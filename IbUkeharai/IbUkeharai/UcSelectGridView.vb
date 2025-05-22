Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class UcSelectGridView
		Inherits UserControl

        Public Sub New()
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
            Dim DataGridViewCellStyle1 As New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As New DataGridViewCellStyle()
            Me.StatusStrip1 = New StatusStrip()
            Me.ToolStripStatusLabel1 = New ToolStripStatusLabel()
            Me.CmpSgv = New IbUkeharai.Util.CmpSelectGridView(Me.components)
            Me.StatusStrip1.SuspendLayout()
            CType(Me.CmpSgv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripStatusLabel1})
            Me.StatusStrip1.Location = New Point(0, 169)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.RightToLeft = RightToLeft.No
            Me.StatusStrip1.Size = New Size(498, 22)
            Me.StatusStrip1.SizingGrip = False
            Me.StatusStrip1.TabIndex = 1
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'ToolStripStatusLabel1
            '
            Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
            Me.ToolStripStatusLabel1.Size = New Size(144, 17)
            Me.ToolStripStatusLabel1.Text = "0行"
            Me.ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
            '
            'CmpSgv
            '
            Me.CmpSgv.AllowUserToAddRows = False
            Me.CmpSgv.AllowUserToDeleteRows = False
            Me.CmpSgv.AllowUserToResizeRows = False
            Me.CmpSgv.BorderStyle = BorderStyle.None
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = SystemColors.Control
            DataGridViewCellStyle1.Font = New Font("ＭＳ Ｐゴシック", 14.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.[True]
            Me.CmpSgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.CmpSgv.ColumnHeadersHeight = 28
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.Padding = New Padding(2)
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
            Me.CmpSgv.DefaultCellStyle = DataGridViewCellStyle2
            Me.CmpSgv.Dock = DockStyle.Fill
            Me.CmpSgv.EnableHeadersVisualStyles = False
            Me.CmpSgv.ImeMode = ImeMode.Disable
            Me.CmpSgv.Location = New Point(0, 0)
            Me.CmpSgv.Name = "CmpSgv"
            Me.CmpSgv.ReadOnly = True
            Me.CmpSgv.RowHeadersVisible = False
            Me.CmpSgv.RowHeadersWidth = 60
            Me.CmpSgv.RowTemplate.Height = 25
            Me.CmpSgv.RowTemplate.ReadOnly = True
            Me.CmpSgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.CmpSgv.ShowCellToolTips = False
            Me.CmpSgv.Size = New Size(498, 169)
            Me.CmpSgv.TabIndex = 2
            '
            'UcSelectGridView
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.CmpSgv)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Name = "UcSelectGridView"
            Me.Size = New Size(498, 191)
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            CType(Me.CmpSgv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private Sub CmpSgv_SendMessage(msg As String)
            Me.ToolStripStatusLabel1.Text = msg
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("StatusStrip1")>
        Private WithEvents StatusStrip1 As StatusStrip

        <AccessedThroughProperty("ToolStripStatusLabel1")>
        Public WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

        <AccessedThroughProperty("CmpSgv")>
        Public WithEvents CmpSgv As CmpSelectGridView

        Private Sub CmpSgv_RowsAdded_1(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles CmpSgv.RowsAdded
            Me.ToolStripStatusLabel1.Text = Conversions.ToString(Me.CmpSgv.RowCount) + "行"
        End Sub
        Private Sub CmpSgv_RowsRemoved_1(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles CmpSgv.RowsRemoved
            Me.ToolStripStatusLabel1.Text = Conversions.ToString(Me.CmpSgv.RowCount) + "行"
        End Sub

    End Class
End Namespace
