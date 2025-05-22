Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util
	Friend Class CalendarEditingControl
		Inherits DateTimePicker
		Implements IDataGridViewEditingControl

		Public Sub New()
			Me.valueIsChanged = False
			Me.Format = DateTimePickerFormat.[Short]
		End Sub

		Public Sub New(frm As String)
			Me.valueIsChanged = False
			Me.Format = DateTimePickerFormat.Custom
			Me.custom_format = frm
		End Sub

		Public Property EditingControlFormattedValue As Object Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlFormattedValue
			Get
				Return Me.Value.ToShortDateString()
			End Get
			Set(value As Object)
				Try
					Me.Value = DateTime.Parse(Conversions.ToString(value))
				Catch ex As Exception
					Me.Value = DateTime.Now
				End Try
			End Set
		End Property

		Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object Implements System.Windows.Forms.IDataGridViewEditingControl.GetEditingControlFormattedValue
			If Me.Format = DateTimePickerFormat.Custom Then
				Return Me.Value.ToString(Me.CustomFormat)
			End If
			Return Me.Value.ToShortDateString()
		End Function

		Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements System.Windows.Forms.IDataGridViewEditingControl.ApplyCellStyleToEditingControl
			Me.Font = dataGridViewCellStyle.Font
			Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
			Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
		End Sub

		Public Property EditingControlRowIndex As Integer Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlRowIndex
			Get
				Return Me.rowIndexNum
			End Get
			Set(value As Integer)
				Me.rowIndexNum = value
			End Set
		End Property

		Public Function EditingControlWantsInputKey(key As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlWantsInputKey
			Select Case key And Keys.KeyCode
				Case Keys.Prior, Keys.[Next], Keys.[End], Keys.Home, Keys.Left, Keys.Up, Keys.Right, Keys.Down
					Return True
				Case Else
					Return False
			End Select
		End Function

		Public Sub PrepareEditingControlForEdit(selectAll As Boolean) Implements System.Windows.Forms.IDataGridViewEditingControl.PrepareEditingControlForEdit
		End Sub

		Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.RepositionEditingControlOnValueChange
			Get
				Return False
			End Get
		End Property

		Public Property EditingControlDataGridView As DataGridView Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlDataGridView
			Get
				Return Me.dataGridViewControl
			End Get
			Set(value As DataGridView)
				Me.dataGridViewControl = value
			End Set
		End Property

		Public Property EditingControlValueChanged As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlValueChanged
			Get
				Return Me.valueIsChanged
			End Get
			Set(value As Boolean)
				Me.valueIsChanged = value
			End Set
		End Property

		Public ReadOnly Property EditingControlCursor As Cursor Implements System.Windows.Forms.IDataGridViewEditingControl.EditingPanelCursor
			Get
				Return MyBase.Cursor
			End Get
		End Property

		Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
			Me.valueIsChanged = True
			Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
			MyBase.OnValueChanged(eventargs)
		End Sub

		Private dataGridViewControl As DataGridView

		Private valueIsChanged As Boolean

		Private rowIndexNum As Integer

		Private custom_format As String
	End Class
End Namespace
