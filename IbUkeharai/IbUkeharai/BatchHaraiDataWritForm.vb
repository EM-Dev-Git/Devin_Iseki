Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.BatchExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class BatchHaraiDataWritForm
		Inherits Form


		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.BatchHaraiDataWritForm_FormClosing
			AddHandler MyBase.Load, AddressOf Me.BatchTorihikiBulkChangeForm_Load
			Me.outPutDir = Path.Combine("kekka", "45.払出書き込み")
			Me.backupDir = Path.Combine("backup", "haraidashi")
			Me._haraicolum = New String() {"払出年月日", "取引先コード", "部品コード", "数量", "伝票NO", "納入先", "納入金額", "手数料単価", "備考１", "備考２", "備考３"}
			Me._viewInfo = Nothing
			Me._okTable = Nothing
			Me._errTable = Nothing
			Me._configData = Nothing
			Me.FlgMemory = False
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
			Me.BTC_BackButton = New Button()
			Me.BTC_ReloadButton = New Button()
			Me.BTC_ExecutButton = New Button()
			Me.ResultGroupBox = New GroupBox()
			Me.Err_Count_Label = New Label()
			Me.G_Count_Label = New Label()
			Me.G_Money_Label = New Label()
			Me.Err_Money_Label = New Label()
			Me.G_Kosu_Label = New Label()
			Me.G_Kojo_Label = New Label()
			Me.Err_Kosu_Label = New Label()
			Me.S_Count_Label = New Label()
			Me.S_Money_Label = New Label()
			Me.Err_BuhinCD_Label = New Label()
			Me.S_Kosu_Label = New Label()
			Me.Err_ToriCD_Label = New Label()
			Me.S_BuhinCD_Label = New Label()
			Me.S_ToriCD_Label = New Label()
			Me.Err_Kojo_Label = New Label()
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
			Me.Label1 = New Label()
			Me.ChkMemory = New CheckBox()
			Me.ResultGroupBox.SuspendLayout()
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
			Me.FormTitleLabel.TabIndex = 8
			Me.FormTitleLabel.Text = "払出データ書き込み"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'BTC_BackButton
			'
			Me.BTC_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BTC_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BTC_BackButton.Location = New Point(687, 520)
			Me.BTC_BackButton.Name = "BTC_BackButton"
			Me.BTC_BackButton.Size = New Size(80, 30)
			Me.BTC_BackButton.TabIndex = 52
			Me.BTC_BackButton.Tag = "3"
			Me.BTC_BackButton.Text = "戻る"
			Me.BTC_BackButton.UseVisualStyleBackColor = True
			'
			'BTC_ReloadButton
			'
			Me.BTC_ReloadButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BTC_ReloadButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BTC_ReloadButton.Location = New Point(601, 520)
			Me.BTC_ReloadButton.Name = "BTC_ReloadButton"
			Me.BTC_ReloadButton.Size = New Size(80, 30)
			Me.BTC_ReloadButton.TabIndex = 51
			Me.BTC_ReloadButton.Tag = "2"
			Me.BTC_ReloadButton.Text = "再取込み"
			Me.BTC_ReloadButton.UseVisualStyleBackColor = True
			'
			'BTC_ExecutButton
			'
			Me.BTC_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BTC_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BTC_ExecutButton.Location = New Point(515, 520)
			Me.BTC_ExecutButton.Name = "BTC_ExecutButton"
			Me.BTC_ExecutButton.Size = New Size(80, 30)
			Me.BTC_ExecutButton.TabIndex = 50
			Me.BTC_ExecutButton.Tag = "1"
			Me.BTC_ExecutButton.Text = "実行"
			Me.BTC_ExecutButton.UseVisualStyleBackColor = True
			'
			'ResultGroupBox
			'
			Me.ResultGroupBox.Controls.Add(Me.Err_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Money_Label)
			Me.ResultGroupBox.Controls.Add(Me.Err_Money_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.G_Kojo_Label)
			Me.ResultGroupBox.Controls.Add(Me.Err_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.S_Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.S_Money_Label)
			Me.ResultGroupBox.Controls.Add(Me.Err_BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.S_Kosu_Label)
			Me.ResultGroupBox.Controls.Add(Me.Err_ToriCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.S_BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.S_ToriCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.Err_Kojo_Label)
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
			Me.ResultGroupBox.Location = New Point(73, 190)
			Me.ResultGroupBox.Name = "ResultGroupBox"
			Me.ResultGroupBox.Size = New Size(618, 203)
			Me.ResultGroupBox.TabIndex = 53
			Me.ResultGroupBox.TabStop = False
			Me.ResultGroupBox.Text = "取込み結果"
			'
			'Err_Count_Label
			'
			Me.Err_Count_Label.Location = New Point(536, 135)
			Me.Err_Count_Label.Name = "Err_Count_Label"
			Me.Err_Count_Label.Size = New Size(80, 20)
			Me.Err_Count_Label.TabIndex = 45
			Me.Err_Count_Label.Text = "ZZ,ZZ9"
			'
			'G_Count_Label
			'
			Me.G_Count_Label.Location = New Point(535, 175)
			Me.G_Count_Label.Name = "G_Count_Label"
			Me.G_Count_Label.Size = New Size(80, 20)
			Me.G_Count_Label.TabIndex = 39
			Me.G_Count_Label.Text = "ZZ,ZZ9"
			'
			'G_Money_Label
			'
			Me.G_Money_Label.Location = New Point(409, 175)
			Me.G_Money_Label.Name = "G_Money_Label"
			Me.G_Money_Label.Size = New Size(120, 20)
			Me.G_Money_Label.TabIndex = 38
			Me.G_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
			'
			'Err_Money_Label
			'
			Me.Err_Money_Label.Location = New Point(410, 135)
			Me.Err_Money_Label.Name = "Err_Money_Label"
			Me.Err_Money_Label.Size = New Size(120, 20)
			Me.Err_Money_Label.TabIndex = 44
			Me.Err_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
			'
			'G_Kosu_Label
			'
			Me.G_Kosu_Label.Location = New Point(313, 175)
			Me.G_Kosu_Label.Name = "G_Kosu_Label"
			Me.G_Kosu_Label.Size = New Size(80, 20)
			Me.G_Kosu_Label.TabIndex = 37
			Me.G_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'G_Kojo_Label
			'
			Me.G_Kojo_Label.Location = New Point(6, 175)
			Me.G_Kojo_Label.Name = "G_Kojo_Label"
			Me.G_Kojo_Label.Size = New Size(80, 20)
			Me.G_Kojo_Label.TabIndex = 36
			Me.G_Kojo_Label.Text = "合計"
			'
			'Err_Kosu_Label
			'
			Me.Err_Kosu_Label.Location = New Point(314, 135)
			Me.Err_Kosu_Label.Name = "Err_Kosu_Label"
			Me.Err_Kosu_Label.Size = New Size(80, 20)
			Me.Err_Kosu_Label.TabIndex = 43
			Me.Err_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'S_Count_Label
			'
			Me.S_Count_Label.Location = New Point(535, 155)
			Me.S_Count_Label.Name = "S_Count_Label"
			Me.S_Count_Label.Size = New Size(80, 20)
			Me.S_Count_Label.TabIndex = 35
			Me.S_Count_Label.Text = "ZZ,ZZ9"
			'
			'S_Money_Label
			'
			Me.S_Money_Label.Location = New Point(409, 155)
			Me.S_Money_Label.Name = "S_Money_Label"
			Me.S_Money_Label.Size = New Size(120, 20)
			Me.S_Money_Label.TabIndex = 34
			Me.S_Money_Label.Text = "ZZ,ZZZ,ZZZ,ZZ9"
			'
			'Err_BuhinCD_Label
			'
			Me.Err_BuhinCD_Label.Location = New Point(179, 135)
			Me.Err_BuhinCD_Label.Name = "Err_BuhinCD_Label"
			Me.Err_BuhinCD_Label.Size = New Size(120, 20)
			Me.Err_BuhinCD_Label.TabIndex = 42
			Me.Err_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
			'
			'S_Kosu_Label
			'
			Me.S_Kosu_Label.Location = New Point(313, 155)
			Me.S_Kosu_Label.Name = "S_Kosu_Label"
			Me.S_Kosu_Label.Size = New Size(80, 20)
			Me.S_Kosu_Label.TabIndex = 33
			Me.S_Kosu_Label.Text = "ZZ,ZZZ,ZZ9"
			'
			'Err_ToriCD_Label
			'
			Me.Err_ToriCD_Label.Location = New Point(93, 135)
			Me.Err_ToriCD_Label.Name = "Err_ToriCD_Label"
			Me.Err_ToriCD_Label.Size = New Size(80, 20)
			Me.Err_ToriCD_Label.TabIndex = 41
			Me.Err_ToriCD_Label.Text = "XXXXXXXX"
			'
			'S_BuhinCD_Label
			'
			Me.S_BuhinCD_Label.Location = New Point(178, 155)
			Me.S_BuhinCD_Label.Name = "S_BuhinCD_Label"
			Me.S_BuhinCD_Label.Size = New Size(120, 20)
			Me.S_BuhinCD_Label.TabIndex = 32
			Me.S_BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
			'
			'S_ToriCD_Label
			'
			Me.S_ToriCD_Label.Location = New Point(92, 155)
			Me.S_ToriCD_Label.Name = "S_ToriCD_Label"
			Me.S_ToriCD_Label.Size = New Size(80, 20)
			Me.S_ToriCD_Label.TabIndex = 31
			Me.S_ToriCD_Label.Text = "XXXXXXXX"
			'
			'Err_Kojo_Label
			'
			Me.Err_Kojo_Label.Location = New Point(7, 135)
			Me.Err_Kojo_Label.Name = "Err_Kojo_Label"
			Me.Err_Kojo_Label.Size = New Size(80, 20)
			Me.Err_Kojo_Label.TabIndex = 40
			Me.Err_Kojo_Label.Text = "エラー"
			'
			'S_Kojo_Label
			'
			Me.S_Kojo_Label.Location = New Point(6, 155)
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
			'Label1
			'
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.Location = New Point(70, 90)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(433, 53)
			Me.Label1.TabIndex = 54
			Me.Label1.Text = "払出データを取り込む場合は、「実行」ボタンを押してください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "エラーファイルを取り込む場合は、「再取込み」ボタンを押してください。"
			'
			'ChkMemory
			'
			Me.ChkMemory.AutoSize = True
			Me.ChkMemory.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ChkMemory.Location = New Point(18, 525)
			Me.ChkMemory.Name = "ChkMemory"
			Me.ChkMemory.Size = New Size(159, 16)
			Me.ChkMemory.TabIndex = 55
			Me.ChkMemory.Text = "指定フォルダーを記憶する"
			Me.ChkMemory.UseVisualStyleBackColor = True
			'
			'BatchHaraiDataWritForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.ChkMemory)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.ResultGroupBox)
			Me.Controls.Add(Me.BTC_BackButton)
			Me.Controls.Add(Me.BTC_ReloadButton)
			Me.Controls.Add(Me.BTC_ExecutButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "BatchHaraiDataWritForm"
			Me.Text = "払出データ書き込み画面"
			Me.ResultGroupBox.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

#End Region
		Private Sub BatchTorihikiBulkChangeForm_Load(sender As Object, e As EventArgs)
			Me._configData = TopForm.ConfigData
			Me.ResultGroupBox.Hide()
			If Operators.CompareString(Me._configData.xmlConfData.Kyoten, "Matsuyama", False) <> 0 Then
				Me.ChkMemory.Visible = False
				Return
			End If
			If "ON".Equals(Me._configData.xmlConfData.Memory) Then
				Me.FlgMemory = True
				Me.ChkMemory.Checked = True
			Else
				Me.FlgMemory = False
				Me.ChkMemory.Checked = False
			End If
		End Sub

		Private Function HaraiWritExec(csvTb As DataTable) As Boolean
			Me.CreateOutPutTable(csvTb)
			Try
				Me.HaraiDataWrit(csvTb)
				Me.ShowViewInfo(Me._viewInfo)
				Me.OutPutFile()
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("Exception Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CheckTableColums(csvTb As DataTable) As Boolean
			Dim list As New List(Of String)()
			For Each columnName As String In Me._haraicolum
				If csvTb.Columns.IndexOf(columnName) < 0 Then
					Return False
				End If
			Next
			Return True
		End Function

		Private Function CreateOutPutTable(csvTb As DataTable) As Boolean
			If csvTb.Columns.IndexOf("エラー") > -1 Then
				csvTb.Columns.Remove("エラー")
			End If
			Me._okTable = csvTb.Clone()
			Me._errTable = csvTb.Clone()
			Me._errTable.Columns.Add("エラー")
			Return True
		End Function

		Private Sub HaraiDataWrit(csvTb As DataTable)
			Me.CreateViewInfo()
			Try
				For Each obj As Object In csvTb.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim toricd As String = Conversions.ToString(dataRow("取引先コード"))
					Dim toriTable As DataTable = Me.GetToriTable(toricd)
					If IsNothing(toriTable) Then
						Me.AddErrRow(dataRow, "#")
					Else
						Dim buhincd As String = Conversions.ToString(dataRow("部品コード"))
						Dim buhinTable As DataTable = Me.GetBuhinTable(toricd, buhincd)
						If IsNothing(buhinTable) Then
							Me.AddErrRow(dataRow, "*")
						Else
							Dim sakicd As String = ""
							If Operators.ConditionalCompareObjectNotEqual(dataRow("納入先"), String.Empty, False) Then
								sakicd = String.Format("{0:00}", Conversions.ToInteger(dataRow("納入先")))
							End If
							Dim text As String = Conversions.ToString(toriTable.Rows(0)("SEIKYU_TYPE"))
							dataRow("手数料単価") = 0
							If Operators.CompareString(text, "1", False) = 0 Then
								Dim dateYMD As String = Conversions.ToString(dataRow("払出年月日"))
								Dim tankaTable As DataTable = Me.GetTankaTable(toricd, buhincd, sakicd, dateYMD)
								If IsNothing(tankaTable) Then
									Me.AddErrRow(dataRow, "@")
								Else
									dataRow("手数料単価") = RuntimeHelpers.GetObjectValue(tankaTable.Rows(0)("SAGYO"))
									If Me.InsertRowData(dataRow, text) Then
										Me.AddOkRow(dataRow)
									Else
										Me.AddErrRow(dataRow, "!")
									End If
								End If
							ElseIf Me.InsertRowData(dataRow, text) Then
								Me.AddOkRow(dataRow)
							Else
								Me.AddErrRow(dataRow, "!")
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.SetTotaleViewValue()
		End Sub

		Private Function InsertRowData(row As DataRow, sType As String) As Boolean
			Dim ukeharaiMeisaiTable As DataTable = Me.GetUkeharaiMeisaiTable()
			If IsNothing(ukeharaiMeisaiTable) Then
				Me.AddErrRow(row, "!")
			End If
			Dim result As Boolean = False
			Try
				If Me.CreateHaraiMeisaiData(ukeharaiMeisaiTable, row, sType) Then
					Dim sql As String = Me.CreateInsertSql(ukeharaiMeisaiTable)
					result = Me.InsertUkeharaiMeisai(sql)
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function GetExecFilePath(Optional a_path As String = "") As String
			Dim result As String = Nothing
			Dim openFileDialog As New OpenFileDialog()
			If String.IsNullOrEmpty(a_path) Then
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			Else
				openFileDialog.InitialDirectory = a_path
			End If
			openFileDialog.Filter = "CSVファイル(*.csv)|*.csv| すべてのファイル(*.*)|*.*"
			openFileDialog.Title = "払出データ書き込みファイルを選択してください。"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				result = openFileDialog.FileName
			End If
			Return result
		End Function

		Private Function GetRetryFilePath() As String
			Dim result As String = Nothing
			Dim openFileDialog As New OpenFileDialog()
			Dim initialDirectory As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			openFileDialog.InitialDirectory = initialDirectory
			openFileDialog.Filter = "CSVファイル(*.csv)|*.csv| すべてのファイル(*.*)|*.*"
			openFileDialog.Title = "再取込みするファイルを選択してください。"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				result = openFileDialog.FileName
			End If
			Return result
		End Function

		Private Sub AddOkRow(row As DataRow)
			Dim dataRow As DataRow = Me._okTable.NewRow()
			For Each columnName As String In Me._haraicolum
				dataRow(columnName) = RuntimeHelpers.GetObjectValue(row(columnName))
			Next
			Me._okTable.Rows.Add(dataRow)
			Dim num As Integer = Conversions.ToInteger(row("納入先"))
			If num < 1 Or num >= 6 Then
				num = 7
			End If
			Me.SetViewValue(num, row)
		End Sub

		Private Sub AddErrRow(row As DataRow, errMsg As String)
			Dim dataRow As DataRow = Me._errTable.NewRow()
			For Each columnName As String In Me._haraicolum
				dataRow(columnName) = RuntimeHelpers.GetObjectValue(row(columnName))
			Next
			dataRow("エラー") = errMsg
			Me._errTable.Rows.Add(dataRow)
			Me.SetViewValue(6, row)
		End Sub

		Private Sub OutPutFile()
			Dim now As DateTime = DateAndTime.Now
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			If Not BaseOperation.IsDirectory(text) AndAlso Not BaseOperation.CreateDirectory(text) Then
				Return
			End If
			Dim path1 As String = String.Format("45.払出データ書き込み_OK_{0}-{1}.csv", now.ToString("yyyyMMdd"), now.ToString("HHmmss"))
			Dim csvPath As String = Path.Combine(text, path1)
			Dim path2 As String = String.Format("45.払出データ書き込み_ERR_{0}-{1}.csv", now.ToString("yyyyMMdd"), now.ToString("HHmmss"))
			Dim csvPath2 As String = Path.Combine(text, path2)
			Dim csvCommon As New CsvCommon()
			If Me._okTable.Rows.Count > 0 AndAlso Not csvCommon.ConvertDataTableToCsv(Me._okTable, csvPath, True) Then
				DlgMessageBox.Show("OKファイルの出力に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			If Me._errTable.Rows.Count > 0 AndAlso Not csvCommon.ConvertDataTableToCsv(Me._errTable, csvPath2, True) Then
				DlgMessageBox.Show("ERRファイルの出力に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		Private Sub FixedOutPutFile()
			Dim list As New List(Of String)()
			Dim list2 As New List(Of String)()
			Dim path1 As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			If Not BaseOperation.IsDirectory(path1) AndAlso Not BaseOperation.CreateDirectory(path1) Then
				Return
			End If
			For Each text As String In BaseOperation.GetFileList(path1)
				If text.IndexOf("45.払出データ書き込み_OK") >= 0 Then
					list.Add(text)
				ElseIf text.IndexOf("45.払出データ書き込み_ERR") >= 0 Then
					list2.Add(text)
				End If
			Next
			If list.Count > 2 Then
				BaseOperation.DeleteFileList(list, 2)
			End If
			If list2.Count > 2 Then
				BaseOperation.DeleteFileList(list2, 2)
			End If
		End Sub


		Private Function GetDbParam(sql As String) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sql, True)
				If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function


		Private Function GetSelectTable(sql As String, ByRef tb As DataTable) As String
			Dim result As String = Nothing
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.getSQLData(sql, True)
				tb = sqlDataBase.DbDataTable
			End Using
			Return result
		End Function


		Private Function GetToriTable(toricd As String) As DataTable
			Dim result As DataTable = Nothing
			Dim toriSql As String = Me.GetToriSql(toricd)
			Dim dataTable As New DataTable()
			Dim selectTable As String = Me.GetSelectTable(toriSql, dataTable)
			If Operators.CompareString(selectTable, String.Empty, False) = 0 AndAlso dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function GetToriSql(toricd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD = '{0}' ", toricd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetBuhinTable(toricd As String, buhincd As String) As DataTable
			Dim result As DataTable = Nothing
			Dim buhinSql As String = Me.GetBuhinSql(toricd, buhincd)
			Dim dataTable As New DataTable()
			Dim selectTable As String = Me.GetSelectTable(buhinSql, dataTable)
			If Operators.CompareString(selectTable, String.Empty, False) = 0 AndAlso dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function GetBuhinSql(toricd As String, buhincd As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_BUHIN [M_Buhin] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Buhin.TORI_CD = '{0}' ", toricd))
			stringBuilder.Append(String.Format("AND M_Buhin.BUHIN_CD = '{0}' ", buhincd))
			Return stringBuilder.ToString()
		End Function

		Private Function GetTankaTable(toricd As String, buhincd As String, sakicd As String, dateYMD As String) As DataTable
			Dim result As DataTable = Nothing
			Dim tankaSql As String = Me.GetTankaSql(toricd, buhincd, sakicd, dateYMD)
			Dim dataTable As New DataTable()
			Dim selectTable As String = Me.GetSelectTable(tankaSql, dataTable)
			If Operators.CompareString(selectTable, String.Empty, False) = 0 AndAlso dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function GetTankaSql(toricd As String, buhincd As String, sakicd As String, accept As String) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TANKA [M_Tanka] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tanka.TORI_CD = '{0}' ", toricd))
			stringBuilder.Append(String.Format("AND M_Tanka.BUHIN_CD = '{0}' ", buhincd))
			stringBuilder.Append(String.Format("AND M_Tanka.SAKI_CD = '{0}' ", sakicd))
			stringBuilder.Append(String.Format("AND CONVERT(VARCHAR(30), {0}, 111) BETWEEN M_tanka.YUKO_FM AND M_tanka.YUKO_TO ", accept))
			Return stringBuilder.ToString()
		End Function

		Private Function InsertUkeharaiMeisai(sql As String) As Boolean
			Dim result As Boolean = False
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				result = sqlDataBase.execSql(sql)
			End Using
			Return result
		End Function

		Private Function GetUkeharaiMeisaiTable() As DataTable
			Dim result As DataTable = Nothing
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_UKEHARAIMEISAI  [T_Meisai] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE T_Meisai.TORI_CD = '00000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.BUHIN_CD = '000000000000' ", New Object(-1) {}))
			stringBuilder.Append(String.Format("AND T_Meisai.UKEHARA_YYYYMMDD = '2000/01/01' ", New Object(-1) {}))
			Dim selectTable As String = Me.GetSelectTable(stringBuilder.ToString(), result)
			If Operators.CompareString(selectTable, String.Empty, False) <> 0 Then
				result = Nothing
			End If
			Return result
		End Function

		Private Function CreateHaraiMeisaiData(tb As DataTable, csvRow As DataRow, sType As String) As Boolean
			Dim dataRow As DataRow = tb.NewRow()
			Try
				dataRow("TORI_CD") = RuntimeHelpers.GetObjectValue(csvRow("取引先コード"))
				dataRow("BUHIN_CD") = RuntimeHelpers.GetObjectValue(csvRow("部品コード"))
				dataRow("UKEHARA_YYYYMMDD") = DateTime.Parse(Strings.Format(Conversions.ToInteger(csvRow("払出年月日")), "0000/00/00"))
				dataRow("DEN_NO") = RuntimeHelpers.GetObjectValue(csvRow("伝票NO"))
				dataRow("UKEHARAI_KBN") = "2"
				dataRow("KOSU") = RuntimeHelpers.GetObjectValue(csvRow("数量"))
				dataRow("REMARKS1") = RuntimeHelpers.GetObjectValue(csvRow("備考１"))
				dataRow("REMARKS2") = RuntimeHelpers.GetObjectValue(csvRow("備考２"))
				dataRow("REMARKS3") = RuntimeHelpers.GetObjectValue(csvRow("備考３"))
				Dim value As String = ""
				If Operators.ConditionalCompareObjectNotEqual(csvRow("納入先"), String.Empty, False) Then
					value = String.Format("{0:00}", Conversions.ToInteger(csvRow("納入先")))
				End If
				dataRow("SAKI_CD") = value
				dataRow("KINGAKU") = RuntimeHelpers.GetObjectValue(csvRow("納入金額"))
				Dim value2 As String = "0.00"
				If Operators.CompareString(sType, "1", False) = 0 Then
					value2 = Conversions.ToString(csvRow("手数料単価"))
				End If
				dataRow("TESU") = value2
				dataRow("INSERT_USER") = Me._configData.xmlConfData.xDataBase.UserId
				dataRow("INSERT_DTM") = DateAndTime.Now
				dataRow("INSERT_FUNCTION") = "BatchHaraiDataWrit"
				tb.Rows.Add(dataRow)
			Catch ex As Exception
				OutputLog.WriteLine(String.Format("CreateMeisaiData Errer : {0}", ex.Message))
				Return False
			End Try
			Return True
		End Function

		Private Function CreateInsertSql(tb As DataTable) As String
			Dim str As String = "INSERT INTO Ukeharai.T_UKEHARAIMEISAI "
			Dim count As Integer = tb.Columns.Count
			Dim text As String = "("
			Dim text2 As String = "VALUES ("
			Dim dataRow As DataRow = tb.Rows(0)
			Dim num As Integer = 0
			Dim num2 As Integer = count - 1
			For i As Integer = num To num2
				Dim caption As String = tb.Columns(i).Caption
				text += caption
				If Not IsNothing(RuntimeHelpers.GetObjectValue(dataRow(i))) Then
					If Me.GetDataType(caption) = 1 Then
						text2 += dataRow(i).ToString()
					Else
						text2 += String.Format("'{0}'", RuntimeHelpers.GetObjectValue(dataRow(i)))
					End If
				End If
				If i < count - 1 Then
					text += " ,"
					text2 += " ,"
				Else
					text += " )"
					text2 += " )"
				End If
			Next
			Return str + text + text2
		End Function

		Private Function GetDataType(name As String) As Integer
			Dim result As Integer
			If Operators.CompareString(name, "KOSU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "KINGAKU", False) = 0 Then
				result = 1
			ElseIf Operators.CompareString(name, "TESU", False) = 0 Then
				result = 1
			Else
				result = 0
			End If
			Return result
		End Function

		Private Sub ShowViewInfo(viewInfo As Dictionary(Of Integer, viewInfo))
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
						Me.SetErrorInfo(viewInfo(i))
					Case 7
						Me.SetSonotaInfo(viewInfo(i))
					Case 8
						Me.SetTotaleInfo(viewInfo(i))
				End Select
			Next
			Me.ResultGroupBox.Show()
		End Sub


		Private Sub SetMatuyamaInfo(info As viewInfo)
			Me.M_ToriCD_Label.Text = info.tori_cd
			Me.M_BuhinCD_Label.Text = info.buhin_cd
			Me.M_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.M_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.M_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetKumamotoInfo(info As viewInfo)
			Me.K_ToriCD_Label.Text = info.tori_cd
			Me.K_BuhinCD_Label.Text = info.buhin_cd
			Me.K_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.K_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.K_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetHoueiInfo(info As viewInfo)
			Me.H_ToriCD_Label.Text = info.tori_cd
			Me.H_BuhinCD_Label.Text = info.buhin_cd
			Me.H_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.H_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.H_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetIsekiKoubaiInfo(info As viewInfo)
			Me.IK_ToriCD_Label.Text = info.tori_cd
			Me.IK_BuhinCD_Label.Text = info.buhin_cd
			Me.IK_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.IK_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.IK_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetIsekiBuhinInfo(info As viewInfo)
			Me.IB_ToriCD_Label.Text = info.tori_cd
			Me.IB_BuhinCD_Label.Text = info.buhin_cd
			Me.IB_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.IB_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.IB_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetErrorInfo(info As viewInfo)
			Me.Err_ToriCD_Label.Text = info.tori_cd
			Me.Err_BuhinCD_Label.Text = info.buhin_cd
			Me.Err_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.Err_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.Err_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetSonotaInfo(info As viewInfo)
			Me.S_ToriCD_Label.Text = info.tori_cd
			Me.S_BuhinCD_Label.Text = info.buhin_cd
			Me.S_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.S_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.S_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Sub SetTotaleInfo(info As viewInfo)
			Me.G_Kosu_Label.Text = Me.ConvertViewNumber(info.kosu)
			Me.G_Money_Label.Text = Me.ConvertViewNumber(info.money)
			Me.G_Count_Label.Text = Me.ConvertViewNumber(info.count)
		End Sub

		Private Function ConvertViewNumber(num As Integer) As String
			Return String.Format("{0:#,0}", num)
		End Function

		Private Sub CreateViewInfo()
			If Not IsNothing(Me._viewInfo) Then
				Me._viewInfo.Clear()
				Me._viewInfo = Nothing
			End If
			Me._viewInfo = New Dictionary(Of Integer, viewInfo)()
			Dim viewInfoNum As viewInfoNum = viewInfoNum.Matuyama
			Dim num As Integer = 1
			Do
				Me._viewInfo.Add(CInt(viewInfoNum), New viewInfo())
				num += 1
				viewInfoNum = CType(num, viewInfoNum)
			Loop While viewInfoNum <= viewInfoNum.Sonota
		End Sub

		Private Sub SetViewValue(id As Integer, row As DataRow)
			Me._viewInfo(id).tori_cd = Conversions.ToString(row("取引先コード"))
			Me._viewInfo(id).buhin_cd = Me.ConvertBuhinCd(Conversions.ToString(row("部品コード")))
			Dim viewInfo As viewInfo = Me._viewInfo(id)
			viewInfo.kosu += Conversions.ToInteger(row("数量"))
			viewInfo = Me._viewInfo(id)
			viewInfo.money += Conversions.ToInteger(row("納入金額"))
			viewInfo = Me._viewInfo(id)
			viewInfo.count += 1
		End Sub

		Private Function SetTotaleViewValue() As Boolean
			Dim count As Integer = Me._viewInfo.Count
			Dim viewInfo As New viewInfo()
			Dim num As Integer = 1
			Dim num2 As Integer = count
			For i As Integer = num To num2
				Dim viewInfo2 As viewInfo = viewInfo
				viewInfo2.kosu += Me._viewInfo(i).kosu
				viewInfo2 = viewInfo
				viewInfo2.money += Me._viewInfo(i).money
				viewInfo2 = viewInfo
				viewInfo2.count += Me._viewInfo(i).count
			Next
			Me._viewInfo.Add(count + 1, viewInfo)
			Return viewInfo.count >= 1
		End Function

		Private Function ConvertBuhinCd(buhin_cd As String) As String
			Dim length As Integer = buhin_cd.Length
			Dim result As String
			If length > 10 Then
				result = String.Format("{0}-{1}-{2}-{3}", New Object() {buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7, 3), buhin_cd.Substring(10)})
			ElseIf length > 7 Then
				result = String.Format("{0}-{1}-{2}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7))
			ElseIf length > 4 Then
				result = String.Format("{0}-{1}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4))
			Else
				result = buhin_cd
			End If
			Return result
		End Function

		Private Sub FileBackUp(filePath As String)
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.backupDir)
			If Not BaseOperation.IsDirectory(text) AndAlso Not BaseOperation.CreateDirectory(text) Then
				Return
			End If
			Dim fileName As String = Path.GetFileName(filePath)
			Dim dst As String = Path.Combine(text, fileName)
			BaseOperation.CopyToFile(filePath, dst)
			Me.FixedBackUpFile()
		End Sub

		Private Sub FixedBackUpFile()
			Dim list As New List(Of String)()
			Dim path1 As String = Path.Combine(FileSystem.CurDir(), Me.backupDir)
			For Each item As String In BaseOperation.GetFileList(path1)
				list.Add(item)
			Next
			If list.Count > 2 Then
				BaseOperation.DeleteFileList(list, 2)
			End If
		End Sub

		Private Sub BatchHaraiDataWritForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Operators.CompareString(Me._configData.xmlConfData.Kyoten, "Matsuyama", False) <> 0 Then
				Return
			End If
			If Me.FlgMemory <> Me.ChkMemory.Checked Then
				If Me.ChkMemory.Checked Then
					Me._configData.xmlConfData.Memory = "ON"
				Else
					Me._configData.xmlConfData.Memory = "OFF"
				End If
				Me._configData.writeConfig()
			End If
		End Sub


		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("BTC_BackButton")>
		Private WithEvents BTC_BackButton As Button

		<AccessedThroughProperty("BTC_ReloadButton")>
		Private WithEvents BTC_ReloadButton As Button

		<AccessedThroughProperty("BTC_ExecutButton")>
		Private WithEvents BTC_ExecutButton As Button

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

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("Err_Count_Label")>
		Private WithEvents Err_Count_Label As Label

		<AccessedThroughProperty("Err_Money_Label")>
		Private WithEvents Err_Money_Label As Label

		<AccessedThroughProperty("Err_Kosu_Label")>
		Private WithEvents Err_Kosu_Label As Label

		<AccessedThroughProperty("Err_BuhinCD_Label")>
		Private WithEvents Err_BuhinCD_Label As Label

		<AccessedThroughProperty("Err_ToriCD_Label")>
		Private WithEvents Err_ToriCD_Label As Label

		<AccessedThroughProperty("Err_Kojo_Label")>
		Private WithEvents Err_Kojo_Label As Label

		<AccessedThroughProperty("ChkMemory")>
		Private WithEvents ChkMemory As CheckBox

		Private Const EXEC_FUNC_NAME As String = "BatchHaraiDataWrit"

		Private Const UKEHARAI_KUBUN As String = "2"

		Private Const FIX_FILE_COUNT As Integer = 2

		Private outPutDir As String

		Private Const OK_FILE_NAME As String = "45.払出データ書き込み_OK"

		Private Const OK_FILE_FORMAT As String = "45.払出データ書き込み_OK_{0}-{1}.csv"

		Private Const ERR_FILE_NAME As String = "45.払出データ書き込み_ERR"

		Private Const ERR_FILE_FORMAT As String = "45.払出データ書き込み_ERR_{0}-{1}.csv"

		Private Const FIX_BACKFILE_COUNT As Integer = 2

		Private backupDir As String

		Private Const ITEM_HARAIYMD As String = "払出年月日"

		Private Const ITEM_TORICD As String = "取引先コード"

		Private Const ITEM_BUHINCD As String = "部品コード"

		Private Const ITEM_KOSU As String = "数量"

		Private Const ITEM_DENNO As String = "伝票NO"

		Private Const ITEM_SAKICD As String = "納入先"

		Private Const ITEM_MONEY As String = "納入金額"

		Private Const ITEM_TANKA As String = "手数料単価"

		Private Const ITEM_REMARKS_1 As String = "備考１"

		Private Const ITEM_REMARKS_2 As String = "備考２"

		Private Const ITEM_REMARKS_3 As String = "備考３"

		Private _haraicolum As String()

		Private Const ITEM_ERR As String = "エラー"

		Private _viewInfo As Dictionary(Of Integer, BatchHaraiDataWritForm.viewInfo)

		Private Const ERR_TORI_MARK As String = "#"

		Private Const ERR_BUHIN_MARK As String = "*"

		Private Const ERR_TANKA_MARK As String = "@"

		Private Const ERR_DB_MARK As String = "!"

		Private Const TORI_SEIKYU_TYPE As String = "SEIKYU_TYPE"

		Private _okTable As DataTable

		Private _errTable As DataTable

		Private _configData As XmlConfigControl

		Private FlgMemory As Boolean

		Public Class viewInfo

			Public Sub New()
				Me.tori_cd = ""
				Me.buhin_cd = ""
				Me.kosu = 0
				Me.money = 0
				Me.count = 0
			End Sub

			Public tori_cd As String

			Public buhin_cd As String

			Public kosu As Integer

			Public money As Integer

			Public count As Integer
		End Class

		Public Enum viewInfoNum

			Matuyama = 1

			Kumamoto

			Houei

			Koubai

			Buhin

			Errors

			Sonota

			Totale

			err
		End Enum

		Private Sub BTC_ExecutButton_Click_1(sender As Object, e As EventArgs) Handles BTC_ExecutButton.Click
			Dim execFilePath As String = Me.GetExecFilePath(Me._configData.xmlConfData.BaseFolder)
			If IsNothing(execFilePath) Then
				Return
			End If
			If Me.ChkMemory.Checked Then
				Dim directoryName As String = Path.GetDirectoryName(execFilePath)
				Me._configData.xmlConfData.BaseFolder = directoryName
				Me._configData.writeConfig()
			End If
			Dim csvCommon As New CsvCommon()
			Dim dataTable As DataTable = csvCommon.ConvertCsvToDataTable(execFilePath)
			If Not Me.CheckTableColums(dataTable) Then
				DlgMessageBox.Show("払出データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If dataTable.Rows.Count < 1 Then
				DlgMessageBox.Show("取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.HaraiWritExec(dataTable) Then
				Me.FileBackUp(execFilePath)
				DlgMessageBox.Show("払出データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
				Me.FixedOutPutFile()
				Return
			End If
			DlgMessageBox.Show("払出データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BTC_ReloadButton_Click(sender As Object, e As EventArgs) Handles BTC_ReloadButton.Click
			Dim retryFilePath As String = Me.GetRetryFilePath()
			If IsNothing(retryFilePath) Then
				Return
			End If
			Dim csvCommon As New CsvCommon()
			Dim dataTable As DataTable = csvCommon.ConvertCsvToDataTable(retryFilePath)
			If Not Me.CheckTableColums(dataTable) Then
				DlgMessageBox.Show("払出データ書き込みに必要な項目が有りません。" & vbCrLf & "入力ファイルのフォーマットに誤りが有ります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If dataTable.Rows.Count < 1 Then
				DlgMessageBox.Show("取込み可能なデータ行が存在しません。" & vbCrLf & "入力ファイルを確認してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.HaraiWritExec(dataTable) Then
				Me.FileBackUp(retryFilePath)
				BaseOperation.DeleteFile(retryFilePath)
				DlgMessageBox.Show("払出データ書き込み処理が完了しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
				Me.FixedOutPutFile()
				Return
			End If
			DlgMessageBox.Show("払出データ書き込み処理を中断します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BTC_BackButton_Click(sender As Object, e As EventArgs) Handles BTC_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
