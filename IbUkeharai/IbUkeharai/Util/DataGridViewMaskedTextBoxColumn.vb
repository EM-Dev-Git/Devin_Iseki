Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace IbUkeharai.Util

	Public Class DataGridViewMaskedTextBoxColumn
		Inherits DataGridViewColumn

		<DebuggerNonUserCode()>
		Public Sub New(container As IContainer)
			Me.New()
			If container IsNot Nothing Then
				container.Add(Me)
			End If
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
			Me.components = New Container()
		End Sub

		Public Sub New()
			MyBase.New(New DataGridViewMaskedTextBoxCell())
			Me.maskValue = ""
		End Sub

		Public Property Mask As String
			Get
				Return Me.maskValue
			End Get
			Set(value As String)
				Me.maskValue = value
			End Set
		End Property

		Public Overrides Function Clone() As Object
			Dim dataGridViewMaskedTextBoxColumn As DataGridViewMaskedTextBoxColumn = CType(MyBase.Clone(), DataGridViewMaskedTextBoxColumn)
			dataGridViewMaskedTextBoxColumn.Mask = Me.Mask
			Return dataGridViewMaskedTextBoxColumn
		End Function

		Public Overrides Property CellTemplate As DataGridViewCell
			Get
				Return MyBase.CellTemplate
			End Get
			Set(value As DataGridViewCell)
				If Not (TypeOf value Is DataGridViewMaskedTextBoxCell) Then
					Throw New InvalidCastException("DataGridViewMaskedTextBoxCellオブジェクトを指定してください。")
				End If
				MyBase.CellTemplate = value
			End Set
		End Property

		Private components As IContainer

		Private maskValue As String
	End Class
End Namespace
