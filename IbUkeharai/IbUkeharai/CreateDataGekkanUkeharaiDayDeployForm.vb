Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class CreateDataGekkanUkeharaiDayDeployForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CreatDataGekkanUkeharaiDayDeployForm_Load
			Me.csvDirectory = Path.Combine("csv", "52.取引先別受払データ作成(月間日別展開)")
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub
#Region " フォーム "
		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.FormTitleLabel = New Label()
			Me.SpecifiedDateLabel = New Label()
			Me.TorihikiLabel = New Label()
			Me.CTUG_BackButton = New Button()
			Me.CTUG_ExecutButton = New Button()
			Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.FormTitleLabel.BackColor = Color.SlateBlue
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
			Me.FormTitleLabel.Location = New Point(12, 9)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(760, 45)
			Me.FormTitleLabel.TabIndex = 5
			Me.FormTitleLabel.Text = "取引先別受払データ作成(月間日別展開)"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(35, 122)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(74, 18)
			Me.SpecifiedDateLabel.TabIndex = 36
			Me.SpecifiedDateLabel.Text = "指定年月"
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(35, 79)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(97, 18)
			Me.TorihikiLabel.TabIndex = 34
			Me.TorihikiLabel.Text = "取引先コード"
			'
			'CTUG_BackButton
			'
			Me.CTUG_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CTUG_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CTUG_BackButton.Location = New Point(687, 520)
			Me.CTUG_BackButton.Name = "CTUG_BackButton"
			Me.CTUG_BackButton.Size = New Size(80, 30)
			Me.CTUG_BackButton.TabIndex = 5
			Me.CTUG_BackButton.Text = "戻る"
			Me.CTUG_BackButton.UseVisualStyleBackColor = True
			'
			'CTUG_ExecutButton
			'
			Me.CTUG_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CTUG_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CTUG_ExecutButton.Location = New Point(586, 520)
			Me.CTUG_ExecutButton.Name = "CTUG_ExecutButton"
			Me.CTUG_ExecutButton.Size = New Size(80, 30)
			Me.CTUG_ExecutButton.TabIndex = 3
			Me.CTUG_ExecutButton.Text = "実行"
			Me.CTUG_ExecutButton.UseVisualStyleBackColor = True
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(138, 117)
			Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(120, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'ComboTori1
			'
			Me.ComboTori1.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.ComboTori1.AutoCompleteSource = AutoCompleteSource.ListItems
			Me.ComboTori1.BackColor = Color.LightGoldenrodYellow
			Me.ComboTori1.ColumnCode = "TORI_CD"
			Me.ComboTori1.ColumnName = "TORI_NAME"
			Me.ComboTori1.FlatStyle = FlatStyle.Popup
			Me.ComboTori1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ComboTori1.FormattingEnabled = True
			Me.ComboTori1.ImeMode = ImeMode.Disable
			Me.ComboTori1.Location = New Point(138, 76)
			Me.ComboTori1.MaxLength = 8
			Me.ComboTori1.Name = "ComboTori1"
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 1
			Me.ComboTori1.TableName = "M_TORI"
			'
			'CreateDataGekkanUkeharaiDayDeployForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.CTUG_BackButton)
			Me.Controls.Add(Me.CTUG_ExecutButton)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "CreateDataGekkanUkeharaiDayDeployForm"
			Me.Text = "月刊受払日別展開データ作成画面"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Private Sub CreatDataGekkanUkeharaiDayDeployForm_Load(sender As Object, e As EventArgs)
			Dim cclDateTimePicker As CclDateTimePicker = Me.CclDateTimePicker
			Dim dateTime As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
			cclDateTimePicker.Value = dateTime
			Me.ComboTori1.SetToriItemList()
		End Sub

		Private Function makeSql(toricd As String, syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			Dim stringBuilder2 As New StringBuilder()
			Dim dateTime As New DateTime(syoriym.Year, syoriym.Month, 1)
			Dim dateTime2 As DateTime = dateTime
			Dim syoriymd As DateTime = dateTime2.AddMonths(1).AddDays(-1.0)
			Dim arg As String = syoriymd.ToString("yyyy/MM/dd")
			stringBuilder.Append("SELECT ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                             AS 取引先コード, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(TOR.TORI_NAME)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                             AS 取引先名, ")
			stringBuilder.Append(vbTab & vbTab & "MEI.BUHIN_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                             AS 部品コード, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.BUHIN_NAME) " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                             AS 部品名称, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO1)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                         AS 棚番１, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO2)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                         AS 棚番２, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO3)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                             AS 棚番３, ")
			Dim stringBuilder3 As StringBuilder = stringBuilder
			syoriymd = New DateTime(syoriym.Year, syoriym.Month, 1)
			stringBuilder3.Append(ZaikosuCommon.GetZaikoSubquery(syoriymd, "MEI", False) + " AS 前月末在庫, ")
			Dim num As Integer = 1
			Do
				stringBuilder2.Clear()
				stringBuilder2.Append("SUM(CASE WHEN DAY(MEI.UKEHARA_YYYYMMDD) = {0} AND MEI.UKEHARAI_KBN = '1' ")
				stringBuilder2.Append(vbTab & vbTab & " THEN ISNULL(MEI.KOSU, 0) ELSE 0 END)                                            AS '日付({0}日)分：受入数', ")
				stringBuilder2.Append("SUM(CASE WHEN DAY(MEI.UKEHARA_YYYYMMDD) = {0} AND MEI.UKEHARAI_KBN = '2' ")
				stringBuilder2.Append(vbTab & vbTab & " THEN ISNULL(MEI.KOSU, 0) ELSE 0 END)                                            AS '日付({0}日)分：払出数', ")
				stringBuilder.Append(String.Format(stringBuilder2.ToString(), num))
				num += 1
			Loop While num <= 31
			stringBuilder.Append("     SUM(CASE WHEN MEI.UKEHARAI_KBN = '1' THEN KOSU ")
			stringBuilder.Append("              WHEN MEI.UKEHARAI_KBN = '2' THEN -KOSU ")
			stringBuilder.Append("              ELSE 0 END)                                                                     AS 在庫数 ")
			stringBuilder.Append("FROM  ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[T_UKEHARAIMEISAI] AS MEI ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_TORI] AS TOR ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD = TOR.TORI_CD ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_BUHIN] AS BUH ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD = BUH.TORI_CD ")
			stringBuilder.Append(vbTab & "AND ")
			stringBuilder.Append(vbTab & vbTab & "MEI.BUHIN_CD = BUH.BUHIN_CD ")
			stringBuilder.Append("WHERE ")
			stringBuilder.Append(vbTab & vbTab & "MEI.UKEHARA_YYYYMMDD >= '{0}' ")
			stringBuilder.Append(vbTab & "AND ")
			stringBuilder.Append(vbTab & vbTab & "MEI.UKEHARA_YYYYMMDD <= '{1}' ")
			If Not String.IsNullOrEmpty(toricd) Then
				stringBuilder.Append(vbTab & "AND ")
				stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD = '{2}' ")
			End If
			stringBuilder.Append("GROUP BY ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "MEI.BUHIN_CD ")
			stringBuilder.Append("ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "MEI.BUHIN_CD ")
			Dim result As String
			If Not String.IsNullOrEmpty(toricd) Then
				result = String.Format(stringBuilder.ToString(), syoriym.ToString("yyyy/MM/01"), arg, toricd)
			Else
				result = String.Format(stringBuilder.ToString(), syoriym.ToString("yyyy/MM/01"), arg)
			End If
			Return result
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("CTUG_BackButton")>
		Private WithEvents CTUG_BackButton As Button

		<AccessedThroughProperty("CTUG_ExecutButton")>
		Private WithEvents CTUG_ExecutButton As Button

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		Private Const ALL_MANUFACTURER As String = "全メーカー"

		Private Const CSV_FILE_NAME As String = "52.取引先別受払データ作成(月間日別展開)_{0}_{1}{2}.csv"

		Private csvDirectory As String

		Private Sub CTUG_ExecutButton_Click(sender As Object, e As EventArgs) Handles CTUG_ExecutButton.Click
			Dim syoriym As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			Dim itemInfomation As ItemInfomation = CType(Me.ComboTori1.SelectedItem, ItemInfomation)
			If Me.ComboTori1.SelectedIndex <= 0 Then
				DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.ComboTori1.Focus()
				Return
			End If
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年月を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclDateTimePicker.Focus()
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Dim configData As XmlConfigControl = TopForm.ConfigData
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(configData.xmlConfData.xDataBase)
				Dim text As String
				If itemInfomation.Code.Equals("全メーカー") Then
					text = Me.makeSql("", syoriym)
				Else
					text = Me.makeSql(itemInfomation.Code, syoriym)
				End If
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Cursor.Current = Cursors.[Default]
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
					Return
				End If
				If sqlDataBase.DbDataTable.Rows.Count = 0 Then
					DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Cursor.Current = Cursors.[Default]
					Return
				End If
				dbDataTable = sqlDataBase.DbDataTable
			End Using
			Try
				For Each obj As Object In dbDataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					dataRow("在庫数") = Operators.AddObject(dataRow("在庫数"), dataRow("前月末在庫"))
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim text2 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text2) Then
				Directory.CreateDirectory(text2)
			End If
			Dim csvPath As String
			If itemInfomation.Code.Equals("全メーカー") Then
				csvPath = Path.Combine(text2, String.Format("52.取引先別受払データ作成(月間日別展開)_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), "", "全メーカー"))
			Else
				csvPath = Path.Combine(text2, Common.EscapeInvalidFileName(String.Format("52.取引先別受払データ作成(月間日別展開)_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), itemInfomation.Code, itemInfomation.Name)))
			End If
			Dim csvCommon As New CsvCommon()
			Dim flag As Boolean = csvCommon.ConvertDataTableToCsv(dbDataTable, csvPath, True)
			Cursor.Current = Cursors.[Default]
			If Not flag Then
				DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				DlgMessageBox.Show("CSV出力が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		Private Sub CTUG_BackButton_Click(sender As Object, e As EventArgs) Handles CTUG_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
