# IbUkeharai データベーススキーマ分析

## 📋 概要
現在の調査資料から把握できるIbUkeharaiシステムのデータベーススキーマ構造を詳細に分析しました。

## 🗄️ データベース情報
- **データベース名**: UkeharaiDB_Matsuyama
- **スキーマ**: Ukeharai
- **SQL Server**: Microsoft SQL Server

## 📊 テーブル構造

### 1. T_UKEHARAIJISSEKI（受払実績テーブル）
**用途**: 受払処理の実績データを格納

| カラム名 | データ型 | 説明 | 制約 |
|----------|----------|------|------|
| TORI_CD | NVARCHAR(8) | 取引先コード | NOT NULL |
| BUHIN_CD | NVARCHAR(12) | 部品コード | NOT NULL |
| UKEHARA_YYYYMM | Date | 受払年月 | NOT NULL |
| ZAIKOSU | numeric(7,0) | 在庫数 | 最大9,999,999 |
| UKESU | numeric(7,0) | 受数 | 最大9,999,999 |
| HARASU | numeric(7,0) | 払数 | 最大9,999,999 |
| INSERT_USER | NVARCHAR(50) | 登録ユーザー | |
| INSERT_DTM | DateTime | 登録日時 | |
| INSERT_FUNCTION | NVARCHAR(50) | 登録機能 | |
| UPDATE_USER | NVARCHAR(50) | 更新ユーザー | |
| UPDATE_DTM | DateTime | 更新日時 | |
| UPDATE_FUNCTION | NVARCHAR(50) | 更新機能 | |

**レコード数**: 15,469件（2025年5月分）

### 2. T_UKEHARAIMEISAI（受払明細テーブル）
**用途**: 受払処理の明細データを格納

| カラム名 | データ型 | 説明 | 制約 |
|----------|----------|------|------|
| TORI_CD | NVARCHAR(8) | 取引先コード | NOT NULL |
| BUHIN_CD | NVARCHAR(12) | 部品コード | NOT NULL |
| UKEHARA_YYYYMMDD | Date | 受払年月日 | NOT NULL |
| DEN_NO | NVARCHAR | 伝票番号 | |
| UKEHARAI_KBN | INT | 受払区分 | 1:受入, 2:払出 |
| KOSU | numeric | 個数 | 最大9,999,999 |
| REMARKS1 | NVARCHAR | 備考1 | |
| REMARKS2 | NVARCHAR | 備考2 | |
| REMARKS3 | NVARCHAR | 備考3 | |
| SAKI_CD | NVARCHAR | 先コード | |
| KINGAKU | numeric | 金額 | |
| TESU | numeric | 手数 | |
| INSERT_USER | NVARCHAR(50) | 登録ユーザー | |
| INSERT_DTM | DateTime | 登録日時 | |
| INSERT_FUNCTION | NVARCHAR(50) | 登録機能 | |
| UPDATE_USER | NVARCHAR(50) | 更新ユーザー | |
| UPDATE_DTM | DateTime | 更新日時 | |
| UPDATE_FUNCTION | NVARCHAR(50) | 更新機能 | |

**レコード数**: 23,681件

### 3. M_TORI（取引先マスタテーブル）
**用途**: 取引先の基本情報を管理

| カラム名 | データ型 | 説明 | 制約 |
|----------|----------|------|------|
| TORI_CD | NVARCHAR(8) | 取引先コード | PRIMARY KEY |
| その他のカラム | - | 取引先情報 | |

### 4. M_BUHIN（部品マスタテーブル）
**用途**: 部品の基本情報を管理

| カラム名 | データ型 | 説明 | 制約 |
|----------|----------|------|------|
| TORI_CD | NVARCHAR(8) | 取引先コード | |
| BUHIN_CD | NVARCHAR(12) | 部品コード | |
| その他のカラム | - | 部品情報 | |

## 🔗 テーブル関係

### 主要な関係性
```
M_TORI (取引先マスタ)
  ↓ 1:N
M_BUHIN (部品マスタ)
  ↓ 1:N
T_UKEHARAIJISSEKI (受払実績)
  ↓ 1:N
T_UKEHARAIMEISAI (受払明細)
```

### JOIN関係
- **M_TORI ← M_BUHIN**: `M_Tori.TORI_CD = M_Buhin.TORI_CD`
- **M_BUHIN ← T_UKEHARAIJISSEKI**: `M_Buhin.TORI_CD = Jisseki.TORI_CD AND M_Buhin.BUHIN_CD = Jisseki.BUHIN_CD`
- **T_UKEHARAIJISSEKI ← T_UKEHARAIMEISAI**: `Jisseki.TORI_CD = Meisai.TORI_CD AND Jisseki.BUHIN_CD = Meisai.BUHIN_CD`

## ⚠️ データ型制限の問題

### 確認された制限
1. **NVARCHAR(7)**: 文字列7文字制限
2. **numeric(7,0)**: 数値7桁制限（最大9,999,999）

### 問題のあるデータ
- **ZAIKOSU最大値**: 9,999,996（制限ギリギリ）
- **UKESU最大値**: 9,999,999（制限到達）
- **KOSU最大値**: 9,999,999（制限到達）

## 📝 ストアドプロシージャでの使用

### Update_Month_Data
```sql
-- 変数宣言（問題箇所）
DECLARE @S_Zaikosu    NVARCHAR(7)     -- 7文字制限
DECLARE @I_Zaikosu    numeric(7, 0)   -- 7桁制限

-- 変換処理（エラー発生箇所）
SET @I_Zaikosu = CONVERT(numeric(7, 0), @S_Zaikosu)
```

## 🔍 調査資料の出典

### SQLストアドプロシージャ
- `Ukeharai.Update_Month_Data.txt`: テーブル構造とJOIN関係
- `Ukeharai.Select_Month_Data.txt`: SELECT文でのカラム参照

### データファイル
- `UkeharaiDB_Matsuyama.xlsx`: 実際のテーブル構造とデータ
  - T_UKEHARAIJISSEKIシート: 15,469レコード
  - T_UKEHARAIMEISAIシート: 23,681レコード

### VB.NETコード
- `BatchMonthlyDataForm.vb`: データベースアクセス処理
- パラメータ定義でのデータ型指定

## 📊 データ統計

### T_UKEHARAIJISSEKI
- **ZAIKOSU**: 平均22,187、最大9,999,996（33件が999,999超過）
- **UKESU**: 平均3,234、最大9,999,999（5件が999,999超過）
- **HARASU**: 平均0.48、最大3,000

### T_UKEHARAIMEISAI
- **KOSU**: 平均2,222、最大9,999,999（5件が999,999超過）

## 🎯 結論

現在の調査資料から、IbUkeharaiシステムは以下の特徴を持つデータベース構造であることが確認できました：

1. **階層構造**: マスタ→実績→明細の3層構造
2. **データ型制限**: numeric(7,0)による数値制限が問題の根本原因
3. **大量データ**: 合計約39,000レコードの処理対象
4. **月次処理**: UKEHARA_YYYYMMによる月単位でのデータ管理

**信頼度**: 高 🟢 SQLストアドプロシージャ、実データ、VB.NETコードの三方向から確認済み
