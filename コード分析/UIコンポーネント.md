# IbUkeharai システム - UIコンポーネント
   
## 1. カスタムコントロール
   
### 1.1 CustomDataGridView
DataGridViewを拡張したカスタムコントロール。以下の機能を提供：
- 行番号の表示
- セルの背景色による入力状態の視覚化
- 変更検知機能（IsChanged）
- セル入力検証

主要なメソッド：
- SetCellBackColor: セルの背景色を設定
- OnCellValidating: セル入力検証
- OnCellEndEdit: セル編集完了時の処理
   
### 1.2 UcDataGridView
CustomDataGridViewをラップするUserControl。以下の機能を提供：
- ステータスバーによるメッセージ表示
- セル編集イベントの伝播
- 行追加・削除イベント処理

主要なイベント：
- CellEndEdit: セル編集完了時に発生
- RowAdded: 行追加時に発生
- RowDeleted: 行削除時に発生
   
### 1.3 ControlDataGridView
データグリッドの制御とデータベース連携を担当。以下の機能を提供：
- データの読み込みと表示
- データの検証
- データベース更新（UpdateGridView）

主要なメソッド：
- UpdateGridView: データベース更新処理
- LoadData: データの読み込み
- ValidateData: データの検証

## 2. 入力検証機能

### 2.1 必須入力チェック
未入力フィールドの背景色をMistyRoseに変更して入力を促す機能。

```vb
' 数量の検証
If IsNothing(dataGridViewRow.Cells("SURYO").Value) OrElse 
   String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("SURYO").Value)) Then
    dataGridViewRow.Cells("SURYO").Style.BackColor = Color.MistyRose
    hasValue = False
Else
    Decimal.TryParse(Conversions.ToString(dataGridViewRow.Cells("SURYO").Value), suryo)
    dataGridViewRow.Cells("SURYO").Style.BackColor = Me._bkcolor_normal
End If
```

### 2.2 コード値チェック
マスタテーブルに存在するコード値かどうかをチェックする機能。

```vb
' 取引先コードの検証
Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
    Dim sql As String = "SELECT COUNT(*) FROM Ukeharai.M_TORI WHERE TORI_CD = '" & toriCd & "'"
    If sqlDataBase.execSql(sql) Then
        If CInt(sqlDataBase.DbData.DataList(0)(0)) = 0 Then
            MessageBox.Show("取引先コードが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End If
End Using
```

### 2.3 日付チェック
日付形式の妥当性をチェックする機能。

```vb
' 日付の検証
Dim date_str As String = Conversions.ToString(dataGridViewRow.Cells("UKEHARA_YYYYMMDD").Value)
If Not IsDate(date_str.Substring(0, 4) & "/" & date_str.Substring(4, 2) & "/" & date_str.Substring(6, 2)) Then
    MessageBox.Show("日付の形式が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Return False
End If
```

## 3. レポート表示機能

### 3.1 ReportViewer
Microsoft Reporting Servicesを使用したレポート表示機能。

```vb
' レポートの表示
Private Sub ShowReport()
    ' レポートビューアの設定
    Me.ReportViewer1.ProcessingMode = ProcessingMode.Local
    Me.ReportViewer1.LocalReport.ReportPath = "OutputSeikyuReportS.rdlc"
    
    ' データソースの設定
    Dim dataSource As New ReportDataSource("DataSet1", _dataTable)
    Me.ReportViewer1.LocalReport.DataSources.Clear()
    Me.ReportViewer1.LocalReport.DataSources.Add(dataSource)
    
    ' レポートの更新と表示
    Me.ReportViewer1.RefreshReport()
End Sub
```

### 3.2 RDLCテンプレート
レポートのレイアウトを定義するRDLCファイル。数量と単位の表示方法などを定義。

```xml
<!-- 数量の表示 -->
<Textbox Name="SURYO">
  <Value>=Format(Fields!SURYO.Value,"#,###")</Value>
  <Style>
    <TextAlign>Right</TextAlign>
  </Style>
</Textbox>

<!-- 単位の表示 -->
<Textbox Name="TANI">
  <Value>=Fields!TANI.Value</Value>
  <Style>
    <TextAlign>Left</TextAlign>
  </Style>
</Textbox>
```
