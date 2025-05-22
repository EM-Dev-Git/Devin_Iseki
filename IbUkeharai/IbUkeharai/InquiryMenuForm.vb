Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class InquiryMenuForm
		Inherits BaseMenuForm

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.InquiryMenuForm_Load
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
            Me.TorihikiUkeharaiDailyButton = New Button()
            Me.KeppinBuhinButton = New Button()
            Me.SuspendLayout()
            '
            'TitleLabel
            '
            Me.TitleLabel.BackColor = Color.Teal
            Me.TitleLabel.Text = "問合せメニュー"
            '
            'TorihikiUkeharaiDailyButton
            '
            Me.TorihikiUkeharaiDailyButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikiUkeharaiDailyButton.ForeColor = Color.Black
            Me.TorihikiUkeharaiDailyButton.Location = New Point(45, 90)
            Me.TorihikiUkeharaiDailyButton.Name = "TorihikiUkeharaiDailyButton"
            Me.TorihikiUkeharaiDailyButton.Size = New Size(225, 40)
            Me.TorihikiUkeharaiDailyButton.TabIndex = 1
            Me.TorihikiUkeharaiDailyButton.Text = "21. 受払実績"
            Me.TorihikiUkeharaiDailyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TorihikiUkeharaiDailyButton.UseVisualStyleBackColor = True
            '
            'KeppinBuhinButton
            '
            Me.KeppinBuhinButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.KeppinBuhinButton.ForeColor = Color.Black
            Me.KeppinBuhinButton.Location = New Point(320, 90)
            Me.KeppinBuhinButton.Name = "KeppinBuhinButton"
            Me.KeppinBuhinButton.Size = New Size(225, 40)
            Me.KeppinBuhinButton.TabIndex = 2
            Me.KeppinBuhinButton.Text = "22. 欠品部品情報"
            Me.KeppinBuhinButton.TextAlign = ContentAlignment.MiddleLeft
            Me.KeppinBuhinButton.UseVisualStyleBackColor = True
            '
            'InquiryMenuForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(600, 500)
            Me.Controls.Add(Me.KeppinBuhinButton)
            Me.Controls.Add(Me.TorihikiUkeharaiDailyButton)
            Me.Name = "InquiryMenuForm"
            Me.Text = "InquiryMenuForm"
            Me.TitleColor = Color.Teal
            Me.TitleName = "問合せメニュー"
            Me.Controls.SetChildIndex(Me.TitleLabel, 0)
            Me.Controls.SetChildIndex(Me.TorihikiUkeharaiDailyButton, 0)
            Me.Controls.SetChildIndex(Me.KeppinBuhinButton, 0)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub InquiryMenuForm_Load(sender As Object, e As EventArgs)
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("TorihikiUkeharaiDailyButton")>
        Private WithEvents TorihikiUkeharaiDailyButton As Button

        <AccessedThroughProperty("KeppinBuhinButton")>
        Private WithEvents KeppinBuhinButton As Button

        Private Sub TorihikiUkeharaiDailyButton_Click_1(sender As Object, e As EventArgs) Handles TorihikiUkeharaiDailyButton.Click
            Me._frm = New InquiryUkeharaiZissekiForm()
            Me.formShow()
        End Sub

        Private Sub KeppinBuhinButton_Click_1(sender As Object, e As EventArgs) Handles KeppinBuhinButton.Click
            Me._frm = New InquiryKeppinBuhinForm()
            Me.formShow()
        End Sub
    End Class
End Namespace
