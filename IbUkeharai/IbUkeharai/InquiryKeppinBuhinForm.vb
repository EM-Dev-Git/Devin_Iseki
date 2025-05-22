Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.InquiryExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class InquiryKeppinBuhinForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.InquiryKeppinBuhinForm_Load
			Me._ftpkeppin = Nothing
			Me._isCancel = False
			Me._isErrer = False
			Me.FTP_FILE_BUHINSINDO_M = "M_BUHINSINDO_NOW.txt"
			Me.FTP_FILE_BUHINSINDO_K = "K_BUHINSINDO_NOW.txt"
			Me.FTP_FILE_BUHINSINDO_S = "S_BUHINSINDO_NOW.txt"
			Me.FTP_FILE_SISAN_M = "M_SISAN.txt"
			Me.FTP_FILE_SISAN_K = "K_SISAN.txt"
			Me.FTP_FILE_SISAN_S = "S_SISAN.txt"
			Me.FTP_FILE_CYUZAN_M = "M_CYUZAN.txt"
			Me.FTP_FILE_CYUZAN_K = "K_CYUZAN.txt"
			Me.FTP_FILE_CYUZAN_S = "S_CYUZAN.txt"
			Me.receiveFtpDir = Path.Combine("FTP", "22.欠品部品情報")
			Me.KYOTEN = New String() {"Matsuyama", "Kumamoto", "Shigenobu"}
			Me.DELETETABLE = New String() {"DELETE FROM Ukeharai.T_BUHINSINDO", "DELETE FROM Ukeharai.T_SISAN", "DELETE FROM Ukeharai.T_CYUZAN"}
			Me.csvDirectory = Path.Combine("csv", "22.欠品部品情報")
			Me.csvFileName = "欠品部品"
			Me.outPutDir = Path.Combine("kekka", "欠品")
			Me.saveTori = Nothing
			Me.saveM = False
			Me.saveK = False
			Me.saveS = False
			Me.BASESQL = "SELECT [KAKUNIN],[TORI_NAME],[BUHIN_CD],[BUHIN_NAME],[LINE],convert(varchar,[TEBAN]) + '日' as [TEBAN],DATEADD(day, -[TEBAN], [LINE]) as [NONYU],[ZAIKO],[FUSOKU_TOGETU],[FUSOKU_JIGETU],[CYUZAN],[NOKI],[NOHINSAKI],[NYUKABI] FROM Ukeharai.T_KEPPIN WHERE ([KAKUNIN] ='0' OR [NYUKABI] IS NULL) "
			Me._conf = Nothing
			Me._execFlag = False
			Me.ReViewFlag = False
			Me._titleName = String.Empty
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
#Region " フォーム "
		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.FormTitleLabel = New Label()
			Me.ToriCdLabel = New Label()
			Me.IKB_ReferButton = New Button()
			Me.IKB_BackButton = New Button()
			Me.IKB_UpdateButton = New Button()
			Me.Nouhin_M = New CheckBox()
			Me.Nouhin_S = New CheckBox()
			Me.Nouhin_K = New CheckBox()
			Me.IKB_OutPutButton = New Button()
			Me.NouhinLabel = New Label()
			Me.IKB_ExecutButton = New Button()
			Me.ConfirmationButton = New Button()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.CustDgv = New IbUkeharai.Util.CustomDataGridView(Me.components)
			Me.ComboTori = New IbUkeharai.Util.KeppinComboBox(Me.components)
			Me.UcDgv.SuspendLayout()
			CType(Me.CustDgv, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.FormTitleLabel.BackColor = Color.DarkCyan
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
			Me.FormTitleLabel.Location = New Point(14, 9)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(1346, 45)
			Me.FormTitleLabel.TabIndex = 40
			Me.FormTitleLabel.Text = "欠品部品情報"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'ToriCdLabel
			'
			Me.ToriCdLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ToriCdLabel.Location = New Point(25, 79)
			Me.ToriCdLabel.Name = "ToriCdLabel"
			Me.ToriCdLabel.Size = New Size(65, 18)
			Me.ToriCdLabel.TabIndex = 56
			Me.ToriCdLabel.Text = "取 引 先"
			Me.ToriCdLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'IKB_ReferButton
			'
			Me.IKB_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IKB_ReferButton.Location = New Point(731, 98)
			Me.IKB_ReferButton.Name = "IKB_ReferButton"
			Me.IKB_ReferButton.Size = New Size(80, 30)
			Me.IKB_ReferButton.TabIndex = 4
			Me.IKB_ReferButton.Text = "参照"
			Me.IKB_ReferButton.UseVisualStyleBackColor = True
			'
			'IKB_BackButton
			'
			Me.IKB_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.IKB_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IKB_BackButton.Location = New Point(1280, 585)
			Me.IKB_BackButton.Name = "IKB_BackButton"
			Me.IKB_BackButton.Size = New Size(80, 73)
			Me.IKB_BackButton.TabIndex = 9
			Me.IKB_BackButton.Text = "戻る"
			Me.IKB_BackButton.UseVisualStyleBackColor = True
			'
			'IKB_UpdateButton
			'
			Me.IKB_UpdateButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.IKB_UpdateButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IKB_UpdateButton.Location = New Point(827, 585)
			Me.IKB_UpdateButton.Name = "IKB_UpdateButton"
			Me.IKB_UpdateButton.Size = New Size(144, 73)
			Me.IKB_UpdateButton.TabIndex = 6
			Me.IKB_UpdateButton.Text = "登録" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ﾁｪｯｸﾏｰｸ・物流入荷日)"
			Me.IKB_UpdateButton.UseVisualStyleBackColor = True
			'
			'Nouhin_M
			'
			Me.Nouhin_M.AutoSize = True
			Me.Nouhin_M.Location = New Point(612, 83)
			Me.Nouhin_M.Name = "Nouhin_M"
			Me.Nouhin_M.Size = New Size(69, 16)
			Me.Nouhin_M.TabIndex = 1
			Me.Nouhin_M.Text = "M (松山)"
			Me.Nouhin_M.UseVisualStyleBackColor = True
			'
			'Nouhin_S
			'
			Me.Nouhin_S.AutoSize = True
			Me.Nouhin_S.Location = New Point(612, 128)
			Me.Nouhin_S.Name = "Nouhin_S"
			Me.Nouhin_S.Size = New Size(67, 16)
			Me.Nouhin_S.TabIndex = 3
			Me.Nouhin_S.Text = "S (重信)"
			Me.Nouhin_S.UseVisualStyleBackColor = True
			'
			'Nouhin_K
			'
			Me.Nouhin_K.AutoSize = True
			Me.Nouhin_K.Location = New Point(612, 106)
			Me.Nouhin_K.Name = "Nouhin_K"
			Me.Nouhin_K.Size = New Size(67, 16)
			Me.Nouhin_K.TabIndex = 2
			Me.Nouhin_K.Text = "K (熊本)"
			Me.Nouhin_K.UseVisualStyleBackColor = True
			'
			'IKB_OutPutButton
			'
			Me.IKB_OutPutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.IKB_OutPutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IKB_OutPutButton.Location = New Point(1173, 585)
			Me.IKB_OutPutButton.Name = "IKB_OutPutButton"
			Me.IKB_OutPutButton.Size = New Size(80, 73)
			Me.IKB_OutPutButton.TabIndex = 8
			Me.IKB_OutPutButton.Text = "データ出力" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(CSV)"
			Me.IKB_OutPutButton.UseVisualStyleBackColor = True
			'
			'NouhinLabel
			'
			Me.NouhinLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NouhinLabel.Location = New Point(488, 79)
			Me.NouhinLabel.Name = "NouhinLabel"
			Me.NouhinLabel.Size = New Size(103, 18)
			Me.NouhinLabel.TabIndex = 69
			Me.NouhinLabel.Text = " 納品先(工場区分)"
			Me.NouhinLabel.TextAlign = ContentAlignment.BottomCenter
			'
			'IKB_ExecutButton
			'
			Me.IKB_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.IKB_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.IKB_ExecutButton.Location = New Point(1000, 585)
			Me.IKB_ExecutButton.Name = "IKB_ExecutButton"
			Me.IKB_ExecutButton.Size = New Size(145, 73)
			Me.IKB_ExecutButton.TabIndex = 7
			Me.IKB_ExecutButton.Text = "データ取込" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(進度表・試算表" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "・注残(納期指定))"
			Me.IKB_ExecutButton.UseVisualStyleBackColor = True
			'
			'ConfirmationButton
			'
			Me.ConfirmationButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ConfirmationButton.Location = New Point(1070, 98)
			Me.ConfirmationButton.Name = "ConfirmationButton"
			Me.ConfirmationButton.Size = New Size(80, 30)
			Me.ConfirmationButton.TabIndex = 70
			Me.ConfirmationButton.TabStop = False
			Me.ConfirmationButton.Text = "確認済み"
			Me.ConfirmationButton.UseVisualStyleBackColor = True
			Me.ConfirmationButton.Visible = False
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Controls.Add(Me.CustDgv)
			Me.UcDgv.Location = New Point(18, 166)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(1342, 413)
			Me.UcDgv.TabIndex = 5
			'
			'CustDgv
			'
			Me.CustDgv.AllowUserToDeleteRows = False
			Me.CustDgv.AllowUserToResizeRows = False
			Me.CustDgv.BorderStyle = BorderStyle.None
			Me.CustDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.CustDgv.Dock = DockStyle.Fill
			Me.CustDgv.EnableHeadersVisualStyles = False
			Me.CustDgv.gridInfo = Nothing
			Me.CustDgv.IsRowNoView = False
			Me.CustDgv.Location = New Point(0, 0)
			Me.CustDgv.MultiSelect = False
			Me.CustDgv.Name = "CustDgv"
			Me.CustDgv.RowHeadersWidth = 55
			Me.CustDgv.RowTemplate.Height = 21
			Me.CustDgv.ShowCellToolTips = False
			Me.CustDgv.Size = New Size(1342, 413)
			Me.CustDgv.TabIndex = 0
			Me.CustDgv.TableName = ""
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
			Me.ComboTori.Location = New Point(96, 81)
			Me.ComboTori.MaxLength = 8
			Me.ComboTori.Name = "ComboTori"
			Me.ComboTori.Size = New Size(334, 20)
			Me.ComboTori.TabIndex = 0
			Me.ComboTori.TableName = "M_TORI"
			Me.ComboTori.Tag = ""
			'
			'InquiryKeppinBuhinForm
			'
			Me.ClientSize = New Size(1372, 670)
			Me.Controls.Add(Me.ConfirmationButton)
			Me.Controls.Add(Me.IKB_ExecutButton)
			Me.Controls.Add(Me.NouhinLabel)
			Me.Controls.Add(Me.Nouhin_S)
			Me.Controls.Add(Me.Nouhin_K)
			Me.Controls.Add(Me.IKB_OutPutButton)
			Me.Controls.Add(Me.Nouhin_M)
			Me.Controls.Add(Me.IKB_UpdateButton)
			Me.Controls.Add(Me.IKB_BackButton)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.IKB_ReferButton)
			Me.Controls.Add(Me.ToriCdLabel)
			Me.Controls.Add(Me.ComboTori)
			Me.Controls.Add(Me.FormTitleLabel)
			Me.Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.KeyPreview = True
			Me.Name = "InquiryKeppinBuhinForm"
			Me.Text = "欠品部品情報"
			Me.UcDgv.ResumeLayout(False)
			Me.UcDgv.PerformLayout()
			CType(Me.CustDgv, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Private Sub SetFTPparamsBuhinSindo(host As HostBuhinSihdoDataReceive, nohinsaki As String)
			If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
				host._ftpBuhinSindoFile = Me.FTP_FILE_BUHINSINDO_M
			ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
				host._ftpBuhinSindoFile = Me.FTP_FILE_BUHINSINDO_K
			ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
				host._ftpBuhinSindoFile = Me.FTP_FILE_BUHINSINDO_S
			End If
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
			text = Path.Combine(text, nohinsaki)
			host._ftpSaveFolder = text
		End Sub

		Private Sub SetFTPparamsSisan(host As HostSisanDataReceive, nohinsaki As String)
			If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
				host._ftpSisanFile = Me.FTP_FILE_SISAN_M
			ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
				host._ftpSisanFile = Me.FTP_FILE_SISAN_K
			ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
				host._ftpSisanFile = Me.FTP_FILE_SISAN_S
			End If
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
			text = Path.Combine(text, nohinsaki)
			host._ftpSaveFolder = text
		End Sub

		Private Sub SetFTPparamsCyuzan(host As HostCyuzanDataReceive, nohinsaki As String)
			If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
				host._ftpCyuzanFile = Me.FTP_FILE_CYUZAN_M
			ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
				host._ftpCyuzanFile = Me.FTP_FILE_CYUZAN_K
			ElseIf Operators.CompareString(nohinsaki, "Shigenobu", False) = 0 Then
				host._ftpCyuzanFile = Me.FTP_FILE_CYUZAN_S
			End If
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
			text = Path.Combine(text, nohinsaki)
			host._ftpSaveFolder = text
		End Sub

		Private Sub SetKeppinWritParam(Keppin As KeppinDataWrit)
			Keppin._configData = TopForm.ConfigData
			Keppin._funcName = "InquiryKeppinBuhin"
			Dim outPutFolder As String = Path.Combine(FileSystem.CurDir(), Me.outPutDir)
			Keppin._outPutFolder = outPutFolder
		End Sub

		Private Function makeSql(sql As String) As String
			Dim text As String = sql
			Dim text2 As String = Nothing
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text3 As String = String.Empty
			Dim array As String() = Strings.Split(Me.ComboTori.Text.Trim(), " ", -1, CompareMethod.Binary)
			text3 = array(0)
			If Not String.IsNullOrEmpty(text3) Then
				dictionary.Add("[TORI_CD]", "'" + text3 + "'")
			End If
			Dim checked As Boolean = Me.Nouhin_M.Checked
			If checked Then
				dictionary.Add("[NOHINSAKI_M]", "'M'")
			End If
			Dim checked2 As Boolean = Me.Nouhin_K.Checked
			If checked2 Then
				dictionary.Add("[NOHINSAKI_K]", "'K'")
			End If
			Dim checked3 As Boolean = Me.Nouhin_S.Checked
			If checked3 Then
				dictionary.Add("[NOHINSAKI_S]", "'S'")
			End If
			If dictionary.Count <= 0 Then
				text += "AND 1 = 0"
				Return text
			End If
			text += "AND "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					If "[TORI_CD]".Equals(keyValuePair.Key) Then
						text = String.Concat(New String() {text, "( ", keyValuePair.Key, " = ", keyValuePair.Value, " ) AND "})
					ElseIf text2 Is Nothing Then
						text2 = "[NOHINSAKI] = " + keyValuePair.Value
					Else
						text2 = text2 + " OR [NOHINSAKI] = " + keyValuePair.Value
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			If text2 Is Nothing Then
				text += "1=0"
			Else
				text = text + "( " + text2 + " )"
			End If
			text += " ORDER BY [LINE], CASE [NOHINSAKI] WHEN 'M' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'K' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'S' THEN 1 ELSE 2 END "
			Return text
		End Function

		Private Function makeCsvSql(sql As String, saveTori As String, saveM As Boolean, saveK As Boolean, saveS As Boolean) As String
			Dim text As String = sql
			Dim text2 As String = Nothing
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text3 As String = String.Empty
			Dim array As String() = Strings.Split(saveTori.Trim(), " ", -1, CompareMethod.Binary)
			text3 = array(0)
			If Not String.IsNullOrEmpty(text3) Then
				dictionary.Add("[TORI_CD]", "'" + text3 + "'")
			End If
			If saveM Then
				dictionary.Add("[NOHINSAKI_M]", "'M'")
			End If
			If saveK Then
				dictionary.Add("[NOHINSAKI_K]", "'K'")
			End If
			If saveS Then
				dictionary.Add("[NOHINSAKI_S]", "'S'")
			End If
			If dictionary.Count <= 0 Then
				text += "AND 1 = 0"
				Return text
			End If
			text += "AND "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					If "[TORI_CD]".Equals(keyValuePair.Key) Then
						text = String.Concat(New String() {text, "( ", keyValuePair.Key, " = ", keyValuePair.Value, " ) AND "})
					ElseIf text2 Is Nothing Then
						text2 = "[NOHINSAKI] = " + keyValuePair.Value
					Else
						text2 = text2 + " OR [NOHINSAKI] = " + keyValuePair.Value
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			If text2 Is Nothing Then
				text += "1=0"
			Else
				text = text + "( " + text2 + " )"
			End If
			text += " ORDER BY [LINE], CASE [NOHINSAKI] WHEN 'M' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'K' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'S' THEN 1 ELSE 2 END "
			Return text
		End Function

		Private Sub SetFileNames()
			If Me._conf Is Nothing Then
				Return
			End If
			Dim xFtpServer_Keppin As FtpServer_KeppinInfo = Me._conf.xmlConfData.xFtpServer_Keppin
			If xFtpServer_Keppin.MatsuyamaFilename IsNot Nothing Then
				Me.FTP_FILE_BUHINSINDO_M = xFtpServer_Keppin.MatsuyamaFilename.Buhinsindo
				Me.FTP_FILE_SISAN_M = xFtpServer_Keppin.MatsuyamaFilename.Sisan
				Me.FTP_FILE_CYUZAN_M = xFtpServer_Keppin.MatsuyamaFilename.Cyuzan
			End If
			If xFtpServer_Keppin.KumamotoFilename IsNot Nothing Then
				Me.FTP_FILE_BUHINSINDO_K = xFtpServer_Keppin.KumamotoFilename.Buhinsindo
				Me.FTP_FILE_SISAN_K = xFtpServer_Keppin.KumamotoFilename.Sisan
				Me.FTP_FILE_CYUZAN_K = xFtpServer_Keppin.KumamotoFilename.Cyuzan
			End If
			If xFtpServer_Keppin.ShigenobuFilename IsNot Nothing Then
				Me.FTP_FILE_BUHINSINDO_S = xFtpServer_Keppin.ShigenobuFilename.Buhinsindo
				Me.FTP_FILE_SISAN_S = xFtpServer_Keppin.ShigenobuFilename.Sisan
				Me.FTP_FILE_CYUZAN_S = xFtpServer_Keppin.ShigenobuFilename.Cyuzan
			End If
		End Sub

		Private Sub InquiryKeppinBuhinForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Me.ComboTori.Text = Nothing
			Me.Nouhin_M.Checked = True
			Me.Nouhin_K.Checked = True
			Me.Nouhin_S.Checked = True
			Me.saveTori = Me.ComboTori.Text
			Me.saveM = Me.Nouhin_M.Checked
			Me.saveK = Me.Nouhin_K.Checked
			Me.saveS = Me.Nouhin_S.Checked
			Cursor.Current = Cursors.WaitCursor
			Me.ComboTori.Text = String.Empty
			Me._conf = TopForm.ConfigData
			Me.ComboTori.SetItemListKeppin()
			Dim text As String = Me.BASESQL
			text += " ORDER BY [LINE], CASE [NOHINSAKI] WHEN 'M' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'K' THEN 1 ELSE 2 END, CASE [NOHINSAKI] WHEN 'S' THEN 1 ELSE 2 END "
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.DisplayGridView(text, 63)
			Me.ComboTori.SetItemListKeppin()
			Me.SetFileNames()
		End Sub

		Private Function KeppinProcess() As Boolean
			Return Me.StartExec() AndAlso Not Me._isCancel
		End Function

		Private Function StartExec() As Boolean
			Dim result As Boolean = False
			Me._isCancel = False
			Me._isErrer = False
			Dim dialogResult As DialogResult = DialogResult.None
			Using dlgProcessKeppin As New DlgProcessKeppin("欠品部品", AddressOf Me.KeppinView, 100)
				dialogResult = dlgProcessKeppin.ShowDialog(Me)
			End Using
			If Not Me._isErrer Then
				result = True
			End If
			If dialogResult = DialogResult.Cancel Then
				Me._isCancel = True
			End If
			Return result
		End Function

		Private Sub KeppinView(sender As Object, e As DoWorkEventArgs)
			If Information.IsNothing(TopForm.ConfigData) Then
				Return
			End If
			Dim xmlConfData As xRoot = TopForm.ConfigData.xmlConfData
			Me._ftpkeppin = xmlConfData.xFtpServer_Keppin
			Dim ftpCommon As New FtpCommon(Me._ftpkeppin.UserId, Me._ftpkeppin.Password)
			Dim ftpUrl As String = Me._ftpkeppin.FtpUrl
			If Not ftpCommon.IsDirectory(ftpUrl) Then
				Me._isErrer = True
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Dim text As String = Path.Combine(FileSystem.CurDir(), Me.receiveFtpDir)
			If Not Directory.Exists(text) Then
				Directory.CreateDirectory(text)
			End If
			For Each text2 As String In Me.KYOTEN
				Dim text3 As String = Path.Combine(text, text2)
				If Not Directory.Exists(text3) Then
					Directory.CreateDirectory(text3)
				End If
				Dim hostBuhinSihdoDataReceive As New HostBuhinSihdoDataReceive()
				Me.SetFTPparamsBuhinSindo(hostBuhinSihdoDataReceive, text2)
				If Not hostBuhinSihdoDataReceive.Exec() Then
					Return
				End If
				Dim hostSisanDataReceive As New HostSisanDataReceive()
				Me.SetFTPparamsSisan(hostSisanDataReceive, text2)
				If Not hostSisanDataReceive.Exec() Then
					Return
				End If
				Dim hostCyuzanDataReceive As New HostCyuzanDataReceive()
				Me.SetFTPparamsCyuzan(hostCyuzanDataReceive, text2)
				If Not hostCyuzanDataReceive.Exec() Then
					Return
				End If
			Next
			Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
			Dim percentProgress As Integer = 0
			Try
				Cursor.Current = Cursors.WaitCursor
				Dim keppinDataWrit As New KeppinDataWrit()
				Me.SetKeppinWritParam(keppinDataWrit)
				For Each sql As String In Me.DELETETABLE
					Dim flag As Boolean = False
					Try
						flag = keppinDataWrit.DeleteUkeharaiKeppin(sql)
					Catch ex As Exception
						flag = False
					End Try
					If Not flag Then
						DlgMessageBox.Show("テーブルの削除に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return
					End If
				Next
				For Each text4 As String In Me.KYOTEN
					Dim text3 As String = Path.Combine(text, text4)
					Dim path1 As String = Nothing
					Dim path2 As String = Nothing
					Dim path3 As String = Nothing
					If Operators.CompareString(text4, "Matsuyama", False) = 0 Then
						path1 = Me.FTP_FILE_BUHINSINDO_M
						path2 = Me.FTP_FILE_SISAN_M
						path3 = Me.FTP_FILE_CYUZAN_M
					ElseIf Operators.CompareString(text4, "Kumamoto", False) = 0 Then
						path1 = Me.FTP_FILE_BUHINSINDO_K
						path2 = Me.FTP_FILE_SISAN_K
						path3 = Me.FTP_FILE_CYUZAN_K
					ElseIf Operators.CompareString(text4, "Shigenobu", False) = 0 Then
						path1 = Me.FTP_FILE_BUHINSINDO_S
						path2 = Me.FTP_FILE_SISAN_S
						path3 = Me.FTP_FILE_CYUZAN_S
					End If
					Dim path4 As String = Path.Combine(text3, path1)
					Dim path5 As String = Path.Combine(text3, path2)
					Dim path6 As String = Path.Combine(text3, path3)
					keppinDataWrit.WritSisanDataExec(RuntimeHelpers.GetObjectValue(sender), path5, text4)
					keppinDataWrit.WritBuhinSindoDataExec(RuntimeHelpers.GetObjectValue(sender), path4, text4)
					keppinDataWrit.WritCyuzanDataExec(RuntimeHelpers.GetObjectValue(sender), path6, text4)
				Next
			Catch ex2 As Exception
				OutputLog.WriteLine(String.Format("sr : {0}", ex2.Message))
			End Try
			backgroundWorker.ReportProgress(percentProgress, "欠品部品情報作成中")
			If Not Me.CreateKeppinTable() Then
				DlgMessageBox.Show("欠品部品情報の作成に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		Private Function CreateKeppinTable() As Boolean
			Dim result As Boolean = False
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Make_Keppin")
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = True
				Else
					OutputLog.WriteLine(String.Format("CreateKeppinTable ERRER [{0}] ", storedProcedureData))
				End If
			End Using
			Return result
		End Function

		Private Sub ComboTori_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
			If f12check = False Then
				If e.KeyData = CType(131195, Keys) Then
					If Not Me.ConfirmationButton.Visible Then
						Me.ConfirmationButton.Visible = True
						Me.IKB_ExecutButton.Enabled = False
						Me.IKB_OutPutButton.Enabled = False
						Console.WriteLine("Ctrl+F12キーが押されました。")
					Else
						Me.ConfirmationButton.Visible = False
						Me.IKB_ExecutButton.Enabled = True
						Me.IKB_OutPutButton.Enabled = True
						Console.WriteLine("Ctrl+F12キーが押されました。")
					End If
				End If
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("ComboTori")>
		Private WithEvents ComboTori As KeppinComboBox

		<AccessedThroughProperty("ToriCdLabel")>
		Private WithEvents ToriCdLabel As Label

		<AccessedThroughProperty("IKB_ReferButton")>
		Private WithEvents IKB_ReferButton As Button

		<AccessedThroughProperty("IKB_BackButton")>
		Private WithEvents IKB_BackButton As Button

		<AccessedThroughProperty("IKB_UpdateButton")>
		Private WithEvents IKB_UpdateButton As Button

		<AccessedThroughProperty("Nouhin_M")>
		Private WithEvents Nouhin_M As CheckBox

		<AccessedThroughProperty("Nouhin_S")>
		Private WithEvents Nouhin_S As CheckBox

		<AccessedThroughProperty("Nouhin_K")>
		Private WithEvents Nouhin_K As CheckBox

		<AccessedThroughProperty("IKB_OutPutButton")>
		Private WithEvents IKB_OutPutButton As Button

		<AccessedThroughProperty("CustDgv")>
		Private WithEvents CustDgv As CustomDataGridView

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("NouhinLabel")>
		Private WithEvents NouhinLabel As Label

		<AccessedThroughProperty("IKB_ExecutButton")>
		Private WithEvents IKB_ExecutButton As Button

		<AccessedThroughProperty("ConfirmationButton")>
		Private WithEvents ConfirmationButton As Button

		Private _ftpkeppin As FtpServer_KeppinInfo

		Private _isCancel As Boolean

		Private _isErrer As Boolean

		Private FTP_FILE_BUHINSINDO_M As String

		Private FTP_FILE_BUHINSINDO_K As String

		Private FTP_FILE_BUHINSINDO_S As String

		Private FTP_FILE_SISAN_M As String

		Private FTP_FILE_SISAN_K As String

		Private FTP_FILE_SISAN_S As String

		Private FTP_FILE_CYUZAN_M As String

		Private FTP_FILE_CYUZAN_K As String

		Private FTP_FILE_CYUZAN_S As String

		Private receiveFtpDir As String

		Private Const MAKE_KEPPIN As String = "Ukeharai.Make_Keppin"

		Private KYOTEN As String()

		Private DELETETABLE As String()

		Private csvDirectory As String

		Private csvFileName As String

		Private Const EXEC_FUNC_NAME As String = "InquiryKeppinBuhin"

		Private outPutDir As String

		Private saveTori As String

		Private saveM As Boolean

		Private saveK As Boolean

		Private saveS As Boolean

		Private BASESQL As String

		Private _conf As XmlConfigControl

		Private _execFlag As Boolean

		Public _gridViewInfo As ControlDataGridView

		Protected ReViewFlag As Boolean

		Private _titleName As String

		Private f12check As Boolean = False

		Public Const MSG_E10001 As String = "登録中にエラーが発生しました。"

		Private Const COL_HEADER_HEIGHT As Integer = 63

		Private Sub IKB_ReferButton_Click(sender As Object, e As EventArgs) Handles IKB_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			Me.IKB_ReferButton.Enabled = False
			Dim sql As String = Me.makeSql(Me.BASESQL)
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.DisplayGridView(sql, 63)
			Me.saveTori = Me.ComboTori.Text
			Me.saveM = Me.Nouhin_M.Checked
			Me.saveK = Me.Nouhin_K.Checked
			Me.saveS = Me.Nouhin_S.Checked
			Me.IKB_ReferButton.Enabled = True
			Me.ActiveControl = Me.IKB_ReferButton
		End Sub

		Private Sub ConfirmationButton_Click_1(sender As Object, e As EventArgs) Handles ConfirmationButton.Click
			f12check = True
			If Me._conf Is Nothing Then
				Return
			End If
			Me.IKB_ReferButton.Enabled = False
			Dim sql As String = "SELECT [KAKUNIN],[TORI_NAME],[BUHIN_CD],[BUHIN_NAME],[LINE],convert(varchar,[TEBAN]) + '日' as [TEBAN],DATEADD(day, -[TEBAN], [LINE]) as [NONYU],[ZAIKO],[FUSOKU_TOGETU],[FUSOKU_JIGETU],[CYUZAN],[NOKI],[NOHINSAKI],[NYUKABI] FROM Ukeharai.T_KEPPIN WHERE ([KAKUNIN] ='1' AND [NYUKABI] IS NOT NULL) "
			Dim sql2 As String = Me.makeSql(sql)
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.DisplayGridView(sql2, 63)
			Me.saveTori = Me.ComboTori.Text
			Me.saveM = Me.Nouhin_M.Checked
			Me.saveK = Me.Nouhin_K.Checked
			Me.saveS = Me.Nouhin_S.Checked
			Me.IKB_ReferButton.Enabled = True
			Me.ActiveControl = Me.ConfirmationButton
		End Sub

		Private Sub IKB_UpdateButton_Click(sender As Object, e As EventArgs) Handles IKB_UpdateButton.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.IKB_UpdateButton.Enabled = False
			Me.ReViewFlag = True
			Try
				Dim keppinUtext As String = Nothing
				Me.ReViewFlag = Me._gridViewInfo.UpdateGridKeppinView(keppinUtext)
				Dim ucdgv As UcDataGridView = Me.UcDgv
				ucdgv.CustDgv_SendMessage(keppinUtext)
			Catch ex As Exception
				OutputLog.WriteLine("InquiryKeppinBuhinForm IKB_ExecutButton_Click.Click Error {0} : {1}", New String() {Me._titleName, ex.Message})
				DlgMessageBox.Show("登録中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Me.IKB_UpdateButton.Enabled = True
				Me.ActiveControl = Me.IKB_UpdateButton
			End Try
		End Sub

		Private Sub IKB_ExecutButton_Click(sender As Object, e As EventArgs) Handles IKB_ExecutButton.Click
			Dim dialogResult As DialogResult = MessageBox.Show("データの取込を行います。" + Environment.NewLine + "現在の情報は失われますがよろしいですか? ", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			If Not Me.KeppinProcess() Then
				If Me._isCancel Then
					DlgMessageBox.Show("処理を中断しました。", "キャンセル", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				DlgMessageBox.Show("処理を中断しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
			Else
				If Me._conf Is Nothing Then
					Return
				End If
				Me.IKB_ReferButton.Enabled = False
				Me.ComboTori.Text = Nothing
				Me.Nouhin_M.Checked = True
				Me.Nouhin_K.Checked = True
				Me.Nouhin_S.Checked = True
				Dim sql As String = Me.makeSql(Me.BASESQL)
				Dim ucDgv As UcDataGridView = Me.UcDgv
				Dim custDgv As CustomDataGridView = ucDgv.CustDgv
				Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
				ucDgv.CustDgv = custDgv
				Me._gridViewInfo = gridViewInfo
				Me._gridViewInfo.DisplayGridView(sql, 63)
				Me.saveTori = Me.ComboTori.Text
				Me.saveM = Me.Nouhin_M.Checked
				Me.saveK = Me.Nouhin_K.Checked
				Me.saveS = Me.Nouhin_S.Checked
				Me.IKB_ReferButton.Enabled = True
				Return
			End If
		End Sub

		Private Sub IKB_OutPutButton_Click(sender As Object, e As EventArgs) Handles IKB_OutPutButton.Click
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Dim configData As XmlConfigControl = TopForm.ConfigData
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(configData.xmlConfData.xDataBase)
				Dim month As Integer = DateTime.Now.Month
				Dim num As Integer
				Dim num2 As Integer
				If month = 11 Then
					num = 12
					num2 = 1
				ElseIf month = 12 Then
					num = 1
					num2 = 2
				Else
					num = month + 1
					num2 = num + 1
				End If
				Dim str As String = "SELECT [TORI_CD] as '取引先コード',[TORI_NAME] as '取引先名',[BUHIN_CD] as '部品コード',[BUHIN_NAME] as '部品名称',[TANA_NO1] as '棚番１',[TANA_NO2] as '棚番２',[TANA_NO3] as '棚番３',[TORIHIN_NO] as '取引先品番',[KIKAKU] as '規格',[IKISAKI_CD] as '行先ｺｰﾄﾞ',[UKESU] as '当月受入数',[HARASU] as '当月払出数',[ZAIKO] as '在庫数',"
				Dim text As String = " [SISAN_1ST] as 'firstMonth_月試算数',[KABUSOKU_1ST] as 'firstMonth_月過不足',[SISAN_2ND] as 'secondMonth_月試算数',[KABUSOKU_2ND] as 'secondMonth_月過不足',[SISAN_3RD] as 'thirdMonth_月試算数',[KABUSOKU_3RD] as 'thirdMonth_月過不足'"
				Dim str2 As String = ",[CYUZAN_SAITAN] as '最短納期',[CYUZAN_SU] as '注残数',[CYUZAN_ORDER] as 'オーダー',[CYUZAN_TOTAL] as '注残総数',[SINDO_1DAY] as '進度_1日',[SINDO_2DAY] as '進度_2日',[SINDO_3DAY] as '進度_3日',[SINDO_4DAY] as '進度_4日',[SINDO_5DAY] as '進度_5日',[SINDO_6DAY] as '進度_6日',[SINDO_7DAY] as '進度_7日',[SINDO_8DAY] as '進度_8日',[SINDO_9DAY] as '進度_9日',[SINDO_10DAY] as '進度_10日',[SINDO_11DAY] as '進度_11日',[SINDO_12DAY] as '進度_12日',[SINDO_13DAY] as '進度_13日',[SINDO_14DAY] as '進度_14日',[SINDO_15DAY] as '進度_15日',[SINDO_16DAY] as '進度_16日',[SINDO_17DAY] as '進度_17日',[SINDO_18DAY] as '進度_18日',[SINDO_19DAY] as '進度_19日',[SINDO_20DAY] as '進度_20日',[SINDO_21DAY] as '進度_21日',[SINDO_22DAY] as '進度_22日',[SINDO_23DAY] as '進度_23日',[SINDO_24DAY] as '進度_24日',[SINDO_25DAY] as '進度_25日',[SINDO_26DAY] as '進度_26日',[SINDO_27DAY] as '進度_27日',[SINDO_28DAY] as '進度_28日',[SINDO_29DAY] as '進度_29日',[SINDO_30DAY] as '進度_30日',[SINDO_31DAY] as '進度_31日',[SINDO_TOTAL] as '進度_合計',[KABUSOKU_1DAY] as '過不足_1日',[KABUSOKU_2DAY] as '過不足_2日',[KABUSOKU_3DAY] as '過不足_3日',[KABUSOKU_4DAY] as '過不足_4日',[KABUSOKU_5DAY] as '過不足_5日',[KABUSOKU_6DAY] as '過不足_6日',[KABUSOKU_7DAY] as '過不足_7日',[KABUSOKU_8DAY] as '過不足_8日',[KABUSOKU_9DAY] as '過不足_9日',[KABUSOKU_10DAY] as '過不足_10日',[KABUSOKU_11DAY] as '過不足_11日',[KABUSOKU_12DAY] as '過不足_12日',[KABUSOKU_13DAY] as '過不足_13日',[KABUSOKU_14DAY] as '過不足_14日',[KABUSOKU_15DAY] as '過不足_15日',[KABUSOKU_16DAY] as '過不足_16日',[KABUSOKU_17DAY] as '過不足_17日',[KABUSOKU_18DAY] as '過不足_18日',[KABUSOKU_19DAY] as '過不足_19日',[KABUSOKU_20DAY] as '過不足_20日',[KABUSOKU_21DAY] as '過不足_21日',[KABUSOKU_22DAY] as '過不足_22日',[KABUSOKU_23DAY] as '過不足_23日',[KABUSOKU_24DAY] as '過不足_24日',[KABUSOKU_25DAY] as '過不足_25日',[KABUSOKU_26DAY] as '過不足_26日',[KABUSOKU_27DAY] as '過不足_27日',[KABUSOKU_28DAY] as '過不足_28日',[KABUSOKU_29DAY] as '過不足_29日',[KABUSOKU_30DAY] as '過不足_30日',[KABUSOKU_31DAY] as '過不足_31日',[KABUSOKU_TOTAL] as '過不足_合計' FROM Ukeharai.T_KEPPIN　WHERE ([KAKUNIN] ='0' OR [NYUKABI] IS NULL) "
				text = text.Replace("firstMonth_", month.ToString())
				text = text.Replace("secondMonth_", num.ToString())
				text = text.Replace("thirdMonth_", num2.ToString())
				Dim sql As String = str + text + str2
				Dim text2 As String = Me.makeCsvSql(sql, Me.saveTori, Me.saveM, Me.saveK, Me.saveS)
				Dim sqldata As String = sqlDataBase.getSQLData(text2, True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text2, sqldata})
					Return
				End If
				dbDataTable = sqlDataBase.DbDataTable
			End Using
			Dim text3 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text3) Then
				Directory.CreateDirectory(text3)
			End If
			Dim count As Integer = dbDataTable.Rows.Count
			If dbDataTable.Rows.Count = 0 Then
				DlgMessageBox.Show("出力データがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
			End If
			Dim path1 As String
			If String.IsNullOrEmpty(Me.saveTori) Then
				path1 = Me.csvFileName + "_全メーカー.csv"
			Else
				Dim array As String() = Strings.Split(Me.saveTori.Trim(), " ", -1, CompareMethod.Binary)
				path1 = String.Concat(New String() {Me.csvFileName, "_", array(0), "_", array(1), ".csv"})
			End If
			Dim csvPath As String = Path.Combine(text3, path1)
			Dim csvCommon As New CsvCommon()
			If Not csvCommon.ConvertDataTableToCsv(dbDataTable, csvPath, True) Then
				DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
			End If
			DlgMessageBox.Show("欠品部品を " + count.ToString() + " 件 出力しました。", "完了", MessageBoxButtons.OK)
		End Sub

		Private Sub IKB_BackButton_Click(sender As Object, e As EventArgs) Handles IKB_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
