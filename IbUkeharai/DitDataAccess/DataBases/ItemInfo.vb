Imports System

Namespace DitDataAccess.DataBases

	Public Class ItemInfo

		Public Sub New()
			Me.name = String.Empty
			Me.type = Nothing
			Me.length = 0
			Me.iskey = False
		End Sub

		Public Sub New(n As String, t As Type, l As Integer, k As Boolean, tbl As String, hide As Boolean)
			Me.name = n
			Me.type = t
			Me.length = l
			Me.iskey = k
			Me.tablename = tbl
			Me.ishidden = hide
		End Sub

		Public name As String

		Public type As Type

		Public length As Integer

		Public iskey As Boolean

		Public tablename As String

		Public ishidden As Boolean
	End Class
End Namespace
