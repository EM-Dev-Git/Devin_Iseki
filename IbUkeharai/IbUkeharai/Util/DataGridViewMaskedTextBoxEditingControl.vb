Imports System
Imports System.Windows.Forms

Namespace IbUkeharai.Util

	Public Class DataGridViewMaskedTextBoxEditingControl
		Inherits MaskedTextBox
		Implements IDataGridViewEditingControl

		Public Sub New()
			Me.TabStop = False
		End Sub

		Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements System.Windows.Forms.IDataGridViewEditingControl.GetEditingControlFormattedValue
			Return Me.Text
		End Function

		Public Property EditingControlFormattedValue As Object Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlFormattedValue
			Get
				Return Me.GetEditingControlFormattedValue(DataGridViewDataErrorContexts.Formatting)
			End Get
			Set(value As Object)
				Me.Text = CStr(value)
			End Set
		End Property

		Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements System.Windows.Forms.IDataGridViewEditingControl.ApplyCellStyleToEditingControl
			Me.Font = dataGridViewCellStyle.Font
			Me.ForeColor = dataGridViewCellStyle.ForeColor
			Me.BackColor = dataGridViewCellStyle.BackColor
			Dim alignment As DataGridViewContentAlignment = dataGridViewCellStyle.Alignment
			If alignment = DataGridViewContentAlignment.BottomCenter OrElse alignment = DataGridViewContentAlignment.MiddleCenter OrElse alignment = DataGridViewContentAlignment.TopCenter Then
				Me.TextAlign = HorizontalAlignment.Center
			ElseIf alignment = DataGridViewContentAlignment.BottomRight OrElse alignment = DataGridViewContentAlignment.MiddleRight OrElse alignment = DataGridViewContentAlignment.TopRight Then
				Me.TextAlign = HorizontalAlignment.Right
			Else
				Me.TextAlign = HorizontalAlignment.Left
			End If
		End Sub

		Public Property EditingControlDataGridView As DataGridView Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlDataGridView
			Get
				Return Me.dataGridView
			End Get
			Set(value As DataGridView)
				Me.dataGridView = value
			End Set
		End Property

		Public Property EditingControlRowIndex As Integer Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlRowIndex
			Get
				Return Me.rowIndex
			End Get
			Set(value As Integer)
				Me.rowIndex = value
			End Set
		End Property

		Public Property EditingControlValueChanged As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlValueChanged
			Get
				Return Me.valueChanged
			End Get
			Set(value As Boolean)
				Me.valueChanged = value
			End Set
		End Property

		Public Function EditingControlWantsInputKey(keyData As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlWantsInputKey
			Select Case keyData And Keys.KeyCode
				Case Keys.[End], Keys.Home, Keys.Left, Keys.Right
					Return True
			End Select
			Return Not dataGridViewWantsInputKey
		End Function

		Public ReadOnly Property EditingPanelCursor As Cursor Implements System.Windows.Forms.IDataGridViewEditingControl.EditingPanelCursor
			Get
				Return MyBase.Cursor
			End Get
		End Property

		Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements System.Windows.Forms.IDataGridViewEditingControl.PrepareEditingControlForEdit
			If selectAll Then
				Me.SelectAll()
			Else
				Me.SelectionStart = Me.TextLength
			End If
		End Sub

		Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.RepositionEditingControlOnValueChange
			Get
				Return False
			End Get
		End Property

		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.valueChanged = True
			Me.dataGridView.NotifyCurrentCellDirty(True)
		End Sub

		Private dataGridView As DataGridView

		Private rowIndex As Integer

		Private valueChanged As Boolean
	End Class
End Namespace
