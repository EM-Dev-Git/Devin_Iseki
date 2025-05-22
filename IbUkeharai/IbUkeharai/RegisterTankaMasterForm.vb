Imports System
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
	Public Class RegisterTankaMasterForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterTankaMasterForm_Load
			Me.BASESQL = "SELECT '' AS KUBUN, tanka.BUHIN_CD, buhin.BUHIN_NAME, tanka.SAKI_CD, tanka.SAGYO, tanka.YUKO_FM, tanka.YUKO_TO FROM Ukeharai.M_TANKA AS tanka LEFT JOIN Ukeharai.M_BUHIN AS buhin ON tanka.BUHIN_CD = buhin.BUHIN_CD AND tanka.TORI_CD = buhin.TORI_CD "
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
			Me.RTNM_ReferButton = New Button()
			Me.BuhinLabel = New Label()
			Me.TorihikiLabel = New Label()
			Me.NounyuLabel = New Label()
			Me.NounyuCodeTextBox = New TextBox()
			Me.AddRow_Button = New Button()
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.BtnCancel = New Button()
			Me.lblTori = New Label()
			Me.CclBuhinCode1 = New DitCore.CclBuhinCode()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Size = New Size(1010, 45)
			Me.FormTitleLabel.Text = "単価マスター登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.Location = New Point(915, 560)
			Me.RBM_BackButton.TabIndex = 8
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.Location = New Point(743, 560)
			Me.RBM_ExecutButton.TabIndex = 6
			'
			'RTNM_ReferButton
			'
			Me.RTNM_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RTNM_ReferButton.Location = New Point(536, 55)
			Me.RTNM_ReferButton.Name = "RTNM_ReferButton"
			Me.RTNM_ReferButton.Size = New Size(80, 30)
			Me.RTNM_ReferButton.TabIndex = 3
			Me.RTNM_ReferButton.Text = "参照"
			Me.RTNM_ReferButton.UseVisualStyleBackColor = True
			'
			'BuhinLabel
			'
			Me.BuhinLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BuhinLabel.Location = New Point(203, 61)
			Me.BuhinLabel.Name = "BuhinLabel"
			Me.BuhinLabel.Size = New Size(35, 18)
			Me.BuhinLabel.TabIndex = 23
			Me.BuhinLabel.Text = "部品"
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(15, 61)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(48, 18)
			Me.TorihikiLabel.TabIndex = 50
			Me.TorihikiLabel.Text = "取引先"
			'
			'NounyuLabel
			'
			Me.NounyuLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NounyuLabel.Location = New Point(402, 61)
			Me.NounyuLabel.Name = "NounyuLabel"
			Me.NounyuLabel.Size = New Size(48, 18)
			Me.NounyuLabel.TabIndex = 27
			Me.NounyuLabel.Text = "納入先"
			'
			'NounyuCodeTextBox
			'
			Me.NounyuCodeTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NounyuCodeTextBox.ImeMode = ImeMode.Disable
			Me.NounyuCodeTextBox.Location = New Point(456, 58)
			Me.NounyuCodeTextBox.MaxLength = 2
			Me.NounyuCodeTextBox.Name = "NounyuCodeTextBox"
			Me.NounyuCodeTextBox.Size = New Size(25, 19)
			Me.NounyuCodeTextBox.TabIndex = 2
			'
			'AddRow_Button
			'
			Me.AddRow_Button.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
			Me.AddRow_Button.BackColor = Color.DodgerBlue
			Me.AddRow_Button.FlatStyle = FlatStyle.Popup
			Me.AddRow_Button.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.AddRow_Button.ForeColor = Color.White
			Me.AddRow_Button.Location = New Point(18, 560)
			Me.AddRow_Button.Name = "AddRow_Button"
			Me.AddRow_Button.Size = New Size(80, 30)
			Me.AddRow_Button.TabIndex = 5
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
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
			Me.ComboTori1.Location = New Point(69, 58)
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
			Me.BtnCancel.Location = New Point(829, 560)
			Me.BtnCancel.Name = "BtnCancel"
			Me.BtnCancel.Size = New Size(80, 30)
			Me.BtnCancel.TabIndex = 7
			Me.BtnCancel.Text = "キャンセル"
			Me.BtnCancel.UseVisualStyleBackColor = True
			'
			'lblTori
			'
			Me.lblTori.AutoSize = True
			Me.lblTori.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.lblTori.Location = New Point(67, 87)
			Me.lblTori.Name = "lblTori"
			Me.lblTori.Size = New Size(65, 12)
			Me.lblTori.TabIndex = 28
			Me.lblTori.Text = "取引先名称"
			'
			'CclBuhinCode1
			'
			Me.CclBuhinCode1.Font = New Font("ＭＳ Ｐゴシック", 9.5!)
			Me.CclBuhinCode1.ImeMode = ImeMode.Disable
			Me.CclBuhinCode1.Location = New Point(244, 57)
			Me.CclBuhinCode1.Mask = "aaaa-aaa-aaa-aa"
			Me.CclBuhinCode1.Name = "CclBuhinCode1"
			Me.CclBuhinCode1.Size = New Size(141, 20)
			Me.CclBuhinCode1.TabIndex = 1
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Location = New Point(18, 108)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(977, 437)
			Me.UcDgv.TabIndex = 4
			'
			'RegisterTankaMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(1010, 602)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.CclBuhinCode1)
			Me.Controls.Add(Me.lblTori)
			Me.Controls.Add(Me.BtnCancel)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.NounyuLabel)
			Me.Controls.Add(Me.NounyuCodeTextBox)
			Me.Controls.Add(Me.RTNM_ReferButton)
			Me.Controls.Add(Me.BuhinLabel)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.Name = "RegisterTankaMasterForm"
			Me.Text = "単価マスター登録画面"
			Me.TtileName = "単価マスター登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.TorihikiLabel, 0)
			Me.Controls.SetChildIndex(Me.BuhinLabel, 0)
			Me.Controls.SetChildIndex(Me.RTNM_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.NounyuCodeTextBox, 0)
			Me.Controls.SetChildIndex(Me.NounyuLabel, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.ComboTori1, 0)
			Me.Controls.SetChildIndex(Me.BtnCancel, 0)
			Me.Controls.SetChildIndex(Me.lblTori, 0)
			Me.Controls.SetChildIndex(Me.CclBuhinCode1, 0)
			Me.Controls.SetChildIndex(Me.UcDgv, 0)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Friend Overridable Property CustDgv As CustomDataGridView
			Get
				Return Me._CustDgv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CustomDataGridView)
				Me._CustDgv = value
			End Set
		End Property

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
				Me.RBM_ExecutButton.Enabled = Me._execFlag
				Me.BtnCancel.Enabled = Me._execFlag
				Me.ComboTori1.Enabled = Not Me._execFlag
				Me.AddRow_Button.Enabled = Me._execFlag
				If Not String.IsNullOrEmpty(Me.ComboTori1.Text.Trim()) AndAlso Not String.IsNullOrEmpty(Me.CclBuhinCode1.Value) Then
					String.IsNullOrEmpty(Me.NounyuCodeTextBox.Text.Trim())
				End If
			End Set
		End Property

		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("tanka.TORI_CD", "'" + text2 + "'")
			End If
			text2 = Me.CclBuhinCode1.Value
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("tanka.BUHIN_CD", "'" + text2 + "%'")
			End If
			text2 = Me.NounyuCodeTextBox.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("tanka.SAKI_CD", "'" + text2 + "%'")
			End If
			If dictionary.Count <= 0 Then
				Return text
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					If keyValuePair.Value.IndexOf("%") >= 0 Then
						text = String.Concat(New String() {text, keyValuePair.Key, " LIKE ", keyValuePair.Value, " AND "})
					Else
						text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " AND "})
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1"
			Return text
		End Function

		Private Function chkInput() As Boolean
			Dim result As Boolean = False
			Me.AddRow_Button.Enabled = False
			If Me.ComboTori1.SelectedIndex < 0 Then
				DlgMessageBox.Show("取引先コードを指定してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.ComboTori1.Focus()
				Return result
			End If
			result = True
			Me.AddRow_Button.Enabled = True
			Return result
		End Function

		Private Sub RegisterTankaMasterForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
			If TypeOf CType(sender, RegisterTankaMasterForm).ActiveControl Is CmpComboBox Then
				Return
			End If
			If e.KeyCode = Keys.[Return] AndAlso Not e.Alt AndAlso Not e.Control Then
				Me.ProcessTabKey(Not e.Shift)
				e.Handled = True
				e.SuppressKeyPress = True
			End If
		End Sub


		Private Sub RegisterTankaMasterForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.lblTori.Text = String.Empty
			Me._conf = TopForm.ConfigData
			Me.ExecFlag = False
			Me.ComboTori1.SetItemList()
			Dim sql As String = Me.BASESQL + "where 0=1"
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.listOfKey.Add("YUKO_FM")
			Me._gridViewInfo.DisplayGridView(sql, 0)
		End Sub

		Private Sub UcDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			If Common.compareObjToObj(RuntimeHelpers.GetObjectValue(customDataGridView.CellValuePre), RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
				Return
			End If
			If "BUHIN_CD".Equals(dataGridViewColumn.Name) Then
				customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = Nothing
				customDataGridView.Rows(e.RowIndex).Cells("BUHIN_NAME").Value = Nothing
				Dim text As String = Me.ComboTori1.Text.Trim()
				If String.IsNullOrEmpty(text) Then
					Return
				End If
				If IsNothing(RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
					customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = "必須項目です。"
					Return
				End If
				Dim text2 As String = customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Trim()
				Dim text3 As String = text2.Replace("-", "").Trim()
				Dim text4 As String = String.Concat(New String() {"SELECT * FROM Ukeharai.M_BUHIN WHERE TORI_CD ='", text, "' AND BUHIN_CD ='", text3, "'"})
				Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					Dim sqldata As String = sqlDataBase.getSQLData(text4, False)
					If String.IsNullOrEmpty(sqldata) Then
						Try
							If sqlDataBase.DbData.DataList.Count = 0 Then
								customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = "入力値に誤りがあります！"
								DlgMessageBox.Show(String.Format("部品コードが存在しません。[{0}]", text2), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								GoTo IL_33F
							End If
							Dim dictionary As Dictionary(Of String, Object) = sqlDataBase.DbData.DataList(0)
							customDataGridView.Rows(e.RowIndex).Cells("BUHIN_NAME").Value = RuntimeHelpers.GetObjectValue(dictionary("BUHIN_NAME"))
							GoTo IL_33F
						Catch ex As Exception
							DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = "グリッド表示中にエラーが発生しました。"
							Return
						End Try
					End If
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text4 + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = "SQL実行中にエラーが発生しました。"
					Return
				End Using
			End If
IL_33F:
			Dim dataGridViewRow As DataGridViewRow = customDataGridView.Rows(e.RowIndex)
			If "SAKI_CD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("SAKI_CD").ErrorText = Nothing
				If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					dataGridViewRow.Cells("SAKI_CD").ErrorText = "必須項目です。"
					Return
				End If
				Dim text5 As String = String.Empty
				If Not IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					text5 = dataGridViewRow.Cells(e.ColumnIndex).Value.ToString().Trim()
				End If
				Dim text6 As String = "SELECT * FROM Ukeharai.M_SAKI WHERE SAKI_CD ='" + text5 + "'"
				Using sqlDataBase2 As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					Dim sqldata2 As String = sqlDataBase2.getSQLData(text6, False)
					If String.IsNullOrEmpty(sqldata2) Then
						Try
							If sqlDataBase2.DbData.DataList.Count = 0 Then
								dataGridViewRow.Cells("SAKI_CD").ErrorText = "入力値に誤りがあります！"
								DlgMessageBox.Show(String.Format("納入先コードが存在しません。[{0}]", text5), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							End If
							GoTo IL_73D
						Catch ex2 As Exception
							DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex2.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							dataGridViewRow.Cells("SAKI_CD").ErrorText = "グリッド表示中にエラーが発生しました。"
							Return
						End Try
					End If
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text6 + vbCrLf + sqldata2, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					dataGridViewRow.Cells("SAKI_CD").ErrorText = "SQL実行中にエラーが発生しました。"
					Return
				End Using
			End If
			If "YUKO_FM".Equals(dataGridViewColumn.Name) Or "YUKO_TO".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("YUKO_FM").ErrorText = Nothing
				dataGridViewRow.Cells("YUKO_TO").ErrorText = Nothing
				Dim flag As Boolean = False
				Dim dateTime As DateTime = Nothing
				Dim dateTime2 As DateTime = Nothing
				If Not DateTime.TryParse(Conversions.ToString(dataGridViewRow.Cells("YUKO_FM").Value), dateTime) Then
					dataGridViewRow.Cells("YUKO_FM").ErrorText = "入力値に誤りがあります！"
					Return
				End If
				If Not DateTime.TryParse(Conversions.ToString(dataGridViewRow.Cells("YUKO_TO").Value), dateTime2) Then
					dataGridViewRow.Cells("YUKO_TO").ErrorText = "入力値に誤りがあります！"
					Return
				End If
				If Not IsNothing(dateTime) AndAlso (DateTime.Compare(dateTime, DateAndTime.Now.AddYears(-200)) < 0 Or DateTime.Compare(dateTime, DateAndTime.Now.AddYears(200)) > 0) Then
					dataGridViewRow.Cells("YUKO_FM").ErrorText = "入力値に誤りがあります！"
					flag = True
				End If
				If DateTime.Compare(dateTime2, DateAndTime.Now.AddYears(-200)) < 0 Or DateTime.Compare(dateTime2, DateAndTime.Now.AddYears(200)) > 0 Then
					dataGridViewRow.Cells("YUKO_TO").ErrorText = "入力値に誤りがあります！"
					flag = True
				End If
				If flag Then
					Return
				End If
				If IsNothing(dateTime) Then
					Return
				End If
				If DateTime.Compare(dateTime, dateTime2) > 0 Then
					dataGridViewRow.Cells("YUKO_FM").ErrorText = "有効日の大小関係が不正です！"
					dataGridViewRow.Cells("YUKO_TO").ErrorText = "有効日の大小関係が不正です！"
				End If
			End If
IL_73D:
			dataGridViewRow = Nothing
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

		<AccessedThroughProperty("RTNM_ReferButton")>
		Private WithEvents RTNM_ReferButton As Button

		<AccessedThroughProperty("BuhinLabel")>
		Private WithEvents BuhinLabel As Label

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("NounyuLabel")>
		Private WithEvents NounyuLabel As Label

		<AccessedThroughProperty("NounyuCodeTextBox")>
		Private WithEvents NounyuCodeTextBox As TextBox

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("BtnCancel")>
		Private WithEvents BtnCancel As Button

		<AccessedThroughProperty("lblTori")>
		Private WithEvents lblTori As Label

		<AccessedThroughProperty("CclBuhinCode1")>
		Private WithEvents CclBuhinCode1 As CclBuhinCode

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("CustDgv")>
		Private _CustDgv As CustomDataGridView

		<AccessedThroughProperty("CustomDataGridView1")>
		Private _CustomDataGridView1 As CustomDataGridView

		Private BASESQL As String

		Private Const YEARWIDTH As Integer = 200

		Private _conf As XmlConfigControl

		Private _execFlag As Boolean

		Private Sub RTNM_ReferButton_Click(sender As Object, e As EventArgs) Handles RTNM_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			If Not Me.chkInput() Then
				Return
			End If
			Me.RTNM_ReferButton.Enabled = False
			Me.ExecFlag = True
			Dim sql As String = Me.makeSql()
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.listOfKey.Add("YUKO_FM")
			Me._gridViewInfo.DisplayGridView(sql, 0)
			Me.RTNM_ReferButton.Enabled = True
		End Sub

		Private Sub AddRow_Button_Click(sender As Object, e As EventArgs) Handles AddRow_Button.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			If Not Me.chkInput() Then
				Return
			End If
			Dim obj As Object = Nothing
			Dim obj2 As Object = Nothing
			Dim value As String = Me.CclBuhinCode1.Value
			If Not String.IsNullOrEmpty(value) Then
				obj = Conversions.ToLong(value)
			End If
			Dim text As String = Me.NounyuCodeTextBox.Text.Trim()
			If Not String.IsNullOrEmpty(text) Then
				obj2 = text
			End If
			Me._gridViewInfo.RowAdd(New Dictionary(Of String, Object)() From {{"TORI_CD", Me.ComboTori1.Text.Trim()}, {"BUHIN_CD", RuntimeHelpers.GetObjectValue(obj)}, {"SAKI_CD", RuntimeHelpers.GetObjectValue(obj2)}}, False)

		End Sub

		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			If Not Me.chkInput() Then
				Return
			End If
			MyBase.RBM_ExecutButton_Click(RuntimeHelpers.GetObjectValue(sender), e)
			Dim undertext As String = MyBase.undertext
			If undertext <> Nothing Then
				Me.UcDgv.CustDgv_SendMessage(undertext)
			End If
		End Sub

		Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
			Cursor.Current = Cursors.WaitCursor
			Me.ExecFlag = False
			Me.CclBuhinCode1.Text = String.Empty
			Me.NounyuCodeTextBox.Text = String.Empty
			Me.UcDgv.CustDgv.Rows.Clear()
			Me.UcDgv.CustDgv.IsChanged = False
			Me.ComboTori1.SetItemList()
			Me.ComboTori1.Focus()
		End Sub
	End Class
End Namespace
