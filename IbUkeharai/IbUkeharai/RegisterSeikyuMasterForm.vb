Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class RegisterSeikyuMasterForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterSeikyuMasterForm_Load
			AddHandler MyBase.KeyUp, AddressOf Me.RegisterSeikyuMasterForm_KeyUp
			Me._kazei = 0L
			Me._hikazei = 0L
			Me._syohizei = 0L
			Me._goukei = 0L
			Me.TANI_EN = "円"
			Me.TANI_PC = "%"
			Me.BASESQL = "SELECT '' AS KUBUN, M.UCHIWAKE, M.SURYO, M.TANI, M.TANKA, M.KINGAKU, M.KAZEI_KBN, M.MEISAI_UMU, M.SAKI_CD, M.TEKIYO, M.SAKU_KBN FROM Ukeharai.T_SEIKYUM AS M LEFT JOIN Ukeharai.T_SEIKYU AS H ON H.TORI_CD = M.TORI_CD AND H.SEIKYU_YYYYMM = M.SEIKYU_YYYYMM "
			Me._bkcolor_readonly = SystemColors.GradientInactiveCaption
			Me._bkcolor_normal = Color.White
			Me._conf = Nothing
			Me._execFlag = False
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
			Me.RSM_ReferButton = New Button()
			Me.TorihikiLabel = New Label()
			Me.SpecifiedDateLabel = New Label()
			Me.AddRow_Button = New Button()
			Me.CclDateTimePicker1 = New DitCore.CclDateTimePicker(Me.components)
			Me.Label2 = New Label()
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.BtnCancel = New Button()
			Me.Label1 = New Label()
			Me.lblSeikyuNo = New Label()
			Me.lblMessage = New Label()
			Me.Label3 = New Label()
			Me.Label4 = New Label()
			Me.lblKazei = New Label()
			Me.lblHikazei = New Label()
			Me.lblTotal = New Label()
			Me.lblSyohizei = New Label()
			Me.Label9 = New Label()
			Me.Label10 = New Label()
			Me.btnDelete = New Button()
			Me.lblTori = New Label()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Size = New Size(1315, 45)
			Me.FormTitleLabel.Text = "請求マスター登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.Location = New Point(1223, 621)
			Me.RBM_BackButton.TabIndex = 8
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.Location = New Point(1051, 621)
			Me.RBM_ExecutButton.TabIndex = 6
			'
			'RSM_ReferButton
			'
			Me.RSM_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RSM_ReferButton.Location = New Point(450, 51)
			Me.RSM_ReferButton.Name = "RSM_ReferButton"
			Me.RSM_ReferButton.Size = New Size(80, 30)
			Me.RSM_ReferButton.TabIndex = 2
			Me.RSM_ReferButton.Text = "参照"
			Me.RSM_ReferButton.UseVisualStyleBackColor = True
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(15, 57)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(83, 18)
			Me.TorihikiLabel.TabIndex = 17
			Me.TorihikiLabel.Text = "取引先コード"
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(244, 57)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(61, 18)
			Me.SpecifiedDateLabel.TabIndex = 35
			Me.SpecifiedDateLabel.Text = "請求年月"
			'
			'AddRow_Button
			'
			Me.AddRow_Button.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
			Me.AddRow_Button.BackColor = Color.DodgerBlue
			Me.AddRow_Button.FlatStyle = FlatStyle.Popup
			Me.AddRow_Button.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.AddRow_Button.ForeColor = Color.White
			Me.AddRow_Button.Location = New Point(18, 621)
			Me.AddRow_Button.Name = "AddRow_Button"
			Me.AddRow_Button.Size = New Size(80, 30)
			Me.AddRow_Button.TabIndex = 5
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
			'
			'CclDateTimePicker1
			'
			Me.CclDateTimePicker1.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker1.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker1.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker1.CustomFormat = "yyyy年M月"
			Me.CclDateTimePicker1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker1.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker1.Location = New Point(311, 52)
			Me.CclDateTimePicker1.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker1.Name = "CclDateTimePicker1"
			Me.CclDateTimePicker1.NullValue = ""
			Me.CclDateTimePicker1.RightToLeft = RightToLeft.Yes
			Me.CclDateTimePicker1.Size = New Size(93, 19)
			Me.CclDateTimePicker1.TabIndex = 1
			Me.CclDateTimePicker1.Value = DateTime.Now
			'
			'Label2
			'
			Me.Label2.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label2.Location = New Point(571, 56)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(68, 18)
			Me.Label2.TabIndex = 40
			Me.Label2.Text = "請求書Ｎｏ"
			'
			'ComboTori1
			'
			Me.ComboTori1.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.ComboTori1.AutoCompleteSource = AutoCompleteSource.ListItems
			Me.ComboTori1.BackColor = Color.LightGoldenrodYellow
			Me.ComboTori1.ColumnCode = "TORI_CD"
			Me.ComboTori1.ColumnName = "TORI_NAME"
			Me.ComboTori1.FlatStyle = FlatStyle.Popup
			Me.ComboTori1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ComboTori1.FormattingEnabled = True
			Me.ComboTori1.ImeMode = ImeMode.Disable
			Me.ComboTori1.Location = New Point(104, 54)
			Me.ComboTori1.MaxLength = 8
			Me.ComboTori1.Name = "ComboTori1"
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 0
			Me.ComboTori1.TableName = "M_TORI"
			'
			'BtnCancel
			'
			Me.BtnCancel.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BtnCancel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BtnCancel.Location = New Point(1137, 621)
			Me.BtnCancel.Name = "BtnCancel"
			Me.BtnCancel.Size = New Size(80, 30)
			Me.BtnCancel.TabIndex = 7
			Me.BtnCancel.Text = "キャンセル"
			Me.BtnCancel.UseVisualStyleBackColor = True
			'
			'Label1
			'
			Me.Label1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.ForeColor = Color.Green
			Me.Label1.Location = New Point(15, 567)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(237, 42)
			Me.Label1.TabIndex = 41
			Me.Label1.Text = "課税区分：課税＝空白、非課税＝１" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "明細有無：有り＝１、無し＝空白"
			'
			'lblSeikyuNo
			'
			Me.lblSeikyuNo.BorderStyle = BorderStyle.FixedSingle
			Me.lblSeikyuNo.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblSeikyuNo.Location = New Point(645, 55)
			Me.lblSeikyuNo.Name = "lblSeikyuNo"
			Me.lblSeikyuNo.Padding = New Padding(3, 0, 0, 0)
			Me.lblSeikyuNo.Size = New Size(86, 23)
			Me.lblSeikyuNo.TabIndex = 42
			Me.lblSeikyuNo.Text = "＊＊＊＊＊＊"
			Me.lblSeikyuNo.TextAlign = ContentAlignment.MiddleLeft
			'
			'lblMessage
			'
			Me.lblMessage.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
			Me.lblMessage.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblMessage.ForeColor = Color.Red
			Me.lblMessage.Location = New Point(991, 56)
			Me.lblMessage.Name = "lblMessage"
			Me.lblMessage.Size = New Size(312, 61)
			Me.lblMessage.TabIndex = 43
			Me.lblMessage.Text = "ここにメッセージを表示します。"
			Me.lblMessage.TextAlign = ContentAlignment.TopRight
			'
			'Label3
			'
			Me.Label3.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.Label3.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label3.Location = New Point(951, 570)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Size(68, 18)
			Me.Label3.TabIndex = 44
			Me.Label3.Text = "課税計"
			'
			'Label4
			'
			Me.Label4.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.Label4.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label4.Location = New Point(951, 588)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Size(68, 18)
			Me.Label4.TabIndex = 45
			Me.Label4.Text = "非課税計"
			'
			'lblKazei
			'
			Me.lblKazei.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.lblKazei.BorderStyle = BorderStyle.FixedSingle
			Me.lblKazei.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblKazei.Location = New Point(1009, 566)
			Me.lblKazei.Name = "lblKazei"
			Me.lblKazei.Padding = New Padding(0, 0, 3, 0)
			Me.lblKazei.Size = New Size(112, 23)
			Me.lblKazei.TabIndex = 46
			Me.lblKazei.Text = "＊＊＊＊＊＊"
			Me.lblKazei.TextAlign = ContentAlignment.MiddleRight
			'
			'lblHikazei
			'
			Me.lblHikazei.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.lblHikazei.BorderStyle = BorderStyle.FixedSingle
			Me.lblHikazei.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblHikazei.Location = New Point(1009, 588)
			Me.lblHikazei.Name = "lblHikazei"
			Me.lblHikazei.Padding = New Padding(0, 0, 3, 0)
			Me.lblHikazei.Size = New Size(112, 23)
			Me.lblHikazei.TabIndex = 47
			Me.lblHikazei.Text = "＊＊＊＊＊＊"
			Me.lblHikazei.TextAlign = ContentAlignment.MiddleRight
			'
			'lblTotal
			'
			Me.lblTotal.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.lblTotal.BorderStyle = BorderStyle.FixedSingle
			Me.lblTotal.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblTotal.Location = New Point(1191, 588)
			Me.lblTotal.Name = "lblTotal"
			Me.lblTotal.Padding = New Padding(0, 0, 3, 0)
			Me.lblTotal.Size = New Size(112, 23)
			Me.lblTotal.TabIndex = 51
			Me.lblTotal.Text = "＊＊＊＊＊＊"
			Me.lblTotal.TextAlign = ContentAlignment.MiddleRight
			'
			'lblSyohizei
			'
			Me.lblSyohizei.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.lblSyohizei.BorderStyle = BorderStyle.FixedSingle
			Me.lblSyohizei.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblSyohizei.Location = New Point(1191, 566)
			Me.lblSyohizei.Name = "lblSyohizei"
			Me.lblSyohizei.Padding = New Padding(0, 0, 3, 0)
			Me.lblSyohizei.Size = New Size(112, 23)
			Me.lblSyohizei.TabIndex = 50
			Me.lblSyohizei.Text = "＊＊＊＊＊＊"
			Me.lblSyohizei.TextAlign = ContentAlignment.MiddleRight
			'
			'Label9
			'
			Me.Label9.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.Label9.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label9.Location = New Point(1139, 588)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Size(68, 18)
			Me.Label9.TabIndex = 49
			Me.Label9.Text = "合計"
			'
			'Label10
			'
			Me.Label10.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.Label10.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label10.Location = New Point(1139, 570)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Size(68, 18)
			Me.Label10.TabIndex = 48
			Me.Label10.Text = "消費税"
			'
			'btnDelete
			'
			Me.btnDelete.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.btnDelete.Location = New Point(796, 52)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New Size(80, 44)
			Me.btnDelete.TabIndex = 3
			Me.btnDelete.Text = "削除" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F9)"
			Me.btnDelete.UseVisualStyleBackColor = True
			'
			'lblTori
			'
			Me.lblTori.AutoSize = True
			Me.lblTori.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblTori.Location = New Point(101, 86)
			Me.lblTori.Name = "lblTori"
			Me.lblTori.Size = New Size(65, 12)
			Me.lblTori.TabIndex = 52
			Me.lblTori.Text = "取引先名称"
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Location = New Point(18, 111)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(1285, 445)
			Me.UcDgv.TabIndex = 4
			'
			'RegisterSeikyuMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(1315, 657)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.lblTori)
			Me.Controls.Add(Me.btnDelete)
			Me.Controls.Add(Me.lblTotal)
			Me.Controls.Add(Me.lblSyohizei)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.Label10)
			Me.Controls.Add(Me.lblHikazei)
			Me.Controls.Add(Me.lblKazei)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.lblMessage)
			Me.Controls.Add(Me.lblSeikyuNo)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.BtnCancel)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.CclDateTimePicker1)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.RSM_ReferButton)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.KeyPreview = True
			Me.Name = "RegisterSeikyuMasterForm"
			Me.Text = "請求マスター登録画面"
			Me.TtileName = "請求マスター登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.TorihikiLabel, 0)
			Me.Controls.SetChildIndex(Me.RSM_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.SpecifiedDateLabel, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.CclDateTimePicker1, 0)
			Me.Controls.SetChildIndex(Me.Label2, 0)
			Me.Controls.SetChildIndex(Me.ComboTori1, 0)
			Me.Controls.SetChildIndex(Me.BtnCancel, 0)
			Me.Controls.SetChildIndex(Me.Label1, 0)
			Me.Controls.SetChildIndex(Me.lblSeikyuNo, 0)
			Me.Controls.SetChildIndex(Me.lblMessage, 0)
			Me.Controls.SetChildIndex(Me.Label3, 0)
			Me.Controls.SetChildIndex(Me.Label4, 0)
			Me.Controls.SetChildIndex(Me.lblKazei, 0)
			Me.Controls.SetChildIndex(Me.lblHikazei, 0)
			Me.Controls.SetChildIndex(Me.Label10, 0)
			Me.Controls.SetChildIndex(Me.Label9, 0)
			Me.Controls.SetChildIndex(Me.lblSyohizei, 0)
			Me.Controls.SetChildIndex(Me.lblTotal, 0)
			Me.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.Controls.SetChildIndex(Me.lblTori, 0)
			Me.Controls.SetChildIndex(Me.UcDgv, 0)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Friend Overridable Property CustomDataGridView1 As CustomDataGridView
			Get
				Return Me._CustomDataGridView1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CustomDataGridView)
				Me._CustomDataGridView1 = value
			End Set
		End Property

		Private Property ExecFlag As Boolean
			Get
				Return Me._execFlag
			End Get
			Set(value As Boolean)
				Me._execFlag = value
				If Not Me._execFlag Then
					Me.lblSeikyuNo.Text = Nothing
					Me.lblKazei.Text = Nothing
					Me.lblHikazei.Text = Nothing
					Me.lblSyohizei.Text = Nothing
					Me.lblTotal.Text = Nothing
				End If
				Me.RBM_ExecutButton.Enabled = Me._execFlag
				Me.BtnCancel.Enabled = Me._execFlag
				Me.ComboTori1.Enabled = Not Me._execFlag
				Me.CclDateTimePicker1.Enabled = Not Me._execFlag
				Me.AddRow_Button.Enabled = Me._execFlag
				Me.btnDelete.Enabled = Me._execFlag
			End Set
		End Property

		Private Sub InitGoukei()
			Me._kazei = 0L
			Me._hikazei = 0L
			Me._syohizei = 0L
			Me._goukei = 0L
		End Sub

		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("H.TORI_CD", "'" + text2 + "'")
			End If
			If String.IsNullOrEmpty(Conversions.ToString(Me.CclDateTimePicker1.Value)) Then
				text2 = String.Empty
			Else
				text2 = Me.getTergetTime()
			End If
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("H.SEIKYU_YYYYMM", "'" + text2 + "'")
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " AND "})
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1 "
			text += "ORDER BY M.SEIKYU_SQNO"
			Return text
		End Function

		Private Function makeSqlSeikyu() As String
			Dim text As String = "SELECT TORI_CD FROM Ukeharai.T_SEIKYU "
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("TORI_CD", "'" + text2 + "'")
			End If
			If String.IsNullOrEmpty(Conversions.ToString(Me.CclDateTimePicker1.Value)) Then
				text2 = String.Empty
			Else
				text2 = Me.getTergetTime()
			End If
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("SEIKYU_YYYYMM", "'" + text2 + "'")
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " AND "})
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1 "
			Return text
		End Function

		Private Function chkInput(Optional flg As Boolean = False) As Boolean
			Dim result As Boolean = False
			Me.AddRow_Button.Enabled = False
			If Me.ComboTori1.SelectedIndex < 0 Then
				DlgMessageBox.Show("取引先コードを指定してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.ComboTori1.Focus()
				Return result
			End If
			If String.IsNullOrEmpty(Me.CclDateTimePicker1.Text.Trim()) Then
				DlgMessageBox.Show("請求年月を指定してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.CclDateTimePicker1.Focus()
				Return result
			End If
			result = True
			Me.AddRow_Button.Enabled = True
			Return result
		End Function

		Private Function getMjosu() As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim sSQL As String = "SELECT TOP 1 * FROM Ukeharai.M_JOSU ORDER BY JOSU_CD DESC"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sSQL, False)
				If String.IsNullOrEmpty(sqldata) Then
					result = sqlDataBase.DbData.DataList(0)
				End If
			End Using
			Return result
		End Function

		Private Function getMtori(toriCd As String) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim sSQL As String = "SELECT TORI_CD, TORI_NAME, SEIKYU_TYPE, RITU, HASU_KBN FROM Ukeharai.M_TORI WHERE TORI_CD = '" + toriCd + "'"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sSQL, False)
				If String.IsNullOrEmpty(sqldata) AndAlso sqlDataBase.DbData.DataList.Count > 0 Then
					result = sqlDataBase.DbData.DataList(0)
				End If
			End Using
			Return result
		End Function

		Private Function getNounyuSakiName(sakiCd As String) As String
			Dim result As String = String.Empty
			Dim sSQL As String = "SELECT SAKI_NAME FROM Ukeharai.M_SAKI WHERE SAKI_CD = '" + sakiCd + "'"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sSQL, False)
				If String.IsNullOrEmpty(sqldata) Then
					Dim dictionary As Dictionary(Of String, Object) = sqlDataBase.DbData.DataList(0)
					result = Conversions.ToString(dictionary("SAKI_NAME"))
				End If
			End Using
			Return result
		End Function

		Private Function getSeikyuTable(Optional hidukeFlg As Boolean = False) As List(Of Dictionary(Of String, Object))
			Dim result As New List(Of Dictionary(Of String, Object))()
			Dim text As String = "SELECT TORI_CD, SEIKYU_YYYYMM, SEIKYU_TYPE, SEIKYU_NO, KAZEI, HIKAZEI, SYOHIZEI, GOUKEI FROM Ukeharai.T_SEIKYU WHERE TORI_CD = '" + Me.ComboTori1.Text.Trim() + "'"
			If hidukeFlg Then
				text = text + " AND SEIKYU_YYYYMM = '" + Me.getTergetTime() + "'"
			Else
				text = text + " AND SEIKYU_YYYYMM < '" + Me.getTergetTime() + "'"
			End If
			text += " ORDER BY SEIKYU_YYYYMM DESC"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					result = sqlDataBase.DbData.DataList
				End If
			End Using
			Return result
		End Function

		Private Function getSeikyuMeisaiTable(a_yyymmdd As Object) As List(Of Dictionary(Of String, Object))
			Dim result As New List(Of Dictionary(Of String, Object))()
			Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM Ukeharai.T_SEIKYUM WHERE TORI_CD = '" + Me.ComboTori1.Text.Trim() + "'" + " AND SEIKYU_YYYYMM = '", a_yyymmdd), "'"), " AND ( SAKU_KBN <> '1' OR SAKU_KBN IS NULL )"))
			text += " ORDER BY SEIKYU_SQNO"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					result = sqlDataBase.DbData.DataList
				End If
			End Using
			Return result
		End Function

		Private Function getTergetTime() As String
			Return Conversions.ToDate(NewLateBinding.LateGet(Me.CclDateTimePicker1.Value, Nothing, "Date", New Object(-1) {}, Nothing, Nothing, Nothing)).ToString("yyyy/MM/01")
		End Function

		Private Function insertSeikyuHeader(type As String) As String
			Return Me.MakeSqlInsert(New List(Of sqlWork)() From {New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"), New sqlWork("KAZEI", Conversions.ToString(Me._kazei), "String"), New sqlWork("HIKAZEI", Conversions.ToString(Me._hikazei), "String"), New sqlWork("SYOHIZEI", Conversions.ToString(Me._syohizei), "String"), New sqlWork("GOUKEI", Conversions.ToString(Me._goukei), "String"), New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"), New sqlWork("SEIKYU_TYPE", type, "String"), New sqlWork("SEIKYU_NO", String.Empty, "String")}, "Ukeharai.T_SEIKYU")
		End Function

		Private Function insertSeikyuMeisai(sqno As String, data As Dictionary(Of String, Object), seikyuType As String) As String
			Dim list As New List(Of sqlWork)()
			list.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"))
			list.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
			list.Add(New sqlWork("SEIKYU_SQNO", sqno, "Integer"))
			list.Add(New sqlWork("SAKU_KBN", "1", "String"))
			If Operators.CompareString(sqno, "1", False) = 0 Then
				list.Add(New sqlWork("UCHIWAKE", "１．納入代行作業料", "String"))
			Else
				If "1".Equals(seikyuType) Then
					list.Add(New sqlWork("MEISAI_UMU", "1", "String"))
					list.Add(New sqlWork("UCHIWAKE", Conversions.ToString(Operators.ConcatenateObject(data("SAKI_NAME"), "作業料")), "String"))
				Else
					list.Add(New sqlWork("UCHIWAKE", Conversions.ToString(Operators.ConcatenateObject(data("SAKI_NAME"), "検収額")), "String"))
					list.Add(New sqlWork("TANI", Conversions.ToString(data("TANI")), "String"))
					list.Add(New sqlWork("TANKA", Conversions.ToString(data("TANKA")), "String"))
					list.Add(New sqlWork("SURYO", Conversions.ToString(data("KOSU")), "String"))
				End If
				list.Add(New sqlWork("KINGAKU", Conversions.ToString(data("KINGAKU")), "String"))
				list.Add(New sqlWork("SAKI_CD", Conversions.ToString(data("SAKI_CD")), "String"))
			End If
			Return Me.MakeSqlInsert(list, "Ukeharai.T_SEIKYUM")
		End Function

		Private Function insertSeikyuMeisai2(sqno As String, data As Dictionary(Of String, Object)) As String
			Return Me.MakeSqlInsert(New List(Of sqlWork)() From {New sqlWork("TORI_CD", Conversions.ToString(data("TORI_CD")), "String"), New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"), New sqlWork("SEIKYU_SQNO", sqno, "Integer"), New sqlWork("SAKU_KBN", Conversions.ToString(data("SAKU_KBN")), "String"), New sqlWork("UCHIWAKE", Conversions.ToString(data("UCHIWAKE")), "String"), New sqlWork("KINGAKU", Conversions.ToString(data("KINGAKU")), "Integer"), New sqlWork("MEISAI_UMU", Conversions.ToString(data("MEISAI_UMU")), "String"), New sqlWork("SAKI_CD", Conversions.ToString(data("SAKI_CD")), "String"), New sqlWork("TEKIYO", Conversions.ToString(data("TEKIYO")), "String"), New sqlWork("SURYO", Conversions.ToString(data("SURYO")), "Integer"), New sqlWork("TANI", Conversions.ToString(data("TANI")), "String"), New sqlWork("TANKA", Conversions.ToString(data("TANKA")), "String"), New sqlWork("KAZEI_KBN", Conversions.ToString(data("KAZEI_KBN")), "String")}, "Ukeharai.T_SEIKYUM")
		End Function

		Private Function MakeSqlInsert(uSet As List(Of sqlWork), tableName As String) As String
			Dim text As String = String.Empty
			Dim text2 As String = String.Empty
			uSet.Add(New sqlWork("INSERT_USER", Me._conf.xmlConfData.xDataBase.UserId, "String"))
			uSet.Add(New sqlWork("INSERT_DTM", Conversions.ToString(DateAndTime.Now), "Date"))
			uSet.Add(New sqlWork("INSERT_FUNCTION", Me.Name, "String"))
			Try
				For Each sqlWork As sqlWork In uSet
					text = text + sqlWork.name + " ,"
					If "NULL".Equals(sqlWork.value) Then
						text2 = text2 + sqlWork.value + " ,"
					ElseIf "String".Equals(sqlWork.type) Or "Date".Equals(sqlWork.type) Then
						text2 = text2 + "'" + sqlWork.value + "' ,"
					ElseIf String.IsNullOrEmpty(sqlWork.value) Then
						text2 += "NULL ,"
					Else
						text2 = text2 + sqlWork.value + " ,"
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			text2 = text2.TrimEnd(New Char() {","c})
			Return String.Concat(New String() {"INSERT INTO ", tableName, " (", text, " ) VALUES (", text2, " )"})
		End Function

		Private Sub dispTotal(josu As Dictionary(Of String, Object))
			Me._syohizei = Conversions.ToLong(Operators.DivideObject(Operators.MultiplyObject(Me._kazei, josu("ZEIRITU")), 100))
			Me._goukei = Me._kazei + Me._hikazei + Me._syohizei
			Me.lblKazei.Text = String.Format("{0:#,0}", Me._kazei)
			Me.lblHikazei.Text = String.Format("{0:#,0}", Me._hikazei)
			Me.lblSyohizei.Text = String.Format("{0:#,0}", Me._syohizei)
			Me.lblTotal.Text = String.Format("{0:#,0}", Me._goukei)
		End Sub

		Private Sub changeGridview()
			Try
				For Each obj As Object In CType(Me.UcDgv.CustDgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					dataGridViewRow.Cells("KUBUN").[ReadOnly] = False
					dataGridViewRow.Cells("KUBUN").Style.BackColor = Me._bkcolor_normal
					dataGridViewRow.Cells("UCHIWAKE").[ReadOnly] = False
					dataGridViewRow.Cells("UCHIWAKE").Style.BackColor = Me._bkcolor_normal
					If "1".Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("SAKU_KBN").Value)) Then
						dataGridViewRow.Cells("SURYO").[ReadOnly] = True
						dataGridViewRow.Cells("SURYO").Style.BackColor = Me._bkcolor_readonly
						dataGridViewRow.Cells("TANKA").[ReadOnly] = True
						dataGridViewRow.Cells("TANKA").Style.BackColor = Me._bkcolor_readonly
						dataGridViewRow.Cells("TANI").[ReadOnly] = True
						dataGridViewRow.Cells("TANI").Style.BackColor = Me._bkcolor_readonly
						dataGridViewRow.Cells("KINGAKU").[ReadOnly] = True
						dataGridViewRow.Cells("KINGAKU").Style.BackColor = Me._bkcolor_readonly
						dataGridViewRow.Cells("KAZEI_KBN").[ReadOnly] = True
						dataGridViewRow.Cells("KAZEI_KBN").Style.BackColor = Me._bkcolor_readonly
						dataGridViewRow.Cells("MEISAI_UMU").[ReadOnly] = True
						dataGridViewRow.Cells("MEISAI_UMU").Style.BackColor = Me._bkcolor_readonly
					Else
						dataGridViewRow.Cells("SURYO").[ReadOnly] = False
						dataGridViewRow.Cells("SURYO").Style.BackColor = Me._bkcolor_normal
						dataGridViewRow.Cells("TANKA").[ReadOnly] = False
						dataGridViewRow.Cells("TANKA").Style.BackColor = Me._bkcolor_normal
						dataGridViewRow.Cells("TANI").[ReadOnly] = False
						dataGridViewRow.Cells("TANI").Style.BackColor = Me._bkcolor_normal
						dataGridViewRow.Cells("KINGAKU").[ReadOnly] = False
						dataGridViewRow.Cells("KINGAKU").Style.BackColor = Me._bkcolor_normal
						dataGridViewRow.Cells("KAZEI_KBN").[ReadOnly] = False
						dataGridViewRow.Cells("KAZEI_KBN").Style.BackColor = Me._bkcolor_normal
						dataGridViewRow.Cells("MEISAI_UMU").[ReadOnly] = False
						dataGridViewRow.Cells("MEISAI_UMU").Style.BackColor = Me._bkcolor_normal
					End If
					dataGridViewRow.Cells("SAKI_CD").[ReadOnly] = True
					dataGridViewRow.Cells("SAKI_CD").Style.BackColor = Me._bkcolor_readonly
					dataGridViewRow.Cells("TEKIYO").[ReadOnly] = False
					dataGridViewRow.Cells("TEKIYO").Style.BackColor = Me._bkcolor_normal
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Function gridDisplay() As Boolean
			Dim text As String = Me.makeSqlSeikyu()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					Dim num As Long = 0L
					Dim text2 As String = String.Empty
					Dim value As String = String.Empty
					Try
						Me.InitGoukei()
						Dim seikyuTable As List(Of Dictionary(Of String, Object)) = Me.getSeikyuTable(True)
						Dim ucDgv As UcDataGridView
						Dim custDgv As CustomDataGridView
						If seikyuTable.Count = 1 AndAlso Not String.IsNullOrEmpty(Conversions.ToString(seikyuTable(0)("SEIKYU_NO"))) Then
							Me.lblSeikyuNo.Text = Conversions.ToString(seikyuTable(0)("SEIKYU_NO"))
							Me.lblKazei.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(seikyuTable(0)("KAZEI")))
							Me.lblHikazei.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(seikyuTable(0)("HIKAZEI")))
							Me.lblSyohizei.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(seikyuTable(0)("SYOHIZEI")))
							Me.lblTotal.Text = String.Format("{0:#,0}", RuntimeHelpers.GetObjectValue(seikyuTable(0)("GOUKEI")))
							text = Me.makeSql()
							ucDgv = Me.UcDgv
							custDgv = ucDgv.CustDgv
							Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
							ucDgv.CustDgv = custDgv
							Me._gridViewInfo = gridViewInfo
							Me._gridViewInfo.listOfHidden.Add("SAKU_KBN")
							Me._gridViewInfo.DisplayGridView(text, 0)
							Me.changeGridview()
							Return True
						End If
						Dim sSQL As String = String.Empty
						Me.lblSeikyuNo.Text = Nothing
						Dim t As DateTime
						DateTime.TryParse(DateAndTime.Now.ToString("yyyy/MM/01"), t)
						Dim t2 As DateTime
						DateTime.TryParse(DateAndTime.Now.AddMonths(-1).ToString("yyyy/MM/01"), t2)
						Dim t3 As DateTime
						DateTime.TryParse(Me.getTergetTime(), t3)
						If DateTime.Compare(t3, t) > 0 Or DateTime.Compare(t3, t2) < 0 Then
							Me.lblMessage.Text = "請求情報が存在しません。" & vbCrLf & "請求年月を確認して再度実施して下さい。"
							Return False
						End If
						sqlDataBase.BeginTransaction()
						Dim tergetTime As String = Me.getTergetTime()
						Dim sSQL2 As String = String.Concat(New String() {"SELECT U.TORI_CD, U.BUHIN_CD, MAX(U.UKEHARA_YYYYMMDD) AS UKEHARA_YYYYMMDD, MAX(U.DEN_NO) AS DEN_NO, SUM(U.KOSU) AS KOSU,  MAX(U.REMARKS1) AS REMARKS1, SUM(U.KINGAKU) AS KINGAKU, MAX(U.TESU) AS TESU, MAX(S.SAKI_CD) AS SAKI_CD, MAX(S.SAKI_NAME) AS SAKI_NAME FROM Ukeharai.T_UKEHARAIMEISAI AS U LEFT JOIN Ukeharai.M_SAKI AS S ON S.SAKI_CD = U.SAKI_CD  WHERE TORI_CD = '", Me.ComboTori1.Text, "' AND UKEHARA_YYYYMMDD BETWEEN '", tergetTime, "' AND EOMONTH('", tergetTime, "')  AND UKEHARAI_KBN = '2'  GROUP BY TORI_CD, BUHIN_CD, S.SAKI_CD ORDER BY S.SAKI_CD"})
						sqlDataBase.getSQLData(sSQL2, False)
						If sqlDataBase.DbData.DataList.Count > 0 Then
							Dim dictionary As Dictionary(Of String, Object) = Me.getMtori(Me.ComboTori1.Text)
							text2 = Conversions.ToString(dictionary("SEIKYU_TYPE"))
							Dim num2 As Double = Conversions.ToDouble(dictionary("RITU"))
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dictionary("HASU_KBN"))
							Dim list As List(Of Dictionary(Of String, Object)) = Me.getSeikyuTable(False)
							If list.Count > 0 Then
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(list(0)("SEIKYU_YYYYMM"))
								list = Me.getSeikyuMeisaiTable(RuntimeHelpers.GetObjectValue(objectValue2))
							End If
							Dim list2 As New List(Of Dictionary(Of String, Object))()
							list2 = Me.getSeikyuMeisaiTable(Me.getTergetTime())
							sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYU  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
							If Not sqlDataBase.execSql(sSQL2) Then
								Me.lblMessage.Text = "請求テーブル(ヘッダー)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
								Return False
							End If
							sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYUM  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
							If Not sqlDataBase.execSql(sSQL2) Then
								Me.lblMessage.Text = "請求テーブル(明細)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
								Return False
							End If
							Dim num3 As Integer = 1
							dictionary = sqlDataBase.DbData.DataList(0)
							sSQL = Me.insertSeikyuMeisai(num3.ToString(), dictionary, text2)
							If Not sqlDataBase.execSql(sSQL) Then
								Return False
							End If
							num3 += 1
							Dim text3 As String = String.Empty
							Dim num4 As Double = 0.0
							Dim num5 As Long = 0L
							Dim num6 As Double = 0.0
							Dim num7 As Integer = 0
							Dim num8 As Integer = sqlDataBase.DbData.DataList.Count - 1
							Dim i As Integer = num7
							While i <= num8
								Dim dictionary2 As Dictionary(Of String, Object) = sqlDataBase.DbData.DataList(i)
								Dim value2 As String = Conversions.ToString(dictionary2("SAKI_CD"))
								If String.IsNullOrEmpty(value2) Then
									value2 = String.Empty
								End If
								Dim num9 As Long
								If "1".Equals(text2) Then
									num9 = Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dictionary2("KOSU")))
								Else
									num9 = Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(dictionary2("KINGAKU")))
								End If
								If i = sqlDataBase.DbData.DataList.Count - 1 Then

									If "1".Equals(text2) Then
										num6 = CDbl(num9) * Common.objToDouble(RuntimeHelpers.GetObjectValue(dictionary2("TESU")))
										num6 = CDbl(Common.hasu(num6, Conversions.ToString(objectValue)))
									ElseIf "2".Equals(text2) Then
										num6 = CDbl(num9)
									End If
									If text3.Equals(value2) Then
										num4 += num6
										num5 += num9
									Else
										num4 = num6
									End If
									If "1".Equals(text2) Then
										num4 = CDbl(Common.hasu(num4, Conversions.ToString(objectValue)))
										dictionary2("KINGAKU") = num4
									ElseIf "2".Equals(text2) Then
										dictionary2("TANI") = Me.TANI_EN
										dictionary2("TANKA") = num2.ToString("F2") + Me.TANI_PC
										dictionary2("KOSU") = num4
										num4 = CDbl(Common.hasu(num4 * num2 / 100.0, Conversions.ToString(objectValue)))
										dictionary2("KINGAKU") = num4
									End If
									sSQL = Me.insertSeikyuMeisai(num3.ToString(), dictionary2, text2)
									If Not sqlDataBase.execSql(sSQL) Then
										Return False
									End If

									num3 += 1
									num = CLng(Math.Round(CDbl(num) + num4))
									Exit While
								Else
									If "1".Equals(text2) Then
										' The following expression was wrapped in a unchecked-expression
										num6 = CDbl(num9) * Common.objToDouble(RuntimeHelpers.GetObjectValue(dictionary2("TESU")))
										num6 = CDbl(Common.hasu(num6, Conversions.ToString(objectValue)))
									ElseIf "2".Equals(text2) Then
										num6 = CDbl(num9)
									End If
									If text3.Equals(value2) Then

										num4 += num6

										num5 += num9
									Else
										num4 = num6
										num5 = num9
									End If
									Dim text4 As String = Conversions.ToString(sqlDataBase.DbData.DataList(i + 1)("SAKI_CD"))
									If String.IsNullOrEmpty(text4) Then
										text4 = String.Empty
									End If
									If Not text4.Equals(value2) Then
										If "1".Equals(text2) Then
											num4 = CDbl(Common.hasu(num4, Conversions.ToString(objectValue)))
											dictionary2("KINGAKU") = num4
										ElseIf "2".Equals(text2) Then
											dictionary2("TANI") = Me.TANI_EN
											dictionary2("TANKA") = num2.ToString("F2") + Me.TANI_PC
											dictionary2("KOSU") = num4
											num4 = CDbl(Common.hasu(num4 * num2 / 100.0, Conversions.ToString(objectValue)))
											dictionary2("KINGAKU") = num4
										End If
										sSQL = Me.insertSeikyuMeisai(num3.ToString(), dictionary2, text2)
										If Not sqlDataBase.execSql(sSQL) Then
											Return False
										End If
										num3 += 1
										num = CLng(Math.Round(CDbl(num) + num4))
										num4 = 0.0
									End If
									text3 = Conversions.ToString(dictionary2("SAKI_CD"))
									If String.IsNullOrEmpty(text3) Then
										text3 = String.Empty
									End If
									i += 1
								End If
							End While
							Try
								For Each dictionary3 As Dictionary(Of String, Object) In list2
									value = Conversions.ToString(dictionary3("KAZEI_KBN"))
									sSQL = Me.insertSeikyuMeisai2(num3.ToString().ToString(), dictionary3)
									If Not sqlDataBase.execSql(sSQL) Then
										Return False
									End If
									num3 += 1
									If String.IsNullOrEmpty(value) Then
										num = Conversions.ToLong(Operators.AddObject(num, dictionary3("KINGAKU")))
									ElseIf "1".Equals(value) Then
										Me._hikazei = Conversions.ToLong(Operators.AddObject(Me._hikazei, dictionary3("KINGAKU")))
									End If
								Next
							Finally
								Dim enumerator As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
								CType(enumerator, IDisposable).Dispose()
							End Try
							If list2.Count = 0 Then
								Try
									For Each dictionary4 As Dictionary(Of String, Object) In list
										value = Conversions.ToString(dictionary4("KAZEI_KBN"))
										sSQL = Me.insertSeikyuMeisai2(num3.ToString().ToString(), dictionary4)
										If Not sqlDataBase.execSql(sSQL) Then
											Return False
										End If
										num3 += 1
										If String.IsNullOrEmpty(value) Then
											num = Conversions.ToLong(Operators.AddObject(num, dictionary4("KINGAKU")))
										ElseIf "1".Equals(value) Then
											Me._hikazei = Conversions.ToLong(Operators.AddObject(Me._hikazei, dictionary4("KINGAKU")))
										End If
									Next
								Finally
									Dim enumerator2 As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
									CType(enumerator2, IDisposable).Dispose()
								End Try
							End If
							dictionary = Me.getMjosu()
							Me._kazei = num
							Me.dispTotal(dictionary)
						Else
							Dim list3 As List(Of Dictionary(Of String, Object)) = Me.getSeikyuTable(False)
							If list3.Count > 0 Then
								Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(list3(0)("SEIKYU_YYYYMM"))
								list3 = Me.getSeikyuMeisaiTable(RuntimeHelpers.GetObjectValue(objectValue3))
								sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYU  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
								If Not sqlDataBase.execSql(sSQL2) Then
									Me.lblMessage.Text = "請求テーブル(ヘッダー)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
									Return False
								End If
								sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYUM  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
								If Not sqlDataBase.execSql(sSQL2) Then
									Me.lblMessage.Text = "請求テーブル(明細)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
									Return False
								End If
								Dim num10 As Integer = 1
								Try
									For Each dictionary5 As Dictionary(Of String, Object) In list3
										value = Conversions.ToString(dictionary5("KAZEI_KBN"))
										sSQL = Me.insertSeikyuMeisai2(num10.ToString().ToString(), dictionary5)
										If Not sqlDataBase.execSql(sSQL) Then
											Return False
										End If
										num10 += 1
										If String.IsNullOrEmpty(value) Then
											num = Conversions.ToLong(Operators.AddObject(num, dictionary5("KINGAKU")))
										ElseIf "1".Equals(value) Then
											Me._hikazei = Conversions.ToLong(Operators.AddObject(Me._hikazei, dictionary5("KINGAKU")))
										End If
									Next
								Finally
									Dim enumerator3 As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
									CType(enumerator3, IDisposable).Dispose()
								End Try
								Dim dictionary As Dictionary(Of String, Object) = Me.getMjosu()
								Me._kazei = num
								Me.dispTotal(dictionary)
							Else
								Me.lblMessage.Text = "払出明細データが存在しません。"
								sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYU  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
								If Not sqlDataBase.execSql(sSQL2) Then
									Me.lblMessage.Text = "請求テーブル(ヘッダー)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
									Return False
								End If
								sSQL2 = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYUM  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
								If Not sqlDataBase.execSql(sSQL2) Then
									Me.lblMessage.Text = "請求テーブル(明細)の削除処理に失敗しました。" & vbCrLf & "データベースを確認して再度実施して下さい。"
									Return False
								End If
								Dim dictionary As Dictionary(Of String, Object) = Me.getMtori(Me.ComboTori1.Text)
								text2 = Conversions.ToString(dictionary("SEIKYU_TYPE"))
							End If
						End If
						sSQL = Me.insertSeikyuHeader(text2)
						If Not sqlDataBase.execSql(sSQL) Then
							Return False
						End If
						sqlDataBase.CommitTransact()
						text = Me.makeSql()
						ucDgv = Me.UcDgv
						custDgv = ucDgv.CustDgv
						Dim gridViewInfo2 As New ControlDataGridView(custDgv, Me._conf)
						ucDgv.CustDgv = custDgv
						Me._gridViewInfo = gridViewInfo2
						Me._gridViewInfo.listOfHidden.Add("SAKU_KBN")
						Me._gridViewInfo.DisplayGridView(text, 0)
						GoTo IL_E92
					Catch ex As Exception
						OutputLog.WriteLine(Me.Name + ":gridDisplay:" + ex.Message)
						DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End If
				DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Using
IL_E92:
			Me.changeGridview()
			Return True
		End Function

		Private Function delSeikyu() As Boolean
			Dim text As String = String.Empty
			Dim result As Boolean = False
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Try
					sqlDataBase.BeginTransaction()
					text = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYU  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
					If sqlDataBase.execSql(text) Then
						text = String.Concat(New String() {"DELETE FROM Ukeharai.T_SEIKYUM  WHERE TORI_CD = '", Me.ComboTori1.Text.Trim(), "' AND SEIKYU_YYYYMM = '", Me.getTergetTime(), "'"})
						If sqlDataBase.execSql(text) Then
							sqlDataBase.CommitTransact()
							result = True
						End If
					End If
				Catch ex As Exception
					OutputLog.WriteLine(Me.Name + ":Delete SEIKYU:" + ex.Message)
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End Using
			Return result
		End Function

		Private Sub InitDisplay()
			Me.ExecFlag = False
			Me.CclDateTimePicker1.Value = Nothing
			Me.lblMessage.Text = Nothing
			Me.UcDgv.CustDgv.Rows.Clear()
			Me.ComboTori1.Focus()
		End Sub

		Private Function makeUpdateSeikyuTable() As String
			Dim list As New List(Of sqlWork)()
			Dim list2 As New List(Of sqlWork)()
			list.Add(New sqlWork("KAZEI", Conversions.ToString(Me._kazei), "Integer"))
			list.Add(New sqlWork("HIKAZEI", Conversions.ToString(Me._hikazei), "Integer"))
			list.Add(New sqlWork("SYOHIZEI", Conversions.ToString(Me._syohizei), "Integer"))
			list.Add(New sqlWork("GOUKEI", Conversions.ToString(Me._goukei), "Integer"))
			list.Add(New sqlWork("UPDATE_USER", Me._conf.xmlConfData.xDataBase.UserId, "String"))
			list.Add(New sqlWork("UPDATE_DTM", Conversions.ToString(DateAndTime.Now), "Date"))
			list.Add(New sqlWork("UPDATE_FUNCTION", Me.Name, "String"))
			Dim text As String = "UPDATE Ukeharai.T_SEIKYU SET "
			Try
				For Each sqlWork As sqlWork In list
					If "NULL".Equals(sqlWork.value) Then
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					ElseIf "String".Equals(sqlWork.type) Or "Date".Equals(sqlWork.type) Then
						text = String.Concat(New String() {text, sqlWork.name, "='", sqlWork.value, "' ,"})
					ElseIf String.IsNullOrEmpty(sqlWork.value) Then
						text = text + sqlWork.name + "=NULL ,"
					Else
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			list2.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text.Trim(), "String"))
			list2.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
			If list2.Count > 0 Then
				text += " WHERE "
				Try
					For Each sqlWork2 As sqlWork In list2
						If "String".Equals(sqlWork2.type) Or "Date".Equals(sqlWork2.type) Then
							text = String.Concat(New String() {text, " ", sqlWork2.name, "='", sqlWork2.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork2.name, "=", sqlWork2.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator2, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Return text
		End Function

		Private Function getIndexChangeSeqno() As Integer
			Dim result As Integer = -1
			Dim flag As Boolean = False
			Dim num As Integer = 0
			Dim num2 As Integer = Me.UcDgv.CustDgv.Rows.Count - 1
			For i As Integer = num To num2
				Dim dataGridViewRow As DataGridViewRow = Me.UcDgv.CustDgv.Rows(i)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KUBUN").Value)
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
					If flag Then
						Return result
					End If
				ElseIf "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
					If Me.UcDgv.CustDgv.Rows.Count - 1 = i Then
						Return result
					End If
					If Not flag Then
						result = i
					End If
					flag = True
				ElseIf "変更".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
					If flag Then
						Return result
					End If
				ElseIf "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
					If Me.UcDgv.CustDgv.Rows.Count - 1 = i Then
						Return result
					End If
					If Not flag Then
						result = i
					End If
					flag = True
				End If
			Next
			Return result
		End Function

		Private Function MakeSeikyuMeisaiInsert(uSet As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Dim text2 As String = String.Empty
			uSet.Add(New sqlWork("INSERT_USER", Me._conf.xmlConfData.xDataBase.UserId, "String"))
			uSet.Add(New sqlWork("INSERT_DTM", Conversions.ToString(DateAndTime.Now), "Date"))
			uSet.Add(New sqlWork("INSERT_FUNCTION", Me.Name, "String"))
			Try
				For Each sqlWork As sqlWork In uSet
					text = text + sqlWork.name + " ,"
					If "NULL".Equals(sqlWork.value) Then
						text2 = text2 + sqlWork.value + " ,"
					ElseIf "String".Equals(sqlWork.type) Or "Date".Equals(sqlWork.type) Then
						text2 = text2 + "'" + sqlWork.value + "' ,"
					Else
						text2 = text2 + sqlWork.value + " ,"
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			text2 = text2.TrimEnd(New Char() {","c})
			Return String.Concat(New String() {"INSERT INTO Ukeharai.T_SEIKYUM (", text, " ) VALUES (", text2, " )"})
		End Function

		Private Function MakeSeikyuMeisaiUpdate(uSet As List(Of sqlWork), uWhere As List(Of sqlWork)) As String
			uSet.Add(New sqlWork("UPDATE_USER", Me._conf.xmlConfData.xDataBase.UserId, "String"))
			uSet.Add(New sqlWork("UPDATE_DTM", Conversions.ToString(DateAndTime.Now), "Date"))
			uSet.Add(New sqlWork("UPDATE_FUNCTION", Me.Name, "String"))
			Dim text As String = "UPDATE Ukeharai.T_SEIKYUM SET "
			Try
				For Each sqlWork As sqlWork In uSet
					If "NULL".Equals(sqlWork.value) Then
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					ElseIf "System.String".Equals(sqlWork.type) Or "System.DateTime".Equals(sqlWork.type) Or "String".Equals(sqlWork.type) Or "Date".Equals(sqlWork.type) Then
						text = String.Concat(New String() {text, sqlWork.name, "='", sqlWork.value, "' ,"})
					Else
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			If uWhere.Count > 0 Then
				text += " WHERE "
				Try
					For Each sqlWork2 As sqlWork In uWhere
						If "System.String".Equals(sqlWork2.type) Or "System.DateTime".Equals(sqlWork2.type) Or "String".Equals(sqlWork2.type) Or "Date".Equals(sqlWork2.type) Then
							text = String.Concat(New String() {text, " ", sqlWork2.name, "='", sqlWork2.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork2.name, "=", sqlWork2.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator2, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Console.WriteLine(text)
			Return text
		End Function

		Private Function MakeSeikyuMeisaiDelete(uWhere As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If "String".Equals(sqlWork.type) Or "Date".Equals(sqlWork.type) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "DELETE FROM Ukeharai.T_SEIKYUM WHERE " + text
		End Function


		Private Function UpdateSeikyu() As Boolean
			Dim text As String = String.Empty
			Dim list As New List(Of sqlWork)()
			Dim list2 As New List(Of sqlWork)()
			Dim dictionary As New Dictionary(Of String, Integer)() From {{"追加", 0}, {"変更", 0}, {"削除", 0}}
			Dim indexChangeSeqno As Integer = Me.getIndexChangeSeqno()
			If indexChangeSeqno = -1 Then
				Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					sqlDataBase.BeginTransaction()
					Try
						For Each obj As Object In CType(Me.UcDgv.CustDgv.Rows, IEnumerable)
							Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KUBUN").Value)
							list.Clear()
							list2.Clear()
							If Not (IsNothing(RuntimeHelpers.GetObjectValue(objectValue)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue))) Then
								If "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
									list.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"))
									list.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
									list.Add(New sqlWork("SEIKYU_SQNO", (dataGridViewRow.Index + 1).ToString(), "Int"))
									list.Add(New sqlWork("SAKU_KBN", Conversions.ToString(dataGridViewRow.Cells("SAKU_KBN").Value), "String"))
									list.Add(New sqlWork("UCHIWAKE", Conversions.ToString(dataGridViewRow.Cells("UCHIWAKE").Value), "String"))
									list.Add(New sqlWork("TEKIYO", Conversions.ToString(dataGridViewRow.Cells("TEKIYO").Value), "String"))
									list.Add(New sqlWork("SURYO", Conversions.ToString(Interaction.IIf(dataGridViewRow.Cells("SURYO").Value Is Nothing, "NULL", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("SURYO").Value))), "Long"))
									list.Add(New sqlWork("TANI", Conversions.ToString(dataGridViewRow.Cells("TANI").Value), "String"))
									list.Add(New sqlWork("TANKA", Conversions.ToString(dataGridViewRow.Cells("TANKA").Value), "String"))
									list.Add(New sqlWork("KINGAKU", Conversions.ToString(Interaction.IIf(dataGridViewRow.Cells("KINGAKU").Value Is Nothing, "NULL", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KINGAKU").Value))), "Long"))
									list.Add(New sqlWork("KAZEI_KBN", Conversions.ToString(dataGridViewRow.Cells("KAZEI_KBN").Value), "String"))
									list.Add(New sqlWork("MEISAI_UMU", Conversions.ToString(dataGridViewRow.Cells("MEISAI_UMU").Value), "String"))
									list.Add(New sqlWork("SAKI_CD", Conversions.ToString(dataGridViewRow.Cells("SAKI_CD").Value), "String"))
									text = Me.MakeSeikyuMeisaiInsert(list)
									If sqlDataBase.execSql(text) Then
										Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
										Dim dictionary3 As Dictionary(Of String, Integer) = dictionary2
										Dim value As Object = objectValue
										dictionary3(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
									End If
								ElseIf "変更".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
									Dim dictionary4 As Dictionary(Of String, Object) = Me._gridViewInfo.dataInfo.DataList(Conversions.ToInteger(dataGridViewRow.Cells("ROW").Value.ToString()))
									Try
										For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me._gridViewInfo.dataInfo.ItemDetail
											If Not "KUBUN".Equals(keyValuePair.Key) Then
												Dim obj2 As Object = Nothing
												Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(dictionary4(keyValuePair.Key))
												If keyValuePair.Value.type Is GetType(String) Then
													obj2 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
												ElseIf keyValuePair.Value.type Is GetType(Decimal) Then
													If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).Value)) Then
														obj2 = "NULL"
													Else
														Dim s As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).Value)
														Dim num As Decimal = Conversions.ToDecimal(obj2)
														Decimal.TryParse(s, num)
														obj2 = num
													End If
												ElseIf keyValuePair.Value.type Is GetType(DateTime) Then
													If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair.Key).Value)) Then
														obj2 = "NULL"
													Else
														Dim s2 As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
														Dim dateTime As DateTime = Conversions.ToDate(obj2)
														DateTime.TryParse(s2, dateTime)
														obj2 = dateTime
													End If
												End If
												If obj2 IsNot Nothing Then
													If Not obj2.Equals(RuntimeHelpers.GetObjectValue(objectValue2)) Then
														list.Add(New sqlWork(keyValuePair.Key, Conversions.ToString(obj2), keyValuePair.Value.type.ToString()))
													End If
													If keyValuePair.Value.iskey Then
														If "SEIKYU_YYYYMM".Equals(keyValuePair.Key) Then
															list2.Add(New sqlWork(keyValuePair.Key, Me.getTergetTime(), keyValuePair.Value.type.ToString()))
														Else
															list2.Add(New sqlWork(keyValuePair.Key, objectValue2.ToString(), keyValuePair.Value.type.ToString()))
														End If
													End If
												End If
											End If
										Next
									Finally
										Dim enumerator2 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
										CType(enumerator2, IDisposable).Dispose()
									End Try
									If list.Count <> 0 Then
										text = Me.MakeSeikyuMeisaiUpdate(list, list2)
										If sqlDataBase.execSql(text) Then
											Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
											Dim dictionary5 As Dictionary(Of String, Integer) = dictionary2
											Dim value As Object = objectValue
											dictionary5(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
										End If
									End If
								ElseIf "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
									list2.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"))
									list2.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
									list2.Add(New sqlWork("SEIKYU_SQNO", Conversions.ToString(dataGridViewRow.Cells("SEIKYU_SQNO").Value), "Int"))
									text = Me.MakeSeikyuMeisaiDelete(list2)
									If sqlDataBase.execSql(text) Then
										Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
										Dim dictionary6 As Dictionary(Of String, Integer) = dictionary2
										Dim value As Object = objectValue
										dictionary6(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
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
					Dim sSQL As String = Me.makeSql()
					Dim tergetTime As String = Me.getTergetTime()
					Me.InitGoukei()
					sqlDataBase.getSQLData(sSQL, False)
					Try
						For Each dictionary7 As Dictionary(Of String, Object) In sqlDataBase.DbData.DataList
							Dim value2 As String = Conversions.ToString(dictionary7("KAZEI_KBN"))
							If String.IsNullOrEmpty(value2) Then
								Me._kazei = Conversions.ToLong(Operators.AddObject(Me._kazei, dictionary7("KINGAKU")))
							ElseIf "1".Equals(value2) Then
								Me._hikazei = Conversions.ToLong(Operators.AddObject(Me._hikazei, dictionary7("KINGAKU")))
							End If
						Next
					Finally
						Dim enumerator3 As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
						CType(enumerator3, IDisposable).Dispose()
					End Try
					Dim mjosu As Dictionary(Of String, Object) = Me.getMjosu()
					Me.dispTotal(mjosu)
					Dim seikyuTable As List(Of Dictionary(Of String, Object)) = Me.getSeikyuTable(True)
					If seikyuTable.Count = 1 Then
						If Not Me._kazei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable(0)("KAZEI")))) OrElse Not Me._hikazei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable(0)("HIKAZEI")))) OrElse Not Me._syohizei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable(0)("SYOHIZEI")))) OrElse Not Me._goukei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable(0)("GOUKEI")))) Then
							text = Me.makeUpdateSeikyuTable()
							sqlDataBase.execSql(text)
						End If
					End If
					sqlDataBase.CommitTransact()
					GoTo IL_13C0
				End Using
			End If
			Using sqlDataBase2 As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				sqlDataBase2.BeginTransaction()
				list2.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"))
				list2.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
				text = Me.MakeSeikyuMeisaiDelete(list2) + " AND SEIKYU_SQNO >= " + (indexChangeSeqno + 1).ToString()
				If Not sqlDataBase2.execSql(text) Then
					DlgMessageBox.Show("更新処理に失敗しました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				Dim num2 As Integer = 0
				Dim num3 As Integer = indexChangeSeqno - 1
				For i As Integer = num2 To num3
					Dim dataGridViewRow2 As DataGridViewRow = Me.UcDgv.CustDgv.Rows(i)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("KUBUN").Value)
					list.Clear()
					list2.Clear()
					If Not (IsNothing(RuntimeHelpers.GetObjectValue(objectValue3)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue3))) Then
						If Not "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue3)) Then
							If "変更".Equals(RuntimeHelpers.GetObjectValue(objectValue3)) Then
								Dim dictionary8 As Dictionary(Of String, Object) = Me._gridViewInfo.dataInfo.DataList(i)
								Try
									For Each keyValuePair2 As KeyValuePair(Of String, ItemInfo) In Me._gridViewInfo.dataInfo.ItemDetail
										If Not "KUBUN".Equals(keyValuePair2.Key) Then
											Dim obj3 As Object = Nothing
											Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(dictionary8(keyValuePair2.Key))
											If keyValuePair2.Value.type Is GetType(String) Then
												obj3 = RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(keyValuePair2.Key).FormattedValue)
											ElseIf keyValuePair2.Value.type Is GetType(Decimal) Then
												If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow2.Cells(keyValuePair2.Key).Value)) Then
													obj3 = "NULL"
												Else
													Dim s3 As String = Conversions.ToString(dataGridViewRow2.Cells(keyValuePair2.Key).Value)
													Dim num As Decimal = Conversions.ToDecimal(obj3)
													Decimal.TryParse(s3, num)
													obj3 = num
												End If
											ElseIf keyValuePair2.Value.type Is GetType(DateTime) Then
												If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(keyValuePair2.Key).Value)) Then
													obj3 = "NULL"
												Else
													Dim s4 As String = Conversions.ToString(dataGridViewRow2.Cells(keyValuePair2.Key).FormattedValue)
													Dim dateTime As DateTime = Conversions.ToDate(obj3)
													DateTime.TryParse(s4, dateTime)
													obj3 = dateTime
												End If
											End If
											If obj3 IsNot Nothing Then
												If Not obj3.Equals(RuntimeHelpers.GetObjectValue(objectValue4)) Then
													list.Add(New sqlWork(keyValuePair2.Key, Conversions.ToString(obj3), keyValuePair2.Value.type.ToString()))
												End If
												If keyValuePair2.Value.iskey Then
													If "SEIKYU_YYYYMM".Equals(keyValuePair2.Key) Then
														list2.Add(New sqlWork(keyValuePair2.Key, Me.getTergetTime(), keyValuePair2.Value.type.ToString()))
													Else
														list2.Add(New sqlWork(keyValuePair2.Key, objectValue4.ToString(), keyValuePair2.Value.type.ToString()))
													End If
												End If
											End If
										End If
									Next
								Finally
									Dim enumerator4 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
									CType(enumerator4, IDisposable).Dispose()
								End Try
								If list.Count <> 0 Then
									text = Me.MakeSeikyuMeisaiUpdate(list, list2)
									If sqlDataBase2.execSql(text) Then
										Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
										Dim dictionary9 As Dictionary(Of String, Integer) = dictionary2
										Dim value As Object = objectValue3
										dictionary9(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
									End If
								End If
							ElseIf "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue3)) Then 'とりあえずエラー修正。コマンドを入れる??
							End If
						End If
					End If
				Next
				Dim num4 As Integer = indexChangeSeqno
				Dim num5 As Integer = Me.UcDgv.CustDgv.Rows.Count - 1
				For j As Integer = num4 To num5
					Dim dataGridViewRow3 As DataGridViewRow = Me.UcDgv.CustDgv.Rows(j)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells("KUBUN").Value)
					list.Clear()
					list2.Clear()
					If IsNothing(RuntimeHelpers.GetObjectValue(objectValue5)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue5)) Or "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue5)) Or "変更".Equals(RuntimeHelpers.GetObjectValue(objectValue5)) Then
						list.Add(New sqlWork("TORI_CD", Me.ComboTori1.Text, "String"))
						list.Add(New sqlWork("SEIKYU_YYYYMM", Me.getTergetTime(), "Date"))
						list.Add(New sqlWork("SEIKYU_SQNO", (j + 1 - dictionary("削除")).ToString(), "Int"))
						list.Add(New sqlWork("SAKU_KBN", Conversions.ToString(dataGridViewRow3.Cells("SAKU_KBN").Value), "String"))
						list.Add(New sqlWork("UCHIWAKE", Conversions.ToString(dataGridViewRow3.Cells("UCHIWAKE").Value), "String"))
						list.Add(New sqlWork("TEKIYO", Conversions.ToString(dataGridViewRow3.Cells("TEKIYO").Value), "String"))
						list.Add(New sqlWork("SURYO", Conversions.ToString(Interaction.IIf(dataGridViewRow3.Cells("SURYO").Value Is Nothing, "NULL", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells("SURYO").Value))), "Long"))
						list.Add(New sqlWork("TANI", Conversions.ToString(dataGridViewRow3.Cells("TANI").Value), "String"))
						list.Add(New sqlWork("TANKA", Conversions.ToString(dataGridViewRow3.Cells("TANKA").Value), "String"))
						list.Add(New sqlWork("KINGAKU", Conversions.ToString(Interaction.IIf(dataGridViewRow3.Cells("KINGAKU").Value Is Nothing, "NULL", RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells("KINGAKU").Value))), "Long"))
						list.Add(New sqlWork("KAZEI_KBN", Conversions.ToString(dataGridViewRow3.Cells("KAZEI_KBN").Value), "String"))
						list.Add(New sqlWork("MEISAI_UMU", Conversions.ToString(dataGridViewRow3.Cells("MEISAI_UMU").Value), "String"))
						list.Add(New sqlWork("SAKI_CD", Conversions.ToString(dataGridViewRow3.Cells("SAKI_CD").Value), "String"))
						text = Me.MakeSeikyuMeisaiInsert(list)
						If sqlDataBase2.execSql(text) Then
							If Not (IsNothing(RuntimeHelpers.GetObjectValue(objectValue5)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue5))) Then
								Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
								Dim dictionary10 As Dictionary(Of String, Integer) = dictionary2
								Dim value As Object = objectValue5
								dictionary10(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
							End If
						End If
					ElseIf "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue5)) Then
						Dim dictionary2 As Dictionary(Of String, Integer) = dictionary
						Dim dictionary11 As Dictionary(Of String, Integer) = dictionary2
						Dim value As Object = objectValue5
						dictionary11(Conversions.ToString(value)) = dictionary2(Conversions.ToString(value)) + 1
					End If
				Next
				Dim sSQL2 As String = Me.makeSql()
				Dim tergetTime2 As String = Me.getTergetTime()
				Me.InitGoukei()
				sqlDataBase2.getSQLData(sSQL2, False)
				Try
					For Each dictionary12 As Dictionary(Of String, Object) In sqlDataBase2.DbData.DataList
						Dim value3 As String = Conversions.ToString(dictionary12("KAZEI_KBN"))
						If String.IsNullOrEmpty(value3) Then
							Me._kazei = Conversions.ToLong(Operators.AddObject(Me._kazei, dictionary12("KINGAKU")))
						ElseIf "1".Equals(value3) Then
							Me._hikazei = Conversions.ToLong(Operators.AddObject(Me._hikazei, dictionary12("KINGAKU")))
						End If
					Next
				Finally
					Dim enumerator5 As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
					CType(enumerator5, IDisposable).Dispose()
				End Try
				Dim mjosu2 As Dictionary(Of String, Object) = Me.getMjosu()
				Me.dispTotal(mjosu2)
				Dim seikyuTable2 As List(Of Dictionary(Of String, Object)) = Me.getSeikyuTable(True)
				If seikyuTable2.Count = 1 Then
					If Not Me._kazei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable2(0)("KAZEI")))) OrElse Not Me._hikazei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable2(0)("HIKAZEI")))) OrElse Not Me._syohizei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable2(0)("SYOHIZEI")))) OrElse Not Me._goukei.Equals(Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(seikyuTable2(0)("GOUKEI")))) Then
						text = Me.makeUpdateSeikyuTable()
						sqlDataBase2.execSql(text)
					End If
				End If
				sqlDataBase2.CommitTransact()
			End Using
IL_13C0:
			Dim sMessage As String = "更新処理が正常に終了しました。"
			Dim text2 As String = String.Empty
			Try
				For Each keyValuePair3 As KeyValuePair(Of String, Integer) In dictionary
					text2 = String.Concat(New String() {text2, keyValuePair3.Key, "[", Conversions.ToString(keyValuePair3.Value), "]  "})
				Next
			Finally
				Dim enumerator6 As Dictionary(Of String, Integer).Enumerator = Nothing
				CType(enumerator6, IDisposable).Dispose()
			End Try
			text = Me.makeSql()
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.listOfHidden.Add("SAKU_KBN")
			Me._gridViewInfo.DisplayGridView(text, 0)
			Me.UcDgv.CustDgv.IsChanged = False
			DlgMessageBox.Show(sMessage, "結果", MessageBoxButtons.OK)
			undertext = Me.UcDgv.CustDgv.UpdateRows(text2)
			Return True
		End Function

		Private Function chkGridView() As Boolean
			Dim num As Integer = 0
			Dim result As Boolean = False
			Try
				Try
					For Each obj As Object In CType(Me.UcDgv.CustDgv.Rows, IEnumerable)
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Try
							For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me._gridViewInfo.dataInfo.ItemDetail
								If Not String.IsNullOrEmpty(dataGridViewRow.Cells(keyValuePair.Key).ErrorText) Then
									If num = 0 Then
										Me.UcDgv.CustDgv.CurrentCell = dataGridViewRow.Cells(keyValuePair.Key)
									End If
									num += 1
									Exit For
								End If
							Next
						Finally
							Dim enumerator2 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
							CType(enumerator2, IDisposable).Dispose()
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If num = 0 Then
					result = True
				Else
					DlgMessageBox.Show("入力エラーのため一部行を更新できませんでした。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
			Catch ex As Exception
				Me.lblMessage.Text = "マスタ登録中にエラーが発生しました。"
				OutputLog.WriteLine("RegisterBaseForm RBM_ExecutButton.Click Error {0} : {1}", New String() {MyBase.FormTitleLabel.Text, ex.Message})
				DlgMessageBox.Show("マスタ登録中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return result
		End Function

		Private Sub RegisterSeikyuMasterForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Me.lblTori.Text = String.Empty
			Cursor.Current = Cursors.WaitCursor
			Me._conf = TopForm.ConfigData
			Me.ComboTori1.SetItemList()
			Dim sql As String = Me.BASESQL + "where 0=1"
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.listOfHidden.Add("SAKU_KBN")
			Me._gridViewInfo.DisplayGridView(sql, 0)
			Me.InitDisplay()
			Me.CclDateTimePicker1.Value = DateAndTime.Now
		End Sub

		Private Sub UcDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			Dim dataGridViewRow As DataGridViewRow = customDataGridView.Rows(e.RowIndex)
			If Operators.ConditionalCompareObjectEqual(customDataGridView.CellValuePre, dataGridViewRow.Cells(e.ColumnIndex).Value, False) Then
				Return
			End If
			If "SAKI_CD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("SAKI_CD").ErrorText = Nothing
				If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					Return
				End If
				Dim text As String = dataGridViewRow.Cells(e.ColumnIndex).Value.ToString().Trim()
				Dim text2 As String = "SELECT SAKI_CD FROM Ukeharai.M_SAKI WHERE SAKI_CD ='" + text + "'"
				Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					Dim sqldata As String = sqlDataBase.getSQLData(text2, False)
					If String.IsNullOrEmpty(sqldata) Then
						Try
							If sqlDataBase.DbData.DataList.Count = 0 Then
								dataGridViewRow.Cells("SAKI_CD").ErrorText = "入力値に誤りがあります！"
								DlgMessageBox.Show(String.Format("納入先コードが存在しません。[{0}]", text), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								GoTo IL_330
							End If
							dataGridViewRow.Cells("SAKI_CD").ErrorText = Nothing
							GoTo IL_330
						Catch ex As Exception
							DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							dataGridViewRow.Cells("SAKI_CD").ErrorText = "グリッド表示中にエラーが発生しました。"
							Return
						End Try
					End If
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text2 + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					dataGridViewRow.Cells("SAKI_CD").ErrorText = "SQL実行中にエラーが発生しました。"
					Return
				End Using
			End If
			'ここ後で直す
			If "KAZEI_KBN".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("KAZEI_KBN").ErrorText = Nothing
				If Not (String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("KAZEI_KBN").Value)) Or "1".Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KAZEI_KBN").Value))) Then
					dataGridViewRow.Cells("KAZEI_KBN").ErrorText = "入力値に誤りがあります！"
				End If
			End If
			If "MEISAI_UMU".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("MEISAI_UMU").ErrorText = Nothing
				If Not (String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("MEISAI_UMU").Value)) Or "1".Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("MEISAI_UMU").Value))) Then
					dataGridViewRow.Cells("MEISAI_UMU").ErrorText = "入力値に誤りがあります！"
				End If
			End If
IL_330:
			dataGridViewRow = Nothing
		End Sub

		Private Sub RegisterSeikyuMasterForm_KeyUp(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.F9 Then
				Me.btnDelete.PerformClick()
			End If
		End Sub

		Private Sub ComboTori1_TextChanged(sender As Object, e As EventArgs) Handles ComboTori1.TextChanged
			Dim itemInfomation As ItemInfomation = CType(Me.ComboTori1.SelectedItem, ItemInfomation)
			Me.lblTori.Text = String.Empty
		End Sub

		Private Sub ComboTori1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTori1.SelectedIndexChanged
			Dim itemInfomation As ItemInfomation = CType(Me.ComboTori1.SelectedItem, ItemInfomation)
			If IsNothing(itemInfomation) Then
				Me.lblTori.Text = Nothing
			Else
				Me.lblTori.Text = itemInfomation.Name
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("RSM_ReferButton")>
		Private WithEvents RSM_ReferButton As Button

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("CclDateTimePicker1")>
		Private WithEvents CclDateTimePicker1 As CclDateTimePicker

		<AccessedThroughProperty("Label2")>
		Private WithEvents Label2 As Label

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("BtnCancel")>
		Private WithEvents BtnCancel As Button

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("lblSeikyuNo")>
		Private WithEvents lblSeikyuNo As Label

		<AccessedThroughProperty("lblMessage")>
		Private WithEvents lblMessage As Label

		<AccessedThroughProperty("Label3")>
		Private WithEvents Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private WithEvents Label4 As Label

		<AccessedThroughProperty("lblKazei")>
		Private WithEvents lblKazei As Label

		<AccessedThroughProperty("lblHikazei")>
		Private WithEvents lblHikazei As Label

		<AccessedThroughProperty("lblTotal")>
		Private WithEvents lblTotal As Label

		<AccessedThroughProperty("lblSyohizei")>
		Private WithEvents lblSyohizei As Label

		<AccessedThroughProperty("Label9")>
		Private WithEvents Label9 As Label

		<AccessedThroughProperty("Label10")>
		Private WithEvents Label10 As Label

		<AccessedThroughProperty("btnDelete")>
		Private WithEvents btnDelete As Button

		<AccessedThroughProperty("lblTori")>
		Private WithEvents lblTori As Label

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("CustomDataGridView1")>
		Private _CustomDataGridView1 As CustomDataGridView

		Private _kazei As Long

		Private _hikazei As Long

		Private _syohizei As Long

		Private _goukei As Long

		Private TANI_EN As String

		Private TANI_PC As String

		Private BASESQL As String

		Private _bkcolor_readonly As Color

		Private _bkcolor_normal As Color

		Private Const MAXROWCOUNT As Integer = 30

		Private _conf As XmlConfigControl

		Private _execFlag As Boolean

		Protected Class sqlWork

			Private _name As String
			Private _value As String
			Private _type As String
			Public Property name As String
				Get
					Return Me._name
				End Get
				Set(value As String)
					Me._name = value
				End Set
			End Property

			Public Property value As String
				Get
					Return Me._value
				End Get
				Set(value As String)
					Me._value = value
				End Set
			End Property

			Public Property type As String
				Get
					Return Me._type
				End Get
				Set(value As String)
					Me._type = value
				End Set
			End Property

			Public Sub New(n As String, v As String, Optional t As String = "String")
				Me.name = n
				Me.value = v
				Me.type = t
			End Sub

		End Class

		Private Sub RSM_ReferButton_Click(sender As Object, e As EventArgs) Handles RSM_ReferButton.Click
			Me.RSM_ReferButton.Enabled = False
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.lblMessage.Text = Nothing
				Me.UcDgv.CustDgv.Rows.Clear()
				Me.lblSeikyuNo.Text = Nothing
				If Me._conf IsNot Nothing Then
					If Me.chkInput(False) Then
						Me.ExecFlag = Me.gridDisplay()
						If Me.ExecFlag Then
							Me.btnDelete.Enabled = String.IsNullOrEmpty(Me.lblSeikyuNo.Text)
						End If
					End If
				End If
			Catch ex As Exception
				OutputLog.WriteLine(Me.Name + ":RSM_ReferButton_Click:" + ex.Message)
			Finally
				Me.RSM_ReferButton.Enabled = True
			End Try
		End Sub

		Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
			Dim dialogResult As DialogResult = MessageBox.Show("請求書を削除します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult <> DialogResult.Yes Then
				Return
			End If
			Dim flag As Boolean = False
			Cursor.Current = Cursors.WaitCursor
			Me.btnDelete.Enabled = False
			Try
				flag = Me.delSeikyu()
				If flag Then
					Me.ExecFlag = False
					Me.lblMessage.Text = "請求書を削除しました。"
					Me.UcDgv.CustDgv.Rows.Clear()
				Else
					Me.ExecFlag = False
					Me.lblMessage.Text = "請求書の削除に失敗しました。"
				End If
				Me.ComboTori1.Focus()
			Catch ex As Exception
				OutputLog.WriteLine(Me.Name + ":btnDelete_Click:" + ex.Message)
			Finally
				Me.btnDelete.Enabled = Not flag
			End Try
		End Sub

		Private Sub AddRow_Button_Click(sender As Object, e As EventArgs) Handles AddRow_Button.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			If Not Me.chkInput(True) Then
				Return
			End If
			If Me.UcDgv.CustDgv.RowCount >= 30 Then
				Return
			End If
			Dim dictionary As New Dictionary(Of String, Object)()
			dictionary("TORI_CD") = Me.ComboTori1.Text.Trim()
			dictionary("SEIKYU_YYYYMM") = Conversions.ToDate(NewLateBinding.LateGet(Me.CclDateTimePicker1.Value, Nothing, "Date", New Object(-1) {}, Nothing, Nothing, Nothing)).ToString("yyyy/MM/01")
			dictionary("SEIKYU_NO") = Me.lblSeikyuNo.Text.Trim()
			dictionary("SAKU_KBN") = "2"
			Me._gridViewInfo.RowAdd(dictionary, False)
			Me.changeGridview()
		End Sub

		Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
			Cursor.Current = Cursors.WaitCursor
			Me.BtnCancel.Enabled = False
			Me.ExecFlag = False
			Me.CclDateTimePicker1.Value = Nothing
			Me.lblMessage.Text = Nothing
			Me.UcDgv.CustDgv.Rows.Clear()
			Me.UcDgv.CustDgv.IsChanged = False
			Me.ComboTori1.Focus()
			Me.BtnCancel.Enabled = True
		End Sub

		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			If Not Me.chkInput(True) Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.RBM_ExecutButton.Enabled = False
			Me.ReViewFlag = False
			If Not Me.chkGridView() Then
				Me.RBM_ExecutButton.Enabled = True
				Return
			End If
			Try
				If Me._gridViewInfo.IsChanged() Then
					Me.ReViewFlag = Me.UpdateSeikyu()
					Me.lblMessage.Text = "請求書を更新しました。"
					Dim ucdgv As UcDataGridView = Me.UcDgv
					ucdgv.CustDgv_SendMessage(undertext)
				Else
					DlgMessageBox.Show("更新データありません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.lblMessage.Text = "更新データありません。"
				End If
			Catch ex As Exception
				Me.lblMessage.Text = "マスタ登録中にエラーが発生しました。"
				OutputLog.WriteLine("RegisterBaseForm RBM_ExecutButton.Click Error {0} : {1}", New String() {MyBase.FormTitleLabel.Text, ex.Message})
				DlgMessageBox.Show("マスタ登録中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
			End Try
			Me.changeGridview()
			Me.RBM_ExecutButton.Enabled = True
		End Sub
	End Class
End Namespace
