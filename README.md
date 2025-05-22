# Devin_Iseki

## IbUkeharai プロジェクト詳細分析

### システム概要
IbUkeharaiは受払管理システム（在庫管理システム）として、.NET Framework 4.6を使用したWindowsフォームアプリケーションです。主に取引先、部品、単価などのマスタ管理と、受入・払出データの処理、帳票出力機能を提供しています。

### プロジェクト構成
システムは3つの主要サブプロジェクトで構成されています：
- **IbUkeharai**: メインアプリケーション（UI、ビジネスロジック）
- **DitCore**: 共通ユーティリティ（設定管理、ダイアログなど）
- **DitDataAccess**: データベースアクセス層

### データベース構造
Ukeharaiスキーマ内に以下の主要テーブルが存在します：

#### マスタテーブル
- **M_TORI**: 取引先マスタ（TORI_CD, TORI_NAME, SEIKYU_TYPE, RITU, HASU_KBN）
- **M_BUHIN**: 部品マスタ（TORI_CD, BUHIN_CD, BUHIN_NAME, TANA_NO1-3）
- **M_SAKI**: 納入先マスタ（SAKI_CD, SAKI_NAME）
- **M_TANKA**: 単価マスタ（TORI_CD, BUHIN_CD, SAKI_CD, YUKO_FM, YUKO_TO, SAGYO）
- **M_JOSU**: 請求書連番管理（SEQNUM）

#### トランザクションテーブル
- **T_UKEHARAIMEISAI**: 受払明細（TORI_CD, BUHIN_CD, UKEHARA_YYYYMMDD, DEN_NO, UKEHARAI_KBN, KOSU, SAKI_CD, KINGAKU, TESU）
- **T_UKEHARAIJISSEKI**: 受払実績（TORI_CD, BUHIN_CD, UKEHARA_YYYYMM, UKESU, HARASU）
- **T_SEIKYU**: 請求ヘッダ（TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KAZEI, HIKAZEI, SYOHIZEI, GOUKEI）
- **T_SEIKYUM**: 請求明細
- **T_KEPPIN**: 欠品部品情報
- **T_BUHINSINDO**: 部品進度
- **T_SISAN**: 資産
- **T_CYUZAN**: 注残

### データフロー

#### 受入データ処理フロー
1. CSVファイルから受入データを読み込み
2. 取引先マスタ（M_TORI）で取引先コード検証
3. 部品マスタ（M_BUHIN）で部品コード検証
4. 検証済みデータをT_UKEHARAIMEISAIテーブルに登録
5. 処理結果をOK/ERRファイルに出力
6. 元ファイルをバックアップ

#### 払出データ処理フロー
1. 固定長テキストファイルから払出データを読み込み（SN41A00クラスで解析）
2. 取引先マスタ（M_TORI）で取引先コード検証
3. 部品マスタ（M_BUHIN）で部品コード検証
4. 単価マスタ（M_TANKA）で単価情報取得
5. 検証済みデータをT_UKEHARAIMEISAIテーブルに登録（UKEHARAI_KBN="2"）
6. 処理結果をOK/ERRファイルに出力
7. 元ファイルをバックアップ

#### 帳票出力フロー
1. 帳票条件（取引先、期間など）を指定
2. SQLクエリでデータ取得
3. Microsoft.Reporting.WinFormsを使用してRDLCテンプレートにデータバインド
4. ReportViewerコンポーネントで表示・印刷

### バッチ処理機能
- **BatchUkeireDataWritForm**: 受入データ一括処理
- **BatchHaraiDataWritForm**: 払出データ一括処理
- **BatchJissekiForm**: 実績データ一括処理
- **UkeHaraiDataWrit**: 受払データ書き込み処理エンジン

### 特徴的な実装パターン
1. **固定長データ処理**: SN41A00, CYUZANなどのクラスで固定長テキストデータを構造化
2. **トランザクション管理**: SqlDataBaseクラスによるBeginTransaction/CommitTransact/RollBackTransactの実装
3. **エラーハンドリング**: 詳細なエラーチェックと結果ファイル出力
4. **設定管理**: Config.xmlによるデータベース接続情報などの管理
5. **マルチロケーション対応**: 松山、熊本、重信などの拠点別設定

### レポート生成
- RDLC形式のレポートテンプレート使用
- 複数のデータソースをバインド（ヘッダー・明細など）
- ReportParameterによる動的パラメータ設定
- 印刷前の請求番号自動採番機能

### 主要な機能グループ
1. **登録機能**: 取引先、部品、単価、請求、納入マスタ管理
2. **データ作成**: 日別/月別の取引先受払データ作成
3. **帳票出力**: 請求書、実績表、在庫リスト
4. **照会機能**: 受払実績、欠品部品情報の照会
5. **バッチ処理**: 受入/払出データ一括処理、月次/年次データ処理

このシステムは、製造業における部品の受入・払出管理、在庫管理、請求書発行を統合的に行うための包括的なソリューションとなっています。
