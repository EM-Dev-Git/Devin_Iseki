Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security.Permissions
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class CustomDataGridView
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
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'CustomDataGridView
			'
			Me.RowTemplate.Height = 21
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Public Property TableName As String
			Get
				Return Me._tablename
			End Get
			Set(value As String)
				Me._tablename = value
			End Set
		End Property

		Public Property gridInfo As List(Of ControlDataGridView.gridInfomation)
			Get
				Return Me._gridInfo
			End Get
			Set(value As List(Of ControlDataGridView.gridInfomation))
				Me._gridInfo = value
			End Set
		End Property

		Public Property IsRowNoView As Boolean
			Get
				Return Me._rowNoView
			End Get
			Set(value As Boolean)
				Me._rowNoView = value
			End Set
		End Property

		Public Sub Init()
			Me.IsChanged = False
		End Sub

		Private Sub dataGridViewComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim dataGridViewComboBoxEditingControl As DataGridViewComboBoxEditingControl = CType(sender, DataGridViewComboBoxEditingControl)
			If dataGridViewComboBoxEditingControl.SelectedIndex >= 0 Then
				Me.IsChanged = True
			End If
		End Sub

		Public Event SendMessage As CustomDataGridView.SendMessageEventHandler

		Public Sub New()
			AddHandler MyBase.RowPostPaint, AddressOf Me.DataGridView1_RowPostPaint
			AddHandler MyBase.KeyDown, AddressOf Me.MyDataGridView_KeyDown
			AddHandler MyBase.CellEndEdit, AddressOf Me.CustomDataGridView_CellEndEdit
			AddHandler MyBase.CellFormatting, AddressOf Me.CcDataGridView_CellFormatting
			AddHandler MyBase.EditingControlShowing, AddressOf Me.CcDataGridView1_EditingControlShowing
			AddHandler MyBase.CellEnter, AddressOf Me.DataGridView1_CellEnter
			AddHandler MyBase.CellValueChanged, AddressOf Me.DataGridView1_CellValueChanged
			AddHandler MyBase.MouseDown, AddressOf Me.DataGridView1_MouseDown
			AddHandler MyBase.CellClick, AddressOf Me.DataGridView_CheckBoxColumnMouseDown
			Me._tablename = String.Empty
			Me.mouseFlg = False
			Me.checkFlg = False
			Me._rowNoView = False
			Me.ImeModeHiragana = New List(Of String)() From {"TORI_NAME", "BUHIN_NAME", "SAKI_NAME", "SAKI_ABBREVIATION", "UCHIWAKE", "TEKIYO", "TANI", "IKISAKI_CD"}
			Me.ImeModeOff = New List(Of String)() From {"REMARKS1", "REMARKS2", "REMARKS3", "TANA_NO1", "TANA_NO2", "TANA_NO3", "TORIHIN_NO", "KIKAKU", "DEN_NO"}
			Me.IsChanged = False
			Me.dataGridViewComboBox = Nothing
			Me.CellValuePre = Nothing
			Me.CellFmtValuePre = Nothing
			Me.InitializeComponent()
			Me.AllowUserToResizeRows = False
			Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
			Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
			Me.MultiSelect = False
			Me.ShowCellToolTips = False
			Me.EnableHeadersVisualStyles = False
			Me.AllowUserToDeleteRows = False
			Dim typeFromHandle As Type = GetType(DataGridView)
			Dim [property] As PropertyInfo = typeFromHandle.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
			[property].SetValue(Me, True, Nothing)
			Me.RowHeadersWidth = 55
		End Sub

		Private Sub CcDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
			If e.Value Is Nothing Then
				Return
			End If
			Dim name As String = Me.Columns(e.ColumnIndex).Name
			Dim colType As Type = Me.getColType(name)
			If colType Is GetType(Decimal) Then
				Dim num As Decimal = 0D
				Decimal.TryParse(Conversions.ToString(e.Value), num)
				e.Value = num
			ElseIf colType Is GetType(DateTime) Then
				Dim dateTime As DateTime = Nothing
				DateTime.TryParse(Conversions.ToString(e.Value), dateTime)
				e.Value = dateTime
			End If
		End Sub

		Private Sub EditingControl_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = True
			If flag = TypeOf sender Is DataGridViewTextBoxEditingControl Then
				Try
					Dim dataGridViewTextBoxEditingControl As DataGridViewTextBoxEditingControl = CType(sender, DataGridViewTextBoxEditingControl)
					Dim dataGridViewTextBoxCell As DataGridViewTextBoxCell = CType(Me.CurrentCell, DataGridViewTextBoxCell)
					Dim byteCount As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(dataGridViewTextBoxEditingControl.Text)
					If byteCount > dataGridViewTextBoxCell.MaxInputLength Then
						dataGridViewTextBoxEditingControl.Text = Common.MidB(dataGridViewTextBoxEditingControl.Text, 1, dataGridViewTextBoxCell.MaxInputLength)
						dataGridViewTextBoxEditingControl.SelectionStart = dataGridViewTextBoxEditingControl.TextLength
					End If
					Return
				Catch ex As Exception
					Return
				End Try
			End If
			If flag = TypeOf sender Is DataGridViewComboBoxEditingControl Then
			End If
		End Sub

		Private Sub EditingControl_CalendarEnter(sender As Object, e As EventArgs)
			Dim flag As Boolean = True
			If flag = TypeOf sender Is CalendarEditingControl Then
				Try
					Dim calendarEditingControl As CalendarEditingControl = CType(sender, CalendarEditingControl)
					Dim calendarCell As CalendarCell = CType(Me.CurrentCell, CalendarCell)
					If String.IsNullOrEmpty(Conversions.ToString(Me.Rows(calendarCell.RowIndex).Cells(calendarCell.ColumnIndex).Value)) Then
						calendarEditingControl.Value = DateTime.Now
					ElseIf DateTime.Compare(Conversions.ToDate(Me.Rows(calendarCell.RowIndex).Cells(calendarCell.ColumnIndex).Value), calendarEditingControl.Value.[Date]) <> 0 Then
						calendarEditingControl.Value = DateTime.Now
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		Private Sub CcDataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
			If TypeOf e.Control Is DataGridViewTextBoxEditingControl Then
				Dim dataGridView As DataGridView = CType(sender, DataGridView)
				If "IKISAKI_CD".Equals(dataGridView.CurrentCell.OwningColumn.Name) Then
					Return
				End If
				AddHandler Me.EditingControl.TextChanged, AddressOf Me.EditingControl_TextChanged
				Dim dataGridViewTextBoxEditingControl As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
				RemoveHandler dataGridViewTextBoxEditingControl.KeyPress, AddressOf Me.dataGridViewTextBox_KeyPress
				Dim colType As Type = Me.getColType(dataGridView.CurrentCell.OwningColumn.Name)
				If colType Is GetType(Decimal) Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(CType(dataGridView, CustomDataGridView).CellValuePre)
					If objectValue IsNot Nothing Then
						dataGridViewTextBoxEditingControl.Text = objectValue.ToString()
					End If
					AddHandler dataGridViewTextBoxEditingControl.KeyPress, AddressOf Me.dataGridViewTextBox_KeyPress
				End If
			ElseIf TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
				Dim dataGridView2 As DataGridView = CType(sender, DataGridView)
				If Operators.CompareString(dataGridView2.Columns("KUBUN").Name, "KUBUN", False) = 0 Then
					Me.dataGridViewComboBox = CType(e.Control, DataGridViewComboBoxEditingControl)
					AddHandler Me.dataGridViewComboBox.SelectedIndexChanged, AddressOf Me.dataGridViewComboBox_SelectedIndexChanged
				End If
			ElseIf TypeOf e.Control Is CalendarEditingControl Then
				Dim calendarEditingControl As CalendarEditingControl = CType(e.Control, CalendarEditingControl)
				RemoveHandler calendarEditingControl.Enter, AddressOf Me.EditingControl_CalendarEnter
				AddHandler calendarEditingControl.Enter, AddressOf Me.EditingControl_CalendarEnter
			End If
		End Sub

		Private Sub dataGridViewTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
			If e.KeyChar < "0"c Or e.KeyChar > "9"c Then
				e.Handled = True
				If e.KeyChar = "."c Or e.KeyChar = "-"c Or e.KeyChar = vbBack Then
					e.Handled = False
				End If
			End If
		End Sub

		Public Sub UpdateRows()
			Dim msg As String = Me.Rows.Count.ToString("#,0") + "行"
			Dim sendMessageEvent As CustomDataGridView.SendMessageEventHandler = Me.SendMessageEvent
			If sendMessageEvent IsNot Nothing Then
				sendMessageEvent(msg)
			End If
		End Sub

		Public Function UpdateRows(msg As String) As String
			Dim msg2 As String = Me.Rows.Count.ToString("#,0") + "行" + Strings.Space(2) + msg
			Dim sendMessageEvent As CustomDataGridView.SendMessageEventHandler = Me.SendMessageEvent
			If sendMessageEvent IsNot Nothing Then
				sendMessageEvent(msg2)
			End If
			Return msg2
		End Function

		Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			Me.CellValuePre = RuntimeHelpers.GetObjectValue(dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
			Me.CellFmtValuePre = RuntimeHelpers.GetObjectValue(dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).FormattedValue)
			Dim name As String = dataGridView.Columns(e.ColumnIndex).Name
			If Me.ImeModeHiragana.Contains(name) Then
				MyBase.ImeMode = ImeMode.Hiragana
			Else
				MyBase.ImeMode = ImeMode.Disable
			End If
			If Me.ImeModeOff.Contains(name) Then
				MyBase.ImeMode = ImeMode.Off
			End If
			If Me.mouseFlg Then
				Me.mouseFlg = False
				SendKeys.Send("{F4}")
			End If
		End Sub

		Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If IsNothing(RuntimeHelpers.GetObjectValue(Me.CellValuePre)) Then
				If IsNothing(RuntimeHelpers.GetObjectValue(dataGridView.CurrentCell.Value)) Then
					Return
				End If
			ElseIf Me.CellValuePre.Equals(RuntimeHelpers.GetObjectValue(dataGridView.CurrentCell.Value)) Then
				Return
			End If
			If dataGridView.Columns("KUBUN") Is Nothing Then
				Return
			End If
			If Operators.CompareString(dataGridView.Columns("KUBUN").Name, "KUBUN", False) = 0 AndAlso TypeOf dataGridView.Columns("KUBUN") Is DataGridViewComboBoxColumn AndAlso e.ColumnIndex <> dataGridView.Rows(e.RowIndex).Cells("KUBUN").ColumnIndex Then
				Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(dataGridView.Rows(e.RowIndex).Cells("KUBUN"), DataGridViewComboBoxCell)
				Me.IsChanged = True
				If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewComboBoxCell.Value)) Or "".Equals(RuntimeHelpers.GetObjectValue(dataGridViewComboBoxCell.Value)) Then
					dataGridView.Rows(e.RowIndex).Cells("KUBUN").Value = "変更"
				End If
				If Not dataGridView.CurrentCell.[ReadOnly] Then
					dataGridView.CurrentCell.Style.BackColor = Color.PeachPuff
				End If
			End If
		End Sub

		Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs)
			Dim hitTestInfo As DataGridView.HitTestInfo = CType(sender, DataGridView).HitTest(e.X, e.Y)
			Me.Text = hitTestInfo.ColumnIndex.ToString() + " " + hitTestInfo.RowIndex.ToString()
			If hitTestInfo.ColumnIndex < 0 Or hitTestInfo.RowIndex < 0 Then
				Return
			End If
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If TypeOf dataGridView.Columns(hitTestInfo.ColumnIndex) Is DataGridViewComboBoxColumn Then
				Me.mouseFlg = True
			ElseIf TypeOf dataGridView.Columns(hitTestInfo.ColumnIndex) Is DataGridViewCheckBoxColumn Then
				Me.checkFlg = True

			End If
		End Sub

		Private Sub DataGridView_CheckBoxColumnMouseDown(sender As Object, e As DataGridViewCellEventArgs)
			If Me.checkFlg Then
				Me.EndEdit()
				Me.checkFlg = False
			End If
		End Sub

		Private Function getColType(name As String) As Type
			Dim result As Type = Nothing
			If Me._gridInfo Is Nothing Then
				Return result
			End If
			Try
				For Each gridInfomation As ControlDataGridView.gridInfomation In Me._gridInfo
					If name.Equals(gridInfomation.colKeyName) Then
						result = gridInfomation.colType
						Exit For
					End If
				Next
			Finally
				Dim enumerator As List(Of ControlDataGridView.gridInfomation).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return result
		End Function

		<UIPermission(SecurityAction.Demand, Window:=UIPermissionWindow.AllWindows)>
		Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
			If (keyData And Keys.KeyCode) = Keys.[Return] Then
				Return Me.ProcessTabKey(keyData)
			End If
			Return MyBase.ProcessDialogKey(keyData)
		End Function

		<SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
		Protected Overrides Function ProcessDataGridViewKey(e As KeyEventArgs) As Boolean
			If e.KeyCode = Keys.[Return] Then
				Return Me.ProcessTabKey(e.KeyCode)
			End If
			Return MyBase.ProcessDataGridViewKey(e)
		End Function

		Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			If Me.IsRowNoView Then
				Return
			End If
			If dataGridView.RowHeadersVisible Then
				Dim bounds As New Rectangle(e.RowBounds.Left, e.RowBounds.Top, dataGridView.RowHeadersWidth, e.RowBounds.Height)
				bounds.Inflate(-2, -2)
				e.InheritedRowStyle.Font = New Font("ＭＳ Ｐゴシック", 9.5F)
				TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, bounds, e.InheritedRowStyle.ForeColor, TextFormatFlags.Right Or TextFormatFlags.VerticalCenter)
			End If
		End Sub

		Public Event AfterPaste As EventHandler

		Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs)
			If Me.SelectedCells.Count = 1 AndAlso Not Me.SelectedCells(0).[ReadOnly] Then
				If e.KeyCode = Keys.Delete Then
					If Not "KUBUN".Equals(Me.Columns(Me.CurrentCell.ColumnIndex).Name) Then
						Me.SelectedCells(0).Value = Nothing
						Me.OnCellEndEdit(New DataGridViewCellEventArgs(Me.CurrentCell.ColumnIndex, Me.CurrentCell.RowIndex))
						Return
					End If
					If "追加".Equals(RuntimeHelpers.GetObjectValue(Me.Rows(Me.CurrentRow.Index).Cells("KUBUN").Value)) Then
						Me.Rows.RemoveAt(Me.CurrentRow.Index)
						Return
					End If
					Me.Rows(Me.CurrentRow.Index).Cells("KUBUN").Value = "削除"
					Me.IsChanged = True
					Return
				ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
					If "KUBUN".Equals(Me.SelectedCells(0).OwningColumn.Name) Then
						Return
					End If
					Dim text As String = Clipboard.GetText().TrimEnd(New Char(-1) {})
					Dim colType As Type = Me.getColType(Me.SelectedCells(0).OwningColumn.Name)
					If colType Is GetType(Decimal) Then
						Dim num As Decimal = 0D
						If Not Decimal.TryParse(text, num) Then
							Return
						End If
						Me.SelectedCells(0).Value = num
					ElseIf colType Is GetType(DateTime) Then
						Dim dateTime As DateTime = Nothing
						If Not DateTime.TryParse(text, dateTime) Then
							Return
						End If
						Me.SelectedCells(0).Value = dateTime
					Else
						Me.SelectedCells(0).Value = text
					End If
					Dim afterPasteEvent As EventHandler = Me.AfterPasteEvent
					If afterPasteEvent IsNot Nothing Then
						afterPasteEvent(RuntimeHelpers.GetObjectValue(sender), e)
					End If
					Me.OnCellEndEdit(New DataGridViewCellEventArgs(Me.CurrentCell.ColumnIndex, Me.CurrentCell.RowIndex))
				End If
			End If
		End Sub

		Private Sub CustomDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
			If Me.dataGridViewComboBox IsNot Nothing Then
				RemoveHandler Me.dataGridViewComboBox.SelectedIndexChanged, AddressOf Me.dataGridViewComboBox_SelectedIndexChanged
				Me.dataGridViewComboBox = Nothing
			End If
			Dim colType As Type = Me.getColType(Me.CurrentCell.OwningColumn.Name)
			If colType Is GetType(Decimal) Then
				Dim num As Decimal = 0D
				If Decimal.TryParse(Conversions.ToString(Me.CurrentCell.Value), num) Then
					Me.CurrentCell.Value = num
				End If
			ElseIf colType Is GetType(DateTime) Then
				Dim dateTime As DateTime = Nothing
				If DateTime.TryParse(Conversions.ToString(Me.CurrentCell.Value), dateTime) Then
					Me.CurrentCell.Value = dateTime
				End If
			End If
		End Sub

		Private components As IContainer

		Private _tablename As String

		Private _gridInfo As List(Of ControlDataGridView.gridInfomation)

		Private mouseFlg As Boolean

		Private checkFlg As Boolean

		Private _rowNoView As Boolean

		Private ImeModeHiragana As List(Of String)

		Private ImeModeOff As List(Of String)

		Public IsChanged As Boolean

		Private dataGridViewComboBox As DataGridViewComboBoxEditingControl

		Public CellValuePre As Object

		Public CellFmtValuePre As Object

		Public Delegate Sub SendMessageEventHandler(msg As String)
	End Class
End Namespace
