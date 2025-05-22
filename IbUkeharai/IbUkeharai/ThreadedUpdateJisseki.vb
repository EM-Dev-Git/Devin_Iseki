Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	Public Class ThreadedUpdateJisseki

		Public ReadOnly Property IsRunning As Boolean
			Get
				Return Me.thread IsNot Nothing AndAlso Me.thread.IsAlive
			End Get
		End Property

		Public Sub New(d As DateTime)
			Me._execday = Nothing
			Me._conf = Nothing
			Me.thread = Nothing
			Me.cnt = -1
			Me.IsError = False
			Me._execday = d
			Me._conf = TopForm.ConfigData
		End Sub

		Public Sub DoStart()

			Me.thread = New Thread(New ThreadStart(AddressOf Me.ThreadMethod))
			Me.thread.Start()

		End Sub

		Public Sub ThreadAbort()
			If Me.thread IsNot Nothing Then
				Me.thread.Abort()
			End If
		End Sub

		Private Sub ThreadMethod()
			Dim monthDataTable As DataTable = Me.GetMonthDataTable()
			If IsNothing(monthDataTable) Then
				DlgMessageBox.Show("対象の受払実績データが存在しません。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.IsError = True
				Return
			End If
			Me.cnt = 0
			Try
				Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					Try
						For Each obj As Object In monthDataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataRow("取引先コード"))
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(dataRow("部品コード"))
							Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(dataRow("受入数合計"))
							Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(dataRow("払出数合計"))
							Dim text As String = Me._execday.ToShortDateString()
							Dim sSQL As String = String.Format("select UKESU, HARASU from Ukeharai.T_UKEHARAIJISSEKI where TORI_CD='{0}' and BUHIN_CD='{1}' and UKEHARA_YYYYMM='{2}' and (UKESU<>{3} or HARASU<>{4})", New Object() {RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), text, RuntimeHelpers.GetObjectValue(objectValue3), RuntimeHelpers.GetObjectValue(objectValue4)})
							Dim sqldata As String = sqlDataBase.getSQLData(sSQL, True)
							If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
								Dim dbDataTable As DataTable = sqlDataBase.DbDataTable
								If dbDataTable IsNot Nothing AndAlso dbDataTable.Rows.Count = 1 Then
									Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(dbDataTable.Rows(0)(0))
									Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(dbDataTable.Rows(0)(1))
									Dim text2 As String = String.Format("update Ukeharai.T_UKEHARAIJISSEKI set UKESU={0}, HARASU={1} where TORI_CD='{2}' and BUHIN_CD='{3}' and UKEHARA_YYYYMM='{4}'", New Object() {RuntimeHelpers.GetObjectValue(objectValue3), RuntimeHelpers.GetObjectValue(objectValue4), RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), text})
									If Not sqlDataBase.execSql(text2) Then
										Throw New Exception("Error SQL:" + text2)
									End If
									Me.cnt += 1
								End If
							End If
						Next
					Finally
						Dim enumerator As IEnumerator = Nothing
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End Using
			Catch ex As Exception
				Me.IsError = True
				OutputLog.WriteLine(ex.Message)
			End Try
			Console.WriteLine("終了しました。")
		End Sub

		Private Function GetMonthDataTable() As DataTable
			Dim result As DataTable = Nothing
			Dim paramlist As List(Of SqlDataBase.SqlParamInfo) = Me.CreateSelectStoredParam(Me._execday)
			Dim dataTable As DataTable = Me.ExecStoredDbParam(paramlist)
			If dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function CreateSelectStoredParam(execDate As DateTime) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = execDate.ToString("yyyy/MM/dd")}}
		End Function

		Private Function ExecStoredDbParam(paramlist As List(Of SqlDataBase.SqlParamInfo)) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Select_Month_Data", paramlist, True)
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private text As String

		Private _execday As DateTime

		Private _conf As XmlConfigControl

		Private Const SELECT_STORED_NAME As String = "Ukeharai.Select_Month_Data"

		Private thread As Thread

		Public cnt As Integer

		Public IsError As Boolean
	End Class
End Namespace
