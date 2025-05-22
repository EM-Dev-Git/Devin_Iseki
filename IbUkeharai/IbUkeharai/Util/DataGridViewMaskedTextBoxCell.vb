Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace IbUkeharai.Util

	Public Class DataGridViewMaskedTextBoxCell
		Inherits DataGridViewTextBoxCell

		Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
			MyBase.InitializeEditingControl(rowIndex, RuntimeHelpers.GetObjectValue(initialFormattedValue), dataGridViewCellStyle)
			Dim dataGridViewMaskedTextBoxEditingControl As DataGridViewMaskedTextBoxEditingControl = TryCast(Me.DataGridView.EditingControl, DataGridViewMaskedTextBoxEditingControl)
			If dataGridViewMaskedTextBoxEditingControl IsNot Nothing Then
				Dim text As String = TryCast(initialFormattedValue, String)
				dataGridViewMaskedTextBoxEditingControl.Text = If((text IsNot Nothing), text, "")
				Dim dataGridViewMaskedTextBoxColumn As DataGridViewMaskedTextBoxColumn = TryCast(Me.OwningColumn, DataGridViewMaskedTextBoxColumn)
				If dataGridViewMaskedTextBoxColumn IsNot Nothing Then
					dataGridViewMaskedTextBoxEditingControl.Mask = dataGridViewMaskedTextBoxColumn.Mask
				End If
			End If
		End Sub

		Public Overrides ReadOnly Property EditType As Type
			Get
				Return GetType(DataGridViewMaskedTextBoxEditingControl)
			End Get
		End Property
		Public Overrides ReadOnly Property ValueType As Type
			Get
				Return GetType(Object)
			End Get
		End Property

		Public Overrides ReadOnly Property DefaultNewRowValue As Object
			Get
				Return MyBase.DefaultNewRowValue
			End Get
		End Property
	End Class
End Namespace
