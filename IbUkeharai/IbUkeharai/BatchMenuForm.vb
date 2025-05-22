Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class BatchMenuForm
		Inherits BaseMenuForm


        Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.BatchMenuForm_KeyDown
			AddHandler MyBase.Load, AddressOf Me.BatchMenuForm_Load
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
            Me.UkeireDataWritButton = New System.Windows.Forms.Button()
            Me.HostHaraiDataWritButton = New System.Windows.Forms.Button()
            Me.HaraiDataWritButton = New System.Windows.Forms.Button()
            Me.MonthlyDataButton = New System.Windows.Forms.Button()
            Me.YearlyDataButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'TitleLabel
            '
            Me.TitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TitleLabel.Text = "バッチ処理メニュー"
            '
            'UkeireDataWritButton
            '
            Me.UkeireDataWritButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.UkeireDataWritButton.ForeColor = System.Drawing.Color.Black
            Me.UkeireDataWritButton.Location = New System.Drawing.Point(45, 90)
            Me.UkeireDataWritButton.Name = "UkeireDataWritButton"
            Me.UkeireDataWritButton.Size = New System.Drawing.Size(225, 40)
            Me.UkeireDataWritButton.TabIndex = 1
            Me.UkeireDataWritButton.Text = "40. 受入データ書き込み"
            Me.UkeireDataWritButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.UkeireDataWritButton.UseVisualStyleBackColor = True
            '
            'HostHaraiDataWritButton
            '
            Me.HostHaraiDataWritButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.HostHaraiDataWritButton.ForeColor = System.Drawing.Color.Black
            Me.HostHaraiDataWritButton.Location = New System.Drawing.Point(45, 160)
            Me.HostHaraiDataWritButton.Name = "HostHaraiDataWritButton"
            Me.HostHaraiDataWritButton.Size = New System.Drawing.Size(225, 40)
            Me.HostHaraiDataWritButton.TabIndex = 2
            Me.HostHaraiDataWritButton.Text = "41. 払出データ書き込み（ホスト)"
            Me.HostHaraiDataWritButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.HostHaraiDataWritButton.UseVisualStyleBackColor = True
            '
            'HaraiDataWritButton
            '
            Me.HaraiDataWritButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.HaraiDataWritButton.ForeColor = System.Drawing.Color.Black
            Me.HaraiDataWritButton.Location = New System.Drawing.Point(45, 230)
            Me.HaraiDataWritButton.Name = "HaraiDataWritButton"
            Me.HaraiDataWritButton.Size = New System.Drawing.Size(225, 40)
            Me.HaraiDataWritButton.TabIndex = 5
            Me.HaraiDataWritButton.Text = "45. 払出データ書き込み"
            Me.HaraiDataWritButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.HaraiDataWritButton.UseVisualStyleBackColor = True
            '
            'MonthlyDataButton
            '
            Me.MonthlyDataButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.MonthlyDataButton.ForeColor = System.Drawing.Color.Black
            Me.MonthlyDataButton.Location = New System.Drawing.Point(320, 90)
            Me.MonthlyDataButton.Name = "MonthlyDataButton"
            Me.MonthlyDataButton.Size = New System.Drawing.Size(225, 40)
            Me.MonthlyDataButton.TabIndex = 3
            Me.MonthlyDataButton.Text = "42. 月次データ処理"
            Me.MonthlyDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.MonthlyDataButton.UseVisualStyleBackColor = True
            '
            'YearlyDataButton
            '
            Me.YearlyDataButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.YearlyDataButton.ForeColor = System.Drawing.Color.Black
            Me.YearlyDataButton.Location = New System.Drawing.Point(320, 160)
            Me.YearlyDataButton.Name = "YearlyDataButton"
            Me.YearlyDataButton.Size = New System.Drawing.Size(225, 40)
            Me.YearlyDataButton.TabIndex = 4
            Me.YearlyDataButton.Text = "44. 年次データ処理"
            Me.YearlyDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.YearlyDataButton.UseVisualStyleBackColor = True
            '
            'BatchMenuForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(600, 500)
            Me.Controls.Add(Me.YearlyDataButton)
            Me.Controls.Add(Me.MonthlyDataButton)
            Me.Controls.Add(Me.HaraiDataWritButton)
            Me.Controls.Add(Me.HostHaraiDataWritButton)
            Me.Controls.Add(Me.UkeireDataWritButton)
            Me.Name = "BatchMenuForm"
            Me.TitleColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.TitleName = "バッチ処理メニュー"
            Me.Controls.SetChildIndex(Me.TitleLabel, 0)
            Me.Controls.SetChildIndex(Me.UkeireDataWritButton, 0)
            Me.Controls.SetChildIndex(Me.HostHaraiDataWritButton, 0)
            Me.Controls.SetChildIndex(Me.HaraiDataWritButton, 0)
            Me.Controls.SetChildIndex(Me.MonthlyDataButton, 0)
            Me.Controls.SetChildIndex(Me.YearlyDataButton, 0)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub BatchMenuForm_Load(sender As Object, e As EventArgs)
            If "Matsuyama".Equals(TopForm.ConfigData.xmlConfData.Kyoten) Or "Kumamoto".Equals(TopForm.ConfigData.xmlConfData.Kyoten) Then
                Return
            End If
            Me._orgToolTip = New ToolTip()
            Me._orgToolTip.InitialDelay = 500
            Me._orgToolTip.ReshowDelay = 1000
            Me._orgToolTip.AutoPopDelay = 10000
            Me._orgToolTip.ShowAlways = True
            Me._orgToolTip.SetToolTip(Me.HostHaraiDataWritButton, "この機能は利用できません！")
            Me.HostHaraiDataWritButton.Enabled = False
        End Sub

        Private Sub BatchMenuForm_KeyDown(sender As Object, e As KeyEventArgs)
            If e.KeyData = CType(131184, Keys) Then
                Me._frm = New BatchJissekiForm()
                Me.formShow()
                Console.WriteLine("Ctrl+F1キーが押されました。")
            End If
        End Sub


        Private components As IContainer

        <AccessedThroughProperty("UkeireDataWritButton")>
        Private WithEvents UkeireDataWritButton As Button

        <AccessedThroughProperty("HostHaraiDataWritButton")>
        Private WithEvents HostHaraiDataWritButton As Button

        <AccessedThroughProperty("HaraiDataWritButton")>
        Private WithEvents HaraiDataWritButton As Button

        <AccessedThroughProperty("MonthlyDataButton")>
        Private WithEvents MonthlyDataButton As Button

        <AccessedThroughProperty("YearlyDataButton")>
        Private WithEvents YearlyDataButton As Button

        Private _orgToolTip As ToolTip

        Private Sub UkeireDataWritButton_Click_1(sender As Object, e As EventArgs) Handles UkeireDataWritButton.Click
            Me._frm = New BatchUkeireDataWritForm()
            Me.formShow()
        End Sub

        Private Sub HostHaraiDataWritButton_Click(sender As Object, e As EventArgs) Handles HostHaraiDataWritButton.Click
            Me._frm = New BatchHaraiHostDataWritForm()
            Me.formShow()
        End Sub

        Private Sub HaraiDataWritButton_Click(sender As Object, e As EventArgs) Handles HaraiDataWritButton.Click
            Me._frm = New BatchHaraiDataWritForm()
            Me.formShow()
        End Sub

        Private Sub MonthlyDataButton_Click(sender As Object, e As EventArgs) Handles MonthlyDataButton.Click
            Me._frm = New BatchMonthlyDataForm()
            Me.formShow()
        End Sub

        Private Sub YearlyDataButton_Click(sender As Object, e As EventArgs) Handles YearlyDataButton.Click
            Me._frm = New BatchYearlyDataForm()
            Me.formShow()
        End Sub
    End Class
End Namespace
