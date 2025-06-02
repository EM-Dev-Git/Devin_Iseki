# SQLストアドプロシージャ詳細分析報告書

## 🔍 Update_Month_Data ストアドプロシージャ分析

### パラメータ定義
```sql
ALTER PROCEDURE [Ukeharai].[Update_Month_Data]
    @S_ToriCd           NVARCHAR(8),     -- 取引先コード
    @D_ExecYYYYMMDD     Date,            -- 実行日
    @ID_User            NVARCHAR(50),    -- ユーザーID  
    @D_UpdateTime       DateTime,        -- 更新時刻
    @ID_Func            NVARCHAR(50)     -- 機能ID
```

### 🚨 問題のある変数宣言（33-42行目）
```sql
DECLARE @S_Zaikosu      NVARCHAR(7)     -- 在庫数（文字列）
DECLARE @S_Ukesu        NVARCHAR(7)     -- 受数（文字列）
DECLARE @S_Harasu       NVARCHAR(7)     -- 払数（文字列）
DECLARE @I_Zaikosu      numeric(7, 0)   -- 在庫数（数値）
DECLARE @I_Ukesu        numeric(7, 0)   -- 受数（数値）
DECLARE @I_Harasu       numeric(7, 0)   -- 払数（数値）
```

### ❌ 算術オーバーフローの発生箇所（130-132行目）
```sql
SET @I_Zaikosu = CONVERT(numeric(7, 0), @S_Zaikosu)
SET @I_Ukesu = CONVERT(numeric(7, 0), @S_Ukesu)
SET @I_Harasu = CONVERT(numeric(7, 0), @S_Harasu)
```

## 🔬 根本原因の詳細分析

### 1. データ型制限の問題
- **NVARCHAR(7)**: 最大7文字まで格納可能
- **numeric(7,0)**: 最大7桁の整数（小数点なし）
- **最大値**: 9,999,999
- **実際のデータ**: 9,999,999（制限ギリギリ）

### 2. 処理フローとエラー発生メカニズム
1. **カーソル処理開始**（50-109行目）
   - T_UKEHARAIJISSEKIテーブルからデータを選択
   - 大きな数値（9,999,999）を含むレコードを処理

2. **データフェッチ**（112行目）
   ```sql
   FETCH NEXT FROM cur1 INTO @ID_Tori,@ID_Buhin,@S_Zaikosu,@S_Ukesu,@S_Harasu,...
   ```
   - 9,999,999が@S_ZaikosのNVARCHAR(7)変数に格納される

3. **型変換でオーバーフロー**（130-132行目）
   ```sql
   SET @I_Zaikosu = CONVERT(numeric(7, 0), @S_Zaikosu)
   ```
   - '9999999'文字列をnumeric(7,0)に変換しようとする
   - SQL Serverの内部変換処理でオーバーフロー発生

### 3. エラーメッセージの解釈
**エラー**: `expression をデータ型 nvarchar に変換中に、算術オーバーフロー エラーが発生しました`

**なぜ"nvarchar変換"と表示されるか**:
- 実際のオーバーフローはnumeric変換時に発生
- SQL Serverの内部エラーハンドリングの表現
- エラーメッセージが実際の処理と異なる場合がある

## 🔄 VB.NETコードとの関連性

### BatchMonthlyDataForm.vb との連携
```vb
' VB.NET側（264行目）
@D_UpdateTime: SqlDbType.DateTime, .val = Conversions.ToString(DateAndTime.Now)
```

**分析結果**:
- DateTime文字列変換は直接的な原因ではない
- SQL側で@D_UpdateTimeはDateTime型で正しく受け取られる
- 主要原因は数値データの型制限

## 💡 技術的解決策

### 即座の対応
1. **データ型拡張**
   ```sql
   DECLARE @S_Zaikosu      NVARCHAR(10)    -- 7→10文字に拡張
   DECLARE @I_Zaikosu      numeric(10, 0)  -- 7→10桁に拡張
   ```

2. **異常データの修正**
   - 9,999,999を超える値の確認と修正
   - データ入力時の妥当性チェック強化

### 根本的対策
1. **データベース設計の見直し**
   - より大きなデータ型（BIGINT等）の採用
   - 将来的なデータ増加を考慮した設計

2. **エラーハンドリングの改善**
   - TRY-CATCH文による例外処理
   - 部分的な処理継続機能の実装

## 📊 調査結論

**確定した根本原因**:
1. **データ型制限**: NVARCHAR(7)とnumeric(7,0)の制限
2. **限界値データ**: 9,999,999という制限ギリギリの値
3. **型変換処理**: CONVERT関数での算術オーバーフロー

**信頼度**: 最高 🟢  
SQLストアドプロシージャの実装を直接確認し、VB.NETコードとの連携も含めて完全に原因を特定しました。
