Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DitCore.Dialogs
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class ExcelCommon
		Public Sub New()
			Me._excelApp = Nothing
			Me._workBook = Nothing
			Me._sheets = Nothing
			Me._wksheet = Nothing
			Try
				Dim clsid As New Guid("00024500-0000-0000-C000-000000000046")
				Me._excelApp = CType(Activator.CreateInstance(Type.GetTypeFromCLSID(clsid)), Microsoft.Office.Interop.Excel.Application)
			Catch ex As Exception
				DlgMessageBox.Show("Excelの生成に失敗しました。" & vbCrLf & "Excelがインストールされているか確認してください。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		Public Function FileOpen(excelPath As String) As Boolean
			Try
				Me._workBook = Me._excelApp.Workbooks.Open(excelPath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value)
			Catch ex As Exception
				DlgMessageBox.Show("Excelを開くことができませんでした。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Public Sub SaveExcel(Optional fileName As String = "")
			If fileName.Length < 1 Then
				Me._workBook.Save()
			Else
				Me._workBook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value)
			End If
		End Sub

		Public Sub CloseExcel()
			If Not IsNothing(Me._wksheet) Then
				Marshal.FinalReleaseComObject(Me._wksheet)
				Me._wksheet = Nothing
			End If
			If Not IsNothing(Me._sheets) Then
				Marshal.FinalReleaseComObject(Me._sheets)
				Me._sheets = Nothing
			End If
			If Not IsNothing(Me._workBook) Then
				Marshal.FinalReleaseComObject(Me._workBook)
				Me._workBook = Nothing
			End If
			If Not IsNothing(Me._excelApp) Then
				Me._excelApp.Quit()
				Marshal.FinalReleaseComObject(Me._excelApp)
				Me._excelApp = Nothing
			End If
		End Sub

		Public Function CopyExcelSheet(index As Integer, addIndex As Integer, Optional sheeName As String = "") As Boolean
			Dim count As Integer = Me._workBook.Sheets.Count
			If count < index Or count < addIndex Then
				DlgMessageBox.Show(String.Concat(New String() {"ExcelSheetをコピーすることができません。" & vbCrLf & "シート数：", Conversions.ToString(count), vbCrLf & "シート番号：", Conversions.ToString(index), vbCrLf & "追加シート位置番号：", Conversions.ToString(addIndex)}), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Dim flag As Boolean = False
			If sheeName.Length > 0 Then
				flag = True
				Try
					For Each obj As Object In Me._workBook.Sheets
						Dim worksheet As Worksheet = CType(obj, Worksheet)
						If Operators.CompareString(worksheet.Name, sheeName, False) = 0 Then
							flag = False
							DlgMessageBox.Show("同一のシート名が存在する為、コピー元のシート名を使用します。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Try
				Me.SetWorkSheet(index).Copy(Missing.Value, RuntimeHelpers.GetObjectValue(Me._workBook.Sheets(addIndex)))
				If flag Then
					' The following expression was wrapped in a checked-expression
					Me.SetWorkSheet(addIndex + 1).Name = sheeName
				End If
			Catch ex As Exception
				DlgMessageBox.Show("ExcelSheetのコピーに失敗しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Public Function GetExcelSheet(excelPath As String, Optional ByRef sheetName As String = "") As Worksheet
			' The following expression was wrapped in a checked-statement
			If Me.FileOpen(excelPath) Then
				If sheetName.Length > 0 Then
					Me._sheets = Me._workBook.Worksheets
					Dim num As Integer = 1
					Dim count As Integer = Me._sheets.Count
					For i As Integer = num To count
						Dim worksheet As Worksheet = CType(Me._sheets(i), Worksheet)
						If Operators.CompareString(worksheet.Name, sheetName, False) = 0 Then
							Me._wksheet = worksheet
							Exit For
						End If
					Next
					If Not IsNothing(Me._wksheet) Then
						DlgMessageBox.Show("Excelのシートが見つかりません。" & vbCrLf & "シート名：" + sheetName, "成功", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				Else
					Me._wksheet = CType(Me._workBook.Sheets(1), Worksheet)
				End If
			End If
			Return Me._wksheet
		End Function

		Public Function SetWorkSheet(index As Integer) As Worksheet
			Me._wksheet = Nothing
			If Me._workBook.Sheets.Count < index Then
				DlgMessageBox.Show("Excelのシートが見つかりません。" & vbCrLf & "シート番号：" + Conversions.ToString(index), "成功", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				Me._wksheet = CType(Me._workBook.Sheets(index), Worksheet)
			End If
			Return Me._wksheet
		End Function

		Public Function SetWorkSheet(sheetName As String) As Worksheet
			Me._wksheet = Nothing
			Try
				For Each obj As Object In Me._workBook.Sheets
					Dim worksheet As Worksheet = CType(obj, Worksheet)
					If Operators.CompareString(sheetName, worksheet.Name, False) = 0 Then
						Me._wksheet = worksheet
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If IsNothing(Me._wksheet) Then
				DlgMessageBox.Show("Excelのシートが見つかりません。" & vbCrLf & "シート名：" + sheetName, "成功", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			Return Me._wksheet
		End Function

		Public Function GetLastRow() As Integer
			Return Me._wksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Missing.Value).Row
		End Function

		Public Function GetDataRow() As Integer
			' The following expression was wrapped in a checked-expression
			Return Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(Me._wksheet.Cells(Me.GetLastRow() + 1, 2), Nothing, "End", New Object() {XlDirection.xlUp}, Nothing, Nothing, Nothing), Nothing, "Row", New Object(-1) {}, Nothing, Nothing, Nothing))
		End Function

		Public Function DeleteRows(sheetIndex As Integer) As Boolean
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return False
			End If
			Dim num As Integer = Me.GetDataRow() + 1
			Dim lastRow As Integer = Me.GetLastRow()
			Try
				Dim rowIndex As String = String.Format("{0}:{1}", num, lastRow)
				NewLateBinding.LateCall(Me._wksheet.Rows(rowIndex, Missing.Value), Nothing, "Delete", New Object(-1) {}, Nothing, Nothing, Nothing, True)
			Catch ex As Exception
				DlgMessageBox.Show("行の削除に失敗しました。" & vbCrLf + ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Public Function DeleteRows(sheetIndex As Integer, startRow As Integer, endRow As Integer) As Boolean
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return False
			End If
			If startRow < 1 Or endRow < 1 Then
				Return False
			End If
			Try
				Dim rowIndex As String = String.Format("{0}:{1}", startRow, endRow)
				NewLateBinding.LateCall(Me._wksheet.Rows(rowIndex, Missing.Value), Nothing, "Delete", New Object(-1) {}, Nothing, Nothing, Nothing, True)
			Catch ex As Exception
				DlgMessageBox.Show("行の削除に失敗しました。" & vbCrLf + ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Public Function GetNameRange(rangeName As String) As Range
			Dim result As Range = Nothing
			Try
				For Each obj As Object In Me._wksheet.Names
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
					Dim text As String = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing))
					If text.Contains(rangeName) Then
						result = Me._wksheet.Range(rangeName, Missing.Value)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return result
		End Function

		Public Function GetNameRange(name As String, sheetIndex As Integer, inputIndex As Integer) As Range
			Dim result As Range = Nothing
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return result
			End If
			Dim nameRange As Range = Me.GetNameRange(name)
			If IsNothing(nameRange) Then
				Return result
			End If
			Dim cells As Range = nameRange.Cells
			Dim row As Integer = cells.Row
			Dim column As Integer = cells.Column
			Dim num As Integer = cells.Row + (cells.Rows.Count - 1)
			Dim num2 As Integer = cells.Column + (cells.Columns.Count - 1)
			If IsNothing(Me.SetWorkSheet(inputIndex)) Then
				Return result
			End If
			Dim cell As Range = CType(Me._wksheet.Cells(row, column), Range)
			Dim cell2 As Range = CType(Me._wksheet.Cells(num, num2), Range)
			Return Me._wksheet.Range(cell, cell2)
		End Function

		Public Function SetNameParam(name As String, value As String) As Boolean
			Dim nameRange As Range = Me.GetNameRange(name)
			If IsNothing(nameRange) Then
				Return False
			End If
			nameRange.Value2 = value
			Return True
		End Function

		Public Function SetNameParam(name As String, value As Integer) As Boolean
			Dim nameRange As Range = Me.GetNameRange(name)
			If IsNothing(nameRange) Then
				Return False
			End If
			nameRange.Value2 = value
			Return True
		End Function

		Public Function CopyNameArea(name As String, sheetIndex As Integer, copyIndex As Integer) As Boolean
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return False
			End If
			Dim nameRange As Range = Me.GetNameRange(name)
			If IsNothing(nameRange) Then
				Return False
			End If
			Dim row As Integer = nameRange.Cells.Row
			Dim column As Integer = nameRange.Cells.Column
			If IsNothing(Me.SetWorkSheet(copyIndex)) Then
				Return False
			End If
			nameRange.Copy(RuntimeHelpers.GetObjectValue(Me._wksheet.Cells(row, column)))
			Return True
		End Function

		Public Function GetItemColumn(itemName As String, Optional sheetIndex As Integer = 1) As Integer
			Dim result As Integer = 0
			Me.SetWorkSheet(sheetIndex)
			Dim nameRange As Range = Me.GetNameRange("項目エリア")
			If IsNothing(nameRange) Then
				Return result
			End If
			Dim array As Object(,) = CType(nameRange.Value(Missing.Value), Object(,))
			Dim num As Integer = 1
			Dim count As Integer = nameRange.Columns.Count
			For i As Integer = num To count
				If Not IsNothing(RuntimeHelpers.GetObjectValue(array(1, i))) Then
					Dim left As String = array(1, i).ToString()
					If Operators.CompareString(left, itemName, False) = 0 Then
						result = i
						Exit For
					End If
				End If
			Next
			Return result
		End Function

		Public Function GetAllItemColumn(name As String, Optional sheetIndex As Integer = 1) As Dictionary(Of String, Integer)
			Dim dictionary As New Dictionary(Of String, Integer)()
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return dictionary
			End If
			Dim nameRange As Range = Me.GetNameRange(name)
			If IsNothing(nameRange) Then
				Return dictionary
			End If
			Dim array As Object(,) = CType(nameRange.Value(Missing.Value), Object(,))
			Dim num As Integer = 1
			Dim count As Integer = nameRange.Rows.Count
			For i As Integer = num To count
				Dim str As String = ""
				Dim num2 As Integer = 1
				Dim count2 As Integer = nameRange.Columns.Count
				For j As Integer = num2 To count2
					If Not IsNothing(RuntimeHelpers.GetObjectValue(array(i, j))) Then
						If i = 1 Then
							dictionary.Add(Conversions.ToString(array(i, j)), j)
						Else
							Try
								For Each keyValuePair As KeyValuePair(Of String, Integer) In dictionary
									If keyValuePair.Value = j Then
										str = keyValuePair.Key
									End If
								Next
							Finally
								Dim enumerator As Dictionary(Of String, Integer).Enumerator = Nothing
								CType(enumerator, IDisposable).Dispose()
							End Try
							dictionary.Add(Conversions.ToString(Operators.ConcatenateObject(str + ".", array(i, j))), j)
						End If
					End If
				Next
			Next
			Return dictionary
		End Function

		Public Sub SetTempParm(item As Dictionary(Of String, String), Optional sheetIndex As Integer = 1)
			If IsNothing(Me.SetWorkSheet(sheetIndex)) Then
				Return
			End If
			Try
				For Each text As String In item.Keys
					If Not Me.SetNameParam(text, item(text)) Then
						DlgMessageBox.Show("値の設定に失敗しました" & vbCrLf & "名前定義：" + text + vbCrLf & "設定値：" + item(text), "成功", MessageBoxButtons.OK, MessageBoxIcon.None)
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		Private _excelApp As Microsoft.Office.Interop.Excel.Application

		Private _workBook As Workbook

		Private _sheets As Sheets

		Private _wksheet As Worksheet
	End Class
End Namespace
