Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class OutPutSeikyuFormReportViewUchiwake
		Inherits Form

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
			Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource()
			Dim ReportDataSource2 As New Microsoft.Reporting.WinForms.ReportDataSource()
			Me.UchiwakeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.OutputSeikyu = New IbUkeharai.OutputSeikyu()
			Me.M_JOSUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
			CType(Me.UchiwakeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.OutputSeikyu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.M_JOSUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'UchiwakeTableBindingSource
			'
			Me.UchiwakeTableBindingSource.DataMember = "UchiwakeTable"
			Me.UchiwakeTableBindingSource.DataSource = Me.OutputSeikyu
			'
			'OutputSeikyu
			'
			Me.OutputSeikyu.DataSetName = "OutputSeikyu"
			Me.OutputSeikyu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			'
			'M_JOSUBindingSource
			'
			Me.M_JOSUBindingSource.DataMember = "M_JOSU"
			Me.M_JOSUBindingSource.DataSource = Me.OutputSeikyu
			'
			'ReportViewer1
			'
			Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			ReportDataSource1.Name = "DataSet1"
			ReportDataSource1.Value = Me.UchiwakeTableBindingSource
			ReportDataSource2.Name = "DataSet2"
			ReportDataSource2.Value = Me.M_JOSUBindingSource
			Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
			Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
			Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IbUkeharai.OutputSeikyuReportU.rdlc"
			Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
			Me.ReportViewer1.Name = "ReportViewer1"
			Me.ReportViewer1.ServerReport.BearerToken = Nothing
			Me.ReportViewer1.ShowExportButton = False
			Me.ReportViewer1.Size = New System.Drawing.Size(984, 477)
			Me.ReportViewer1.TabIndex = 0
			'
			'OutPutSeikyuFormReportViewUchiwake
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(984, 477)
			Me.Controls.Add(Me.ReportViewer1)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "OutPutSeikyuFormReportViewUchiwake"
			Me.Text = "内訳"
			CType(Me.UchiwakeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.OutputSeikyu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.M_JOSUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
#End Region
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmReportView_Load
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_ukeharai = Nothing
			Me._dateFm = String.Empty
			Me._dateTo = String.Empty
			Me.InitializeComponent()
			Me._conf = TopForm.ConfigData
			Me._sConnectDB = Common.makeConnectionString(Me._conf)
		End Sub

		Public Sub New(a_date As DateTime, a_kind As Integer, a_toricd As List(Of String))
			AddHandler MyBase.Load, AddressOf Me.frmReportView_Load
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_ukeharai = Nothing
			Me._dateFm = String.Empty
			Me._dateTo = String.Empty
			Me.InitializeComponent()
			Me._conf = TopForm.ConfigData
			Me._sConnectDB = Common.makeConnectionString(Me._conf)
			Dim str As String = DateTime.DaysInMonth(a_date.Year, a_date.Month).ToString()
			Me._date = a_date
			Me._dateFm = Me._date.ToString("yyyy/MM/01")
			Me._dateTo = Me._date.ToString("yyyy/MM/") + str
			Me._kind = a_kind
			Me._toricd = a_toricd
			Me.getDataBase()
		End Sub

		Private Sub frmReportView_Load(sender As Object, e As EventArgs)
			If Me._dt_ukeharai Is Nothing OrElse Me._dt_ukeharai.Rows.Count = 0 Then
				DlgMessageBox.Show("該当する請求書明細データが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.Close()
				Return
			End If
			Me.ReportViewer1.LocalReport.DataSources.Clear()
			Dim reportDataSource As New ReportDataSource()
			reportDataSource.Name = "DataSet1"
			reportDataSource.Value = Me._print_meisai
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			reportDataSource = New ReportDataSource()
			reportDataSource.Name = "DataSet2"
			reportDataSource.Value = Me._dt_m_josu
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			Me.ReportViewer1.SetDisplayMode(CType(1, DisplayMode))
			Me.ReportViewer1.ZoomMode = CType(1, ZoomMode)
			Dim str As String = DateTime.DaysInMonth(Me._date.Year, Me._date.Month).ToString()
			Dim list As New List(Of ReportParameter)()
			Dim list2 As List(Of ReportParameter) = list
			list2.Add(New ReportParameter("DateFm", Me._date.ToString("yyyy年MM月01日")))
			list2.Add(New ReportParameter("DateTo", Me._date.ToString("yyyy年MM月") + str + "日"))
			Me.ReportViewer1.LocalReport.SetParameters(list)
			Me.ReportViewer1.RefreshReport()
		End Sub

		Private Sub ReportViewer1_PrintingBegin(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs)
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("ReportViewer1")>
		Private WithEvents ReportViewer1 As ReportViewer

		<AccessedThroughProperty("UchiwakeTableBindingSource")>
		Private WithEvents UchiwakeTableBindingSource As BindingSource

		<AccessedThroughProperty("OutputSeikyu")>
		Private WithEvents OutputSeikyu As OutputSeikyu

		<AccessedThroughProperty("M_JOSUBindingSource")>
		Private WithEvents M_JOSUBindingSource As BindingSource

		Private _sConnectDB As String

		Private _conf As XmlConfigControl

		Private _date As DateTime

		Private _kind As Integer

		Private _toricd As List(Of String)

		Private Const PRINT_MAXRECORD As Integer = 45

		Private _dt_m_josu As DataTable

		Private _dt_ukeharai As DataTable

		Private _print_meisai As DataTable

		Private _dateFm As String

		Private _dateTo As String
	End Class
End Namespace
