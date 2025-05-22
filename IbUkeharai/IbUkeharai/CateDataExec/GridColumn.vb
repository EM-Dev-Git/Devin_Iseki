Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace IbUkeharai.CateDataExec

	Public Class GridColumn

		Public Sub New()
			Me._fontHeader = Nothing
			Me._fontCell = Nothing
			Me._readColor = SystemColors.GradientInactiveCaption
			Me.ReadOnlyFlag = False
			Me._fontHeader = New Font("ＭＳ Ｐゴシック", 9.5F)
			Me._fontCell = New Font("ＭＳ Ｐゴシック", 9.5F)
		End Sub

		Public Function CreateTextColumn(name As String, header As String, width As Integer, Optional isread As Boolean = False, Optional proname As String = "") As DataGridViewTextBoxColumn
			Dim dataGridViewTextBoxColumn As New DataGridViewTextBoxColumn()
			dataGridViewTextBoxColumn.Name = name
			dataGridViewTextBoxColumn.HeaderText = header
			dataGridViewTextBoxColumn.DataPropertyName = proname
			dataGridViewTextBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			dataGridViewTextBoxColumn.HeaderCell.Style.Font = Me._fontHeader
			dataGridViewTextBoxColumn.Width = width
			dataGridViewTextBoxColumn.[ReadOnly] = isread
			If Not Me.ReadOnlyFlag AndAlso isread Then
				dataGridViewTextBoxColumn.DefaultCellStyle.BackColor = Me._readColor
			End If
			dataGridViewTextBoxColumn.DefaultCellStyle.Format = ""
			Return dataGridViewTextBoxColumn
		End Function

		Public Function CreateCheckColumn(name As String, header As String, width As Integer, Optional isread As Boolean = False, Optional proname As String = "") As DataGridViewCheckBoxColumn
			Dim font As New Font("ＭＳ Ｐゴシック", 9.5F)
			Dim font2 As New Font("ＭＳ Ｐゴシック", 9.5F)
			Dim gradientInactiveCaption As Color = SystemColors.GradientInactiveCaption
			Dim dataGridViewCheckBoxColumn As New DataGridViewCheckBoxColumn()
			dataGridViewCheckBoxColumn.CellTemplate = New DataGridViewCheckBoxCellEx()
			dataGridViewCheckBoxColumn.Name = name
			dataGridViewCheckBoxColumn.HeaderText = header
			dataGridViewCheckBoxColumn.DataPropertyName = proname
			dataGridViewCheckBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			dataGridViewCheckBoxColumn.HeaderCell.Style.Font = font
			dataGridViewCheckBoxColumn.Width = width
			dataGridViewCheckBoxColumn.DefaultCellStyle.Format = "Boolean"
			dataGridViewCheckBoxColumn.[ReadOnly] = isread
			If Not Me.ReadOnlyFlag AndAlso isread Then
				dataGridViewCheckBoxColumn.DefaultCellStyle.BackColor = gradientInactiveCaption
			End If
			Return dataGridViewCheckBoxColumn
		End Function

		Private _fontHeader As Font

		Private _fontCell As Font

		Private _readColor As Color

		Public ReadOnlyFlag As Boolean
	End Class
End Namespace
