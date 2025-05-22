Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class SeikyuMenuForm
		Inherits BaseMenuForm

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.SeikyuMenuForm_Load
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
            Me.ZissekiTableButton = New Button()
            Me.SeikyuButton = New Button()
            Me.SuspendLayout()
            '
            'TitleLabel
            '
            Me.TitleLabel.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TitleLabel.Text = "請求メニュー"
            '
            'ZissekiTableButton
            '
            Me.ZissekiTableButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ZissekiTableButton.ForeColor = Color.Black
            Me.ZissekiTableButton.Location = New Point(45, 90)
            Me.ZissekiTableButton.Name = "ZissekiTableButton"
            Me.ZissekiTableButton.Size = New Size(225, 40)
            Me.ZissekiTableButton.TabIndex = 1
            Me.ZissekiTableButton.Text = "61. 実績内訳表出力"
            Me.ZissekiTableButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ZissekiTableButton.UseVisualStyleBackColor = True
            '
            'SeikyuButton
            '
            Me.SeikyuButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SeikyuButton.ForeColor = Color.Black
            Me.SeikyuButton.Location = New Point(320, 90)
            Me.SeikyuButton.Name = "SeikyuButton"
            Me.SeikyuButton.Size = New Size(225, 40)
            Me.SeikyuButton.TabIndex = 2
            Me.SeikyuButton.Text = "62. 請求書出力"
            Me.SeikyuButton.TextAlign = ContentAlignment.MiddleLeft
            Me.SeikyuButton.UseVisualStyleBackColor = True
            '
            'SeikyuMenuForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(600, 500)
            Me.Controls.Add(Me.SeikyuButton)
            Me.Controls.Add(Me.ZissekiTableButton)
            Me.Name = "SeikyuMenuForm"
            Me.Text = "SeikyuMenuForm"
            Me.TitleColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TitleName = "請求メニュー"
            Me.Controls.SetChildIndex(Me.TitleLabel, 0)
            Me.Controls.SetChildIndex(Me.ZissekiTableButton, 0)
            Me.Controls.SetChildIndex(Me.SeikyuButton, 0)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub SeikyuMenuForm_Load(sender As Object, e As EventArgs)

        End Sub



        Private components As IContainer

        <AccessedThroughProperty("ZissekiTableButton")>
        Private WithEvents ZissekiTableButton As Button

        <AccessedThroughProperty("SeikyuButton")>
        Private WithEvents SeikyuButton As Button

        Private Sub ZissekiTableButton_Click_1(sender As Object, e As EventArgs) Handles ZissekiTableButton.Click
            Me._frm = New OutPutZissekiTableForm()
            Me.formShow()
        End Sub

        Private Sub SeikyuButton_Click_1(sender As Object, e As EventArgs) Handles SeikyuButton.Click
            Me._frm = New OutPutSeikyuForm()
            Me.formShow()
        End Sub
    End Class
End Namespace
