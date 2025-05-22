Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class FtpCommon

		Public Sub New(user As String, pass As String)
			Me._FTPUser = Nothing
			Me._FTPPass = Nothing
			Me._FTPReq = Nothing
			Me._FTPUser = user
			Me._FTPPass = pass
		End Sub

		Private Function CreateRequestFTP(url As String, reqmod As FtpCommon.FtpRequest) As Boolean
			If IsNothing(Me._FTPUser) Or IsNothing(Me._FTPPass) Then
				OutputLog.WriteLine(String.Format("FTP User,Password Error : User[{0}] Password[{1}]", Me._FTPUser, Me._FTPPass))
				Return False
			End If
			Dim requestUri As New Uri(url)
			Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(requestUri), FtpWebRequest)
			ftpWebRequest.Credentials = New NetworkCredential(Me._FTPUser, Me._FTPPass)
			If reqmod = FtpCommon.FtpRequest.DownLoad Then
				ftpWebRequest.Method = "RETR"
			ElseIf reqmod = FtpCommon.FtpRequest.UpLoad Then
				ftpWebRequest.Method = "STOR"
			ElseIf reqmod = FtpCommon.FtpRequest.Directory Then
				ftpWebRequest.Method = "NLST"
			Else
				If reqmod <> FtpCommon.FtpRequest.MakeDirectory Then
					Return False
				End If
				ftpWebRequest.Method = "MKD"
			End If
			ftpWebRequest.KeepAlive = False
			ftpWebRequest.UseBinary = False
			ftpWebRequest.UsePassive = False
			Me._FTPReq = ftpWebRequest
			Return True
		End Function

		Public Function DownLoadFile(url As String, path As String) As Boolean
			If Operators.CompareString(url, String.Empty, False) = 0 Or Operators.CompareString(path, String.Empty, False) = 0 Then
				Return False
			End If
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.DownLoad) Then
					Return False
				End If
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				Try
					Dim responseStream As Stream = ftpWebResponse.GetResponseStream()
					Dim fileStream As New FileStream(path, FileMode.Create, FileAccess.Write)
					Dim array As Byte() = New Byte(1023) {}
					While True
						Dim num As Integer = responseStream.Read(array, 0, array.Length)
						If num = 0 Then
							Exit While
						End If
						fileStream.Write(array, 0, num)
					End While
					fileStream.Close()
					responseStream.Close()
					Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
					ftpWebResponse.Close()
				Catch ex As Exception
					OutputLog.WriteLine(String.Format("FTP DownLoad Error : {0}" & vbCrLf & "url[{1}] path[{2}]", ex.Message, url, path))
					ftpWebResponse.Close()
					Return False
				End Try
			Catch ex2 As Exception
				OutputLog.WriteLine(String.Format("FTP DownLoad Error : {0}" & vbCrLf & "url[{1}] path[{2}]", ex2.Message, url, path))
				Return False
			End Try
			Return True
		End Function

		Public Function UpLoadFile(url As String, path As String) As Boolean
			If Operators.CompareString(url, String.Empty, False) = 0 Or Operators.CompareString(path, String.Empty, False) = 0 Then
				url = "ftp://172.23.1.59/FTPROOT/TestUpFile.csv"
				path = "C:\FTP\UpFILE\空ファイル.txt"
			End If
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.UpLoad) Then
					Return False
				End If
				Dim requestStream As Stream = Me._FTPReq.GetRequestStream()
				Dim fileStream As New FileStream(path, FileMode.Open, FileAccess.Read)
				Dim array As Byte() = New Byte(1023) {}
				While True
					Dim num As Integer = fileStream.Read(array, 0, array.Length)
					If num = 0 Then
						Exit While
					End If
					requestStream.Write(array, 0, num)
				End While
				fileStream.Close()
				requestStream.Close()
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
				ftpWebResponse.Close()
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP UpLoad Error : {0}" & vbCrLf & "url[{1}] path[{2}]", ex.Message, url, path))
				Return False
			End Try
			Return True
		End Function

		Public Function IsDirectory(url As String) As Boolean
			If Operators.CompareString(url, String.Empty, False) = 0 Then
				Return False
			End If
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.Directory) Then
					Return False
				End If
				Dim value As String = ""
				Using ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
					Using streamReader As New StreamReader(ftpWebResponse.GetResponseStream())
						value = streamReader.ReadToEnd()
					End Using
				End Using
				Console.WriteLine(value)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP Directory Error : {0}" & vbCrLf & "url[{1}]", ex.Message, url))
				DlgMessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Public Function CreateDirectory(url As String) As Boolean
			If Operators.CompareString(url, String.Empty, False) = 0 Then
				Return False
			End If
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.MakeDirectory) Then
					Return False
				End If
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP CreateDirectory Error : {0}" & vbCrLf & "url[{1}]", ex.Message, url))
				Return False
			End Try
			Return True
		End Function

		Public Function GetTimeStamp(url As String) As DateTime
			If Operators.CompareString(url, String.Empty, False) = 0 Then
				Return DateTime.MinValue
			End If
			Dim result As DateTime = Nothing
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.DownLoad) Then
					Return DateTime.MinValue
				End If
				Me._FTPReq.Method = "MDTM"
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				result = ftpWebResponse.LastModified
				Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
				ftpWebResponse.Close()
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP GetTimeStamp Error : {0}" & vbCrLf & "url[{1}]", ex.Message, url))
				Return DateTime.MinValue
			End Try
			Return result
		End Function

		Public Function CheakTimeStamp(url As String, localTimeStamp As DateTime) As Boolean
			If Operators.CompareString(url, String.Empty, False) = 0 Then
				Return False
			End If
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.DownLoad) Then
					Return False
				End If
				Me._FTPReq.Method = "MDTM"
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				Dim lastModified As DateTime = ftpWebResponse.LastModified
				Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
				ftpWebResponse.Close()
				If DateTime.Compare(localTimeStamp, lastModified) = 0 Then
					Return False
				End If
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP GetTimeStamp Error : {0}" & vbCrLf & "url[{1}]", ex.Message, url))
				Return False
			End Try
			Return True
		End Function

		Public Function GetDirectoryList(url As String) As String
			If Operators.CompareString(url, String.Empty, False) = 0 Then
				Return Nothing
			End If
			Dim result As String = Nothing
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_JIS")
			Try
				If Not Me.CreateRequestFTP(url, FtpCommon.FtpRequest.DownLoad) Then
					Return Nothing
				End If
				Me._FTPReq.Method = "LIST"
				Dim ftpWebResponse As FtpWebResponse = CType(Me._FTPReq.GetResponse(), FtpWebResponse)
				Dim streamReader As New StreamReader(ftpWebResponse.GetResponseStream(), encoding)
				result = streamReader.ReadToEnd()
				Console.WriteLine("{0}: {1}", ftpWebResponse.StatusCode, ftpWebResponse.StatusDescription)
				ftpWebResponse.Close()
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FTP GetDirectoryList Error : {0}" & vbCrLf & "url[{1}]", ex.Message, url))
				Return Nothing
			End Try
			Return result
		End Function

		Private _FTPUser As String

		Private _FTPPass As String

		Private _FTPReq As FtpWebRequest

		Private Enum FtpRequest
			DownLoad = 1

			UpLoad

			Directory

			MakeDirectory
		End Enum
	End Class
End Namespace
