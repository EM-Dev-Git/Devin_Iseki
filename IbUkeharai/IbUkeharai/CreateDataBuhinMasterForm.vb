Imports System
Imports System.Collections
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
Imports IbUkeharai.IbUkeharai.CateDataExec
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class CreateDataBuhinMasterForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CreatDataBuhinMasterForm_Load
			Me.csvDirectory = Path.Combine("csv", "55.部品マスタ")
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
			Me.CBM_BackButton = New Button()
			Me.CBM_ExecutButton = New Button()
			Me.LUR_SelectAllButton = New Button()
			Me.LUR_ClearButton = New Button()
			Me.SpecifiedDateLabel = New Label()
			Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
			Me.UcSelectGridView1 = New IbUkeharai.UcSelectGridView()
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
			Me.FormTitleLabel.TabIndex = 6
			Me.FormTitleLabel.Text = "部品マスターデータ作成"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'CBM_BackButton
			'
			Me.CBM_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CBM_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CBM_BackButton.Location = New Point(687, 520)
			Me.CBM_BackButton.Name = "CBM_BackButton"
			Me.CBM_BackButton.Size = New Size(80, 30)
			Me.CBM_BackButton.TabIndex = 5
			Me.CBM_BackButton.Text = "戻る"
			Me.CBM_BackButton.UseVisualStyleBackColor = True
			'
			'CBM_ExecutButton
			'
			Me.CBM_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.CBM_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CBM_ExecutButton.Location = New Point(591, 520)
			Me.CBM_ExecutButton.Name = "CBM_ExecutButton"
			Me.CBM_ExecutButton.Size = New Size(80, 30)
			Me.CBM_ExecutButton.TabIndex = 4
			Me.CBM_ExecutButton.Text = "実行"
			Me.CBM_ExecutButton.UseVisualStyleBackColor = True
			'
			'LUR_SelectAllButton
			'
			Me.LUR_SelectAllButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_SelectAllButton.Location = New Point(42, 72)
			Me.LUR_SelectAllButton.Name = "LUR_SelectAllButton"
			Me.LUR_SelectAllButton.Size = New Size(80, 30)
			Me.LUR_SelectAllButton.TabIndex = 0
			Me.LUR_SelectAllButton.Text = "全選択"
			Me.LUR_SelectAllButton.UseVisualStyleBackColor = True
			'
			'LUR_ClearButton
			'
			Me.LUR_ClearButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.LUR_ClearButton.Location = New Point(138, 72)
			Me.LUR_ClearButton.Name = "LUR_ClearButton"
			Me.LUR_ClearButton.Size = New Size(80, 30)
			Me.LUR_ClearButton.TabIndex = 1
			Me.LUR_ClearButton.Text = "クリア"
			Me.LUR_ClearButton.UseVisualStyleBackColor = True
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(262, 78)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(45, 18)
			Me.SpecifiedDateLabel.TabIndex = 35
			Me.SpecifiedDateLabel.Text = "指定年"
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(308, 73)
			Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(87, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'UcSelectGridView1
			'
			Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcSelectGridView1.Location = New Point(12, 108)
			Me.UcSelectGridView1.Name = "UcSelectGridView1"
			Me.UcSelectGridView1.Size = New Size(749, 406)
			Me.UcSelectGridView1.TabIndex = 3
			'
			'CreateDataBuhinMasterForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.UcSelectGridView1)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.LUR_ClearButton)
			Me.Controls.Add(Me.LUR_SelectAllButton)
			Me.Controls.Add(Me.CBM_BackButton)
			Me.Controls.Add(Me.CBM_ExecutButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "CreateDataBuhinMasterForm"
			Me.Text = "部品マスターデータ作成画面"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Friend Overridable Property CmpSgv As CmpSelectGridView
			Get
				Return Me._CmpSgv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CmpSelectGridView)
				Me._CmpSgv = value
			End Set
		End Property

		Private Sub CreatDataBuhinMasterForm_Load(sender As Object, e As EventArgs)
			Me.SetToriGridView()
			Me.SetToriGridViewData()
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
			Me.CclDateTimePicker.Value = DateAndTime.Now.ToString("yyyy/MM/01")
		End Sub

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

		Private Function makeSql(arySelectedRows As ArrayList, syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append("SELECT ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 取引先コード, ")
			stringBuilder.Append(vbTab & vbTab & "TOR.TORI_NAME" & vbTab & "    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 取引先名, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 部品コード, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_NAME    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                AS 品名, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO1    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                AS 棚番１, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO2    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                AS 棚番２, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TANA_NO3    " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 棚番３, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORIHIN_NO  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 取引先品番, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.KIKAKU  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                        AS 規格, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.IKISAKI_CD  " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "                                                    AS 行先コード, ")
			stringBuilder.Append(vbTab & vbTab & "JIS.ZAIKOSU                                                                                                     AS 期末在庫, ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_01                                                                                                  AS '1月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_01                                                                                                  AS '1月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_02                                                                                                  AS '2月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_02                                                                                                  AS '2月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_03                                                                                                  AS '3月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_03                                                                                                  AS '3月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_04                                                                                                  AS '4月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_04                                                                                                  AS '4月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_05                                                                                                  AS '5月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_05                                                                                                  AS '5月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_06                                                                                                  AS '6月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_06                                                                                                  AS '6月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_07                                                                                                  AS '7月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_07                                                                                                  AS '7月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_08                                                                                                  AS '8月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_08                                                                                                  AS '8月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_09                                                                                                  AS '9月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_09                                                                                                  AS '9月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_10                                                                                                  AS '10月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_10                                                                                                  AS '10月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_11                                                                                                  AS '11月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_11                                                                                                  AS '11月：払出', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.UKEKOSU_12                                                                                                  AS '12月：受入', ")
			stringBuilder.Append(vbTab & vbTab & "JIS.HARKOSU_12                                                                                                  AS '12月：払出' ")
			stringBuilder.Append("FROM  ")
			stringBuilder.Append("    ( ")
			stringBuilder.Append("     SELECT ")
			stringBuilder.Append("           * ")
			stringBuilder.Append("     FROM ")
			stringBuilder.Append("           [Ukeharai].[M_BUHIN] ")
			stringBuilder.Append("     WHERE ")
			stringBuilder.Append("            TORI_CD IN ({1}) ")
			stringBuilder.Append("    ) AS BUH ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append("    ( ")
			stringBuilder.Append("     SELECT ")
			stringBuilder.Append("           TORI_CD, ")
			stringBuilder.Append("           BUHIN_CD,")
			stringBuilder.Append("           MAX(ZAIKOSU) AS ZAIKOSU, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 1  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_01, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 1  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_01, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 2  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_02, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 2  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_02, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 3  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_03, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 3  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_03, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 4  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_04, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 4  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_04, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 5  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_05, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 5  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_05, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 6  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_06, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 6  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_06, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 7  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_07, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 7  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_07, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 8  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_08, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 8  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_08, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 9  THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_09, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 9  THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_09, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 10 THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_10, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 10 THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_10, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 11 THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_11, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 11 THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_11, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 12 THEN ISNULL(UKESU, 0)  ELSE 0 END ) AS UKEKOSU_12, ")
			stringBuilder.Append("           SUM( CASE WHEN MONTH(UKEHARA_YYYYMM) = 12 THEN ISNULL(HARASU, 0) ELSE 0 END ) AS HARKOSU_12  ")
			stringBuilder.Append("     FROM ")
			stringBuilder.Append("           [Ukeharai].[T_UKEHARAIJISSEKI] ")
			stringBuilder.Append("     WHERE ")
			stringBuilder.Append("           YEAR(UKEHARA_YYYYMM) = {0} ")
			stringBuilder.Append(vbTab & "     AND ")
			stringBuilder.Append("           TORI_CD IN ({1}) ")
			stringBuilder.Append("     GROUP BY ")
			stringBuilder.Append("           TORI_CD, ")
			stringBuilder.Append("           BUHIN_CD ")
			stringBuilder.Append("    ) AS JIS ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = JIS.TORI_CD ")
			stringBuilder.Append(vbTab & "AND ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD = JIS.BUHIN_CD ")
			stringBuilder.Append("LEFT OUTER JOIN ")
			stringBuilder.Append(vbTab & vbTab & "[Ukeharai].[M_TORI] AS TOR ")
			stringBuilder.Append("ON ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD = TOR.TORI_CD ")
			stringBuilder.Append("ORDER BY ")
			stringBuilder.Append(vbTab & vbTab & "BUH.TORI_CD, ")
			stringBuilder.Append(vbTab & vbTab & "BUH.BUHIN_CD ")
			Dim text As String = ""
			Try
				For Each obj As Object In arySelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text + "'", dataGridViewRow.Cells("Tori_Cd").Value), "',"))
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			text = text.TrimEnd(New Char() {","c})
			Return String.Format(stringBuilder.ToString(), syoriym.ToString("yyyy"), text)
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("CBM_BackButton")>
		Private WithEvents CBM_BackButton As Button

		<AccessedThroughProperty("CBM_ExecutButton")>
		Private WithEvents CBM_ExecutButton As Button

		<AccessedThroughProperty("LUR_SelectAllButton")>
		Private WithEvents LUR_SelectAllButton As Button

		<AccessedThroughProperty("LUR_ClearButton")>
		Private WithEvents LUR_ClearButton As Button

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		<AccessedThroughProperty("UcSelectGridView1")>
		Private WithEvents UcSelectGridView1 As UcSelectGridView

		<AccessedThroughProperty("CmpSgv")>
		Private _CmpSgv As CmpSelectGridView

		Private Const ALL_MANUFACTURER As String = "全メーカー"

		Private Const CSV_FILE_NAME As String = "55.部品マスタ_{0}_{1}{2}.csv"

		Private csvDirectory As String

		Private Sub LUR_SelectAllButton_Click(sender As Object, e As EventArgs) Handles LUR_SelectAllButton.Click
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

		Private Sub LUR_ClearButton_Click(sender As Object, e As EventArgs) Handles LUR_ClearButton.Click
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

		Private Sub CBM_ExecutButton_Click(sender As Object, e As EventArgs) Handles CBM_ExecutButton.Click
			Dim syoriym As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.CclDateTimePicker.Focus()
				Return
			End If
			Dim arrayList As New ArrayList()
			Try
				For Each obj As Object In CType(Me.UcSelectGridView1.CmpSgv.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					If Conversions.ToBoolean(dataGridViewRow.Cells("SelectCheckd").Value) Then
						arrayList.Add(dataGridViewRow)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If arrayList.Count = 0 Then
				DlgMessageBox.Show("取引先コードを選択してださい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "情報", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Dim dbDataTable As DataTable
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = Me.makeSql(arrayList, syoriym)
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not sqldata.Equals(String.Empty) Then
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
			Dim text2 As String = ""
			Dim csvCommon As New CsvCommon()
			Dim text3 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text3) Then
				Directory.CreateDirectory(text3)
			End If
			Dim flag As Boolean
			If arrayList.Count = Me.UcSelectGridView1.CmpSgv.Rows.Count Then
				text2 = Path.Combine(text3, String.Format("55.部品マスタ_{0}_{1}{2}.csv", syoriym.ToString("yyyy"), "", "全メーカー"))
				flag = csvCommon.ConvertDataTableToCsv(dbDataTable, text2, True)
			Else
				Dim dataTable As DataTable = dbDataTable.Clone()
				Try
					For Each obj2 As Object In arrayList
						Dim dataGridViewRow2 As DataGridViewRow = CType(obj2, DataGridViewRow)
						dataTable.Clear()
						Dim array As DataRow() = dbDataTable.[Select](String.Format("取引先コード = '{0}'", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Cd").Value)))
						For Each row As DataRow In array
							dataTable.ImportRow(row)
						Next
						Dim fileName As String = String.Format("55.部品マスタ_{0}_{1}{2}.csv", syoriym.ToString("yyyy"), RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Cd").Value), RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells("Tori_Name").Value))
						text2 = Path.Combine(text3, Common.EscapeInvalidFileName(fileName))
						flag = csvCommon.ConvertDataTableToCsv(dataTable, text2, True)
						If Not flag Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator = Nothing
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			Cursor.Current = Cursors.[Default]
			If Not flag Then
				DlgMessageBox.Show(String.Format("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}", Path.GetFileName(text2)), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				DlgMessageBox.Show("CSV出力が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		Private Sub CBM_BackButton_Click(sender As Object, e As EventArgs) Handles CBM_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
