Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class CalendarCell
		Inherits DataGridViewTextBoxCell


		Public Sub New()
			Me.Style.Format = "d"
		End Sub


		Public Sub New(frm As String)
			Me.Style.Format = frm
		End Sub

		Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
			MyBase.InitializeEditingControl(rowIndex, RuntimeHelpers.GetObjectValue(initialFormattedValue), dataGridViewCellStyle)
			Dim calendarEditingControl As CalendarEditingControl = CType(Me.DataGridView.EditingControl, CalendarEditingControl)
			calendarEditingControl.Format = DateTimePickerFormat.Custom
			calendarEditingControl.CustomFormat = Me.Style.Format
			If Me.Value Is Nothing Then
				calendarEditingControl.Value = DateAndTime.Now.[Date]
			Else
				calendarEditingControl.Value = Conversions.ToDate(Me.Value)
			End If
		End Sub

		Public Overrides ReadOnly Property EditType As Type
			Get
				Return GetType(CalendarEditingControl)
			End Get
		End Property

		Public Overrides ReadOnly Property ValueType As Type
			Get
				Return GetType(DateTime)
			End Get
		End Property

		Public Overrides ReadOnly Property DefaultNewRowValue As Object
			Get
				Return DateTime.Now
			End Get
		End Property
	End Class
End Namespace
