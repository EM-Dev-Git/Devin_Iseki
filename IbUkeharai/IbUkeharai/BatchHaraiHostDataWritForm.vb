Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Dialogs
Imports IbUkeharai.IbUkeharai.BatchExec
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class BatchHaraiHostDataWritForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.BatchHaraiDataWritForm_Load
            Me.receiveFtpDir = Path.Combine("FTP", "41.払出書き込み(ホスト)")
            Me.outPutDir = Path.Combine("kekka", "41.払出書き込み(ホスト)")
            Me.backupDir = Path.Combine("backup", "haraidashi_H")
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
            Me.FormTitleLabel = New Label()
            Me.Label1 = New Label()
            Me.BHDW_BackButton = New Button()
            Me.BHDW_ExecutButton = New Button()
            Me.DataReceiveButton = New Button()
            Me.BHDW_ReloadButton = New Button()
            Me.ResultGroupBox = New GroupBox()
            Me.G_Count_Label = New Label()
            Me.G_Money_Label = New Label()
            Me.G_Kosu_Label = New Label()
            Me.G_Kojo_Label = New Label()
            Me.S_Count_Label = New Label()
            Me.S_Money_Label = New Label()
            Me.S_Kosu_Label = New Label()
            Me.S_BuhinCD_Label = New Label()
            Me.S_ToriCD_Label = New Label()
            Me.S_Kojo_Label = New Label()
            Me.IB_Count_Label = New Label()
            Me.IB_Money_Label = New Label()
            Me.IB_Kosu_Label = New Label()
            Me.IB_BuhinCD_Label = New Label()
            Me.IB_ToriCD_Label = New Label()
            Me.IB_Kojo_Label = New Label()
            Me.IK_Count_Label = New Label()
            Me.IK_Money_Label = New Label()
            Me.IK_Kosu_Label = New Label()
            Me.IK_BuhinCD_Label = New Label()
            Me.IK_ToriCD_Label = New Label()
            Me.IK_Kojo_Label = New Label()
            Me.H_Count_Label = New Label()
            Me.H_Money_Label = New Label()
            Me.H_Kosu_Label = New Label()
            Me.H_BuhinCD_Label = New Label()
            Me.H_ToriCD_Label = New Label()
            Me.H_Kojo_Label = New Label()
            Me.K_Count_Label = New Label()
            Me.K_Money_Label = New Label()
            Me.K_Kosu_Label = New Label()
            Me.K_BuhinCD_Label = New Label()
            Me.K_ToriCD_Label = New Label()
            Me.K_Kojo_Label = New Label()
            Me.M_Count_Label = New Label()
            Me.M_Money_Label = New Label()
            Me.M_Kosu_Label = New Label()
            Me.M_BuhinCD_Label = New Label()
            Me.M_ToriCD_Label = New Label()
            Me.M_Kojo_Label = New Label()
            Me.Label2 = New Label()
            Me.ReceiveGroupBox = New GroupBox()
            Me.ResultGroupBox.SuspendLayout()
            Me.ReceiveGroupBox.SuspendLayout()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.FormTitleLabel.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(760, 45)
            Me.FormTitleLabel.TabIndex = 6
            Me.FormTitleLabel.Text = "払出データ書き込み（ホスト）"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Label1.Location = New Point(60, 69)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(433, 44)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "払出データを受信します。" & ChrW(13) & ChrW(10) & "払出データ書き込みを実行する前に、払出データの受信を行ってください。"
            '
            'BHDW_BackButton
            '
            Me.BHDW_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.BHDW_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BHDW_BackButton.Location = New Point(687, 520)
            Me.BHDW_BackButton.Name = "BHDW_BackButton"
            Me.BHDW_BackButton.Size = New Size(80, 30)
            Me.BHDW_BackButton.TabIndex = 3
            Me.BHDW_BackButton.Text = "戻る"
            Me.BHDW_BackButton.UseVisualStyleBackColor = True
            '
            'BHDW_ExecutButton
            '
            Me.BHDW_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.BHDW_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BHDW_ExecutButton.Location = New Point(482, 520)
            Me.BHDW_ExecutButton.Name = "BHDW_ExecutButton"
            Me.BHDW_ExecutButton.Size = New Size(80, 30)
            Me.BHDW_ExecutButton.TabIndex = 1
            Me.BHDW_ExecutButton.Text = "実行"
            Me.BHDW_ExecutButton.UseVisualStyleBackColor = True
            '
            'DataReceiveButton
            '
            Me.DataReceiveButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.DataReceiveButton.Location = New Point(18, 24)
            Me.DataReceiveButton.Name = "DataReceiveButton"
            Me.DataReceiveButton.Size = New Size(124, 41)
            Me.DataReceiveButton.TabIndex = 0
            Me.DataReceiveButton.Text = "データ受信"
            Me.DataReceiveButton.UseVisualStyleBackColor = True
            '
            'BHDW_ReloadButton
            '
            Me.BHDW_ReloadButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.BHDW_ReloadButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BHDW_ReloadButton.Location = New Point(568, 520)
            Me.BHDW_ReloadButton.Name = "BHDW_ReloadButton"
            Me.BHDW_ReloadButton.Size = New Size(113, 30)
            Me.BHDW_ReloadButton.TabIndex = 2
            Me.BHDW_ReloadButton.Text = "再取込み(エラー)"
            Me.BHDW_ReloadButton.UseVisualStyleBackColor = True
            '
            'ResultGroupBox
            '
            Me.ResultGroupBox.Controls.Add(Me.G_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.G_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.G_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.G_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.S_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.IB_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.IK_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.H_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.K_Kojo_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_Count_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_Money_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_Kosu_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_BuhinCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_ToriCD_Label)
            Me.ResultGroupBox.Controls.Add(Me.M_Kojo_Label)
            Me.ResultGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ResultGroupBox.Location = New Point(63, 294)
            Me.ResultGroupBox.Name = "ResultGroupBox"
            Me.ResultGroupBox.Size = New Size(618, 178)
            Me.ResultGroupBox.TabIndex = 10
            Me.ResultGroupBox.TabStop = False
            Me.ResultGroupBox.Text = "取込み結果"
            '
            'G_Count_Label
            '
            Me.G_Count_Label.Location = New Point(535, 155)
            Me.G_Count_Label.Name = "G_Count_Label"
            Me.G_Count_Label.Size = New Size(80, 20)
            Me.G_Count_Label.TabIndex = 39
            Me.G_Count_Label.Text = "ZZ,ZZ9"
            '
            'G_Money_Label
            '
            Me.G_Money_Label.Location = New Point(409, 155)
            Me.G_Money_Label.Name = "G_Money_Label"
            Me.G_Money_Label.Size = New Size(120, 20)
            Me.G_Money_Label.TabIndex = 38
            Me.G_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'G_Kosu_Label
            '
            Me.G_Kosu_Label.Location = New Point(313, 155)
            Me.G_Kosu_Label.Name = "G_Kosu_Label"
            Me.G_Kosu_Label.Size = New Size(80, 20)
            Me.G_Kosu_Label.TabIndex = 37
            Me.G_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'G_Kojo_Label
            '
            Me.G_Kojo_Label.Location = New Point(6, 155)
            Me.G_Kojo_Label.Name = "G_Kojo_Label"
            Me.G_Kojo_Label.Size = New Size(80, 20)
            Me.G_Kojo_Label.TabIndex = 36
            Me.G_Kojo_Label.Text = "合計"
            '
            'S_Count_Label
            '
            Me.S_Count_Label.Location = New Point(535, 135)
            Me.S_Count_Label.Name = "S_Count_Label"
            Me.S_Count_Label.Size = New Size(80, 20)
            Me.S_Count_Label.TabIndex = 35
            Me.S_Count_Label.Text = "ZZ,ZZ9"
            '
            'S_Money_Label
            '
            Me.S_Money_Label.Location = New Point(409, 135)
            Me.S_Money_Label.Name = "S_Money_Label"
            Me.S_Money_Label.Size = New Size(120, 20)
            Me.S_Money_Label.TabIndex = 34
            Me.S_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'S_Kosu_Label
            '
            Me.S_Kosu_Label.Location = New Point(313, 135)
            Me.S_Kosu_Label.Name = "S_Kosu_Label"
            Me.S_Kosu_Label.Size = New Size(80, 20)
            Me.S_Kosu_Label.TabIndex = 33
            Me.S_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'S_BuhinCD_Label
            '
            Me.S_BuhinCD_Label.Location = New Point(178, 135)
            Me.S_BuhinCD_Label.Name = "S_BuhinCD_Label"
            Me.S_BuhinCD_Label.Size = New Size(120, 20)
            Me.S_BuhinCD_Label.TabIndex = 32
            Me.S_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'S_ToriCD_Label
            '
            Me.S_ToriCD_Label.Location = New Point(92, 135)
            Me.S_ToriCD_Label.Name = "S_ToriCD_Label"
            Me.S_ToriCD_Label.Size = New Size(80, 20)
            Me.S_ToriCD_Label.TabIndex = 31
            Me.S_ToriCD_Label.Text = "XXXXXXXX"
            '
            'S_Kojo_Label
            '
            Me.S_Kojo_Label.Location = New Point(6, 135)
            Me.S_Kojo_Label.Name = "S_Kojo_Label"
            Me.S_Kojo_Label.Size = New Size(80, 20)
            Me.S_Kojo_Label.TabIndex = 30
            Me.S_Kojo_Label.Text = "その他"
            '
            'IB_Count_Label
            '
            Me.IB_Count_Label.Location = New Point(535, 115)
            Me.IB_Count_Label.Name = "IB_Count_Label"
            Me.IB_Count_Label.Size = New Size(80, 20)
            Me.IB_Count_Label.TabIndex = 29
            Me.IB_Count_Label.Text = "ZZ,ZZ9"
            '
            'IB_Money_Label
            '
            Me.IB_Money_Label.Location = New Point(409, 115)
            Me.IB_Money_Label.Name = "IB_Money_Label"
            Me.IB_Money_Label.Size = New Size(120, 20)
            Me.IB_Money_Label.TabIndex = 28
            Me.IB_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'IB_Kosu_Label
            '
            Me.IB_Kosu_Label.Location = New Point(313, 115)
            Me.IB_Kosu_Label.Name = "IB_Kosu_Label"
            Me.IB_Kosu_Label.Size = New Size(80, 20)
            Me.IB_Kosu_Label.TabIndex = 27
            Me.IB_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'IB_BuhinCD_Label
            '
            Me.IB_BuhinCD_Label.Location = New Point(178, 115)
            Me.IB_BuhinCD_Label.Name = "IB_BuhinCD_Label"
            Me.IB_BuhinCD_Label.Size = New Size(120, 20)
            Me.IB_BuhinCD_Label.TabIndex = 26
            Me.IB_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'IB_ToriCD_Label
            '
            Me.IB_ToriCD_Label.Location = New Point(92, 115)
            Me.IB_ToriCD_Label.Name = "IB_ToriCD_Label"
            Me.IB_ToriCD_Label.Size = New Size(80, 20)
            Me.IB_ToriCD_Label.TabIndex = 25
            Me.IB_ToriCD_Label.Text = "XXXXXXXX"
            '
            'IB_Kojo_Label
            '
            Me.IB_Kojo_Label.Location = New Point(6, 115)
            Me.IB_Kojo_Label.Name = "IB_Kojo_Label"
            Me.IB_Kojo_Label.Size = New Size(80, 20)
            Me.IB_Kojo_Label.TabIndex = 24
            Me.IB_Kojo_Label.Text = "井関部品部"
            '
            'IK_Count_Label
            '
            Me.IK_Count_Label.Location = New Point(535, 95)
            Me.IK_Count_Label.Name = "IK_Count_Label"
            Me.IK_Count_Label.Size = New Size(80, 20)
            Me.IK_Count_Label.TabIndex = 23
            Me.IK_Count_Label.Text = "ZZ,ZZ9"
            '
            'IK_Money_Label
            '
            Me.IK_Money_Label.Location = New Point(409, 95)
            Me.IK_Money_Label.Name = "IK_Money_Label"
            Me.IK_Money_Label.Size = New Size(120, 20)
            Me.IK_Money_Label.TabIndex = 22
            Me.IK_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'IK_Kosu_Label
            '
            Me.IK_Kosu_Label.Location = New Point(313, 95)
            Me.IK_Kosu_Label.Name = "IK_Kosu_Label"
            Me.IK_Kosu_Label.Size = New Size(80, 20)
            Me.IK_Kosu_Label.TabIndex = 21
            Me.IK_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'IK_BuhinCD_Label
            '
            Me.IK_BuhinCD_Label.Location = New Point(178, 95)
            Me.IK_BuhinCD_Label.Name = "IK_BuhinCD_Label"
            Me.IK_BuhinCD_Label.Size = New Size(120, 20)
            Me.IK_BuhinCD_Label.TabIndex = 20
            Me.IK_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'IK_ToriCD_Label
            '
            Me.IK_ToriCD_Label.Location = New Point(92, 95)
            Me.IK_ToriCD_Label.Name = "IK_ToriCD_Label"
            Me.IK_ToriCD_Label.Size = New Size(80, 20)
            Me.IK_ToriCD_Label.TabIndex = 19
            Me.IK_ToriCD_Label.Text = "XXXXXXXX"
            '
            'IK_Kojo_Label
            '
            Me.IK_Kojo_Label.Location = New Point(6, 95)
            Me.IK_Kojo_Label.Name = "IK_Kojo_Label"
            Me.IK_Kojo_Label.Size = New Size(80, 20)
            Me.IK_Kojo_Label.TabIndex = 18
            Me.IK_Kojo_Label.Text = "井関購買部"
            '
            'H_Count_Label
            '
            Me.H_Count_Label.Location = New Point(535, 75)
            Me.H_Count_Label.Name = "H_Count_Label"
            Me.H_Count_Label.Size = New Size(80, 20)
            Me.H_Count_Label.TabIndex = 17
            Me.H_Count_Label.Text = "ZZ,ZZ9"
            '
            'H_Money_Label
            '
            Me.H_Money_Label.Location = New Point(409, 75)
            Me.H_Money_Label.Name = "H_Money_Label"
            Me.H_Money_Label.Size = New Size(120, 20)
            Me.H_Money_Label.TabIndex = 16
            Me.H_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'H_Kosu_Label
            '
            Me.H_Kosu_Label.Location = New Point(313, 75)
            Me.H_Kosu_Label.Name = "H_Kosu_Label"
            Me.H_Kosu_Label.Size = New Size(80, 20)
            Me.H_Kosu_Label.TabIndex = 15
            Me.H_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'H_BuhinCD_Label
            '
            Me.H_BuhinCD_Label.Location = New Point(178, 75)
            Me.H_BuhinCD_Label.Name = "H_BuhinCD_Label"
            Me.H_BuhinCD_Label.Size = New Size(120, 20)
            Me.H_BuhinCD_Label.TabIndex = 14
            Me.H_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'H_ToriCD_Label
            '
            Me.H_ToriCD_Label.Location = New Point(92, 75)
            Me.H_ToriCD_Label.Name = "H_ToriCD_Label"
            Me.H_ToriCD_Label.Size = New Size(80, 20)
            Me.H_ToriCD_Label.TabIndex = 13
            Me.H_ToriCD_Label.Text = "XXXXXXXX"
            '
            'H_Kojo_Label
            '
            Me.H_Kojo_Label.Location = New Point(6, 75)
            Me.H_Kojo_Label.Name = "H_Kojo_Label"
            Me.H_Kojo_Label.Size = New Size(80, 20)
            Me.H_Kojo_Label.TabIndex = 12
            Me.H_Kojo_Label.Text = "邦栄製造所"
            '
            'K_Count_Label
            '
            Me.K_Count_Label.Location = New Point(535, 55)
            Me.K_Count_Label.Name = "K_Count_Label"
            Me.K_Count_Label.Size = New Size(80, 20)
            Me.K_Count_Label.TabIndex = 11
            Me.K_Count_Label.Text = "ZZ,ZZ9"
            '
            'K_Money_Label
            '
            Me.K_Money_Label.Location = New Point(409, 55)
            Me.K_Money_Label.Name = "K_Money_Label"
            Me.K_Money_Label.Size = New Size(120, 20)
            Me.K_Money_Label.TabIndex = 10
            Me.K_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'K_Kosu_Label
            '
            Me.K_Kosu_Label.Location = New Point(313, 55)
            Me.K_Kosu_Label.Name = "K_Kosu_Label"
            Me.K_Kosu_Label.Size = New Size(80, 20)
            Me.K_Kosu_Label.TabIndex = 9
            Me.K_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'K_BuhinCD_Label
            '
            Me.K_BuhinCD_Label.Location = New Point(178, 55)
            Me.K_BuhinCD_Label.Name = "K_BuhinCD_Label"
            Me.K_BuhinCD_Label.Size = New Size(120, 20)
            Me.K_BuhinCD_Label.TabIndex = 8
            Me.K_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'K_ToriCD_Label
            '
            Me.K_ToriCD_Label.Location = New Point(92, 55)
            Me.K_ToriCD_Label.Name = "K_ToriCD_Label"
            Me.K_ToriCD_Label.Size = New Size(80, 20)
            Me.K_ToriCD_Label.TabIndex = 7
            Me.K_ToriCD_Label.Text = "XXXXXXXX"
            '
            'K_Kojo_Label
            '
            Me.K_Kojo_Label.Location = New Point(6, 55)
            Me.K_Kojo_Label.Name = "K_Kojo_Label"
            Me.K_Kojo_Label.Size = New Size(80, 20)
            Me.K_Kojo_Label.TabIndex = 6
            Me.K_Kojo_Label.Text = "熊本製造所"
            '
            'M_Count_Label
            '
            Me.M_Count_Label.Location = New Point(535, 35)
            Me.M_Count_Label.Name = "M_Count_Label"
            Me.M_Count_Label.Size = New Size(80, 20)
            Me.M_Count_Label.TabIndex = 5
            Me.M_Count_Label.Text = "ZZ,ZZ9"
            '
            'M_Money_Label
            '
            Me.M_Money_Label.Location = New Point(409, 35)
            Me.M_Money_Label.Name = "M_Money_Label"
            Me.M_Money_Label.Size = New Size(120, 20)
            Me.M_Money_Label.TabIndex = 4
            Me.M_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
            '
            'M_Kosu_Label
            '
            Me.M_Kosu_Label.Location = New Point(313, 35)
            Me.M_Kosu_Label.Name = "M_Kosu_Label"
            Me.M_Kosu_Label.Size = New Size(80, 20)
            Me.M_Kosu_Label.TabIndex = 3
            Me.M_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
            '
            'M_BuhinCD_Label
            '
            Me.M_BuhinCD_Label.Location = New Point(178, 35)
            Me.M_BuhinCD_Label.Name = "M_BuhinCD_Label"
            Me.M_BuhinCD_Label.Size = New Size(120, 20)
            Me.M_BuhinCD_Label.TabIndex = 2
            Me.M_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
            '
            'M_ToriCD_Label
            '
            Me.M_ToriCD_Label.Location = New Point(92, 35)
            Me.M_ToriCD_Label.Name = "M_ToriCD_Label"
            Me.M_ToriCD_Label.Size = New Size(80, 20)
            Me.M_ToriCD_Label.TabIndex = 1
            Me.M_ToriCD_Label.Text = "XXXXXXXX"
            '
            'M_Kojo_Label
            '
            Me.M_Kojo_Label.Location = New Point(6, 35)
            Me.M_Kojo_Label.Name = "M_Kojo_Label"
            Me.M_Kojo_Label.Size = New Size(80, 20)
            Me.M_Kojo_Label.TabIndex = 0
            Me.M_Kojo_Label.Text = "松山製造所"
            '
            'Label2
            '
            Me.Label2.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Label2.Location = New Point(60, 211)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(433, 80)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "払出データの受信は終わりましたか？" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "データ受信済みなら「実行」ボタンを押してください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "未受信なら「データ受信」ボタンを押してデータ受信して下さい。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "エラー" &
    "ファイルを取り込む場合は、「再取込み」ボタンを押してください。"
            '
            'ReceiveGroupBox
            '
            Me.ReceiveGroupBox.Controls.Add(Me.DataReceiveButton)
            Me.ReceiveGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ReceiveGroupBox.Location = New Point(63, 116)
            Me.ReceiveGroupBox.Name = "ReceiveGroupBox"
            Me.ReceiveGroupBox.Size = New Size(159, 76)
            Me.ReceiveGroupBox.TabIndex = 0
            Me.ReceiveGroupBox.TabStop = False
            Me.ReceiveGroupBox.Text = "データ受信"
            '
            'BatchHaraiHostDataWritForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(784, 562)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.ResultGroupBox)
            Me.Controls.Add(Me.BHDW_ReloadButton)
            Me.Controls.Add(Me.ReceiveGroupBox)
            Me.Controls.Add(Me.BHDW_BackButton)
            Me.Controls.Add(Me.BHDW_ExecutButton)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.FormTitleLabel)
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "BatchHaraiHostDataWritForm"
            Me.Text = "払出データ書き込み"
            Me.ResultGroupBox.ResumeLayout(False)
            Me.ReceiveGroupBox.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub BatchHaraiDataWritForm_Load(sender As Object, e As EventArgs)
            Me.ResultGroupBox.Hide()
        End Sub

        Private Sub SetFTPparams(host As HostDataReceive)
            host._ftpMatuyamaFile = "SN41M00.TXT"
            host._ftpBackMatuyamaFile = "SN40M00.TXT"
            host._ftpMatuyamaMFile = "SN41M00.TXT"
            host._ftpBackMatuyamaMFile = "SN40M00.TXT"
            host._ftpMatuyamaKFile = "SN41K00.TXT"
            host._ftpBackMatuyamaKFile = "SN40K00.TXT"
            host._ftpMatuyamaSFile = "SN41S00.TXT"
            host._ftpBackMatuyamaSFile = "SN40S00.TXT"
            host._ftpMatuyamaBFile = "SN41B00.TXT"
            host._ftpBackMatuyamaBFile = "SN40B00.TXT"
            host._ftpKumamotoFile = "SN41Q00.TXT"
            host._ftpBackKumamotoFile = "SN40Q00.TXT"
            Dim ftpSaveFolder As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
            host._ftpSaveFolder = ftpSaveFolder
            host._ftpSaveFile = "SN41A00"
            host._ftpNullFile = "初期化用.txt"
        End Sub

        Private Sub SetHaraiWritParam(harai As UkeHaraiDataWrit)
            harai._configData = TopForm.ConfigData
            harai._funcName = "BatchHaraiHostDataWrit"
            harai._ukeharaiKubun = "2"
            harai._fixcount = 2
            Dim outPutFolder As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
            harai._outPutFolder = outPutFolder
            harai._okFileName = "SN41AOK"
            harai._errFileName = "SN41AER"
            harai._fixBackCount = 2
            Dim backUpFolder As String = Path.Combine(FileSystem.CurDir(), Me.backupDir)
            harai._backUpFolder = backUpFolder
        End Sub

        Private Function GetKyotenNo(kyoten As String) As Integer
            If Operators.CompareString(kyoten, "Matsuyama", False) = 0 Then
                Return 1
            End If
            If Operators.CompareString(kyoten, "Kumamoto", False) = 0 Then
                Return 2
            End If
            Return 0
        End Function

        Private Function GetRetryFilePath() As String
            Dim result As String = Nothing
            Dim openFileDialog As New OpenFileDialog()
            Dim initialDirectory As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
            openFileDialog.InitialDirectory = initialDirectory
            openFileDialog.Title = "再取込みするエラーファイルを選択してください。"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                result = openFileDialog.FileName
            End If
            Return result
        End Function

        Private Sub ShowViewInfo(viewInfo As Dictionary(Of Integer, UkeHaraiDataWrit.viewInfo))
            Dim num As Integer = 1
            Dim count As Integer = viewInfo.Count
            For i As Integer = num To count
                Select Case i
                    Case 1
                        Me.SetMatuyamaInfo(viewInfo(i))
                    Case 2
                        Me.SetKumamotoInfo(viewInfo(i))
                    Case 3
                        Me.SetHoueiInfo(viewInfo(i))
                    Case 4
                        Me.SetIsekiKoubaiInfo(viewInfo(i))
                    Case 5
                        Me.SetIsekiBuhinInfo(viewInfo(i))
                    Case 6
                        Me.SetSonotaInfo(viewInfo(i))
                    Case 7
                        Me.SetTotaleInfo(viewInfo(i))
                End Select
            Next
            Me.ResultGroupBox.Show()
        End Sub

        Private Sub SetMatuyamaInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.M_ToriCD_Label.Text = info.tori_cd
            Me.M_BuhinCD_Label.Text = info.buhin_cd
            Me.M_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.M_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.M_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetKumamotoInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.K_ToriCD_Label.Text = info.tori_cd
            Me.K_BuhinCD_Label.Text = info.buhin_cd
            Me.K_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.K_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.K_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetHoueiInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.H_ToriCD_Label.Text = info.tori_cd
            Me.H_BuhinCD_Label.Text = info.buhin_cd
            Me.H_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.H_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.H_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetIsekiKoubaiInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.IK_ToriCD_Label.Text = info.tori_cd
            Me.IK_BuhinCD_Label.Text = info.buhin_cd
            Me.IK_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.IK_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.IK_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetIsekiBuhinInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.IB_ToriCD_Label.Text = info.tori_cd
            Me.IB_BuhinCD_Label.Text = info.buhin_cd
            Me.IB_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.IB_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.IB_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetSonotaInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.S_ToriCD_Label.Text = info.tori_cd
            Me.S_BuhinCD_Label.Text = info.buhin_cd
            Me.S_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.S_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.S_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Sub SetTotaleInfo(info As UkeHaraiDataWrit.viewInfo)
            Me.G_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
            Me.G_Money_Label.Text = Me.ConvertViewNumber(info.money)
            Me.G_Count_Label.Text = Me.ConvertViewNumber(info.count)
        End Sub

        Private Function ConvertViewNumber(num As Integer) As String
            Return String.Format("{0:#,0}", num)
        End Function


        Private components As IContainer

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("Label1")>
        Private WithEvents Label1 As Label

        <AccessedThroughProperty("BHDW_BackButton")>
        Private WithEvents BHDW_BackButton As Button

        <AccessedThroughProperty("BHDW_ExecutButton")>
        Private WithEvents BHDW_ExecutButton As Button

        <AccessedThroughProperty("DataReceiveButton")>
        Private WithEvents DataReceiveButton As Button

        <AccessedThroughProperty("BHDW_ReloadButton")>
        Private WithEvents BHDW_ReloadButton As Button

        <AccessedThroughProperty("ResultGroupBox")>
        Private WithEvents ResultGroupBox As GroupBox

        <AccessedThroughProperty("G_Count_Label")>
        Private WithEvents G_Count_Label As Label

        <AccessedThroughProperty("G_Money_Label")>
        Private WithEvents G_Money_Label As Label

        <AccessedThroughProperty("G_Kosu_Label")>
        Private WithEvents G_Kosu_Label As Label

        <AccessedThroughProperty("G_Kojo_Label")>
        Private WithEvents G_Kojo_Label As Label

        <AccessedThroughProperty("S_Count_Label")>
        Private WithEvents S_Count_Label As Label

        <AccessedThroughProperty("S_Money_Label")>
        Private WithEvents S_Money_Label As Label

        <AccessedThroughProperty("S_Kosu_Label")>
        Private WithEvents S_Kosu_Label As Label

        <AccessedThroughProperty("S_BuhinCD_Label")>
        Private WithEvents S_BuhinCD_Label As Label

        <AccessedThroughProperty("S_ToriCD_Label")>
        Private WithEvents S_ToriCD_Label As Label

        <AccessedThroughProperty("S_Kojo_Label")>
        Private WithEvents S_Kojo_Label As Label

        <AccessedThroughProperty("IB_Count_Label")>
        Private WithEvents IB_Count_Label As Label

        <AccessedThroughProperty("IB_Money_Label")>
        Private WithEvents IB_Money_Label As Label

        <AccessedThroughProperty("IB_Kosu_Label")>
        Private WithEvents IB_Kosu_Label As Label

        <AccessedThroughProperty("IB_BuhinCD_Label")>
        Private WithEvents IB_BuhinCD_Label As Label

        <AccessedThroughProperty("IB_ToriCD_Label")>
        Private WithEvents IB_ToriCD_Label As Label

        <AccessedThroughProperty("IB_Kojo_Label")>
        Private WithEvents IB_Kojo_Label As Label

        <AccessedThroughProperty("IK_Count_Label")>
        Private WithEvents IK_Count_Label As Label

        <AccessedThroughProperty("IK_Money_Label")>
        Private WithEvents IK_Money_Label As Label

        <AccessedThroughProperty("IK_Kosu_Label")>
        Private WithEvents IK_Kosu_Label As Label

        <AccessedThroughProperty("IK_BuhinCD_Label")>
        Private WithEvents IK_BuhinCD_Label As Label

        <AccessedThroughProperty("IK_ToriCD_Label")>
        Private WithEvents IK_ToriCD_Label As Label

        <AccessedThroughProperty("IK_Kojo_Label")>
        Private WithEvents IK_Kojo_Label As Label

        <AccessedThroughProperty("H_Count_Label")>
        Private WithEvents H_Count_Label As Label

        <AccessedThroughProperty("H_Money_Label")>
        Private WithEvents H_Money_Label As Label

        <AccessedThroughProperty("H_Kosu_Label")>
        Private WithEvents H_Kosu_Label As Label

        <AccessedThroughProperty("H_BuhinCD_Label")>
        Private WithEvents H_BuhinCD_Label As Label

        <AccessedThroughProperty("H_ToriCD_Label")>
        Private WithEvents H_ToriCD_Label As Label

        <AccessedThroughProperty("H_Kojo_Label")>
        Private WithEvents H_Kojo_Label As Label

        <AccessedThroughProperty("K_Count_Label")>
        Private WithEvents K_Count_Label As Label

        <AccessedThroughProperty("K_Money_Label")>
        Private WithEvents K_Money_Label As Label

        <AccessedThroughProperty("K_Kosu_Label")>
        Private WithEvents K_Kosu_Label As Label

        <AccessedThroughProperty("K_BuhinCD_Label")>
        Private WithEvents K_BuhinCD_Label As Label

        <AccessedThroughProperty("K_ToriCD_Label")>
        Private WithEvents K_ToriCD_Label As Label

        <AccessedThroughProperty("K_Kojo_Label")>
        Private WithEvents K_Kojo_Label As Label

        <AccessedThroughProperty("M_Count_Label")>
        Private WithEvents M_Count_Label As Label

        <AccessedThroughProperty("M_Money_Label")>
        Private WithEvents M_Money_Label As Label

        <AccessedThroughProperty("M_Kosu_Label")>
        Private WithEvents M_Kosu_Label As Label

        <AccessedThroughProperty("M_BuhinCD_Label")>
        Private WithEvents M_BuhinCD_Label As Label

        <AccessedThroughProperty("M_ToriCD_Label")>
        Private WithEvents M_ToriCD_Label As Label

        <AccessedThroughProperty("M_Kojo_Label")>
        Private WithEvents M_Kojo_Label As Label

        <AccessedThroughProperty("Label2")>
        Private WithEvents Label2 As Label

        <AccessedThroughProperty("ReceiveGroupBox")>
        Private WithEvents ReceiveGroupBox As GroupBox

        Private Const FTP_FILE_MATUYAMA As String = "SN41M00.TXT"

        Private Const FTP_BACKUP_FILE_MATUYAMA As String = "SN40M00.TXT"

        Private Const FTP_FILE_MATUYAMA_M As String = "SN41M00.TXT"

        Private Const FTP_BACKUP_FILE_MATUYAMA_M As String = "SN40M00.TXT"

        Private Const FTP_FILE_MATUYAMA_K As String = "SN41K00.TXT"

        Private Const FTP_BACKUP_FILE_MATUYAMA_K As String = "SN40K00.TXT"

        Private Const FTP_FILE_MATUYAMA_S As String = "SN41S00.TXT"

        Private Const FTP_BACKUP_FILE_MATUYAMA_S As String = "SN40S00.TXT"

        Private Const FTP_FILE_MATUYAMA_B As String = "SN41B00.TXT"

        Private Const FTP_BACKUP_FILE_MATUYAMA_B As String = "SN40B00.TXT"

        Private Const FTP_FILE_KUMAMOTO As String = "SN41Q00.TXT"

        Private Const FTP_BACKUP_FILE_KUMAMOTO As String = "SN40Q00.TXT"

        Private receiveFtpDir As String

        Private Const SAVE_FILE_NAME As String = "SN41A00"

        Private Const NULL_FILE_NAME As String = "初期化用.txt"

        Private Const EXEC_FUNC_NAME As String = "BatchHaraiHostDataWrit"

        Private Const UKEHARAI_KUBUN As String = "2"

        Private Const FIX_FILE_COUNT As Integer = 2

        Private outPutDir As String

        Private Const OK_FILE_NAME As String = "SN41AOK"

        Private Const ERR_FILE_NAME As String = "SN41AER"

        Private Const FIX_BACKFILE_COUNT As Integer = 2

        Private backupDir As String


        Private Sub DataReceiveButton_Click(sender As Object, e As EventArgs) Handles DataReceiveButton.Click
            Dim dialogResult As DialogResult = MessageBox.Show("FTPサーバからデータを受信します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            Dim hostDataReceive As New HostDataReceive()
            Me.SetFTPparams(hostDataReceive)
            If Not hostDataReceive.Exec() Then
                DlgMessageBox.Show("ホストデータ受信処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                DlgMessageBox.Show("ホストデータ受信処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        End Sub

        Private Sub BHDW_ExecutButton_Click(sender As Object, e As EventArgs) Handles BHDW_ExecutButton.Click
            Cursor.Current = Cursors.WaitCursor
            Dim path1 As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
            Dim path2 As String = Path.Combine(path1, "SN41A00")
            Dim ukeHaraiDataWrit As New UkeHaraiDataWrit()
            Me.SetHaraiWritParam(ukeHaraiDataWrit)
            If ukeHaraiDataWrit.WritDataExec(path2) Then
                DlgMessageBox.Show("払出データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
                Dim viewInfo As Dictionary(Of Integer, UkeHaraiDataWrit.viewInfo) = ukeHaraiDataWrit.GetViewInfo()
                Me.ShowViewInfo(viewInfo)
            Else
                DlgMessageBox.Show("払出データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        End Sub

        Private Sub BHDW_ReloadButton_Click(sender As Object, e As EventArgs) Handles BHDW_ReloadButton.Click
            Dim retryFilePath As String = Me.GetRetryFilePath()
            If IsNothing(retryFilePath) Then
                Return
            End If
            Dim ukeHaraiDataWrit As New UkeHaraiDataWrit()
            Me.SetHaraiWritParam(ukeHaraiDataWrit)
            If ukeHaraiDataWrit.RetryWritDataExec(retryFilePath) Then
                DlgMessageBox.Show("払出データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
                Dim viewInfo As Dictionary(Of Integer, UkeHaraiDataWrit.viewInfo) = ukeHaraiDataWrit.GetViewInfo()
                Me.ShowViewInfo(viewInfo)
            Else
                DlgMessageBox.Show("払出データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.ResultGroupBox.Hide()
            End If
        End Sub

        Private Sub BHDW_BackButton_Click(sender As Object, e As EventArgs) Handles BHDW_BackButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
