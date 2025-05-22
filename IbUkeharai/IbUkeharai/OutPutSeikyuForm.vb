Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.CateDataExec
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class OutPutSeikyuForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.OutPutSeikyuForm_Load
            Me.sSectionParam_Seikyu = "１．請求書"
            Me.sSectionParam_Utiwake = "２．内訳"
            Me.sSectionParam_Ryouhou = "３．両方"
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
            Me.SpecifiedDateLabel = New Label()
            Me.SelectDateTimePicker = New DateTimePicker()
            Me.OPS_ClearButton = New Button()
            Me.OPS_SelectAllButton = New Button()
            Me.OPS_BackButton = New Button()
            Me.OPS_ExecutButton = New Button()
            Me.SectionLabel = New Label()
            Me.cmbSection = New ComboBox()
            Me.rdbPreviewOff = New RadioButton()
            Me.rdbPreviewOn = New RadioButton()
            Me.gbxPreview = New GroupBox()
            Me.UcSelectGridView1 = New IbUkeharai.UcSelectGridView()
            Me.gbxPreview.SuspendLayout()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.FormTitleLabel.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(760, 45)
            Me.FormTitleLabel.TabIndex = 6
            Me.FormTitleLabel.Text = "請求書　出力"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'SpecifiedDateLabel
            '
            Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SpecifiedDateLabel.Location = New Point(229, 78)
            Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
            Me.SpecifiedDateLabel.Size = New Size(56, 18)
            Me.SpecifiedDateLabel.TabIndex = 45
            Me.SpecifiedDateLabel.Text = "指定年月"
            '
            'SelectDateTimePicker
            '
            Me.SelectDateTimePicker.CustomFormat = "yyyy年MM月"
            Me.SelectDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SelectDateTimePicker.Format = DateTimePickerFormat.Custom
            Me.SelectDateTimePicker.Location = New Point(303, 73)
            Me.SelectDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
            Me.SelectDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
            Me.SelectDateTimePicker.Name = "SelectDateTimePicker"
            Me.SelectDateTimePicker.Size = New Size(120, 19)
            Me.SelectDateTimePicker.TabIndex = 2
            '
            'OPS_ClearButton
            '
            Me.OPS_ClearButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.OPS_ClearButton.Location = New Point(114, 72)
            Me.OPS_ClearButton.Name = "OPS_ClearButton"
            Me.OPS_ClearButton.Size = New Size(80, 30)
            Me.OPS_ClearButton.TabIndex = 1
            Me.OPS_ClearButton.Text = "クリア"
            Me.OPS_ClearButton.UseVisualStyleBackColor = True
            '
            'OPS_SelectAllButton
            '
            Me.OPS_SelectAllButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.OPS_SelectAllButton.Location = New Point(18, 72)
            Me.OPS_SelectAllButton.Name = "OPS_SelectAllButton"
            Me.OPS_SelectAllButton.Size = New Size(80, 30)
            Me.OPS_SelectAllButton.TabIndex = 0
            Me.OPS_SelectAllButton.Text = "全選択"
            Me.OPS_SelectAllButton.UseVisualStyleBackColor = True
            '
            'OPS_BackButton
            '
            Me.OPS_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.OPS_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.OPS_BackButton.Location = New Point(687, 531)
            Me.OPS_BackButton.Name = "OPS_BackButton"
            Me.OPS_BackButton.Size = New Size(80, 30)
            Me.OPS_BackButton.TabIndex = 7
            Me.OPS_BackButton.Text = "戻る"
            Me.OPS_BackButton.UseVisualStyleBackColor = True
            '
            'OPS_ExecutButton
            '
            Me.OPS_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.OPS_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.OPS_ExecutButton.Location = New Point(592, 531)
            Me.OPS_ExecutButton.Name = "OPS_ExecutButton"
            Me.OPS_ExecutButton.Size = New Size(80, 30)
            Me.OPS_ExecutButton.TabIndex = 6
            Me.OPS_ExecutButton.Text = "実行"
            Me.OPS_ExecutButton.UseVisualStyleBackColor = True
            '
            'SectionLabel
            '
            Me.SectionLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SectionLabel.Location = New Point(464, 78)
            Me.SectionLabel.Name = "SectionLabel"
            Me.SectionLabel.Size = New Size(45, 18)
            Me.SectionLabel.TabIndex = 48
            Me.SectionLabel.Text = "分類"
            '
            'cmbSection
            '
            Me.cmbSection.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbSection.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.cmbSection.FormattingEnabled = True
            Me.cmbSection.Location = New Point(515, 72)
            Me.cmbSection.Name = "cmbSection"
            Me.cmbSection.Size = New Size(120, 20)
            Me.cmbSection.TabIndex = 3
            '
            'rdbPreviewOff
            '
            Me.rdbPreviewOff.AutoSize = True
            Me.rdbPreviewOff.Checked = True
            Me.rdbPreviewOff.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.rdbPreviewOff.Location = New Point(17, 14)
            Me.rdbPreviewOff.Name = "rdbPreviewOff"
            Me.rdbPreviewOff.Size = New Size(43, 16)
            Me.rdbPreviewOff.TabIndex = 0
            Me.rdbPreviewOff.TabStop = True
            Me.rdbPreviewOff.Text = "なし"
            Me.rdbPreviewOff.UseVisualStyleBackColor = True
            '
            'rdbPreviewOn
            '
            Me.rdbPreviewOn.AutoSize = True
            Me.rdbPreviewOn.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.rdbPreviewOn.Location = New Point(73, 14)
            Me.rdbPreviewOn.Name = "rdbPreviewOn"
            Me.rdbPreviewOn.Size = New Size(43, 16)
            Me.rdbPreviewOn.TabIndex = 1
            Me.rdbPreviewOn.Text = "あり"
            Me.rdbPreviewOn.UseVisualStyleBackColor = True
            '
            'gbxPreview
            '
            Me.gbxPreview.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles)
            Me.gbxPreview.Controls.Add(Me.rdbPreviewOff)
            Me.gbxPreview.Controls.Add(Me.rdbPreviewOn)
            Me.gbxPreview.FlatStyle = FlatStyle.Popup
            Me.gbxPreview.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.gbxPreview.Location = New Point(18, 528)
            Me.gbxPreview.Name = "gbxPreview"
            Me.gbxPreview.Size = New Size(146, 42)
            Me.gbxPreview.TabIndex = 5
            Me.gbxPreview.TabStop = False
            Me.gbxPreview.Text = "プレビュー"
            '
            'UcSelectGridView1
            '
            Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.UcSelectGridView1.Location = New Point(18, 108)
            Me.UcSelectGridView1.Name = "UcSelectGridView1"
            Me.UcSelectGridView1.Size = New Size(749, 417)
            Me.UcSelectGridView1.TabIndex = 4
            '
            'OutPutSeikyuForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(784, 573)
            Me.Controls.Add(Me.OPS_BackButton)
            Me.Controls.Add(Me.OPS_ExecutButton)
            Me.Controls.Add(Me.gbxPreview)
            Me.Controls.Add(Me.UcSelectGridView1)
            Me.Controls.Add(Me.cmbSection)
            Me.Controls.Add(Me.SectionLabel)
            Me.Controls.Add(Me.SpecifiedDateLabel)
            Me.Controls.Add(Me.SelectDateTimePicker)
            Me.Controls.Add(Me.OPS_ClearButton)
            Me.Controls.Add(Me.OPS_SelectAllButton)
            Me.Controls.Add(Me.FormTitleLabel)
            Me.Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Name = "OutPutSeikyuForm"
            Me.Text = "請求書出力画面"
            Me.gbxPreview.ResumeLayout(False)
            Me.gbxPreview.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub SetToriGridView()
            Dim gridColumn As New GridColumn()
            gridColumn.ReadOnlyFlag = True
            Me.UcSelectGridView1.CmpSgv.AutoGenerateColumns = False
            Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.UcSelectGridView1.CmpSgv.ColumnHeadersHeight = 28
            Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateCheckColumn("SelectCheckd", "選択", 50, False, ""))
            Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("Tori_Cd", "取引先コード", 180, True, ""))
            Me.UcSelectGridView1.CmpSgv.Columns.Add(gridColumn.CreateTextColumn("Tori_Name", "取引先名称", 500, True, ""))
        End Sub

        Private Sub SetToriGridViewData()
            Dim dbDataTable As DataTable
            Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
                Dim text As String = "SELECT TORI_CD, ISNULL(TORI_NAME,'') AS TORI_NAME FROM Ukeharai.M_TORI WHERE TORI_CD <> ''"
                Dim sqldata As String = sqlDataBase.getSQLData(text, True)
                If Not sqldata.Equals(String.Empty) Then
                    OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
                    DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return
                End If
                dbDataTable = sqlDataBase.DbDataTable
            End Using
            Try
                For Each obj As Object In dbDataTable.Rows
                    Dim dataRow As DataRow = CType(obj, DataRow)
                    Me.UcSelectGridView1.CmpSgv.Rows.Add(New Object() {False, RuntimeHelpers.GetObjectValue(dataRow("TORI_CD")), RuntimeHelpers.GetObjectValue(dataRow("TORI_NAME"))})
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub SetComboBox()
            Me.cmbSection.Items.Clear()
            Me.cmbSection.Items.Add(Me.sSectionParam_Seikyu)
            Me.cmbSection.Items.Add(Me.sSectionParam_Utiwake)
            Me.cmbSection.Items.Add(Me.sSectionParam_Ryouhou)
            Me.cmbSection.SelectedIndex = 0
        End Sub

        Private Sub changePreview()
            If Me.rdbPreviewOff.Checked Then
                Me.rdbPreviewOn.Checked = False
            Else
                Me.rdbPreviewOn.Checked = True
            End If
        End Sub

        Private Function getTergetTime() As DateTime
            Dim [date] As DateTime = Me.SelectDateTimePicker.Value.[Date]
            Dim result As New DateTime([date].Year, [date].Month, 1)
            Return result
        End Function

        Private Sub OutPutSeikyuForm_Load(sender As Object, e As EventArgs)
            Cursor.Current = Cursors.WaitCursor
            Me.SetComboBox()
            Me.SetToriGridView()
            Me.SetToriGridViewData()
            Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
            Me.SelectDateTimePicker.Value = Conversions.ToDate(DateAndTime.Now.AddMonths(-1).ToString("yyyy/MM/01"))
        End Sub

        Private Sub rdbPreviewOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPreviewOff.CheckedChanged
            Me.changePreview()
        End Sub

        Private Sub rdbPreviewOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPreviewOn.CheckedChanged
            Me.changePreview()
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("SpecifiedDateLabel")>
        Private WithEvents SpecifiedDateLabel As Label

        <AccessedThroughProperty("SelectDateTimePicker")>
        Private WithEvents SelectDateTimePicker As DateTimePicker

        <AccessedThroughProperty("OPS_ClearButton")>
        Private WithEvents OPS_ClearButton As Button

        <AccessedThroughProperty("OPS_SelectAllButton")>
        Private WithEvents OPS_SelectAllButton As Button

        <AccessedThroughProperty("OPS_BackButton")>
        Private WithEvents OPS_BackButton As Button

        <AccessedThroughProperty("OPS_ExecutButton")>
        Private WithEvents OPS_ExecutButton As Button

        <AccessedThroughProperty("SectionLabel")>
        Private WithEvents SectionLabel As Label

        <AccessedThroughProperty("cmbSection")>
        Private WithEvents cmbSection As ComboBox

        <AccessedThroughProperty("UcSelectGridView1")>
        Private WithEvents UcSelectGridView1 As UcSelectGridView

        <AccessedThroughProperty("rdbPreviewOff")>
        Private WithEvents rdbPreviewOff As RadioButton

        <AccessedThroughProperty("rdbPreviewOn")>
        Private WithEvents rdbPreviewOn As RadioButton

        <AccessedThroughProperty("gbxPreview")>
        Private WithEvents gbxPreview As GroupBox

        Private sSectionParam_Seikyu As String

        Private sSectionParam_Utiwake As String

        Private sSectionParam_Ryouhou As String

        Private Sub OPS_SelectAllButton_Click(sender As Object, e As EventArgs) Handles OPS_SelectAllButton.Click
            Try
                For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
                    Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                    dataGridViewRow.Cells("SelectCheckd").Value = True
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub OPS_ClearButton_Click(sender As Object, e As EventArgs) Handles OPS_ClearButton.Click
            Try
                For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
                    Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                    dataGridViewRow.Cells("SelectCheckd").Value = False
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub OPS_ExecutButton_Click(sender As Object, e As EventArgs) Handles OPS_ExecutButton.Click
            Me.OPS_ExecutButton.Enabled = False
            Cursor.Current = Cursors.WaitCursor
            Dim list As New List(Of String)()
            Try
                For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
                    Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                    If Conversions.ToBoolean(dataGridViewRow.Cells("SelectCheckd").Value) Then
                        list.Add(Conversions.ToString(dataGridViewRow.Cells("Tori_Cd").Value))
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            If list.Count = 0 Then
                DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.OPS_ExecutButton.Enabled = True
                Return
            End If
            If Me.UcSelectGridView1.CmpSgv.Rows.Count = list.Count Then
                list = Nothing
            End If
            Select Case Me.cmbSection.SelectedIndex
                Case 0
                    If Me.rdbPreviewOn.Checked Then
                        Dim outPutSeikyuFormReportViewSeikyu As New OutPutSeikyuFormReportViewSeikyu(Me.getTergetTime(), Me.cmbSection.SelectedIndex, list)
                        outPutSeikyuFormReportViewSeikyu.Show()
                    ElseIf MessageBox.Show(String.Format("{0}を印刷します。よろしいですか？", "請求書"), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Try
                            clsDirectPrintSeikyu.ExecPrint(Me.getTergetTime(), list)
                            DlgMessageBox.Show("印刷が完了しました。", "結果", MessageBoxButtons.OK)
                        Catch ex As Exception
                            DlgMessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End Try
                    End If
                Case 1
                    If Me.rdbPreviewOn.Checked Then
                        Dim outPutSeikyuFormReportViewUchiwake As New OutPutSeikyuFormReportViewUchiwake(Me.getTergetTime(), Me.cmbSection.SelectedIndex, list)
                        outPutSeikyuFormReportViewUchiwake.Show()
                    ElseIf MessageBox.Show(String.Format("{0}を印刷します。よろしいですか？", "内訳"), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Try
                            clsDirectPrintUchiwake.ExecPrint(Me.getTergetTime(), list)
                            DlgMessageBox.Show("印刷が完了しました。", "結果", MessageBoxButtons.OK)
                        Catch ex2 As Exception
                            DlgMessageBox.Show(ex2.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End Try
                    End If
                Case 2
                    If Me.rdbPreviewOn.Checked Then
                        Dim outPutSeikyuFormReportViewUchiwake2 As New OutPutSeikyuFormReportViewUchiwake(Me.getTergetTime(), Me.cmbSection.SelectedIndex, list)
                        outPutSeikyuFormReportViewUchiwake2.Show()
                        Dim outPutSeikyuFormReportViewSeikyu2 As New OutPutSeikyuFormReportViewSeikyu(Me.getTergetTime(), Me.cmbSection.SelectedIndex, list)
                        outPutSeikyuFormReportViewSeikyu2.Show()
                    ElseIf MessageBox.Show(String.Format("{0}を印刷します。よろしいですか？", "請求書・内訳"), "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Try

                            clsDirectPrintSeikyu.ExecPrint(Me.getTergetTime(), list)
                            clsDirectPrintUchiwake.ExecPrint(Me.getTergetTime(), list)
                            DlgMessageBox.Show("印刷が完了しました。", "結果", MessageBoxButtons.OK)
                        Catch ex3 As Exception
                            DlgMessageBox.Show(ex3.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        End Try
                    End If
            End Select
            Me.OPS_ExecutButton.Enabled = True
        End Sub

        Private Sub OPS_BackButton_Click(sender As Object, e As EventArgs) Handles OPS_BackButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
