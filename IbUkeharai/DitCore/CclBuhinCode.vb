Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace DitCore

	<DesignerGenerated()>
	Public Class CclBuhinCode
		Inherits MaskedTextBox

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

		Public ReadOnly Property Value As String
			Get
				Return MyBase.Text.Replace("-", "").TrimEnd(New Char(-1) {})
			End Get
		End Property

		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
		End Sub

		Public Sub New()
			Me.InitializeComponent()
			Me.Mask = "aaaa-aaa-aaa-aa"
			Me.Font = New Font("ＭＳ Ｐゴシック", 9.0F)
		End Sub

		Private components As IContainer
	End Class
End Namespace
