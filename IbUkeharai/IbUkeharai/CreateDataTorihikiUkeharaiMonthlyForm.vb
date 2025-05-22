Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
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
	Public Class CreateDataTorihikiUkeharaiMonthlyForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CreatDataTorihikiUkeharaiMonthlyForm_Load
			Me.csvDirectory = Path.Combine("csv", "51.取引先別受払データ作成(月別)")
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
			Me.TorihikiLabel = New Label()
			Me.CTUM_BackButton = New Button()
			Me.CTUM_ExecutButton = New Button()
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
			Me.FormTitleLabel.Text = "取引先別受払データ作成(月別)"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(35, 122)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(74, 18)
			Me.SpecifiedDateLabel.TabIndex = 31
			Me.SpecifiedDateLabel.Text = "指定年月"
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
			'CTUM_BackButton
			'
			Me.CTUM_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CTUM_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CTUM_BackButton.Location = New Point(687, 520)
			Me.CTUM_BackButton.Name = "CTUM_BackButton"
			Me.CTUM_BackButton.Size = New Size(80, 30)
			Me.CTUM_BackButton.TabIndex = 5
			Me.CTUM_BackButton.Text = "戻る"
			Me.CTUM_BackButton.UseVisualStyleBackColor = True
			'
			'CTUM_ExecutButton
			'
			Me.CTUM_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CTUM_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CTUM_ExecutButton.Location = New Point(589, 520)
			Me.CTUM_ExecutButton.Name = "CTUM_ExecutButton"
			Me.CTUM_ExecutButton.Size = New Size(80, 30)
			Me.CTUM_ExecutButton.TabIndex = 3
			Me.CTUM_ExecutButton.Text = "実行"
			Me.CTUM_ExecutButton.UseVisualStyleBackColor = True
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
			Me.ComboTori1.Size = New Size(109, 20)
			Me.ComboTori1.TabIndex = 1
			Me.ComboTori1.TableName = "M_TORI"
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(138, 117)
			Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(120, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'CreateDataTorihikiUkeharaiMonthlyForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.ComboTori1)
			Me.Controls.Add(Me.CTUM_BackButton)
			Me.Controls.Add(Me.CTUM_ExecutButton)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.TorihikiLabel)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "CreateDataTorihikiUkeharaiMonthlyForm"
			Me.Text = "取引先別受払データ作成(月別)"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Private Sub CreatDataTorihikiUkeharaiMonthlyForm_Load(sender As Object, e As EventArgs)
			Dim cclDateTimePicker As CclDateTimePicker = Me.CclDateTimePicker
			Dim dateTime As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
			cclDateTimePicker.Value = dateTime
			Me.ComboTori1.SetToriItemList()
		End Sub

		Private Function makeSql(toricd As String, syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			Dim dateTime As New DateTime(syoriym.Year, syoriym.Month, 1)
			Dim dateTime2 As DateTime = dateTime
			Dim syoriymd As DateTime = dateTime2.AddMonths(1).AddDays(-1.0)
			stringBuilder.Append("SELECT ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 取引先コード, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(TOR.TORI_NAME)    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                AS 取引先名, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 部品コード, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.BUHIN_NAME)    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 部品名称, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO1)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                AS 棚番１, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO2)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                AS 棚番２, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TANA_NO3)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 棚番３, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.TORIHIN_NO)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 取引先品番, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.KIKAKU)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                        AS 規格, ")
			stringBuilder.Append(vbTab & vbTab & "MAX(BUH.IKISAKI_CD)" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                    AS 行先ｺｰﾄﾞ, ")
			stringBuilder.Append(vbTab & vbTab & "SUM(CASE WHEN MEI.UKEHARAI_KBN = '1' THEN ISNULL(MEI.KOSU, 0) ELSE 0 END)       AS 当月受入数, ")
			stringBuilder.Append(vbTab & vbTab & "SUM(CASE WHEN MEI.UKEHARAI_KBN = '2' THEN ISNULL(MEI.KOSU, 0) ELSE 0 END)       AS 当月払出数, ")
			stringBuilder.Append(vbTab & vbTab & "''" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                            AS 伝票NO, ")
			stringBuilder.Append(vbTab & vbTab & "''" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                AS 備考１, ")
			stringBuilder.Append(vbTab & vbTab & "''" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                AS 備考２, ")
			stringBuilder.Append(vbTab & vbTab & "''" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                AS 備考３, ")
			stringBuilder.Append(ZaikosuCommon.GetZaikoSubquery(syoriymd, "BUH", True) + "                       AS 在庫数 ")
			stringBuilder.Append("FROM  ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_BUHIN] AS BUH ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append("     ( ")
			stringBuilder.Append("         SELECT ")
			stringBuilder.Append("              * ")
			stringBuilder.Append("         FROM ")
			stringBuilder.Append(vbTab & vbTab & "         [Ukeharai].[T_UKEHARAIMEISAI] ")
			stringBuilder.Append("         WHERE ")
			stringBuilder.Append(vbTab & vbTab & "         UKEHARA_YYYYMMDD >= '{1}' ")
			stringBuilder.Append("          AND ")
			stringBuilder.Append(vbTab & "         " & vbTab & " UKEHARA_YYYYMMDD <= '{0}' ")
			stringBuilder.Append("     ) AS MEI ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = MEI.TORI_CD ")
			stringBuilder.Append(vbTab & "AND ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD = MEI.BUHIN_CD ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_TORI] AS TOR ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = TOR.TORI_CD ")
			If Not String.IsNullOrEmpty(toricd) Then
				stringBuilder.Append(vbTab & "WHERE ")
				stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = '{2}' ")
			End If
			stringBuilder.Append("GROUP BY ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD ")
			stringBuilder.Append("ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD ")
			Dim result As String
			If Not String.IsNullOrEmpty(toricd) Then
				result = String.Format(stringBuilder.ToString(), syoriymd.ToString("yyyy/MM/dd"), syoriym.ToString("yyyy/MM/01"), toricd)
			Else
				result = String.Format(stringBuilder.ToString(), syoriymd.ToString("yyyy/MM/dd"), syoriym.ToString("yyyy/MM/01"))
			End If
			Return result
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("TorihikiLabel")>
		Private WithEvents TorihikiLabel As Label

		<AccessedThroughProperty("CTUM_BackButton")>
		Private WithEvents CTUM_BackButton As Button

		<AccessedThroughProperty("CTUM_ExecutButton")>
		Private WithEvents CTUM_ExecutButton As Button

		<AccessedThroughProperty("ComboTori1")>
		Private WithEvents ComboTori1 As CmpComboBox
		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		Private Const ALL_MANUFACTURER As String = "全メーカー"

		Private Const CSV_FILE_NAME As String = "51.取引先別受払データ作成(月別)_{0}_{1}{2}.csv"

		Private csvDirectory As String

		Private Sub CTUM_ExecutButton_Click(sender As Object, e As EventArgs) Handles CTUM_ExecutButton.Click
			Dim syoriym As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			Dim itemInfomation As ItemInfomation = CType(Me.ComboTori1.SelectedItem, ItemInfomation)
			If Me.ComboTori1.SelectedIndex <= 0 Then
				DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.ComboTori1.Focus()
				Return
			End If
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年月を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclDateTimePicker.Focus()
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Dim configData As XmlConfigControl = TopForm.ConfigData
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(configData.xmlConfData.xDataBase)
				Dim text As String
				If itemInfomation.Code.Equals("全メーカー") Then
					text = Me.makeSql("", syoriym)
				Else
					text = Me.makeSql(itemInfomation.Code, syoriym)
				End If
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not String.IsNullOrEmpty(sqldata) Then
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Cursor.Current = Cursors.[Default]
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
					Return
				End If
				If sqlDataBase.DbDataTable.Rows.Count = 0 Then
					DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Cursor.Current = Cursors.[Default]
					Return
				End If
				dbDataTable = sqlDataBase.DbDataTable
			End Using
			Dim text2 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text2) Then
				Directory.CreateDirectory(text2)
			End If
			Dim csvPath As String
			If itemInfomation.Code.Equals("全メーカー") Then
				csvPath = Path.Combine(text2, String.Format("51.取引先別受払データ作成(月別)_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), "", "全メーカー"))
			Else
				csvPath = Path.Combine(text2, Common.EscapeInvalidFileName(String.Format("51.取引先別受払データ作成(月別)_{0}_{1}{2}.csv", syoriym.ToString("yyyyMM"), itemInfomation.Code, itemInfomation.Name)))
			End If
			Dim csvCommon As New CsvCommon()
			Dim flag As Boolean = csvCommon.ConvertDataTableToCsv(dbDataTable, csvPath, True)
			Cursor.Current = Cursors.[Default]
			If Not flag Then
				DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				DlgMessageBox.Show("CSV出力が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		Private Sub CTUM_BackButton_Click(sender As Object, e As EventArgs) Handles CTUM_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
