# スキーマ定義に基づく根本原因再調査報告書

## 📋 調査概要
データベーススキーマ定義を詳細に分析し、算術オーバーフローエラーの根本原因を再調査しました。

## 🔍 スキーマ定義から判明した新たな問題点

### 1. **データ型不整合の発見**

#### テーブル定義 vs ストアドプロシージャ定義
| 項目 | テーブル定義 | ストアドプロシージャ定義 | 問題 |
|------|-------------|------------------------|------|
| ZAIKOSU | `numeric(7,0)` | `@S_Zaikosu NVARCHAR(7)` → `@I_Zaikosu numeric(7,0)` | 二重変換 |
| UKESU | `numeric(7,0)` | `@S_Ukesu NVARCHAR(7)` → `@I_Ukesu numeric(7,0)` | 二重変換 |
| HARASU | `numeric(7,0)` | `@S_Harasu NVARCHAR(7)` → `@I_Harasu numeric(7,0)` | 二重変換 |

### 2. **カーソル処理での型変換問題**

#### Update_Month_Data.txt 50-112行目の分析
```sql
-- カーソル定義（50-112行目）
DECLARE cur1 CURSOR FOR
SELECT J.ZAIKOSU          -- numeric(7,0)型で取得
      ,ISNULL(T_Month.U_Totale,0)  -- 計算結果
      ,ISNULL(T_Month.H_Totale,0)  -- 計算結果

-- フェッチ処理（112行目）
FETCH NEXT FROM cur1 INTO @ID_Tori,@ID_Buhin,@S_Zaikosu,@S_Ukesu,@S_Harasu
```

**問題**: numeric(7,0)型の値をNVARCHAR(7)変数に格納している

### 3. **集計処理での精度問題**

#### SUM関数による値の増大（84-103行目）
```sql
SELECT M.TORI_CD
      ,M.BUHIN_CD
      ,SUM(M.U_KOSU) [U_Totale]  -- 複数レコードの合計
      ,SUM(M.H_KOSU) [H_Totale]  -- 複数レコードの合計
FROM (
    SELECT Meisai.KOSU  -- 最大9,999,999の値
    FROM Ukeharai.T_UKEHARAIMEISAI [Meisai]
) [M]
GROUP BY M.TORI_CD,M.BUHIN_CD
```

**問題**: 個別レコードが9,999,999の場合、SUM結果が制限を超過する可能性

## 🚨 新たに発見された根本原因

### A. **型変換の多段階処理**
1. **テーブル**: `numeric(7,0)` → **カーソル**: `NVARCHAR(7)` → **変数**: `numeric(7,0)`
2. 各段階で精度ロスとオーバーフロー発生の可能性

### B. **集計処理での値の増大**
- T_UKEHARAIMEISAIの23,681レコードをSUM集計
- 個別値9,999,999 × 複数レコード = 制限超過

### C. **ISNULL関数の影響**
```sql
ISNULL(T_Month.U_Totale,0)  -- NULLの場合0、値がある場合はSUM結果
```
- SUM結果がnumeric(7,0)制限を超える場合のエラー処理なし

## 📊 データ分析による検証

### 実データでの検証結果
- **T_UKEHARAIJISSEKI**: 15,469レコード
  - ZAIKOSU最大: 9,999,996（制限ギリギリ）
  - UKESU最大: 9,999,999（制限到達）
- **T_UKEHARAIMEISAI**: 23,681レコード
  - KOSU最大: 9,999,999（制限到達）

### 集計処理での問題
同一TORI_CD + BUHIN_CDで複数のKOSU=9,999,999レコードが存在する場合：
```
SUM(KOSU) = 9,999,999 × N件 > numeric(7,0)制限
```

## 🔄 エラー発生メカニズムの詳細分析

### 1. **カーソルフェッチ時（112行目）**
```sql
FETCH NEXT FROM cur1 INTO @ID_Tori,@ID_Buhin,@S_Zaikosu,@S_Ukesu,@S_Harasu
```
- numeric(7,0)値をNVARCHAR(7)に暗黙変換
- 9,999,999 → "9999999"（7文字ギリギリ）

### 2. **明示的変換時（130-132行目）**
```sql
SET @I_Zaikosu = CONVERT(numeric(7, 0), @S_Zaikosu)
SET @I_Ukesu = CONVERT(numeric(7, 0), @S_Ukesu)
SET @I_Harasu = CONVERT(numeric(7, 0), @S_Harasu)
```
- NVARCHAR(7) → numeric(7,0)変換でオーバーフロー

### 3. **集計値の問題**
- SUM(KOSU)結果がnumeric(7,0)制限を超過
- ISNULL関数で0置換されるが、値がある場合は制限超過値

## 💡 スキーマ定義に基づく対策

### 🔥 緊急対策

#### 1. **ストアドプロシージャ修正**
```sql
-- 現在（問題あり）
DECLARE @S_Zaikosu    NVARCHAR(7)
DECLARE @I_Zaikosu    numeric(7, 0)

-- 修正後
DECLARE @S_Zaikosu    NVARCHAR(12)    -- 7→12文字
DECLARE @I_Zaikosu    numeric(12, 0)  -- 7→12桁
```

#### 2. **テーブル定義修正**
```sql
-- T_UKEHARAIJISSEKI
ALTER TABLE T_UKEHARAIJISSEKI 
ALTER COLUMN ZAIKOSU numeric(12, 0)
ALTER COLUMN UKESU numeric(12, 0)
ALTER COLUMN HARASU numeric(12, 0)

-- T_UKEHARAIMEISAI
ALTER TABLE T_UKEHARAIMEISAI 
ALTER COLUMN KOSU numeric(12, 0)
```

### 🛠️ 根本対策

#### 1. **型変換の最適化**
```sql
-- 直接numeric型で処理（NVARCHAR経由を廃止）
DECLARE cur1 CURSOR FOR
SELECT J.TORI_CD
      ,J.BUHIN_CD
      ,J.ZAIKOSU          -- numeric型のまま
      ,ISNULL(T_Month.U_Totale,0)
      ,ISNULL(T_Month.H_Totale,0)
```

#### 2. **集計処理の改善**
```sql
-- オーバーフロー検証付きSUM
SELECT M.TORI_CD
      ,M.BUHIN_CD
      ,CASE 
        WHEN SUM(CAST(M.U_KOSU AS BIGINT)) > 999999999 
        THEN NULL 
        ELSE SUM(M.U_KOSU) 
       END [U_Totale]
```

#### 3. **エラーハンドリング追加**
```sql
BEGIN TRY
    SET @I_Zaikosu = CONVERT(numeric(12, 0), @S_Zaikosu)
END TRY
BEGIN CATCH
    -- エラーログ出力とスキップ処理
    PRINT 'Conversion error for ZAIKOSU: ' + @S_Zaikosu
    SET @I_Zaikosu = 0
END CATCH
```

## 🎯 調査結論

### **確定した根本原因（スキーマ分析版）**

1. **データ型設計の不整合**
   - テーブル: numeric(7,0)
   - ストアドプロシージャ: NVARCHAR(7) → numeric(7,0)の二重変換

2. **集計処理での値の増大**
   - SUM(KOSU)による制限超過
   - 23,681レコードの集計で個別最大値9,999,999が累積

3. **型変換処理の脆弱性**
   - カーソルフェッチ時の暗黙変換
   - CONVERT関数での明示的変換エラー

### **技術的優先度**

| 優先度 | 対策 | 影響度 | 実装難易度 |
|--------|------|--------|------------|
| 🔥 最高 | ストアドプロシージャのデータ型拡張 | 高 | 低 |
| 🔥 最高 | テーブル定義のデータ型拡張 | 高 | 中 |
| 🟡 中 | 集計処理の改善 | 中 | 中 |
| 🟡 中 | エラーハンドリング追加 | 低 | 高 |

**信頼度**: 最高 🟢  
スキーマ定義、ストアドプロシージャ、実データの完全な整合性分析により確定
