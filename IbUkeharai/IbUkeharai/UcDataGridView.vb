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
	Public Class UcDataGridView
		Inherits UserControl

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.UcDataGridView_Load
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
			Me.StatusStrip1 = New StatusStrip()
			Me.ToolStripStatusLabel1 = New ToolStripStatusLabel()
			Me.CustDgv = New IbUkeharai.Util.CustomDataGridView(Me.components)
			Me.StatusStrip1.SuspendLayout()
			CType(Me.CustDgv, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'StatusStrip1
			'
			Me.StatusStrip1.BackColor = SystemColors.ControlLight
			Me.StatusStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripStatusLabel1})
			Me.StatusStrip1.Location = New Point(0, 169)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode
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
			Me.ToolStripStatusLabel1.Text = "ここにメッセージを出力します。"
			Me.ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
			'
			'CustDgv
			'
			Me.CustDgv.AllowUserToDeleteRows = False
			Me.CustDgv.AllowUserToResizeRows = False
			Me.CustDgv.BorderStyle = BorderStyle.None
			Me.CustDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.CustDgv.Dock = DockStyle.Fill
			Me.CustDgv.EnableHeadersVisualStyles = False
			Me.CustDgv.gridInfo = Nothing
			Me.CustDgv.IsRowNoView = False
			Me.CustDgv.Location = New Point(0, 0)
			Me.CustDgv.MultiSelect = False
			Me.CustDgv.Name = "CustDgv"
			Me.CustDgv.RowHeadersWidth = 55
			Me.CustDgv.RowTemplate.Height = 21
			Me.CustDgv.ShowCellToolTips = False
			Me.CustDgv.Size = New Size(498, 169)
			Me.CustDgv.TabIndex = 0
			Me.CustDgv.TableName = ""
			'
			'UcDataGridView
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.CustDgv)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Name = "UcDataGridView"
			Me.Size = New Size(498, 191)
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			CType(Me.CustDgv, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Public Event DgvCellEndEdit As UcDataGridView.DgvCellEndEditEventHandler


		Public Sub CustDgv_SendMessage(msg As String)
			Me.ToolStripStatusLabel1.Text = msg
		End Sub

		Private Sub CustDgv_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles CustDgv.UserDeletingRow
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If dataGridView.Columns("KUBUN") IsNot Nothing Then
				If "追加".Equals(RuntimeHelpers.GetObjectValue(dataGridView.Rows(e.Row.Index).Cells("KUBUN").Value)) Then
					Return
				End If
				dataGridView.Rows(e.Row.Index).Cells("KUBUN").Value = "削除"
				CType(dataGridView, CustomDataGridView).IsChanged = True
			End If
			e.Cancel = True
		End Sub

		Private Sub UcDataGridView_Load(sender As Object, e As EventArgs)
			Me.CustDgv.AllowUserToDeleteRows = True
		End Sub

		Private Sub CustDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustDgv.CellClick
			If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
				Return
			End If
			If TypeOf Me.CustDgv.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
				Dim dataGridViewCheckBoxCell As DataGridViewCheckBoxCell = CType(Me.CustDgv(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
				dataGridViewCheckBoxCell.Value = Operators.NotObject(dataGridViewCheckBoxCell.Value)
				Me.CustDgv.Refresh()
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("CustDgv")>
		Public WithEvents CustDgv As CustomDataGridView

		<AccessedThroughProperty("StatusStrip1")>
		Private WithEvents StatusStrip1 As StatusStrip

		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

		Public Delegate Sub DgvCellEndEditEventHandler(sender As Object, e As DataGridViewCellEventArgs)

		Private Sub CustDgv_RowsAdded_1(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles CustDgv.RowsAdded
			Me.ToolStripStatusLabel1.Text = Conversions.ToString(Me.CustDgv.RowCount) + "行"
		End Sub

		Private Sub CustDgv_RowsRemoved_1(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles CustDgv.RowsRemoved
			Me.ToolStripStatusLabel1.Text = Conversions.ToString(Me.CustDgv.RowCount) + "行"
		End Sub

		Private Sub CustDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CustDgv.CellEndEdit
			Dim dgvCellEndEditEvent As UcDataGridView.DgvCellEndEditEventHandler = Me.DgvCellEndEditEvent
			If dgvCellEndEditEvent IsNot Nothing Then
				dgvCellEndEditEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub
	End Class
End Namespace
