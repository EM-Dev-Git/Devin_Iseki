Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class CreatDataMenuForm
		Inherits BaseMenuForm

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.CreatDataMenuForm_Load
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
            Me.TorihikiUkeharaiMonthlyButton = New Button()
            Me.GekkanUkeharaiDayDeployButton = New Button()
            Me.UkeharaiReportButton = New Button()
            Me.UkeharaiConfirmationLetterButton = New Button()
            Me.BuhinMasterButton = New Button()
            Me.TorihikitMasterButton = New Button()
            Me.ZaikoDailyAndMonthlyButton = New Button()
            Me.BuhinPrintButton = New Button()
            Me.NounyuMasterButton = New Button()
            Me.SuspendLayout()
            '
            'TitleLabel
            '
            Me.TitleLabel.BackColor = Color.SlateBlue
            Me.TitleLabel.Text = "データ作成メニュー"
            '
            'TorihikiUkeharaiDailyButton
            '
            Me.TorihikiUkeharaiDailyButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikiUkeharaiDailyButton.ForeColor = Color.Black
            Me.TorihikiUkeharaiDailyButton.Location = New Point(45, 90)
            Me.TorihikiUkeharaiDailyButton.Name = "TorihikiUkeharaiDailyButton"
            Me.TorihikiUkeharaiDailyButton.Size = New Size(225, 40)
            Me.TorihikiUkeharaiDailyButton.TabIndex = 1
            Me.TorihikiUkeharaiDailyButton.Text = "50. 取引先別受払データ作成（日別）"
            Me.TorihikiUkeharaiDailyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TorihikiUkeharaiDailyButton.UseVisualStyleBackColor = True
            '
            'TorihikiUkeharaiMonthlyButton
            '
            Me.TorihikiUkeharaiMonthlyButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikiUkeharaiMonthlyButton.ForeColor = Color.Black
            Me.TorihikiUkeharaiMonthlyButton.Location = New Point(45, 155)
            Me.TorihikiUkeharaiMonthlyButton.Name = "TorihikiUkeharaiMonthlyButton"
            Me.TorihikiUkeharaiMonthlyButton.Size = New Size(225, 40)
            Me.TorihikiUkeharaiMonthlyButton.TabIndex = 2
            Me.TorihikiUkeharaiMonthlyButton.Text = "51. 取引先別受払データ作成（月別）"
            Me.TorihikiUkeharaiMonthlyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TorihikiUkeharaiMonthlyButton.UseVisualStyleBackColor = True
            '
            'GekkanUkeharaiDayDeployButton
            '
            Me.GekkanUkeharaiDayDeployButton.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.GekkanUkeharaiDayDeployButton.ForeColor = Color.Black
            Me.GekkanUkeharaiDayDeployButton.Location = New Point(45, 220)
            Me.GekkanUkeharaiDayDeployButton.Name = "GekkanUkeharaiDayDeployButton"
            Me.GekkanUkeharaiDayDeployButton.Size = New Size(225, 40)
            Me.GekkanUkeharaiDayDeployButton.TabIndex = 3
            Me.GekkanUkeharaiDayDeployButton.Text = "52. 月間受払日別展開データ作成"
            Me.GekkanUkeharaiDayDeployButton.TextAlign = ContentAlignment.MiddleLeft
            Me.GekkanUkeharaiDayDeployButton.UseVisualStyleBackColor = True
            '
            'UkeharaiReportButton
            '
            Me.UkeharaiReportButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.UkeharaiReportButton.ForeColor = Color.Black
            Me.UkeharaiReportButton.Location = New Point(45, 285)
            Me.UkeharaiReportButton.Name = "UkeharaiReportButton"
            Me.UkeharaiReportButton.Size = New Size(225, 40)
            Me.UkeharaiReportButton.TabIndex = 4
            Me.UkeharaiReportButton.Text = "53. 受払報告書データ作成"
            Me.UkeharaiReportButton.TextAlign = ContentAlignment.MiddleLeft
            Me.UkeharaiReportButton.UseVisualStyleBackColor = True
            '
            'UkeharaiConfirmationLetterButton
            '
            Me.UkeharaiConfirmationLetterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.UkeharaiConfirmationLetterButton.ForeColor = Color.Black
            Me.UkeharaiConfirmationLetterButton.Location = New Point(45, 350)
            Me.UkeharaiConfirmationLetterButton.Name = "UkeharaiConfirmationLetterButton"
            Me.UkeharaiConfirmationLetterButton.Size = New Size(225, 40)
            Me.UkeharaiConfirmationLetterButton.TabIndex = 5
            Me.UkeharaiConfirmationLetterButton.Text = "54. 受払確認書データ作成"
            Me.UkeharaiConfirmationLetterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.UkeharaiConfirmationLetterButton.UseVisualStyleBackColor = True
            '
            'BuhinMasterButton
            '
            Me.BuhinMasterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BuhinMasterButton.ForeColor = Color.Black
            Me.BuhinMasterButton.Location = New Point(320, 90)
            Me.BuhinMasterButton.Name = "BuhinMasterButton"
            Me.BuhinMasterButton.Size = New Size(225, 40)
            Me.BuhinMasterButton.TabIndex = 6
            Me.BuhinMasterButton.Text = "55. 部品マスターデータ作成"
            Me.BuhinMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BuhinMasterButton.UseVisualStyleBackColor = True
            '
            'TorihikitMasterButton
            '
            Me.TorihikitMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikitMasterButton.ForeColor = Color.Black
            Me.TorihikitMasterButton.Location = New Point(320, 155)
            Me.TorihikitMasterButton.Name = "TorihikitMasterButton"
            Me.TorihikitMasterButton.Size = New Size(225, 40)
            Me.TorihikitMasterButton.TabIndex = 7
            Me.TorihikitMasterButton.Text = "56. 取引先マスターデータ作成"
            Me.TorihikitMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.TorihikitMasterButton.UseVisualStyleBackColor = True
            '
            'ZaikoDailyAndMonthlyButton
            '
            Me.ZaikoDailyAndMonthlyButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ZaikoDailyAndMonthlyButton.ForeColor = Color.Black
            Me.ZaikoDailyAndMonthlyButton.Location = New Point(320, 220)
            Me.ZaikoDailyAndMonthlyButton.Name = "ZaikoDailyAndMonthlyButton"
            Me.ZaikoDailyAndMonthlyButton.Size = New Size(225, 40)
            Me.ZaikoDailyAndMonthlyButton.TabIndex = 8
            Me.ZaikoDailyAndMonthlyButton.Text = "57. 在庫注残リスト（月初）"
            Me.ZaikoDailyAndMonthlyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ZaikoDailyAndMonthlyButton.UseVisualStyleBackColor = True
            '
            'BuhinPrintButton
            '
            Me.BuhinPrintButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BuhinPrintButton.ForeColor = Color.Black
            Me.BuhinPrintButton.Location = New Point(320, 285)
            Me.BuhinPrintButton.Name = "BuhinPrintButton"
            Me.BuhinPrintButton.Size = New Size(225, 40)
            Me.BuhinPrintButton.TabIndex = 9
            Me.BuhinPrintButton.Text = "58. 部品別受払プリント"
            Me.BuhinPrintButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BuhinPrintButton.UseVisualStyleBackColor = True
            '
            'NounyuMasterButton
            '
            Me.NounyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.NounyuMasterButton.ForeColor = Color.Black
            Me.NounyuMasterButton.Location = New Point(320, 350)
            Me.NounyuMasterButton.Name = "NounyuMasterButton"
            Me.NounyuMasterButton.Size = New Size(225, 40)
            Me.NounyuMasterButton.TabIndex = 10
            Me.NounyuMasterButton.Text = "59. 納入先マスターデータ作成"
            Me.NounyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.NounyuMasterButton.UseVisualStyleBackColor = True
            '
            'CreatDataMenuForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(600, 500)
            Me.Controls.Add(Me.NounyuMasterButton)
            Me.Controls.Add(Me.BuhinPrintButton)
            Me.Controls.Add(Me.ZaikoDailyAndMonthlyButton)
            Me.Controls.Add(Me.TorihikitMasterButton)
            Me.Controls.Add(Me.BuhinMasterButton)
            Me.Controls.Add(Me.UkeharaiConfirmationLetterButton)
            Me.Controls.Add(Me.UkeharaiReportButton)
            Me.Controls.Add(Me.GekkanUkeharaiDayDeployButton)
            Me.Controls.Add(Me.TorihikiUkeharaiMonthlyButton)
            Me.Controls.Add(Me.TorihikiUkeharaiDailyButton)
            Me.Name = "CreatDataMenuForm"
            Me.Text = "CreatDataMenuForm"
            Me.TitleColor = Color.SlateBlue
            Me.TitleName = "データ作成メニュー"
            Me.Controls.SetChildIndex(Me.TitleLabel, 0)
            Me.Controls.SetChildIndex(Me.TorihikiUkeharaiDailyButton, 0)
            Me.Controls.SetChildIndex(Me.TorihikiUkeharaiMonthlyButton, 0)
            Me.Controls.SetChildIndex(Me.GekkanUkeharaiDayDeployButton, 0)
            Me.Controls.SetChildIndex(Me.UkeharaiReportButton, 0)
            Me.Controls.SetChildIndex(Me.UkeharaiConfirmationLetterButton, 0)
            Me.Controls.SetChildIndex(Me.BuhinMasterButton, 0)
            Me.Controls.SetChildIndex(Me.TorihikitMasterButton, 0)
            Me.Controls.SetChildIndex(Me.ZaikoDailyAndMonthlyButton, 0)
            Me.Controls.SetChildIndex(Me.BuhinPrintButton, 0)
            Me.Controls.SetChildIndex(Me.NounyuMasterButton, 0)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub CreatDataMenuForm_Load(sender As Object, e As EventArgs)
        End Sub
        Private components As IContainer

        <AccessedThroughProperty("TorihikiUkeharaiDailyButton")>
        Private WithEvents TorihikiUkeharaiDailyButton As Button

        <AccessedThroughProperty("TorihikiUkeharaiMonthlyButton")>
        Private WithEvents TorihikiUkeharaiMonthlyButton As Button

        <AccessedThroughProperty("GekkanUkeharaiDayDeployButton")>
        Private WithEvents GekkanUkeharaiDayDeployButton As Button

        <AccessedThroughProperty("UkeharaiReportButton")>
        Private WithEvents UkeharaiReportButton As Button

        <AccessedThroughProperty("UkeharaiConfirmationLetterButton")>
        Private WithEvents UkeharaiConfirmationLetterButton As Button

        <AccessedThroughProperty("BuhinMasterButton")>
        Private WithEvents BuhinMasterButton As Button

        <AccessedThroughProperty("TorihikitMasterButton")>
        Private WithEvents TorihikitMasterButton As Button

        <AccessedThroughProperty("ZaikoDailyAndMonthlyButton")>
        Private WithEvents ZaikoDailyAndMonthlyButton As Button

        <AccessedThroughProperty("BuhinPrintButton")>
        Private WithEvents BuhinPrintButton As Button

        <AccessedThroughProperty("NounyuMasterButton")>
        Private WithEvents NounyuMasterButton As Button

        Private Sub TorihikiUkeharaiDailyButton_Click(sender As Object, e As EventArgs) Handles TorihikiUkeharaiDailyButton.Click
            Me._frm = New CreateDataTorihikiUkeharaiDailyForm()
            Me.formShow()
        End Sub

        Private Sub TorihikiUkeharaiMonthlyButton_Click(sender As Object, e As EventArgs) Handles TorihikiUkeharaiMonthlyButton.Click
            Me._frm = New CreateDataTorihikiUkeharaiMonthlyForm()
            Me.formShow()
        End Sub

        Private Sub GekkanUkeharaiDayDeployButton_Click(sender As Object, e As EventArgs) Handles GekkanUkeharaiDayDeployButton.Click
            Me._frm = New CreateDataGekkanUkeharaiDayDeployForm()
            Me.formShow()
        End Sub

        Private Sub UkeharaiReportButton_Click(sender As Object, e As EventArgs) Handles UkeharaiReportButton.Click
            Me._frm = New ListUkeharaiReporForm()
            Me.formShow()
        End Sub

        Private Sub UkeharaiConfirmationLetterButton_Click(sender As Object, e As EventArgs) Handles UkeharaiConfirmationLetterButton.Click
            Me._frm = New ListUkeharaiConfirmationLetterForm()
            Me.formShow()
        End Sub

        Private Sub BuhinMasterButton_Click(sender As Object, e As EventArgs) Handles BuhinMasterButton.Click
            Me._frm = New CreateDataBuhinMasterForm()
            Me.formShow()
        End Sub

        Private Sub TorihikitMasterButton_Click(sender As Object, e As EventArgs) Handles TorihikitMasterButton.Click
            Me._frm = New CreateDataTorihikiMasterForm()
            Me.formShow()
        End Sub

        Private Sub ZaikoDailyAndMonthlyButton_Click(sender As Object, e As EventArgs) Handles ZaikoDailyAndMonthlyButton.Click
            Me._frm = New ListZaikoDailyAndMonthlyForm()
            Me.formShow()
        End Sub

        Private Sub BuhinPrintButton_Click(sender As Object, e As EventArgs) Handles BuhinPrintButton.Click
            Me._frm = New ListBuhinForm()
            Me.formShow()
        End Sub

        Private Sub NounyuMasterButton_Click(sender As Object, e As EventArgs) Handles NounyuMasterButton.Click
            Me._frm = New CreateDataNounyuMasterForm()
            Me.formShow()
        End Sub

    End Class
End Namespace
