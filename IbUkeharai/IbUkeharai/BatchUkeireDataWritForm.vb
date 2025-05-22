Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.BatchExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class BatchUkeireDataWritForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.BatchUkeireDataWritForm_Load
			AddHandler MyBase.FormClosing, AddressOf Me.BatchUkeireDataWritForm_FormClosing
			Me.outPutDir = Path.Combine("kekka", "40.受入書き込み")
			Me.backupDir = Path.Combine("backup", "ukeire")
			Me._ukeirecolum = New String() {"受入年月日", "取引先コード", "部品コード", "数量", "伝票NO", "備考１", "備考２", "備考３"}
			Me._viewInfo = Nothing
			Me._okTable = Nothing
			Me._errTable = Nothing
			Me._configData = Nothing
			Me.FlgMemory = False
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
			Me.FormTitleLabel = New Label()
			Me.Label1 = New Label()
			Me.BUDW_BackButton = New Button()
			Me.BUDW_ExecutButton = New Button()
			Me.ResultGroupBox = New GroupBox()
			Me.G_Count_Label = New Label()
			Me.G_Kosu_Label = New Label()
			Me.G_Kojo_Label = New Label()
			Me.ERR_Count_Label = New Label()
			Me.ERR_Kosu_Label = New Label()
			Me.ERR_BuhinCD_Label = New Label()
			Me.ERR_ToriCD_Label = New Label()
			Me.ERR_Kojo_Label = New Label()
			Me.OK_Count_Label = New Label()
			Me.OK_Kosu_Label = New Label()
			Me.OK_BuhinCD_Label = New Label()
			Me.OK_ToriCD_Label = New Label()
			Me.OK_Kojo_Label = New Label()
			Me.BUDW_ReloadButton = New Button()
			Me.ChkMemory = New CheckBox()
			Me.ResultGroupBox.SuspendLayout()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.FormTitleLabel.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
			Me.FormTitleLabel.Location = New Point(12, 9)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(760, 45)
			Me.FormTitleLabel.TabIndex = 5
			Me.FormTitleLabel.Text = "受入データ書き込み"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'Label1
			'
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.Location = New Point(70, 90)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(433, 71)
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "受入データを取り込む場合は、「実行」ボタンを押してください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "エラーファイルを取り込む場合は、「再取込み」ボタンを押してください。"
			'
			'BUDW_BackButton
			'
			Me.BUDW_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BUDW_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BUDW_BackButton.Location = New Point(687, 520)
			Me.BUDW_BackButton.Name = "BUDW_BackButton"
			Me.BUDW_BackButton.Size = New Size(80, 30)
			Me.BUDW_BackButton.TabIndex = 2
			Me.BUDW_BackButton.Text = "戻る"
			Me.BUDW_BackButton.UseVisualStyleBackColor = True
			'
			'BUDW_ExecutButton
			'
			Me.BUDW_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BUDW_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BUDW_ExecutButton.Location = New Point(515, 520)
			Me.BUDW_ExecutButton.Name = "BUDW_ExecutButton"
			Me.BUDW_ExecutButton.Size = New Size(80, 30)
			Me.BUDW_ExecutButton.TabIndex = 0
			Me.BUDW_ExecutButton.Text = "実行"
			Me.BUDW_ExecutButton.UseVisualStyleBackColor = True
			'
			'ResultGroupBox
			'
			Me.ResultGroupBox.Controls.Add(Me.G_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Kojo_Label)
			Me.ResultGroupBox.Controls.Add(Me.ERR_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.ERR_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.ERR_BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.ERR_ToriCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.ERR_Kojo_Label)
			Me.ResultGroupBox.Controls.Add(Me.OK_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.OK_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.OK_BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.OK_ToriCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.OK_Kojo_Label)
			Me.ResultGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ResultGroupBox.Location = New Point(73, 190)
			Me.ResultGroupBox.Name = "ResultGroupBox"
			Me.ResultGroupBox.Size = New Size(488, 108)
			Me.ResultGroupBox.TabIndex = 54
			Me.ResultGroupBox.TabStop = False
			Me.ResultGroupBox.Text = "取込み結果"
			'
			'G_Count_Label
			'
			Me.G_Count_Label.Location = New Point(409, 75)
			Me.G_Count_Label.Name = "G_Count_Label"
			Me.G_Count_Label.Size = New Size(59, 16)
			Me.G_Count_Label.TabIndex = 39
			Me.G_Count_Label.Text = "ZZ,ZZ9"
			'
			'G_Kosu_Label
			'
			Me.G_Kosu_Label.Location = New Point(313, 75)
			Me.G_Kosu_Label.Name = "G_Kosu_Label"
			Me.G_Kosu_Label.Size = New Size(80, 16)
			Me.G_Kosu_Label.TabIndex = 37
			Me.G_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'G_Kojo_Label
			'
			Me.G_Kojo_Label.Location = New Point(6, 75)
			Me.G_Kojo_Label.Name = "G_Kojo_Label"
			Me.G_Kojo_Label.Size = New Size(80, 16)
			Me.G_Kojo_Label.TabIndex = 36
			Me.G_Kojo_Label.Text = "合計"
			'
			'ERR_Count_Label
			'
			Me.ERR_Count_Label.Location = New Point(409, 55)
			Me.ERR_Count_Label.Name = "ERR_Count_Label"
			Me.ERR_Count_Label.Size = New Size(59, 20)
			Me.ERR_Count_Label.TabIndex = 11
			Me.ERR_Count_Label.Text = "ZZ,ZZ9"
			'
			'ERR_Kosu_Label
			'
			Me.ERR_Kosu_Label.Location = New Point(313, 55)
			Me.ERR_Kosu_Label.Name = "ERR_Kosu_Label"
			Me.ERR_Kosu_Label.Size = New Size(80, 20)
			Me.ERR_Kosu_Label.TabIndex = 9
			Me.ERR_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'ERR_BuhinCD_Label
			'
			Me.ERR_BuhinCD_Label.Location = New Point(178, 55)
			Me.ERR_BuhinCD_Label.Name = "ERR_BuhinCD_Label"
			Me.ERR_BuhinCD_Label.Size = New Size(120, 20)
			Me.ERR_BuhinCD_Label.TabIndex = 8
			Me.ERR_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
			'
			'ERR_ToriCD_Label
			'
			Me.ERR_ToriCD_Label.Location = New Point(92, 55)
			Me.ERR_ToriCD_Label.Name = "ERR_ToriCD_Label"
			Me.ERR_ToriCD_Label.Size = New Size(80, 20)
			Me.ERR_ToriCD_Label.TabIndex = 7
			Me.ERR_ToriCD_Label.Text = "XXXXXXXX"
			'
			'ERR_Kojo_Label
			'
			Me.ERR_Kojo_Label.Location = New Point(6, 55)
			Me.ERR_Kojo_Label.Name = "ERR_Kojo_Label"
			Me.ERR_Kojo_Label.Size = New Size(80, 20)
			Me.ERR_Kojo_Label.TabIndex = 6
			Me.ERR_Kojo_Label.Text = "取込み失敗"
			'
			'OK_Count_Label
			'
			Me.OK_Count_Label.Location = New Point(409, 35)
			Me.OK_Count_Label.Name = "OK_Count_Label"
			Me.OK_Count_Label.Size = New Size(59, 20)
			Me.OK_Count_Label.TabIndex = 5
			Me.OK_Count_Label.Text = "ZZ,ZZ9"
			'
			'OK_Kosu_Label
			'
			Me.OK_Kosu_Label.Location = New Point(313, 35)
			Me.OK_Kosu_Label.Name = "OK_Kosu_Label"
			Me.OK_Kosu_Label.Size = New Size(80, 20)
			Me.OK_Kosu_Label.TabIndex = 3
			Me.OK_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'OK_BuhinCD_Label
			'
			Me.OK_BuhinCD_Label.Location = New Point(178, 35)
			Me.OK_BuhinCD_Label.Name = "OK_BuhinCD_Label"
			Me.OK_BuhinCD_Label.Size = New Size(120, 20)
			Me.OK_BuhinCD_Label.TabIndex = 2
			Me.OK_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
			'
			'OK_ToriCD_Label
			'
			Me.OK_ToriCD_Label.Location = New Point(92, 35)
			Me.OK_ToriCD_Label.Name = "OK_ToriCD_Label"
			Me.OK_ToriCD_Label.Size = New Size(80, 20)
			Me.OK_ToriCD_Label.TabIndex = 1
			Me.OK_ToriCD_Label.Text = "XXXXXXXX"
			'
			'OK_Kojo_Label
			'
			Me.OK_Kojo_Label.Location = New Point(6, 35)
			Me.OK_Kojo_Label.Name = "OK_Kojo_Label"
			Me.OK_Kojo_Label.Size = New Size(80, 20)
			Me.OK_Kojo_Label.TabIndex = 0
			Me.OK_Kojo_Label.Text = "取込み成功"
			'
			'BUDW_ReloadButton
			'
			Me.BUDW_ReloadButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BUDW_ReloadButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BUDW_ReloadButton.Location = New Point(601, 520)
			Me.BUDW_ReloadButton.Name = "BUDW_ReloadButton"
			Me.BUDW_ReloadButton.Size = New Size(80, 30)
			Me.BUDW_ReloadButton.TabIndex = 1
			Me.BUDW_ReloadButton.Text = "再取込み"
			Me.BUDW_ReloadButton.UseVisualStyleBackColor = True
			'
			'ChkMemory
			'
			Me.ChkMemory.AutoSize = True
			Me.ChkMemory.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ChkMemory.Location = New Point(18, 525)
			Me.ChkMemory.Name = "ChkMemory"
			Me.ChkMemory.Size = New Size(159, 16)
			Me.ChkMemory.TabIndex = 56
			Me.ChkMemory.Text = "指定フォルダーを記憶する"
			Me.ChkMemory.UseVisualStyleBackColor = True
			'
			'BatchUkeireDataWritForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.ChkMemory)
			Me.Controls.Add(Me.BUDW_ReloadButton)
			Me.Controls.Add(Me.ResultGroupBox)
			Me.Controls.Add(Me.BUDW_BackButton)
			Me.Controls.Add(Me.BUDW_ExecutButton)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "BatchUkeireDataWritForm"
			Me.Text = "受入データ書き込み画面"
			Me.ResultGroupBox.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region

		Private Sub BatchUkeireDataWritForm_Load(sender As Object, e As EventArgs)
			Me._configData = TopForm.ConfigData
			Me.ResultGroupBox.Hide()
			If Operators.CompareString(Me._configData.xmlConfData.Kyoten, "Matsuyama", False) <> 0 Then
				Me.ChkMemory.Visible = False
				Return
			End If
			If "ON".Equals(Me._configData.xmlConfData.Memory) Then
				Me.FlgMemory = True
				Me.ChkMemory.Checked = True
			Else
				Me.FlgMemory = False
				Me.ChkMemory.Checked = False
			End If
		End Sub

		Private Function CheckTableColums(csvTb As DataTable) As Boolean
			Dim list As New List(Of String)()
			For Each columnName As String In Me._ukeirecolum
				If csvTb.Columns.IndexOf(columnName) < 0 Then
					Return False
				End If
			Next
			Return True
		End Function

		Private Function UkeireWritExec(csvTb As DataTable) As Boolean
			Try
				Me.CreateOutPutTable(csvTb)
				Me.UkeireDataWrit(csvTb)
				Me.ShowViewInfo(Me._viewInfo)
				Me.OutPutFile()
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("Exception Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Sub CreateOutPutTable(csvTb As DataTable)
			If csvTb.Columns.IndexOf("エラー") > -1 Then
				csvTb.Columns.Remove("エラー")
			End If
			Me._okTable = csvTb.Clone()
			Me._errTable = csvTb.Clone()
			Me._errTable.Columns.Add("エラー")
		End Sub

		Private Function GetExecFilePath(Optional a_path As String = "") As String
			Dim result As String = Nothing
			Dim openFileDialog As New OpenFileDialog()
			If String.IsNullOrEmpty(a_path) Then
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			Else
				openFileDialog.InitialDirectory = a_path
			End If
			openFileDialog.Filter = "CSVファイル(*.csv)|*.csv| すべてのファイル(*.*)|*.*"
			openFileDialog.Title = "受入データ書き込みファイルを選択してください。"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				result = openFileDialog.FileName
			End If
			Return result
		End Function

		Private Function GetRetryFilePath() As String
			Dim result As String = Nothing
			Dim openFileDialog As New OpenFileDialog()
			Dim initialDirectory As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			openFileDialog.InitialDirectory = initialDirectory
			openFileDialog.Filter = "CSVファイル(*.csv)|*.csv| すべてのファイル(*.*)|*.*"
			openFileDialog.Title = "再取込みするファイルを選択してください。"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				result = openFileDialog.FileName
			End If
			Return result
		End Function

		Private Sub UkeireDataWrit(csvTb As DataTable)
			Me.CreateViewInfo()
			Try
				For Each obj As Object In csvTb.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim toricd As String = Conversions.ToString(dataRow("取引先コード"))
					Dim toriTable As DataTable = Me.GetToriTable(toricd)
					If IsNothing(toriTable) Then
						Me.AddErrRow(dataRow, "#")
					Else
						Dim buhincd As String = Conversions.ToString(dataRow("部品コード"))
						Dim buhinTable As DataTable = Me.GetBuhinTable(toricd, buhincd)
						If IsNothing(buhinTable) Then
							Me.AddErrRow(dataRow, "*")
						Else
							Dim sType As String = ""
							If Me.InsertRowData(dataRow, sType) Then
								Me.AddOkRow(dataRow)
							Else
								Me.AddErrRow(dataRow, "!")
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.SetTotaleViewValue()
		End Sub

		Private Function InsertRowData(row As DataRow, sType As String) As Boolean
			Dim ukeharaiMeisaiTable As DataTable = Me.GetUkeharaiMeisaiTable()
			If IsNothing(ukeharaiMeisaiTable) Then
				Me.AddErrRow(row, "!")
			End If
			Dim result As Boolean = False
			Try
				If Me.CreateHaraiMeisaiData(ukeharaiMeisaiTable, row) Then
					Dim sql As String = Me.CreateInsertSql(ukeharaiMeisaiTable)
					result = Me.InsertUkeharaiMeisai(sql)
				End If
			Catch ex As Exception
				result = False
				OutputLog.WriteLine(String.Format("Insert Errer : {0}", ex.Message))
			End Try
			Return result
		End Function

		Private Sub AddOkRow(row As DataRow)
			Dim dataRow As DataRow = Me._okTable.NewRow()
			For Each columnName As String In Me._ukeirecolum
				dataRow(columnName) = RuntimeHelpers.GetObjectValue(row(columnName))
			Next
			Me._okTable.Rows.Add(dataRow)
			Dim id As Integer = 1
			Me.SetViewValue(id, row)
		End Sub

		Private Sub AddErrRow(row As DataRow, errMsg As String)
			Dim dataRow As DataRow = Me._errTable.NewRow()
			For Each columnName As String In Me._ukeirecolum
				dataRow(columnName) = RuntimeHelpers.GetObjectValue(row(columnName))
			Next
			dataRow("エラー") = errMsg
			Me._errTable.Rows.Add(dataRow)
			Dim id As Integer = 2
			Me.SetViewValue(id, row)
		End Sub

		Private Sub OutPutFile()
			Dim now As DateTime = DateAndTime.Now
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			If Not BaseOperation.IsDirectory(text) AndAlso Not BaseOperation.CreateDirectory(text) Then
				Return
			End If
			Dim path1 As String = String.Format("40.受入書き込み_OK_{0}-{1}.csv", now.ToString("yyyyMMdd"), now.ToString("HHmmss"))
			Dim csvPath As String = Path.Combine(text, path1)
			Dim path2 As String = String.Format("40.受入書き込み_ERR_{0}-{1}.csv", now.ToString("yyyyMMdd"), now.ToString("HHmmss"))
			Dim csvPath2 As String = Path.Combine(text, path2)
			Dim csvCommon As New CsvCommon()
			If Me._okTable.Rows.Count > 0 AndAlso Not csvCommon.ConvertDataTableToCsv(Me._okTable, csvPath, True) Then
				DlgMessageBox.Show("OKファイルの出力に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			If Me._errTable.Rows.Count > 0 AndAlso Not csvCommon.ConvertDataTableToCsv(Me._errTable, csvPath2, True) Then
				DlgMessageBox.Show("ERRファイルの出力に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		Private Sub FixedOutPutFile()
			Dim list As New List(Of String)()
			Dim list2 As New List(Of String)()
			Dim path1 As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			If Not BaseOperation.IsDirectory(path1) AndAlso Not BaseOperation.CreateDirectory(path1) Then
				Return
			End If
			For Each text As String In BaseOperation.GetFileList(path1)
				If text.IndexOf("40.受入書き込み_OK") >= 0 Then
					list.Add(text)
				ElseIf text.IndexOf("40.受入書き込み_ERR") >= 0 Then
					list2.Add(text)
				End If
			Next
			If list.Count > 2 Then
				BaseOperation.DeleteFileList(list, 2)
			End If
			If list2.Count > 2 Then
				BaseOperation.DeleteFileList(list2, 2)
			End If
		End Sub

		Private Function GetDbParam(sql As String) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sql, True)
				If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function GetSelectTable(sql As String, ByRef tb As DataTable) As String
			Dim result As String = Nothing
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.getSQLData(sql, True)
				tb = sqlDataBase.DbDataTable
			End Using
			Return result
		End Function

		Private Function GetToriTable(toricd As String) As DataTable
			Dim result As DataTable = Nothing
			Dim toriSql As String = Me.GetToriSql(toricd)
			Dim dataTable As New DataTable()
			Dim selectTable As String = Me.GetSelectTable(toriSql, dataTable)
			If Operators.CompareString(selectTable, String.Empty, False) = 0 AndAlso dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function GetToriSql(toricd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD = '{0}' ", toricd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetBuhinTable(toricd As String, buhincd As String) As DataTable
			Dim result As DataTable = Nothing
			Dim buhinSql As String = Me.GetBuhinSql(toricd, buhincd)
			Dim dataTable As New DataTable()
			Dim selectTable As String = Me.GetSelectTable(buhinSql, dataTable)
			If Operators.CompareString(selectTable, String.Empty, False) = 0 AndAlso dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function GetBuhinSql(toricd As String, buhincd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_BUHIN [M_Buhin] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Buhin.TORI_CD = '{0}' ", toricd))
			stringBuilder.Append(String.Format("AND M_Buhin.BUHIN_CD = '{0}' ", buhincd))
			Return stringBuilder.ToString()
		End Function

		Private Function InsertUkeharaiMeisai(sql As String) As Boolean
			Dim result As Boolean = False
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.execSql(sql)
			End Using
			Return result
		End Function

		Private Function GetUkeharaiMeisaiTable() As DataTable
			Dim result As DataTable = Nothing
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_UKEHARAIMEISAI  [T_Meisai] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE T_Meisai.TORI_CD = '00000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.BUHIN_CD = '000000000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.UKEHARA_YYYYMMDD = '2000/01/01' ", New Object(-1) {}))
			Dim selectTable As String = Me.GetSelectTable(stringBuilder.ToString(), result)
			If Operators.CompareString(selectTable, String.Empty, False) <> 0 Then
				result = Nothing
			End If
			Return result
		End Function

		Private Function CreateHaraiMeisaiData(tb As DataTable, csvRow As DataRow) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("TORI_CD") = RuntimeHelpers.GetObjectValue(csvRow("取引先コード"))
				dataRow("BUHIN_CD") = RuntimeHelpers.GetObjectValue(csvRow("部品コード"))
				dataRow("UKEHARA_YYYYMMDD") = DateTime.Parse(Strings.Format(Conversions.ToInteger(csvRow("受入年月日")), "0000/00/00"))
				dataRow("DEN_NO") = RuntimeHelpers.GetObjectValue(csvRow("伝票NO"))
				dataRow("UKEHARAI_KBN") = "1"
				dataRow("KOSU") = RuntimeHelpers.GetObjectValue(csvRow("数量"))
				dataRow("REMARKS1") = RuntimeHelpers.GetObjectValue(csvRow("備考１"))
				dataRow("REMARKS2") = RuntimeHelpers.GetObjectValue(csvRow("備考２"))
				dataRow("REMARKS3") = RuntimeHelpers.GetObjectValue(csvRow("備考３"))
				Dim value As String = ""
				dataRow("SAKI_CD") = value
				Dim num As Integer = 0
				dataRow("KINGAKU") = num
				Dim value2 As String = "0.00"
				dataRow("TESU") = value2
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = "BatchUkeireDataWrit"
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateMeisaiData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateInsertSql(tb As DataTable) As String
			Dim str As String = "INSERT INTO Ukeharai.T_UKEHARAIMEISAI "
			Dim count As Integer = tb.Columns.Count
			Dim text As String = "("
			Dim text2 As String = "VALUES ("
			Dim dataRow As DataRow = tb.Rows(0)
			Dim num As Integer = 0
			Dim num2 As Integer = count - 1
			For i As Integer = num To num2
				Dim caption As String = tb.Columns(i).Caption
				text += caption
				If Not IsNothing(RuntimeHelpers.GetObjectValue(dataRow(i))) Then
					If Me.GetDataType(caption) = 1 Then
						text2 += dataRow(i).ToString()
					Else
						text2 += String.Format("'{0}'", RuntimeHelpers.GetObjectValue(dataRow(i)))
					End If
				End If
				If i < count - 1 Then
					text += " ,"
					text2 += " ,"
				Else
					text += " )"
					text2 += " )"
				End If
			Next
			Return str + text + text2
		End Function

		Private Function GetDataType(name As String) As Integer
			Dim result As Integer
			If Operators.CompareString(name, "KOSU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "KINGAKU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "TESU", False) = 0 Then
				result = 1
			Else
				result = 0
			End If
			Return result
		End Function

		Private Sub ShowViewInfo(viewInfo As Dictionary(Of Integer, BatchUkeireDataWritForm.viewInfo))
			Dim num As Integer = 1
			Dim count As Integer = viewInfo.Count
			For i As Integer = num To count
				Select Case i
					Case 1
						Me.SetOkTableInfo(viewInfo(i))
					Case 2
						Me.SetErrTableInfo(viewInfo(i))
					Case 3
						Me.SetTotaleInfo(viewInfo(i))
				End Select
			Next
			Me.ResultGroupBox.Show()
		End Sub

		Private Sub SetOkTableInfo(info As BatchUkeireDataWritForm.viewInfo)
			Me.OK_ToriCD_Label.Text = info.tori_cd
			Me.OK_BuhinCD_Label.Text = info.buhin_cd
			Me.OK_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.OK_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetErrTableInfo(info As BatchUkeireDataWritForm.viewInfo)
			Me.ERR_ToriCD_Label.Text = info.tori_cd
			Me.ERR_BuhinCD_Label.Text = info.buhin_cd
			Me.ERR_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.ERR_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetTotaleInfo(info As BatchUkeireDataWritForm.viewInfo)
			Me.G_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.G_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Function ConvertViewNumber(num As Integer) As String
			Return String.Format("{0:#,0}", num)
		End Function

		Private Sub CreateViewInfo()
			If Not IsNothing(Me._viewInfo) Then
				Me._viewInfo.Clear()
				Me._viewInfo = Nothing
			End If
			Me._viewInfo = New Dictionary(Of Integer, BatchUkeireDataWritForm.viewInfo)()
			Dim viewInfoNum As BatchUkeireDataWritForm.viewInfoNum = BatchUkeireDataWritForm.viewInfoNum.OK
			Dim num As Integer = 1
			Do
				Me._viewInfo.Add(CInt(viewInfoNum), New BatchUkeireDataWritForm.viewInfo())
				num += 1
				viewInfoNum = CType(num, viewInfoNum)
			Loop While viewInfoNum <= BatchUkeireDataWritForm.viewInfoNum.ERR
		End Sub

		Private Sub SetViewValue(id As Integer, row As DataRow)
			Me._viewInfo(id).tori_cd = Conversions.ToString(row("取引先コード"))
			Me._viewInfo(id).buhin_cd = Me.ConvertBuhinCd(Conversions.ToString(row("部品コード")))
			Dim viewInfo As BatchUkeireDataWritForm.viewInfo = Me._viewInfo(id)
			viewInfo.kosu += Conversions.ToInteger(row("数量"))
			viewInfo = Me._viewInfo(id)
			viewInfo.count += 1
		End Sub

		Private Function SetTotaleViewValue() As Boolean
			Dim count As Integer = Me._viewInfo.Count
			Dim viewInfo As New BatchUkeireDataWritForm.viewInfo()
			Dim num As Integer = 1
			Dim num2 As Integer = count
			For i As Integer = num To num2
				Dim viewInfo2 As BatchUkeireDataWritForm.viewInfo = viewInfo
				viewInfo2.kosu += Me._viewInfo(i).kosu
				viewInfo2 = viewInfo
				viewInfo2.count += Me._viewInfo(i).count
			Next
			Me._viewInfo.Add(count + 1, viewInfo)
			Return viewInfo.count >= 1
		End Function

		Private Function ConvertBuhinCd(buhin_cd As String) As String
			Dim length As Integer = buhin_cd.Length
			Dim result As String
			If length > 10 Then
				result = String.Format("{0}-{1}-{2}-{3}", New Object() {buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7, 3), buhin_cd.Substring(10)})
			ElseIf length > 7 Then
				result = String.Format("{0}-{1}-{2}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7))
			ElseIf length > 4 Then
				result = String.Format("{0}-{1}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4))
			Else
				result = buhin_cd
			End If
			Return result
		End Function

		Private Sub FileBackUp(filePath As String)
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.backupDir)
			If Not BaseOperation.IsDirectory(text) AndAlso Not BaseOperation.CreateDirectory(text) Then
				Return
			End If
			Dim fileName As String = Path.GetFileName(filePath)
			Dim dst As String = Path.Combine(text, fileName)
			BaseOperation.CopyToFile(filePath, dst)
			Me.FixedBackUpFile()
		End Sub

		Private Sub FixedBackUpFile()
			Dim list As New List(Of String)()
			Dim path1 As String = Path.Combine(FileSystem.CurDir(), Me.backupDir)
			For Each item As String In BaseOperation.GetFileList(path1)
				list.Add(item)
			Next
			If list.Count > 2 Then
				BaseOperation.DeleteFileList(list, 2)
			End If
		End Sub

		Private Sub BatchUkeireDataWritForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Operators.CompareString(Me._configData.xmlConfData.Kyoten, "Matsuyama", False) <> 0 Then
				Return
			End If
			If Me.FlgMemory <> Me.ChkMemory.Checked Then
				If Me.ChkMemory.Checked Then
					Me._configData.xmlConfData.Memory = "ON"
				Else
					Me._configData.xmlConfData.Memory = "OFF"
				End If
				Me._configData.writeConfig()
			End If
		End Sub


		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("BUDW_BackButton")>
		Private WithEvents BUDW_BackButton As Button

		<AccessedThroughProperty("BUDW_ExecutButton")>
		Private WithEvents BUDW_ExecutButton As Button

		<AccessedThroughProperty("ResultGroupBox")>
		Private WithEvents ResultGroupBox As GroupBox

		<AccessedThroughProperty("G_Count_Label")>
		Private WithEvents G_Count_Label As Label

		<AccessedThroughProperty("G_Kosu_Label")>
		Private WithEvents G_Kosu_Label As Label

		<AccessedThroughProperty("G_Kojo_Label")>
		Private WithEvents G_Kojo_Label As Label

		<AccessedThroughProperty("BUDW_ReloadButton")>
		Private WithEvents BUDW_ReloadButton As Button

		<AccessedThroughProperty("ERR_Count_Label")>
		Private WithEvents ERR_Count_Label As Label

		<AccessedThroughProperty("ERR_Kosu_Label")>
		Private WithEvents ERR_Kosu_Label As Label

		<AccessedThroughProperty("ERR_BuhinCD_Label")>
		Private WithEvents ERR_BuhinCD_Label As Label

		<AccessedThroughProperty("ERR_ToriCD_Label")>
		Private WithEvents ERR_ToriCD_Label As Label

		<AccessedThroughProperty("ERR_Kojo_Label")>
		Private WithEvents ERR_Kojo_Label As Label

		<AccessedThroughProperty("OK_Count_Label")>
		Private WithEvents OK_Count_Label As Label

		<AccessedThroughProperty("OK_Kosu_Label")>
		Private WithEvents OK_Kosu_Label As Label

		<AccessedThroughProperty("OK_BuhinCD_Label")>
		Private WithEvents OK_BuhinCD_Label As Label

		<AccessedThroughProperty("OK_ToriCD_Label")>
		Private WithEvents OK_ToriCD_Label As Label

		<AccessedThroughProperty("OK_Kojo_Label")>
		Private WithEvents OK_Kojo_Label As Label

		<AccessedThroughProperty("ChkMemory")>
		Private WithEvents ChkMemory As CheckBox

		Private Const EXEC_FUNC_NAME As String = "BatchUkeireDataWrit"

		Private Const UKEHARAI_KUBUN As String = "1"

		Private Const FIX_FILE_COUNT As Integer = 2

		Private outPutDir As String

		Private Const OK_FILE_NAME As String = "40.受入書き込み_OK"

		Private Const OK_FILE_FORMAT As String = "40.受入書き込み_OK_{0}-{1}.csv"

		Private Const ERR_FILE_NAME As String = "40.受入書き込み_ERR"

		Private Const ERR_FILE_FORMAT As String = "40.受入書き込み_ERR_{0}-{1}.csv"

		Private Const FIX_BACKFILE_COUNT As Integer = 2

		Private backupDir As String

		Private Const ITEM_UKEIREYMD As String = "受入年月日"

		Private Const ITEM_TORICD As String = "取引先コード"

		Private Const ITEM_BUHINCD As String = "部品コード"

		Private Const ITEM_KOSU As String = "数量"

		Private Const ITEM_DENNO As String = "伝票NO"

		Private Const ITEM_REMARKS_1 As String = "備考１"

		Private Const ITEM_REMARKS_2 As String = "備考２"

		Private Const ITEM_REMARKS_3 As String = "備考３"

		Private _ukeirecolum As String()

		Private Const ITEM_ERR As String = "エラー"

		Private _viewInfo As Dictionary(Of Integer, BatchUkeireDataWritForm.viewInfo)

		Private Const ERR_TORI_MARK As String = "#"

		Private Const ERR_BUHIN_MARK As String = "*"

		Private Const ERR_TANKA_MARK As String = "@"

		Private Const ERR_DB_MARK As String = "!"

		Private _okTable As DataTable

		Private _errTable As DataTable

		Private _configData As XmlConfigControl

		Private FlgMemory As Boolean

		Public Class viewInfo
			Public Sub New()
				Me.tori_cd = ""
				Me.buhin_cd = ""
				Me.kosu = 0
				Me.count = 0
			End Sub

			Public tori_cd As String

			Public buhin_cd As String

			Public kosu As Integer

			Public count As Integer
		End Class

		Public Enum viewInfoNum
			OK = 1

			ERR

			Totale
		End Enum

		Private Sub BUDW_ExecutButton_Click(sender As Object, e As EventArgs) Handles BUDW_ExecutButton.Click
			Dim execFilePath As String = Me.GetExecFilePath(Me._configData.xmlConfData.BaseFolder)
			If IsNothing(execFilePath) Then
				Return
			End If
			If Me.ChkMemory.Checked Then
				Dim directoryName As String = Path.GetDirectoryName(execFilePath)
				Me._configData.xmlConfData.BaseFolder = directoryName
				Me._configData.writeConfig()
			End If
			Dim csvCommon As New CsvCommon()
			Dim dataTable As DataTable = csvCommon.ConvertCsvToDataTable(execFilePath)
			If Not Me.CheckTableColums(dataTable) Then
				DlgMessageBox.Show("受入データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If dataTable.Rows.Count < 1 Then
				DlgMessageBox.Show("取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.UkeireWritExec(dataTable) Then
				Me.FileBackUp(execFilePath)
				DlgMessageBox.Show("受入データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
				Me.FixedOutPutFile()
				Return
			End If
			DlgMessageBox.Show("受入データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BUDW_ReloadButton_Click(sender As Object, e As EventArgs) Handles BUDW_ReloadButton.Click
			Dim retryFilePath As String = Me.GetRetryFilePath()
			If IsNothing(retryFilePath) Then
				Return
			End If
			Dim csvCommon As New CsvCommon()
			Dim dataTable As DataTable = csvCommon.ConvertCsvToDataTable(retryFilePath)
			If Not Me.CheckTableColums(dataTable) Then
				DlgMessageBox.Show("受入データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If dataTable.Rows.Count < 1 Then
				DlgMessageBox.Show("取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.UkeireWritExec(dataTable) Then
				Me.FileBackUp(retryFilePath)
				BaseOperation.DeleteFile(retryFilePath)
				DlgMessageBox.Show("受入データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
				Me.FixedOutPutFile()
				Return
			End If
			DlgMessageBox.Show("受入データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BUDW_BackButton_Click(sender As Object, e As EventArgs) Handles BUDW_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
