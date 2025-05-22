Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports IbUkeharai.IbUkeharai.My
Imports Microsoft.VisualBasic.CompilerServices

''
''この画面は使用していない?
''初期起動はTopForm.vb
''

Namespace IbUkeharai

    <DesignerGenerated()>
    Public Class MainForm
        Inherits Form

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
            Me.FormTitleLabel = New Label()
            Me.RegisterGroupBox = New GroupBox()
            Me.RegisterTeisuMasterButton = New Button()
            Me.RegisterNounyuMasterButton = New Button()
            Me.RegisterSeikyuMasterButton = New Button()
            Me.RegisterTankaMasterButton = New Button()
            Me.RegisterBuhinMasterButton = New Button()
            Me.RegisterTorihikiMasterButton = New Button()
            Me.RegisterHaraiZIssekiButton = New Button()
            Me.RegisterUkeireZissekiButton = New Button()
            Me.CreateDataGroupBox = New GroupBox()
            Me.CreatDataNounyuMasterButton = New Button()
            Me.CreatDataTorihikitMasterButton = New Button()
            Me.CreatDataBuhinSubButton = New Button()
            Me.CreatDataBuhinMasterButton = New Button()
            Me.CreatDataGekkanUkeharaiDayDeployButton = New Button()
            Me.CreatDataTorihikiUkeharaiMonthlyButton = New Button()
            Me.CreatDataTorihikiUkeharaiDailyButton = New Button()
            Me.ListOutputGroupBox = New GroupBox()
            Me.OutPutSeikyuButton = New Button()
            Me.OutPutZissekiTableButton = New Button()
            Me.ListBuhinButton = New Button()
            Me.ListZaikoDailyAndMonthlyButton = New Button()
            Me.ListUkeharaiConfirmationLetterButton = New Button()
            Me.ListUkeharaiReportButton = New Button()
            Me.InquiryWindowGroupBox = New GroupBox()
            Me.InquiryUkeharaiZissekiButton = New Button()
            Me.BatchProcessGroupBox = New GroupBox()
            Me.BatchTorihikiBulkChangeButton = New Button()
            Me.BatchYearlyDataButton = New Button()
            Me.BatchMonthlyDataButton = New Button()
            Me.BatchHaraiDataWritButton = New Button()
            Me.BatchUkeireDataWritButton = New Button()
            Me.CloseButton = New Button()
            Me.RegisterGroupBox.SuspendLayout()
            Me.CreateDataGroupBox.SuspendLayout()
            Me.ListOutputGroupBox.SuspendLayout()
            Me.InquiryWindowGroupBox.SuspendLayout()
            Me.BatchProcessGroupBox.SuspendLayout()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.BackColor = Color.CornflowerBlue
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(760, 45)
            Me.FormTitleLabel.TabIndex = 0
            Me.FormTitleLabel.Text = "受払システム　　　メニュー"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'RegisterGroupBox
            '
            Me.RegisterGroupBox.Controls.Add(Me.RegisterTeisuMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterNounyuMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterSeikyuMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterTankaMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterBuhinMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterTorihikiMasterButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterHaraiZIssekiButton)
            Me.RegisterGroupBox.Controls.Add(Me.RegisterUkeireZissekiButton)
            Me.RegisterGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterGroupBox.Location = New Point(39, 57)
            Me.RegisterGroupBox.Name = "RegisterGroupBox"
            Me.RegisterGroupBox.Size = New Size(325, 262)
            Me.RegisterGroupBox.TabIndex = 1
            Me.RegisterGroupBox.TabStop = False
            Me.RegisterGroupBox.Text = "登録画面"
            '
            'RegisterTeisuMasterButton
            '
            Me.RegisterTeisuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterTeisuMasterButton.Location = New Point(14, 228)
            Me.RegisterTeisuMasterButton.Name = "RegisterTeisuMasterButton"
            Me.RegisterTeisuMasterButton.Size = New Size(300, 24)
            Me.RegisterTeisuMasterButton.TabIndex = 7
            Me.RegisterTeisuMasterButton.Text = "19. 定数マスター登録"
            Me.RegisterTeisuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterTeisuMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterNounyuMasterButton
            '
            Me.RegisterNounyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterNounyuMasterButton.Location = New Point(14, 198)
            Me.RegisterNounyuMasterButton.Name = "RegisterNounyuMasterButton"
            Me.RegisterNounyuMasterButton.Size = New Size(300, 24)
            Me.RegisterNounyuMasterButton.TabIndex = 6
            Me.RegisterNounyuMasterButton.Text = "18. 納入先マスター登録"
            Me.RegisterNounyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterNounyuMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterSeikyuMasterButton
            '
            Me.RegisterSeikyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterSeikyuMasterButton.Location = New Point(14, 168)
            Me.RegisterSeikyuMasterButton.Name = "RegisterSeikyuMasterButton"
            Me.RegisterSeikyuMasterButton.Size = New Size(300, 24)
            Me.RegisterSeikyuMasterButton.TabIndex = 5
            Me.RegisterSeikyuMasterButton.Text = "17. 請求マスター登録"
            Me.RegisterSeikyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterSeikyuMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterTankaMasterButton
            '
            Me.RegisterTankaMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterTankaMasterButton.Location = New Point(14, 138)
            Me.RegisterTankaMasterButton.Name = "RegisterTankaMasterButton"
            Me.RegisterTankaMasterButton.Size = New Size(300, 24)
            Me.RegisterTankaMasterButton.TabIndex = 4
            Me.RegisterTankaMasterButton.Text = "16. 単価マスター登録"
            Me.RegisterTankaMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterTankaMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterBuhinMasterButton
            '
            Me.RegisterBuhinMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterBuhinMasterButton.Location = New Point(14, 108)
            Me.RegisterBuhinMasterButton.Name = "RegisterBuhinMasterButton"
            Me.RegisterBuhinMasterButton.Size = New Size(300, 24)
            Me.RegisterBuhinMasterButton.TabIndex = 3
            Me.RegisterBuhinMasterButton.Text = "15. 部品マスター登録"
            Me.RegisterBuhinMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterBuhinMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterTorihikiMasterButton
            '
            Me.RegisterTorihikiMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterTorihikiMasterButton.Location = New Point(14, 78)
            Me.RegisterTorihikiMasterButton.Name = "RegisterTorihikiMasterButton"
            Me.RegisterTorihikiMasterButton.Size = New Size(300, 24)
            Me.RegisterTorihikiMasterButton.TabIndex = 2
            Me.RegisterTorihikiMasterButton.Text = "14. 取引先マスター登録"
            Me.RegisterTorihikiMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterTorihikiMasterButton.UseVisualStyleBackColor = True
            '
            'RegisterHaraiZIssekiButton
            '
            Me.RegisterHaraiZIssekiButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterHaraiZIssekiButton.Location = New Point(14, 48)
            Me.RegisterHaraiZIssekiButton.Name = "RegisterHaraiZIssekiButton"
            Me.RegisterHaraiZIssekiButton.Size = New Size(300, 24)
            Me.RegisterHaraiZIssekiButton.TabIndex = 1
            Me.RegisterHaraiZIssekiButton.Text = "12. 払出実績登録"
            Me.RegisterHaraiZIssekiButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterHaraiZIssekiButton.UseVisualStyleBackColor = True
            '
            'RegisterUkeireZissekiButton
            '
            Me.RegisterUkeireZissekiButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterUkeireZissekiButton.Location = New Point(14, 18)
            Me.RegisterUkeireZissekiButton.Name = "RegisterUkeireZissekiButton"
            Me.RegisterUkeireZissekiButton.Size = New Size(300, 24)
            Me.RegisterUkeireZissekiButton.TabIndex = 0
            Me.RegisterUkeireZissekiButton.Text = "11. 受入実績登録"
            Me.RegisterUkeireZissekiButton.TextAlign = ContentAlignment.MiddleLeft
            Me.RegisterUkeireZissekiButton.UseVisualStyleBackColor = True
            '
            'CreateDataGroupBox
            '
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataNounyuMasterButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataTorihikitMasterButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataBuhinSubButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataBuhinMasterButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataGekkanUkeharaiDayDeployButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataTorihikiUkeharaiMonthlyButton)
            Me.CreateDataGroupBox.Controls.Add(Me.CreatDataTorihikiUkeharaiDailyButton)
            Me.CreateDataGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreateDataGroupBox.Location = New Point(39, 323)
            Me.CreateDataGroupBox.Name = "CreateDataGroupBox"
            Me.CreateDataGroupBox.Size = New Size(325, 231)
            Me.CreateDataGroupBox.TabIndex = 2
            Me.CreateDataGroupBox.TabStop = False
            Me.CreateDataGroupBox.Text = "データ作成"
            '
            'CreatDataNounyuMasterButton
            '
            Me.CreatDataNounyuMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataNounyuMasterButton.Location = New Point(14, 198)
            Me.CreatDataNounyuMasterButton.Name = "CreatDataNounyuMasterButton"
            Me.CreatDataNounyuMasterButton.Size = New Size(300, 24)
            Me.CreatDataNounyuMasterButton.TabIndex = 6
            Me.CreatDataNounyuMasterButton.Text = "56. 納入先マスターデータ作成"
            Me.CreatDataNounyuMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataNounyuMasterButton.UseVisualStyleBackColor = True
            '
            'CreatDataTorihikitMasterButton
            '
            Me.CreatDataTorihikitMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataTorihikitMasterButton.Location = New Point(14, 168)
            Me.CreatDataTorihikitMasterButton.Name = "CreatDataTorihikitMasterButton"
            Me.CreatDataTorihikitMasterButton.Size = New Size(300, 24)
            Me.CreatDataTorihikitMasterButton.TabIndex = 5
            Me.CreatDataTorihikitMasterButton.Text = "55. 取引先マスターデータ作成"
            Me.CreatDataTorihikitMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataTorihikitMasterButton.UseVisualStyleBackColor = True
            '
            'CreatDataBuhinSubButton
            '
            Me.CreatDataBuhinSubButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataBuhinSubButton.Location = New Point(14, 138)
            Me.CreatDataBuhinSubButton.Name = "CreatDataBuhinSubButton"
            Me.CreatDataBuhinSubButton.Size = New Size(300, 24)
            Me.CreatDataBuhinSubButton.TabIndex = 4
            Me.CreatDataBuhinSubButton.Text = "54. 部品マスターデータ（２）作成"
            Me.CreatDataBuhinSubButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataBuhinSubButton.UseVisualStyleBackColor = True
            '
            'CreatDataBuhinMasterButton
            '
            Me.CreatDataBuhinMasterButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataBuhinMasterButton.Location = New Point(14, 108)
            Me.CreatDataBuhinMasterButton.Name = "CreatDataBuhinMasterButton"
            Me.CreatDataBuhinMasterButton.Size = New Size(300, 24)
            Me.CreatDataBuhinMasterButton.TabIndex = 3
            Me.CreatDataBuhinMasterButton.Text = "53. 部品マスターデータ作成"
            Me.CreatDataBuhinMasterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataBuhinMasterButton.UseVisualStyleBackColor = True
            '
            'CreatDataGekkanUkeharaiDayDeployButton
            '
            Me.CreatDataGekkanUkeharaiDayDeployButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataGekkanUkeharaiDayDeployButton.Location = New Point(14, 78)
            Me.CreatDataGekkanUkeharaiDayDeployButton.Name = "CreatDataGekkanUkeharaiDayDeployButton"
            Me.CreatDataGekkanUkeharaiDayDeployButton.Size = New Size(300, 24)
            Me.CreatDataGekkanUkeharaiDayDeployButton.TabIndex = 2
            Me.CreatDataGekkanUkeharaiDayDeployButton.Text = "52. 月刊受払日別展開データ作成"
            Me.CreatDataGekkanUkeharaiDayDeployButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataGekkanUkeharaiDayDeployButton.UseVisualStyleBackColor = True
            '
            'CreatDataTorihikiUkeharaiMonthlyButton
            '
            Me.CreatDataTorihikiUkeharaiMonthlyButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataTorihikiUkeharaiMonthlyButton.Location = New Point(14, 48)
            Me.CreatDataTorihikiUkeharaiMonthlyButton.Name = "CreatDataTorihikiUkeharaiMonthlyButton"
            Me.CreatDataTorihikiUkeharaiMonthlyButton.Size = New Size(300, 24)
            Me.CreatDataTorihikiUkeharaiMonthlyButton.TabIndex = 1
            Me.CreatDataTorihikiUkeharaiMonthlyButton.Text = "51. 取引先別受払データ作成（月別）"
            Me.CreatDataTorihikiUkeharaiMonthlyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataTorihikiUkeharaiMonthlyButton.UseVisualStyleBackColor = True
            '
            'CreatDataTorihikiUkeharaiDailyButton
            '
            Me.CreatDataTorihikiUkeharaiDailyButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataTorihikiUkeharaiDailyButton.Location = New Point(14, 18)
            Me.CreatDataTorihikiUkeharaiDailyButton.Name = "CreatDataTorihikiUkeharaiDailyButton"
            Me.CreatDataTorihikiUkeharaiDailyButton.Size = New Size(300, 24)
            Me.CreatDataTorihikiUkeharaiDailyButton.TabIndex = 0
            Me.CreatDataTorihikiUkeharaiDailyButton.Text = "50. 取引先別受払データ作成（日別）"
            Me.CreatDataTorihikiUkeharaiDailyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.CreatDataTorihikiUkeharaiDailyButton.UseVisualStyleBackColor = True
            '
            'ListOutputGroupBox
            '
            Me.ListOutputGroupBox.Controls.Add(Me.OutPutSeikyuButton)
            Me.ListOutputGroupBox.Controls.Add(Me.OutPutZissekiTableButton)
            Me.ListOutputGroupBox.Controls.Add(Me.ListBuhinButton)
            Me.ListOutputGroupBox.Controls.Add(Me.ListZaikoDailyAndMonthlyButton)
            Me.ListOutputGroupBox.Controls.Add(Me.ListUkeharaiConfirmationLetterButton)
            Me.ListOutputGroupBox.Controls.Add(Me.ListUkeharaiReportButton)
            Me.ListOutputGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ListOutputGroupBox.Location = New Point(421, 57)
            Me.ListOutputGroupBox.Name = "ListOutputGroupBox"
            Me.ListOutputGroupBox.Size = New Size(325, 202)
            Me.ListOutputGroupBox.TabIndex = 3
            Me.ListOutputGroupBox.TabStop = False
            Me.ListOutputGroupBox.Text = "リスト出力"
            '
            'OutPutSeikyuButton
            '
            Me.OutPutSeikyuButton.Location = New Point(14, 168)
            Me.OutPutSeikyuButton.Name = "OutPutSeikyuButton"
            Me.OutPutSeikyuButton.Size = New Size(300, 24)
            Me.OutPutSeikyuButton.TabIndex = 5
            Me.OutPutSeikyuButton.Text = "62. 請求書出力"
            Me.OutPutSeikyuButton.TextAlign = ContentAlignment.MiddleLeft
            Me.OutPutSeikyuButton.UseVisualStyleBackColor = True
            '
            'OutPutZissekiTableButton
            '
            Me.OutPutZissekiTableButton.Location = New Point(14, 138)
            Me.OutPutZissekiTableButton.Name = "OutPutZissekiTableButton"
            Me.OutPutZissekiTableButton.Size = New Size(300, 24)
            Me.OutPutZissekiTableButton.TabIndex = 4
            Me.OutPutZissekiTableButton.Text = "61. 実績内訳表出力"
            Me.OutPutZissekiTableButton.TextAlign = ContentAlignment.MiddleLeft
            Me.OutPutZissekiTableButton.UseVisualStyleBackColor = True
            '
            'ListBuhinButton
            '
            Me.ListBuhinButton.Location = New Point(14, 108)
            Me.ListBuhinButton.Name = "ListBuhinButton"
            Me.ListBuhinButton.Size = New Size(300, 24)
            Me.ListBuhinButton.TabIndex = 3
            Me.ListBuhinButton.Text = "38. 部品別受払プリント"
            Me.ListBuhinButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ListBuhinButton.UseVisualStyleBackColor = True
            '
            'ListZaikoDailyAndMonthlyButton
            '
            Me.ListZaikoDailyAndMonthlyButton.Location = New Point(14, 78)
            Me.ListZaikoDailyAndMonthlyButton.Name = "ListZaikoDailyAndMonthlyButton"
            Me.ListZaikoDailyAndMonthlyButton.Size = New Size(300, 24)
            Me.ListZaikoDailyAndMonthlyButton.TabIndex = 2
            Me.ListZaikoDailyAndMonthlyButton.Text = "37. 在庫注残リスト（当時・月初）"
            Me.ListZaikoDailyAndMonthlyButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ListZaikoDailyAndMonthlyButton.UseVisualStyleBackColor = True
            '
            'ListUkeharaiConfirmationLetterButton
            '
            Me.ListUkeharaiConfirmationLetterButton.Location = New Point(14, 48)
            Me.ListUkeharaiConfirmationLetterButton.Name = "ListUkeharaiConfirmationLetterButton"
            Me.ListUkeharaiConfirmationLetterButton.Size = New Size(300, 24)
            Me.ListUkeharaiConfirmationLetterButton.TabIndex = 1
            Me.ListUkeharaiConfirmationLetterButton.Text = "32. 受払確認書"
            Me.ListUkeharaiConfirmationLetterButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ListUkeharaiConfirmationLetterButton.UseVisualStyleBackColor = True
            '
            'ListUkeharaiReportButton
            '
            Me.ListUkeharaiReportButton.Location = New Point(14, 18)
            Me.ListUkeharaiReportButton.Name = "ListUkeharaiReportButton"
            Me.ListUkeharaiReportButton.Size = New Size(300, 24)
            Me.ListUkeharaiReportButton.TabIndex = 0
            Me.ListUkeharaiReportButton.Text = "31. 受払報告書"
            Me.ListUkeharaiReportButton.TextAlign = ContentAlignment.MiddleLeft
            Me.ListUkeharaiReportButton.UseVisualStyleBackColor = True
            '
            'InquiryWindowGroupBox
            '
            Me.InquiryWindowGroupBox.Controls.Add(Me.InquiryUkeharaiZissekiButton)
            Me.InquiryWindowGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.InquiryWindowGroupBox.Location = New Point(421, 265)
            Me.InquiryWindowGroupBox.Name = "InquiryWindowGroupBox"
            Me.InquiryWindowGroupBox.Size = New Size(325, 55)
            Me.InquiryWindowGroupBox.TabIndex = 4
            Me.InquiryWindowGroupBox.TabStop = False
            Me.InquiryWindowGroupBox.Text = "問合せ画面"
            '
            'InquiryUkeharaiZissekiButton
            '
            Me.InquiryUkeharaiZissekiButton.Location = New Point(14, 22)
            Me.InquiryUkeharaiZissekiButton.Name = "InquiryUkeharaiZissekiButton"
            Me.InquiryUkeharaiZissekiButton.Size = New Size(300, 24)
            Me.InquiryUkeharaiZissekiButton.TabIndex = 0
            Me.InquiryUkeharaiZissekiButton.Text = "21. 受払実績"
            Me.InquiryUkeharaiZissekiButton.TextAlign = ContentAlignment.MiddleLeft
            Me.InquiryUkeharaiZissekiButton.UseVisualStyleBackColor = True
            '
            'BatchProcessGroupBox
            '
            Me.BatchProcessGroupBox.Controls.Add(Me.BatchTorihikiBulkChangeButton)
            Me.BatchProcessGroupBox.Controls.Add(Me.BatchYearlyDataButton)
            Me.BatchProcessGroupBox.Controls.Add(Me.BatchMonthlyDataButton)
            Me.BatchProcessGroupBox.Controls.Add(Me.BatchHaraiDataWritButton)
            Me.BatchProcessGroupBox.Controls.Add(Me.BatchUkeireDataWritButton)
            Me.BatchProcessGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BatchProcessGroupBox.Location = New Point(421, 326)
            Me.BatchProcessGroupBox.Name = "BatchProcessGroupBox"
            Me.BatchProcessGroupBox.Size = New Size(325, 177)
            Me.BatchProcessGroupBox.TabIndex = 5
            Me.BatchProcessGroupBox.TabStop = False
            Me.BatchProcessGroupBox.Text = "バッチ処理"
            '
            'BatchTorihikiBulkChangeButton
            '
            Me.BatchTorihikiBulkChangeButton.Location = New Point(14, 144)
            Me.BatchTorihikiBulkChangeButton.Name = "BatchTorihikiBulkChangeButton"
            Me.BatchTorihikiBulkChangeButton.Size = New Size(300, 24)
            Me.BatchTorihikiBulkChangeButton.TabIndex = 4
            Me.BatchTorihikiBulkChangeButton.Text = "45. 取引先一括変更"
            Me.BatchTorihikiBulkChangeButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BatchTorihikiBulkChangeButton.UseVisualStyleBackColor = True
            '
            'BatchYearlyDataButton
            '
            Me.BatchYearlyDataButton.Location = New Point(14, 114)
            Me.BatchYearlyDataButton.Name = "BatchYearlyDataButton"
            Me.BatchYearlyDataButton.Size = New Size(300, 24)
            Me.BatchYearlyDataButton.TabIndex = 3
            Me.BatchYearlyDataButton.Text = "44. 年次データ処理"
            Me.BatchYearlyDataButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BatchYearlyDataButton.UseVisualStyleBackColor = True
            '
            'BatchMonthlyDataButton
            '
            Me.BatchMonthlyDataButton.Location = New Point(14, 84)
            Me.BatchMonthlyDataButton.Name = "BatchMonthlyDataButton"
            Me.BatchMonthlyDataButton.Size = New Size(300, 24)
            Me.BatchMonthlyDataButton.TabIndex = 2
            Me.BatchMonthlyDataButton.Text = "42. 月次データ処理"
            Me.BatchMonthlyDataButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BatchMonthlyDataButton.UseVisualStyleBackColor = True
            '
            'BatchHaraiDataWritButton
            '
            Me.BatchHaraiDataWritButton.Location = New Point(14, 54)
            Me.BatchHaraiDataWritButton.Name = "BatchHaraiDataWritButton"
            Me.BatchHaraiDataWritButton.Size = New Size(300, 24)
            Me.BatchHaraiDataWritButton.TabIndex = 1
            Me.BatchHaraiDataWritButton.Text = "41. 払出データ書き込み"
            Me.BatchHaraiDataWritButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BatchHaraiDataWritButton.UseVisualStyleBackColor = True
            '
            'BatchUkeireDataWritButton
            '
            Me.BatchUkeireDataWritButton.Location = New Point(14, 24)
            Me.BatchUkeireDataWritButton.Name = "BatchUkeireDataWritButton"
            Me.BatchUkeireDataWritButton.Size = New Size(300, 24)
            Me.BatchUkeireDataWritButton.TabIndex = 0
            Me.BatchUkeireDataWritButton.Text = "40. 受入データ書き込み"
            Me.BatchUkeireDataWritButton.TextAlign = ContentAlignment.MiddleLeft
            Me.BatchUkeireDataWritButton.UseVisualStyleBackColor = True
            '
            'CloseButton
            '
            Me.CloseButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CloseButton.Location = New Point(692, 515)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New Size(80, 35)
            Me.CloseButton.TabIndex = 6
            Me.CloseButton.Text = "閉じる"
            Me.CloseButton.UseVisualStyleBackColor = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(784, 562)
            Me.Controls.Add(Me.CloseButton)
            Me.Controls.Add(Me.BatchProcessGroupBox)
            Me.Controls.Add(Me.InquiryWindowGroupBox)
            Me.Controls.Add(Me.ListOutputGroupBox)
            Me.Controls.Add(Me.CreateDataGroupBox)
            Me.Controls.Add(Me.RegisterGroupBox)
            Me.Controls.Add(Me.FormTitleLabel)
            Me.FormBorderStyle = FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "MainForm"
            Me.Text = "受払システム"
            Me.RegisterGroupBox.ResumeLayout(False)
            Me.CreateDataGroupBox.ResumeLayout(False)
            Me.ListOutputGroupBox.ResumeLayout(False)
            Me.InquiryWindowGroupBox.ResumeLayout(False)
            Me.BatchProcessGroupBox.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.MainForm_Load
            Me.InitializeComponent()
            Me.StartPosition = FormStartPosition.CenterScreen
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs)
            Using frmLogo As New frmLogo()
                frmLogo.StartPosition = FormStartPosition.CenterScreen
                frmLogo.ShowDialog()
                MainForm.ConfigData = frmLogo._configData
                OutputLog.WriteLine("aaa")
                OutputLog.Initialize(False, MainForm.ConfigData.xmlConfData.xPath.LogFileName)
            End Using
        End Sub


        Private Sub formShow()
            If Me._frm Is Nothing Then
                Return
            End If
            Me.Hide()
            Me._frm.ShowDialog()
            Me.Show()
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("RegisterGroupBox")>
        Private WithEvents RegisterGroupBox As GroupBox

        <AccessedThroughProperty("RegisterTeisuMasterButton")>
        Private WithEvents RegisterTeisuMasterButton As Button

        <AccessedThroughProperty("RegisterNounyuMasterButton")>
        Private WithEvents RegisterNounyuMasterButton As Button

        <AccessedThroughProperty("RegisterSeikyuMasterButton")>
        Private WithEvents RegisterSeikyuMasterButton As Button

        <AccessedThroughProperty("RegisterTankaMasterButton")>
        Private WithEvents RegisterTankaMasterButton As Button

        <AccessedThroughProperty("RegisterBuhinMasterButton")>
        Private WithEvents RegisterBuhinMasterButton As Button

        <AccessedThroughProperty("RegisterTorihikiMasterButton")>
        Private WithEvents RegisterTorihikiMasterButton As Button

        <AccessedThroughProperty("RegisterHaraiZIssekiButton")>
        Private WithEvents RegisterHaraiZIssekiButton As Button

        <AccessedThroughProperty("RegisterUkeireZissekiButton")>
        Private WithEvents RegisterUkeireZissekiButton As Button

        <AccessedThroughProperty("CreateDataGroupBox")>
        Private WithEvents CreateDataGroupBox As GroupBox

        <AccessedThroughProperty("CreatDataTorihikiUkeharaiDailyButton")>
        Private WithEvents CreatDataTorihikiUkeharaiDailyButton As Button

        <AccessedThroughProperty("CreatDataNounyuMasterButton")>
        Private WithEvents CreatDataNounyuMasterButton As Button

        <AccessedThroughProperty("CreatDataTorihikitMasterButton")>
        Private WithEvents CreatDataTorihikitMasterButton As Button

        <AccessedThroughProperty("CreatDataBuhinSubButton")>
        Private WithEvents CreatDataBuhinSubButton As Button

        <AccessedThroughProperty("CreatDataBuhinMasterButton")>
        Private WithEvents CreatDataBuhinMasterButton As Button

        <AccessedThroughProperty("CreatDataGekkanUkeharaiDayDeployButton")>
        Private WithEvents CreatDataGekkanUkeharaiDayDeployButton As Button

        <AccessedThroughProperty("CreatDataTorihikiUkeharaiMonthlyButton")>
        Private WithEvents CreatDataTorihikiUkeharaiMonthlyButton As Button

        <AccessedThroughProperty("ListOutputGroupBox")>
        Private WithEvents ListOutputGroupBox As GroupBox

        <AccessedThroughProperty("OutPutSeikyuButton")>
        Private WithEvents OutPutSeikyuButton As Button

        <AccessedThroughProperty("OutPutZissekiTableButton")>
        Private WithEvents OutPutZissekiTableButton As Button

        <AccessedThroughProperty("ListBuhinButton")>
        Private WithEvents ListBuhinButton As Button

        <AccessedThroughProperty("ListZaikoDailyAndMonthlyButton")>
        Private WithEvents ListZaikoDailyAndMonthlyButton As Button

        <AccessedThroughProperty("ListUkeharaiConfirmationLetterButton")>
        Private WithEvents ListUkeharaiConfirmationLetterButton As Button

        <AccessedThroughProperty("ListUkeharaiReportButton")>
        Private WithEvents ListUkeharaiReportButton As Button

        <AccessedThroughProperty("InquiryWindowGroupBox")>
        Private WithEvents InquiryWindowGroupBox As GroupBox

        <AccessedThroughProperty("InquiryUkeharaiZissekiButton")>
        Private WithEvents InquiryUkeharaiZissekiButton As Button

        <AccessedThroughProperty("BatchProcessGroupBox")>
        Private WithEvents BatchProcessGroupBox As GroupBox

        <AccessedThroughProperty("BatchYearlyDataButton")>
        Private WithEvents BatchYearlyDataButton As Button

        <AccessedThroughProperty("BatchMonthlyDataButton")>
        Private WithEvents BatchMonthlyDataButton As Button

        <AccessedThroughProperty("BatchHaraiDataWritButton")>
        Private WithEvents BatchHaraiDataWritButton As Button

        <AccessedThroughProperty("BatchUkeireDataWritButton")>
        Private WithEvents BatchUkeireDataWritButton As Button

        <AccessedThroughProperty("CloseButton")>
        Private WithEvents CloseButton As Button

        <AccessedThroughProperty("BatchTorihikiBulkChangeButton")>
        Private WithEvents BatchTorihikiBulkChangeButton As Button

        Public Shared ConfigData As XmlConfigControl

        Private _frm As Form

        Private Sub RegisterUkeireZissekiButton_Click(sender As Object, e As EventArgs) Handles RegisterUkeireZissekiButton.Click
            Me._frm = New RegisterUkeireZissekiForm()
            Me.formShow()
        End Sub

        Private Sub RegisterHaraiZIssekiButton_Click(sender As Object, e As EventArgs) Handles RegisterHaraiZIssekiButton.Click
            Me._frm = New RegisterHaraiZIssekiForm()
            Me.formShow()
        End Sub

        Private Sub RegisterTorihikiMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterTorihikiMasterButton.Click
            Me._frm = New RegisterTorihikiMasterForm()
            Me.formShow()
        End Sub

        Private Sub RegisterBuhinMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterBuhinMasterButton.Click
            Me._frm = New RegisterBuhinMasterForm()
            Me.formShow()
        End Sub

        Private Sub RegisterTankaMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterTankaMasterButton.Click
            Me._frm = New RegisterTankaMasterForm()
            Me.formShow()
        End Sub

        Private Sub RegisterSeikyuMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterSeikyuMasterButton.Click
            Me._frm = New RegisterSeikyuMasterForm()
            Me.formShow()
        End Sub

        Private Sub RegisterNounyuMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterNounyuMasterButton.Click
            Me._frm = New RegisterNounyuMasterForm()
            Me.formShow()
        End Sub

        Private Sub RegisterTeisuMasterButton_Click(sender As Object, e As EventArgs) Handles RegisterTeisuMasterButton.Click
            Me._frm = New RegisterJosuMasterForm()
            Me.formShow()
        End Sub

        Private Sub CreatDataTorihikiUkeharaiDailyButton_Click(sender As Object, e As EventArgs) Handles CreatDataTorihikiUkeharaiDailyButton.Click
            MyProject.Forms.CreateDataTorihikiUkeharaiDailyForm.ShowDialog()
        End Sub

        Private Sub CreatDataTorihikiUkeharaiMonthlyButton_Click(sender As Object, e As EventArgs) Handles CreatDataTorihikiUkeharaiMonthlyButton.Click
            MyProject.Forms.CreateDataTorihikiUkeharaiMonthlyForm.ShowDialog()
        End Sub

        Private Sub CreatDataGekkanUkeharaiDayDeployButton_Click(sender As Object, e As EventArgs) Handles CreatDataGekkanUkeharaiDayDeployButton.Click
            MyProject.Forms.CreateDataGekkanUkeharaiDayDeployForm.ShowDialog()
        End Sub

        Private Sub CreatDataBuhinMasterButton_Click(sender As Object, e As EventArgs) Handles CreatDataBuhinMasterButton.Click
            MyProject.Forms.CreateDataBuhinMasterForm.ShowDialog()
        End Sub

        Private Sub CreatDataTorihikitMasterButton_Click(sender As Object, e As EventArgs) Handles CreatDataTorihikitMasterButton.Click
            MyProject.Forms.CreateDataTorihikiMasterForm.ShowDialog()
        End Sub

        Private Sub CreatDataNounyuMasterButton_Click(sender As Object, e As EventArgs) Handles CreatDataNounyuMasterButton.Click
            MyProject.Forms.CreateDataNounyuMasterForm.ShowDialog()
        End Sub

        Private Sub ListUkeharaiReportButton_Click(sender As Object, e As EventArgs) Handles ListUkeharaiReportButton.Click
            MyProject.Forms.ListUkeharaiReporForm.ShowDialog()
        End Sub

        Private Sub ListUkeharaiConfirmationLetterButton_Click(sender As Object, e As EventArgs) Handles ListUkeharaiConfirmationLetterButton.Click
            MyProject.Forms.ListUkeharaiConfirmationLetterForm.ShowDialog()
        End Sub

        Private Sub ListZaikoDailyAndMonthlyButton_Click(sender As Object, e As EventArgs) Handles ListZaikoDailyAndMonthlyButton.Click
            Me._frm = New ListZaikoDailyAndMonthlyForm()
            Me.formShow()
        End Sub

        Private Sub ListBuhinButton_Click(sender As Object, e As EventArgs) Handles ListBuhinButton.Click
            MyProject.Forms.ListBuhinForm.ShowDialog()
        End Sub

        Private Sub OutPutZissekiTableButton_Click(sender As Object, e As EventArgs) Handles OutPutZissekiTableButton.Click
            MyProject.Forms.OutPutZissekiTableForm.ShowDialog()
        End Sub

        Private Sub OutPutSeikyuButton_Click(sender As Object, e As EventArgs) Handles OutPutSeikyuButton.Click
            MyProject.Forms.OutPutSeikyuForm.ShowDialog()
        End Sub

        Private Sub InquiryUkeharaiZissekiButton_Click(sender As Object, e As EventArgs) Handles InquiryUkeharaiZissekiButton.Click
            MyProject.Forms.InquiryUkeharaiZissekiForm.ShowDialog()
        End Sub

        Private Sub BatchUkeireDataWritButton_Click(sender As Object, e As EventArgs) Handles BatchUkeireDataWritButton.Click
            MyProject.Forms.BatchUkeireDataWritForm.ShowDialog()
        End Sub

        Private Sub BatchHaraiDataWritButton_Click(sender As Object, e As EventArgs) Handles BatchHaraiDataWritButton.Click
            MyProject.Forms.BatchHaraiHostDataWritForm.ShowDialog()
        End Sub

        Private Sub BatchMonthlyDataButton_Click(sender As Object, e As EventArgs) Handles BatchMonthlyDataButton.Click
            MyProject.Forms.BatchMonthlyDataForm.ShowDialog()
        End Sub

        Private Sub BatchYearlyDataButton_Click(sender As Object, e As EventArgs) Handles BatchYearlyDataButton.Click
            MyProject.Forms.BatchYearlyDataForm.ShowDialog()
        End Sub

        Private Sub BatchTorihikiBulkChangeButton_Click(sender As Object, e As EventArgs) Handles BatchTorihikiBulkChangeButton.Click
            MyProject.Forms.BatchHaraiDataWritForm.ShowDialog()
        End Sub

        Private Sub CreatDataBuhinSubButton_Click(sender As Object, e As EventArgs) Handles CreatDataBuhinSubButton.Click

        End Sub
    End Class
End Namespace
