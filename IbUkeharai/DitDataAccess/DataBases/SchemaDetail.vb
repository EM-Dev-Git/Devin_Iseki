Imports System

Namespace DitDataAccess.DataBases

	Public Class SchemaDetail

		Public Sub New()
			Me.name = String.Empty
			Me.type = Nothing
			Me.charlength = 0
			Me.numericprecision = 0
			Me.numericscale = 0
		End Sub

		Public tblschema As String

		Public name As String

		Public type As Type

		Public charlength As Integer

		Public numericprecision As Integer

		Public numericscale As Integer
	End Class
End Namespace
