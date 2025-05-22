Imports System
Imports System.Collections
Imports System.Data
Imports System.IO
Imports System.Text
Imports DitCore.Classes
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.FileIO

Namespace IbUkeharai.Util

	Public Class CsvCommon
		Implements IDisposable

		Public Sub New()
			Me._srw = Nothing
			Me._textFP = Nothing
			Me.disposedValue = False
		End Sub

		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue AndAlso disposing Then
				If Not IsNothing(Me._srw) Then
					Me._srw.Close()
					Me._srw = Nothing
				End If
				If Not IsNothing(Me._textFP) Then
					Me._textFP.Close()
					Me._textFP = Nothing
				End If
			End If
			Me.disposedValue = True
		End Sub

		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		Public Function CsvDataFieldRead(FileName As String, Delimiter As String, encode As String) As ArrayList
			Dim arrayList As ArrayList = Nothing
			Try
				Me.disposedValue = False
				Me._textFP = New TextFieldParser(FileName, Encoding.GetEncoding(encode))
				Me._textFP.TextFieldType = FieldType.Delimited
				Me._textFP.Delimiters = New String() {Delimiter}
				Me._textFP.HasFieldsEnclosedInQuotes = True
				Me._textFP.TrimWhiteSpace = True
				arrayList = New ArrayList()
				While Not Me._textFP.EndOfData
					arrayList.Add(Me._textFP.ReadFields())
				End While
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CsvDataFieldRead Errer : {0}", ex.Message))
			Finally
				Me.Dispose()
			End Try
			Return arrayList
		End Function

		Public Function ConvertCsvToDataTable(csvPath As String) As DataTable
			Dim dataTable As New DataTable()
			Try
				Dim arrayList As ArrayList = Me.CsvDataFieldRead(csvPath, ",", "Shift_JIS")
				If IsNothing(arrayList) Then
					Return dataTable
				End If
				Dim array As String() = CType(arrayList(0), String())
				For Each columnName As String In array
					dataTable.Columns.Add(columnName, Type.[GetType]("System.String"))
				Next
				Dim num As Integer = 1
				Dim num2 As Integer = arrayList.Count - 1
				For j As Integer = num To num2
					Dim values As String() = CType(arrayList(j), String())
					dataTable.Rows.Add(values)
				Next
				Return dataTable
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("ConvertCsvToDataTable Errer : {0}", ex.Message))
			End Try
			Return dataTable
		End Function

		Public Function AddRowsToCsvData(ByRef tb As DataTable, csvPath As String, Optional csvHeader As Boolean = True) As Boolean
			Dim arrayList As ArrayList = Nothing
			arrayList = Me.CsvDataFieldRead(csvPath, ",", "Shift_JIS")
			If IsNothing(arrayList) Then
				Return False
			End If
			If csvHeader Then
				Dim array As String() = CType(arrayList(0), String())
				Dim num As Integer = 1
				Dim num2 As Integer = arrayList.Count - 1
				For i As Integer = num To num2
					Dim dataRow As DataRow = tb.NewRow()
					Dim array2 As String() = CType(arrayList(i), String())
					Dim num3 As Integer = 0
					Dim num4 As Integer = array.Length - 1
					For j As Integer = num3 To num4
						Try
							dataRow(array(j)) = array2(j)
						Catch ex As Exception
						End Try
					Next
					tb.Rows.Add(dataRow)
				Next
			Else
				Try
					For Each obj As Object In arrayList
						Dim array3 As String() = CType(obj, String())
						If tb.Columns.Count = array3.Length Then
							tb.Rows.Add(array3)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Return True
		End Function

		Public Function ConvertDataTableToCsv(dt As DataTable, csvPath As String, Optional writeHeader As Boolean = True) As Boolean
			Dim result As Boolean = False
			Dim encoding As Encoding = Encoding.GetEncoding("Shift_JIS")
			Try
				Me.disposedValue = False
				Me._srw = New StreamWriter(csvPath, False, encoding)
				Dim count As Integer = dt.Columns.Count
				Dim num As Integer = count - 1
				If writeHeader Then
					Dim num2 As Integer = 0
					Dim num3 As Integer = count - 1
					For i As Integer = num2 To num3
						Dim text As String = dt.Columns(i).Caption
						text = Me.EncloseDoubleQuotesIfNeed(text)
						Me._srw.Write(text)
						If num > i Then
							Me._srw.Write(","c)
						End If
					Next
					Me._srw.Write(vbCrLf)
				End If
				Try
					For Each obj As Object In dt.Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						Dim num4 As Integer = 0
						Dim num5 As Integer = count - 1
						For i As Integer = num4 To num5
							Dim text2 As String = dataRow(i).ToString()
							text2 = Me.EncloseDoubleQuotesIfNeed(text2)
							Me._srw.Write(text2)
							If num > i Then
								Me._srw.Write(","c)
							End If
						Next
						Me._srw.Write(vbCrLf)
					Next
				Finally
					Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				result = True
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("ConvertDataTableToCsv Errer : {0}", ex.Message))
			Finally
				Me.Dispose()
			End Try
			Return result
		End Function

		Private Function EncloseDoubleQuotesIfNeed(field As String) As String
			If Me.NeedEncloseDoubleQuotes(field) Then
				Return Me.EncloseDoubleQuotes(field)
			End If
			Return field
		End Function

		Private Function EncloseDoubleQuotes(field As String) As String
			If field.IndexOf(""""c) > -1 Then
				field = field.Replace("""", """""")
			End If
			Return """" + field + """"
		End Function

		Private Function NeedEncloseDoubleQuotes(field As String) As Boolean
			If field.IndexOf(""""c) <= -1 AndAlso field.IndexOf(","c) <= -1 AndAlso field.IndexOf(vbCr) <= -1 AndAlso field.IndexOf(vbLf) <= -1 Then
				If Not field.StartsWith(" ") Then
					If Not field.StartsWith(vbTab) Then
						If Not field.EndsWith(vbTab) Then
							Return False
						End If
					End If
				End If
			End If
			Return True
		End Function

		Private _srw As StreamWriter

		Private _textFP As TextFieldParser

		Private disposedValue As Boolean
	End Class
End Namespace
