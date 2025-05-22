Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class InquiryUkeharaiZissekiReportForm
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
			Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
			Me.SuspendLayout()
			'
			'ReportViewer1
			'
			Me.ReportViewer1.Dock = DockStyle.Fill
			Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IbUkeharai.InquiryUkeharaiZissekiReport.rdlc"
			Me.ReportViewer1.Location = New Point(0, 0)
			Me.ReportViewer1.Name = "ReportViewer1"
			Me.ReportViewer1.ServerReport.BearerToken = Nothing
			Me.ReportViewer1.ShowExportButton = False
			Me.ReportViewer1.Size = New Size(957, 670)
			Me.ReportViewer1.TabIndex = 0
			'
			'InquiryUkeharaiZissekiReportForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(957, 670)
			Me.Controls.Add(Me.ReportViewer1)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "InquiryUkeharaiZissekiReportForm"
			Me.Text = "受払実績問合せ"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Public Sub New(header As DataTable, body As DataTable)
			AddHandler MyBase.Load, AddressOf Me.InquiryUkeharaiZissekiReportForm_Load
			Me.header = Nothing
			Me.body = Nothing
			Me.InitializeComponent()
			Me.header = header
			Me.body = body
		End Sub

		Private Sub InquiryUkeharaiZissekiReportForm_Load(sender As Object, e As EventArgs)
			Me.ReportViewer1.LocalReport.DataSources.Clear()
			Dim reportDataSource As New ReportDataSource()
			reportDataSource.Name = "HEADER"
			reportDataSource.Value = Me.header
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			reportDataSource = New ReportDataSource()
			reportDataSource.Name = "BODY"
			reportDataSource.Value = Me.body
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
			Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth
			Me.ReportViewer1.RefreshReport()
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("ReportViewer1")>
		Private WithEvents ReportViewer1 As ReportViewer

		Private header As DataTable

		Private body As DataTable
	End Class
End Namespace
