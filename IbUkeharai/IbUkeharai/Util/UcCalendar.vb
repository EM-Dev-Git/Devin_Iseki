Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	<DesignerGenerated()>
	Public Class UcCalendar
		Inherits UserControl

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.UcCalendar_Load
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
			Me.components = New Container()
			Me.CheckBox1 = New CheckBox()
			Me.CclDateTimePicker1 = New CclDateTimePicker(Me.components)
			Me.SuspendLayout()
			Me.CheckBox1.AutoSize = True
			Dim checkBox As Control = Me.CheckBox1
			Dim location As Point = New Point(3, 10)
			checkBox.Location = location
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox2 As Control = Me.CheckBox1
			Dim size As Size = New Size(15, 14)
			checkBox2.Size = size
			Me.CheckBox1.TabIndex = 0
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.CclDateTimePicker1.BackColor = SystemColors.Window
			Me.CclDateTimePicker1.BkColor = SystemColors.Window
			Me.CclDateTimePicker1.CustomFormat = "yyyy年M月d日"
			Me.CclDateTimePicker1.Format = DateTimePickerFormat.Custom
			Dim cclDateTimePicker As Control = Me.CclDateTimePicker1
			location = New Point(24, 4)
			cclDateTimePicker.Location = location
			Dim cclDateTimePicker2 As DateTimePicker = Me.CclDateTimePicker1
			Dim dateTime As DateTime = New DateTime(1899, 12, 30, 0, 0, 0, 0)
			cclDateTimePicker2.MinDate = dateTime
			Me.CclDateTimePicker1.Name = "CclDateTimePicker1"
			Dim cclDateTimePicker3 As Control = Me.CclDateTimePicker1
			size = New Size(130, 25)
			cclDateTimePicker3.Size = size
			Me.CclDateTimePicker1.TabIndex = 1
			Dim cclDateTimePicker4 As CclDateTimePicker = Me.CclDateTimePicker1
			dateTime = New DateTime(2015, 5, 15, 10, 41, 20, 698)
			cclDateTimePicker4.Value = dateTime
			Dim autoScaleDimensions As SizeF = New SizeF(7.0F, 18.0F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.CheckBox1)
			Me.Controls.Add(Me.CclDateTimePicker1)
			Me.Font = New Font("ＭＳ Ｐゴシック", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 128)
			Dim margin As Padding = New Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "UcCalendar"
			size = New Size(161, 33)
			Me.Size = size
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Friend Overridable Property CclDateTimePicker1 As CclDateTimePicker
			Get
				Return Me._CclDateTimePicker1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CclDateTimePicker)
				Me._CclDateTimePicker1 = value
			End Set
		End Property

		Friend Overridable Property CheckBox1 As CheckBox
			Get
				Return Me._CheckBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				If Me._CheckBox1 IsNot Nothing Then
					RemoveHandler Me._CheckBox1.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				If Me._CheckBox1 IsNot Nothing Then
					AddHandler Me._CheckBox1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public ReadOnly Property IsChecked As Boolean
			Get
				Return Me.CheckBox1.Checked
			End Get
		End Property

		Public Property MyValue As Object
			Get
				Return Me.CclDateTimePicker1.Value
			End Get
			Set(value As Object)
				Me.CclDateTimePicker1.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		Private Sub ChangeCustomFormat()
			Me.CclDateTimePicker1.Format = DateTimePickerFormat.Custom
			If Me.CheckBox1.Checked Then
				Me.CclDateTimePicker1.CustomFormat = "yyyy年M月d日"
			Else
				Me.CclDateTimePicker1.CustomFormat = "yyyy年M月"
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.CclDateTimePicker1.Value)
			Me.CclDateTimePicker1.Value = Nothing
			Me.CclDateTimePicker1.Value = RuntimeHelpers.GetObjectValue(objectValue)
			Me.CclDateTimePicker1.Refresh()
		End Sub

		Private Sub UcCalendar_Load(sender As Object, e As EventArgs)
			Me.ChangeCustomFormat()
			Me.CclDateTimePicker1.Value = Nothing
		End Sub

		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
			Me.ChangeCustomFormat()
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("CclDateTimePicker1")>
		Private _CclDateTimePicker1 As CclDateTimePicker

		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox
	End Class
End Namespace
