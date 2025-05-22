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
	Public Class RegisterBuhinMasterForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterBuhinMasterForm_Load
			Me.BASESQL = "SELECT '' AS KUBUN, buhin.TORI_CD, tori.TORI_NAME, tori.SEIKYU_TYPE, TNK.SAKI_CD, TNK.SAGYO, buhin.BUHIN_CD, buhin.BUHIN_NAME, buhin.TANA_NO1, buhin.TANA_NO2, buhin.TANA_NO3, buhin.TORIHIN_NO, buhin.KIKAKU, buhin.IKISAKI_CD, buhin.TEBAN FROM Ukeharai.M_BUHIN AS buhin LEFT JOIN Ukeharai.M_TORI AS tori ON buhin.TORI_CD=tori.TORI_CD LEFT JOIN Ukeharai.M_TANKA AS TNK ON TNK.TORI_CD=buhin.TORI_CD AND TNK.BUHIN_CD=buhin.BUHIN_CD "
			Me._conf = Nothing
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
			Me.BuhinLabel = New Label()
			Me.TorihikiLabel = New Label()
			Me.RTM_ReferButton = New Button()
			Me.AddRow_Button = New Button()
			Me.CclBuhinCode1 = New DitCore.CclBuhinCode()
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Size = New Size(1213, 45)
			Me.FormTitleLabel.Text = "部品マスター登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.Location = New Point(1121, 560)
			Me.RBM_BackButton.TabIndex = 6
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.Location = New Point(1035, 560)
			Me.RBM_ExecutButton.TabIndex = 5
			'
			'BuhinLabel
			'
			Me.BuhinLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BuhinLabel.Location = New Point(203, 58)
			Me.BuhinLabel.Name = "BuhinLabel"
			Me.BuhinLabel.Size = New Size(35, 18)
			Me.BuhinLabel.TabIndex = 18
			Me.BuhinLabel.Text = "部品"
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(15, 58)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(48, 18)
			Me.TorihikiLabel.TabIndex = 50
			Me.TorihikiLabel.Text = "取引先"
			'
			'RTM_ReferButton
			'
			Me.RTM_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RTM_ReferButton.Location = New Point(422, 52)
			Me.RTM_ReferButton.Name = "RTM_ReferButton"
			Me.RTM_ReferButton.Size = New Size(80, 30)
			Me.RTM_ReferButton.TabIndex = 2
			Me.RTM_ReferButton.Text = "参照"
			Me.RTM_ReferButton.UseVisualStyleBackColor = True
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
			Me.AddRow_Button.TabIndex = 4
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
			'
			'CclBuhinCode1
			'
			Me.CclBuhinCode1.Font = New Font("ＭＳ Ｐゴシック", 9.5!)
			Me.CclBuhinCode1.ImeMode = ImeMode.Disable
			Me.CclBuhinCode1.Location = New Point(237, 54)
			Me.CclBuhinCode1.Mask = "aaaa-aaa-aaa-aa"
			Me.CclBuhinCode1.Name = "CclBuhinCode1"
			Me.CclBuhinCode1.Size = New Size(141, 20)
			Me.CclBuhinCode1.TabIndex = 1
			'
			'ComboTori1
			'
			Me.ComboTori1.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.ComboTori1.AutoCompleteSource = AutoCompleteSource.ListItems
			Me.ComboTori1.BackColor = SystemColors.Window
			Me.ComboTori1.ColumnCode = "TORI_CD"
			Me.ComboTori1.ColumnName = "TORI_NAME"
			Me.ComboTori1.FlatStyle = FlatStyle.Popup
			Me.ComboTori1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ComboTori1.FormattingEnabled = True
			Me.ComboTori1.ImeMode = ImeMode.Disable
			Me.ComboTori1.Location = New Point(60, 55)
			Me.ComboTori1.MaxLength = 8
			Me.ComboTori1.Name = "ComboTori1"
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 0
			Me.ComboTori1.TableName = "M_TORI"
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.UcDgv.Location = New Point(18, 88)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(1183, 455)
			Me.UcDgv.TabIndex = 3
			'
			'RegisterBuhinMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(1213, 602)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.CclBuhinCode1)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.RTM_ReferButton)
			Me.Controls.Add(Me.BuhinLabel)
			Me.Controls.Add(Me.TorihikiLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.TtileName = "部品マスター登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.TorihikiLabel, 0)
			Me.Controls.SetChildIndex(Me.BuhinLabel, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.RTM_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.CclBuhinCode1, 0)
			Me.Controls.SetChildIndex(Me.ComboTori1, 0)
			Me.Controls.SetChildIndex(Me.UcDgv, 0)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("buhin.TORI_CD", "'" + text2 + "%'")
			End If
			text2 = Me.CclBuhinCode1.Value
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("buhin.BUHIN_CD", "'" + text2 + "%'")
			End If
			text2 = DateAndTime.Now.ToString("yyyy/MM/dd")
			dictionary.Add("TNK.YUKO_FM", "'" + text2 + "'")
			dictionary.Add("TNK.YUKO_TO", "'" + text2 + "'")
			If dictionary.Count <= 0 Then
				Return text
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					If "TNK.YUKO_FM".Equals(keyValuePair.Key) Then
						text = String.Concat(New String() {text, "( ", keyValuePair.Key, " <= ", keyValuePair.Value, " OR ", keyValuePair.Key, " IS NULL  ) AND "})
					ElseIf "TNK.YUKO_TO".Equals(keyValuePair.Key) Then
						text = String.Concat(New String() {text, "( ", keyValuePair.Key, " >= ", keyValuePair.Value, " OR ", keyValuePair.Key, " IS NULL  ) AND "})
					Else
						text = String.Concat(New String() {text, keyValuePair.Key, " LIKE ", keyValuePair.Value, " AND "})
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1"
			text += "ORDER BY buhin.TORI_CD, buhin.BUHIN_CD, TNK.SAKI_CD "
			Return text
		End Function

		Private Sub RegisterBuhinMasterForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me._conf = TopForm.ConfigData
			Me.ComboTori1.SetItemList()
			Dim sql As String = Me.BASESQL + "where 0=1"
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.DisplayGridView(sql, 0)
		End Sub

		Private Sub TorihikiCodeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTori1.KeyPress
			'e.Handled = FormOperation.IsInputNumber(e)
		End Sub

		Private Sub UcDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			If Common.compareObjToObj(RuntimeHelpers.GetObjectValue(customDataGridView.CellValuePre), RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
				Return
			End If
			If "TORI_CD".Equals(dataGridViewColumn.Name) Then
				customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = Nothing
				customDataGridView.Rows(e.RowIndex).Cells("TORI_NAME").Value = Nothing
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
					customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = "必須項目です。"
					Return
				End If
				Dim text As String = customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Trim()
				Dim text2 As String = "SELECT * FROM Ukeharai.M_TORI WHERE TORI_CD ='" + text + "'"
				Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
					Dim sqldata As String = sqlDataBase.getSQLData(text2, False)
					If String.IsNullOrEmpty(sqldata) Then
						Try
							If sqlDataBase.DbData.DataList.Count = 0 Then
								customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = "入力値に誤りがあります！"
								DlgMessageBox.Show(String.Format("取引先コードが存在しません。[{0}]", text), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								GoTo IL_342
							End If
							Dim dictionary As Dictionary(Of String, Object) = sqlDataBase.DbData.DataList(0)
							customDataGridView.Rows(e.RowIndex).Cells("TORI_NAME").Value = RuntimeHelpers.GetObjectValue(dictionary("TORI_NAME"))
							customDataGridView.Rows(e.RowIndex).Cells("SEIKYU_TYPE").Value = RuntimeHelpers.GetObjectValue(dictionary("SEIKYU_TYPE"))
							customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = Nothing
							GoTo IL_342
						Catch ex As Exception
							DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = "グリッド表示中にエラーが発生しました。"
							Return
						End Try
					End If
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text2 + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					customDataGridView.Rows(e.RowIndex).Cells("TORI_CD").ErrorText = "SQL実行中にエラーが発生しました。"
					Return
				End Using
			End If
IL_342:
			If "BUHIN_CD".Equals(dataGridViewColumn.Name) Then
				customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = Nothing
				Dim value As String = Common.BuhinObjToString(RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
				If String.IsNullOrEmpty(value) Then
					customDataGridView.Rows(e.RowIndex).Cells("BUHIN_CD").ErrorText = "必須項目です。"
					Return
				End If
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("BuhinLabel")>
		Private WithEvents BuhinLabel As Label

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("RTM_ReferButton")>
		Private WithEvents RTM_ReferButton As Button

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("CclBuhinCode1")>
		Private WithEvents CclBuhinCode1 As CclBuhinCode

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("CustomDataGridView1")>
		Private _CustomDataGridView1 As CustomDataGridView

		Private BASESQL As String

		Private _conf As XmlConfigControl

		Private Sub RTM_ReferButton_Click(sender As Object, e As EventArgs) Handles RTM_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			Me.RTM_ReferButton.Enabled = False
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim sql As String = Me.makeSql()
				Dim ucDgv As UcDataGridView = Me.UcDgv
				Dim custDgv As CustomDataGridView = ucDgv.CustDgv
				Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
				ucDgv.CustDgv = custDgv
				Me._gridViewInfo = gridViewInfo
				Me._gridViewInfo.DisplayGridView(sql, 0)
			Catch ex As Exception
				OutputLog.WriteLine(Me.Name + ":RTM_ReferButton_Click:" + ex.Message)
			Finally
				Me.RTM_ReferButton.Enabled = True
			End Try
		End Sub


		Private Sub AddRow_Button_Click(sender As Object, e As EventArgs) Handles AddRow_Button.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			Me._gridViewInfo.RowAdd(Nothing, False)
		End Sub
		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			MyBase.RBM_ExecutButton_Click(RuntimeHelpers.GetObjectValue(sender), e)
			Dim undertext As String = MyBase.undertext
			If undertext <> Nothing Then
				Me.UcDgv.CustDgv_SendMessage(undertext)
			End If
		End Sub

	End Class
End Namespace
