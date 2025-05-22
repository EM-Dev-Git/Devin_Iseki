Imports System
Imports System.Windows.Forms

Namespace IbUkeharai.Util

	Public Class CalendarColumn
		Inherits DataGridViewColumn

		Public Sub New()
			MyBase.New(New CalendarCell("d"))
		End Sub

		Public Sub New(frm As String)
			MyBase.New(New CalendarCell(frm))
		End Sub

		Public Property StyleFormat As String
			Get
				Return Me._format
			End Get
			Set(value As String)
				Me._format = value
			End Set
		End Property

		Public Overrides Property CellTemplate As DataGridViewCell
			Get
				Return MyBase.CellTemplate
			End Get
			Set(value As DataGridViewCell)
				If value IsNot Nothing AndAlso Not value.[GetType]().IsAssignableFrom(GetType(CalendarCell)) Then
					Throw New InvalidCastException("Must be a CalendarCell")
				End If
				MyBase.CellTemplate = value
			End Set
		End Property

		Private _format As String
	End Class
End Namespace
