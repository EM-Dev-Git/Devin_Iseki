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

Namespace IbUkeharai.BatchExec
	Public Class HostDataReceive
		Public Sub New()
			Me._ftpMatuyamaFile = Nothing
			Me._ftpBackMatuyamaFile = Nothing
			Me._ftpMatuyamaMFile = Nothing
			Me._ftpBackMatuyamaMFile = Nothing
			Me._ftpMatuyamaKFile = Nothing
			Me._ftpBackMatuyamaKFile = Nothing
			Me._ftpMatuyamaSFile = Nothing
			Me._ftpBackMatuyamaSFile = Nothing
			Me._ftpMatuyamaBFile = Nothing
			Me._ftpBackMatuyamaBFile = Nothing
			Me._ftpKumamotoFile = Nothing
			Me._ftpBackKumamotoFile = Nothing
			Me._ftpSaveFolder = Nothing
			Me._ftpSaveFile = Nothing
			Me._ftpNullFile = Nothing
			Me._enc = Encoding.GetEncoding("Shift_jis")
			Me._ftp = Nothing
			Me._testmode = False
			Me._kyoten = CType(0, HostDataReceive.baseNum)
		End Sub

		Public Function Exec() As Boolean
			If Not Me.CheckConfigParam() Then
				DlgMessageBox.Show("コンフィグファイル(FTP)の設定に不備があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("ホストデータ受信設定に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If Me._kyoten = HostDataReceive.baseNum.Matuyama Then
				If Not Me.HaraidasiDataReceiveMatsuyama() Then
					Return False
				End If
			ElseIf Me._kyoten = HostDataReceive.baseNum.Kumamoto AndAlso Not Me.HaraidasiDataReceive() Then
				Return False
			End If
			Return True
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
			If IsNothing(TopForm.ConfigData) Then
				Return False
			End If
			Dim xmlConfData As xRoot = TopForm.ConfigData.xmlConfData
			If Operators.CompareString(xmlConfData.Kyoten, String.Empty, False) = 0 Then
				Return False
			End If
			Me._kyoten = CType(Me.GetKyotenNo(xmlConfData.Kyoten), HostDataReceive.baseNum)
			If Operators.CompareString(xmlConfData.xFtpServer.UserId, String.Empty, False) = 0 Then
				Return False
			End If
			If Operators.CompareString(xmlConfData.xFtpServer.Password, String.Empty, False) = 0 Then
				Return False
			End If
			If Operators.CompareString(xmlConfData.xFtpServer.FtpUrl, String.Empty, False) = 0 Then
				Return False
			End If
			If Operators.CompareString(xmlConfData.xFtpServer.FtpBackUpUrl, String.Empty, False) = 0 Then
				Return False
			End If
			Me._ftp = xmlConfData.xFtpServer
			Return True
		End Function

		Private Function CheckSettingParam() As Boolean
			Return Not (Me._kyoten <> HostDataReceive.baseNum.Matuyama And Me._kyoten <> HostDataReceive.baseNum.Kumamoto) AndAlso Not (Information.IsNothing(Me._ftpMatuyamaMFile) Or Information.IsNothing(Me._ftpBackMatuyamaMFile)) AndAlso Not (Information.IsNothing(Me._ftpMatuyamaKFile) Or Information.IsNothing(Me._ftpBackMatuyamaKFile)) AndAlso Not (Information.IsNothing(Me._ftpMatuyamaSFile) Or Information.IsNothing(Me._ftpBackMatuyamaSFile)) AndAlso Not (Information.IsNothing(Me._ftpMatuyamaBFile) Or Information.IsNothing(Me._ftpBackMatuyamaBFile)) AndAlso Not (Information.IsNothing(Me._ftpKumamotoFile) Or Information.IsNothing(Me._ftpBackKumamotoFile)) AndAlso Not Information.IsNothing(Me._ftpSaveFolder) AndAlso Not Information.IsNothing(Me._ftpSaveFile) AndAlso Not Information.IsNothing(Me._ftpNullFile) AndAlso Me.SetFtpTestMode(Me._ftp.TestMode)
		End Function

		Private Function SetFtpTestMode(mode As String) As Boolean
			Dim result As Boolean = False
			Try
				Me._testmode = Boolean.Parse(Me._ftp.TestMode)
				result = True
			Catch ex As Exception
				DlgMessageBox.Show("FTP設定のTestModeの値が不明です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return result
		End Function

		Private Function HaraidasiDataReceive() As Boolean
			Dim ftpdataUrl As String = Me.GetFTPDataUrl()
			Dim savePath As String = Me.GetSavePath()
			Dim backUpPath As String = Me.GetBackUpPath()
			Dim nullFilePath As String = Me.GetNullFilePath()
			Dim ftpCommon As New FtpCommon(Me._ftp.UserId, Me._ftp.Password)
			If Not ftpCommon.DownLoadFile(ftpdataUrl, savePath) Then
				DlgMessageBox.Show("ファイルのダウンロードに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If Not Me.CheckBackUpData(savePath) Then
				Me.DeletReceiveFile()
				Return False
			End If
			If Me._testmode Then
				Me.DeletReceiveFile()
				Return True
			End If
			If Not ftpCommon.IsDirectory(Me._ftp.FtpBackUpUrl) AndAlso Not ftpCommon.CreateDirectory(Me._ftp.FtpBackUpUrl) Then
				DlgMessageBox.Show("バックアップフォルダの作成に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If Not ftpCommon.UpLoadFile(backUpPath, savePath) Then
				DlgMessageBox.Show("受信データのバックアップに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me.DeletReceiveFile()
			If Not ftpCommon.UpLoadFile(ftpdataUrl, nullFilePath) Then
				DlgMessageBox.Show("受信データの初期化に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Return True
		End Function

		Private Function HaraidasiDataReceiveMatsuyama() As Boolean
			Dim array As String() = New String() {Me._ftpMatuyamaMFile, Me._ftpMatuyamaKFile, Me._ftpMatuyamaSFile, Me._ftpMatuyamaBFile}
			Dim savePathMasuyama As String = Me.GetSavePathMasuyama(Me._ftpSaveFile)
			Dim text As String = Me.GetdumyFilePath("dumy.txt")
			For Each file1 As String In array
				Dim ftpdataUrlMatsuyama As String = Me.GetFTPDataUrlMatsuyama(file1)
				Dim savePathMasuyama2 As String = Me.GetSavePathMasuyama(file1)
				Dim backUpPathMatsuyama As String = Me.GetBackUpPathMatsuyama(file1)
				Dim nullFilePath As String = Me.GetNullFilePath()
				Dim ftpCommon As New FtpCommon(Me._ftp.UserId, Me._ftp.Password)
				If Not ftpCommon.DownLoadFile(ftpdataUrlMatsuyama, savePathMasuyama2) Then
					DlgMessageBox.Show("ファイルのダウンロードに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.DeletReceiveFile(text)
					Return False
				End If
				If Not Me.MatsuyamaChekReceiveData(savePathMasuyama2) Then
					Me.DeletReceiveFile(savePathMasuyama2)
				Else
					If File.Exists(savePathMasuyama2) Then
						Try
							Dim text2 As String = File.ReadAllText(text)
							Dim str As String = File.ReadAllText(savePathMasuyama2)
							text2 += str
							File.WriteAllText(text, text2)
						Catch ex As Exception
							DlgMessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.DeletReceiveFile(text)
						End Try
					End If
					If Me._testmode Then
						Me.DeletReceiveFile(savePathMasuyama2)
						Return True
					End If
					If Not ftpCommon.IsDirectory(Me._ftp.FtpBackUpUrl) AndAlso Not ftpCommon.CreateDirectory(Me._ftp.FtpBackUpUrl) Then
						DlgMessageBox.Show("バックアップフォルダの作成に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.DeletReceiveFile(text)
						Return False
					End If
					If Not ftpCommon.UpLoadFile(backUpPathMatsuyama, savePathMasuyama2) Then
						DlgMessageBox.Show("受信データのバックアップに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.DeletReceiveFile(text)
						Return False
					End If
					Me.DeletReceiveFile(savePathMasuyama2)
					If Not ftpCommon.UpLoadFile(ftpdataUrlMatsuyama, nullFilePath) Then
						DlgMessageBox.Show("受信データの初期化に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.DeletReceiveFile(text)
						Return False
					End If
				End If
			Next
			Try
				Dim fileInfo As New FileInfo(text)
				If fileInfo.Length = 0L Then
					DlgMessageBox.Show("受信データに書き込み可能なデータが有りません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.DeletReceiveFile(text)
					Return False
				End If
				File.Copy(text, savePathMasuyama, True)
			Catch ex2 As Exception
				DlgMessageBox.Show(ex2.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.DeletReceiveFile(text)
				Return False
			End Try
			Me.DeletReceiveFile(text)
			Return True
		End Function

		Private Function GetFTPDataUrl() As String
			Dim result As String = ""
			If Me._testmode Then
				If Me._kyoten = HostDataReceive.baseNum.Matuyama Then
					result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaFile)
				ElseIf Me._kyoten = HostDataReceive.baseNum.Kumamoto Then
					result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackKumamotoFile)
				End If
				Return result
			End If
			If Me._kyoten = HostDataReceive.baseNum.Matuyama Then
				result = Path.Combine(Me._ftp.FtpUrl, Me._ftpMatuyamaFile)
			ElseIf Me._kyoten = HostDataReceive.baseNum.Kumamoto Then
				result = Path.Combine(Me._ftp.FtpUrl, Me._ftpKumamotoFile)
			End If
			Return result
		End Function

		Private Function GetFTPDataUrlMatsuyama(file As String) As String
			Return Path.Combine(Me._ftp.FtpUrl, file)
		End Function

		Private Function GetSavePath() As String
			Dim result As String = ""
			If Not BaseOperation.IsDirectory(Me._ftpSaveFolder) AndAlso Not BaseOperation.CreateDirectory(Me._ftpSaveFolder) Then
				Return result
			End If
			If Me._kyoten = HostDataReceive.baseNum.Matuyama Then
				result = Path.Combine(Me._ftpSaveFolder, Me._ftpMatuyamaFile)
			ElseIf Me._kyoten = HostDataReceive.baseNum.Kumamoto Then
				result = Path.Combine(Me._ftpSaveFolder, Me._ftpKumamotoFile)
			End If
			Return result
		End Function

		Private Function GetSavePathMasuyama(file As String) As String
			Dim result As String = ""
			If Not BaseOperation.IsDirectory(Me._ftpSaveFolder) AndAlso Not BaseOperation.CreateDirectory(Me._ftpSaveFolder) Then
				Return result
			End If
			Return Path.Combine(Me._ftpSaveFolder, file)
		End Function

		Private Function GetNullFilePath() As String
			Dim result As String = ""
			If BaseOperation.IsDirectory(Me._ftpSaveFolder) Then
				Dim text As String = Path.Combine(Me._ftpSaveFolder, Me._ftpNullFile)
				If Not BaseOperation.IsFile(text) Then
					BaseOperation.CreateNullFile(text)
				End If
				result = text
			End If
			Return result
		End Function

		Private Function GetdumyFilePath(dumy As String) As String
			Dim result As String = ""
			If BaseOperation.IsDirectory(Me._ftpSaveFolder) Then
				Dim text As String = Path.Combine(Me._ftpSaveFolder, dumy)
				If Not BaseOperation.IsFile(text) Then
					BaseOperation.CreateNullFile(text)
				End If
				result = text
			End If
			Return result
		End Function

		Private Function GetBackUpPath() As String
			Dim result As String = ""
			If Me._kyoten = HostDataReceive.baseNum.Matuyama Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaFile)
			ElseIf Me._kyoten = HostDataReceive.baseNum.Kumamoto Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackKumamotoFile)
			End If
			Return result
		End Function

		Private Function GetBackUpPathMatsuyama(file As String) As String
			Dim result As String = ""
			If Operators.CompareString(file, Me._ftpMatuyamaMFile, False) = 0 Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaMFile)
			ElseIf Operators.CompareString(file, Me._ftpMatuyamaKFile, False) = 0 Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaKFile)
			ElseIf Operators.CompareString(file, Me._ftpMatuyamaSFile, False) = 0 Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaSFile)
			ElseIf Operators.CompareString(file, Me._ftpMatuyamaBFile, False) = 0 Then
				result = Path.Combine(Me._ftp.FtpBackUpUrl, Me._ftpBackMatuyamaBFile)
			End If
			Return result
		End Function

		Private Function CheckBackUpData(path As String) As Boolean
			Dim result As Boolean = False
			Dim streamReader As StreamReader = BaseOperation.CreateStreamReader(path)
			If IsNothing(streamReader) Then
				Return result
			End If
			Dim text As String = streamReader.ReadToEnd()
			streamReader.Close()
			If text.Length < 75 Then
				DlgMessageBox.Show("受信データに書き込み可能なデータが有りません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return result
			End If
			Return Me.ChekReceiveData(path)
		End Function

		Private Function ChekReceiveData(path1 As String) As Boolean
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_jis")
			Try
				Dim array As String() = File.ReadAllLines(path1, encoding)
				Dim list As New List(Of String)()
				If Me._kyoten = baseNum.Matuyama Then
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

		Private Function MatsuyamaChekReceiveData(path1 As String) As Boolean
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_jis")
			Try
				Dim array As String() = File.ReadAllLines(path1, encoding)
				Dim list As New List(Of String)()
				If Me._kyoten = baseNum.Matuyama Then
					list = Me.CheckTextLine(array)
				Else
					list.AddRange(array)
				End If
				If list.Count < 1 Then
					Return False
				End If
				Dim path2 As String = Path.Combine(Me._ftpSaveFolder, path1)
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
			Dim result As Boolean = False
			If val.Length < 75 Then
				Return result
			End If
			Dim left As String = val.Substring(73, 2)
			If Operators.CompareString(left, "01", False) = 0 Then
				result = True
			ElseIf Operators.CompareString(left, "02", False) = 0 Then
				Dim left2 As String = val.Substring(0, 8)
				If Operators.CompareString(left2, "17061000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "15035000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "15128000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "15474000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "18000000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "17883000", False) = 0 Then
					result = True
				ElseIf Operators.CompareString(left2, "15026000", False) = 0 Then
					result = True
				End If
			ElseIf Operators.CompareString(left, "03", False) = 0 Then
				result = True
			ElseIf Operators.CompareString(left, "04", False) = 0 Then
				result = True
			ElseIf Operators.CompareString(left, "06", False) = 0 Then
				result = True
			End If
			Return result
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
			If BaseOperation.IsFile(savePath) Then
				BaseOperation.DeleteFile(savePath)
			End If
		End Sub

		Private Sub DeletReceiveFile(filePath As String)
			If BaseOperation.IsFile(filePath) Then
				BaseOperation.DeleteFile(filePath)
			End If
		End Sub

		Private Sub DeletSaveFile()
			Dim path1 As String = Path.Combine(Me._ftpSaveFolder, Me._ftpSaveFile)
			If BaseOperation.IsFile(path1) Then
				BaseOperation.DeleteFile(path1)
			End If
		End Sub

		Public _ftpMatuyamaFile As String

		Public _ftpBackMatuyamaFile As String

		Public _ftpMatuyamaMFile As String

		Public _ftpBackMatuyamaMFile As String

		Public _ftpMatuyamaKFile As String

		Public _ftpBackMatuyamaKFile As String

		Public _ftpMatuyamaSFile As String

		Public _ftpBackMatuyamaSFile As String

		Public _ftpMatuyamaBFile As String

		Public _ftpBackMatuyamaBFile As String

		Public _ftpKumamotoFile As String

		Public _ftpBackKumamotoFile As String

		Public _ftpSaveFolder As String

		Public _ftpSaveFile As String

		Public _ftpNullFile As String

		Private _enc As Encoding

		Private _ftp As FtpServerInfo

		Private _testmode As Boolean

		Private _kyoten As baseNum

		Public Enum baseNum

			Matuyama = 1

			Kumamoto
		End Enum
	End Class
End Namespace
