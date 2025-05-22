Imports System

Namespace IbUkeharai.Util

	Public Class ItemInfomation

		Public Sub New(code As String, name As String)
			Me.m_code = String.Empty
			Me.m_name = String.Empty
			If String.IsNullOrEmpty(code) Then
				Me.m_code = String.Empty
			Else
				Me.m_code = code
			End If
			Me.m_name = name
		End Sub

		Public ReadOnly Property Code As String
			Get
				Return Me.m_code
			End Get
		End Property

		Public ReadOnly Property Name As String
			Get
				Return Me.m_name
			End Get
		End Property

		Public Overrides Function ToString() As String
			Return Me.m_code
		End Function

		Private m_code As String

		Private m_name As String
	End Class
End Namespace
