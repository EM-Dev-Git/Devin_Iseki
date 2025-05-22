Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class CmpSelectGridView
		Inherits DataGridView

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
			Dim dataGridViewCellStyle As New DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As New DataGridViewCellStyle()
			CType(Me, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.AllowUserToAddRows = False
			Me.AllowUserToDeleteRows = False
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = SystemColors.Control
			dataGridViewCellStyle.Font = New Font("ＭＳ Ｐゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 128)
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.[True]
			Me.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.ColumnHeadersHeight = 28
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = SystemColors.Window
			dataGridViewCellStyle2.Font = New Font("ＭＳ Ｐゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128)
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText
			Dim dataGridViewCellStyle3 As DataGridViewCellStyle = dataGridViewCellStyle2
			Dim padding As New Padding(2)
			dataGridViewCellStyle3.Padding = padding
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.[False]
			Me.DefaultCellStyle = dataGridViewCellStyle2
			Me.ImeMode = ImeMode.Disable
			Me.MultiSelect = False
			Me.[ReadOnly] = True
			Me.RowHeadersVisible = False
			Me.RowTemplate.Height = 25
			Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			CType(Me, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Public Event SendMessage As CmpSelectGridView.SendMessageEventHandler

		Public Sub DisplayRowsCount()
			Dim msg As String = Me.Rows.Count.ToString("#,0") + "行"
			Dim sendMessageEvent As CmpSelectGridView.SendMessageEventHandler = Me.SendMessageEvent
			If sendMessageEvent IsNot Nothing Then
				sendMessageEvent(msg)
			End If
		End Sub

		Public Sub New()
			AddHandler MyBase.CellClick, AddressOf Me.CmpSelectGridView_CellClick
			AddHandler MyBase.CellValueChanged, AddressOf Me.CmpSelectGridView_CellValueChanged
			AddHandler MyBase.MouseDown, AddressOf Me.CmpSelectGridView_MouseDown
			Me.SelectedBackColor = Color.Aquamarine
			Me.NonSelectedBackColor = Color.White
			Me.checkFlg = False
			Me.clickStack = Nothing
			Me.InitializeComponent()
			Me.AllowUserToResizeRows = False
			Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
			Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
			Me.MultiSelect = True
			Me.ShowCellToolTips = False
			Me.EnableHeadersVisualStyles = False
			Me.AllowUserToDeleteRows = False
			Dim typeFromHandle As Type = GetType(DataGridView)
			Dim [property] As PropertyInfo = typeFromHandle.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
			[property].SetValue(Me, True, Nothing)
			Me.clickStack = New List(Of CmpSelectGridView.clickInfo)()
		End Sub

		Private Sub CmpSelectGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If TypeOf dataGridView.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then
				Dim dataGridViewRow As DataGridViewRow = dataGridView.Rows(e.RowIndex)
				Dim dataGridViewCell As DataGridViewCell = dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
				If Operators.ConditionalCompareObjectEqual(dataGridViewCell.Value, True, False) Then
					dataGridViewRow.DefaultCellStyle.BackColor = Me.SelectedBackColor
				Else
					dataGridViewRow.DefaultCellStyle.BackColor = Me.NonSelectedBackColor
				End If
			End If
		End Sub

		Private Sub CmpSelectGridView_MouseDown(sender As Object, e As MouseEventArgs)
			Dim hitTestInfo As DataGridView.HitTestInfo = CType(sender, DataGridView).HitTest(e.X, e.Y)
			If hitTestInfo.ColumnIndex < 0 Or hitTestInfo.RowIndex < 0 Then
				Return
			End If
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If TypeOf dataGridView.Columns(hitTestInfo.ColumnIndex) Is DataGridViewCheckBoxColumn Then
				Me.checkFlg = True
				Me.SetCheckBoxClickInfo(dataGridView, hitTestInfo.RowIndex, hitTestInfo.ColumnIndex)
			End If
		End Sub

		Private Sub CmpSelectGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			If Me.checkFlg Then
				Me.EndEdit()
				Me.checkFlg = False
				Me.SetMultiSelectValue(RuntimeHelpers.GetObjectValue(sender))
			End If
		End Sub

		Private Sub SetCheckBoxClickInfo(dgv As DataGridView, rowIndex As Integer, columnIndex As Integer)
			Dim flag As Boolean = False
			If (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
				flag = True
			End If
			Dim dataGridViewCell As DataGridViewCell = dgv.Rows(rowIndex).Cells(columnIndex)
			Dim value As Boolean = Conversions.ToBoolean(Operators.XorObject(dataGridViewCell.Value, True))
			Dim clickInfo As New CmpSelectGridView.clickInfo()
			clickInfo.iRow = rowIndex
			clickInfo.iColumn = columnIndex
			clickInfo.value = value
			If Not flag Then
				Me.clickStack.Clear()
				Me.clickStack.Add(clickInfo)
			ElseIf Me.clickStack.Count < 1 Then
				Me.clickStack.Add(clickInfo)
			ElseIf Me.clickStack.Last().iRow <> clickInfo.iRow Then
				Me.clickStack.Add(clickInfo)
			End If
		End Sub

		Private Sub SetMultiSelectValue(sender As Object)
			If Me.clickStack.Count < 2 Then
				Return
			End If
			Dim dgv As DataGridView = CType(sender, DataGridView)
			Dim iColumn As Integer = Me.clickStack(0).iColumn
			Dim value As Boolean = Me.clickStack(0).value
			Dim iRow As Integer = Me.clickStack(0).iRow
			Dim iRow2 As Integer = Me.clickStack(1).iRow
			If Me.clickStack.Count = 2 Then
				Dim value2 As Boolean = Me.clickStack(0).value
				Me.MultiSelectBox(dgv, iColumn, value, iRow, iRow2)
			ElseIf Me.clickStack.Count > 2 Then
				Dim val As Boolean = value Xor True
				Me.MultiSelectBox(dgv, iColumn, val, iRow, iRow2)
				iRow = Me.clickStack(0).iRow
				iRow2 = Me.clickStack(2).iRow
				Me.MultiSelectBox(dgv, iColumn, value, iRow, iRow2)
				Me.clickStack.RemoveAt(1)
			End If
		End Sub

		Private Sub MultiSelectBox(dgv As DataGridView, column As Integer, val As Boolean, startRow As Integer, endRow As Integer)
			Dim num As Integer = 1
			Dim num2 As Integer = 0
			If startRow > endRow Then
				Dim num3 As Integer = startRow
				startRow = endRow
				endRow = num3
				Dim num4 As Integer = num
				num = num2
				num2 = num4
			End If
			Dim num5 As Integer = startRow + num
			Dim num6 As Integer = endRow - num2
			For i As Integer = num5 To num6
				Dim dataGridViewRow As DataGridViewRow = dgv.Rows(i)
				Dim dataGridViewCell As DataGridViewCell = dgv.Rows(i).Cells(column)
				dataGridViewCell.Value = val
			Next
		End Sub

		Private components As IContainer

		Private SelectedBackColor As Color

		Private NonSelectedBackColor As Color

		Private checkFlg As Boolean

		Private clickStack As List(Of CmpSelectGridView.clickInfo)

		Public Class clickInfo

			Public Sub New()
				Me.iRow = 0
				Me.iColumn = 0
				Me.value = False
			End Sub

			Public iRow As Integer

			Public iColumn As Integer

			Public value As Boolean
		End Class

		Public Delegate Sub SendMessageEventHandler(msg As String)
	End Class
End Namespace
