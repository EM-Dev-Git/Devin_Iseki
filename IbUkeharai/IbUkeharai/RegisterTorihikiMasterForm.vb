Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class RegisterTorihikiMasterForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterTorihikiMasterForm_Load
			Me.BASESQL = "SELECT '' AS KUBUN, TORI_CD, TORI_NAME, SEIKYU_TYPE, RITU, HASU_KBN FROM Ukeharai.M_TORI "
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
			Me.TorihikiLabel = New Label()
			Me.RTM_ReferButton = New Button()
			Me.AddRow_Button = New Button()
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.Label1 = New Label()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Text = "取引先マスター登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.TabIndex = 5
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.TabIndex = 4
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(15, 58)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(48, 18)
			Me.TorihikiLabel.TabIndex = 2
			Me.TorihikiLabel.Text = "取引先"
			'
			'RTM_ReferButton
			'
			Me.RTM_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RTM_ReferButton.Location = New Point(199, 52)
			Me.RTM_ReferButton.Name = "RTM_ReferButton"
			Me.RTM_ReferButton.Size = New Size(80, 30)
			Me.RTM_ReferButton.TabIndex = 1
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
			Me.AddRow_Button.TabIndex = 3
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
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
			Me.ComboTori1.Location = New Point(69, 55)
			Me.ComboTori1.MaxLength = 8
			Me.ComboTori1.Name = "ComboTori1"
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 0
			Me.ComboTori1.TableName = "M_TORI"
			'
			'Label1
			'
			Me.Label1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.ForeColor = Color.Green
			Me.Label1.Location = New Point(485, 560)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(286, 39)
			Me.Label1.TabIndex = 42
			Me.Label1.Text = "請求形態：個数＝１、％(手数料が必要)＝２" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "端数区分：1:四捨五入、2:切り捨て、3:切り上げ"
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Location = New Point(18, 90)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(919, 464)
			Me.UcDgv.TabIndex = 2
			'
			'RegisterTorihikiMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(955, 602)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.RTM_ReferButton)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.Name = "RegisterTorihikiMasterForm"
			Me.Text = "取引先マスター画面"
			Me.TtileName = "取引先マスター登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.TorihikiLabel, 0)
			Me.Controls.SetChildIndex(Me.RTM_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.ComboTori1, 0)
			Me.Controls.SetChildIndex(Me.Label1, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.UcDgv, 0)
			Me.ResumeLayout(False)

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

		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("TORI_CD", "'" + text2 + "%'")
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

		Private Sub RegisterTorihikiMasterForm_Load(sender As Object, e As EventArgs)
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

		Private Sub UcDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			Dim dataGridViewRow As DataGridViewRow = customDataGridView.Rows(e.RowIndex)
			If Operators.ConditionalCompareObjectEqual(customDataGridView.CellValuePre, dataGridViewRow.Cells(e.ColumnIndex).Value, False) Then
				Return
			End If
			If "TORI_CD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("TORI_CD").ErrorText = Nothing
				If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					dataGridViewRow.Cells("TORI_CD").ErrorText = "必須項目です。"
					Return
				End If
			ElseIf "SEIKYU_TYPE".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("SEIKYU_TYPE").ErrorText = Nothing
				dataGridViewRow.Cells("RITU").ErrorText = Nothing
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value)
				If "1".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
					dataGridViewRow.Cells("RITU").Value = 0D
					dataGridViewRow.Cells("RITU").[ReadOnly] = True
				Else
					If Not "2".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
						dataGridViewRow.Cells("SEIKYU_TYPE").ErrorText = "入力値に誤りがあります！"
						Return
					End If
					dataGridViewRow.Cells("RITU").[ReadOnly] = False
					If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("RITU").Value)) Then
						dataGridViewRow.Cells("RITU").Value = 0D
					End If
				End If
			ElseIf "RITU".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("RITU").ErrorText = Nothing
				If Conversions.ToDouble(dataGridViewRow.Cells("RITU").Value) > 100.0 Then
					dataGridViewRow.Cells("RITU").Value = 100
				End If
				If "1".Equals(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("SEIKYU_TYPE").Value)) Then
					If Not Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells("RITU").Value, 0D, False) Then
						dataGridViewRow.Cells("RITU").ErrorText = "入力値に誤りがあります！"
						Return
					End If
				End If
			ElseIf "HASU_KBN".Equals(dataGridViewColumn.Name) Then
				Dim left As String = Conversions.ToString(dataGridViewRow.Cells("HASU_KBN").Value)
				dataGridViewRow.Cells("HASU_KBN").ErrorText = Nothing
				If Operators.CompareString(left, "1", False) <> 0 Then
					If Operators.CompareString(left, "2", False) <> 0 Then
						If Operators.CompareString(left, "3", False) <> 0 Then
							dataGridViewRow.Cells("HASU_KBN").ErrorText = "入力値に誤りがあります！"
							Return
						End If
					End If
				End If
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("RTM_ReferButton")>
		Private WithEvents RTM_ReferButton As Button

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("CustomDataGridView1")>
		Private _CustomDataGridView1 As CustomDataGridView

		Private BASESQL As String

		Private _conf As XmlConfigControl
		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			MyBase.RBM_ExecutButton_Click(RuntimeHelpers.GetObjectValue(sender), e)
			Dim undertext As String = MyBase.undertext
			If undertext <> Nothing Then
				Me.UcDgv.CustDgv_SendMessage(undertext)
			End If
		End Sub
		Private Sub RTM_ReferButton_Click(sender As Object, e As EventArgs) Handles RTM_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.RTM_ReferButton.Enabled = False
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
			Dim dictionary As New Dictionary(Of String, Object)()
			dictionary("SEIKYU_TYPE") = "1"
			dictionary("RITU") = 0D
			dictionary("HASU_KBN") = "1"
			Me._gridViewInfo.RowAdd(dictionary, False)
		End Sub
	End Class
End Namespace
