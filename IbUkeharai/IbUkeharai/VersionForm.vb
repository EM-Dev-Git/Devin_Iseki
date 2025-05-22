Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class VersionForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.VersionForm_Load
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
#Region " フォーム "
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()

            Me.VersionInformation = New System.Windows.Forms.Label()
            Me.Copyright = New System.Windows.Forms.Label()
            Me.Version = New System.Windows.Forms.Label()
            Me.Confirmation = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'VersionInformation
            '
            Me.VersionInformation.AutoSize = True
            Me.VersionInformation.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.VersionInformation.Location = New Point(25, 86)
            Me.VersionInformation.Name = "VersionInformation"
            Me.VersionInformation.Size = New Size(101, 13)
            Me.VersionInformation.TabIndex = 0
            Me.VersionInformation.Text = "Ukeharai System"
            '
            'Copyright
            '
            Me.Copyright.AutoSize = True
            Me.Copyright.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Copyright.Location = New Point(25, 123)
            Me.Copyright.Name = "Copyright"
            Me.Copyright.Size = New Size(481, 13)
            Me.Copyright.TabIndex = 4
            Me.Copyright.Text = "Copyright © 2018 Digital Information Technologies Corporation. All Rights Reserved."
            '
            'Version
            '
            Me.Version.BackColor = Color.CornflowerBlue
            Me.Version.Font = New Font("ＭＳ Ｐゴシック", 21.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Version.ForeColor = SystemColors.ControlLightLight
            Me.Version.Location = New Point(25, 21)
            Me.Version.Name = "Version"
            Me.Version.Size = New Size(545, 51)
            Me.Version.TabIndex = 5
            Me.Version.Text = "Version"
            Me.Version.TextAlign = ContentAlignment.MiddleCenter
            '
            'Confirmation
            '
            Me.Confirmation.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), AnchorStyles)
            Me.Confirmation.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Confirmation.Location = New Point(245, 169)
            Me.Confirmation.Name = "Confirmation"
            Me.Confirmation.Size = New Size(103, 34)
            Me.Confirmation.TabIndex = 6
            Me.Confirmation.Text = "確認"
            Me.Confirmation.UseVisualStyleBackColor = True
            '
            'VersionForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(605, 215)
            Me.Controls.Add(Me.Confirmation)
            Me.Controls.Add(Me.Version)
            Me.Controls.Add(Me.Copyright)
            Me.Controls.Add(Me.VersionInformation)
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "VersionForm"
            Me.Text = "バージョン情報"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private Sub VersionForm_Load(sender As Object, e As EventArgs)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim version As Version = executingAssembly.GetName().Version
            Me.VersionInformation.Text = "Ukeharai System(" + version.ToString() + ")"
        End Sub

        Private Sub Confirmation_Click(sender As Object, e As EventArgs) Handles Confirmation.Click
            Me.Close()
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("VersionInformation")>
        Friend WithEvents VersionInformation As Windows.Forms.Label

        <AccessedThroughProperty("Copyright")>
        Friend WithEvents Copyright As Windows.Forms.Label

        <AccessedThroughProperty("Version")>
        Friend WithEvents Version As Windows.Forms.Label

        <AccessedThroughProperty("Confirmation")>
        Friend WithEvents Confirmation As Button
    End Class
End Namespace
