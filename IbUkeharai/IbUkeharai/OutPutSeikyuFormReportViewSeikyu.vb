Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
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

	<DesignerGenerated()>
	Public Class OutPutSeikyuFormReportViewSeikyu
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
			Me.SeikyuTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.OutputSeikyu = New IbUkeharai.OutputSeikyu()
			Me.M_JOSUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
			CType(Me.SeikyuTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.OutputSeikyu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.M_JOSUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'SeikyuTableBindingSource
			'
			Me.SeikyuTableBindingSource.DataMember = "SeikyuTable"
			Me.SeikyuTableBindingSource.DataSource = Me.OutputSeikyu
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
			ReportDataSource1.Value = Me.SeikyuTableBindingSource
			ReportDataSource2.Name = "DataSet2"
			ReportDataSource2.Value = Me.M_JOSUBindingSource
			Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
			Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
			Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IbUkeharai.OutputSeikyuReportS.rdlc"
			Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
			Me.ReportViewer1.Name = "ReportViewer1"
			Me.ReportViewer1.ServerReport.BearerToken = Nothing
			Me.ReportViewer1.ShowExportButton = False
			Me.ReportViewer1.Size = New System.Drawing.Size(984, 477)
			Me.ReportViewer1.TabIndex = 0
			'
			'OutPutSeikyuFormReportViewSeikyu
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(984, 477)
			Me.Controls.Add(Me.ReportViewer1)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "OutPutSeikyuFormReportViewSeikyu"
			Me.Text = "請求書"
			CType(Me.SeikyuTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.OutputSeikyu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.M_JOSUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
#End Region
		Private Sub updateDataBase()
			If Me._arry_newSeqnum.Count = 0 Or Me._seq_plus = True Then
				Me._seq_plus = True
				Return
			End If
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Try
					sqlDataBase.BeginTransaction()

					'複数人が処理した時に請求書ナンバー重複しないように処理。
					'プレビュー作成時に請求書ナンバーを_seq_chkに入れておき、印刷ボタンを押したときにseq_chk_printでもう一度取得して同じなら処理続行
					Using sqlDataBase_chk As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
						Dim text_chk As String = "SELECT SEQNUM FROM Ukeharai.M_JOSU ORDER BY JOSU_CD DESC"
						Dim sqldata_chk As String = sqlDataBase_chk.getSQLData(text_chk, True)
						If Not String.IsNullOrEmpty(sqldata_chk) Then
							DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me._seq_plus = False
							Return
						Else
							Me._table_chk = sqlDataBase_chk.DbDataTable
							Dim seq_chk_print As Integer
							seq_chk_print = Conversions.ToInteger(Me._table_chk.Rows(0)("SEQNUM")) + 1
							If seq_chk_print <> Me._seq_chk Then
								DlgMessageBox.Show("印刷に競合が発生しました。請求書ナンバーが重複する恐れがあります。もう一度プレビューし直してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me._seq_plus = False
								Return
							Else
								Me._seq_plus = True
							End If
						End If
					End Using

					Dim text As String = String.Empty
					Try
						For Each array As String() In Me._arry_newSeqnum
							text = "UPDATE Ukeharai.T_SEIKYU SET SEIKYU_NO = '" + String.Format("{0:D5}", Integer.Parse(array(1))) + "', "
							text = text + "UPDATE_USER = '" + Me._conf.xmlConfData.xDataBase.UserId + "', "
							text = text + "UPDATE_DTM = '" + Conversions.ToString(DateAndTime.Now) + "', "
							text = text + "UPDATE_FUNCTION = '" + Me.Name + "' "
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
					text = text + "UPDATE_FUNCTION = '" + Me.Name + "' "
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmReportView_Load
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_seikyu = Nothing
			Me._arry_tori = New List(Of String)()
			Me._seqnum = 0
			Me._arry_newSeqnum = New List(Of String())()
			Me.InitializeComponent()
			Me._conf = TopForm.ConfigData
			Me._sConnectDB = Common.makeConnectionString(Me._conf)
		End Sub

		Public Sub New(a_date As DateTime, a_kind As Integer, a_toricd As List(Of String))
			AddHandler MyBase.Load, AddressOf Me.frmReportView_Load
			Me._conf = Nothing
			Me._dt_m_josu = Nothing
			Me._dt_seikyu = Nothing
			Me._arry_tori = New List(Of String)()
			Me._seqnum = 0
			Me._arry_newSeqnum = New List(Of String())()
			Me.InitializeComponent()
			Me._conf = TopForm.ConfigData
			Me._sConnectDB = Common.makeConnectionString(Me._conf)
			Me._date = a_date
			Me._kind = a_kind
			Me._toricd = a_toricd
			Me.getDataBase()
		End Sub

		Private Sub frmReportView_Load(sender As Object, e As EventArgs)
			If Me._dt_seikyu Is Nothing OrElse Me._dt_seikyu.Rows.Count = 0 Then
				DlgMessageBox.Show("該当する請求書データが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.Close()
				Return
			End If
			Me.ReportViewer1.LocalReport.DataSources.Clear()
			Dim reportDataSource As New ReportDataSource()
			reportDataSource.Name = "DataSet1"
			reportDataSource.Value = Me._dt_seikyu
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

		Private Sub ReportViewer1_PrintingBegin(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print
			Cursor.Current = Cursors.WaitCursor
			Me.updateDataBase()
			If Me._seq_plus = False Then
				e.Cancel = True
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("ReportViewer1")>
		Private WithEvents ReportViewer1 As ReportViewer

		<AccessedThroughProperty("SeikyuTableBindingSource")>
		Private WithEvents SeikyuTableBindingSource As BindingSource

		<AccessedThroughProperty("OutputSeikyu")>
		Private WithEvents OutputSeikyu As OutputSeikyu

		<AccessedThroughProperty("M_JOSUBindingSource")>
		Private WithEvents M_JOSUBindingSource As BindingSource

		Private _sConnectDB As String

		Private _conf As XmlConfigControl

		Private _date As DateTime

		Private _kind As Integer

		Private _toricd As List(Of String)

		Private Const PRINT_MAXRECORD As Integer = 30

		Private Const REGEX_STR As String = "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．"

		Private _dt_m_josu As DataTable

		Private _dt_seikyu As DataTable

		Private _arry_tori As List(Of String)

		Private _seqnum As Integer

		Private _arry_newSeqnum As List(Of String())

		Private _seq_chk As Integer

		Private _table_chk As DataTable

		Private _seq_plus As Boolean
	End Class
End Namespace
