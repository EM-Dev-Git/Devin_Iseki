Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class RegisterMenuForm
		Inherits BaseMenuForm

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.RegisterMenu_Load
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
            Me.UkeireZissekiButton = New Button()
            Me.HaraiZIssekiButton = New Button()
            Me.TorihikiMasterButton = New Button()
            Me.BuhinMasterButton = New Button()
            Me.TankaMasterButton = New Button()
            Me.SeikyuMasterButton = New Button()
            Me.NounyuMasterButton = New Button()
            Me.TeisuMasterButton = New Button()
            Me.SuspendLayout()
            '
            'TitleLabel
            '
            Me.TitleLabel.BackColor = Color.GreenYellow
            Me.TitleLabel.Text = "登録メニュー"
            '
            'UkeireZissekiButton
            '
            Me.UkeireZissekiButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.UkeireZissekiButton.ForeColor = Color.Black
            Me.UkeireZissekiButton.Location = New Point(45, 90)
            Me.UkeireZissekiButton.Name = "UkeireZissekiButton"
            Me.UkeireZissekiButton.Size = New Size(225, 40)
            Me.UkeireZissekiButton.TabIndex = 1
            Me.UkeireZissekiButton.Text = "11. 受入実績登録"
            Me.UkeireZissekiButton.TextAlign = ContentAlignment.MiddleLeft
            Me.UkeireZissekiButton.UseVisualStyleBackColor = True
            '
            'HaraiZIssekiButton
            '
            Me.HaraiZIssekiButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.HaraiZIssekiButton.ForeColor = Color.Black
            Me.HaraiZIssekiButton.Location = New Point(45, 155)
            Me.HaraiZIssekiButton.Name = "HaraiZIssekiButton"
            Me.HaraiZIssekiButton.Size = New Size(225, 40)
            Me.HaraiZIssekiButton.TabIndex = 2
            Me.HaraiZIssekiButton.Text = "12. 払出実績登録"
            Me.HaraiZIssekiButton.TextAlign = ContentAlignment.MiddleLeft
            Me.HaraiZIssekiButton.UseVisualStyleBackColor = True
            '
            'TorihikiMasterButton
            '
            Me.TorihikiMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikiMasterButton.ForeColor = Color.Black
            Me.TorihikiMasterButton.Location = New Point(45, 220)
            Me.TorihikiMasterButton.Name = "TorihikiMasterButton"
            Me.TorihikiMasterButton.Size = New Size(225, 40)
            Me.TorihikiMasterButton.TabIndex = 3
            Me.TorihikiMasterButton.Text = "14. 取引先マスター登録"
            Me.TorihikiMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TorihikiMasterButton.UseVisualStyleBackColor = True
            '
            'BuhinMasterButton
            '
            Me.BuhinMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BuhinMasterButton.ForeColor = Color.Black
            Me.BuhinMasterButton.Location = New Point(45, 285)
            Me.BuhinMasterButton.Name = "BuhinMasterButton"
            Me.BuhinMasterButton.Size = New Size(225, 40)
            Me.BuhinMasterButton.TabIndex = 4
            Me.BuhinMasterButton.Text = "15. 部品マスター登録"
            Me.BuhinMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BuhinMasterButton.UseVisualStyleBackColor = True
            '
            'TankaMasterButton
            '
            Me.TankaMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TankaMasterButton.ForeColor = Color.Black
            Me.TankaMasterButton.Location = New Point(320, 90)
            Me.TankaMasterButton.Name = "TankaMasterButton"
            Me.TankaMasterButton.Size = New Size(225, 40)
            Me.TankaMasterButton.TabIndex = 5
            Me.TankaMasterButton.Text = "16. 単価マスター登録"
            Me.TankaMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TankaMasterButton.UseVisualStyleBackColor = True
            '
            'SeikyuMasterButton
            '
            Me.SeikyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SeikyuMasterButton.ForeColor = Color.Black
            Me.SeikyuMasterButton.Location = New Point(320, 155)
            Me.SeikyuMasterButton.Name = "SeikyuMasterButton"
            Me.SeikyuMasterButton.Size = New Size(225, 40)
            Me.SeikyuMasterButton.TabIndex = 6
            Me.SeikyuMasterButton.Text = "17. 請求マスター登録"
            Me.SeikyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.SeikyuMasterButton.UseVisualStyleBackColor = True
            '
            'NounyuMasterButton
            '
            Me.NounyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.NounyuMasterButton.ForeColor = Color.Black
            Me.NounyuMasterButton.Location = New Point(320, 220)
            Me.NounyuMasterButton.Name = "NounyuMasterButton"
            Me.NounyuMasterButton.Size = New Size(225, 40)
            Me.NounyuMasterButton.TabIndex = 7
            Me.NounyuMasterButton.Text = "18. 納入先マスター登録"
            Me.NounyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.NounyuMasterButton.UseVisualStyleBackColor = True
            '
            'TeisuMasterButton
            '
            Me.TeisuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TeisuMasterButton.ForeColor = Color.Black
            Me.TeisuMasterButton.Location = New Point(320, 285)
            Me.TeisuMasterButton.Name = "TeisuMasterButton"
            Me.TeisuMasterButton.Size = New Size(225, 40)
            Me.TeisuMasterButton.TabIndex = 8
            Me.TeisuMasterButton.Text = "19. 定数マスター登録"
            Me.TeisuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TeisuMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterMenuForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(600, 500)
            Me.Controls.Add(Me.TeisuMasterButton)
            Me.Controls.Add(Me.NounyuMasterButton)
            Me.Controls.Add(Me.SeikyuMasterButton)
            Me.Controls.Add(Me.TankaMasterButton)
            Me.Controls.Add(Me.BuhinMasterButton)
            Me.Controls.Add(Me.TorihikiMasterButton)
            Me.Controls.Add(Me.HaraiZIssekiButton)
            Me.Controls.Add(Me.UkeireZissekiButton)
            Me.ForeColor = SystemColors.ControlLight
            Me.Name = "RegisterMenuForm"
            Me.Text = "RegisterMenu"
            Me.TitleColor = Color.GreenYellow
            Me.TitleName = "登録メニュー"
            Me.Controls.SetChildIndex(Me.TitleLabel, 0)
            Me.Controls.SetChildIndex(Me.UkeireZissekiButton, 0)
            Me.Controls.SetChildIndex(Me.HaraiZIssekiButton, 0)
            Me.Controls.SetChildIndex(Me.TorihikiMasterButton, 0)
            Me.Controls.SetChildIndex(Me.BuhinMasterButton, 0)
            Me.Controls.SetChildIndex(Me.TankaMasterButton, 0)
            Me.Controls.SetChildIndex(Me.SeikyuMasterButton, 0)
            Me.Controls.SetChildIndex(Me.NounyuMasterButton, 0)
            Me.Controls.SetChildIndex(Me.TeisuMasterButton, 0)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub RegisterMenu_Load(sender As Object, e As EventArgs)
        End Sub


        Private components As IContainer

        <AccessedThroughProperty("UkeireZissekiButton")>
        Private WithEvents UkeireZissekiButton As Button

        <AccessedThroughProperty("HaraiZIssekiButton")>
        Private WithEvents HaraiZIssekiButton As Button

        <AccessedThroughProperty("TorihikiMasterButton")>
        Private WithEvents TorihikiMasterButton As Button

        <AccessedThroughProperty("BuhinMasterButton")>
        Private WithEvents BuhinMasterButton As Button

        <AccessedThroughProperty("TankaMasterButton")>
        Private WithEvents TankaMasterButton As Button
        <AccessedThroughProperty("SeikyuMasterButton")>
        Private WithEvents SeikyuMasterButton As Button

        <AccessedThroughProperty("NounyuMasterButton")>
        Private WithEvents NounyuMasterButton As Button

        <AccessedThroughProperty("TeisuMasterButton")>
        Private WithEvents TeisuMasterButton As Button

        Private Sub UkeireZissekiButton_Click_1(sender As Object, e As EventArgs) Handles UkeireZissekiButton.Click
            Me._frm = New RegisterUkeireZissekiForm()
            Me.formShow()
        End Sub

        Private Sub HaraiZIssekiButton_Click_1(sender As Object, e As EventArgs) Handles HaraiZIssekiButton.Click
            Me._frm = New RegisterHaraiZIssekiForm()
            Me.formShow()
        End Sub

        Private Sub TorihikiMasterButton_Click_1(sender As Object, e As EventArgs) Handles TorihikiMasterButton.Click
            Me._frm = New RegisterTorihikiMasterForm()
            Me.formShow()
        End Sub

        Private Sub BuhinMasterButton_Click_1(sender As Object, e As EventArgs) Handles BuhinMasterButton.Click
            Me._frm = New RegisterBuhinMasterForm()
            Me.formShow()
        End Sub

        Private Sub TankaMasterButton_Click_1(sender As Object, e As EventArgs) Handles TankaMasterButton.Click
            Me._frm = New RegisterTankaMasterForm()
            Me.formShow()
        End Sub

        Private Sub SeikyuMasterButton_Click_1(sender As Object, e As EventArgs) Handles SeikyuMasterButton.Click
            Me._frm = New RegisterSeikyuMasterForm()
            Me.formShow()
        End Sub

        Private Sub NounyuMasterButton_Click_1(sender As Object, e As EventArgs) Handles NounyuMasterButton.Click
            Me._frm = New RegisterNounyuMasterForm()
            Me.formShow()
        End Sub

        Private Sub TeisuMasterButton_Click_1(sender As Object, e As EventArgs) Handles TeisuMasterButton.Click
            Me._frm = New RegisterJosuMasterForm()
            Me.formShow()
        End Sub
    End Class
End Namespace
