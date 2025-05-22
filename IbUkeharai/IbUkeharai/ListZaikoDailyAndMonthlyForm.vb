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
Imports IbUkeharai.IbUkeharai.CateDataExec
Imports IbUkeharai.IbUkeharai.Data
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class ListZaikoDailyAndMonthlyForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ListZaikoDailyAndMonthlyForm_Load
			Me.orderDir = Path.Combine("DAT", "")
			Me.csvDirectory = Path.Combine("csv", "57.在庫注残リスト")
			Me._conf = Nothing
			Me._addcolList = Nothing
			Me._allfrg = False
			Me._failfrg = False
			Me._enc = Encoding.GetEncoding("Shift_jis")
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
			Me.LZL_ClearButton = New Button()
			Me.LZL_SelectAllButton = New Button()
			Me.LZL_BackButton = New Button()
			Me.LZL_ExecutButton = New Button()
			Me.DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
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
			Me.FormTitleLabel.TabIndex = 5
			Me.FormTitleLabel.Text = "在庫受注残リスト(月初)　出力"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'LZL_ClearButton
			'
			Me.LZL_ClearButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LZL_ClearButton.Location = New Point(136, 72)
			Me.LZL_ClearButton.Name = "LZL_ClearButton"
			Me.LZL_ClearButton.Size = New Size(80, 30)
			Me.LZL_ClearButton.TabIndex = 1
			Me.LZL_ClearButton.Text = "クリア"
			Me.LZL_ClearButton.UseVisualStyleBackColor = True
			'
			'LZL_SelectAllButton
			'
			Me.LZL_SelectAllButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LZL_SelectAllButton.Location = New Point(40, 72)
			Me.LZL_SelectAllButton.Name = "LZL_SelectAllButton"
			Me.LZL_SelectAllButton.Size = New Size(80, 30)
			Me.LZL_SelectAllButton.TabIndex = 0
			Me.LZL_SelectAllButton.Text = "全選択"
			Me.LZL_SelectAllButton.UseVisualStyleBackColor = True
			'
			'LZL_BackButton
			'
			Me.LZL_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.LZL_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LZL_BackButton.Location = New Point(687, 520)
			Me.LZL_BackButton.Name = "LZL_BackButton"
			Me.LZL_BackButton.Size = New Size(80, 30)
			Me.LZL_BackButton.TabIndex = 4
			Me.LZL_BackButton.Text = "戻る"
			Me.LZL_BackButton.UseVisualStyleBackColor = True
			'
			'LZL_ExecutButton
			'
			Me.LZL_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.LZL_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LZL_ExecutButton.Location = New Point(592, 520)
			Me.LZL_ExecutButton.Name = "LZL_ExecutButton"
			Me.LZL_ExecutButton.Size = New Size(80, 30)
			Me.LZL_ExecutButton.TabIndex = 3
			Me.LZL_ExecutButton.Text = "実行"
			Me.LZL_ExecutButton.UseVisualStyleBackColor = True
			'
			'DataGridViewTextBoxColumn1
			'
			Me.DataGridViewTextBoxColumn1.HeaderText = "取引先コード"
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn1.ReadOnly = True
			Me.DataGridViewTextBoxColumn1.Width = 93
			'
			'DataGridViewTextBoxColumn2
			'
			Me.DataGridViewTextBoxColumn2.HeaderText = "取引先名称"
			Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
			Me.DataGridViewTextBoxColumn2.ReadOnly = True
			Me.DataGridViewTextBoxColumn2.Width = 90
			'
			'UcSelectGridView1
			'
			Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcSelectGridView1.Location = New Point(12, 108)
			Me.UcSelectGridView1.Name = "UcSelectGridView1"
			Me.UcSelectGridView1.Size = New Size(749, 406)
			Me.UcSelectGridView1.TabIndex = 2
			'
			'ListZaikoDailyAndMonthlyForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.UcSelectGridView1)
			Me.Controls.Add(Me.LZL_BackButton)
			Me.Controls.Add(Me.LZL_ExecutButton)
			Me.Controls.Add(Me.LZL_ClearButton)
			Me.Controls.Add(Me.LZL_SelectAllButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "ListZaikoDailyAndMonthlyForm"
			Me.Text = "在庫受注残リスト(当時・月初)画面"
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

		Private Sub ListZaikoDailyAndMonthlyForm_Load(sender As Object, e As EventArgs)
			Me._conf = TopForm.ConfigData
			Me.SetToriGridView()
			Me.SetToriGridViewData()
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
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

		Private Sub AddGridViewData()
			Dim allToriSql As String = Me.GetAllToriSql()
			Dim dbParam As DataTable = Me.GetDbParam(allToriSql)
			If dbParam.Rows.Count < 0 Then
				Return
			End If
			Try
				For Each obj As Object In dbParam.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim text As String = dataRow("TORI_CD").ToString()
					Dim text2 As String = ""
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("TORI_NAME"))) Then
						text2 = Conversions.ToString(dataRow("TORI_NAME"))
					End If
					Me.UcSelectGridView1.CmpSgv.Rows.Add(New Object() {False, text, text2})
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Function GetCheckdToriCd() As List(Of String)
			Dim list As New List(Of String)()
			Try
				For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					If Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells("SelectCheckd").Value, True, False) Then
						list.Add(Conversions.ToString(dataGridViewRow.Cells("Tori_Cd").Value))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return list
		End Function

		Private Function GetDbParam(sql As String) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sql, True)
				If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function ExecStoredDbParam(paramlist As List(Of SqlDataBase.SqlParamInfo)) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Select_Zaiko_Tyuzan", paramlist, True)
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function GetAllToriSql() As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD <> '' ", New Object(-1) {}))
			Return stringBuilder.ToString()
		End Function

		Private Function GetToriSql(toricd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD = '{0}' ", toricd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetBuhinSql(toricd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_BUHIN [M_Buhin] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Buhin.TORI_CD = '{0}' ", toricd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetOrderList(path As String) As List(Of SB15M00)
			Dim list As New List(Of SB15M00)()
			Dim backOrderData As String() = Me.GetBackOrderData(path)
			If Information.IsNothing(backOrderData) Then
				Return list
			End If
			For Each text As String In backOrderData
				If text.Length >= 80 Then
					Dim item As New SB15M00(text)
					list.Add(item)
				End If
			Next
			Return list
		End Function

		Private Function GetBackOrderData(path As String) As String()
			Dim result As String() = Nothing
			Try
				If File.Exists(path) Then
					result = File.ReadAllLines(path, Me._enc)
				End If
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("GetBackOrderData Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			End Try
			Return result
		End Function

		Private Function ZaikoExec(listTori As List(Of String)) As Boolean
			If Not Me.IsDirectory(Me.csvDirectory) Then
				DlgMessageBox.Show("CSV出力フォルダが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.orderDir)
			If Not Me.IsDirectory(text) Then
				DlgMessageBox.Show("注残ファイル格納フォルダが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Dim path1 As String = String.Empty
			If Operators.CompareString(Me._conf.xmlConfData.Kyoten, "Kumamoto", False) = 0 Then
				path1 = Path.Combine(text, "SB15Q00")
			Else
				path1 = Path.Combine(text, "SB15M00")
			End If
			Dim orderList As List(Of SB15M00) = Me.GetOrderList(path1)
			If orderList.Count < 1 Then
				DlgMessageBox.Show("注残ファイルを読み込むことができません。" & vbCrLf & "または、有効なデータが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Dim now As DateTime = DateAndTime.Now
			Dim dataTable As DataTable = Me.CreateOutPutTable(now)
			Try
				For Each sb15M As SB15M00 In orderList
					If listTori.IndexOf(sb15M.tori_cd) >= 0 Then
						Dim toriTable As DataTable = Me.GetToriTable(sb15M.tori_cd)
						If toriTable.Rows.Count >= 1 Then
							Dim buhinTable As DataTable = Me.GetBuhinTable(sb15M.tori_cd)
							If buhinTable.Rows.Count >= 1 Then
								Dim paramlist As List(Of SqlDataBase.SqlParamInfo) = Me.CreateStoredParam(sb15M.tori_cd, sb15M.buhin_cd, now)
								Dim dataTable2 As DataTable = Me.ExecStoredDbParam(paramlist)
								If dataTable2.Rows.Count >= 1 Then
									Dim dataRow As DataRow = dataTable.NewRow()
									dataRow.ItemArray = dataTable2.Rows(0).ItemArray
									Me.SetOrderData(dataRow, sb15M)
									dataTable.Rows.Add(dataRow)
								End If
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As List(Of SB15M00).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			If dataTable.Rows.Count < 1 Then
				DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return False
			End If
			Me.OutPutCsv(dataTable, orderList)
			Return True
		End Function

		Private Function IsDirectory(path As String) As Boolean
			Try
				If Not Directory.Exists(path) Then
					Directory.CreateDirectory(path)
				End If
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("IsOutPutDirectory Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
				Return False
			End Try
			Return True
		End Function

		Private Sub OutPutCsv(outputTb As DataTable, orderlist As List(Of SB15M00))
			Dim list As New List(Of String)()
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Me._failfrg = False
			If Me._allfrg Then
				Dim path1 As String = "57.在庫注残リスト_全メーカー.csv"
				Dim path2 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
				Dim text As String = Path.Combine(path2, path1)
				Dim csvCommon As New CsvCommon()
				If Not csvCommon.ConvertDataTableToCsv(outputTb, text, True) Then
					Me._failfrg = True
					DlgMessageBox.Show(String.Format("CSVファイルの出力に失敗しました。" & vbCrLf & "[ファイル名]" & vbCrLf & "{0}", text), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return
				End If
			Else
				Try
					For Each sb15M As SB15M00 In orderlist
						If list.IndexOf(sb15M.tori_cd) < 0 Then
							list.Add(sb15M.tori_cd)
							Dim filterExpression As String = String.Format("取引先コード = {0}", sb15M.tori_cd)
							Dim array As DataRow() = outputTb.[Select](filterExpression)
							If array.Length >= 1 Then
								Dim dataTable As DataTable = outputTb.Clone()
								For Each dataRow As DataRow In array
									Dim dataRow2 As DataRow = dataTable.NewRow()
									dataRow2.ItemArray = dataRow.ItemArray
									dataTable.Rows.Add(dataRow2)
								Next
								Dim arg As String = Conversions.ToString(dataTable.Rows(0)("取引先コード"))
								Dim arg2 As String = Conversions.ToString(dataTable.Rows(0)("取引先名"))
								Dim path3 As String = String.Format("57.在庫注残リスト_{0}{1}.csv", arg, arg2)
								Dim path4 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
								Dim text2 As String = Path.Combine(path4, path3)
								Dim csvCommon2 As New CsvCommon()
								num += 1
								If Not csvCommon2.ConvertDataTableToCsv(dataTable, text2, True) Then
									num2 += 1
									DlgMessageBox.Show(String.Format("CSVファイルの出力に失敗しました。" & vbCrLf & "[ファイル名]" & vbCrLf & "{0}", text2), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								End If
							End If
						End If
					Next
				Finally
					Dim enumerator As List(Of SB15M00).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				If num = num2 Then
					Me._failfrg = True
				End If
			End If
		End Sub

		Private Function CreateOutPutTable(execday As DateTime) As DataTable
			Dim dataTable As DataTable = Nothing
			Dim paramlist As List(Of SqlDataBase.SqlParamInfo) = Me.CreateStoredParam("", "", execday)
			dataTable = Me.ExecStoredDbParam(paramlist)
			Me._addcolList = New List(Of String)()
			Dim num As Integer = -1
			Do
				Dim month As Integer = execday.AddMonths(num).Month
				Dim item As String = String.Format("注残数量{0:00}月", month)
				Me._addcolList.Add(item)
				num += 1
			Loop While num <= 2
			Dim num2 As Integer = -1
			Do
				Dim month2 As Integer = execday.AddMonths(num2).Month
				Dim item2 As String = String.Format("不足数量{0:00}月", month2)
				Me._addcolList.Add(item2)
				num2 += 1
			Loop While num2 <= 2
			Me._addcolList.Add("合計")
			Me._addcolList.Add("過剰数量")
			Try
				For Each columnName As String In Me._addcolList
					dataTable.Columns.Add(columnName)
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return dataTable
		End Function

		Private Sub SetOrderData(row As DataRow, order As SB15M00)
			Dim dictionary As New Dictionary(Of String, Integer)()
			Dim dictionary2 As New Dictionary(Of String, Integer)()
			Dim num As Integer = Conversions.ToInteger(row("在庫"))
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			If num < 0 Then
				num3 = num * -1
			End If
			Try
				For Each text As String In Me._addcolList
					If text.IndexOf("注残数量") >= 0 Then
						Dim count As Integer = dictionary.Count
						Dim kosu As Integer = order.datalist(count).kosu
						dictionary.Add(text, kosu)
					End If
					If text.IndexOf("不足数量") >= 0 Then
						Dim count2 As Integer = dictionary2.Count
						Dim kosu2 As Integer = order.datalist(count2).kosu
						Dim num4 As Integer = 0
						If num < 1 Then
							num4 = kosu2
						ElseIf num3 > 0 Then
							num4 = kosu2
						Else
							Dim num5 As Integer = num - (num2 + kosu2)
							If num5 < 0 Then
								num5 *= -1
								num4 = num5
							End If
						End If
						num2 += kosu2
						num3 += num4
						dictionary2.Add(text, num4)
					End If
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each keyValuePair As KeyValuePair(Of String, Integer) In dictionary
					row(keyValuePair.Key) = keyValuePair.Value
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, Integer).Enumerator = Nothing
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Try
				For Each keyValuePair2 As KeyValuePair(Of String, Integer) In dictionary2
					row(keyValuePair2.Key) = keyValuePair2.Value
				Next
			Finally
				Dim enumerator3 As Dictionary(Of String, Integer).Enumerator = Nothing
				CType(enumerator3, IDisposable).Dispose()
			End Try
			row("合計") = num3
			Dim num6 As Integer = num - num2
			If num6 < 0 Then
				num6 = 0
			End If
			row("過剰数量") = num6
		End Sub

		Private Function CreateStoredParam(toricd As String, buhincd As String, execDate As DateTime) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@ID_Tori", .type = SqlDbType.NVarChar, .val = toricd}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Buhin", .type = SqlDbType.NVarChar, .val = buhincd}, New SqlDataBase.SqlParamInfo() With {.name = "S_SyuriYYYYMMDD", .type = SqlDbType.[Date], .val = execDate.ToString("yyyy/MM/dd")}}
		End Function

		Private Function GetToriTable(toricd As String) As DataTable
			Dim toriSql As String = Me.GetToriSql(toricd)
			Return Me.GetDbParam(toriSql)
		End Function

		Private Function GetBuhinTable(toricd As String) As DataTable
			Dim buhinSql As String = Me.GetBuhinSql(toricd)
			Return Me.GetDbParam(buhinSql)
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("LZL_ClearButton")>
		Private WithEvents LZL_ClearButton As Button

		<AccessedThroughProperty("LZL_SelectAllButton")>
		Private WithEvents LZL_SelectAllButton As Button

		<AccessedThroughProperty("LZL_BackButton")>
		Private WithEvents LZL_BackButton As Button

		<AccessedThroughProperty("LZL_ExecutButton")>
		Private WithEvents LZL_ExecutButton As Button

		<AccessedThroughProperty("DataGridViewTextBoxColumn1")>
		Private WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("DataGridViewTextBoxColumn2")>
		Private WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

		<AccessedThroughProperty("UcSelectGridView1")>
		Private WithEvents UcSelectGridView1 As UcSelectGridView

		<AccessedThroughProperty("CmpSgv")>
		Private _CmpSgv As CmpSelectGridView

		Private Const BACKORDER_FILE_NAME As String = "SB15M00"

		Private Const BACKORDER_FILE_NAME_Q As String = "SB15Q00"

		Private orderDir As String

		Private Const OUTPUT_FILE_NAME As String = "57.在庫注残リスト_{0}{1}.csv"

		Private Const OUTPUT_ALL_FILE_NAME As String = "57.在庫注残リスト_全メーカー.csv"

		Private csvDirectory As String

		Private Const GRID_COLUMN_SELECT As String = "SelectCheckd"

		Private Const GRID_COLUMN_TORICD As String = "Tori_Cd"

		Private Const GRID_COLUMN_TORINAME As String = "Tori_Name"

		Private Const STORED_NAME As String = "Ukeharai.Select_Zaiko_Tyuzan"

		Private _conf As XmlConfigControl

		Private _addcolList As List(Of String)

		Private _allfrg As Boolean

		Private _failfrg As Boolean

		Private _enc As Encoding

		Private Sub LZL_SelectAllButton_Click(sender As Object, e As EventArgs) Handles LZL_SelectAllButton.Click
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

		Private Sub LZL_ClearButton_Click(sender As Object, e As EventArgs) Handles LZL_ClearButton.Click
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

		Private Sub LZL_ExecutButton_Click(sender As Object, e As EventArgs) Handles LZL_ExecutButton.Click

			Dim checkdToriCd As List(Of String) = Me.GetCheckdToriCd()
			Dim count As Integer = Me.UcSelectGridView1.CmpSgv.Rows.Count
			If checkdToriCd.Count < 1 Then
				DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If count = checkdToriCd.Count Then
				Me._allfrg = True
			Else
				Me._allfrg = False
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			If Not Me.ZaikoExec(checkdToriCd) Then
				DlgMessageBox.Show("CSV出力を中断しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			ElseIf Me._failfrg Then
				DlgMessageBox.Show("CSV出力できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				DlgMessageBox.Show("CSV出力が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.None)
			End If
		End Sub

		Private Sub LZL_BackButton_Click(sender As Object, e As EventArgs) Handles LZL_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
