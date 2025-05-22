Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class RegisterNounyuMasterForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterNounyuMasterForm_Load
			Me.BASESQL = "SELECT '' AS KUBUN, SAKI_CD, SAKI_NAME, SAKI_ABBREVIATION FROM Ukeharai.M_SAKI "
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
			Me.NounyuLabel = New Label()
			Me.NounyuCodeTextBox = New TextBox()
			Me.RNM_ReferButton = New Button()
			Me.AddRow_Button = New Button()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Size = New Size(780, 45)
			Me.FormTitleLabel.Text = "納入先マスター登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.Location = New Point(688, 549)
			Me.RBM_BackButton.TabIndex = 5
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.Location = New Point(602, 549)
			Me.RBM_ExecutButton.TabIndex = 4
			'
			'NounyuLabel
			'
			Me.NounyuLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NounyuLabel.Location = New Point(15, 60)
			Me.NounyuLabel.Name = "NounyuLabel"
			Me.NounyuLabel.Size = New Size(48, 18)
			Me.NounyuLabel.TabIndex = 30
			Me.NounyuLabel.Text = "納入先"
			'
			'NounyuCodeTextBox
			'
			Me.NounyuCodeTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.NounyuCodeTextBox.ImeMode = ImeMode.Disable
			Me.NounyuCodeTextBox.Location = New Point(69, 57)
			Me.NounyuCodeTextBox.MaxLength = 2
			Me.NounyuCodeTextBox.Name = "NounyuCodeTextBox"
			Me.NounyuCodeTextBox.Size = New Size(25, 19)
			Me.NounyuCodeTextBox.TabIndex = 0
			'
			'RNM_ReferButton
			'
			Me.RNM_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RNM_ReferButton.Location = New Point(143, 54)
			Me.RNM_ReferButton.Name = "RNM_ReferButton"
			Me.RNM_ReferButton.Size = New Size(80, 30)
			Me.RNM_ReferButton.TabIndex = 1
			Me.RNM_ReferButton.Text = "参照"
			Me.RNM_ReferButton.UseVisualStyleBackColor = True
			'
			'AddRow_Button
			'
			Me.AddRow_Button.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
			Me.AddRow_Button.BackColor = Color.DodgerBlue
			Me.AddRow_Button.FlatStyle = FlatStyle.Popup
			Me.AddRow_Button.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.AddRow_Button.ForeColor = Color.White
			Me.AddRow_Button.Location = New Point(12, 549)
			Me.AddRow_Button.Name = "AddRow_Button"
			Me.AddRow_Button.Size = New Size(80, 30)
			Me.AddRow_Button.TabIndex = 3
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Location = New Point(12, 90)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(756, 443)
			Me.UcDgv.TabIndex = 2
			'
			'RegisterNounyuMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(780, 591)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.NounyuLabel)
			Me.Controls.Add(Me.NounyuCodeTextBox)
			Me.Controls.Add(Me.RNM_ReferButton)
			Me.Name = "RegisterNounyuMasterForm"
			Me.Text = "納入先マスター登録画面"
			Me.TtileName = "納入先マスター登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.RNM_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.NounyuCodeTextBox, 0)
			Me.Controls.SetChildIndex(Me.NounyuLabel, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.UcDgv, 0)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.NounyuCodeTextBox.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("SAKI_CD", "'" + text2 + "%'")
			End If
			If dictionary.Count <= 0 Then
				Return text
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					text = String.Concat(New String() {text, keyValuePair.Key, " LIKE ", keyValuePair.Value, " AND "})
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1"
			Return text
		End Function

		Private Sub RegisterNounyuMasterForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me._conf = TopForm.ConfigData
			Dim sql As String = Me.BASESQL + "where 0=1"
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.DisplayGridView(sql, 0)
		End Sub

		Private Sub UcDataGridView1_DgvCellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			If Common.compareObjToObj(RuntimeHelpers.GetObjectValue(customDataGridView.CellValuePre), RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
				Return
			End If
			If "SAKI_CD".Equals(dataGridViewColumn.Name) Then
				customDataGridView.Rows(e.RowIndex).Cells("SAKI_CD").ErrorText = Nothing
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
					customDataGridView.Rows(e.RowIndex).Cells("SAKI_CD").ErrorText = "必須項目です。"
					Return
				End If
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("NounyuLabel")>
		Private WithEvents NounyuLabel As Label

		<AccessedThroughProperty("NounyuCodeTextBox")>
		Private WithEvents NounyuCodeTextBox As TextBox

		<AccessedThroughProperty("RNM_ReferButton")>
		Private WithEvents RNM_ReferButton As Button

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		Private BASESQL As String

		Private _conf As XmlConfigControl
		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			MyBase.RBM_ExecutButton_Click(RuntimeHelpers.GetObjectValue(sender), e)
			Dim undertext As String = MyBase.undertext
			If undertext <> Nothing Then
				Me.UcDgv.CustDgv_SendMessage(undertext)
			End If
		End Sub
		Private Sub RNM_ReferButton_Click(sender As Object, e As EventArgs) Handles RNM_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			Me.RNM_ReferButton.Enabled = False
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
				OutputLog.WriteLine(Me.Name + ":RNM_ReferButton_Click:" + ex.Message)
			Finally
				Me.RNM_ReferButton.Enabled = True
			End Try
		End Sub

		Private Sub AddRow_Button_Click(sender As Object, e As EventArgs) Handles AddRow_Button.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			Me._gridViewInfo.RowAdd(Nothing, False)
		End Sub

		Private Sub RBM_BackButton_Click_1(sender As Object, e As EventArgs) Handles RBM_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
