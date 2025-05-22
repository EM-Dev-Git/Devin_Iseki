Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class Common

		Public Shared Function GetColType(dataBaseInfo As SchemaInfo, tblname As String, colname As String) As Type
			If Not dataBaseInfo.ContainsKey(tblname) Then
				Return Nothing
			End If
			Dim dictionary As Dictionary(Of String, SchemaDetail) = dataBaseInfo(tblname)
			If dictionary.ContainsKey(colname) Then
				Return dictionary(colname).type
			End If
			Return Nothing
		End Function

		Public Shared Function ExecExcelToPDF(excel As String, pdf As String) As Boolean
			Dim result As Boolean = False
			If Not Common.IsDirectory(pdf) Then
				Return result
			End If
			If File.Exists(pdf) Then
				Try
					File.Delete(pdf)
				Catch ex As Exception
					OutputLog.WriteLine(String.Format("PDF File Delete Error : {0}, {1}", pdf, ex.Message))
					Return result
				End Try
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
			NewLateBinding.LateSet(objectValue, Nothing, "DisplayAlerts", New Object() {False}, Nothing, Nothing)
			Try
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim instance As Object = objectValue2
				Dim type As Type = Nothing
				Dim memberName As String = "Open"
				Dim array As Object() = New Object() {excel}
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() {True}
				Dim obj As Object = NewLateBinding.LateGet(instance, type, memberName, arguments, argumentNames, typeArguments, array2)
				If array2(0) Then
					excel = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
				End If
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(obj)
				Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, Nothing, "Sheets", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim instance2 As Object = objectValue3
				Dim type2 As Type = Nothing
				Dim memberName2 As String = "ExportAsFixedFormat"
				Dim array3 As Object() = New Object() {0, pdf, 0, True, False, False}
				Dim arguments2 As Object() = array3
				Dim argumentNames2 As String() = New String() {"Type", "Filename", "Quality", "IncludeDocProperties", "IgnorePrintAreas", "OpenAfterPublish"}
				Dim typeArguments2 As Type() = Nothing
				array2 = New Boolean() {False, True, False, False, False, False}
				NewLateBinding.LateCall(instance2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
				If array2(1) Then
					pdf = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(1)), GetType(String)))
				End If
				NewLateBinding.LateCall(objectValue3, Nothing, "Save", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				If objectValue4 IsNot Nothing Then
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue4))
				End If
				If objectValue3 IsNot Nothing Then
					Try
						NewLateBinding.LateCall(objectValue3, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Finally
						Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue3))
					End Try
				End If
				If objectValue2 IsNot Nothing Then
					Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue2))
				End If
				result = True
			Catch ex2 As Exception
				OutputLog.WriteLine(ex2.Message)
			Finally
				If objectValue IsNot Nothing Then
					Try
						NewLateBinding.LateCall(objectValue, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Finally
						Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue))
					End Try
				End If
			End Try
			Return result
		End Function

		Public Shared Function IsDirectory(fPath As String) As Boolean
			Dim result As Boolean
			Try
				Dim str As String = Path.GetDirectoryName(fPath)
				result = Directory.Exists(str)
			Catch ex As Exception
				OutputLog.WriteLine(ex.Message)
				result = False
			End Try
			Return result
		End Function

		Public Shared Sub PDFDisplay(FilePath As String)
			Dim processStartInfo As New ProcessStartInfo()
			Dim process As New Process()
			Dim arrayList As New ArrayList()
			Try
				Dim processStartInfo2 As ProcessStartInfo = processStartInfo
				processStartInfo2.FileName = FilePath
				processStartInfo2.CreateNoWindow = False
				processStartInfo2.WindowStyle = ProcessWindowStyle.Normal
				process.StartInfo = processStartInfo
				If process.Start() Then
					process.WaitForExit()
				Else
					OutputLog.WriteLine("PDFファイルの起動に失敗しました。")
					DlgMessageBox.Show("起動に失敗しました。", "エラー", MessageBoxButtons.OK)
				End If
			Catch ex As InvalidOperationException
				OutputLog.WriteLine(ex.Message)
				DlgMessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK)
			End Try
		End Sub

		Public Shared Function StrToInt(str As String) As Integer
			Dim result As Integer = 0
			If String.IsNullOrEmpty(str) Then
				Return result
			End If
			Try
				result = Integer.Parse(str)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Shared Function BuhinObjToString(buhincd As Object) As String
			If IsNothing(RuntimeHelpers.GetObjectValue(buhincd)) Then
				Return String.Empty
			End If
			Return buhincd.ToString().Replace("-", "").Trim()
		End Function

		Public Shared Function LenB(stTarget As String) As Integer
			Return Encoding.GetEncoding("Shift_JIS").GetByteCount(stTarget)
		End Function

		Public Shared Function LeftB(value As String, length As Integer) As String
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_JIS")
			Dim bytes As Byte() = encoding.GetBytes(value.PadRight(length))
			Return encoding.GetString(bytes, 0, length)
		End Function

		Public Shared Function MidB(str As String, Start As Integer, Optional Length As Integer = 0) As String
			If Operators.CompareString(str, "", False) = 0 Then
				Return ""
			End If
			Dim num As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(str) - Start + 1
			If Length = 0 OrElse Length > num Then
				Length = num
			End If
			Dim encoding1 As Encoding = Encoding.GetEncoding("Shift-JIS")
			Dim array1 As Byte() = CType(Array.CreateInstance(GetType(Byte), Length), Byte())
			Array.Copy(encoding1.GetBytes(str), Start - 1, array1, 0, Length)
			Dim [string] As String = encoding1.GetString(array1)
			Dim num2 As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount([string]) - Start + 1
			If Strings.Asc(Strings.Right([string], 1)) = 0 Then
				Return [string].Substring(0, [string].Length - 1)
			End If
			If Length = num2 - 1 Then
				Return [string].Substring(0, [string].Length - 1)
			End If
			Return [string]
		End Function

		Public Shared Function compareObjToObj(p1 As Object, p2 As Object) As Boolean
			Return (IsNothing(RuntimeHelpers.GetObjectValue(p1)) AndAlso IsNothing(RuntimeHelpers.GetObjectValue(p2))) OrElse (Not (IsNothing(RuntimeHelpers.GetObjectValue(p1)) Or IsNothing(RuntimeHelpers.GetObjectValue(p2))) AndAlso p1.Equals(RuntimeHelpers.GetObjectValue(p2)))
		End Function

		Public Shared Function EscapeInvalidFileName(fileName As String) As String
			Dim result As String = fileName
			If Not String.IsNullOrEmpty(fileName) Then
				Dim pattern As String = String.Format("[{0}]", Regex.Escape(New String(Path.GetInvalidFileNameChars())))
				result = Regex.Replace(fileName, pattern, "")
			End If
			Return result
		End Function

		Public Shared Function cnvObjToLong(obj As Object) As Long
			Dim result As Long = 0L
			Dim text As String = String.Empty
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				If Not String.IsNullOrEmpty(Conversions.ToString(obj)) Then
					text = obj.ToString()
					text = text.Replace(",", "")
				End If
			End If
			Long.TryParse(text, result)
			Return result
		End Function

		Public Shared Function objToDouble(obj As Object) As Double
			Dim result As Double = 0.0
			Dim text As String = String.Empty
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				If Not String.IsNullOrEmpty(Conversions.ToString(obj)) Then
					text = obj.ToString()
					text = text.Replace(",", "")
				End If
			End If
			Double.TryParse(text, result)
			Return result
		End Function

		Public Shared Function makeConnectionString(conf As XmlConfigControl) As String
			Dim empty As String = String.Empty
			Dim xDataBase As DataBaseInfo = conf.xmlConfData.xDataBase
			Return String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", New Object() {xDataBase.ServerName, xDataBase.DBName, xDataBase.UserId, xDataBase.PassWord})
		End Function

		Public Shared Function hasu(dbl As Double, kind As String) As Long
			' The following expression was wrapped in a checked-statement
			Dim result As Long
			If Operators.CompareString(kind, "1", False) = 0 Then
				result = CLng(Math.Round(Math.Round(dbl, MidpointRounding.AwayFromZero)))
			ElseIf Operators.CompareString(kind, "2", False) = 0 Then
				result = CLng(Math.Round(Math.Floor(dbl)))
			ElseIf Operators.CompareString(kind, "3", False) = 0 Then
				result = CLng(Math.Round(Math.Ceiling(dbl)))
			Else
				result = CLng(Math.Round(Math.Round(dbl, MidpointRounding.AwayFromZero)))
			End If
			Return result
		End Function

		Public Const FontCommon As String = "ＭＳ Ｐゴシック"

		Public Const GRIDVIEW_ERROR_MESSAGE As String = "入力値に誤りがあります！"

		Public Const GRIDVIEW_ERROR_MESSAGE1 As String = "必須項目です。"

		Public Const GRIDVIEW_ERROR_MESSAGE2 As String = "有効日の大小関係が不正です！"

		Public Const DbConnect As String = "Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
	End Class
End Namespace
