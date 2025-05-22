Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
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
	Public Class ListBuhinForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.ListBuhinForm_Load
            Me.csvDirectory = Path.Combine("csv", "58.部品別受払プリント")
            Me.csvFileNameFormat = "58.部品別受払プリント_{0}_{1}{2}.csv"
            Me.allManufacturer = "全メーカー"
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
            Me.InfoLabel = New Label()
            Me.SpecifiedDateLabel = New Label()
            Me.TorihikiLabel = New Label()
            Me.LBP_BackButton = New Button()
            Me.LBP_ExecutButton = New Button()
            Me.ResultLabel = New Label()
            Me.ComboTori1 = New IbUkeharai.Util.CmpComboBox(Me.components)
            Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.FormTitleLabel.BackColor = Color.SlateBlue
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(760, 45)
            Me.FormTitleLabel.TabIndex = 5
            Me.FormTitleLabel.Text = "部品別受払プリント　出力"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'InfoLabel
            '
            Me.InfoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.InfoLabel.ForeColor = Color.Black
            Me.InfoLabel.Location = New Point(136, 190)
            Me.InfoLabel.Name = "InfoLabel"
            Me.InfoLabel.Size = New Size(376, 30)
            Me.InfoLabel.TabIndex = 32
            Me.InfoLabel.Text = "※　印刷したい取引先コード、年月日を入力してください。"
            '
            'SpecifiedDateLabel
            '
            Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SpecifiedDateLabel.Location = New Point(35, 122)
            Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
            Me.SpecifiedDateLabel.Size = New Size(74, 18)
            Me.SpecifiedDateLabel.TabIndex = 31
            Me.SpecifiedDateLabel.Text = "指定年月日"
            '
            'TorihikiLabel
            '
            Me.TorihikiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.TorihikiLabel.Location = New Point(35, 79)
            Me.TorihikiLabel.Name = "TorihikiLabel"
            Me.TorihikiLabel.Size = New Size(97, 18)
            Me.TorihikiLabel.TabIndex = 29
            Me.TorihikiLabel.Text = "取引先コード"
            '
            'LBP_BackButton
            '
            Me.LBP_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.LBP_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.LBP_BackButton.Location = New Point(687, 520)
            Me.LBP_BackButton.Name = "LBP_BackButton"
            Me.LBP_BackButton.Size = New Size(80, 30)
            Me.LBP_BackButton.TabIndex = 4
            Me.LBP_BackButton.Text = "戻る"
            Me.LBP_BackButton.UseVisualStyleBackColor = True
            '
            'LBP_ExecutButton
            '
            Me.LBP_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.LBP_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.LBP_ExecutButton.Location = New Point(592, 520)
            Me.LBP_ExecutButton.Name = "LBP_ExecutButton"
            Me.LBP_ExecutButton.Size = New Size(80, 30)
            Me.LBP_ExecutButton.TabIndex = 3
            Me.LBP_ExecutButton.Text = "実行"
            Me.LBP_ExecutButton.UseVisualStyleBackColor = True
            '
            'ResultLabel
            '
            Me.ResultLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ResultLabel.ForeColor = Color.Black
            Me.ResultLabel.Location = New Point(135, 220)
            Me.ResultLabel.Name = "ResultLabel"
            Me.ResultLabel.Size = New Size(320, 40)
            Me.ResultLabel.TabIndex = 35
            Me.ResultLabel.Text = "ここに結果を表示します。"
            Me.ResultLabel.TextAlign = ContentAlignment.MiddleLeft
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
            Me.ComboTori1.Location = New Point(138, 76)
            Me.ComboTori1.MaxLength = 8
            Me.ComboTori1.Name = "ComboTori1"
            Me.ComboTori1.Size = New Size(107, 20)
            Me.ComboTori1.TabIndex = 1
            Me.ComboTori1.TableName = "M_TORI"
            '
            'CclDateTimePicker
            '
            Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
            Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
            Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CclDateTimePicker.CustomFormat = "yyyy年MM月dd日"
            Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
            Me.CclDateTimePicker.Location = New Point(138, 117)
            Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
            Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.CclDateTimePicker.Name = "CclDateTimePicker"
            Me.CclDateTimePicker.NullValue = ""
            Me.CclDateTimePicker.Size = New Size(130, 19)
            Me.CclDateTimePicker.TabIndex = 2
            Me.CclDateTimePicker.Value = DateTime.Now
            '
            'ListBuhinForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(784, 562)
            Me.Controls.Add(Me.CclDateTimePicker)
            Me.Controls.Add(Me.ComboTori1)
            Me.Controls.Add(Me.ResultLabel)
            Me.Controls.Add(Me.LBP_BackButton)
            Me.Controls.Add(Me.LBP_ExecutButton)
            Me.Controls.Add(Me.InfoLabel)
            Me.Controls.Add(Me.SpecifiedDateLabel)
            Me.Controls.Add(Me.TorihikiLabel)
            Me.Controls.Add(Me.FormTitleLabel)
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "ListBuhinForm"
            Me.Text = "部品別受払プリント"
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub ListBuhinForm_Load(sender As Object, e As EventArgs)
            Me.ComboTori1.SetToriItemList()
            Me.ResultLabel.Text = String.Empty
        End Sub

        Private Function getOutputCsvDataSql(ByRef torihikiCode As String, ByRef selectDate As DateTime) As String
            Dim text As String = "SELECT um.TORI_CD                                                                  AS 取引先コード,        mt.TORI_NAME                                                                AS 取引先名,        FORMAT(um.UKEHARA_YYYYMMDD, 'yyyy/MM/dd')                                   AS 対象年月日,        um.BUHIN_CD                                                                 AS 部品コード,        mb.BUHIN_NAME                                                               AS 品名,        mb.TANA_NO1                                                                 AS 棚番1,        mb.TANA_NO2                                                                 AS 棚番2,        mb.TANA_NO3                                                                 AS 棚番3,        CASE WHEN um.UKEHARAI_KBN='1' THEN um.KOSU ELSE 0 END                       AS 受入数,        CASE WHEN um.UKEHARAI_KBN='2' THEN um.KOSU ELSE 0 END                       AS 払出数,        um.DEN_NO                                                                   AS 伝票NO,        um.REMARKS1                                                                 AS 備考1,        um.REMARKS2                                                                 AS 備考2,        um.REMARKS3                                                                 AS 備考3, " + ZaikosuCommon.GetZaikoSubquery(selectDate, "um", False) + "                         AS 当月残  FROM   Ukeharai.T_UKEHARAIMEISAI   AS um        LEFT OUTER JOIN Ukeharai.M_BUHIN       AS mb        ON um.BUHIN_CD=mb.BUHIN_CD AND um.TORI_CD=mb.TORI_CD        JOIN Ukeharai.M_TORI        AS mt        ON um.TORI_CD=mt.TORI_CD WHERE  um.UKEHARA_YYYYMMDD='{0}'"
            If Not String.IsNullOrEmpty(torihikiCode) Then
                text += " AND um.TORI_CD='{1}'"
                text = String.Format(text, selectDate.ToString("yyyy/MM/dd"), torihikiCode)
            Else
                text = String.Format(text, selectDate.ToString("yyyy/MM/dd"))
            End If
            Return text
        End Function

        Private components As IContainer

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("InfoLabel")>
        Private WithEvents InfoLabel As Label

        <AccessedThroughProperty("SpecifiedDateLabel")>
        Private WithEvents SpecifiedDateLabel As Label

        <AccessedThroughProperty("TorihikiLabel")>
        Private WithEvents TorihikiLabel As Label

        <AccessedThroughProperty("LBP_BackButton")>
        Private WithEvents LBP_BackButton As Button

        <AccessedThroughProperty("LBP_ExecutButton")>
        Private WithEvents LBP_ExecutButton As Button

        <AccessedThroughProperty("ResultLabel")>
        Private WithEvents ResultLabel As Label

        <AccessedThroughProperty("ComboTori1")>
        Private WithEvents ComboTori1 As CmpComboBox

        <AccessedThroughProperty("CclDateTimePicker")>
        Private WithEvents CclDateTimePicker As CclDateTimePicker

        Private csvDirectory As String

        Private csvFileNameFormat As String

        Public allManufacturer As String

        Private Sub LBP_ExecutButton_Click(sender As Object, e As EventArgs) Handles LBP_ExecutButton.Click
            Dim text As String = Me.ComboTori1.Text
            Dim arg As String = String.Empty
            Dim dateTime As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
            If Me.ComboTori1.SelectedIndex <= 0 Then
                DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.ComboTori1.Focus()
                Return
            End If
            If Operators.CompareString(text, Me.allManufacturer, False) = 0 Then
                text = Nothing
            End If
            If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
                DlgMessageBox.Show("指定年月日を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CclDateTimePicker.Focus()
                Return
            End If
            Me.ResultLabel.Text = Nothing
            Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim dbDataTable As DataTable
                Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
                    Dim text2 As String = String.Empty
                    If Operators.CompareString(Me.ComboTori1.Text, Me.allManufacturer, False) = 0 Then
                        arg = Me.allManufacturer
                    Else
                        If Me.ComboTori1.SelectedIndex <= 0 Then
                            DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.ComboTori1.Focus()
                            Return
                        End If
                        arg = Conversions.ToString(NewLateBinding.LateGet(Me.ComboTori1.SelectedItem, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing))
                    End If
                    Dim outputCsvDataSql As String = Me.getOutputCsvDataSql(text, dateTime)
                    text2 = sqlDataBase.getSQLData(outputCsvDataSql, True)
                    If Not String.IsNullOrEmpty(text2) Then
                        DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        OutputLog.WriteLine(Me.[GetType]().Name + " CSV SQL Database Error.", New String() {outputCsvDataSql, text2})
                        Return
                    End If
                    If sqlDataBase.DbDataTable.Rows.Count = 0 Then
                        DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                    dbDataTable = sqlDataBase.DbDataTable
                End Using
                Dim zaikosuCommon As New ZaikosuCommon()
                Dim text3 As String = ""
                Dim num As Integer = 0
                Try
                    For Each obj As Object In dbDataTable.Rows
                        Dim dataRow As DataRow = CType(obj, DataRow)
                        Dim value As String = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(dataRow("取引先コード")), GetType(String))) + CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(dataRow("部品コード")), GetType(String)))
                        If text3.Equals(value) Then
                            num = num + Integer.Parse(Conversions.ToString(dataRow("受入数"))) - Integer.Parse(Conversions.ToString(dataRow("払出数")))
                            dataRow("当月残") = num.ToString()
                        Else
                            num = Integer.Parse(Conversions.ToString(dataRow("当月残"))) + Integer.Parse(Conversions.ToString(dataRow("受入数"))) - Integer.Parse(Conversions.ToString(dataRow("払出数")))
                            dataRow("当月残") = num.ToString()
                        End If
                        text3 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(dataRow("取引先コード")), GetType(String))) + CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(dataRow("部品コード")), GetType(String)))
                    Next
                Finally
                    Dim enumerator As IEnumerator = Nothing
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Dim text4 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
                If Not Directory.Exists(text4) Then
                    Directory.CreateDirectory(text4)
                End If
                Dim count As Integer = dbDataTable.Rows.Count
                Dim path1 As String = String.Format(Me.csvFileNameFormat, dateTime.ToString("yyyyMMdd"), text, arg)
                Dim csvPath As String = Path.Combine(text4, path1)
                Dim csvCommon As New CsvCommon()
                If Not csvCommon.ConvertDataTableToCsv(dbDataTable, csvPath, True) Then
                    DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    DlgMessageBox.Show("CSV出力が完了しました。", "完了", MessageBoxButtons.OK)
                    Me.ResultLabel.Text = count.ToString() + " 件のデータを出力しました。"
                End If
            Finally
                Cursor.Current = Cursors.[Default]
            End Try
        End Sub

        Private Sub LBP_BackButton_Click(sender As Object, e As EventArgs) Handles LBP_BackButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
