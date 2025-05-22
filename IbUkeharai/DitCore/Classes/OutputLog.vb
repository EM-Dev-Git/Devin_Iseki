Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace DitCore.Classes

	Public Class OutputLog
		Public Shared Function Initialize(blnDebugMode As Boolean, sLogFilePath As String) As Boolean
			_sLogFilePath = sLogFilePath
			_sLogFileName = Path.GetFileNameWithoutExtension(sLogFilePath)
			_sLogFileExtension = Path.GetExtension(sLogFilePath)
			_sLogFolder = Path.GetDirectoryName(sLogFilePath)
			_blnDebugMode = blnDebugMode
			If Not Directory.Exists(_sLogFolder) Then
				Try
					Directory.CreateDirectory(_sLogFolder)
				Catch ex As Exception
					Return False
				End Try
			End If
			Return BackupOldLogFile() AndAlso WriteLine("OutputLog Class (Initialize) : Mode ({0})", New String() {blnDebugMode.ToString()})
		End Function

		Private Shared Function Write(sMessage As String) As Boolean
			Dim now As DateTime = DateTime.Now
			Dim arg As String = String.Format("{0}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", New Object() {now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second})
			Dim value As String = String.Format("{0} {1} {2}", arg, GetMethodName(), sMessage)
			Try
				Using streamWriter As New StreamWriter(_sLogFilePath, True, Encoding.UTF8)
					streamWriter.WriteLine(value)
					If _blnDebugMode Then
						Console.WriteLine(value)
					End If
					streamWriter.Close()
				End Using
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		Public Shared Function WriteLine(sMessage As String, ParamArray sParams As String()) As Boolean
			Return Write(String.Format(sMessage, sParams))
		End Function

		Public Shared Function WriteLine(sMessage As String) As Boolean
			Return Write(sMessage)
		End Function

		Private Shared Function BackupOldLogFile() As Boolean
			Dim now As DateTime = DateTime.Now
			If File.Exists(_sLogFilePath) Then
				Dim lastWriteTime As DateTime = File.GetLastWriteTime(_sLogFilePath)
				If Operators.CompareString(lastWriteTime.ToString("yyyyMMdd"), now.ToString("yyyyMMdd"), False) <> 0 Then
					Dim text As String
					If String.IsNullOrEmpty(_sLogFileExtension) Then
						text = String.Format("{0}_{1}", Path.Combine(_sLogFolder, _sLogFileName), lastWriteTime.ToString("yyyyMMdd"))
					Else
						text = String.Format("{0}_{1}{2}", Path.Combine(_sLogFolder, _sLogFileName), lastWriteTime.ToString("yyyyMMdd"), _sLogFileExtension)
					End If
					File.Copy(_sLogFilePath, text, True)
					File.Delete(_sLogFilePath)
				End If
			End If
			Dim directoryInfo As New DirectoryInfo(_sLogFolder)
			Dim files As FileInfo()
			Try
				If String.IsNullOrEmpty(_sLogFileExtension) Then
					files = directoryInfo.GetFiles(String.Format("{0}_*", _sLogFileName))
				Else
					files = directoryInfo.GetFiles(String.Format("{0}_*.{1}", _sLogFileName, "Log"))
				End If
			Catch ex As Exception
				Return False
			End Try
			Dim array2 As DateTime() = New DateTime(files.Length - 1 + 1 - 1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = files.Length - 1
			For i As Integer = num To num2
				array2(i) = files(i).LastWriteTime
			Next
			Array.Sort(array2, files)
			If files.Length > 5 Then
				Dim num3 As Integer = 0
				Dim num4 As Integer = files.Length - 5 - 1
				For j As Integer = num3 To num4
					Try
						Dim text As String = Path.Combine(_sLogFolder, files(j).Name)
						File.Delete(text)
					Catch ex2 As Exception
						Return False
					End Try
				Next
			End If
			Return True
		End Function

		Private Shared Function GetMethodName() As String
			Dim frame As StackFrame = New StackTrace(True).GetFrame(3)
			Return Path.GetFileNameWithoutExtension(frame.GetFileName()) + ":" + frame.GetMethod().Name
		End Function

		Public Const LOG_COUNT As Integer = 5

		Private Shared _sLogFolder As String

		Private Shared _sLogFileName As String

		Private Shared _sLogFileExtension As String

		Private Shared _sLogFilePath As String

		Private Shared _blnDebugMode As Boolean = False
	End Class
End Namespace
