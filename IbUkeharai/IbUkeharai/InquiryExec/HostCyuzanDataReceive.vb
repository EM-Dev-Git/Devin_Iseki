Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.InquiryExec

	Public Class HostCyuzanDataReceive

		Public Sub New()
			Me._ftpCyuzanFile = Nothing
			Me._ftpSaveFolder = Nothing
			Me._ftpSaveFile = Nothing
			Me._enc = Encoding.GetEncoding("Shift_jis")
			Me._ftpkeppin = Nothing
			Me._testmode = False
			Me._kyoten = CType(0, HostCyuzanDataReceive.baseNum)
		End Sub

		Public Function Exec() As Boolean
			If Not Me.CheckConfigParam() Then
				DlgMessageBox.Show("コンフィグファイル(FTP)の設定に不備があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Return Me.KeppinDataReceive()
		End Function

		Private Function GetKyotenNo(kyoten As String) As Integer
			If Operators.CompareString(kyoten, "Matsuyama", False) = 0 Then
				Return 1
			End If
			If Operators.CompareString(kyoten, "Kumamoto", False) = 0 Then
				Return 2
			End If
			Return 0
		End Function

		Private Function CheckConfigParam() As Boolean
			If Information.IsNothing(TopForm.ConfigData) Then
				Return False
			End If
			Dim xmlConfData As xRoot = TopForm.ConfigData.xmlConfData
			If Operators.CompareString(xmlConfData.Kyoten, String.Empty, False) = 0 Then
				Return False
			End If
			Me._kyoten = CType(Me.GetKyotenNo(xmlConfData.Kyoten), HostCyuzanDataReceive.baseNum)
			If Operators.CompareString(xmlConfData.xFtpServer_Keppin.UserId, String.Empty, False) = 0 Then
				Return False
			End If
			If Operators.CompareString(xmlConfData.xFtpServer_Keppin.Password, String.Empty, False) = 0 Then
				Return False
			End If
			If Operators.CompareString(xmlConfData.xFtpServer_Keppin.FtpUrl, String.Empty, False) = 0 Then
				Return False
			End If
			Me._ftpkeppin = xmlConfData.xFtpServer_Keppin
			Return True
		End Function

		Private Function CheckSettingParam() As Boolean
			Return Not (Me._kyoten <> HostCyuzanDataReceive.baseNum.Matuyama And Me._kyoten <> HostCyuzanDataReceive.baseNum.Kumamoto) AndAlso Not (Information.IsNothing(Me._ftpCyuzanFile) Or Information.IsNothing(Me._ftpCyuzanFile)) AndAlso Not Information.IsNothing(Me._ftpSaveFolder) AndAlso Not Information.IsNothing(Me._ftpSaveFile) AndAlso Me.SetFtpTestMode(Me._ftpkeppin.TestMode)
		End Function

		Private Function SetFtpTestMode(mode As String) As Boolean
			Dim result As Boolean = False
			Try
				Me._testmode = Boolean.Parse(Me._ftpkeppin.TestMode)
				result = True
			Catch ex As Exception
				DlgMessageBox.Show("FTP設定のTestModeの値が不明です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return result
		End Function

		Private Function KeppinDataReceive() As Boolean
			Dim ftpcyuzanDataUrl As String = Me.GetFTPCyuzanDataUrl()
			Dim savePath As String = Me.GetSavePath()
			Dim ftpCommon As New FtpCommon(Me._ftpkeppin.UserId, Me._ftpkeppin.Password)
			If ftpCommon.IsDirectory(ftpcyuzanDataUrl) Then
				If Not ftpCommon.DownLoadFile(ftpcyuzanDataUrl, savePath) Then
					DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				If Me._testmode Then
					Me.DeletReceiveFile()
					Return True
				End If
			End If
			Return True
		End Function

		Private Function GetFTPCyuzanDataUrl() As String
			Dim result As String = ""
			If Me._testmode Then
				Return result
			End If
			If Me._kyoten = HostCyuzanDataReceive.baseNum.Matuyama Then
				result = Path.Combine(Me._ftpkeppin.FtpUrl, Me._ftpCyuzanFile)
			ElseIf Me._kyoten = HostCyuzanDataReceive.baseNum.Kumamoto Then
				result = Path.Combine(Me._ftpkeppin.FtpUrl, Me._ftpCyuzanFile)
			End If
			Return result
		End Function

		Private Function GetSavePath() As String
			Dim result As String = ""
			If Not BaseOperation2.IsDirectory(Me._ftpSaveFolder) AndAlso Not BaseOperation2.CreateDirectory(Me._ftpSaveFolder) Then
				Return result
			End If
			If Me._kyoten = HostCyuzanDataReceive.baseNum.Matuyama Then
				result = Path.Combine(Me._ftpSaveFolder, Me._ftpCyuzanFile)
			ElseIf Me._kyoten = HostCyuzanDataReceive.baseNum.Kumamoto Then
				result = Path.Combine(Me._ftpSaveFolder, Me._ftpCyuzanFile)
			End If
			Return result
		End Function

		Private Function ChekReceiveData(path1 As String) As Boolean
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_jis")
			Try
				Dim array As String() = File.ReadAllLines(path1, encoding)
				Dim list As New List(Of String)()
				If Me._kyoten = HostCyuzanDataReceive.baseNum.Matuyama Then
					list = Me.CheckTextLine(array)
				Else
					list.AddRange(array)
				End If
				If list.Count < 1 Then
					DlgMessageBox.Show("受信データに書き込み可能なデータが有りません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				Dim path2 As String = Path.Combine(Me._ftpSaveFolder, Me._ftpSaveFile)
				Me.WriteTextLine(path2, list, encoding)
			Catch ex As Exception
				DlgMessageBox.Show("受信データチェックに失敗しました。" + Environment.NewLine + ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Private Function CheckTextLine(data As String()) As List(Of String)
			Dim list As New List(Of String)()
			For Each text As String In data
				If Me.CheckWritLineData(text) Then
					list.Add(text)
				End If
			Next
			Return list
		End Function

		Private Function CheckWritLineData(val As String) As Boolean
			Dim flag As Boolean = False
			Return val.Length >= 102 OrElse flag
		End Function

		Private Sub WriteTextLine(path As String, data As List(Of String), enc As Encoding)
			If path.Length < 1 Or data.Count < 1 Then
				Return
			End If
			Dim streamWriter As New StreamWriter(path, False, enc)
			Try
				For Each value As String In data
					streamWriter.WriteLine(value)
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			streamWriter.Close()
		End Sub

		Private Sub DeleteFiles()
			Me.DeletReceiveFile()
			Me.DeletSaveFile()
		End Sub

		Private Sub DeletReceiveFile()
			Dim savePath As String = Me.GetSavePath()
			If BaseOperation2.IsFile(savePath) Then
				BaseOperation2.DeleteFile(savePath)
			End If
		End Sub

		Private Sub DeletSaveFile()
			Dim path1 As String = Path.Combine(Me._ftpSaveFolder, Me._ftpSaveFile)
			If BaseOperation2.IsFile(path1) Then
				BaseOperation2.DeleteFile(path1)
			End If
		End Sub

		Public _ftpCyuzanFile As String

		Public _ftpSaveFolder As String

		Public _ftpSaveFile As String

		Private _enc As Encoding

		Private _ftpkeppin As FtpServer_KeppinInfo

		Private _testmode As Boolean

		Private _kyoten As HostCyuzanDataReceive.baseNum

		Public Enum baseNum

			Matuyama = 1

			Kumamoto
		End Enum
	End Class
End Namespace
