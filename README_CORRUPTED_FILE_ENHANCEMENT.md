# 破損ファイル対応マクロ強化版

## 概要

このプロジェクトは、元のExcelマクロ（ver6.xlsm）の `folder()` 関数を拡張し、破損したExcelファイルやCSVファイルでも強制的にマージ処理を継続できるように改良したものです。

## 主要機能

### 🔧 3段階エラー処理システム
1. **通常オープン**: 標準的なファイル読み込み
2. **修復モード**: Excel内蔵の修復機能を使用
3. **データ抽出モード**: 破損ファイルからデータのみを強制抽出

### 📊 強化されたデータ処理
- 値のみペースト（数式参照を自動除去）
- 非表示シートも自動処理
- シート単位でのエラー処理継続

### 💾 自動バックアップ機能
- 処理開始前の自動バックアップ作成
- タイムスタンプ付きファイル名生成

### 📝 詳細ログ機能
- 処理状況の詳細記録
- エラー原因の特定と記録
- ログファイルの自動保存

## ファイル構成

```
├── enhanced_folder_macro.vb           # 強化版VBAマクロコード
├── CORRUPTED_FILE_HANDLING_GUIDE.md  # 詳細実装ガイド
└── README_CORRUPTED_FILE_ENHANCEMENT.md  # このファイル
```

## クイックスタート

### 1. 実装方法

1. **バックアップ作成**
   ```
   元のver6.xlsmファイルをコピーして保存
   ```

2. **VBAコードの追加**
   ```vba
   ' VBAエディタ（Alt + F11）を開く
   ' enhanced_folder_macro.vb の内容をコピー&ペースト
   ```

3. **マクロの実行**
   ```vba
   ' 拡張版の実行
   Call folder_enhanced()
   
   ' 元の名前での実行（互換性維持）
   Call folder()
   ```

### 2. 使用方法

1. 処理対象ファイルを1つのフォルダに配置
2. マクロを実行
3. バックアップ作成の確認（推奨：Yes）
4. 対象フォルダを選択
5. 自動処理開始
6. 結果ログの確認

## 技術仕様

### 対応ファイル形式
- Excel形式: `.xls`, `.xlsx`, `.xlsm`
- CSV形式: `.csv`

### エラー処理レベル
- **レベル1**: 通常読み込み失敗時の修復モード移行
- **レベル2**: 修復失敗時のデータ抽出モード移行
- **レベル3**: シート単位でのエラースキップ継続

### パフォーマンス最適化
```vba
Application.ScreenUpdating = False      ' 画面更新停止
Application.DisplayAlerts = False       ' 警告ダイアログ非表示
Application.EnableEvents = False        ' イベント処理停止
Application.Calculation = xlCalculationManual  ' 計算処理停止
```

## 破損ファイル対応の仕組み

### 段階的処理フロー

```mermaid
graph TD
    A[ファイル検出] --> B[通常オープン試行]
    B --> C{成功?}
    C -->|Yes| D[データコピー]
    C -->|No| E[修復モード試行]
    E --> F{成功?}
    F -->|Yes| D
    F -->|No| G[データ抽出モード試行]
    G --> H{成功?}
    H -->|Yes| D
    H -->|No| I[エラーログ記録]
    D --> J[次のファイル処理]
    I --> J
```

### エラー処理の詳細

```vba
Function ProcessFileWithErrorHandling(filePath As String, ByRef errorLog As String, processedCount As Integer, errorCount As Integer) As Boolean
    For attempt = 1 To 3
        On Error GoTo ErrorHandler
        
        Select Case attempt
            Case 1: Set wb = Workbooks.Open(filePath, ReadOnly:=True)
            Case 2: Set wb = Workbooks.Open(filePath, CorruptLoad:=xlRepairFile)
            Case 3: Set wb = Workbooks.Open(filePath, CorruptLoad:=xlExtractData)
        End Select
        
        If CopyDataSafely(wb, targetWs, fileName, errorLog) Then
            ProcessFileWithErrorHandling = True
            Exit For
        End If
        
ErrorHandler:
        Resume Next
    Next attempt
End Function
```

## テスト方法

### 破損ファイルの作成方法

1. **軽微な破損**
   ```bash
   # ファイル末尾の削除
   truncate -s -100 normal_file.xlsx
   ```

2. **重度の破損**
   ```bash
   # ランダムデータの挿入
   dd if=/dev/urandom of=corrupted_file.xlsx bs=1024 count=1 seek=50
   ```

3. **CSV文字化け**
   ```bash
   # 異なる文字コードでの保存
   iconv -f UTF-8 -t SHIFT-JIS input.csv > corrupted.csv
   ```

### テスト手順

1. 正常ファイルと破損ファイルを混在させたフォルダを準備
2. マクロを実行
3. 処理ログで成功/失敗の詳細を確認
4. 生成されたワークシートでデータの整合性を確認

## トラブルシューティング

### よくある問題

| 問題 | 原因 | 解決方法 |
|------|------|----------|
| メモリ不足エラー | 大量ファイル処理 | 分割処理、オブジェクト解放強化 |
| ファイルロックエラー | 他プロセスでの使用 | ReadOnlyモード強制 |
| 文字化け | 文字コード不一致 | 複数エンコーディング試行 |
| シート名重複 | 同名ファイル存在 | 連番付き安全名生成 |

### ログの読み方

```
=== マージ処理ログ ===
処理開始時刻: 2024/12/03 10:30:00
対象フォルダ: C:\TestFiles\

処理中: file1.xlsx
  ✓ 成功: file1.xlsx (試行1回目)
    データコピー完了: 3シート処理

処理中: corrupted.xlsx
  → 修復モードで再試行: corrupted.xlsx
  ✓ 成功: corrupted.xlsx (試行2回目)
    データコピー完了: 2シート処理

処理中: broken.xlsx
  → 修復モードで再試行: broken.xlsx
  → データ抽出モードで再試行: broken.xlsx
  ✗ 失敗: broken.xlsx - 全ての方法で開けませんでした

=== 処理完了 ===
成功: 2 ファイル
エラー: 1 ファイル
合計: 3 ファイル
```

## 貢献方法

1. このリポジトリをフォーク
2. 機能ブランチを作成 (`git checkout -b feature/new-feature`)
3. 変更をコミット (`git commit -am 'Add new feature'`)
4. ブランチにプッシュ (`git push origin feature/new-feature`)
5. プルリクエストを作成

## ライセンス

このプロジェクトは元のver6.xlsmマクロの拡張版として開発されています。

## サポート

問題や質問がある場合は、以下の方法でサポートを受けることができます：

1. **GitHub Issues**: バグ報告や機能要求
2. **ドキュメント**: `CORRUPTED_FILE_HANDLING_GUIDE.md` の詳細ガイド
3. **ログファイル**: 自動生成されるログファイルでの問題特定

---

**注意**: このマクロは破損ファイルからのデータ抽出を試みますが、重度に破損したファイルからは完全なデータ復旧ができない場合があります。重要なデータについては、定期的なバックアップの作成を強く推奨します。
