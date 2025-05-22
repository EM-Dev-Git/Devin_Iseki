Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Data
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.InquiryExec

	Public Class KeppinDataWrit

		Public Sub New()
			Me._configData = Nothing
			Me._funcName = Nothing
			Me._outPutFolder = Nothing
			Me._enc = Encoding.GetEncoding("Shift_jis")
			Me._now = Nothing
		End Sub

		Public Function WritBuhinSindoDataExec(sender As Object, path As String, nohinsaki As String) As Boolean
			Dim flag As Boolean = False
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("設定情報に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return flag
			End If
			Try
				Dim receiveData As String() = Me.GetReceiveData(path)
				If IsNothing(receiveData) Then
					Return flag
				End If
				If Not Me.ReceiveBuhinSindoDataRead(RuntimeHelpers.GetObjectValue(sender), receiveData, nohinsaki) Then
					Return False
				End If
				flag = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("WritData Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			Finally
				If flag Then
				End If
			End Try
			Return flag
		End Function

		Public Function WritSisanDataExec(sender As Object, path As String, nohinsaki As String) As Boolean
			Dim flag As Boolean = False
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("設定情報に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return flag
			End If
			Try
				Dim receiveData As String() = Me.GetReceiveData(path)
				If IsNothing(receiveData) Then
					Return flag
				End If
				If Not Me.ReceiveSisanDataRead(RuntimeHelpers.GetObjectValue(sender), receiveData, nohinsaki) Then
					Return False
				End If
				flag = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("WritData Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			Finally
				If flag Then
				End If
			End Try
			Return flag
		End Function

		Public Function WritCyuzanDataExec(sender As Object, path As String, nohinsaki As String) As Boolean
			Dim flag As Boolean = False
			If Not Me.CheckSettingParam() Then
				DlgMessageBox.Show("設定情報に不備が有ります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return flag
			End If
			Try
				Dim receiveData As String() = Me.GetReceiveData(path)
				If IsNothing(receiveData) Then
					Return flag
				End If
				If Not Me.ReceiveCyuzanDataRead(RuntimeHelpers.GetObjectValue(sender), receiveData, nohinsaki) Then
					Return False
				End If
				flag = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("WritData Errer : {0}" & vbCrLf & "path[{1}]", ex.Message, path))
			Finally
				If flag Then
				End If
			End Try
			Return flag
		End Function

		Public Function DeleteUkeharaiKeppin(sql As String) As Boolean
			Dim result As Boolean = False
			If IsNothing(Me._configData) Then
				Return False
			End If
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.execSql(sql)
			End Using
			Return result
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
			Return Not IsNothing(Me._configData) AndAlso Not IsNothing(Me._outPutFolder)
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

		Private Function InsertUkeharaiKeppin(sql As String) As Boolean
			Dim result As Boolean = False
			If IsNothing(Me._configData) Then
				Return False
			End If
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.execSql(sql)
			End Using
			Return result
		End Function

		Private Function GetBuhinSindoTable() As DataTable
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_BUHINSINDO  ", New Object(-1) {}))
			Return Me.GetDbParam(stringBuilder.ToString())
		End Function

		Private Function GetSisanTable() As DataTable
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_SISAN  ", New Object(-1) {}))
			Return Me.GetDbParam(stringBuilder.ToString())
		End Function

		Private Function GetCyuzanTable() As DataTable
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_CYUZAN  ", New Object(-1) {}))
			Return Me.GetDbParam(stringBuilder.ToString())
		End Function

		Private Function CreateBuhinSindoData(tb As DataTable, item As BUHINSINDO) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("NOHINSAKI") = item.nohinsaki_cd
				dataRow("TORI_CD") = item.tori_cd
				dataRow("BUHIN_CD") = item.buhin_cd
				dataRow("PROCESS") = item.process
				dataRow("BUHIN_NAME") = item.buhin_name
				dataRow("SIGN") = item.sign
				dataRow("PRE_KEI") = item.pre_key
				dataRow("1DAY_SIGN") = item.first_sign
				dataRow("1DAY_NUMBER") = item.first_number
				dataRow("2DAY_SIGN") = item.second_sign
				dataRow("2DAY_NUMBER") = item.second_number
				dataRow("3DAY_SIGN") = item.third_sign
				dataRow("3DAY_NUMBER") = item.third_number
				dataRow("4DAY_SIGN") = item.fourth_sign
				dataRow("4DAY_NUMBER") = item.fourth_number
				dataRow("5DAY_SIGN") = item.fifth_sign
				dataRow("5DAY_NUMBER") = item.fifth_number
				dataRow("6DAY_SIGN") = item.sixth_sign
				dataRow("6DAY_NUMBER") = item.sixth_number
				dataRow("7DAY_SIGN") = item.seventh_sign
				dataRow("7DAY_NUMBER") = item.seventh_number
				dataRow("8DAY_SIGN") = item.eighth_sign
				dataRow("8DAY_NUMBER") = item.eighth_number
				dataRow("9DAY_SIGN") = item.ninth_sign
				dataRow("9DAY_NUMBER") = item.ninth_number
				dataRow("10DAY_SIGN") = item.tenth_sign
				dataRow("10DAY_NUMBER") = item.tenth_number
				dataRow("11DAY_SIGN") = item.eleventh_sign
				dataRow("11DAY_NUMBER") = item.eleventh_number
				dataRow("12DAY_SIGN") = item.twelfth_sign
				dataRow("12DAY_NUMBER") = item.twelfth_number
				dataRow("13DAY_SIGN") = item.thirteenth_sign
				dataRow("13DAY_NUMBER") = item.thirteenth_number
				dataRow("14DAY_SIGN") = item.fourteenth_sign
				dataRow("14DAY_NUMBER") = item.fourteenth_number
				dataRow("15DAY_SIGN") = item.fifteenth_sign
				dataRow("15DAY_NUMBER") = item.fifteenth_number
				dataRow("16DAY_SIGN") = item.sixteenth_sign
				dataRow("16DAY_NUMBER") = item.sixteenth_number
				dataRow("17DAY_SIGN") = item.seventeenth_sign
				dataRow("17DAY_NUMBER") = item.seventeenth_number
				dataRow("18DAY_SIGN") = item.eighteenth_sign
				dataRow("18DAY_NUMBER") = item.eighteenth_number
				dataRow("19DAY_SIGN") = item.nineteenth_sign
				dataRow("19DAY_NUMBER") = item.nineteenth_number
				dataRow("20DAY_SIGN") = item.twentieth_sign
				dataRow("20DAY_NUMBER") = item.twentieth_number
				dataRow("21DAY_SIGN") = item.twenty_first_sign
				dataRow("21DAY_NUMBER") = item.twenty_first_number
				dataRow("22DAY_SIGN") = item.twenty_second_sign
				dataRow("22DAY_NUMBER") = item.twenty_second_number
				dataRow("23DAY_SIGN") = item.twenty_third_sign
				dataRow("23DAY_NUMBER") = item.twenty_third_number
				dataRow("24DAY_SIGN") = item.twenty_fourth_sign
				dataRow("24DAY_NUMBER") = item.twenty_fourth_number
				dataRow("25DAY_SIGN") = item.twenty_fifth_sign
				dataRow("25DAY_NUMBER") = item.twenty_fifth_number
				dataRow("26DAY_SIGN") = item.twenty_sixth_sign
				dataRow("26DAY_NUMBER") = item.twenty_sixth_number
				dataRow("27DAY_SIGN") = item.twenty_seventh_sign
				dataRow("27DAY_NUMBER") = item.twenty_seventh_number
				dataRow("28DAY_SIGN") = item.twenty_eighth_sign
				dataRow("28DAY_NUMBER") = item.twenty_eighth_number
				dataRow("29DAY_SIGN") = item.twenty_ninth_sign
				dataRow("29DAY_NUMBER") = item.twenty_ninth_number
				dataRow("30DAY_SIGN") = item.thirtieth_sign
				dataRow("30DAY_NUMBER") = item.thirtieth_number
				dataRow("31DAY_SIGN") = item.thirtieth_first_sign
				dataRow("31DAY_NUMBER") = item.thirtieth_first_number
				dataRow("YYYYMM") = item.yyyymm
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = Me._funcName
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateBuhinSindoData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateSisanData(tb As DataTable, item As SISAN) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("NOHINSAKI") = item.nohinsaki_cd
				dataRow("KBN") = item.kbn
				dataRow("TORI_CD") = item.tori_cd
				dataRow("BUHIN_CD") = item.buhin_cd
				dataRow("PROCESS") = item.process
				dataRow("BUHIN_NAME") = item.buhin_name
				dataRow("TANI") = item.tani
				dataRow("TORI_SHORT") = item.tori_short
				dataRow("YYYYMM") = item.yyyymm
				dataRow("1MONTH_YYYYMM") = item.jan_yyyymm
				dataRow("1MONTH_NUMBER") = item.jan_number
				dataRow("2MONTH_YYYYMM") = item.feb_yyyymm
				dataRow("2MONTH_NUMBER") = item.feb_number
				dataRow("3MONTH_YYYYMM") = item.mar_yyyymm
				dataRow("3MONTH_NUMBER") = item.mar_number
				dataRow("4MONTH_YYYYMM") = item.apr_yyyymm
				dataRow("4MONTH_NUMBER") = item.apr_number
				dataRow("5MONTH_YYYYMM") = item.may_yyyymm
				dataRow("5MONTH_NUMBER") = item.may_number
				dataRow("6MONTH_YYYYMM") = item.jun_yyyymm
				dataRow("6MONTH_NUMBER") = item.jun_number
				dataRow("7MONTH_YYYYMM") = item.jul_yyyymm
				dataRow("7MONTH_NUMBER") = item.jul_number
				dataRow("8MONTH_YYYYMM") = item.aug_yyyymm
				dataRow("8MONTH_NUMBER") = item.aug_number
				dataRow("9MONTH_YYYYMM") = item.sep_yyyymm
				dataRow("9MONTH_NUMBER") = item.sep_number
				dataRow("10MONTH_YYYYMM") = item.oct_yyyymm
				dataRow("10MONTH_NUMBER") = item.oct_number
				dataRow("11MONTH_YYYYMM") = item.nov_yyyymm
				dataRow("11MONTH_NUMBER") = item.nov_number
				dataRow("12MONTH_YYYYMM") = item.dec_yyyymm
				dataRow("12MONTH_NUMBER") = item.dec_number
				dataRow("FACTORY") = item.factory
				dataRow("0000D") = item._0000D
				dataRow("KARIUKE") = item.kariuke
				dataRow("ZENGETU") = item.zengetu
				dataRow("TOTAL") = item.total
				dataRow("CYUZAN") = item.cyuzan
				dataRow("NAIJI") = item.naiji
				dataRow("PROCESS_DAY") = item.process_day
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = Me._funcName
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateSisanData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateCyuzanData(tb As DataTable, item As CYUZAN) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("NOHINSAKI") = item.nohinsaki_cd
				dataRow("BUHIN_CD") = item.buhin_cd
				dataRow("SAISINHENSEN") = item.saisinhensen
				dataRow("PROCESS") = item.process
				dataRow("BUHIN_NAME") = item.buhin_name
				dataRow("HACYU_YYYYMMDD") = item.hacyu_yyyymmdd
				If DateTime.Compare(item.noki_yyyymmdd, DateTime.MinValue) = 0 Then
					dataRow("NOKI_YYYYMMDD") = DBNull.Value
				Else
					dataRow("NOKI_YYYYMMDD") = item.noki_yyyymmdd
				End If
				dataRow("HACYU_NO") = item.hacyu_no
				dataRow("HACYU_FUGO") = item.hacyu_fugo
				dataRow("HACYU_SU") = item.hacyu_su
				dataRow("NONYU_FUGO") = item.nonyu_fugo
				dataRow("NONYU_SU") = item.nonyu_su
				dataRow("CYUZAN_FUGO") = item.cyuzan_fugo
				dataRow("CYUZAN_SU") = item.cyuzan_su
				dataRow("TORI_CD") = item.tori_cd
				dataRow("ORDER_CD") = item.order_cd
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = Me._funcName
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateCyuzanData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateInsertSql(tb As DataTable, header As String) As String
			Dim count As Integer = tb.Columns.Count
			Dim text As String = "("
			Dim text2 As String = "VALUES ("
			Dim dataRow As DataRow = tb.Rows(tb.Rows.Count - 1)
			Dim num As Integer = 0
			Dim num2 As Integer = count - 1
			For i As Integer = num To num2
				Dim text3 As String = tb.Columns(i).Caption
				text3 = "[" + text3 + "]"
				text += text3
				If Not IsNothing(RuntimeHelpers.GetObjectValue(dataRow(i))) Then
					If Me.GetDataType(text3) = 1 Then
						text2 += dataRow(i).ToString()
					ElseIf Me.GetDataType(text3) = 2 And dataRow(i) Is DBNull.Value Then
						text2 += "NULL"
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
			Return header + text + text2
		End Function

		Private Function GetDataType(name As String) As Integer
			Dim pattern As String = ".*_NUMBER"
			Dim result As Integer
			If Regex.IsMatch(name, pattern) Or Regex.IsMatch(name, "PRE_KEI") Then
				result = 1
			ElseIf Operators.CompareString(name, "[FACTORY]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[0000D]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[KARIUKE]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[ZENGETU]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[TOTAL]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[CYUZAN]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[NAIJI]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[HACYU_NO]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[HACYU_SU]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[NONYU_SU]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[CYUZAN_SU]", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "[NOKI_YYYYMMDD]", False) = 0 Then
				result = 2
			Else
				result = 0
			End If
			Return result
		End Function

		Private Function AddFilenameToDatetime(name As String, addDate As DateTime) As String
			Return String.Concat(New String() {name, "-", addDate.ToString("yyyyMMdd"), "-", addDate.ToString("HHmmss")})
		End Function

		Private Function ReceiveBuhinSindoDataRead(sender As Object, datas As String(), nohinsaki As String) As Boolean
			Dim buhinSindoTable As DataTable = Me.GetBuhinSindoTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
				Dim num As Integer = datas.Length
				Dim num2 As Integer = 0
				Dim text As String = Nothing
				If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
					text = "QIG14M92.txt"
				ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
					text = "QIG14K92.txt"
				ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
					text = "QIG14S92.txt"
				End If
				Try
					sqlDataBase.BeginTransaction()
					For Each text2 As String In datas
						num2 += 1
						backgroundWorker.ReportProgress(num2, String.Concat(New String() {text, " ： ", num2.ToString(), " / ", num.ToString(), "  ", (CDbl(num2) / CDbl(num)).ToString("P0")}))
						If text2.Length < 209 Then
							OutputLog.WriteLine(text + "：" + num2.ToString() + "行目のデータ長が不足しています")
							Return False
						End If
						Dim item As New BUHINSINDO(text2, nohinsaki)
						If Not Me.SindoDataWrite(sqlDataBase, buhinSindoTable, text2, item) Then
						End If
					Next
					sqlDataBase.CommitTransact()
				Catch ex As Exception
					OutputLog.WriteLine(String.Format("SQL : {0}", ex.Message))
					Return False
				End Try
			End Using
			Return True
		End Function

		Private Function ReceiveSisanDataRead(sender As Object, datas As String(), nohinsaki As String) As Boolean
			Dim sisanTable As DataTable = Me.GetSisanTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
				Dim num As Integer = datas.Length
				Dim num2 As Integer = 0
				Dim text As String = Nothing
				If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
					text = "QIG14M91.txt"
				ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
					text = "QIG14K91.txt"
				ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
					text = "QIG14S91.txt"
				End If
				Try
					sqlDataBase.BeginTransaction()
					For Each text2 As String In datas
						num2 += 1
						backgroundWorker.ReportProgress(num2, String.Concat(New String() {text, " ： ", num2.ToString(), " / ", num.ToString(), "  ", (CDbl(num2) / CDbl(num)).ToString("P0")}))
						If text2.Length < 273 Then
							OutputLog.WriteLine(text + "：" + num2.ToString() + "行目のデータ長が不足しています")
							Return False
						End If
						Dim item As New SISAN(text2, nohinsaki)
						If Not Me.SisanDataWrite(sqlDataBase, sisanTable, text2, item) Then
						End If
					Next
					sqlDataBase.CommitTransact()
				Catch ex As Exception
					OutputLog.WriteLine(String.Format("SQL : {0}", ex.Message))
					Return False
				End Try
			End Using
			Return True
		End Function

		Private Function ReceiveCyuzanDataRead(sender As Object, datas As String(), nohinsaki As String) As Boolean
			Dim cyuzanTable As DataTable = Me.GetCyuzanTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
				Dim num As Integer = datas.Length
				Dim num2 As Integer = 0
				Dim text As String = Nothing
				If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
					text = "QIG05M91.txt"
				ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
					text = "QIG05K91.txt"
				ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
					text = "QIG05S91.txt"
				End If
				Try
					sqlDataBase.BeginTransaction()
					For Each text2 As String In datas
						num2 += 1
						backgroundWorker.ReportProgress(num2, String.Concat(New String() {text, " ： ", num2.ToString(), " / ", num.ToString(), "  ", (CDbl(num2) / CDbl(num)).ToString("P0")}))
						If text2.Length < 102 Then
							OutputLog.WriteLine(text + "：" + num2.ToString() + "行目のデータ長が不足しています")
							Return False
						End If
						Dim item As New CYUZAN(text2, nohinsaki)
						If Not Me.CyuzanDataWrite(sqlDataBase, cyuzanTable, text2, item) Then
						End If
					Next
					sqlDataBase.CommitTransact()
				Catch ex As Exception
					OutputLog.WriteLine(String.Format("SQL : {0}", ex.Message))
					Return False
				End Try
			End Using
			Return True
		End Function

		Private Function SindoDataWrite(db As SqlDataBase, buinsindoTb As DataTable, lineData As String, item As BUHINSINDO) As Boolean
			Dim result As Boolean = False
			If Me.CreateBuhinSindoData(buinsindoTb, item) Then
				Try
					Dim header As String = "INSERT INTO Ukeharai.T_BUHINSINDO"
					Dim sSQL As String = Me.CreateInsertSql(buinsindoTb, header)
					result = db.execSql(sSQL)
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

		Private Function SisanDataWrite(db As SqlDataBase, siasnTb As DataTable, lineData As String, item As SISAN) As Boolean
			Dim result As Boolean = False
			If Me.CreateSisanData(siasnTb, item) Then
				Try
					Dim header As String = "INSERT INTO Ukeharai.T_SISAN"
					Dim sSQL As String = Me.CreateInsertSql(siasnTb, header)
					result = db.execSql(sSQL)
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

		Private Function CyuzanDataWrite(db As SqlDataBase, cyuzanTb As DataTable, lineData As String, item As CYUZAN) As Boolean
			Dim result As Boolean = False
			If Me.CreateCyuzanData(cyuzanTb, item) Then
				Try
					Dim header As String = "INSERT INTO Ukeharai.T_CYUZAN"
					Dim sSQL As String = Me.CreateInsertSql(cyuzanTb, header)
					result = db.execSql(sSQL)
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

		Private Function GetReceiveData(filePath As String) As String()
			Dim result As String() = Nothing
			If Not BaseOperation2.IsFile(filePath) Then
				Return result
			End If
			Return File.ReadAllLines(filePath, Me._enc)
		End Function

		Private Sub DeleteReceiveFile(filePath As String)
			If Not BaseOperation2.IsFile(filePath) Then
				Return
			End If
			File.Delete(filePath)
		End Sub

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

		Public _outPutFolder As String

		Private _enc As Encoding

		Private _now As DateTime
	End Class
End Namespace
