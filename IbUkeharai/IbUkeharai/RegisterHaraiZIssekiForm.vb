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
	Public Class RegisterHaraiZIssekiForm
		Inherits RegisterBaseForm

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.RegisterHaraiZIssekiForm_Load
			Me.BASESQL = "SELECT '' AS KUBUN, uke.TORI_CD, tori.TORI_NAME, uke.BUHIN_CD, bhn.BUHIN_NAME, bhn.TANA_NO1, bhn.TANA_NO2, bhn.TANA_NO3, uke.UKEHARA_YYYYMMDD, uke.DEN_NO, uke.SAKI_CD, uke.KINGAKU, uke.TESU, uke.KOSU, uke.REMARKS1, uke.REMARKS2, uke.REMARKS3 FROM Ukeharai.T_UKEHARAIMEISAI AS uke LEFT JOIN Ukeharai.M_TORI AS tori ON uke.TORI_CD = tori.TORI_CD LEFT JOIN Ukeharai.M_BUHIN AS bhn ON uke.TORI_CD = bhn.TORI_CD and uke.BUHIN_CD = bhn.BUHIN_CD "
			Me._sql = String.Empty
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
			Me.RHZ_ReferButton = New Button()
			Me.HaraidasiDayLabel = New Label()
			Me.BuhinLabel = New Label()
			Me.TorihikiLabel = New Label()
			Me.AddRow_Button = New Button()
			Me.CclBuhinCode1 = New DitCore.CclBuhinCode()
			Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
			Me.Label1 = New Label()
			Me.txtDenno = New TextBox()
			Me.UcCalendar1 = New IbUkeharai.Util.UcCalendar()
			Me.UcDgv = New IbUkeharai.UcDataGridView()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Size = New Size(1279, 45)
			Me.FormTitleLabel.Text = "払出実績登録"
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.BackColor = Color.Pink
			Me.RBM_BackButton.FlatStyle = FlatStyle.Popup
			Me.RBM_BackButton.Location = New Point(1181, 560)
			Me.RBM_BackButton.TabIndex = 8
			Me.RBM_BackButton.UseVisualStyleBackColor = False
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.BackColor = Color.Pink
			Me.RBM_ExecutButton.FlatStyle = FlatStyle.Popup
			Me.RBM_ExecutButton.Location = New Point(1095, 560)
			Me.RBM_ExecutButton.TabIndex = 7
			Me.RBM_ExecutButton.UseVisualStyleBackColor = False
			'
			'RHZ_ReferButton
			'
			Me.RHZ_ReferButton.BackColor = Color.Pink
			Me.RHZ_ReferButton.FlatStyle = FlatStyle.Popup
			Me.RHZ_ReferButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RHZ_ReferButton.Location = New Point(806, 55)
			Me.RHZ_ReferButton.Name = "RHZ_ReferButton"
			Me.RHZ_ReferButton.Size = New Size(80, 30)
			Me.RHZ_ReferButton.TabIndex = 4
			Me.RHZ_ReferButton.Text = "参照"
			Me.RHZ_ReferButton.UseVisualStyleBackColor = False
			'
			'HaraidasiDayLabel
			'
			Me.HaraidasiDayLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.HaraidasiDayLabel.Location = New Point(398, 61)
			Me.HaraidasiDayLabel.Name = "HaraidasiDayLabel"
			Me.HaraidasiDayLabel.Size = New Size(48, 18)
			Me.HaraidasiDayLabel.TabIndex = 14
			Me.HaraidasiDayLabel.Text = "払出日"
			'
			'BuhinLabel
			'
			Me.BuhinLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BuhinLabel.Location = New Point(203, 61)
			Me.BuhinLabel.Name = "BuhinLabel"
			Me.BuhinLabel.Size = New Size(35, 18)
			Me.BuhinLabel.TabIndex = 11
			Me.BuhinLabel.Text = "部品"
			'
			'TorihikiLabel
			'
			Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.TorihikiLabel.Location = New Point(15, 61)
			Me.TorihikiLabel.Name = "TorihikiLabel"
			Me.TorihikiLabel.Size = New Size(48, 18)
			Me.TorihikiLabel.TabIndex = 5
			Me.TorihikiLabel.Text = "取引先"
			'
			'AddRow_Button
			'
			Me.AddRow_Button.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
			Me.AddRow_Button.BackColor = Color.Pink
			Me.AddRow_Button.FlatStyle = FlatStyle.Popup
			Me.AddRow_Button.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.AddRow_Button.ForeColor = Color.Black
			Me.AddRow_Button.Location = New Point(18, 560)
			Me.AddRow_Button.Name = "AddRow_Button"
			Me.AddRow_Button.Size = New Size(80, 30)
			Me.AddRow_Button.TabIndex = 6
			Me.AddRow_Button.Text = "行追加"
			Me.AddRow_Button.UseVisualStyleBackColor = False
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
			Me.ComboTori1.Location = New Point(66, 58)
			Me.ComboTori1.MaxLength = 8
			Me.ComboTori1.Name = "ComboTori1"
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 0
			Me.ComboTori1.TableName = "M_TORI"
			'
			'Label1
			'
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.Location = New Point(620, 61)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(52, 18)
			Me.Label1.TabIndex = 16
			Me.Label1.Text = "伝票No"
			'
			'txtDenno
			'
			Me.txtDenno.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.txtDenno.ImeMode = ImeMode.Off
			Me.txtDenno.Location = New Point(678, 58)
			Me.txtDenno.MaxLength = 12
			Me.txtDenno.Name = "txtDenno"
			Me.txtDenno.Size = New Size(109, 19)
			Me.txtDenno.TabIndex = 3
			Me.txtDenno.Tag = ""
			'
			'UcCalendar1
			'
			Me.UcCalendar1.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.UcCalendar1.Location = New Point(453, 54)
			Me.UcCalendar1.Margin = New Padding(3, 4, 3, 4)
			Me.UcCalendar1.MyValue = Nothing
			Me.UcCalendar1.Name = "UcCalendar1"
			Me.UcCalendar1.Size = New Size(161, 33)
			Me.UcCalendar1.TabIndex = 2
			'
			'UcDgv
			'
			Me.UcDgv.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcDgv.Location = New Point(18, 97)
			Me.UcDgv.Name = "UcDgv"
			Me.UcDgv.Size = New Size(1243, 443)
			Me.UcDgv.TabIndex = 5
			'
			'RegisterHaraiZIssekiForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Pink
			Me.ClientSize = New Size(1279, 602)
			Me.Controls.Add(Me.UcDgv)
			Me.Controls.Add(Me.UcCalendar1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.txtDenno)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.CclBuhinCode1)
			Me.Controls.Add(Me.AddRow_Button)
			Me.Controls.Add(Me.RHZ_ReferButton)
			Me.Controls.Add(Me.HaraidasiDayLabel)
			Me.Controls.Add(Me.BuhinLabel)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.Name = "RegisterHaraiZIssekiForm"
			Me.Text = "払出実績登録画面"
			Me.TtileName = "払出実績登録"
			Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
			Me.Controls.SetChildIndex(Me.TorihikiLabel, 0)
			Me.Controls.SetChildIndex(Me.BuhinLabel, 0)
			Me.Controls.SetChildIndex(Me.HaraidasiDayLabel, 0)
			Me.Controls.SetChildIndex(Me.RHZ_ReferButton, 0)
			Me.Controls.SetChildIndex(Me.AddRow_Button, 0)
			Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
			Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
			Me.Controls.SetChildIndex(Me.CclBuhinCode1, 0)
			Me.Controls.SetChildIndex(Me.ComboTori1, 0)
			Me.Controls.SetChildIndex(Me.txtDenno, 0)
			Me.Controls.SetChildIndex(Me.Label1, 0)
			Me.Controls.SetChildIndex(Me.UcCalendar1, 0)
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

		Private Function makeSql() As String
			Dim text As String = Me.BASESQL
			Dim dictionary As New Dictionary(Of String, String)()
			Dim text2 As String = String.Empty
			text2 = "2"
			dictionary.Add("uke.UKEHARAI_KBN", "'" + text2 + "'")
			text2 = Me.ComboTori1.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("uke.TORI_CD", "'" + text2 + "%'")
			End If
			text2 = Me.CclBuhinCode1.Value
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("uke.BUHIN_CD", "'" + text2 + "%'")
			End If
			If Me.UcCalendar1.MyValue Is Nothing Then
				text2 = String.Empty
			ElseIf Me.UcCalendar1.IsChecked Then
				text2 = Conversions.ToDate(Me.UcCalendar1.MyValue).ToShortDateString()
			Else
				text2 = Conversions.ToDate(Me.UcCalendar1.MyValue).ToString("yyyy/MM/01")
			End If
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("uke.UKEHARA_YYYYMMDD", "'" + text2 + "'")
			End If
			text2 = Me.txtDenno.Text.Trim()
			If Not String.IsNullOrEmpty(text2) Then
				dictionary.Add("uke.DEN_NO", "'" + text2 + "%'")
			End If
			If dictionary.Count <= 0 Then
				Return text
			End If
			text += "WHERE "
			Try
				For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
					If keyValuePair.Value.IndexOf("%") >= 0 Then
						text = String.Concat(New String() {text, keyValuePair.Key, " LIKE ", keyValuePair.Value, " AND "})
					ElseIf "uke.UKEHARA_YYYYMMDD".Equals(keyValuePair.Key) Then
						If Me.UcCalendar1.IsChecked Then
							text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " AND "})
						Else
							text = String.Concat(New String() {text, keyValuePair.Key, " BETWEEN ", keyValuePair.Value, " AND EOMONTH(", keyValuePair.Value, ")  AND "})
						End If
					Else
						text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " AND "})
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text += "1=1"
			text += " ORDER BY uke.TORI_CD, uke.BUHIN_CD, uke.UKEHARA_YYYYMMDD, uke.DEN_NO"
			Return text
		End Function

		Private Function getToriMaster(sToriCd As String) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim text As String = "SELECT TORI_CD, TORI_NAME, SEIKYU_TYPE, RITU, HASU_KBN FROM Ukeharai.M_TORI WHERE TORI_CD ='" + sToriCd + "'"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					If sqlDataBase.DbData.DataList.Count = 1 Then
						result = sqlDataBase.DbData.DataList(0)
					End If
				Else
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
			End Using
			Return result
		End Function

		Private Function getBuhinMaster(sToriCd As String, sBuhinCd As String) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim text As String = String.Concat(New String() {"SELECT BUHIN_CD, BUHIN_NAME, TANA_NO1, TANA_NO2, TANA_NO3 FROM Ukeharai.M_BUHIN WHERE TORI_CD ='", sToriCd, "' AND BUHIN_CD = '", sBuhinCd, "'"})
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					If sqlDataBase.DbData.DataList.Count = 1 Then
						result = sqlDataBase.DbData.DataList(0)
					End If
				Else
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
			End Using
			Return result
		End Function

		Private Function getTankaMaster(sToriCd As String, sBuhinCd As String, sSakiCd As String, sHiduke As String) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim text As String = String.Concat(New String() {"SELECT TORI_CD, BUHIN_CD, SAKI_CD, YUKO_FM, YUKO_TO, SAGYO FROM Ukeharai.M_TANKA WHERE TORI_CD ='", sToriCd, "' AND BUHIN_CD = '", sBuhinCd, "' AND SAKI_CD ='", sSakiCd, "' AND ( ( YUKO_FM <= '", sHiduke, "' OR YUKO_FM IS NULL ) AND YUKO_TO >= '", sHiduke, "' )"})
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text, False)
				If String.IsNullOrEmpty(sqldata) Then
					If sqlDataBase.DbData.DataList.Count = 1 Then
						result = sqlDataBase.DbData.DataList(0)
					End If
				Else
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
			End Using
			Return result
		End Function

		Private Function IsSakiCd(sSakiCd As String) As Boolean
			Dim result As Boolean = False
			Dim sSQL As String = "SELECT SAKI_CD FROM Ukeharai.M_SAKI WHERE SAKI_CD ='" + sSakiCd + "'"
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sSQL, False)
				If String.IsNullOrEmpty(sqldata) AndAlso sqlDataBase.DbData.DataList.Count = 1 Then
					result = True
				End If
			End Using
			Return result
		End Function

		Private Function setTesu(row As DataGridViewRow) As Boolean
			row.Cells("TESU").Style.ForeColor = Color.Black
			Dim dictionary As New Dictionary(Of String, Object)()
			Dim text As String = Conversions.ToString(row.Cells("TORI_CD").Value)
			Dim text2 As String = Common.BuhinObjToString(RuntimeHelpers.GetObjectValue(row.Cells("BUHIN_CD").Value))
			Dim text3 As String = Conversions.ToString(row.Cells("SAKI_CD").Value)
			Dim text4 As String = Conversions.ToString(row.Cells("UKEHARA_YYYYMMDD").Value)
			If String.IsNullOrEmpty(text) Or String.IsNullOrEmpty(text2) Or String.IsNullOrEmpty(text3) Or String.IsNullOrEmpty(text4) Then
				Return True
			End If
			dictionary = Me.getToriMaster(text)
			If dictionary Is Nothing Then
				Return False
			End If
			If dictionary.Count <= 0 Then
				Return False
			End If
			If Not "1".Equals(RuntimeHelpers.GetObjectValue(dictionary("SEIKYU_TYPE"))) Then
				If "2".Equals(RuntimeHelpers.GetObjectValue(dictionary("SEIKYU_TYPE"))) Then
					row.Cells("TESU").Value = Nothing
				End If
				Return True
			End If
			dictionary.Clear()
			dictionary = Me.getTankaMaster(text, text2, text3, text4)
			If dictionary Is Nothing Then
				Return False
			End If
			If dictionary.Count > 0 Then
				row.Cells("TESU").Value = RuntimeHelpers.GetObjectValue(dictionary("SAGYO"))
				row.Cells("TESU").Style.BackColor = Color.PeachPuff
				Return True
			End If
			If String.IsNullOrEmpty(Conversions.ToString(row.Cells("TESU").Value)) Then
				row.Cells("TESU").Value = "0.00"
			End If
			row.Cells("TESU").Style.ForeColor = Color.DarkRed
			DlgMessageBox.Show("単価マスタが存在しません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Return False
		End Function

		Private Sub chkInput()
			Try
				For Each obj As Object In CType(Me.UcDgv.CustDgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim dataGridViewCell As DataGridViewCell = dataGridViewRow.Cells("KOSU")
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)
					If Not String.IsNullOrEmpty(Conversions.ToString(objectValue)) Then
						If Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(objectValue)) = 0L Then
							dataGridViewCell.ErrorText = "入力値に誤りがあります！"
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub RegisterHaraiZIssekiForm_Load(sender As Object, e As EventArgs)
			If TopForm.ConfigData Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.UcCalendar1.MyValue = DateAndTime.Now.[Date]
			Me.UcCalendar1.MyValue = String.Empty
			Me.ComboTori1.SetItemList()
			Me._conf = TopForm.ConfigData
			Me._sql = Me.BASESQL + "WHERE 0=1"
			Dim ucDgv As UcDataGridView = Me.UcDgv
			Dim custDgv As CustomDataGridView = ucDgv.CustDgv
			Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
			ucDgv.CustDgv = custDgv
			Me._gridViewInfo = gridViewInfo
			Me._gridViewInfo.listOfKey.Add("SAKI_CD")
			Me._gridViewInfo.listOfKey.Add("KOSU")
			Me._gridViewInfo.DisplayGridView(Me._sql, 0)
		End Sub

		Private Sub UcDgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles UcDgv.DgvCellEndEdit
			Dim customDataGridView As CustomDataGridView = CType(sender, CustomDataGridView)
			Dim dataGridViewColumn As DataGridViewColumn = customDataGridView.Columns(e.ColumnIndex)
			If Common.compareObjToObj(RuntimeHelpers.GetObjectValue(customDataGridView.CellValuePre), RuntimeHelpers.GetObjectValue(customDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
				Return
			End If
			Dim dictionary As New Dictionary(Of String, Object)()
			Dim text As String = String.Empty
			Dim text2 As String = String.Empty
			Dim dataGridViewRow As DataGridViewRow = customDataGridView.Rows(e.RowIndex)
			If "TORI_CD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("TORI_CD").ErrorText = Nothing
				dataGridViewRow.Cells("TORI_NAME").Value = Nothing
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					dataGridViewRow.Cells("TORI_CD").ErrorText = "必須項目です。"
					Return
				End If
				text = dataGridViewRow.Cells(e.ColumnIndex).Value.ToString().Trim()
				dictionary = Me.getToriMaster(text)
				If dictionary Is Nothing Then
					Return
				End If
				If dictionary.Count > 0 Then
					dataGridViewRow.Cells("TORI_NAME").Value = RuntimeHelpers.GetObjectValue(dictionary("TORI_NAME"))
					dataGridViewRow.Cells("TORI_CD").ErrorText = String.Empty
				Else
					dataGridViewRow.Cells("TORI_CD").ErrorText = "入力値に誤りがあります！"
					DlgMessageBox.Show(String.Format("取引先コードが存在しません。[{0}]", text), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
				dataGridViewRow.Cells("BUHIN_CD").ErrorText = Nothing
				dataGridViewRow.Cells("BUHIN_NAME").Value = Nothing
				dataGridViewRow.Cells("TANA_NO1").Value = Nothing
				dataGridViewRow.Cells("TANA_NO2").Value = Nothing
				dataGridViewRow.Cells("TANA_NO3").Value = Nothing
				text2 = Common.BuhinObjToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("BUHIN_CD").Value))
				dictionary = Me.getBuhinMaster(text, text2)
				If dictionary Is Nothing Then
					Return
				End If
				If dictionary.Count > 0 Then
					dataGridViewRow.Cells("TANA_NO1").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO1"))
					dataGridViewRow.Cells("TANA_NO2").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO2"))
					dataGridViewRow.Cells("TANA_NO3").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO3"))
					dataGridViewRow.Cells("BUHIN_NAME").Value = RuntimeHelpers.GetObjectValue(dictionary("BUHIN_NAME"))
					Me.setTesu(customDataGridView.Rows(e.RowIndex))
				End If
			ElseIf "BUHIN_CD".Equals(dataGridViewColumn.Name) Then
				text2 = Common.BuhinObjToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(e.ColumnIndex).Value))
				If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("TORI_CD").Value)) Then
					dataGridViewRow.Cells("BUHIN_CD").ErrorText = "入力値に誤りがあります！"
					Return
				End If
				dataGridViewRow.Cells("BUHIN_CD").ErrorText = Nothing
				dataGridViewRow.Cells("BUHIN_NAME").Value = Nothing
				dataGridViewRow.Cells("TANA_NO1").Value = Nothing
				dataGridViewRow.Cells("TANA_NO2").Value = Nothing
				dataGridViewRow.Cells("TANA_NO3").Value = Nothing
				If String.IsNullOrEmpty(text2) Then
					dataGridViewRow.Cells("BUHIN_CD").ErrorText = "必須項目です。"
					Return
				End If
				text = dataGridViewRow.Cells("TORI_CD").Value.ToString().Trim()
				dictionary = Me.getBuhinMaster(text, text2)
				If dictionary Is Nothing Then
					Return
				End If
				If dictionary.Count <= 0 Then
					dataGridViewRow.Cells("BUHIN_CD").ErrorText = "入力値に誤りがあります！"
					DlgMessageBox.Show(String.Format("取引先に対する部品が存在しません。[{0}]", text2), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return
				End If
				dataGridViewRow.Cells("TANA_NO1").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO1"))
				dataGridViewRow.Cells("TANA_NO2").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO2"))
				dataGridViewRow.Cells("TANA_NO3").Value = RuntimeHelpers.GetObjectValue(dictionary("TANA_NO3"))
				dataGridViewRow.Cells("BUHIN_NAME").Value = RuntimeHelpers.GetObjectValue(dictionary("BUHIN_NAME"))
				Me.setTesu(customDataGridView.Rows(e.RowIndex))
			ElseIf "SAKI_CD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("SAKI_CD").ErrorText = Nothing
				If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells(e.ColumnIndex).Value)) Then
					dataGridViewRow.Cells("SAKI_CD").ErrorText = "必須項目です。"
					Return
				End If
				Dim sSakiCd As String = dataGridViewRow.Cells(e.ColumnIndex).Value.ToString().Trim()
				If Me.IsSakiCd(sSakiCd) Then
					Me.setTesu(customDataGridView.Rows(e.RowIndex))
				Else
					dataGridViewRow.Cells("SAKI_CD").ErrorText = "入力値に誤りがあります！"
				End If
			ElseIf "TESU".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("TESU").ErrorText = Nothing
				If Conversions.ToDouble(dataGridViewRow.Cells("TESU").Value) > 9999999.99 Then
					dataGridViewRow.Cells("TESU").Value = 9999999.99
				ElseIf String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("TESU").Value)) Then
					dataGridViewRow.Cells("TESU").Value = 0.0
				End If
			ElseIf "DEN_NO".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("DEN_NO").ErrorText = Nothing
				If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells("DEN_NO").Value)) Then
					dataGridViewRow.Cells("DEN_NO").ErrorText = "必須項目です。"
					Return
				End If
			ElseIf "KOSU".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("KOSU").ErrorText = Nothing
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KOSU").Value)
				If String.IsNullOrEmpty(Conversions.ToString(objectValue)) Then
					dataGridViewRow.Cells("KOSU").ErrorText = "必須項目です。"
					Return
				End If
				If Common.cnvObjToLong(RuntimeHelpers.GetObjectValue(objectValue)) = 0L Then
					dataGridViewRow.Cells("KOSU").ErrorText = "入力値に誤りがあります！"
					Return
				End If
			ElseIf "UKEHARA_YYYYMMDD".Equals(dataGridViewColumn.Name) Then
				dataGridViewRow.Cells("UKEHARA_YYYYMMDD").ErrorText = Nothing
				Dim t As DateTime = Nothing
				If Not DateTime.TryParse(Conversions.ToString(dataGridViewRow.Cells("UKEHARA_YYYYMMDD").Value), t) Then
					dataGridViewRow.Cells("UKEHARA_YYYYMMDD").ErrorText = "入力値に誤りがあります！"
					Return
				End If
				If DateTime.Compare(t, DateAndTime.Now.AddYears(-50)) < 0 Or DateTime.Compare(t, DateAndTime.Now.AddYears(50)) > 0 Then
					dataGridViewRow.Cells("UKEHARA_YYYYMMDD").ErrorText = "入力値に誤りがあります！"
					Return
				End If
				Me.setTesu(customDataGridView.Rows(e.RowIndex))
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("RHZ_ReferButton")>
		Private WithEvents RHZ_ReferButton As Button

		<AccessedThroughProperty("HaraidasiDayLabel")>
		Private WithEvents HaraidasiDayLabel As Label

		<AccessedThroughProperty("BuhinLabel")>
		Private WithEvents BuhinLabel As Label

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("AddRow_Button")>
		Private WithEvents AddRow_Button As Button

		<AccessedThroughProperty("CclBuhinCode1")>
		Private WithEvents CclBuhinCode1 As CclBuhinCode

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("txtDenno")>
		Private WithEvents txtDenno As TextBox

		<AccessedThroughProperty("UcCalendar1")>
		Private WithEvents UcCalendar1 As UcCalendar

		<AccessedThroughProperty("UcDgv")>
		Private WithEvents UcDgv As UcDataGridView

		<AccessedThroughProperty("CustomDataGridView1")>
		Private _CustomDataGridView1 As CustomDataGridView

		Private BASESQL As String

		Private Const YEARWIDTH As Integer = 50

		Private _sql As String

		Private _conf As XmlConfigControl

		Private Sub RHZ_ReferButton_Click(sender As Object, e As EventArgs) Handles RHZ_ReferButton.Click
			If Me._conf Is Nothing Then
				Return
			End If
			Me.RHZ_ReferButton.Enabled = False
			Cursor.Current = Cursors.WaitCursor
			Try
				Me._sql = Me.makeSql()
				Dim ucDgv As UcDataGridView = Me.UcDgv
				Dim custDgv As CustomDataGridView = ucDgv.CustDgv
				Dim gridViewInfo As New ControlDataGridView(custDgv, Me._conf)
				ucDgv.CustDgv = custDgv
				Me._gridViewInfo = gridViewInfo
				Me._gridViewInfo.listOfKey.Add("SAKI_CD")
				Me._gridViewInfo.listOfKey.Add("KOSU")
				Me._gridViewInfo.DisplayGridView(Me._sql, 0)
			Catch ex As Exception
				OutputLog.WriteLine(Me.Name + ":RHZ_ReferButton_Click:" + ex.Message)
			Finally
				Me.RHZ_ReferButton.Enabled = True
			End Try
		End Sub

		Private Sub AddRow_Button_Click(sender As Object, e As EventArgs) Handles AddRow_Button.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			Me._gridViewInfo.RowAdd(New Dictionary(Of String, Object)() From {{"UKEHARAI_KBN", "2"}}, False)
		End Sub

		Protected Overrides Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs)
			Me.chkInput()
			MyBase.RBM_ExecutButton_Click(RuntimeHelpers.GetObjectValue(sender), e)
			Dim undertext As String = MyBase.undertext
			If undertext <> Nothing Then
				Me.UcDgv.CustDgv_SendMessage(undertext)
			End If
		End Sub
	End Class
End Namespace
