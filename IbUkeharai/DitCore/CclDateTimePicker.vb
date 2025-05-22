Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic

Namespace DitCore

	Public Class CclDateTimePicker
		Inherits DateTimePicker

		<DebuggerNonUserCode()>
		Public Sub New(container As IContainer)
			Me.New()
			If container IsNot Nothing Then
				container.Add(Me)
			End If
		End Sub

		Public Property BkColor As Color
			Get
				Return Me.BackColor
			End Get
			Set(value As Color)
				Me.BackColor = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.KeyPress, AddressOf Me.DateTimePicker1_KeyPress
			AddHandler MyBase.CloseUp, AddressOf Me.CclDateTimePicker_CloseUp
			Me._format = DateTimePickerFormat.Custom
			Me.WM_PAINT = 15
			Me.Timer1 = New System.Windows.Forms.Timer()
			Me.InitializeComponent()
			MyBase.Format = DateTimePickerFormat.Custom
			Me.NullValue = " "
			Me.Format = DateTimePickerFormat.Custom
			Me.Timer1.Interval = 100
			Me.Timer1.Start()
		End Sub
		Public Overloads Property Value As Object
			Get
				If Me._isNull Then
					Return Nothing
				End If
				Return MyBase.Value
			End Get
			Set(value As Object)
				If String.IsNullOrEmpty(Conversions.ToString(value)) OrElse value Is DBNull.Value Then
					Me.SetToNullValue()
				Else
					Try
						Me.SetToDateTimeValue()
						MyBase.Value = DateTime.Parse(Conversions.ToString(value))
					Catch ex As Exception
						Dim empty As String = String.Empty
					End Try
				End If
			End Set
		End Property

		<Browsable(True)>
		<TypeConverter(GetType([Enum]))>
		<DefaultValue(1)>
		Public Overloads Property Format As DateTimePickerFormat
			Get
				Return Me._format
			End Get
			Set(value As DateTimePickerFormat)
				Me._format = value
				Me.SetFormat()
				Me.OnFormatChanged(EventArgs.Empty)
			End Set
		End Property

		Public Overloads Property CustomFormat As String
			Get
				Return Me._customFormat
			End Get
			Set(value As String)
				Me._customFormat = value
				Me.FormatAsString = Me.CustomFormat
			End Set
		End Property

		<Browsable(True)>
		<DefaultValue(" ")>
		<Description("The string used to display null values in the control")>
		<Category("Behavior")>
		Public Property NullValue As String
			Get
				Return Me._nullValue
			End Get
			Set(value As String)
				Me._nullValue = value
			End Set
		End Property

		Private Property FormatAsString As String
			Get
				Return Me._formatAsString
			End Get
			Set(value As String)
				Me._formatAsString = value
				MyBase.CustomFormat = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Me.SuspendLayout()
			Dim minDate As New DateTime(1899, 12, 30, 0, 0, 0, 0)
			Me.MinDate = minDate
			Me.ResumeLayout(False)
		End Sub

		Private Sub SetToDateTimeValue()
			If Me._isNull Then
				Me.SetFormat()
				Me._isNull = False
				MyBase.OnValueChanged(New EventArgs())
			End If
			Me.OnValueChanged(New EventArgs())
		End Sub

		Private Sub SetToNullValue()
			Me._isNull = True
			MyBase.CustomFormat = If((Me._nullValue Is Nothing OrElse Operators.CompareString(Me._nullValue, String.Empty, False) = 0), " ", ("'" + Me._nullValue + "'"))
		End Sub

		Private Sub SetFormat()
			Dim currentCulture As CultureInfo = Thread.CurrentThread.CurrentCulture
			Dim dateTimeFormat As DateTimeFormatInfo = currentCulture.DateTimeFormat
			Select Case Me._format
				Case DateTimePickerFormat.[Long]
					Me.FormatAsString = dateTimeFormat.LongDatePattern
				Case DateTimePickerFormat.[Short]
					Me.FormatAsString = dateTimeFormat.ShortDatePattern
				Case DateTimePickerFormat.Time
					Me.FormatAsString = dateTimeFormat.ShortTimePattern
				Case DateTimePickerFormat.Custom
					Me.FormatAsString = Me.CustomFormat
			End Select
		End Sub

		<DllImport("user32.dll")>
		Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer

		End Function

		Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs)
			If e.KeyChar = vbCr Or e.KeyChar = vbCr Or e.KeyChar = " "c Then
				CclDateTimePicker.SendMessage(Me.Handle, 260, 40, 0)
			End If
		End Sub

		Protected Overrides Sub OnCloseUp(e As EventArgs)
			If Control.MouseButtons = MouseButtons.None AndAlso Me._isNull Then
				Me.SetToDateTimeValue()
				Me._isNull = False
			End If
			MyBase.OnCloseUp(e)
		End Sub

		Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
			If e.KeyCode = Keys.Delete Then
				Me.Value = Nothing
				Me.OnValueChanged(EventArgs.Empty)
			End If
			MyBase.OnKeyUp(e)
		End Sub

		Private Property Timer1 As System.Windows.Forms.Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing Then
					Me.Timer1.[Stop]()
					Me.Timer1.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		Protected Overrides Sub WndProc(ByRef m As Message)
			Try
				MyBase.WndProc(m)
				If m.Msg = Me.WM_PAINT Then
					Me.Redraw()
				End If
			Catch ex As Exception
				Dim dateTime As DateTime = Conversions.ToDate(Me.Value).AddMonths(-1)
				Me.Value = dateTime
			End Try
		End Sub

		Public Function GetControlImage() As Bitmap
			Dim bitmap As New Bitmap(Me.Width, Me.Height)
			Dim bitmap2 As Bitmap = bitmap
			Dim rectangle As New Rectangle(0, 0, Me.Width, Me.Height)
			Me.DrawToBitmap(bitmap2, rectangle)
			Using graphics As Graphics = Graphics.FromImage(bitmap)
				Dim array As ColorMap() = New ColorMap() {New ColorMap()}
				array(0).OldColor = SystemColors.Window
				array(0).NewColor = Me.BackColor
				Dim imageAttributes As New ImageAttributes()
				imageAttributes.SetRemapTable(array)
				Dim rectangle2 As New Rectangle(0, 0, bitmap.Width, bitmap.Height)
				Dim graphics2 As Graphics = graphics
				Dim image As Image = bitmap
				rectangle = New Rectangle(0, 0, bitmap.Width, bitmap.Height)
				graphics2.DrawImage(image, rectangle, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, imageAttributes)
			End Using
			Return bitmap
		End Function

		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.Redraw()
		End Sub

		Private Sub Redraw()
			Dim border3DSize As Size = SystemInformation.Border3DSize
			Using graphics As Graphics = Me.CreateGraphics()
				Using controlImage As Bitmap = Me.GetControlImage()
					graphics.DrawImage(controlImage, 0 - border3DSize.Width + 2, 0 - border3DSize.Height + 2)
				End Using
			End Using
		End Sub

		Protected Overrides Sub OnPreviewKeyDown(e As PreviewKeyDownEventArgs)
			If "yyyy年M月".Equals(Me.CustomFormat) AndAlso Me.Value IsNot Nothing Then
				Dim dateTime As DateTime = Conversions.ToDate(Me.Value)
				Dim dateTime2 As New DateTime(dateTime.Year, dateTime.Month, 1)
				Me.Value = dateTime2
			End If
			MyBase.OnPreviewKeyDown(e)
		End Sub

		Private Sub CclDateTimePicker_CloseUp(sender As Object, e As EventArgs)
			If "yyyy年M月".Equals(Me.CustomFormat) AndAlso Me.Value IsNot Nothing Then
				Dim dateTime As DateTime = Conversions.ToDate(Me.Value)
				Dim dateTime2 As New DateTime(dateTime.Year, dateTime.Month, 1)
				Me.Value = dateTime2
			End If
		End Sub

		Private components As IContainer

		Private _isNull As Boolean

		Private _nullValue As String

		Private _format As DateTimePickerFormat

		Private _customFormat As String

		Private _formatAsString As String

		Private Const WM_SYSKEYDOWN As Integer = 260

		Private Const VK_DOWN As Integer = 40

		Private WM_PAINT As Integer

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer
	End Class
End Namespace
