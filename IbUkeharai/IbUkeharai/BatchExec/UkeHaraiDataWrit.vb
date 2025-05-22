Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Data
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.BatchExec

	Public Class UkeHaraiDataWrit

		Public Sub New()
			Me._configData = Nothing
			Me._funcName = Nothing
			Me._ukeharaiKubun = Nothing
			Me._fixcount = 1
			Me._outPutFolder = Nothing
			Me._fixBackCount = 1
			Me._backUpFolder = Nothing
			Me._okFileName = Nothing
			Me._errFileName = Nothing
			Me._enc = Encoding.GetEncoding("Shift_jis")
			Me._fileformat = ".DAT"
			Me._now = Nothing
			Me._okfile = Nothing
			Me._srOk = Nothing
			Me._errfile = Nothing
			Me._srErr = Nothing
			Me._viewInfo = Nothing
		End Sub

		Public Function WritDataExec(path As String) As Boolean
			Dim flag As Boolean = False
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("設定情報に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return flag
			End If
			Me.CreateOutPutFile()
			Try
				Dim receiveData As String() = Me.GetReceiveData(path)
				If IsNothing(receiveData) Then
					DlgMessageBox.Show("データファイルが存在しません。" & vbCrLf & "または、ファイルを開くことができません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return flag
				End If
				If Not Me.ReceiveDataRead(receiveData) Then
					DlgMessageBox.Show("有効な書き込みデータが存在しません。" & vbCrLf & "または、ファイルデータの並びが不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				Me.FileBackUp(path)
				Me.DeleteReceiveFile(path)
				flag = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("WritData Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			Finally
				If flag Then
					Me.OutPutClose()
					Me.CheckOkData()
					Me.CheckUnknownData()
				Else
					Me.OutPutClose()
					Me.OutPutFileDelete()
				End If
				Me.FixedOutPutFile()
				Me.FixedBackUpFile()
			End Try
			Return flag
		End Function

		Public Function RetryWritDataExec(filePath As String) As Boolean
			Dim flag As Boolean = False
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("設定情報に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return flag
			End If
			Me.CreateOutPutFile()
			Try
				Dim receiveData As String() = Me.GetReceiveData(filePath)
				If IsNothing(receiveData) Then
					DlgMessageBox.Show("データファイルが存在しません。" & vbCrLf & "または、ファイルを開くことができません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return flag
				End If
				Me.TrimErrTyepStr(receiveData)
				If Not Me.ReceiveDataRead(receiveData) Then
					DlgMessageBox.Show("有効な書き込みデータが存在しません。" & vbCrLf & "または、ファイルデータの並びが不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				Me.FileBackUp(filePath)
				Me.DeleteReceiveFile(filePath)
				flag = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("ReWritData Errer : {0}" & vbCrLf & "filePath[{1}]", ex.Message, filePath))
			Finally
				If flag Then
					Me.OutPutClose()
					Me.CheckOkData()
					Me.CheckUnknownData()
				Else
					Me.OutPutClose()
					Me.OutPutFileDelete()
				End If
				Me.FixedOutPutFile()
				Me.FixedBackUpFile()
			End Try
			Return flag
		End Function

		Private Function TrimErrTyepStr(datas As String()) As String()
			Dim num As Integer = 0
			Dim num2 As Integer = datas.Count() - 1
			For i As Integer = num To num2
				If datas(i).Length > 75 Then
					datas(i) = datas(i).Substring(0, 75)
				End If
			Next
			Return datas
		End Function

		Private Function CheckSettingParam() As Boolean
			Return Not IsNothing(Me._configData) AndAlso Not IsNothing(Me._ukeharaiKubun) AndAlso Not IsNothing(Me._outPutFolder) AndAlso Not IsNothing(Me._okFileName) AndAlso Not IsNothing(Me._errFileName) AndAlso Not IsNothing(Me._backUpFolder)
		End Function

		Private Function GetDbParam(sql As String) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sql, True)
				If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function InsertUkeharaiMeisai(sql As String) As Boolean
			Dim result As Boolean = False
			If IsNothing(Me._configData) Then
				Return False
			End If
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.execSql(sql)
			End Using
			Return result
		End Function

		Private Function GetToriSql(toricd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD = '{0}' ", toricd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetBuhinSql(toricd As String, buhincd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_BUHIN [M_Buhin] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Buhin.TORI_CD = '{0}' ", toricd))
			stringBuilder.Append(String.Format("AND M_Buhin.BUHIN_CD LIKE '{0}' ", buhincd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetTankaSql(toricd As String, buhincd As String, sakicd As String, accept As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TANKA [M_Tanka] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tanka.TORI_CD = '{0}' ", toricd))
			stringBuilder.Append(String.Format("AND M_Tanka.BUHIN_CD LIKE '{0}' ", buhincd))
			stringBuilder.Append(String.Format("AND M_Tanka.SAKI_CD = '{0}' ", sakicd))
			stringBuilder.Append(String.Format("AND CONVERT(VARCHAR(30), {0}, 111) BETWEEN M_tanka.YUKO_FM AND M_tanka.YUKO_TO ", accept))
			Return stringBuilder.ToString()
		End Function

		Private Function GetUkeharaiMeisaiTable() As DataTable
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_UKEHARAIMEISAI  [T_Meisai] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE T_Meisai.TORI_CD = '00000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.BUHIN_CD LIKE '000000000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.UKEHARA_YYYYMMDD = '2000/01/01' ", New Object(-1) {}))
			Return Me.GetDbParam(stringBuilder.ToString())
		End Function

		Private Function CreateHaraiMeisaiData(tb As DataTable, item As SN41A00, sType As String, Optional tesu As String = "") As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("TORI_CD") = item.tori_cd
				dataRow("BUHIN_CD") = item.buhin_cd
				Dim value As String = String.Format("{0}/{1}/{2}", DateAndTime.Now.ToString("yyyy"), item.acceptMMDD.Substring(0, 2), item.acceptMMDD.Substring(2, 2))
				dataRow("UKEHARA_YYYYMMDD") = value
				dataRow("DEN_NO") = String.Format("{0} {1}", item.order_NO, item.set_NO)
				dataRow("UKEHARAI_KBN") = Me._ukeharaiKubun
				dataRow("KOSU") = item.kosu
				dataRow("REMARKS1") = item.order_cd
				dataRow("SAKI_CD") = item.saki_cd
				dataRow("KINGAKU") = item.money
				Dim value2 As String = "0.00"
				If Operators.CompareString(sType, "1", False) = 0 Then
					value2 = tesu
				End If
				dataRow("TESU") = value2
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = Me._funcName
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateMeisaiData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateUkeMeisaiData(tb As DataTable, item As SN41A00) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("TORI_CD") = item.tori_cd
				dataRow("BUHIN_CD") = item.buhin_cd
				Dim value As String = String.Format("{0}/{1}/{2}", DateAndTime.Now.ToString("yyyy"), item.acceptMMDD.Substring(0, 2), item.acceptMMDD.Substring(2, 2))
				dataRow("UKEHARA_YYYYMMDD") = value
				dataRow("DEN_NO") = String.Format("{0} {1}", item.order_NO, item.set_NO)
				dataRow("UKEHARAI_KBN") = "1"
				dataRow("KOSU") = item.kosu
				dataRow("REMARKS1") = item.order_cd
				dataRow("SAKI_CD") = item.saki_cd
				dataRow("KINGAKU") = item.money
				Dim value2 As String = "0.00"
				dataRow("TESU") = value2
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = Me._funcName
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateMeisaiData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateInsertSql(tb As DataTable) As String
			Dim str As String = "INSERT INTO Ukeharai.T_UKEHARAIMEISAI "
			Dim count As Integer = tb.Columns.Count
			Dim text As String = "("
			Dim text2 As String = "VALUES ("
			Dim dataRow As DataRow = tb.Rows(0)
			Dim num As Integer = 0
			Dim num2 As Integer = count - 1
			For i As Integer = num To num2
				Dim caption As String = tb.Columns(i).Caption
				text += caption
				If Not IsNothing(RuntimeHelpers.GetObjectValue(dataRow(i))) Then
					If Me.GetDataType(caption) = 1 Then
						text2 += dataRow(i).ToString()
					Else
						text2 += String.Format("'{0}'", RuntimeHelpers.GetObjectValue(dataRow(i)))
					End If
				End If
				If i < count - 1 Then
					text += " ,"
					text2 += " ,"
				Else
					text += " )"
					text2 += " )"
				End If
			Next
			Return str + text + text2
		End Function

		Private Function GetDataType(name As String) As Integer
			Dim result As Integer
			If Operators.CompareString(name, "KOSU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "KINGAKU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "TESU", False) = 0 Then
				result = 1
			Else
				result = 0
			End If
			Return result
		End Function

		Private Function OpenOkFile(now As DateTime) As Boolean
			Dim okFilePath As String = Me.GetOkFilePath(now)
			If IsNothing(okFilePath) Then
				Return False
			End If
			Me._srOk = BaseOperation.CreateStreamWriter(okFilePath, Me._enc)
			If IsNothing(Me._srOk) Then
				Return False
			End If
			Me._okfile = okFilePath
			Return True
		End Function

		Private Sub DeleteOkFile()
			If IsNothing(Me._okfile) Then
				Return
			End If
			If Not BaseOperation.IsFile(Me._okfile) Then
				Return
			End If
			File.Delete(Me._okfile)
			Me._okfile = Nothing
		End Sub

		Private Function GetOkFilePath(now As DateTime) As String
			Dim result As String = Nothing
			If Not BaseOperation.IsDirectory(Me._outPutFolder) AndAlso Not BaseOperation.CreateDirectory(Me._outPutFolder) Then
				Return result
			End If
			Dim path1 As String = Me.AddFilenameToDatetime(Me._okFileName, now) + Me._fileformat
			Return Path.Combine(Me._outPutFolder, path1)
		End Function

		Private Function OpenErrFile(now As DateTime) As Boolean
			Dim errFilePath As String = Me.GetErrFilePath(now)
			If IsNothing(errFilePath) Then
				Return False
			End If
			Me._srErr = BaseOperation.CreateStreamWriter(errFilePath, Me._enc)
			If IsNothing(Me._srErr) Then
				Return False
			End If
			Me._errfile = errFilePath
			Return True
		End Function

		Private Sub DeleteErrFile()
			If IsNothing(Me._errfile) Then
				Return
			End If
			If Not BaseOperation.IsFile(Me._errfile) Then
				Return
			End If
			File.Delete(Me._errfile)
			Me._errfile = Nothing
		End Sub

		Private Function GetErrFilePath(now As DateTime) As String
			Dim result As String = Nothing
			If Not BaseOperation.IsDirectory(Me._outPutFolder) AndAlso Not BaseOperation.CreateDirectory(Me._outPutFolder) Then
				Return result
			End If
			Dim path1 As String = Me.AddFilenameToDatetime(Me._errFileName, now) + Me._fileformat
			Return Path.Combine(Me._outPutFolder, path1)
		End Function

		Private Function CreateOutPutFile() As Boolean
			Dim flag As Boolean = False
			Me._now = DateTime.Now
			Try
				If Not Me.OpenOkFile(Me._now) Then
					flag = flag
				ElseIf Not Me.OpenErrFile(Me._now) Then
					flag = flag
				Else
					flag = True
				End If
			Catch ex As Exception
				Me.OutPutClose()
				Me.OutPutFileDelete()
			End Try
			Return flag
		End Function

		Private Sub OutPutClose()
			If Not IsNothing(Me._srOk) Then
				Me._srOk.Close()
				Me._srOk = Nothing
			End If
			If Not IsNothing(Me._srErr) Then
				Me._srErr.Close()
				Me._srErr = Nothing
			End If
			If Not IsNothing(Me._now) Then
				Me._now = Nothing
			End If
		End Sub

		Private Sub OutPutFileDelete()
			Me.DeleteOkFile()
			Me.DeleteErrFile()
		End Sub

		Private Sub FixedOutPutFile()
			Dim list As New List(Of String)()
			Dim list2 As New List(Of String)()
			For Each text As String In BaseOperation.GetFileList(Me._outPutFolder)
				If text.IndexOf(Me._okFileName) >= 0 Then
					list.Add(text)
				ElseIf text.IndexOf(Me._errFileName) >= 0 Then
					list2.Add(text)
				End If
			Next
			If list.Count > Me._fixcount Then
				BaseOperation.DeleteFileList(list, Me._fixcount)
			End If
			If list2.Count > Me._fixcount Then
				BaseOperation.DeleteFileList(list2, Me._fixcount)
			End If
		End Sub

		Private Function AddFilenameToDatetime(name As String, addDate As DateTime) As String
			Return String.Concat(New String() {name, "-", addDate.ToString("yyyyMMdd"), "-", addDate.ToString("HHmmss")})
		End Function

		Private Sub FileBackUp(path1 As String)
			If Not BaseOperation.IsDirectory(Me._backUpFolder) AndAlso Not BaseOperation.CreateDirectory(Me._backUpFolder) Then
				Return
			End If
			Dim fileName As String = Path.GetFileName(path1)
			Dim dst As String = Path.Combine(Me._backUpFolder, fileName)
			BaseOperation.CopyToFile(path1, dst)
		End Sub

		Private Sub FixedBackUpFile()
			Dim list As New List(Of String)()
			Dim array1 As String() = BaseOperation.GetFileList(Me._backUpFolder)
			If array1 IsNot Nothing Then
				For Each item As String In array1
					list.Add(item)
				Next
			End If
			If list.Count > Me._fixBackCount Then
				BaseOperation.DeleteFileList(list, Me._fixBackCount)
			End If
		End Sub

		Private Function ReceiveDataRead(datas As String()) As Boolean
			Me.CreateViewInfo()
			For Each text As String In datas
				If text.Length >= 75 Then
					Dim sn41A As New SN41A00(text)
					Dim sql As String = Me.GetToriSql(sn41A.tori_cd)
					Dim dbParam As DataTable = Me.GetDbParam(sql)
					If dbParam.Rows.Count < 1 Then
						text += "#"
						Me.WriteUnknownData(text, sn41A)
					Else
						sql = Me.GetBuhinSql(sn41A.tori_cd, sn41A.buhin_cd)
						Dim dbParam2 As DataTable = Me.GetDbParam(sql)
						If dbParam2.Rows.Count < 1 Then
							text += "*"
							Me.WriteUnknownData(text, sn41A)
						Else
							Dim num As Integer = Conversions.ToInteger(sn41A.saki_cd)
							If num < 1 Or num > 5 Then
								num = 6
							End If
							If Operators.CompareString(Me._ukeharaiKubun, "1", False) = 0 Then
								If Not Me.UkeDataWrite(text, sn41A) Then
									GoTo IL_108
								End If
							ElseIf Not Me.HaraiDataWrite(text, sn41A, dbParam) Then
								GoTo IL_108
							End If
							Me.SetViewValue(num, sn41A)
						End If
					End If
				End If
IL_108:
			Next
			Return Me.SetTotaleViewValue()
		End Function

		Private Function UkeDataWrite(lineData As String, item As SN41A00) As Boolean
			Dim flag As Boolean = False
			Dim ukeharaiMeisaiTable As DataTable = Me.GetUkeharaiMeisaiTable()
			If Me.CreateUkeMeisaiData(ukeharaiMeisaiTable, item) Then
				Try
					Dim sql As String = Me.CreateInsertSql(ukeharaiMeisaiTable)
					flag = Me.InsertUkeharaiMeisai(sql)
				Catch ex As Exception
					flag = False
				End Try
			End If
			If flag Then
				Me._srOk.WriteLine(lineData)
				Return True
			End If
			lineData += "!"
			Me.WriteUnknownData(lineData, item)
			Return False
		End Function

		Private Function HaraiDataWrite(lineData As String, item As SN41A00, toriTb As DataTable) As Boolean
			Dim text As String = Conversions.ToString(toriTb.Rows(0)("SEIKYU_TYPE"))
			If Operators.CompareString(text, "1", False) = 0 Then
				Dim accept As String = String.Format("{0}{1}{2}", DateAndTime.Now.ToString("yyyy"), item.acceptMMDD.Substring(0, 2), item.acceptMMDD.Substring(2, 2))
				Dim tankaSql As String = Me.GetTankaSql(item.tori_cd, item.buhin_cd, item.saki_cd, accept)
				Dim dbParam As DataTable = Me.GetDbParam(tankaSql)
				If dbParam.Rows.Count < 1 Then
					lineData += "@"
					Me.WriteUnknownData(lineData, item)
					Return False
				End If
				Dim tesu As String = Conversions.ToString(dbParam.Rows(0)("SAGYO"))
				Dim flag As Boolean = False
				Dim ukeharaiMeisaiTable As DataTable = Me.GetUkeharaiMeisaiTable()
				If Me.CreateHaraiMeisaiData(ukeharaiMeisaiTable, item, text, tesu) Then
					Try
						Dim sql As String = Me.CreateInsertSql(ukeharaiMeisaiTable)
						flag = Me.InsertUkeharaiMeisai(sql)
					Catch ex As Exception
						flag = False
					End Try
				End If
				If Not flag Then
					lineData += "!"
					Me.WriteUnknownData(lineData, item)
					Return False
				End If
				Me._srOk.WriteLine(lineData)
			Else
				Dim flag2 As Boolean = False
				Dim ukeharaiMeisaiTable2 As DataTable = Me.GetUkeharaiMeisaiTable()
				If Me.CreateHaraiMeisaiData(ukeharaiMeisaiTable2, item, text, "") Then
					Try
						Dim sql2 As String = Me.CreateInsertSql(ukeharaiMeisaiTable2)
						flag2 = Me.InsertUkeharaiMeisai(sql2)
					Catch ex2 As Exception
						flag2 = False
					End Try
				End If
				If Not flag2 Then
					lineData += "!"
					Me.WriteUnknownData(lineData, item)
					Return False
				End If
				Me._srOk.WriteLine(lineData)
			End If
			Return True
		End Function

		Private Sub WriteUnknownData(lineData As String, item As SN41A00)
			Me._srErr.WriteLine(lineData)
			Dim id As Integer = 6
			Me.SetViewValue(id, item)
		End Sub

		Private Sub CheckUnknownData()
			If IsNothing(Me._viewInfo) Then
				Return
			End If
			If Me._viewInfo.ContainsKey(6) AndAlso Me._viewInfo(6).count > 0 Then
				Return
			End If
			Me.DeleteErrFile()
		End Sub

		Private Sub CheckOkData()
			If IsNothing(Me._viewInfo) Then
				Return
			End If
			Dim flag As Boolean = False
			Dim num As Integer = 1
			Do
				If Me._viewInfo(num).count >= 1 Then
					flag = True
				End If
				num += 1
			Loop While num <= 5
			If Not flag Then
				Me.DeleteOkFile()
			End If
		End Sub

		Private Function GetReceiveData(filePath As String) As String()
			Dim result As String() = Nothing
			If Not BaseOperation.IsFile(filePath) Then
				Return result
			End If
			Return File.ReadAllLines(filePath, Me._enc)
		End Function

		Private Sub DeleteReceiveFile(filePath As String)
			If Not BaseOperation.IsFile(filePath) Then
				Return
			End If
			File.Delete(filePath)
		End Sub

		Private Sub CreateViewInfo()
			If Not IsNothing(Me._viewInfo) Then
				Me._viewInfo.Clear()
				Me._viewInfo = Nothing
			End If
			Me._viewInfo = New Dictionary(Of Integer, viewInfo)()
			Dim viewInfoNum As viewInfoNum = viewInfoNum.Matuyama
			Dim num As Integer = 1
			Do
				Me._viewInfo.Add(CInt(viewInfoNum), New viewInfo())
				num += 1
				viewInfoNum = CType(num, viewInfoNum)
			Loop While viewInfoNum <= viewInfoNum.Sonota
		End Sub

		Public Function GetViewInfo() As Dictionary(Of Integer, viewInfo)
			Return Me._viewInfo
		End Function

		Private Sub SetViewValue(id As Integer, item As SN41A00)
			Me._viewInfo(id).tori_cd = item.tori_cd
			Me._viewInfo(id).buhin_cd = Me.ConvertBuhinCd(item.buhin_cd)
			Dim viewInfo As viewInfo = Me._viewInfo(id)
			viewInfo.kosu += item.kosu
			viewInfo = Me._viewInfo(id)
			viewInfo.money += item.money
			viewInfo = Me._viewInfo(id)
			viewInfo.count += 1
		End Sub

		Private Function SetTotaleViewValue() As Boolean
			Dim count As Integer = Me._viewInfo.Count
			Dim viewInfo As New viewInfo()
			Dim num As Integer = 1
			Dim num2 As Integer = count
			For i As Integer = num To num2
				Dim viewInfo2 As viewInfo = viewInfo
				viewInfo2.kosu += Me._viewInfo(i).kosu
				viewInfo2 = viewInfo
				viewInfo2.money += Me._viewInfo(i).money
				viewInfo2 = viewInfo
				viewInfo2.count += Me._viewInfo(i).count
			Next
			Me._viewInfo.Add(count + 1, viewInfo)
			Return viewInfo.count >= 1
		End Function

		Private Function ConvertBuhinCd(buhin_cd As String) As String
			Dim length As Integer = buhin_cd.Length
			Dim result As String
			If length > 10 Then
				result = String.Format("{0}-{1}-{2}-{3}", New Object() {buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7, 3), buhin_cd.Substring(10)})
			ElseIf length > 7 Then
				result = String.Format("{0}-{1}-{2}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7))
			ElseIf length > 4 Then
				result = String.Format("{0}-{1}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4))
			Else
				result = buhin_cd
			End If
			Return result
		End Function

		Public _configData As XmlConfigControl

		Public _funcName As String

		Public _ukeharaiKubun As String

		Public _fixcount As Integer

		Public _outPutFolder As String

		Public _fixBackCount As Integer

		Public _backUpFolder As String

		Public _okFileName As String

		Public _errFileName As String

		Private _enc As Encoding

		Private _fileformat As String

		Private _now As DateTime

		Private _okfile As String

		Private _srOk As StreamWriter

		Private _errfile As String

		Private _srErr As StreamWriter

		Private _viewInfo As Dictionary(Of Integer, viewInfo)

		Public Class viewInfo

			Public Sub New()
				Me.tori_cd = ""
				Me.buhin_cd = ""
				Me.kosu = 0
				Me.money = 0
				Me.count = 0
			End Sub

			Public tori_cd As String

			Public buhin_cd As String

			Public kosu As Integer

			Public money As Integer

			Public count As Integer
		End Class

		Public Enum viewInfoNum

			Matuyama = 1

			Kumamoto

			Houei

			Koubai

			Buhin

			Sonota

			Totale

			err
		End Enum
	End Class
End Namespace
