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
Imports IbUkeharai.IbUkeharai.CateDataExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class ListUkeharaiReporForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ListUkeharaiReporForm_Load
			Me.csvDirectory = Path.Combine("csv", "53.受払報告書")
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
			Me.LUR_SelectAllButton = New Button()
			Me.LUR_ClearButton = New Button()
			Me.SpecifiedDateLabel = New Label()
			Me.LUR_BackButton = New Button()
			Me.LUR_ExecutButton = New Button()
			Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
			Me.UcSelectGridView1 = New IbUkeharai.UcSelectGridView()
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
			Me.FormTitleLabel.TabIndex = 3
			Me.FormTitleLabel.Text = "受払報告書　出力"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'LUR_SelectAllButton
			'
			Me.LUR_SelectAllButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_SelectAllButton.Location = New Point(36, 67)
			Me.LUR_SelectAllButton.Name = "LUR_SelectAllButton"
			Me.LUR_SelectAllButton.Size = New Size(80, 30)
			Me.LUR_SelectAllButton.TabIndex = 0
			Me.LUR_SelectAllButton.Text = "全選択"
			Me.LUR_SelectAllButton.UseVisualStyleBackColor = True
			'
			'LUR_ClearButton
			'
			Me.LUR_ClearButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_ClearButton.Location = New Point(132, 67)
			Me.LUR_ClearButton.Name = "LUR_ClearButton"
			Me.LUR_ClearButton.Size = New Size(80, 30)
			Me.LUR_ClearButton.TabIndex = 1
			Me.LUR_ClearButton.Text = "クリア"
			Me.LUR_ClearButton.UseVisualStyleBackColor = True
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(256, 73)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(61, 18)
			Me.SpecifiedDateLabel.TabIndex = 33
			Me.SpecifiedDateLabel.Text = "指定年月"
			'
			'LUR_BackButton
			'
			Me.LUR_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.LUR_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_BackButton.Location = New Point(687, 520)
			Me.LUR_BackButton.Name = "LUR_BackButton"
			Me.LUR_BackButton.Size = New Size(80, 30)
			Me.LUR_BackButton.TabIndex = 5
			Me.LUR_BackButton.Text = "戻る"
			Me.LUR_BackButton.UseVisualStyleBackColor = True
			'
			'LUR_ExecutButton
			'
			Me.LUR_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.LUR_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_ExecutButton.Location = New Point(592, 520)
			Me.LUR_ExecutButton.Name = "LUR_ExecutButton"
			Me.LUR_ExecutButton.Size = New Size(80, 30)
			Me.LUR_ExecutButton.TabIndex = 4
			Me.LUR_ExecutButton.Text = "実行"
			Me.LUR_ExecutButton.UseVisualStyleBackColor = True
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(323, 68)
			Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(120, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'UcSelectGridView1
			'
			Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcSelectGridView1.Location = New Point(18, 108)
			Me.UcSelectGridView1.Name = "UcSelectGridView1"
			Me.UcSelectGridView1.Size = New Size(749, 406)
			Me.UcSelectGridView1.TabIndex = 3
			'
			'ListUkeharaiReporForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.UcSelectGridView1)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.LUR_BackButton)
			Me.Controls.Add(Me.LUR_ExecutButton)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.LUR_ClearButton)
			Me.Controls.Add(Me.LUR_SelectAllButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "ListUkeharaiReporForm"
			Me.Text = "受払報告書画面"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Friend Overridable Property CmpSgv As CmpSelectGridView
			Get
				Return Me._CmpSgv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CmpSelectGridView)
				Me._CmpSgv = value
			End Set
		End Property

		Private Sub ListUkeharaiReporForm_Load(sender As Object, e As EventArgs)
			Me.SetToriGridView()
			Me.SetToriGridViewData()
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
			Me.CclDateTimePicker.Value = DateAndTime.Now.ToString("yyyy/MM/01")
		End Sub

		Private Sub SetToriGridView()
			Dim gridColumn As New GridColumn()
			gridColumn.ReadOnlyFlag = True
			Me.UcSelectGridView1.CmpSgv.AutoGenerateColumns = False
			Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeight = 28
			Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateCheckColumn("SelectCheckd", "選択", 50, False, ""))
			Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("Tori_Cd", "取引先コード", 180, True, ""))
			Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("Tori_Name", "取引先名称", 500, True, ""))
		End Sub

		Private Sub SetToriGridViewData()
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = "SELECT TORI_CD, ISNULL(TORI_NAME,'') AS TORI_NAME FROM Ukeharai.M_TORI WHERE TORI_CD <> ''"
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not sqldata.Equals(String.Empty) Then
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return
				End If
				dbDataTable = sqlDataBase.DbDataTable
			End Using
			Try
				For Each obj As Object In dbDataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Me.UcSelectGridView1.CmpSgv.Rows.Add(New Object() {False, RuntimeHelpers.GetObjectValue(dataRow("TORI_CD")), RuntimeHelpers.GetObjectValue(dataRow("TORI_NAME"))})
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Function makeSql(arySelectedRows As ArrayList, syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			Dim dateTime As New DateTime(syoriym.Year, syoriym.Month, 1)
			Dim dateTime2 As DateTime = dateTime
			Dim syoriymd As DateTime = dateTime2.AddMonths(1).AddDays(-1.0)
			Dim arg As String = syoriymd.ToString("yyyy/MM/dd")
			stringBuilder.Append("SELECT ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                  AS 取引先コード, ")
			stringBuilder.Append(vbTab & vbTab & "TOR.TORI_NAME" & vbTab & "    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                  AS 取引先名, ")
			stringBuilder.Append(" '" + syoriym.ToString("yyyy/MM") + "'" & vbTab & vbTab & vbTab & vbTab & vbTab & "  " & vbTab & vbTab & "                  AS 対象年月, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORIHIN_NO  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                  AS 取引先品番, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                  AS 部品コード, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_NAME    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "              AS 品名, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO1    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "              AS 棚番１, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO2    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "              AS 棚番２, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO3    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                  AS 棚番３, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.KIKAKU  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                      AS 規格, ")
			stringBuilder.Append(vbTab & vbTab & "ISNULL(BUH.ZENGETSU_ZAIKO, 0)                                                 AS 前月残, ")
			stringBuilder.Append(vbTab & vbTab & "ISNULL(JIS.UKESU, 0)                                                          AS 受入, ")
			stringBuilder.Append(vbTab & vbTab & "ISNULL(JIS.HARASU, 0)                                                         AS 払出, ")
			stringBuilder.Append(vbTab & vbTab & "ISNULL(BUH.ZENGETSU_ZAIKO, 0) + ISNULL(JIS.UKESU, 0) - ISNULL(JIS.HARASU, 0)  AS 当月残 ")
			stringBuilder.Append("FROM  ")
			stringBuilder.Append("    (  ")
			stringBuilder.Append(vbTab & vbTab & "SELECT ")
			stringBuilder.Append(vbTab & vbTab & "     TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "     TORIHIN_NO, ")
			stringBuilder.Append(vbTab & vbTab & "     BUHIN_CD, ")
			stringBuilder.Append(vbTab & vbTab & "     BUHIN_NAME, ")
			stringBuilder.Append(vbTab & vbTab & "     TANA_NO1, ")
			stringBuilder.Append(vbTab & vbTab & "     TANA_NO2, ")
			stringBuilder.Append(vbTab & vbTab & "     TANA_NO3, ")
			stringBuilder.Append(vbTab & vbTab & "     KIKAKU, ")
			Dim stringBuilder2 As StringBuilder = stringBuilder
			syoriymd = New DateTime(syoriym.Year, syoriym.Month, 1)
			stringBuilder2.Append(ZaikosuCommon.GetZaikoSubquery(syoriymd, "SUB_BUH", False) + " AS ZENGETSU_ZAIKO ")
			stringBuilder.Append(vbTab & vbTab & "FROM ")
			stringBuilder.Append(vbTab & vbTab & "     [Ukeharai].[M_BUHIN] AS SUB_BUH")
			stringBuilder.Append("     WHERE ")
			stringBuilder.Append("          TORI_CD IN ({2}) ")
			stringBuilder.Append("    ) AS BUH ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append("    ( ")
			stringBuilder.Append("     SELECT ")
			stringBuilder.Append("           SUB.TORI_CD, ")
			stringBuilder.Append("           SUB.BUHIN_CD,")
			stringBuilder.Append("           SUB.UKEHARA_YYYYMM, ")
			stringBuilder.Append("           ISNULL(SUB.UKESU, 0)  AS UKESU, ")
			stringBuilder.Append("           ISNULL(SUB.HARASU, 0) AS HARASU ")
			stringBuilder.Append("     FROM ")
			stringBuilder.Append("           [Ukeharai].[T_UKEHARAIJISSEKI] AS SUB")
			stringBuilder.Append("     WHERE ")
			stringBuilder.Append("           UKEHARA_YYYYMM >= '{0}' ")
			stringBuilder.Append("       AND ")
			stringBuilder.Append("           UKEHARA_YYYYMM <= '{1}' ")
			stringBuilder.Append(vbTab & "   AND ")
			stringBuilder.Append("       TORI_CD IN ({2}) ")
			stringBuilder.Append("    ) AS JIS ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = JIS.TORI_CD ")
			stringBuilder.Append(vbTab & "AND ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD = JIS.BUHIN_CD ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_TORI] AS TOR ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = TOR.TORI_CD ")
			stringBuilder.Append("ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD ")
			Dim text As String = ""
			Try
				For Each obj As Object In arySelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text + "'", dataGridViewRow.Cells("Tori_Cd").Value), "',"))
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			text = text.TrimEnd(New Char() {","c})
			Return String.Format(stringBuilder.ToString(), syoriym.ToString("yyyy/MM/01"), arg, text)
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("LUR_SelectAllButton")>
		Private WithEvents LUR_SelectAllButton As Button

		<AccessedThroughProperty("LUR_ClearButton")>
		Private WithEvents LUR_ClearButton As Button

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("LUR_BackButton")>
		Private WithEvents LUR_BackButton As Button

		<AccessedThroughProperty("LUR_ExecutButton")>
		Private WithEvents LUR_ExecutButton As Button

		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		<AccessedThroughProperty("UcSelectGridView1")>
		Private WithEvents UcSelectGridView1 As UcSelectGridView

		<AccessedThroughProperty("CmpSgv")>
		Private _CmpSgv As CmpSelectGridView

		Private Const ALL_MANUFACTURER As String = "全メーカー"

		Private Const CSV_FILE_NAME As String = "53.受払報告書_{0}_{1}{2}.csv"

		Private csvDirectory As String

		Private Sub LUR_SelectAllButton_Click(sender As Object, e As EventArgs) Handles LUR_SelectAllButton.Click
			Try
				For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					dataGridViewRow.Cells("SelectCheckd").Value = True
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub LUR_ClearButton_Click(sender As Object, e As EventArgs) Handles LUR_ClearButton.Click
			Try
				For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					dataGridViewRow.Cells("SelectCheckd").Value = False
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub LUR_ExecutButton_Click(sender As Object, e As EventArgs) Handles LUR_ExecutButton.Click
			Dim syoriym As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年月を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclDateTimePicker.Focus()
				Return
			End If
			Dim arrayList As New ArrayList()
			Try
				For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					If Conversions.ToBoolean(dataGridViewRow.Cells("SelectCheckd").Value) Then
						arrayList.Add(dataGridViewRow)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If arrayList.Count = 0 Then
				DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = Me.makeSql(arrayList, syoriym)
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not sqldata.Equals(String.Empty) Then
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
			Dim text2 As String = ""
			Dim csvCommon As New CsvCommon()
			Dim text3 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text3) Then
				Directory.CreateDirectory(text3)
			End If
			Dim flag As Boolean
			If arrayList.Count = Me.UcSelectGridView1.CmpSgv.Rows.Count Then
				text2 = Path.Combine(text3, String.Format("53.受払報告書_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), "", "全メーカー"))
				flag = csvCommon.ConvertDataTableToCsv(dbDataTable, text2, True)
			Else
				Dim dataTable As DataTable = dbDataTable.Clone()
				Try
					For Each obj2 As Object In arrayList
						Dim dataGridViewRow2 As DataGridViewRow = CType(obj2, DataGridViewRow)
						dataTable.Clear()
						Dim array As DataRow() = dbDataTable.[Select](String.Format("取引先コード = '{0}'", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Cd").Value)))
						For Each row As DataRow In array
							dataTable.ImportRow(row)
						Next
						Dim fileName As String = String.Format("53.受払報告書_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Cd").Value), RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Name").Value))
						text2 = Path.Combine(text3, Common.EscapeInvalidFileName(fileName))
						flag = csvCommon.ConvertDataTableToCsv(dataTable, text2, True)
						If Not flag Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator = Nothing
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			Cursor.Current = Cursors.[Default]
			If Not flag Then
				DlgMessageBox.Show(String.Format("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}", Path.GetFileName(text2)), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				DlgMessageBox.Show("CSV出力が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		Private Sub LUR_BackButton_Click(sender As Object, e As EventArgs) Handles LUR_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
