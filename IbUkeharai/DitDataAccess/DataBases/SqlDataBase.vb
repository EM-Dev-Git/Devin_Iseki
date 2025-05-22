Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports DitCore.Classes
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace DitDataAccess.DataBases
	Public Class SqlDataBase
		Implements IDisposable

		Public ReadOnly Property ConnectDB As String
			Get
				Return Me._sConnectDB
			End Get
		End Property

		Public ReadOnly Property Command As SqlCommand
			Get
				Return Me._objCommand
			End Get
		End Property

		Public ReadOnly Property DbData As SqlDataBase.DataInfomation
			Get
				Return Me._DbData
			End Get
		End Property

		Public ReadOnly Property dataBaseInfo As SchemaInfo
			Get
				Return Me._dataBaseInfo
			End Get
		End Property

		Public ReadOnly Property DbDataTable As DataTable
			Get
				Return Me._dbDataTable
			End Get
		End Property

		Public Sub New()
			Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
			Me._dbDataTable = New DataTable()
			Me.ListOfHidden = New List(Of String)()
		End Sub

		Public Sub New(dbinfo As DataBaseInfo)
			Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
			Me._dbDataTable = New DataTable()
			Me.ListOfHidden = New List(Of String)()
			Me.ControlConnect(dbinfo, True)
		End Sub

		Public Sub ControlConnect(dbinfo As DataBaseInfo, bDummy As Boolean)
			Me._sConnectDB = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Connection Timeout={4}", New Object() {dbinfo.ServerName, dbinfo.DBName, dbinfo.UserId, dbinfo.PassWord, 180})
			Me._objConnection = New SqlConnection(Me._sConnectDB)
			Try
				Dim connectionTimeout As Integer = Me._objConnection.ConnectionTimeout
				Me._objConnection.Open()
				Me._objCommand = New SqlCommand()
				Me._objCommand.Connection = Me._objConnection
				Me._objCommand.CommandTimeout = 180
			Catch ex As Exception
				OutputLog.WriteLine("SQL Server Connection Error!! : " + ex.Message)
			End Try
		End Sub

		Public Sub New(objConnection As SqlConnection)
			Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
			Me._dbDataTable = New DataTable()
			Me.ListOfHidden = New List(Of String)()
			Me._objCommand.Connection = objConnection
		End Sub

		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.RollbackTransact()
			Try
				If Me._objTransaction IsNot Nothing Then
					Me._objTransaction.Dispose()
				End If
				If Me._objCommand IsNot Nothing Then
					Me._objCommand.Dispose()
				End If
				If Me._objConnection IsNot Nothing Then
					Me._objConnection.Close()
					Me._objConnection.Dispose()
				End If
				Me._DbData = Nothing
				Me._dbDataTable = Nothing
				Me._dataBaseInfo = Nothing
			Catch ex As Exception
				OutputLog.WriteLine("Rollback Error!! : " + ex.Message)
			End Try
		End Sub

		Public Function BeginTransaction() As Boolean
			Try
				Me._objTransaction = Me._objConnection.BeginTransaction()
				Me._objCommand = Me._objConnection.CreateCommand()
				Me._objCommand.Transaction = Me._objTransaction
			Catch ex As Exception
				OutputLog.WriteLine("BeginTransaction Error!! : {0}", New String() {ex.Message})
				Return False
			End Try
			Return True
		End Function

		Public Function CommitTransact() As Boolean
			Try
				If Me._objTransaction IsNot Nothing AndAlso Me._objTransaction.Connection IsNot Nothing Then
					Me._objTransaction.Commit()
				End If
			Catch ex As Exception
				OutputLog.WriteLine("CommitTransact Error!! : {0}", New String() {ex.Message})
				Return False
			End Try
			Return True
		End Function

		Public Function RollbackTransact() As Boolean
			Try
				If Me._objTransaction IsNot Nothing AndAlso Me._objTransaction.Connection IsNot Nothing Then
					Me._objTransaction.Rollback()
				End If
			Catch ex As Exception
				OutputLog.WriteLine("RollbackTransact Error!! : {0}", New String() {ex.Message})
				Return False
			End Try
			Return True
		End Function

		Public Function ChangeIntDateToStrDate(sDate As String) As String
			Dim result As String = String.Empty
			If String.IsNullOrEmpty(sDate) Then
				Return String.Empty
			End If
			Try
				result = DateTime.Parse(Strings.Format(Conversions.ToInteger(sDate.PadLeft(8, "0"c)), "0000/00/00")).ToString("yyyy/MM/dd")
			Catch ex As Exception
				Return String.Empty
			End Try
			Return result
		End Function

		Public Function ChangeIntTimeToStrTime(sTime As String) As String
			Dim result As String = String.Empty
			If String.IsNullOrEmpty(sTime) Then
				Return String.Empty
			End If
			Try
				result = DateTime.Parse(Strings.Format(Conversions.ToInteger(sTime.PadLeft(6, "0"c)), "00:00:00")).ToString("HH:mm:ss")
			Catch ex As Exception
				Return String.Empty
			End Try
			Return result
		End Function

		Private Function getDataTable(sSQL As String) As String
			Me._dbDataTable.Clear()
			If Me.Command Is Nothing Then
				OutputLog.WriteLine("MyBase.Command Is Nothing")
				Return "MyBase.Command Is Nothing"
			End If
			If String.IsNullOrEmpty(sSQL) Then
				Return "SQL Nothing"
			End If
			Try
				Dim dataSet As New DataSet()
				Dim sqlDataAdapter As New SqlDataAdapter()
				sqlDataAdapter.SelectCommand = New SqlCommand(sSQL, Me._objConnection)
				sqlDataAdapter.SelectCommand.CommandTimeout = 180
				sqlDataAdapter.SelectCommand.CommandType = CommandType.Text
				sqlDataAdapter.Fill(dataSet)
				Me._dbDataTable = dataSet.Tables(0)
				sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
			Catch ex As Exception
				OutputLog.WriteLine("getDataTable Table Error {0} : {1}", New String() {sSQL, ex.Message})
				Return ex.Message
			End Try
			Return String.Empty
		End Function

		Public Function getSQLData(sSQL As String, Optional tbFlg As Boolean = False) As String
			Me._dbDataTable.Clear()
			If Me.Command Is Nothing Then
				OutputLog.WriteLine("MyBase.Command Is Nothing")
				Return "MyBase.Command Is Nothing"
			End If
			If String.IsNullOrEmpty(sSQL) Then
				Return "SQL Nothing"
			End If
			If tbFlg Then
				Return Me.getDataTable(sSQL)
			End If
			Dim command As SqlCommand = Me.Command
			Try
				command.CommandText = Strings.Replace(sSQL.Replace("TOP 1", ""), "SELECT ", "SELECT TOP 50000 ", 1, 1, CompareMethod.Binary)
				command.CommandTimeout = 180
				Using sqlDataReader As SqlDataReader = command.ExecuteReader(CommandBehavior.KeyInfo)
					command.Dispose()
					Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
					Dim schemaTable As DataTable = sqlDataReader.GetSchemaTable()
					Try
						For Each obj As Object In schemaTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim text As String = Conversions.ToString(dataRow("ColumnName"))
							If Not Me._DbData.ItemDetail.ContainsKey(text) Then
								Dim k As Boolean = Conversions.ToBoolean(dataRow("IsKey"))
								Dim type As Type = Type.[GetType](dataRow("DataType").ToString())
								Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow("BaseSchemaName"), "."), dataRow("BaseTableName")))
								text2.TrimEnd(New Char() {"."c})
								Dim hide As Boolean = Me.ListOfHidden.Contains(text) OrElse Conversions.ToBoolean(dataRow("IsHidden"))
								Dim flag As Boolean = Conversions.ToBoolean(dataRow("AllowDBNull"))
								Dim num As Integer
								If type.Equals(GetType(String)) Then
									num = Conversions.ToInteger(dataRow("ColumnSize"))
								Else
									num = Conversions.ToInteger(dataRow("NumericPrecision"))
									If Conversions.ToInteger(dataRow("NumericScale")) > 0 Then
										num += 1
									End If
								End If
								Me._DbData.ItemDetail.Add(text, New ItemInfo(String.Empty, type, num, k, text2, hide))
							End If
						Next
						GoTo IL_2DB
					Finally
						Dim enumerator As IEnumerator = Nothing
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
IL_242:
					Dim dictionary As New Dictionary(Of String, Object)()
					Try
						For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me.DbData.ItemDetail
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader(keyValuePair.Key))) Then
								dictionary.Add(keyValuePair.Key, Nothing)
							Else
								dictionary.Add(keyValuePair.Key, RuntimeHelpers.GetObjectValue(sqlDataReader(keyValuePair.Key)))
							End If
						Next
					Finally
						Dim enumerator2 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
						CType(enumerator2, IDisposable).Dispose()
					End Try
					Me._DbData.DataList.Add(dictionary)
IL_2DB:
					If sqlDataReader.Read() Then
						GoTo IL_242
					End If
				End Using
			Catch ex As Exception
				OutputLog.WriteLine("Select Table Error {0} : {1}", New String() {sSQL, ex.Message})
				Return ex.Message
			End Try
			Return String.Empty
		End Function

		Public Function getStoredProcedureData(sProName As String) As String
			If Me.Command Is Nothing Then
				OutputLog.WriteLine("MyBase.Command Is Nothing")
				Return "MyBase.Command Is Nothing"
			End If
			If String.IsNullOrEmpty(sProName) Then
				Return "Stored Procedure Name Nothing"
			End If
			Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
			Dim command As SqlCommand = Me.Command
			Dim result As String
			Try
				command.CommandType = CommandType.StoredProcedure
				command.CommandText = sProName
				command.CommandTimeout = 180
				command.Parameters.Clear()
				command.ExecuteNonQuery()
				command.Dispose()
				result = String.Empty
			Catch ex As Exception
				OutputLog.WriteLine("Stored Procedure ExecuteNonQuery Error {0} : {1}", New String() {sProName, ex.Message})
				result = ex.Message
			End Try
			Return result
		End Function

		Public Function getStoredProcedureData(sProName As String, listParams As List(Of SqlDataBase.SqlParamInfo), Optional tbFlg As Boolean = True) As String
			If Me.Command Is Nothing Then
				OutputLog.WriteLine("MyBase.Command Is Nothing")
				Return "MyBase.Command Is Nothing"
			End If
			If String.IsNullOrEmpty(sProName) Then
				Return "Stored Procedure Name Nothing"
			End If
			Me._dbDataTable.Clear()
			Me._DbData = New SqlDataBase.DataInfomation(New Dictionary(Of String, ItemInfo)(), New List(Of Dictionary(Of String, Object))())
			Dim command As SqlCommand = Me.Command
			Dim result As String
			Try
				command.CommandType = CommandType.StoredProcedure
				command.CommandText = sProName
				command.CommandTimeout = 180
				command.Parameters.Clear()
				Try
					For Each sqlParamInfo As SqlDataBase.SqlParamInfo In listParams
						Me.Command.Parameters.Add(New SqlParameter(sqlParamInfo.name, sqlParamInfo.type))
						Me.Command.Parameters(sqlParamInfo.name).Value = sqlParamInfo.val
					Next
				Finally
					Dim enumerator As List(Of SqlDataBase.SqlParamInfo).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.Command.CommandTimeout = 300
				Dim sqlDataAdapter As New SqlDataAdapter(command)
				Dim dataSet As New DataSet()
				sqlDataAdapter.Fill(dataSet)
				If tbFlg Then
					Me._dbDataTable = dataSet.Tables(0)
				End If
				command.Dispose()
				result = String.Empty
			Catch ex As Exception
				OutputLog.WriteLine("Stored Procedure ExecuteNonQuery Error {0} : {1}", New String() {sProName, ex.Message})
				result = ex.Message
			End Try
			Return result
		End Function

		Public Function execSql(sSQL As String) As Boolean
			If Me.Command Is Nothing Then
				OutputLog.WriteLine("MyBase.Command Is Nothing")
				Return False
			End If
			If String.IsNullOrEmpty(sSQL) Then
				Return False
			End If
			Dim command As SqlCommand = Me.Command
			Try
				command.CommandText = sSQL
				command.CommandTimeout = 180
				Using command.ExecuteReader(CommandBehavior.KeyInfo)
					command.Dispose()
				End Using
			Catch ex As Exception
				OutputLog.WriteLine("Update/Insert/Delete Table Error {0} : {1}", New String() {sSQL, ex.Message})
				Throw ex
			Finally
				If Not IsNothing(command) Then
					command.Dispose()
				End If
			End Try
			Return True
		End Function

		Private Function StrToInt(str As String) As Integer
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

		Public Function GetItemType(key As String) As Type
			If Me.DbData Is Nothing Then
				Return Nothing
			End If
			If Not Me.DbData.ItemDetail.ContainsKey(key) Then
				Return Nothing
			End If
			Dim itemInfo As ItemInfo = Me.DbData.ItemDetail(key)
			Return itemInfo.type
		End Function

		Private Const MAXRECORD As String = "50000"

		Private Const TIMEOUT_SEC As Integer = 180

		Private Const conConnect As String = "Data Source={0};Database={1};Integrated Security=True"

		Private Const conConnect1 As String = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};Connection Timeout={4}"

		Private _sConnectDB As String

		Private _objConnection As SqlConnection

		Private _objTransaction As SqlTransaction

		Private _objCommand As SqlCommand

		Private _DbData As SqlDataBase.DataInfomation

		Private _dataBaseInfo As SchemaInfo

		Private _dbDataTable As DataTable

		Public ListOfHidden As List(Of String)

		Public Class DataInfomation
			Public Sub New(aItemDetail As Dictionary(Of String, ItemInfo), aDataList As List(Of Dictionary(Of String, Object)))
				Me.ItemDetail = aItemDetail
				Me.DataList = aDataList
			End Sub

			Public ItemDetail As Dictionary(Of String, ItemInfo)

			Public DataList As List(Of Dictionary(Of String, Object))
		End Class

		Public Class SqlParamInfo
			Public Sub New()
				Me.name = Nothing
				Me.type = SqlDbType.BigInt
				Me.val = Nothing
			End Sub

			Public name As String

			Public type As SqlDbType

			Public val As String
		End Class
	End Class
End Namespace
