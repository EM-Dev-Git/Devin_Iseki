Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	Public Class clsDirectPrintSeikyu
		Implements IDisposable

		Public Sub New()
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_seikyu = Nothing
			Me._arry_tori = New List(Of String)()
			Me._seqnum = 0
			Me._arry_newSeqnum = New List(Of String())()
		End Sub

		Private Function CreateStream(name As String, fileNameExtension As String, encoding As Encoding, mimeType As String, willSeek As Boolean) As Stream
			Dim stream As Stream = New MemoryStream()
			Me._streams.Add(stream)
			Return stream
		End Function

		Private Sub Export(report As LocalReport)
			Dim text As String = "<DeviceInfo><OutputFormat>EMF</OutputFormat></DeviceInfo>"
			Dim array As Warning() = Nothing
			Me._streams = New List(Of Stream)()
			report.Render("Image", text, AddressOf Me.CreateStream, array)
			Try
				For Each stream As Stream In Me._streams
					stream.Position = 0L
				Next
			Finally
				Dim enumerator As IEnumerator(Of Stream) = Nothing
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		Private Sub PrintPage(sender As Object, ev As PrintPageEventArgs)
			Dim image As New Metafile(Me._streams(Me._currentPageIndex))
			Dim rect As New Rectangle(ev.PageBounds.Left - CInt(Math.Round(CDbl(ev.PageSettings.HardMarginX))), ev.PageBounds.Top - CInt(Math.Round(CDbl(ev.PageSettings.HardMarginY))), ev.PageBounds.Width, ev.PageBounds.Height)
			ev.Graphics.FillRectangle(Brushes.White, rect)
			ev.Graphics.DrawImage(image, rect)
			Me._currentPageIndex += 1
			ev.HasMorePages = (Me._currentPageIndex < Me._streams.Count)
		End Sub

		Private Sub Print()
			If Me._streams Is Nothing OrElse Me._streams.Count = 0 Then
				Throw New Exception("印刷領域を確保できませんでした。")
			End If
			Dim printDocument As New PrintDocument()
			If Not printDocument.PrinterSettings.IsValid Then
				Throw New Exception("印刷領域を確保できませんでした。")
			End If
			AddHandler printDocument.PrintPage, AddressOf Me.PrintPage
			Me._currentPageIndex = 0
			printDocument.Print()
		End Sub

		Private Sub Run(a_date As DateTime, a_toricd As List(Of String))
			Me._conf = TopForm.ConfigData
			Me._sConnectDB = Common.makeConnectionString(Me._conf)
			Me._date = a_date
			Me._toricd = a_toricd
			Me.getDataBase()
			Me.updateDataBase()
			If Me._seq_plus = True Then
				Me.getDataBase()
			End If
			If Me._dt_seikyu Is Nothing OrElse Me._dt_seikyu.Rows.Count = 0 Then
				Throw New Exception("該当する請求書データが存在しません。")
			End If
			Dim localReport As New LocalReport()
			localReport.ReportPath = FileSystem.CurDir() + "\OutputSeikyuReportS.rdlc"
			localReport.DataSources.Clear()
			localReport.DataSources.Add(New ReportDataSource("DataSet1", Me._dt_seikyu))
			localReport.DataSources.Add(New ReportDataSource("DataSet2", Me._dt_m_josu))
			Dim str As String = DateTime.DaysInMonth(Me._date.Year, Me._date.Month).ToString()
			Dim list As New List(Of ReportParameter)()
			Dim list2 As List(Of ReportParameter) = list
			list2.Add(New ReportParameter("DateFm", Me._date.ToString("yyyy年MM月01日")))
			list2.Add(New ReportParameter("DateTo", Me._date.ToString("yyyy年MM月") + str + "日"))
			localReport.SetParameters(list)
			Me.Export(localReport)

			Me.Print()

		End Sub

		Private Sub getDataBase()
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = "SELECT JOSU_CD, KAISYA, JIGYOSYO, JUSYO1, JUSYO2, JUSYO3, GREETING1, GREETING2, KOZA_GUIDANCE, KOZA1, KOZA2, CHIKU_NAME, ZEIRITU, PREFIX, SEQNUM"
				text += " FROM Ukeharai.M_JOSU"
				text += " ORDER BY JOSU_CD DESC"
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Else
					Me._dt_m_josu = sqlDataBase.DbDataTable
					If sqlDataBase.DbDataTable.Rows.Count > 0 Then
						Me._seqnum = Conversions.ToInteger(Me._dt_m_josu.Rows(0)("SEQNUM"))
					End If
				End If
			End Using
			Using sqlDataBase2 As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text2 As String = "SELECT H.TORI_CD, H.SEIKYU_YYYYMM, H.SEIKYU_TYPE, H.SEIKYU_NO, H.KAZEI, H.HIKAZEI, H.SYOHIZEI, H.GOUKEI, M.SEIKYU_SQNO, M.SAKU_KBN, M.UCHIWAKE, M.SURYO, M.TANI, "
				text2 += " M.TANKA, M.KINGAKU, M.MEISAI_UMU, M.SAKI_CD, M.TEKIYO, T.TORI_NAME"
				text2 += " FROM Ukeharai.T_SEIKYU AS H LEFT OUTER JOIN"
				text2 += " Ukeharai.T_SEIKYUM AS M ON H.TORI_CD = M.TORI_CD AND H.SEIKYU_YYYYMM = M.SEIKYU_YYYYMM LEFT OUTER JOIN"
				text2 += " Ukeharai.M_TORI AS T ON H.TORI_CD = T.TORI_CD"
				text2 = text2 + " WHERE (H.SEIKYU_YYYYMM = '" + Conversions.ToString(Me._date) + "')"
				If Me._toricd IsNot Nothing Then
					Dim text3 As String = String.Empty
					Try
						For Each str As String In Me._toricd
							text3 = text3 + "'" + str + "', "
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator = Nothing
						CType(enumerator, IDisposable).Dispose()
					End Try
					text3 = text3.Remove(text3.Length - 2)
					text2 = text2 + " AND (H.TORI_CD IN (" + text3 + "))"
				End If
				text2 += " ORDER BY H.TORI_CD, H.SEIKYU_YYYYMM, H.SEIKYU_NO"
				Dim sqldata2 As String = sqlDataBase2.getSQLData(text2, True)
				If Not String.IsNullOrEmpty(sqldata2) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				ElseIf sqlDataBase2.DbDataTable.Rows.Count <> 0 Then
					Me._arry_newSeqnum.Clear()
					Me._dt_seikyu = sqlDataBase2.DbDataTable
					Try
						For Each obj As Object In Me._dt_seikyu.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("UCHIWAKE"))) Then
								dataRow("UCHIWAKE") = Regex.Replace(Conversions.ToString(dataRow("UCHIWAKE")), "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．", "")
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator = Nothing
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Try
						For Each obj2 As Object In Me._dt_seikyu.Rows
							Dim dataRow2 As DataRow = CType(obj2, DataRow)
							Me._arry_tori.Add(Conversions.ToString(dataRow2("TORI_CD")))
						Next
					Finally
						Dim enumerator3 As IEnumerator = Nothing
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim text4 As String = Conversions.ToString(Me._dt_seikyu.Rows(0)("TORI_CD"))
					Dim text5 As String = String.Empty
					Try
						Dim loopchk As Boolean
						loopchk = True
						For Each text6 As String In Me._arry_tori
							num += 1
							num2 += 1
							If Not text5.Equals(RuntimeHelpers.GetObjectValue(Me._dt_seikyu.Rows(num2 - 1)("TORI_CD"))) AndAlso String.IsNullOrEmpty(Conversions.ToString(Me._dt_seikyu.Rows(num2 - 1)("SEIKYU_NO"))) Then
								text5 = Conversions.ToString(Me._dt_seikyu.Rows(num2 - 1)("TORI_CD"))
								Me._seqnum += 1
								If Me._seqnum > 99999 Then
									Me._seqnum = 1
								End If
								If loopchk = True Then
									Me._seq_chk = Me._seqnum
									loopchk = False
								End If
								Me._dt_seikyu.Rows(num2 - 1)("SEIKYU_NO") = String.Format("{0:D5}", Me._seqnum)
								Me._arry_newSeqnum.Add(New String() {text5, Me._seqnum.ToString()})
							End If
							Dim text7 As String = Conversions.ToString(Me._dt_seikyu.Rows(num2 - 1)("SEIKYU_NO"))
							If Not String.IsNullOrEmpty(text7) Then
								Dim s As String = text7
								Dim dataRow3 As DataRow = Me._dt_seikyu.Rows(num2 - 1)
								Dim dataRow4 As DataRow = dataRow3
								Dim columnName As String = "SEIKYU_NO"
								Dim num3 As Integer = Conversions.ToInteger(dataRow4(columnName))
								Integer.TryParse(s, num3)
								dataRow3(columnName) = num3
							End If
							If text4.Equals(text6) Then
								If Me._dt_seikyu.Rows.Count = num2 Then
									num += 1
									For i As Integer = num To 30
										Dim dataRow5 As DataRow = Me._dt_seikyu.NewRow()
										dataRow5("TORI_CD") = text4
										Me._dt_seikyu.Rows.Add(dataRow5)
										num2 += 1
									Next
									Exit For
								End If
							Else
								Dim num4 As Integer = num2 - num
								For j As Integer = num To 30
									Dim dataRow6 As DataRow = Me._dt_seikyu.NewRow()
									dataRow6("TORI_CD") = text4
									Me._dt_seikyu.Rows.InsertAt(dataRow6, num4 + j - 1)
									num2 += 1
								Next
								If Me._dt_seikyu.Rows.Count = num2 Then
									num = 2
									text4 = text6
									For k As Integer = num To 30
										Dim dataRow7 As DataRow = Me._dt_seikyu.NewRow()
										dataRow7("TORI_CD") = text4
										Me._dt_seikyu.Rows.Add(dataRow7)
										num2 += 1
									Next
									Exit For
								End If
								num = 1
								text4 = text6
							End If
						Next
					Finally
						Dim enumerator4 As List(Of String).Enumerator = Nothing
						CType(enumerator4, IDisposable).Dispose()
					End Try
				End If
			End Using
		End Sub

		Private Sub updateDataBase()
			If Me._arry_newSeqnum.Count = 0 Then
				Me._seq_plus = False
				Return
			End If
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Try
					sqlDataBase.BeginTransaction()
					Using sqlDataBase_chk As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
						Dim text_chk As String = "SELECT SEQNUM FROM Ukeharai.M_JOSU ORDER BY JOSU_CD DESC"
						Dim sqldata_chk As String = sqlDataBase_chk.getSQLData(text_chk, True)
						If Not String.IsNullOrEmpty(sqldata_chk) Then
							DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return
						Else
							Me._table_chk = sqlDataBase_chk.DbDataTable
							Dim seq_chk_print As Integer
							seq_chk_print = Conversions.ToInteger(Me._table_chk.Rows(0)("SEQNUM")) + 1
							If seq_chk_print <> Me._seq_chk Then
								Me._seqnum = seq_chk_print
								Dim list_change As String() = Me._arry_newSeqnum(0)
								list_change(1) = seq_chk_print.ToString
								Me._arry_newSeqnum(0) = list_change
								Me._seq_plus = True
							Else
								Me._seq_plus = False
							End If

						End If
					End Using

					Dim text As String = String.Empty
					Try
						For Each array As String() In Me._arry_newSeqnum
							text = "UPDATE Ukeharai.T_SEIKYU SET SEIKYU_NO = '" + String.Format("{0:D5}", Integer.Parse(array(1))) + "', "
							text = text + "UPDATE_USER = '" + Me._conf.xmlConfData.xDataBase.UserId + "', "
							text = text + "UPDATE_DTM = '" + Conversions.ToString(DateAndTime.Now) + "', "
							text += "UPDATE_FUNCTION = 'clsDirectPrintSeikyu' "
							text = String.Concat(New String() {text, "WHERE TORI_CD = '", array(0), "' AND SEIKYU_YYYYMM = '", Conversions.ToString(Me._date), "' "})
							If Not sqlDataBase.execSql(text) Then
								DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Return
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator = Nothing
						CType(enumerator, IDisposable).Dispose()
					End Try
					text = "UPDATE Ukeharai.M_JOSU SET SEQNUM = " + Me._seqnum.ToString() + ", "
					text = text + "UPDATE_USER = '" + Me._conf.xmlConfData.xDataBase.UserId + "', "
					text = text + "UPDATE_DTM = '" + Conversions.ToString(DateAndTime.Now) + "', "
					text += "UPDATE_FUNCTION = 'clsDirectPrintSeikyu' "
					If sqlDataBase.execSql(text) Then
						sqlDataBase.CommitTransact()
					Else
						DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				Catch ex As Exception
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End Using
		End Sub

		Public Sub Dispose() Implements System.IDisposable.Dispose
			If Me._streams IsNot Nothing Then
				Try
					For Each stream As Stream In Me._streams
						stream.Close()
					Next
				Finally
					Dim enumerator As IEnumerator(Of Stream) = Nothing
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me._streams = Nothing
			End If
		End Sub

		Public Shared Sub ExecPrint(a_date As DateTime, a_toricd As List(Of String))
			Using clsDirectPrintSeikyu As New clsDirectPrintSeikyu()
				Cursor.Current = Cursors.WaitCursor
				clsDirectPrintSeikyu.Run(a_date, a_toricd)
			End Using
		End Sub

		Private _sConnectDB As String

		Private _conf As XmlConfigControl

		Private _date As DateTime

		Private _toricd As List(Of String)

		Private Const PRINT_MAXRECORD As Integer = 30

		Private Const REGEX_STR As String = "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．"

		Private _dt_m_josu As DataTable

		Private _dt_seikyu As DataTable

		Private _arry_tori As List(Of String)

		Private _seqnum As Integer

		Private _arry_newSeqnum As List(Of String())

		Private _currentPageIndex As Integer

		Private _streams As IList(Of Stream)

		Private _seq_chk As Integer

		Private _table_chk As DataTable

		Private _seq_plus As Boolean
	End Class
End Namespace
