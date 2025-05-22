Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.CateDataExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class InquiryUkeharaiZissekiForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.KeyUp, AddressOf Me.InquiryUkeharaiZissekiForm_KeyUp
			AddHandler MyBase.Load, AddressOf Me.InquiryUkeharaiZissekiForm_Load
			Me.HeaderTable = New DataTable()
			Me.BodyTable = New DataTable()
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
			Me.components = New System.ComponentModel.Container()
			Me.FormTitleLabel = New Label()
			Me.SearchButton = New Button()
			Me.BuhinLabel = New Label()
			Me.NengetsuLabel = New Label()
			Me.IUHZ_BackButton = New Button()
			Me.OutPutButton = New Button()
			Me.LblTorihikiName = New Label()
			Me.TorihikiNameLabel = New Label()
			Me.BuhinNameLabel = New Label()
			Me.Tana1Label = New Label()
			Me.Tana2Label = New Label()
			Me.Tana3Label = New Label()
			Me.TorihinNoLabel = New Label()
			Me.IkisakiCdLabel = New Label()
			Me.ToriCdLabel = New Label()
			Me.KikakuLabel = New Label()
			Me.ZennenMatuZaikoLabel = New Label()
			Me.UkeireRuikeiLabel = New Label()
			Me.HaraidashiRuikeiLabel = New Label()
			Me.ZengetsuMatsuZaikoLabel = New Label()
			Me.LblBuhinName = New Label()
			Me.LblTana1 = New Label()
			Me.LblTana2 = New Label()
			Me.LblTana3 = New Label()
			Me.LblIkisakiCd = New Label()
			Me.LblKikaku = New Label()
			Me.LblZennenMatuZaiko = New Label()
			Me.LblUkeireRuikei = New Label()
			Me.LblHaraidashiRuikei = New Label()
			Me.LblZengetsuMatsuZaiko = New Label()
			Me.LblTorihinNo = New Label()
			Me.CheckBoxDate = New CheckBox()
			Me.LblMessage = New Label()
			Me.NextButton = New Button()
			Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
			Me.CclBuhinCode = New DitCore.CclBuhinCode()
			Me.UcSelectGridView1 = New IbUkeharai.UcSelectGridView()
			Me.ComboTori = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.FormTitleLabel.BackColor = Color.DarkCyan
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
			Me.FormTitleLabel.Location = New Point(12, 9)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(931, 45)
			Me.FormTitleLabel.TabIndex = 3
			Me.FormTitleLabel.Text = "受払実績"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'SearchButton
			'
			Me.SearchButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SearchButton.Location = New Point(426, 120)
			Me.SearchButton.Name = "SearchButton"
			Me.SearchButton.Size = New Size(80, 30)
			Me.SearchButton.TabIndex = 4
			Me.SearchButton.Text = "検索"
			Me.SearchButton.UseVisualStyleBackColor = True
			'
			'BuhinLabel
			'
			Me.BuhinLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BuhinLabel.Location = New Point(12, 63)
			Me.BuhinLabel.Name = "BuhinLabel"
			Me.BuhinLabel.Size = New Size(141, 18)
			Me.BuhinLabel.TabIndex = 30
			Me.BuhinLabel.Text = "部 品 コ ー ド"
			Me.BuhinLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'NengetsuLabel
			'
			Me.NengetsuLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NengetsuLabel.Location = New Point(165, 62)
			Me.NengetsuLabel.Name = "NengetsuLabel"
			Me.NengetsuLabel.Size = New Size(112, 18)
			Me.NengetsuLabel.TabIndex = 47
			Me.NengetsuLabel.Text = "指 定 年 月"
			Me.NengetsuLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'IUHZ_BackButton
			'
			Me.IUHZ_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.IUHZ_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IUHZ_BackButton.Location = New Point(863, 621)
			Me.IUHZ_BackButton.Name = "IUHZ_BackButton"
			Me.IUHZ_BackButton.Size = New Size(80, 44)
			Me.IUHZ_BackButton.TabIndex = 8
			Me.IUHZ_BackButton.Text = "戻る"
			Me.IUHZ_BackButton.UseVisualStyleBackColor = True
			'
			'OutPutButton
			'
			Me.OutPutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.OutPutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.OutPutButton.Location = New Point(777, 621)
			Me.OutPutButton.Name = "OutPutButton"
			Me.OutPutButton.Size = New Size(80, 44)
			Me.OutPutButton.TabIndex = 7
			Me.OutPutButton.Text = "出力" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F5)"
			Me.OutPutButton.UseVisualStyleBackColor = True
			'
			'LblTorihikiName
			'
			Me.LblTorihikiName.BorderStyle = BorderStyle.FixedSingle
			Me.LblTorihikiName.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblTorihikiName.Location = New Point(130, 123)
			Me.LblTorihikiName.Name = "LblTorihikiName"
			Me.LblTorihikiName.Padding = New Padding(3, 0, 0, 0)
			Me.LblTorihikiName.Size = New Size(277, 26)
			Me.LblTorihikiName.TabIndex = 48
			Me.LblTorihikiName.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
			Me.LblTorihikiName.TextAlign = ContentAlignment.MiddleLeft
			'
			'TorihikiNameLabel
			'
			Me.TorihikiNameLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiNameLabel.Location = New Point(130, 107)
			Me.TorihikiNameLabel.Name = "TorihikiNameLabel"
			Me.TorihikiNameLabel.Size = New Size(266, 18)
			Me.TorihikiNameLabel.TabIndex = 17
			Me.TorihikiNameLabel.Text = "取　引　先　名　称"
			Me.TorihikiNameLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'BuhinNameLabel
			'
			Me.BuhinNameLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BuhinNameLabel.Location = New Point(294, 63)
			Me.BuhinNameLabel.Name = "BuhinNameLabel"
			Me.BuhinNameLabel.Size = New Size(181, 18)
			Me.BuhinNameLabel.TabIndex = 49
			Me.BuhinNameLabel.Text = "品　名"
			Me.BuhinNameLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'Tana1Label
			'
			Me.Tana1Label.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Tana1Label.Location = New Point(481, 63)
			Me.Tana1Label.Name = "Tana1Label"
			Me.Tana1Label.Size = New Size(81, 18)
			Me.Tana1Label.TabIndex = 50
			Me.Tana1Label.Text = "棚 番 1"
			Me.Tana1Label.TextAlign = ContentAlignment.BottomCenter
			'
			'Tana2Label
			'
			Me.Tana2Label.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Tana2Label.Location = New Point(561, 63)
			Me.Tana2Label.Name = "Tana2Label"
			Me.Tana2Label.Size = New Size(80, 18)
			Me.Tana2Label.TabIndex = 51
			Me.Tana2Label.Text = "棚 番 2"
			Me.Tana2Label.TextAlign = ContentAlignment.BottomCenter
			'
			'Tana3Label
			'
			Me.Tana3Label.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Tana3Label.Location = New Point(640, 63)
			Me.Tana3Label.Name = "Tana3Label"
			Me.Tana3Label.Size = New Size(81, 18)
			Me.Tana3Label.TabIndex = 52
			Me.Tana3Label.Text = "棚 番 3"
			Me.Tana3Label.TextAlign = ContentAlignment.BottomCenter
			'
			'TorihinNoLabel
			'
			Me.TorihinNoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihinNoLabel.Location = New Point(727, 63)
			Me.TorihinNoLabel.Name = "TorihinNoLabel"
			Me.TorihinNoLabel.Size = New Size(216, 18)
			Me.TorihinNoLabel.TabIndex = 53
			Me.TorihinNoLabel.Text = "取 引 先 品 番"
			Me.TorihinNoLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'IkisakiCdLabel
			'
			Me.IkisakiCdLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IkisakiCdLabel.Location = New Point(614, 107)
			Me.IkisakiCdLabel.Name = "IkisakiCdLabel"
			Me.IkisakiCdLabel.Size = New Size(112, 18)
			Me.IkisakiCdLabel.TabIndex = 54
			Me.IkisakiCdLabel.Text = "行  先"
			Me.IkisakiCdLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'ToriCdLabel
			'
			Me.ToriCdLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ToriCdLabel.Location = New Point(12, 106)
			Me.ToriCdLabel.Name = "ToriCdLabel"
			Me.ToriCdLabel.Size = New Size(100, 18)
			Me.ToriCdLabel.TabIndex = 55
			Me.ToriCdLabel.Text = "取 引 先"
			Me.ToriCdLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'KikakuLabel
			'
			Me.KikakuLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.KikakuLabel.Location = New Point(732, 107)
			Me.KikakuLabel.Name = "KikakuLabel"
			Me.KikakuLabel.Size = New Size(211, 18)
			Me.KikakuLabel.TabIndex = 56
			Me.KikakuLabel.Text = "規  格"
			Me.KikakuLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'ZennenMatuZaikoLabel
			'
			Me.ZennenMatuZaikoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ZennenMatuZaikoLabel.Location = New Point(12, 162)
			Me.ZennenMatuZaikoLabel.Name = "ZennenMatuZaikoLabel"
			Me.ZennenMatuZaikoLabel.Size = New Size(80, 18)
			Me.ZennenMatuZaikoLabel.TabIndex = 57
			Me.ZennenMatuZaikoLabel.Text = "前年未在庫"
			Me.ZennenMatuZaikoLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'UkeireRuikeiLabel
			'
			Me.UkeireRuikeiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.UkeireRuikeiLabel.Location = New Point(98, 162)
			Me.UkeireRuikeiLabel.Name = "UkeireRuikeiLabel"
			Me.UkeireRuikeiLabel.Size = New Size(80, 18)
			Me.UkeireRuikeiLabel.TabIndex = 58
			Me.UkeireRuikeiLabel.Text = "受 入 累 計"
			Me.UkeireRuikeiLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'HaraidashiRuikeiLabel
			'
			Me.HaraidashiRuikeiLabel.AccessibleDescription = ""
			Me.HaraidashiRuikeiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.HaraidashiRuikeiLabel.Location = New Point(184, 162)
			Me.HaraidashiRuikeiLabel.Name = "HaraidashiRuikeiLabel"
			Me.HaraidashiRuikeiLabel.Size = New Size(80, 18)
			Me.HaraidashiRuikeiLabel.TabIndex = 59
			Me.HaraidashiRuikeiLabel.Text = "払 出 累 計"
			Me.HaraidashiRuikeiLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'ZengetsuMatsuZaikoLabel
			'
			Me.ZengetsuMatsuZaikoLabel.AccessibleDescription = ""
			Me.ZengetsuMatsuZaikoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ZengetsuMatsuZaikoLabel.Location = New Point(270, 162)
			Me.ZengetsuMatsuZaikoLabel.Name = "ZengetsuMatsuZaikoLabel"
			Me.ZengetsuMatsuZaikoLabel.Size = New Size(80, 18)
			Me.ZengetsuMatsuZaikoLabel.TabIndex = 60
			Me.ZengetsuMatsuZaikoLabel.Text = "前月未在庫"
			Me.ZengetsuMatsuZaikoLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'LblBuhinName
			'
			Me.LblBuhinName.BorderStyle = BorderStyle.FixedSingle
			Me.LblBuhinName.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblBuhinName.Location = New Point(294, 78)
			Me.LblBuhinName.Name = "LblBuhinName"
			Me.LblBuhinName.Padding = New Padding(3, 0, 0, 0)
			Me.LblBuhinName.Size = New Size(181, 26)
			Me.LblBuhinName.TabIndex = 61
			Me.LblBuhinName.Text = "XXXXXXXXXXXXXXXXXXXX"
			Me.LblBuhinName.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblTana1
			'
			Me.LblTana1.BorderStyle = BorderStyle.FixedSingle
			Me.LblTana1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblTana1.Location = New Point(481, 78)
			Me.LblTana1.Name = "LblTana1"
			Me.LblTana1.Padding = New Padding(3, 0, 0, 0)
			Me.LblTana1.Size = New Size(81, 26)
			Me.LblTana1.TabIndex = 62
			Me.LblTana1.Text = "XXXXXXXX"
			Me.LblTana1.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblTana2
			'
			Me.LblTana2.BorderStyle = BorderStyle.FixedSingle
			Me.LblTana2.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblTana2.Location = New Point(561, 78)
			Me.LblTana2.Name = "LblTana2"
			Me.LblTana2.Padding = New Padding(3, 0, 0, 0)
			Me.LblTana2.Size = New Size(80, 26)
			Me.LblTana2.TabIndex = 63
			Me.LblTana2.Text = "XXXXXXXX"
			Me.LblTana2.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblTana3
			'
			Me.LblTana3.BorderStyle = BorderStyle.FixedSingle
			Me.LblTana3.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblTana3.Location = New Point(640, 78)
			Me.LblTana3.Name = "LblTana3"
			Me.LblTana3.Padding = New Padding(3, 0, 0, 0)
			Me.LblTana3.Size = New Size(81, 26)
			Me.LblTana3.TabIndex = 64
			Me.LblTana3.Text = "XXXXXXXX"
			Me.LblTana3.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblIkisakiCd
			'
			Me.LblIkisakiCd.BorderStyle = BorderStyle.FixedSingle
			Me.LblIkisakiCd.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblIkisakiCd.Location = New Point(614, 122)
			Me.LblIkisakiCd.Name = "LblIkisakiCd"
			Me.LblIkisakiCd.Padding = New Padding(3, 0, 0, 0)
			Me.LblIkisakiCd.Size = New Size(112, 26)
			Me.LblIkisakiCd.TabIndex = 65
			Me.LblIkisakiCd.Text = "XXXXXXXXXXXX"
			Me.LblIkisakiCd.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblKikaku
			'
			Me.LblKikaku.BorderStyle = BorderStyle.FixedSingle
			Me.LblKikaku.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblKikaku.Location = New Point(732, 122)
			Me.LblKikaku.Name = "LblKikaku"
			Me.LblKikaku.Padding = New Padding(3, 0, 0, 0)
			Me.LblKikaku.Size = New Size(211, 26)
			Me.LblKikaku.TabIndex = 66
			Me.LblKikaku.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
			Me.LblKikaku.TextAlign = ContentAlignment.MiddleLeft
			'
			'LblZennenMatuZaiko
			'
			Me.LblZennenMatuZaiko.BorderStyle = BorderStyle.FixedSingle
			Me.LblZennenMatuZaiko.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblZennenMatuZaiko.ForeColor = Color.Red
			Me.LblZennenMatuZaiko.Location = New Point(12, 178)
			Me.LblZennenMatuZaiko.Name = "LblZennenMatuZaiko"
			Me.LblZennenMatuZaiko.Padding = New Padding(3, 0, 0, 0)
			Me.LblZennenMatuZaiko.Size = New Size(80, 26)
			Me.LblZennenMatuZaiko.TabIndex = 67
			Me.LblZennenMatuZaiko.Text = "Z,ZZZ,ZZ9"
			Me.LblZennenMatuZaiko.TextAlign = ContentAlignment.MiddleRight
			'
			'LblUkeireRuikei
			'
			Me.LblUkeireRuikei.BorderStyle = BorderStyle.FixedSingle
			Me.LblUkeireRuikei.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblUkeireRuikei.ForeColor = Color.DarkGreen
			Me.LblUkeireRuikei.Location = New Point(98, 178)
			Me.LblUkeireRuikei.Name = "LblUkeireRuikei"
			Me.LblUkeireRuikei.Padding = New Padding(3, 0, 0, 0)
			Me.LblUkeireRuikei.Size = New Size(80, 26)
			Me.LblUkeireRuikei.TabIndex = 68
			Me.LblUkeireRuikei.Text = "Z,ZZZ,ZZ9"
			Me.LblUkeireRuikei.TextAlign = ContentAlignment.MiddleRight
			'
			'LblHaraidashiRuikei
			'
			Me.LblHaraidashiRuikei.BorderStyle = BorderStyle.FixedSingle
			Me.LblHaraidashiRuikei.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblHaraidashiRuikei.ForeColor = Color.Blue
			Me.LblHaraidashiRuikei.Location = New Point(184, 178)
			Me.LblHaraidashiRuikei.Name = "LblHaraidashiRuikei"
			Me.LblHaraidashiRuikei.Padding = New Padding(3, 0, 0, 0)
			Me.LblHaraidashiRuikei.Size = New Size(80, 26)
			Me.LblHaraidashiRuikei.TabIndex = 69
			Me.LblHaraidashiRuikei.Text = "Z,ZZZ,ZZ9"
			Me.LblHaraidashiRuikei.TextAlign = ContentAlignment.MiddleRight
			'
			'LblZengetsuMatsuZaiko
			'
			Me.LblZengetsuMatsuZaiko.BorderStyle = BorderStyle.FixedSingle
			Me.LblZengetsuMatsuZaiko.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblZengetsuMatsuZaiko.ForeColor = Color.Red
			Me.LblZengetsuMatsuZaiko.Location = New Point(270, 178)
			Me.LblZengetsuMatsuZaiko.Name = "LblZengetsuMatsuZaiko"
			Me.LblZengetsuMatsuZaiko.Padding = New Padding(3, 0, 0, 0)
			Me.LblZengetsuMatsuZaiko.Size = New Size(80, 26)
			Me.LblZengetsuMatsuZaiko.TabIndex = 70
			Me.LblZengetsuMatsuZaiko.Text = "Z,ZZZ,ZZ9"
			Me.LblZengetsuMatsuZaiko.TextAlign = ContentAlignment.MiddleRight
			'
			'LblTorihinNo
			'
			Me.LblTorihinNo.BorderStyle = BorderStyle.FixedSingle
			Me.LblTorihinNo.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblTorihinNo.Location = New Point(727, 78)
			Me.LblTorihinNo.Name = "LblTorihinNo"
			Me.LblTorihinNo.Padding = New Padding(3, 0, 0, 0)
			Me.LblTorihinNo.Size = New Size(216, 26)
			Me.LblTorihinNo.TabIndex = 71
			Me.LblTorihinNo.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
			Me.LblTorihinNo.TextAlign = ContentAlignment.MiddleLeft
			'
			'CheckBoxDate
			'
			Me.CheckBoxDate.Checked = True
			Me.CheckBoxDate.CheckState = CheckState.Checked
			Me.CheckBoxDate.Font = New Font("ＭＳ Ｐゴシック", 9.0!)
			Me.CheckBoxDate.Location = New Point(165, 78)
			Me.CheckBoxDate.Name = "CheckBoxDate"
			Me.CheckBoxDate.Size = New Size(18, 25)
			Me.CheckBoxDate.TabIndex = 1
			Me.CheckBoxDate.UseVisualStyleBackColor = True
			'
			'LblMessage
			'
			Me.LblMessage.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
			Me.LblMessage.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LblMessage.ForeColor = Color.Red
			Me.LblMessage.Location = New Point(631, 181)
			Me.LblMessage.Name = "LblMessage"
			Me.LblMessage.Size = New Size(312, 38)
			Me.LblMessage.TabIndex = 72
			Me.LblMessage.Text = "ここにメッセージを表示します。"
			Me.LblMessage.TextAlign = ContentAlignment.TopRight
			'
			'NextButton
			'
			Me.NextButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NextButton.Location = New Point(512, 119)
			Me.NextButton.Name = "NextButton"
			Me.NextButton.Size = New Size(80, 30)
			Me.NextButton.TabIndex = 5
			Me.NextButton.Text = "次部品"
			Me.NextButton.UseVisualStyleBackColor = True
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(182, 78)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(106, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'CclBuhinCode
			'
			Me.CclBuhinCode.BackColor = Color.LightGoldenrodYellow
			Me.CclBuhinCode.Font = New Font("ＭＳ Ｐゴシック", 9.5!)
			Me.CclBuhinCode.ImeMode = ImeMode.Disable
			Me.CclBuhinCode.Location = New Point(12, 77)
			Me.CclBuhinCode.Mask = "aaaa-aaa-aaa-aa"
			Me.CclBuhinCode.Name = "CclBuhinCode"
			Me.CclBuhinCode.Size = New Size(141, 20)
			Me.CclBuhinCode.TabIndex = 0
			'
			'UcSelectGridView1
			'
			Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcSelectGridView1.Location = New Point(12, 218)
			Me.UcSelectGridView1.Name = "UcSelectGridView1"
			Me.UcSelectGridView1.Size = New Size(931, 393)
			Me.UcSelectGridView1.TabIndex = 6
			'
			'ComboTori
			'
			Me.ComboTori.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.ComboTori.AutoCompleteSource = AutoCompleteSource.ListItems
			Me.ComboTori.BackColor = SystemColors.Window
			Me.ComboTori.ColumnCode = "TORI_CD"
			Me.ComboTori.ColumnName = "TORI_NAME"
			Me.ComboTori.FlatStyle = FlatStyle.Popup
			Me.ComboTori.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ComboTori.FormattingEnabled = True
			Me.ComboTori.ImeMode = ImeMode.Disable
			Me.ComboTori.Location = New Point(12, 122)
			Me.ComboTori.MaxLength = 8
			Me.ComboTori.Name = "ComboTori"
			Me.ComboTori.Size = New Size(109, 20)
			Me.ComboTori.TabIndex = 3
			Me.ComboTori.TableName = "M_TORI"
			'
			'InquiryUkeharaiZissekiForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(957, 670)
			Me.Controls.Add(Me.UcSelectGridView1)
			Me.Controls.Add(Me.NextButton)
			Me.Controls.Add(Me.LblMessage)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.CheckBoxDate)
			Me.Controls.Add(Me.ComboTori)
			Me.Controls.Add(Me.CclBuhinCode)
			Me.Controls.Add(Me.LblTorihinNo)
			Me.Controls.Add(Me.LblZengetsuMatsuZaiko)
			Me.Controls.Add(Me.LblHaraidashiRuikei)
			Me.Controls.Add(Me.LblUkeireRuikei)
			Me.Controls.Add(Me.LblZennenMatuZaiko)
			Me.Controls.Add(Me.LblKikaku)
			Me.Controls.Add(Me.LblIkisakiCd)
			Me.Controls.Add(Me.LblTana3)
			Me.Controls.Add(Me.LblTana2)
			Me.Controls.Add(Me.LblTana1)
			Me.Controls.Add(Me.LblBuhinName)
			Me.Controls.Add(Me.ZengetsuMatsuZaikoLabel)
			Me.Controls.Add(Me.HaraidashiRuikeiLabel)
			Me.Controls.Add(Me.UkeireRuikeiLabel)
			Me.Controls.Add(Me.ZennenMatuZaikoLabel)
			Me.Controls.Add(Me.KikakuLabel)
			Me.Controls.Add(Me.ToriCdLabel)
			Me.Controls.Add(Me.IkisakiCdLabel)
			Me.Controls.Add(Me.TorihinNoLabel)
			Me.Controls.Add(Me.Tana3Label)
			Me.Controls.Add(Me.Tana2Label)
			Me.Controls.Add(Me.Tana1Label)
			Me.Controls.Add(Me.BuhinNameLabel)
			Me.Controls.Add(Me.LblTorihikiName)
			Me.Controls.Add(Me.IUHZ_BackButton)
			Me.Controls.Add(Me.OutPutButton)
			Me.Controls.Add(Me.NengetsuLabel)
			Me.Controls.Add(Me.SearchButton)
			Me.Controls.Add(Me.BuhinLabel)
			Me.Controls.Add(Me.TorihikiNameLabel)
			Me.Controls.Add(Me.FormTitleLabel)
			Me.KeyPreview = True
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "InquiryUkeharaiZissekiForm"
			Me.Text = "受払実績画面"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Friend Overridable Property CmpSgv As CmpSelectGridView
			Get
				Return Me._CmpSgv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CmpSelectGridView)
				Me._CmpSgv = value
			End Set
		End Property

		Private Sub InquiryUkeharaiZissekiForm_Load(sender As Object, e As EventArgs)
			Me.ComboTori.SetItemList()
			Dim cclDateTimePicker As CclDateTimePicker = Me.CclDateTimePicker
			Dim dateTime As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
			cclDateTimePicker.Value = dateTime
			Me.SetLabel()
			Me.SetupGridView()
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
			Me.OutPutButton.Enabled = False
		End Sub

		Private Sub CheckBoxDate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDate.CheckedChanged
			If Me.CheckBoxDate.Checked Then
				Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Else
				Me.CclDateTimePicker.CustomFormat = "yyyy年"
			End If
		End Sub

		Private Sub InquiryUkeharaiZissekiForm_KeyUp(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.F5 AndAlso Me.OutPutButton.Enabled Then
				Me.OutPutButton.PerformClick()
			End If
		End Sub

		Private Sub SearchOrNextButton_Common(buttonName As String)
			Dim flag As Boolean = True
			Me.OutPutButton.Enabled = False
			Cursor.Current = Cursors.WaitCursor
			Dim value As String = Me.CclBuhinCode.Value
			Dim syoriymd As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			Dim text As String = Me.ComboTori.Text
			If String.IsNullOrEmpty(value) Then
				Cursor.Current = Cursors.[Default]
				DlgMessageBox.Show("部品コードを入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclBuhinCode.Focus()
				Return
			End If
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年月を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclDateTimePicker.Focus()
				Return
			End If
			If Me.UcSelectGridView1.CmpSgv.Rows.Count > 0 Then
				Dim num As Integer = 0
				Dim num2 As Integer = Me.UcSelectGridView1.CmpSgv.Rows.Count - 1
				For i As Integer = num To num2
					Me.UcSelectGridView1.CmpSgv.Rows.RemoveAt(0)
				Next
			End If
			Dim sSQL As String = Me.makeHeaderSql(text, value, syoriymd, Me.CheckBoxDate.Checked, buttonName)
			Me.HeaderTable.Clear()
			Me.SetLabel()
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sSQL, True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag = False
				Else
					Me.HeaderTable = sqlDataBase.DbDataTable
					Me.SetLabel()
					If sqlDataBase.DbDataTable.Rows.Count = 0 Then
						If Me.SearchButton.Name.Equals(buttonName) Then
							Me.LblMessage.Text = "部品マスタに該当データがありませんでした。"
						Else
							Me.LblMessage.Text = "次部品データがありません。"
						End If
						flag = False
					ElseIf sqlDataBase.DbDataTable.Rows.Count >= 2 Then
						Me.LblMessage.Text = "この部品コードには複数の取引先が存在します。" & vbCrLf & "取引先を選択して再検索してください。"
						Me.ComboTori.Focus()
						flag = False
					ElseIf Operators.ConditionalCompareObjectEqual(sqlDataBase.DbDataTable.Rows(0)("M_TORI_REC_COUNT"), 0, False) Then
						Me.LblMessage.Text = "取引先マスタに該当データがありませんでした。"
						Me.ComboTori.Focus()
						flag = False
					End If
				End If
			End Using
			If Not flag Then
				Cursor.Current = Cursors.[Default]
				Return
			End If
			Dim zaikosuCommon As New ZaikosuCommon()
			Dim zaikosuCommon2 As ZaikosuCommon = zaikosuCommon
			Dim toricd As String = Conversions.ToString(Me.HeaderTable.Rows(0)("取引先"))
			Dim buhincd As String = Conversions.ToString(Me.HeaderTable.Rows(0)("部品コード"))
			Dim syoriymd2 As New DateTime(syoriymd.Year, 1, 1)
			Dim zaikosu As String = zaikosuCommon2.GetZaikosu(toricd, buhincd, syoriymd2, False)
			If Not String.IsNullOrEmpty(zaikosu) Then
				DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag = False
			End If
			If Not flag Then
				Cursor.Current = Cursors.[Default]
				Return
			End If
			Me.HeaderTable.Rows(0)("前年未在庫") = zaikosuCommon.Zaikosu
			If Me.CheckBoxDate.Checked Then
				sSQL = Me.makeHeaderOtherSql(Conversions.ToString(Me.HeaderTable.Rows(0)("取引先")), Conversions.ToString(Me.HeaderTable.Rows(0)("部品コード")), syoriymd)
				Using sqlDataBase2 As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
					Dim sqldata2 As String = sqlDataBase2.getSQLData(sSQL, True)
					If Not String.IsNullOrEmpty(sqldata2) Then
						DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						flag = False
					ElseIf sqlDataBase2.DbDataTable.Rows.Count = 0 Then
						Me.HeaderTable.Rows(0)("受入累計") = 0
						Me.HeaderTable.Rows(0)("払出累計") = 0
					Else
						Me.HeaderTable.Rows(0)("受入累計") = RuntimeHelpers.GetObjectValue(sqlDataBase2.DbDataTable.Rows(0)("受入累計"))
						Me.HeaderTable.Rows(0)("払出累計") = RuntimeHelpers.GetObjectValue(sqlDataBase2.DbDataTable.Rows(0)("払出累計"))
					End If
					Me.HeaderTable.Rows(0)("前月未在庫") = Operators.SubtractObject(Operators.AddObject(Me.HeaderTable.Rows(0)("前年未在庫"), Me.HeaderTable.Rows(0)("受入累計")), Me.HeaderTable.Rows(0)("払出累計"))
				End Using
			End If
			If Not flag Then
				Cursor.Current = Cursors.[Default]
				Return
			End If
			Me.SetLabel()
			sSQL = Me.makeBodySql(Conversions.ToString(Me.HeaderTable.Rows(0)("取引先")), Conversions.ToString(Me.HeaderTable.Rows(0)("部品コード")), syoriymd, Me.CheckBoxDate.Checked)
			Using sqlDataBase3 As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim sqldata3 As String = sqlDataBase3.getSQLData(sSQL, True)
				If Not String.IsNullOrEmpty(sqldata3) Then
					Cursor.Current = Cursors.[Default]
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag = False
				ElseIf sqlDataBase3.DbDataTable.Rows.Count = 0 Then
					Me.LblMessage.Text = "受払実績テーブルに該当データがありませんでした。"
					flag = False
				Else
					Me.BodyTable = sqlDataBase3.DbDataTable
				End If
			End Using
			If Not flag Then
				Cursor.Current = Cursors.[Default]
				Return
			End If
			Dim num3 As Integer
			If Me.CheckBoxDate.Checked Then
				num3 = Conversions.ToInteger(Me.HeaderTable.Rows(0)("前月未在庫"))
			Else
				num3 = Conversions.ToInteger(Me.HeaderTable.Rows(0)("前年未在庫"))
			End If
			Try
				For Each obj As Object In Me.BodyTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("受入個数"))) Then
						num3 = Conversions.ToInteger(Operators.AddObject(num3, dataRow("受入個数")))
					End If
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("払出個数"))) Then
						num3 = Conversions.ToInteger(Operators.SubtractObject(num3, dataRow("払出個数")))
					End If
					dataRow("当月残") = num3
					Me.UcSelectGridView1.CmpSgv.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataRow("月日")), RuntimeHelpers.GetObjectValue(dataRow("伝票NO")), String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(dataRow("受入個数"))), RuntimeHelpers.GetObjectValue(dataRow("納入先")), String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(dataRow("払出個数"))), String.Format("{0:#,0.00}", RuntimeHelpers.GetObjectValue(dataRow("納入単価"))), String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(dataRow("当月残"))), RuntimeHelpers.GetObjectValue(dataRow("出庫オーダー"))})
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.UcSelectGridView1.CmpSgv.CurrentCell = Nothing
			Me.OutPutButton.Enabled = True
			Cursor.Current = Cursors.[Default]
		End Sub

		Private Sub SetupGridView()
			Dim gridColumn As New GridColumn()
			Me.UcSelectGridView1.CmpSgv.AutoGenerateColumns = False
			Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeight = 28
			Dim dataGridViewTextBoxColumn As DataGridViewTextBoxColumn = gridColumn.CreateTextColumn("YearMonth", "月日", 58, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("DenNo", "伝票NO", 120, True, ""))
			dataGridViewTextBoxColumn = gridColumn.CreateTextColumn("UkeireKosu", "受入個数", 90, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			dataGridViewTextBoxColumn.DefaultCellStyle.ForeColor = Color.DarkGreen
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			dataGridViewTextBoxColumn = gridColumn.CreateTextColumn("Saki", "納入先", 100, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			dataGridViewTextBoxColumn = gridColumn.CreateTextColumn("UkeireKosu", "払出個数", 90, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			dataGridViewTextBoxColumn.DefaultCellStyle.ForeColor = Color.Blue
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			dataGridViewTextBoxColumn = gridColumn.CreateTextColumn("Tanka", "納入単価", 90, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			dataGridViewTextBoxColumn = gridColumn.CreateTextColumn("Zaikosu", "当月残", 90, True, "")
			dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			dataGridViewTextBoxColumn.DefaultCellStyle.ForeColor = Color.Red
			Me.UcSelectGridView1.CmpSgv.Columns.Add(dataGridViewTextBoxColumn)
			Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("Order", "出庫オーダー", 275, True, ""))
			Try
				For Each obj As Object In Me.UcSelectGridView1.CmpSgv.Columns
					Dim dataGridViewColumn As DataGridViewColumn = CType(obj, DataGridViewColumn)
					dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub SetLabel()
			If Me.HeaderTable.Rows.Count <> 1 Then
				Me.LblBuhinName.Text = String.Empty
				Me.LblTana1.Text = String.Empty
				Me.LblTana2.Text = String.Empty
				Me.LblTana3.Text = String.Empty
				Me.LblTorihinNo.Text = String.Empty
				Me.LblIkisakiCd.Text = String.Empty
				Me.LblTorihikiName.Text = String.Empty
				Me.LblKikaku.Text = String.Empty
				Me.LblZennenMatuZaiko.Text = String.Empty
				Me.LblUkeireRuikei.Text = String.Empty
				Me.LblHaraidashiRuikei.Text = String.Empty
				Me.LblZengetsuMatsuZaiko.Text = String.Empty
				Me.LblMessage.Text = String.Empty
			Else
				Me.LblBuhinName.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("品名"))
				Me.LblTana1.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("棚番1"))
				Me.LblTana2.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("棚番2"))
				Me.LblTana3.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("棚番3"))
				Me.LblTorihinNo.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("取引先品番"))
				Me.LblIkisakiCd.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("行先"))
				Me.LblTorihikiName.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("取引先名称"))
				Me.LblKikaku.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("規格"))
				Me.LblZennenMatuZaiko.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(Me.HeaderTable.Rows(0)("前年未在庫")))
				Me.LblUkeireRuikei.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(Me.HeaderTable.Rows(0)("受入累計")))
				Me.LblHaraidashiRuikei.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(Me.HeaderTable.Rows(0)("払出累計")))
				Me.LblZengetsuMatsuZaiko.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(Me.HeaderTable.Rows(0)("前月未在庫")))
				Me.ComboTori.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("取引先"))
				Me.CclBuhinCode.Text = Conversions.ToString(Me.HeaderTable.Rows(0)("部品コード"))
			End If
		End Sub

		Private Function makeHeaderSql(toricd As String, buhincd As String, syoriymd As DateTime, isNenGetsu As Boolean, buttonName As String) As String
			Dim stringBuilder As New StringBuilder()
			Dim result As String = ""
			stringBuilder.Append("       SELECT ")
			stringBuilder.Append("           {0} ")
			stringBuilder.Append("           BUH.BUHIN_CD                                     AS {1}, ")
			stringBuilder.Append("       " & vbTab & "  ISNULL(BUH.BUHIN_NAME, '')                       AS {2}, ")
			stringBuilder.Append(vbTab & "       " & vbTab & "  ISNULL(BUH.TANA_NO1, '')                         AS {3}, ")
			stringBuilder.Append("       " & vbTab & "  ISNULL(BUH.TANA_NO2, '')                         AS {4}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  ISNULL(BUH.TANA_NO3, '')                         AS {5}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  ISNULL(BUH.TORIHIN_NO, '')                       AS {6}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  ISNULL(BUH.IKISAKI_CD, '')                       AS {7}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  BUH.TORI_CD                                      AS {8}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  ISNULL(TOR.TORI_NAME, '')                        AS {9}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  ISNULL(BUH.KIKAKU, '')                           AS {10}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  '{11}'                                           AS {12}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  Null                                             AS {13}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  Null                                             AS {14}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  Null                                             AS {15}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  Null                                             AS {16}, ")
			stringBuilder.Append(vbTab & "     " & vbTab & "  CASE WHEN TOR.TORI_CD IS NULL THEN 0 ELSE 1 END  AS {17} ")
			stringBuilder.Append("       FROM  ")
			stringBuilder.Append(vbTab & vbTab & "       [Ukeharai].[M_BUHIN] AS BUH ")
			stringBuilder.Append("       LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "       [Ukeharai].[M_TORI]  AS TOR ")
			stringBuilder.Append("       ON ")
			stringBuilder.Append(vbTab & vbTab & "       BUH.TORI_CD = TOR.TORI_CD ")
			If Me.SearchButton.Name.Equals(buttonName) Then
				stringBuilder.Append("   WHERE ")
				stringBuilder.Append(vbTab & "       BUH.BUHIN_CD = '{18}' ")
				If Not String.IsNullOrEmpty(toricd) Then
					stringBuilder.Append(" AND ")
					stringBuilder.Append("    BUH.TORI_CD = '{19}' ")
				End If
			ElseIf Me.NextButton.Name.Equals(buttonName) Then
				stringBuilder.Append("   WHERE ")
				stringBuilder.Append("     ( ")
				stringBuilder.Append(vbTab & "         BUH.BUHIN_CD > '{18}' ")
				stringBuilder.Append("       AND ")
				stringBuilder.Append("          BUH.TORI_CD >= '{19}' ")
				stringBuilder.Append("     ) ")
				stringBuilder.Append("     OR ")
				stringBuilder.Append("     ( ")
				stringBuilder.Append(vbTab & "         BUH.TORI_CD > '{19}' ")
				stringBuilder.Append("     ) ")
			End If
			stringBuilder.Append("       ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & "       BUH.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "       BUH.BUHIN_CD ")
			Dim text As String
			If isNenGetsu Then
				text = syoriymd.ToString("yyyy年MM月")
			Else
				text = syoriymd.ToString("yyyy年")
			End If
			If Me.SearchButton.Name.Equals(buttonName) Then
				If Not String.IsNullOrEmpty(toricd) Then
					result = String.Format(stringBuilder.ToString(), New Object() {"", "部品コード", "品名", "棚番1", "棚番2", "棚番3", "取引先品番", "行先", "取引先", "取引先名称", "規格", text, "年月", "前年未在庫", "受入累計", "払出累計", "前月未在庫", "M_TORI_REC_COUNT", buhincd, toricd})
				Else
					result = String.Format(stringBuilder.ToString(), New Object() {"", "部品コード", "品名", "棚番1", "棚番2", "棚番3", "取引先品番", "行先", "取引先", "取引先名称", "規格", text, "年月", "前年未在庫", "受入累計", "払出累計", "前月未在庫", "M_TORI_REC_COUNT", buhincd})
				End If
			ElseIf Me.NextButton.Name.Equals(buttonName) Then
				result = String.Format(stringBuilder.ToString(), New Object() {"TOP 1", "部品コード", "品名", "棚番1", "棚番2", "棚番3", "取引先品番", "行先", "取引先", "取引先名称", "規格", text, "年月", "前年未在庫", "受入累計", "払出累計", "前月未在庫", "M_TORI_REC_COUNT", buhincd, toricd})
			End If
			Return result
		End Function

		Private Function makeHeaderOtherSql(toricd As String, buhincd As String, syoriymd As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(vbTab & "      ISNULL(SUM(UKESU), 0)                                    AS {0}, ")
			stringBuilder.Append(vbTab & "      ISNULL(SUM(HARASU), 0)                                   AS {1} ")
			stringBuilder.Append(" FROM  ")
			stringBuilder.Append("       [Ukeharai].[T_UKEHARAIJISSEKI] ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & " TORI_CD = '{2}' ")
			stringBuilder.Append(" " & vbTab & "  AND ")
			stringBuilder.Append(vbTab & vbTab & "     BUHIN_CD = '{3}' ")
			stringBuilder.Append(vbTab & "  AND ")
			stringBuilder.Append(vbTab & vbTab & "     FORMAT(UKEHARA_YYYYMM, 'yyyy') = '{4}' ")
			stringBuilder.Append(vbTab & "  AND ")
			stringBuilder.Append(" " & vbTab & vbTab & " FORMAT(UKEHARA_YYYYMM, 'MM') < '{5}' ")
			stringBuilder.Append(" GROUP BY ")
			stringBuilder.Append(vbTab & vbTab & " TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & " BUHIN_CD ")
			Return String.Format(stringBuilder.ToString(), New Object() {"受入累計", "払出累計", toricd, buhincd, syoriymd.ToString("yyyy"), syoriymd.ToString("MM")})
		End Function

		Private Function makeBodySql(toricd As String, buhincd As String, syoriymd As DateTime, isNenGetsu As Boolean) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append("     FORMAT(MEI.UKEHARA_YYYYMMDD, 'MM.dd')                                                            AS {0}, ")
			stringBuilder.Append("     MEI.DEN_NO                                                                                       AS {1}, ")
			stringBuilder.Append(vbTab & "    CASE WHEN MEI.UKEHARAI_KBN = '1' THEN MEI.KOSU ELSE NULL END                                     AS {2}, ")
			stringBuilder.Append("     SAK.SAKI_ABBREVIATION                                                                            AS {3}, ")
			stringBuilder.Append(vbTab & "    CASE WHEN MEI.UKEHARAI_KBN = '2' THEN MEI.KOSU ELSE NULL END                                     AS {4}, ")
			stringBuilder.Append(vbTab & "    CASE WHEN MEI.KOSU <> 0 AND MEI.KINGAKU <> 0 THEN ROUND(MEI.KINGAKU/MEI.KOSU, 2) ELSE NULL END   AS {5}, ")
			stringBuilder.Append(vbTab & "    0                                                                                                AS {6}, ")
			stringBuilder.Append(vbTab & "    MEI.REMARKS1 + MEI.REMARKS2 + MEI.REMARKS3                                                       AS {7} ")
			stringBuilder.Append(" FROM  ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[T_UKEHARAIMEISAI] AS MEI ")
			stringBuilder.Append(" LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_SAKI]  AS SAK ")
			stringBuilder.Append(" ON ")
			stringBuilder.Append(vbTab & vbTab & "MEI.SAKI_CD = SAK.SAKI_CD ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(vbTab & vbTab & "MEI.TORI_CD = '{8}' ")
			stringBuilder.Append(vbTab & "  AND ")
			stringBuilder.Append(vbTab & vbTab & "MEI.BUHIN_CD = '{9}' ")
			stringBuilder.Append(vbTab & "  AND ")
			If isNenGetsu Then
				stringBuilder.Append(vbTab & "FORMAT(MEI.UKEHARA_YYYYMMDD, 'yyyyMM') = '{10}' ")
			Else
				stringBuilder.Append(vbTab & "FORMAT(MEI.UKEHARA_YYYYMMDD, 'yyyy') = '{10}' ")
			End If
			stringBuilder.Append(" ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & " MEI.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & " MEI.BUHIN_CD, ")
			stringBuilder.Append(vbTab & vbTab & " MEI.UKEHARA_YYYYMMDD, ")
			stringBuilder.Append(vbTab & vbTab & " MEI.DEN_NO, ")
			stringBuilder.Append(vbTab & vbTab & " MEI.UKEHARAI_KBN ")
			Dim result As String
			If isNenGetsu Then
				result = String.Format(stringBuilder.ToString(), New Object() {"月日", "伝票NO", "受入個数", "納入先", "払出個数", "納入単価", "当月残", "出庫オーダー", toricd, buhincd, syoriymd.ToString("yyyyMM")})
			Else
				result = String.Format(stringBuilder.ToString(), New Object() {"月日", "伝票NO", "受入個数", "納入先", "払出個数", "納入単価", "当月残", "出庫オーダー", toricd, buhincd, syoriymd.ToString("yyyy")})
			End If
			Return result
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("SearchButton")>
		Private WithEvents SearchButton As Button

		<AccessedThroughProperty("BuhinLabel")>
		Private WithEvents BuhinLabel As Label

		<AccessedThroughProperty("NengetsuLabel")>
		Private WithEvents NengetsuLabel As Label

		<AccessedThroughProperty("IUHZ_BackButton")>
		Private WithEvents IUHZ_BackButton As Button

		<AccessedThroughProperty("OutPutButton")>
		Private WithEvents OutPutButton As Button

		<AccessedThroughProperty("LblTorihikiName")>
		Private WithEvents LblTorihikiName As Label

		<AccessedThroughProperty("TorihikiNameLabel")>
		Private WithEvents TorihikiNameLabel As Label

		<AccessedThroughProperty("BuhinNameLabel")>
		Private WithEvents BuhinNameLabel As Label

		<AccessedThroughProperty("Tana1Label")>
		Private WithEvents Tana1Label As Label

		<AccessedThroughProperty("Tana2Label")>
		Private WithEvents Tana2Label As Label

		<AccessedThroughProperty("Tana3Label")>
		Private WithEvents Tana3Label As Label

		<AccessedThroughProperty("TorihinNoLabel")>
		Private WithEvents TorihinNoLabel As Label

		<AccessedThroughProperty("IkisakiCdLabel")>
		Private WithEvents IkisakiCdLabel As Label

		<AccessedThroughProperty("ToriCdLabel")>
		Private WithEvents ToriCdLabel As Label

		<AccessedThroughProperty("KikakuLabel")>
		Private WithEvents KikakuLabel As Label

		<AccessedThroughProperty("ZennenMatuZaikoLabel")>
		Private WithEvents ZennenMatuZaikoLabel As Label

		<AccessedThroughProperty("UkeireRuikeiLabel")>
		Private WithEvents UkeireRuikeiLabel As Label

		<AccessedThroughProperty("HaraidashiRuikeiLabel")>
		Private WithEvents HaraidashiRuikeiLabel As Label

		<AccessedThroughProperty("ZengetsuMatsuZaikoLabel")>
		Private WithEvents ZengetsuMatsuZaikoLabel As Label

		<AccessedThroughProperty("LblBuhinName")>
		Private WithEvents LblBuhinName As Label

		<AccessedThroughProperty("LblTana1")>
		Private WithEvents LblTana1 As Label

		<AccessedThroughProperty("LblTana2")>
		Private WithEvents LblTana2 As Label

		<AccessedThroughProperty("LblTana3")>
		Private WithEvents LblTana3 As Label

		<AccessedThroughProperty("LblIkisakiCd")>
		Private WithEvents LblIkisakiCd As Label

		<AccessedThroughProperty("LblKikaku")>
		Private WithEvents LblKikaku As Label

		<AccessedThroughProperty("LblZennenMatuZaiko")>
		Private WithEvents LblZennenMatuZaiko As Label

		<AccessedThroughProperty("LblUkeireRuikei")>
		Private WithEvents LblUkeireRuikei As Label

		<AccessedThroughProperty("LblHaraidashiRuikei")>
		Private WithEvents LblHaraidashiRuikei As Label

		<AccessedThroughProperty("LblZengetsuMatsuZaiko")>
		Private WithEvents LblZengetsuMatsuZaiko As Label

		<AccessedThroughProperty("LblTorihinNo")>
		Private WithEvents LblTorihinNo As Label

		<AccessedThroughProperty("CclBuhinCode")>
		Private WithEvents CclBuhinCode As CclBuhinCode

		<AccessedThroughProperty("ComboTori")>
		Private WithEvents ComboTori As CmpComboBox

		<AccessedThroughProperty("CheckBoxDate")>
		Private WithEvents CheckBoxDate As CheckBox

		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		<AccessedThroughProperty("LblMessage")>
		Private WithEvents LblMessage As Label

		<AccessedThroughProperty("NextButton")>
		Private WithEvents NextButton As Button

		<AccessedThroughProperty("UcSelectGridView1")>
		Private WithEvents UcSelectGridView1 As UcSelectGridView

		<AccessedThroughProperty("CmpSgv")>
		Private _CmpSgv As CmpSelectGridView

		Private HeaderTable As DataTable

		Private BodyTable As DataTable

		Private Const HEAD_BUHIN_CD As String = "部品コード"

		Private Const HEAD_BUHIN_NAME As String = "品名"

		Private Const HEAD_TANA_NO1 As String = "棚番1"

		Private Const HEAD_TANA_NO2 As String = "棚番2"

		Private Const HEAD_TANA_NO3 As String = "棚番3"

		Private Const HEAD_TORIHIN_NO As String = "取引先品番"

		Private Const HEAD_IKISAKI_CD As String = "行先"

		Private Const HEAD_TORI_CD As String = "取引先"

		Private Const HEAD_TORI_NAME As String = "取引先名称"

		Private Const HEAD_KIKAKU As String = "規格"

		Private Const HEAD_NENGETU As String = "年月"

		Private Const HEAD_ZENNEN_ZAIKO As String = "前年未在庫"

		Private Const HEAD_UKEIRE_RUI As String = "受入累計"

		Private Const HEAD_HARAI_RUI As String = "払出累計"

		Private Const HEAD_ZENGETU_ZAIKO As String = "前月未在庫"

		Private Const HEAD_M_TORI_REC_COUNT As String = "M_TORI_REC_COUNT"

		Private Const BODY_YYMM As String = "月日"

		Private Const BODY_DEN_NO As String = "伝票NO"

		Private Const BODY_UKE_KOSU As String = "受入個数"

		Private Const BODY_SAKI As String = "納入先"

		Private Const BODY_HARAI_KOSU As String = "払出個数"

		Private Const BODY_TESU As String = "納入単価"

		Private Const BODY_ZAIKO As String = "当月残"

		Private Const BODY_ORDER As String = "出庫オーダー"

		Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
			Me.SearchOrNextButton_Common(Me.SearchButton.Name)
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
		End Sub

		Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
			Me.SearchOrNextButton_Common(Me.NextButton.Name)
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
		End Sub

		Private Sub OutPutButton_Click(sender As Object, e As EventArgs) Handles OutPutButton.Click
			Dim form As Form = New InquiryUkeharaiZissekiReportForm(Me.HeaderTable, Me.BodyTable)
			form.Show()
		End Sub

		Private Sub IUHZ_BackButton_Click(sender As Object, e As EventArgs) Handles IUHZ_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
