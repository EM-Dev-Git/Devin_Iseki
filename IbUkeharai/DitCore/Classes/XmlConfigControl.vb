Imports System
Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Namespace DitCore.Classes

	Public Class XmlConfigControl
		Public Property xmlConfData As xRoot
			Get
				Return Me._xmlConfData
			End Get
			Set(value As xRoot)
				Me._xmlConfData = value
			End Set
		End Property

		Public Sub New()
			Me.getConfig()
		End Sub

		Private Sub getConfig()
			Dim path As String = Directory.GetCurrentDirectory() + "\Config.xml"
			If Not File.Exists(path) Then
				Dim xRoot As New xRoot()
				xRoot.xPath.LogFileName = "IbUkeharai.log"
				xRoot.xDataBase.DBName = "UkeharaiDB_DataMigration"
				xRoot.xDataBase.ServerName = "BUGYO-THINK\OBCINSTANCE2X"
				xRoot.xDataBase.UserId = "dit"
				xRoot.xDataBase.PassWord = "dit"
				xRoot.xFtpServer.FtpUrl = "ftp://172.23.1.31/ROOT/"
				xRoot.xFtpServer.FtpBackUpUrl = "ftp://172.23.1.31/ROOT/BackUp/"
				xRoot.xFtpServer.UserId = "FTPUSER"
				xRoot.xFtpServer.Password = "FTP-USER"
				xRoot.xFtpServer.TestMode = "FALSE"
				xRoot.Message = "変更する際は文字コード「UTF-8」にご注意を！"
				xRoot.Kyoten = "Matsuyama"
				xRoot.BaseFolder = "\\192.168.241.1\D:\"
				xRoot.Memory = "OFF"
				Dim xmlSerializer As New XmlSerializer(GetType(xRoot))
				Using streamWriter As New StreamWriter(path, False, New UTF8Encoding(False))
					xmlSerializer.Serialize(streamWriter, xRoot)
					streamWriter.Close()
				End Using
			End If
			Dim xmlSerializer2 As New XmlSerializer(GetType(xRoot))
			Using streamReader As New StreamReader(path, New UTF8Encoding(False))
				Me.xmlConfData = CType(xmlSerializer2.Deserialize(streamReader), xRoot)
				streamReader.Close()
			End Using

		End Sub

		Public Sub writeConfig()
			Dim path As String = Directory.GetCurrentDirectory() + "\Config.xml"
			Dim xmlSerializer As New XmlSerializer(GetType(xRoot))
			Using streamWriter As New StreamWriter(path, False, New UTF8Encoding(False))
				xmlSerializer.Serialize(streamWriter, Me._xmlConfData)
				streamWriter.Close()
			End Using
			Dim xmlSerializer2 As New XmlSerializer(GetType(xRoot))
			Using streamReader As New StreamReader(path, New UTF8Encoding(False))
				Me.xmlConfData = CType(xmlSerializer2.Deserialize(streamReader), xRoot)
				streamReader.Close()
			End Using
		End Sub

		Private Const LOGFILENAME As String = "IbUkeharai.log"

		Private Const SERVERNAME As String = "BUGYO-THINK\OBCINSTANCE2X"

		Private Const DATABASENAME As String = "UkeharaiDB_DataMigration"

		Private Const USER As String = "dit"

		Private Const PASSWORD As String = "dit"

		Private Const CONFIDFILENAME As String = "\Config.xml"

		Private _xmlConfData As xRoot
	End Class
End Namespace
