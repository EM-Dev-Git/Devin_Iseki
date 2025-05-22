Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class BaseMenuForm
		Inherits Form

		Public Sub New()
			Me._titleName = String.Empty
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
			Me.TitleLabel = New Windows.Forms.Label()
			Me.SuspendLayout()
			Me.TitleLabel.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.TitleLabel.BackColor = Color.LemonChiffon
			Me.TitleLabel.Font = New Font("‚l‚r ‚oƒSƒVƒbƒN", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128)
			Me.TitleLabel.ForeColor = Color.Black
			Dim titleLabel As Control = Me.TitleLabel
			Me.TitleLabel.Location = New Point(-2, -1)
			Me.TitleLabel.Name = "TitleLabel"
			Me.TitleLabel.Size = New Size(600, 60)
			Me.TitleLabel.TabIndex = 1
			Me.TitleLabel.Text = "XXXXXXX"
			Me.TitleLabel.TextAlign = ContentAlignment.MiddleCenter
			Dim autoScaleDimensions As New SizeF(6.0F, 12.0F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(600, 400)
			Me.ClientSize = size
			Me.Controls.Add(Me.TitleLabel)
			Me.FormBorderStyle = FormBorderStyle.None
			Me.Name = "BaseMenuForm"
			Me.Text = "BatchMenuForm"
			Me.ResumeLayout(False)
		End Sub

		Public Property TitleName As String
			Get
				Return Me._titleName
			End Get
			Set(value As String)
				Me._titleName = value
				Me.TitleLabel.Text = Me._titleName
			End Set
		End Property

		Public Property TitleColor As Color
			Get
				Return Me._titleColor
			End Get
			Set(value As Color)
				Me._titleColor = value
				Me.TitleLabel.BackColor = Me._titleColor
			End Set
		End Property

		Protected Sub formShow()
			If Me._frm Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			AddHandler Me._frm.FormClosed, AddressOf Me.Form_FormClosed
			Me._frm.Show()
			If Me._frm Is Nothing Then
				Return
			End If
			Me.Owner.Hide()
		End Sub

		Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me._frm = CType(sender, Form)
			Me.Owner.Show()
			Me.Owner.Activate()
			Me._frm = Nothing
		End Sub


		Private components As IContainer

		Public WithEvents TitleLabel As System.Windows.Forms.Label

		Private _titleName As String

		Private _titleColor As Color

		Protected _frm As Form
	End Class
End Namespace
