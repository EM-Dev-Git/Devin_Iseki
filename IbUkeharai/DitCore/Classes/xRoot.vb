Imports System

Namespace DitCore.Classes

	Public Class xRoot
		Public Sub New()
			Me.xPath = New PathInfo()
			Me.xDataBase = New DataBaseInfo()
			Me.xFtpServer = New FtpServerInfo()
			Me.xFtpServer_Keppin = New FtpServer_KeppinInfo()
		End Sub

		Public xPath As PathInfo

		Public xDataBase As DataBaseInfo

		Public xFtpServer As FtpServerInfo

		Public xFtpServer_Keppin As FtpServer_KeppinInfo

		Public Message As String

		Public Kyoten As String

		Public BaseFolder As String

		Public Memory As String
	End Class
End Namespace