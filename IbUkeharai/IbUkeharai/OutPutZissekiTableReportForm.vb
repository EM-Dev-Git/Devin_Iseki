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
	Public Class OutPutZissekiTableReportForm
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
			Me.components = New Container()
			Dim reportDataSource As New ReportDataSource()
			Dim reportDataSource2 As New ReportDataSource()
			Me.HEADERBindingSource = New BindingSource(Me.components)
			Me.OutPutZissekiTableFormDataSet = New OutPutZissekiTableFormDataSet()
			Me.BODYBindingSource = New BindingSource(Me.components)
			Me.ReportViewer1 = New ReportViewer()
			CType(Me.HEADERBindingSource, ISupportInitialize).BeginInit()
			CType(Me.OutPutZissekiTableFormDataSet, ISupportInitialize).BeginInit()
			CType(Me.BODYBindingSource, ISupportInitialize).BeginInit()
			Me.SuspendLayout()


			Me.HEADERBindingSource.DataMember = "HEADER"
			Me.HEADERBindingSource.DataSource = Me.OutPutZissekiTableFormDataSet


			Me.OutPutZissekiTableFormDataSet.DataSetName = "OutPutZissekiTableFormDataSet"
			Me.OutPutZissekiTableFormDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema


			Me.BODYBindingSource.DataMember = "BODY"
			Me.BODYBindingSource.DataSource = Me.OutPutZissekiTableFormDataSet
			Me.ReportViewer1.Dock = DockStyle.Fill

			reportDataSource.Name = "HEADER"
			reportDataSource.Value = Me.HEADERBindingSource
			reportDataSource2.Name = "BODY"
			reportDataSource2.Value = Me.BODYBindingSource


			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2)
			Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IbUkeharai.OutPutZissekiTableFormReport.rdlc"
			Me.ReportViewer1.Location = New Point(0, 0)
			Me.ReportViewer1.Name = "ReportViewer1"
			Me.ReportViewer1.ShowExportButton = False
			Me.ReportViewer1.Size = New Size(784, 562)
			Me.ReportViewer1.TabIndex = 0


			Me.AutoScaleDimensions = New SizeF(6.0F, 12.0F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.ReportViewer1)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "OutPutZissekiTableReportForm"
			Me.Text = "生産事業部　実績内訳表"
			CType(Me.HEADERBindingSource, ISupportInitialize).EndInit()
			CType(Me.OutPutZissekiTableFormDataSet, ISupportInitialize).EndInit()
			CType(Me.BODYBindingSource, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
#End Region
		Public Sub New(header As DataTable, body As DataTable)
			AddHandler MyBase.Load, AddressOf Me.OutPutZissekiTableReportForm_Load
			Me.header = Nothing
			Me.body = Nothing
			Me.InitializeComponent()
			Me.header = header
			Me.body = body
		End Sub

		Private Sub OutPutZissekiTableReportForm_Load(sender As Object, e As EventArgs)
			Me.ReportViewer1.LocalReport.DataSources.Clear()
			Dim reportDataSource As New ReportDataSource()
			reportDataSource.Name = "HEADER"
			reportDataSource.Value = Me.header
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			reportDataSource = New ReportDataSource()
			reportDataSource.Name = "BODY"
			reportDataSource.Value = Me.body
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			Me.ReportViewer1.SetDisplayMode(CType(1, DisplayMode))
			Me.ReportViewer1.ZoomMode = CType(1, ZoomMode)
			Me.ReportViewer1.RefreshReport()
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("ReportViewer1")>
		Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

		<AccessedThroughProperty("HEADERBindingSource")>
		Private WithEvents HEADERBindingSource As BindingSource

		<AccessedThroughProperty("OutPutZissekiTableFormDataSet")>
		Private WithEvents OutPutZissekiTableFormDataSet As OutPutZissekiTableFormDataSet

		<AccessedThroughProperty("BODYBindingSource")>
		Private WithEvents BODYBindingSource As BindingSource

		Private header As DataTable

		Private body As DataTable
	End Class
End Namespace
