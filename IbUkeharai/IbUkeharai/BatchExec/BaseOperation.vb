Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports DitCore.Classes

Namespace IbUkeharai.BatchExec

	Public Class BaseOperation

		Public Shared Function IsFile(path As String) As Boolean
			Dim result As Boolean = False
			If File.Exists(path) Then
				result = True
			End If
			Return result
		End Function

		Public Shared Function CreateNullFile(path As String) As Boolean
			Dim result As Boolean = False
			Dim fileStream As FileStream = Nothing
			Try
				Try
					fileStream = File.Create(path)
					result = True
				Finally
					If fileStream IsNot Nothing Then
						fileStream.Close()
					End If
				End Try
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateNullFile Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			Finally
				If fileStream IsNot Nothing Then
					Dim disposable As IDisposable = fileStream
					disposable.Dispose()
				End If
			End Try
			Return result
		End Function

		Public Shared Function CopyToFile(src As String, dst As String) As Boolean
			If Not BaseOperation.IsFile(src) Then
				Return False
			End If
			Try
				If BaseOperation.IsFile(dst) Then
					File.Delete(dst)
				End If
				File.Copy(src, dst)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FileCopy Errer : {0}" & vbCrLf & "src[{1}] dst[{2}]", ex.Message, src, dst))
				Return False
			End Try
			Return True
		End Function

		Public Shared Function DeleteFile(path As String) As Object
			If Not BaseOperation.IsFile(path) Then
				Return False
			End If
			Try
				File.Delete(path)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("FileDelete Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
				Return False
			End Try
			Return True
		End Function

		Public Shared Sub DeleteFileList(files As List(Of String), Optional num As Integer = 0)
			Dim num2 As Integer = 0
			Dim num3 As Integer = files.Count - (1 + num)
			For i As Integer = num2 To num3
				BaseOperation.DeleteFile(files(i))
			Next
		End Sub

		Public Shared Function IsDirectory(path As String) As Boolean
			Dim result As Boolean = False
			If Directory.Exists(path) Then
				result = True
			End If
			Return result
		End Function

		Public Shared Function CreateDirectory(path As String) As Boolean
			Dim result As Boolean = False
			Try
				Directory.CreateDirectory(path)
				result = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateDirectory Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			End Try
			Return result
		End Function

		Public Shared Function GetFileList(path As String) As String()
			Dim result As String() = Nothing
			If Not BaseOperation.IsDirectory(path) Then
				Return result
			End If
			Try
				Dim filesOrderByDate As String() = BaseOperation.GetFilesOrderByDate(path)
				result = filesOrderByDate
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("GetFileList Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			End Try
			Return result
		End Function

		Public Shared Function GetFilesOrderByDate(path As String) As String()
			Dim directoryInfo As New DirectoryInfo(path)
			Dim files As FileInfo() = directoryInfo.GetFiles()
			Dim array1 As DateTime() = New DateTime(files.Length - 1 + 1 - 1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = files.Length - 1
			For i As Integer = num To num2
				array1(i) = files(i).LastAccessTime
			Next
			Array.Sort(array1, files)
			Dim list As New List(Of String)()
			For Each fileInfo As FileInfo In files
				list.Add(fileInfo.FullName)
			Next
			Return list.ToArray()
		End Function

		Public Shared Function CreateStreamWriter(path As String, enc As Encoding) As StreamWriter
			Dim result As StreamWriter = Nothing
			Try
				result = New StreamWriter(path, False, enc)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateStreamWriter Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			End Try
			Return result
		End Function

		Public Shared Function CreateStreamReader(path As String) As StreamReader
			Dim result As StreamReader = Nothing
			If Not BaseOperation.IsFile(path) Then
				Return result
			End If
			Try
				result = New StreamReader(path, False)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateStreamReader Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			End Try
			Return result
		End Function
	End Class
End Namespace
