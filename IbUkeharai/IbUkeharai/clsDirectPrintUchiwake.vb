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
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	Public Class clsDirectPrintUchiwake
		Implements IDisposable

		Public Sub New()
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_ukeharai = Nothing
			Me._seqnum = 0
			Me.pageNum = 0
			Me._dateFm = String.Empty
			Me._dateTo = String.Empty
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
			Dim str As String = DateTime.DaysInMonth(a_date.Year, a_date.Month).ToString()
			Me._date = a_date
			Me._dateFm = Me._date.ToString("yyyy/MM/01")
			Me._dateTo = Me._date.ToString("yyyy/MM/") + str
			Me._toricd = a_toricd
			Me.getDataBase()
			If Me._dt_ukeharai Is Nothing OrElse Me._dt_ukeharai.Rows.Count = 0 Then
				Throw New Exception("該当する請求書データが存在しません。")
			End If
			Dim localReport As New LocalReport()
			localReport.ReportPath = FileSystem.CurDir() + "\OutputSeikyuReportU.rdlc"
			localReport.DataSources.Clear()
			localReport.DataSources.Add(New ReportDataSource("DataSet1", Me._print_meisai))
			localReport.DataSources.Add(New ReportDataSource("DataSet2", Me._dt_m_josu))
			Dim list As New List(Of ReportParameter)()
			Dim list2 As List(Of ReportParameter) = list
			list2.Add(New ReportParameter("DateFm", Me._date.ToString("yyyy年MM月01日")))
			list2.Add(New ReportParameter("DateTo", Me._date.ToString("yyyy年MM月") + str + "日"))
			localReport.SetParameters(list)
			Me.Export(localReport)
			Me.Print()
		End Sub

		Private Sub getDataBase()
			' The following expression was wrapped in a checked-statement

			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim stringBuilder As New StringBuilder()
				stringBuilder.Append("SELECT 0 AS ROWCNT, ")
				stringBuilder.Append("TBL.TORI_CD, TBL.BUHIN_CD, TBL.SAKI_CD, SUM(TBL.KOSU) AS KOSU, ")
				stringBuilder.Append("MAX(CASE WHEN TBL.SEIKYU_TYPE = '1' THEN TBL.TESU ELSE NULL END) AS TESU, SUM(TBL.KINGAKU) AS KINGAKU, ")
				stringBuilder.Append("MAX(TBL.BUHIN_NAME) AS BUHIN_NAME, MAX(TBL.KIKAKU) AS KIKAKU, MAX(TBL.SAKI_ABBREVIATION) AS SAKI_ABBREVIATION, ")
				stringBuilder.Append("MAX(TBL.TORI_NAME) AS TORI_NAME, MAX(TBL.SEIKYU_TYPE) AS SEIKYU_TYPE, MAX(TBL.HASU) AS HASU ")
				stringBuilder.Append("FROM (")
				stringBuilder.Append(vbTab & "SELECT")
				stringBuilder.Append(vbTab & vbTab & "M.TORI_CD, M.BUHIN_CD, M.SAKI_CD, M.KOSU, ")
				stringBuilder.Append(vbTab & vbTab & "(" & vbTab & "SELECT TOP(1) A.TESU")
				stringBuilder.Append(vbTab & vbTab & vbTab & "FROM Ukeharai.T_UKEHARAIMEISAI A ")
				stringBuilder.Append(vbTab & vbTab & vbTab & "WHERE A.TORI_CD = M.TORI_CD AND A.BUHIN_CD = M.BUHIN_CD AND A.UKEHARAI_KBN = M.UKEHARAI_KBN AND A.DEN_NO = M.DEN_NO ")
				stringBuilder.Append(vbTab & vbTab & vbTab & "ORDER BY UKEHARA_YYYYMMDD DESC) AS TESU, ")
				stringBuilder.Append(vbTab & vbTab & "M.KINGAKU AS KINGAKU, B.BUHIN_NAME AS BUHIN_NAME, B.KIKAKU AS KIKAKU, S.SAKI_ABBREVIATION AS SAKI_ABBREVIATION, T.TORI_NAME AS TORI_NAME, T.SEIKYU_TYPE AS SEIKYU_TYPE, T.HASU_KBN AS HASU ")
				stringBuilder.Append(vbTab & "FROM Ukeharai.T_UKEHARAIMEISAI AS M INNER JOIN Ukeharai.T_SEIKYU AS SEKY ON M.TORI_CD = SEKY.TORI_CD LEFT JOIN Ukeharai.M_BUHIN AS B ON M.TORI_CD = B.TORI_CD AND  M.BUHIN_CD = B.BUHIN_CD LEFT JOIN Ukeharai.M_SAKI AS S ON M.SAKI_CD = S.SAKI_CD LEFT JOIN Ukeharai.M_TORI AS T ON M.TORI_CD = T.TORI_CD ")
				stringBuilder.Append(String.Concat(New String() {vbTab & "WHERE (M.UKEHARA_YYYYMMDD >= '", Me._dateFm, "' AND M.UKEHARA_YYYYMMDD <= '", Me._dateTo, "')"}))
				stringBuilder.Append(String.Concat(New String() {"  AND (SEKY.SEIKYU_YYYYMM >= '", Me._dateFm, "' AND SEKY.SEIKYU_YYYYMM <= '", Me._dateTo, "')"}))
				stringBuilder.Append("  AND M.UKEHARAI_KBN = '2'")
				If Me._toricd IsNot Nothing Then
					Dim text As String = String.Empty
					Try
						For Each str As String In Me._toricd
							text = text + "'" + str + "', "
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator = Nothing
						CType(enumerator, IDisposable).Dispose()
					End Try
					text = text.Remove(text.Length - 2)
					stringBuilder.Append("  AND (M.TORI_CD IN (" + text + ")) ")
				End If
				stringBuilder.Append(") AS TBL ")
				stringBuilder.Append("GROUP BY TBL.TORI_CD, TBL.BUHIN_CD, TBL.SAKI_CD ")
				stringBuilder.Append("ORDER BY TBL.TORI_CD, TBL.SAKI_CD, TBL.BUHIN_CD ")
				Dim sqldata As String = sqlDataBase.getSQLData(stringBuilder.ToString(), True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return
				End If
				If sqlDataBase.DbDataTable.Rows.Count <> 0 Then
					Dim num As Integer = 0
					Me._dt_ukeharai = sqlDataBase.DbDataTable
					Dim num2 As Long = 0L
					Dim num3 As Long = 0L
					Dim num4 As Integer = 0
					Dim num5 As Integer = 0
					Dim text2 As String = Conversions.ToString(Me._dt_ukeharai.Rows(0)("TORI_CD"))
					Dim text3 As String = Conversions.ToString(Me._dt_ukeharai.Rows(0)("SAKI_CD"))
					Dim num6 As Long = 0L
					Dim num7 As Long = 0L
					Me._print_meisai = Me._dt_ukeharai.Clone()
					Try
						For Each obj As Object In Me._dt_ukeharai.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim text4 As String = Conversions.ToString(dataRow("TORI_CD"))
							Dim text5 As String = Conversions.ToString(dataRow("SAKI_CD"))
							Dim value As String = Conversions.ToString(dataRow("SEIKYU_TYPE"))
							If "1".Equals(value) Then
								Dim dbl As Double = Conversions.ToDouble(Operators.MultiplyObject(dataRow("KOSU"), dataRow("TESU")))
								dataRow("KINGAKU") = Common.hasu(dbl, Conversions.ToString(dataRow("HASU")))
							End If
							num4 += 1
							num5 += 1
							If text2.Equals(text4) AndAlso text3.Equals(text5) Then
								num6 = Conversions.ToLong(Operators.AddObject(num6, dataRow("KOSU")))
								num7 += Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dataRow("KINGAKU")))
								num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow("KOSU")))
								num3 += Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dataRow("KINGAKU")))
								dataRow("ROWCNT") = num4
								Dim dataRow2 As DataRow = dataRow
								Dim dataRow3 As DataRow = dataRow2
								Dim columnName As String = "TORI_CD"
								dataRow3(columnName) = Operators.ConcatenateObject(dataRow2(columnName), "-" + num.ToString())
								Me._print_meisai.ImportRow(dataRow)
								If num4 Mod 45 = 0 AndAlso Me._dt_ukeharai.Rows.Count <> num5 Then
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text4 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "計"
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_NAME") = "続きあり"
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = DBNull.Value
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = DBNull.Value
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text4 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = ""
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = DBNull.Value
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = DBNull.Value
									num += 1
								End If
							Else
								For i As Integer = num4 Mod 45 To 45
									num4 += 1
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
								Next
								If Not text2.Equals(text4) Then
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "小計"
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = num6
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = num7
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "合計"
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = num2
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = num3
									num6 = 0L
									num7 = 0L
									num2 = 0L
									num3 = 0L
								ElseIf Not text3.Equals(text5) Then
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "小計"
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = num6
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = num7
									Me._print_meisai.Rows.Add(New Object(-1) {})
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = ""
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = DBNull.Value
									Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = DBNull.Value
									num6 = 0L
									num7 = 0L
								End If
								num += 1
								num4 = 1
								num6 = Conversions.ToLong(Operators.AddObject(num6, dataRow("KOSU")))
								num7 += Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dataRow("KINGAKU")))
								num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow("KOSU")))
								num3 += Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dataRow("KINGAKU")))
								dataRow("ROWCNT") = num4
								Dim dataRow2 As DataRow = dataRow
								Dim dataRow4 As DataRow = dataRow2
								Dim columnName As String = "TORI_CD"
								dataRow4(columnName) = Operators.ConcatenateObject(dataRow2(columnName), "-" + num.ToString())
								Me._print_meisai.ImportRow(dataRow)
							End If
							text2 = text4
							text3 = text5
						Next
					Finally
						Dim enumerator2 As IEnumerator = Nothing
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					For j As Integer = num4 Mod 45 To 45
						num4 += 1
						Me._print_meisai.Rows.Add(New Object(-1) {})
						Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
					Next
					Me._print_meisai.Rows.Add(New Object(-1) {})
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "小計"
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = num6
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = num7
					Me._print_meisai.Rows.Add(New Object(-1) {})
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("TORI_CD") = text2 + "-" + num.ToString()
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("BUHIN_CD") = "合計"
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KOSU") = num2
					Me._print_meisai.Rows(Me._print_meisai.Rows.Count - 1)("KINGAKU") = num3
				End If
			End Using
			Using sqlDataBase2 As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text6 As String = "SELECT JOSU_CD, KAISYA, JIGYOSYO, JUSYO1, JUSYO2, JUSYO3, GREETING1, GREETING2, KOZA_GUIDANCE, KOZA1, KOZA2, CHIKU_NAME, ZEIRITU, PREFIX, SEQNUM"
				text6 += " FROM Ukeharai.M_JOSU"
				text6 += " ORDER BY JOSU_CD DESC"
				Dim sqldata2 As String = sqlDataBase2.getSQLData(text6, True)
				If Not String.IsNullOrEmpty(sqldata2) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Else
					Me._dt_m_josu = sqlDataBase2.DbDataTable
					If sqlDataBase2.DbDataTable.Rows.Count > 0 Then
					End If
				End If
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
			Using clsDirectPrintUchiwake As New clsDirectPrintUchiwake()
				Cursor.Current = Cursors.WaitCursor
				clsDirectPrintUchiwake.Run(a_date, a_toricd)
			End Using
		End Sub

		Private _sConnectDB As String

		Private _conf As XmlConfigControl

		Private _date As DateTime

		Private _toricd As List(Of String)

		Private Const PRINT_MAXRECORD As Integer = 45

		Private _dt_m_josu As DataTable

		Private _dt_ukeharai As DataTable

		Private _seqnum As Integer

		Private pageNum As Integer

		Private _print_meisai As DataTable

		Private _dateFm As String

		Private _dateTo As String

		Private _currentPageIndex As Integer

		Private _streams As IList(Of Stream)
	End Class
End Namespace
