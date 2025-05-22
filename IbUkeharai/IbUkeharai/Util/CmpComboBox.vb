Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class CmpComboBox
		Inherits ComboBox

		<DebuggerNonUserCode()>
		Public Sub New(container As IContainer)
			Me.New()
			If container IsNot Nothing Then
				container.Add(Me)
			End If
		End Sub

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.EnabledChanged, AddressOf Me.CmpComboBox_EnabledChanged
			AddHandler MyBase.Validated, AddressOf Me.CmpComboBox_Validated
			Me.workText = String.Empty
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.SuspendLayout()
			Me.ImeMode = ImeMode.Disable
			Me.ResumeLayout(False)
		End Sub

		Public Property TableName As String
			Get
				Return Me._tableName
			End Get
			Set(value As String)
				Me._tableName = value
			End Set
		End Property

		Public Property ColumnCode As String
			Get
				Return Me._columnCode
			End Get
			Set(value As String)
				Me._columnCode = value
			End Set
		End Property

		Public Property ColumnName As String
			Get
				Return Me._columnName
			End Get
			Set(value As String)
				Me._columnName = value
			End Set
		End Property

		Public Function SetItemList() As Boolean
			If TopForm.ConfigData Is Nothing Then
				Return False
			End If
			If String.IsNullOrEmpty(Me._tableName) Or String.IsNullOrEmpty(Me._columnName) Then
				Return False
			End If
			Dim text As String = "SELECT " + Me._columnName + " FROM Ukeharai." + Me._tableName
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Me.Items.Clear()
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If Not String.IsNullOrEmpty(sqldata) Then
					OutputLog.WriteLine("Select Table Error {0} : {1}", New String() {text, sqldata})
					Return False
				End If
				Me._itemList = New List(Of ItemInfomation)()
				Try
					For Each dictionary As Dictionary(Of String, Object) In sqlDataBase.DbData.DataList
						If dictionary.ContainsKey(Me._columnCode) Then
							If dictionary.ContainsKey(Me._columnName) Then
								Me._itemList.Add(New ItemInfomation(Conversions.ToString(dictionary(Me._columnCode)), Conversions.ToString(dictionary(Me._columnName))))
							End If
						End If
					Next
				Finally
					Dim enumerator As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.Items.AddRange(Me._itemList.ToArray())
			End Using
			Return True
		End Function

		Public Function SetToriItemList() As Boolean
			Dim itemList As String = "SELECT '' AS TORI_CD, '' AS TORI_NAME UNION ALL SELECT '全メーカー' AS TORI_CD, '全メーカー' AS TORI_NAME UNION ALL SELECT TORI_CD, TORI_NAME FROM [Ukeharai].[M_TORI] WHERE TORI_CD <> ''"
			Return Me.SetItemList(itemList)
		End Function

		Public Function SetItemList(sql As String) As Boolean
			If TopForm.ConfigData Is Nothing Then
				Return False
			End If
			If String.IsNullOrEmpty(Me._tableName) Or String.IsNullOrEmpty(Me._columnName) Then
				Return False
			End If
			If String.IsNullOrEmpty(sql) Then
				Return False
			End If
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = Me.Text
				Me.Items.Clear()
				Dim sqldata As String = sqlDataBase.getSQLData(sql, False)
				If Not String.IsNullOrEmpty(sqldata) Then
					OutputLog.WriteLine("Select Table Error {0} : {1}", New String() {sql, sqldata})
					Return False
				End If
				Me._itemList = New List(Of ItemInfomation)()
				Try
					For Each dictionary As Dictionary(Of String, Object) In sqlDataBase.DbData.DataList
						Dim code As String = If((dictionary.Count >= 1), dictionary.Values.ElementAtOrDefault(0).ToString(), String.Empty)
						Dim name As String = If((dictionary.Count >= 2), dictionary.Values.ElementAtOrDefault(1).ToString(), String.Empty)
						Me._itemList.Add(New ItemInfomation(code, name))
					Next
				Finally
					Dim enumerator As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.Items.AddRange(Me._itemList.ToArray())
				If Me._itemList.Count > 0 Then
					Me.SelectedIndex = 0
				End If
			End Using
			Return True
		End Function

		Private Sub CmpComboBox_EnabledChanged(sender As Object, e As EventArgs)
			If Me.DropDownStyle = ComboBoxStyle.DropDown Then
				Me.DropDownStyle = ComboBoxStyle.DropDownList
			ElseIf Me.DropDownStyle = ComboBoxStyle.DropDownList Then
				Me.DropDownStyle = ComboBoxStyle.DropDown
			End If
		End Sub

		Private Sub CmpComboBox_Validated(sender As Object, e As EventArgs)
			Me.SelectionLength = 0
		End Sub

		Private components As IContainer

		Private _tableName As String

		Private workText As String

		Private _itemList As List(Of ItemInfomation)

		Private _columnCode As String

		Private _columnName As String
	End Class
End Namespace
