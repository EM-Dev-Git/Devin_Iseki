Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Text

Namespace DitDataAccess.Files

	Public Class OutputLine

		Public Function Initialize(sOutputFileName As String) As Boolean
			Dim entryAssembly As Assembly = Assembly.GetEntryAssembly()
			Me._sOutputFolder = Path.Combine(Path.GetDirectoryName(entryAssembly.Location), "Tmp")
			Me._sOutputFileName = sOutputFileName
			Me._sOutputFilePath = Path.Combine(Me._sOutputFolder, Me._sOutputFileName)
			If Not Directory.Exists(Me._sOutputFolder) Then
				Try
					Directory.CreateDirectory(Me._sOutputFolder)
				Catch ex As Exception
					Return False
				End Try
			End If
			If File.Exists(Me._sOutputFilePath) Then
				Try
					File.Delete(Me._sOutputFilePath)
				Catch ex2 As Exception
					Return False
				End Try
			End If
			Return True
		End Function

		Public Function Write(sMessage As String) As Boolean
			Dim now As DateTime = DateTime.Now
			Dim arg As String = String.Format("{0}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", New Object() {now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second})
			Dim value As String = String.Format("{0} {1}", arg, sMessage)
			Try
				Using streamWriter As New StreamWriter(Me._sOutputFilePath, True, Encoding.UTF8)
					streamWriter.WriteLine(value)
				End Using
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		Public Function WriteLine(sMessage As String, ParamArray sParams As String()) As Boolean
			Return Me.Write(String.Format(sMessage, sParams))
		End Function

		Public Function WriteLine(sMessage As String) As Boolean
			Return Me.Write(sMessage)
		End Function

		Public Function FileExists() As Object
			Return File.Exists(Me._sOutputFilePath)
		End Function

		Public Sub ExpressionFile()
			Process.Start("notepad.exe", Me._sOutputFilePath)
		End Sub

		Private _sOutputFolder As String

		Private _sOutputFileName As String

		Private _sOutputFilePath As String
	End Class
End Namespace
