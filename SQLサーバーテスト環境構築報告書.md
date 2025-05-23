# SQL Server テスト環境構築報告書

## 構築環境概要

- **Docker コンテナ**: SQL Server 2017
- **データベース名**: UkeharaiDB_Matsuyama
- **スキーマ**: Ukeharai
- **接続情報**: localhost, sa, StrongPassword123!
- **構築日時**: 2025年5月23日 08:56

## 構築手順

1. **Docker コンテナの作成**
   ```bash
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=StrongPassword123!" -p 1433:1433 --name sql_server_test -d mcr.microsoft.com/mssql/server:2017-latest
   ```

2. **データベースの作成**
   ```sql
   CREATE DATABASE UkeharaiDB_Matsuyama;
   GO
   ```

3. **スキーマの作成**
   ```sql
   USE UkeharaiDB_Matsuyama;
   GO
   CREATE SCHEMA Ukeharai;
   GO
   ```

4. **テーブルの作成**
   ```sql
   -- 取引先マスタ
   CREATE TABLE Ukeharai.M_TORI (
       TORI_CD NVARCHAR(10) PRIMARY KEY,
       TORI_NAME NVARCHAR(50) NOT NULL,
       SEIKYU_TYPE NVARCHAR(1) NOT NULL,
       RITU DECIMAL(5,2) NOT NULL,
       HASU_KBN NVARCHAR(1) NOT NULL
   );

   -- 請求ヘッダ
   CREATE TABLE Ukeharai.T_SEIKYU (
       TORI_CD NVARCHAR(10) NOT NULL,
       SEIKYU_YYYYMM NVARCHAR(6) NOT NULL,
       SEIKYU_TYPE NVARCHAR(1) NOT NULL,
       SEIKYU_NO NVARCHAR(10) NOT NULL,
       KAZEI DECIMAL(12,0) NOT NULL,
       HIKAZEI DECIMAL(12,0) NOT NULL,
       SYOHIZEI DECIMAL(12,0) NOT NULL,
       GOUKEI DECIMAL(12,0) NOT NULL,
       PRIMARY KEY (TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO)
   );

   -- 請求明細
   CREATE TABLE Ukeharai.T_SEIKYUM (
       TORI_CD NVARCHAR(10) NOT NULL,
       SEIKYU_YYYYMM NVARCHAR(6) NOT NULL,
       SEIKYU_TYPE NVARCHAR(1) NOT NULL,
       SEIKYU_NO NVARCHAR(10) NOT NULL,
       KUBUN NVARCHAR(2) NOT NULL,
       UCHIWAKE NVARCHAR(50) NOT NULL,
       SURYO DECIMAL(12,2) NOT NULL,
       TANI NVARCHAR(10) NULL,
       TANKA DECIMAL(12,2) NOT NULL,
       KINGAKU DECIMAL(12,0) NOT NULL,
       KAZEI_KBN NVARCHAR(1) NOT NULL,
       MEISAI_UMU NVARCHAR(1) NOT NULL,
       SAKU_KBN NVARCHAR(1) NOT NULL,
       PRIMARY KEY (TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KUBUN)
   );
   ```

5. **テストデータの投入**
   ```sql
   -- 取引先マスタ
   INSERT INTO Ukeharai.M_TORI (TORI_CD, TORI_NAME, SEIKYU_TYPE, RITU, HASU_KBN) VALUES
   ('10001', '株式会社テスト1', '1', 10.00, '1'),  -- 四捨五入
   ('10002', '株式会社テスト2', '1', 10.00, '2'),  -- 切り捨て
   ('10003', '株式会社テスト3', '1', 10.00, '3');  -- 切り上げ

   -- 請求ヘッダ
   INSERT INTO Ukeharai.T_SEIKYU (TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KAZEI, HIKAZEI, SYOHIZEI, GOUKEI) VALUES
   ('10001', '202504', '1', '0000000001', 10000, 0, 1000, 11000);

   -- 請求明細（テストケース）
   INSERT INTO Ukeharai.T_SEIKYUM (TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KUBUN, UCHIWAKE, SURYO, TANI, TANKA, KINGAKU, KAZEI_KBN, MEISAI_UMU, SAKU_KBN) VALUES
   -- 通常ケース
   ('10001', '202504', '1', '0000000001', '01', 'テスト品目1', 10, '個', 1000, 10000, '1', '1', '2'),
   -- 大きな数値
   ('10001', '202504', '1', '0000000001', '02', 'テスト品目2', 9999999, '個', 1000, 9999999000, '1', '1', '2'),
   -- 小数点以下
   ('10001', '202504', '1', '0000000001', '03', 'テスト品目3', 1.5, '個', 1000, 1500, '1', '1', '2'),
   -- 負の値
   ('10001', '202504', '1', '0000000001', '04', 'テスト品目4', -10, '個', 1000, -10000, '1', '1', '2'),
   -- ゼロ値
   ('10001', '202504', '1', '0000000001', '05', 'テスト品目5', 0, '個', 1000, 0, '1', '1', '2'),
   -- 異なる端数処理（切り捨て）
   ('10002', '202504', '1', '0000000001', '01', 'テスト品目1', 10.5, '個', 1000, 10000, '1', '1', '2'),
   -- 異なる端数処理（切り上げ）
   ('10003', '202504', '1', '0000000001', '01', 'テスト品目1', 10.5, '個', 1000, 11000, '1', '1', '2');
   ```

6. **アプリケーション設定の更新**
   ```xml
   <xDataBase>
     <DBName>UkeharaiDB_Matsuyama</DBName>
     <ServerName>localhost</ServerName>
     <UserId>sa</UserId>
     <PassWord>StrongPassword123!</PassWord>
   </xDataBase>
   ```

## テスト検証結果

### コード検証

1. **自動計算機能**
   - `RegisterSeikyuMasterForm.vb`の`UcDgv_CellEndEdit`メソッドに実装
   - 数量（SURYO）と単価（TANKA）から金額（KINGAKU）を自動計算
   - 取引先マスタの端数処理区分（HASU_KBN）に基づいて端数処理を実施
   - Common.hasu()メソッドを使用して適切な端数処理を適用

2. **入力促進機能**
   - 未入力フィールド（SURYO、TANKA、TANI）の背景色をMistyRoseに変更
   - 値が入力されると背景色が通常色に戻る

3. **手入力防止機能**
   - `changeGridview`メソッドでKINGAKUフィールドを常に読み取り専用に設定
   - 背景色をグレー（_bkcolor_readonly）に設定

4. **請求書フォーマット修正**
   - `OutputSeikyuReportS.rdlc`で数量と単位を分離
   - 数量と単位の間に縦線を追加
   - 数量は右寄せ、単位は左寄せで表示

### 実行環境の制約

Monoを使用したアプリケーションの直接実行は、X-Serverが必要なため、ヘッドレス環境では実行できませんでした。代替手段として、コードの直接検証とデータベースのテストデータ検証を行いました。

## 今後の課題

1. **GUIテスト環境の構築**
   - X-Server対応のテスト環境またはWindows環境でのテスト実施

2. **パフォーマンステスト**
   - 大量データ処理時のパフォーマンス検証
   - 複数ユーザーによる同時操作時の動作確認

3. **長期運用テスト**
   - 長期間の使用による安定性の検証
   - バックアップと復元のテスト

## 添付資料

- テスト計画書
- テスト結果報告書
- Config.xml設定ファイル
