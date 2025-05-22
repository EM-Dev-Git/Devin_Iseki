Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
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
	Public Class OutPutZissekiTableForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.OutPutZissekiTableForm_Load
			Me.HeaderTable = New DataTable()
			Me.BodyTable = New DataTable()
			Me.csvDirectory = Path.Combine("csv", "61.実績内訳表出力")
			Me.csvFileName = "KANRA00.csv"
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
			Me.OPZ_ClearButton = New Button()
			Me.OPZ_SelectAllButton = New Button()
			Me.OPZ_BackButton = New Button()
			Me.OPZ_ExecutButton = New Button()
			Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
			Me.UcSelectGridView1 = New IbUkeharai.UcSelectGridView()
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
			Me.FormTitleLabel.TabIndex = 5
			Me.FormTitleLabel.Text = "実績内訳表　出力"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'SpecifiedDateLabel
			'
			Me.SpecifiedDateLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.SpecifiedDateLabel.Location = New Point(229, 78)
			Me.SpecifiedDateLabel.Name = "SpecifiedDateLabel"
			Me.SpecifiedDateLabel.Size = New Size(70, 18)
			Me.SpecifiedDateLabel.TabIndex = 41
			Me.SpecifiedDateLabel.Text = "指定年月"
			'
			'OPZ_ClearButton
			'
			Me.OPZ_ClearButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.OPZ_ClearButton.Location = New Point(114, 72)
			Me.OPZ_ClearButton.Name = "OPZ_ClearButton"
			Me.OPZ_ClearButton.Size = New Size(80, 30)
			Me.OPZ_ClearButton.TabIndex = 1
			Me.OPZ_ClearButton.Tag = ""
			Me.OPZ_ClearButton.Text = "クリア"
			Me.OPZ_ClearButton.UseVisualStyleBackColor = True
			'
			'OPZ_SelectAllButton
			'
			Me.OPZ_SelectAllButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.OPZ_SelectAllButton.Location = New Point(18, 72)
			Me.OPZ_SelectAllButton.Name = "OPZ_SelectAllButton"
			Me.OPZ_SelectAllButton.Size = New Size(80, 30)
			Me.OPZ_SelectAllButton.TabIndex = 0
			Me.OPZ_SelectAllButton.Tag = ""
			Me.OPZ_SelectAllButton.Text = "全選択"
			Me.OPZ_SelectAllButton.UseVisualStyleBackColor = True
			'
			'OPZ_BackButton
			'
			Me.OPZ_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.OPZ_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.OPZ_BackButton.Location = New Point(687, 520)
			Me.OPZ_BackButton.Name = "OPZ_BackButton"
			Me.OPZ_BackButton.Size = New Size(80, 30)
			Me.OPZ_BackButton.TabIndex = 5
			Me.OPZ_BackButton.Text = "戻る"
			Me.OPZ_BackButton.UseVisualStyleBackColor = True
			'
			'OPZ_ExecutButton
			'
			Me.OPZ_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.OPZ_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.OPZ_ExecutButton.Location = New Point(592, 520)
			Me.OPZ_ExecutButton.Name = "OPZ_ExecutButton"
			Me.OPZ_ExecutButton.Size = New Size(80, 30)
			Me.OPZ_ExecutButton.TabIndex = 4
			Me.OPZ_ExecutButton.Text = "実行"
			Me.OPZ_ExecutButton.UseVisualStyleBackColor = True
			'
			'CclDateTimePicker
			'
			Me.CclDateTimePicker.BackColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.BkColor = Color.LightGoldenrodYellow
			Me.CclDateTimePicker.CalendarFont = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
			Me.CclDateTimePicker.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.CclDateTimePicker.Format = DateTimePickerFormat.Custom
			Me.CclDateTimePicker.Location = New Point(303, 73)
			Me.CclDateTimePicker.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
			Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
			Me.CclDateTimePicker.Name = "CclDateTimePicker"
			Me.CclDateTimePicker.NullValue = ""
			Me.CclDateTimePicker.Size = New Size(120, 19)
			Me.CclDateTimePicker.TabIndex = 2
			Me.CclDateTimePicker.Value = DateTime.Now
			'
			'UcSelectGridView1
			'
			Me.UcSelectGridView1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.UcSelectGridView1.Location = New Point(18, 108)
			Me.UcSelectGridView1.Name = "UcSelectGridView1"
			Me.UcSelectGridView1.Size = New Size(749, 406)
			Me.UcSelectGridView1.TabIndex = 3
			'
			'OutPutZissekiTableForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.UcSelectGridView1)
			Me.Controls.Add(Me.CclDateTimePicker)
			Me.Controls.Add(Me.OPZ_BackButton)
			Me.Controls.Add(Me.OPZ_ExecutButton)
			Me.Controls.Add(Me.SpecifiedDateLabel)
			Me.Controls.Add(Me.OPZ_ClearButton)
			Me.Controls.Add(Me.OPZ_SelectAllButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "OutPutZissekiTableForm"
			Me.Text = "実績内訳表出力画面"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Private Sub OutPutZissekiTableForm_Load(sender As Object, e As EventArgs)
			Me.Cursor = Cursors.WaitCursor
			Me.SetToriGridView()
			Me.SetToriGridViewData()
			Me.UcSelectGridView1.CmpSgv.DisplayRowsCount()
			Me.CclDateTimePicker.Value = DateAndTime.Now.AddMonths(-1).ToString("yyyy/MM/01")
			Me.Cursor = Cursors.[Default]
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

		Private Function makeHeaderSql(syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append("SELECT ")
			stringBuilder.Append(vbTab & vbTab & "TOP 1 ")
			stringBuilder.Append(vbTab & vbTab & "KAISYA                        AS {0}, ")
			stringBuilder.Append(vbTab & vbTab & "JIGYOSYO                      AS {1}, ")
			stringBuilder.Append(vbTab & vbTab & "SUBSTRING(CHIKU_NAME, 1, 2)   AS {2}, ")
			stringBuilder.Append(vbTab & vbTab & "'{3}'                         AS {4}, ")
			stringBuilder.Append(vbTab & vbTab & "'{5}'                         AS {6} ")
			stringBuilder.Append("FROM  ")
			stringBuilder.Append("     Ukeharai.M_JOSU ")
			Return String.Format(stringBuilder.ToString(), New Object() {"会社名", "部署", "地区", syoriym.ToString("yyyy年MM月01日"), "出力年月_開始日", DateAndTime.DateSerial(syoriym.Year, syoriym.Month + 1, 1).AddDays(-1.0).ToString("yyyy年MM月dd日"), "出力年月_終了日"})
		End Function

		Private Function makeBodySql(arySelectedRows As ArrayList, syoriym As DateTime) As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEI.SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '1' THEN '個数' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN '％' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                                                                              AS {0}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "ISNULL(TOR.TORI_NAME, '[不明]')                                                  AS {1}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.UCHIWAKE                                                                    AS {2}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE WHEN SEI.SEIKYU_TYPE = '2' THEN TOR.RITU ELSE NULL END                      AS {3},")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEI.SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN ISNULL(SEIM.SURYO, 0) ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                                                                              AS {4}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "ISNULL(SEIM.KINGAKU, 0)                                                          AS {5}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.TORI_CD                                                                     AS {6}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEI.SEIKYU_TYPE                                                                  AS {7}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.SEIKYU_SQNO                                                                 AS {8}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "''                                                                               AS {9} ")
			stringBuilder.Append(" FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & "( ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & vbTab & "* ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & vbTab & "[Ukeharai].[T_SEIKYUM] ")
			stringBuilder.Append(" " & vbTab & " " & vbTab & vbTab & "WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & vbTab & "{10} ")
			stringBuilder.Append("")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & vbTab & "SEIKYU_YYYYMM = '{11}' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & ") AS SEIM ")
			stringBuilder.Append(" LEFT OUTER JOIN ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[M_TORI]  AS TOR ")
			stringBuilder.Append(" ON ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.TORI_CD = TOR.TORI_CD ")
			stringBuilder.Append(" INNER JOIN  ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[T_SEIKYU] AS SEI ")
			stringBuilder.Append(" ON ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.TORI_CD = SEI.TORI_CD ")
			stringBuilder.Append(" AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIM.SEIKYU_YYYYMM = SEI.SEIKYU_YYYYMM ")
			stringBuilder.Append(" AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEI.SEIKYU_TYPE IN ('1', '2') ")
			stringBuilder.Append(" UNION ALL ")
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '1' THEN '個数' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN '％' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                        AS {0}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {1},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "'課税'                     AS {2},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {3},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {4},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "KAZEI                      AS {5},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "TORI_CD                    AS {6},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE                AS {7},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "1000                       AS {8},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "''                         AS {9}  ")
			stringBuilder.Append(" FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[T_SEIKYU] ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & "{10} ")
			stringBuilder.Append("")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_YYYYMM = '{11}' ")
			stringBuilder.Append("     AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE IN ('1', '2') ")
			stringBuilder.Append(" UNION ALL ")
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '1' THEN '個数' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN '％' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                        AS {0}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {1},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "'非課税'                   AS {2},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {3},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {4},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "HIKAZEI                    AS {5},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "TORI_CD                    AS {6},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE                AS {7},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "1001                       AS {8},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "''                         AS {9}  ")
			stringBuilder.Append(" FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[T_SEIKYU] ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & "{10} ")
			stringBuilder.Append("")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_YYYYMM = '{11}' ")
			stringBuilder.Append("     AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE IN ('1', '2') ")
			stringBuilder.Append(" UNION ALL ")
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '1' THEN '個数' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN '％' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                        AS {0}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {1},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "'消費税'                   AS {2},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {3},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {4},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "SYOHIZEI                   AS {5},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "TORI_CD                    AS {6},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE                AS {7},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "1002                       AS {8},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "''                         AS {9}  ")
			stringBuilder.Append(" FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[T_SEIKYU] ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & "{10} ")
			stringBuilder.Append("")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_YYYYMM = '{11}' ")
			stringBuilder.Append("     AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE IN ('1', '2') ")
			stringBuilder.Append(" UNION ALL ")
			stringBuilder.Append(" SELECT ")
			stringBuilder.Append(" " & vbTab & vbTab & "CASE SEIKYU_TYPE  ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '1' THEN '個数' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "WHEN '2' THEN '％' ")
			stringBuilder.Append(" " & vbTab & vbTab & vbTab & "ELSE NULL  ")
			stringBuilder.Append(" " & vbTab & vbTab & "END                        AS {0}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {1},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "'計'                       AS {2},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {3},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "NULL                       AS {4},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "GOUKEI                     AS {5},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "TORI_CD                    AS {6},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE                AS {7},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "1003                       AS {8},  ")
			stringBuilder.Append(" " & vbTab & vbTab & "''                         AS {9}  ")
			stringBuilder.Append(" FROM ")
			stringBuilder.Append(" " & vbTab & vbTab & "[Ukeharai].[T_SEIKYU] ")
			stringBuilder.Append(" WHERE ")
			stringBuilder.Append(" " & vbTab & vbTab & "{10} ")
			stringBuilder.Append("")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_YYYYMM = '{11}' ")
			stringBuilder.Append("     AND ")
			stringBuilder.Append(" " & vbTab & vbTab & "SEIKYU_TYPE IN ('1', '2') ")
			stringBuilder.Append(" ORDER BY ")
			stringBuilder.Append("     " & vbTab & "{7}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "{6}, ")
			stringBuilder.Append(" " & vbTab & vbTab & "{8} ")
			Dim text As String = ""
			If Me.UcSelectGridView1.CmpSgv.Rows.Count <> arySelectedRows.Count Then
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
				text = "TORI_CD IN (" + text + ") AND "
			End If
			Return String.Format(stringBuilder.ToString(), New Object() {"請求形態", "請求先", "請求内訳", "率", "検収額", "請求金額", "WORK_TORI_CD", "WORK_SEIKYU_TYPE", "WORK_SQNO", "WORK_INITIAL", text, syoriym.ToString("yyyy/MM/01")})
		End Function

		Private Function makeBodyTable(dataRows As DataRow(), seikyuType As String) As DataTable
			Dim text As String = ""
			Dim num As Long = 0L
			Dim num2 As Long = 0L
			Dim num3 As Long = 0L
			Dim num4 As Long = 0L
			Dim num5 As Integer = 0
			Dim dataTable As DataTable = Me.BodyTable.Clone()
			Dim num6 As Integer = 0
			Dim num7 As Integer = dataRows.Count() - 1
			For i As Integer = num6 To num7
				Dim text2 As String = dataRows(i)("WORK_TORI_CD").ToString()
				If Operators.ConditionalCompareObjectGreaterEqual(dataRows(i)("WORK_SQNO"), 1000, False) Then
					num5 = i
					Dim left As Object = dataRows(i)("WORK_SQNO")
					If Operators.ConditionalCompareObjectEqual(left, 1000, False) Then
						num = Conversions.ToLong(Operators.AddObject(num, dataRows(i)("請求金額")))
					ElseIf Operators.ConditionalCompareObjectEqual(left, 1001, False) Then
						num2 = Conversions.ToLong(Operators.AddObject(num2, dataRows(i)("請求金額")))
					ElseIf Operators.ConditionalCompareObjectEqual(left, 1002, False) Then
						num3 = Conversions.ToLong(Operators.AddObject(num3, dataRows(i)("請求金額")))
					ElseIf Operators.ConditionalCompareObjectEqual(left, 1003, False) Then
						num4 = Conversions.ToLong(Operators.AddObject(num4, dataRows(i)("請求金額")))
					End If
				ElseIf Not text.Equals(text2) Or Regex.IsMatch(Conversions.ToString(dataRows(i)("請求内訳")), "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．") Then
					num5 = i
					If text.Equals(text2) Then
						dataRows(i)("請求先") = DBNull.Value
						If seikyuType.Equals("％") Then
							dataRows(i)("率") = DBNull.Value
						End If
					End If
					If Regex.IsMatch(Conversions.ToString(dataRows(i)("請求内訳")), "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．") Then
						dataRows(i)("WORK_INITIAL") = dataRows(i)("請求内訳").ToString().Substring(0, 2)
						dataRows(i)("請求内訳") = dataRows(i)("請求内訳").ToString().Remove(0, 2)
					Else
						dataRows(i)("請求内訳") = ""
					End If
				End If
				If Not Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRows(i)("請求内訳"), "", False), Operators.CompareObjectEqual(dataRows(i)("請求金額"), 0, False))) Then
					If num5 = i Then
						dataTable.ImportRow(dataRows(i))
					Else
						dataTable.Rows(dataTable.Rows.Count - 1)("請求金額") = Operators.AddObject(dataTable.Rows(dataTable.Rows.Count - 1)("請求金額"), dataRows(i)("請求金額"))
						If seikyuType.Equals("％") Then
							dataTable.Rows(dataTable.Rows.Count - 1)("検収額") = Operators.AddObject(dataTable.Rows(dataTable.Rows.Count - 1)("検収額"), dataRows(i)("検収額"))
						End If
					End If
					text = text2
				End If
			Next
			Dim format As String = "Sum({0})"
			Dim format2 As String = "{0} = '{1}'"
			Dim flag As Boolean = True
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "１．")))
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "１．")))
			Dim dataRow As DataRow
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "納入代行作業料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "２．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "２．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "構内作業料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "３．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "３．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "物流加工作業料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "４．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "４．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "貨物運送料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "５．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "５．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "倉庫保管料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "６．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "６．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "輸出倉庫作業料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "７．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "７．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "輸入倉庫作業料"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "８．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "８．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "その他８"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
				flag = False
			End If
			objectValue = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "請求金額"), String.Format(format2, "WORK_INITIAL", "９．")))
			objectValue2 = RuntimeHelpers.GetObjectValue(dataTable.Compute(String.Format(format, "検収額"), String.Format(format2, "WORK_INITIAL", "９．")))
			If Not IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				dataRow = dataTable.NewRow()
				dataRow("請求形態") = seikyuType
				dataRow("請求内訳") = "その他９"
				dataRow("請求金額") = RuntimeHelpers.GetObjectValue(objectValue)
				dataRow("検収額") = RuntimeHelpers.GetObjectValue(objectValue2)
				dataTable.Rows.Add(dataRow)
				If flag Then
					dataRow("請求先") = "計"
				End If
			End If
			dataRow = dataTable.NewRow()
			dataRow("請求形態") = seikyuType
			dataRow("請求内訳") = "課税"
			dataRow("請求金額") = num
			dataTable.Rows.Add(dataRow)
			dataRow = dataTable.NewRow()
			dataRow("請求形態") = seikyuType
			dataRow("請求内訳") = "非課税"
			dataRow("請求金額") = num2
			dataTable.Rows.Add(dataRow)
			dataRow = dataTable.NewRow()
			dataRow("請求形態") = seikyuType
			dataRow("請求内訳") = "消費税"
			dataRow("請求金額") = num3
			dataTable.Rows.Add(dataRow)
			dataRow = dataTable.NewRow()
			dataRow("請求形態") = seikyuType
			dataRow("請求内訳") = "合計"
			dataRow("請求金額") = num4
			dataTable.Rows.Add(dataRow)
			Return dataTable
		End Function

		Private Function makeCsvTable(syoriym As DateTime) As DataTable
			Dim dataTable As New DataTable()
			dataTable.Columns.Add("年月", GetType(String))
			dataTable.Columns.Add("地区名", GetType(String))
			dataTable.Columns.Add("請求形態", GetType(String))
			dataTable.Columns.Add("取引先コード", GetType(String))
			dataTable.Columns.Add("取引先名称", GetType(String))
			dataTable.Columns.Add("内容", GetType(String))
			dataTable.Columns.Add("手数料率", GetType(String))
			dataTable.Columns.Add("検収金額符号", GetType(String))
			dataTable.Columns.Add("検収金額", GetType(String))
			dataTable.Columns.Add("請求金額符号", GetType(String))
			dataTable.Columns.Add("請求金額", GetType(String))
			Dim value As String = ""
			Try
				For Each obj As Object In Me.BodyTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("請求先"))) Then
						value = Conversions.ToString(dataRow("請求先"))
					End If
					Dim dataRow2 As DataRow = dataTable.NewRow()
					dataRow2("年月") = syoriym.ToString("yyyyMM")
					dataRow2("地区名") = RuntimeHelpers.GetObjectValue(Me.HeaderTable.Rows(0)("地区"))
					dataRow2("請求形態") = RuntimeHelpers.GetObjectValue(dataRow("請求形態"))
					dataRow2("取引先コード") = RuntimeHelpers.GetObjectValue(dataRow("WORK_TORI_CD"))
					dataRow2("取引先名称") = value
					dataRow2("内容") = RuntimeHelpers.GetObjectValue(dataRow("請求内訳"))
					If Not IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("率"))) Then
						dataRow2("手数料率") = String.Format("{0:00000}", Operators.MultiplyObject(dataRow("率"), 100))
					End If
					If Not IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("検収額"))) Then
						If Operators.ConditionalCompareObjectLess(dataRow("検収額"), 0, False) Then
							dataRow2("検収金額符号") = "-"
						End If
						Dim dataRow3 As DataRow = dataRow2
						Dim columnName As String = "検収金額"
						Dim instance As Object = Nothing
						Dim typeFromHandle As Type = GetType(Math)
						Dim memberName As String = "Abs"
						Dim array As Object() = New Object(0) {}
						Dim array2 As Object() = array
						Dim num As Integer = 0
						Dim dataRow4 As DataRow = dataRow
						Dim dataRow5 As DataRow = dataRow4
						Dim columnName2 As String = "検収額"
						array2(num) = RuntimeHelpers.GetObjectValue(dataRow5(columnName2))
						Dim array3 As Object() = array
						Dim arguments As Object() = array3
						Dim argumentNames As String() = Nothing
						Dim typeArguments As Type() = Nothing
						Dim array4 As Boolean() = New Boolean() {True}
						Dim obj2 As Object = NewLateBinding.LateGet(instance, typeFromHandle, memberName, arguments, argumentNames, typeArguments, array4)
						If array4(0) Then
							dataRow4(columnName2) = RuntimeHelpers.GetObjectValue(array3(0))
						End If
						dataRow3(columnName) = RuntimeHelpers.GetObjectValue(obj2)
					End If
					If Not IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("請求金額"))) Then
						If Operators.ConditionalCompareObjectLess(dataRow("請求金額"), 0, False) Then
							dataRow2("請求金額符号") = "-"
						End If
						Dim dataRow6 As DataRow = dataRow2
						Dim columnName3 As String = "請求金額"
						Dim instance2 As Object = Nothing
						Dim typeFromHandle2 As Type = GetType(Math)
						Dim memberName2 As String = "Abs"
						Dim array3 As Object() = New Object(0) {}
						Dim array5 As Object() = array3
						Dim num2 As Integer = 0
						Dim dataRow4 As DataRow = dataRow
						Dim dataRow7 As DataRow = dataRow4
						Dim columnName2 As String = "請求金額"
						array5(num2) = RuntimeHelpers.GetObjectValue(dataRow7(columnName2))
						Dim array As Object() = array3
						Dim arguments2 As Object() = array
						Dim argumentNames2 As String() = Nothing
						Dim typeArguments2 As Type() = Nothing
						Dim array4 As Boolean() = New Boolean() {True}
						Dim obj3 As Object = NewLateBinding.LateGet(instance2, typeFromHandle2, memberName2, arguments2, argumentNames2, typeArguments2, array4)
						If array4(0) Then
							dataRow4(columnName2) = RuntimeHelpers.GetObjectValue(array(0))
						End If
						dataRow6(columnName3) = RuntimeHelpers.GetObjectValue(obj3)
					End If
					dataTable.Rows.Add(dataRow2)
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return dataTable
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("SpecifiedDateLabel")>
		Private WithEvents SpecifiedDateLabel As Label

		<AccessedThroughProperty("OPZ_ClearButton")>
		Private WithEvents OPZ_ClearButton As Button

		<AccessedThroughProperty("OPZ_SelectAllButton")>
		Private WithEvents OPZ_SelectAllButton As Button

		<AccessedThroughProperty("OPZ_BackButton")>
		Private WithEvents OPZ_BackButton As Button

		<AccessedThroughProperty("OPZ_ExecutButton")>
		Private WithEvents OPZ_ExecutButton As Button

		<AccessedThroughProperty("CclDateTimePicker")>
		Private WithEvents CclDateTimePicker As CclDateTimePicker

		<AccessedThroughProperty("UcSelectGridView1")>
		Private WithEvents UcSelectGridView1 As UcSelectGridView

		Private HeaderTable As DataTable

		Private BodyTable As DataTable

		Private Const SEIKYU_KEITAI_1 As String = "個数"

		Private Const SEIKYU_KEITAI_2 As String = "％"

		Private Const REGEX_STRING As String = "^１．|^２．|^３．|^４．|^５．|^６．|^７．|^８．|９．"

		Private Const HEAD_KAISYA As String = "会社名"

		Private Const HEAD_BUSYO As String = "部署"

		Private Const HEAD_TIKU As String = "地区"

		Private Const HEAD_NENGETSU_START As String = "出力年月_開始日"

		Private Const HEAD_NENGETSU_END As String = "出力年月_終了日"

		Private Const BODY_SEIKYU_KEITAI As String = "請求形態"

		Private Const BODY_SEIKYU_SAKI As String = "請求先"

		Private Const BODY_SEIKYU_UTIWAKE As String = "請求内訳"

		Private Const BODY_RITSU As String = "率"

		Private Const BODY_KENSYU_GAKU As String = "検収額"

		Private Const BODY_SEIKYU_GAKU As String = "請求金額"

		Private Const BODY_WORK_TORI_CD As String = "WORK_TORI_CD"

		Private Const BODY_WORK_SEIKYU_KEITAI As String = "WORK_SEIKYU_TYPE"

		Private Const BODY_WORK_SEIKYU_SQNO As String = "WORK_SQNO"

		Private Const BODY_WORK_INITIAL As String = "WORK_INITIAL"

		Private Const CSV_NENGETSU As String = "年月"

		Private Const CSV_TIKU As String = "地区名"

		Private Const CSV_SEIKYU_KEITAI As String = "請求形態"

		Private Const CSV_TORI_CD As String = "取引先コード"

		Private Const CSV_TORI_NAME As String = "取引先名称"

		Private Const CSV_NAIYO As String = "内容"

		Private Const CSV_RITU As String = "手数料率"

		Private Const CSV_KENSYU_GAKU_SIGN As String = "検収金額符号"

		Private Const CSV_KENSYU_GAKU As String = "検収金額"

		Private Const CSV_SEIKYU_GAKU_SIGN As String = "請求金額符号"

		Private Const CSV_SEIKYU_GAKU As String = "請求金額"

		Private csvDirectory As String

		Private csvFileName As String

		Private Sub OPZ_SelectAllButton_Click(sender As Object, e As EventArgs) Handles OPZ_SelectAllButton.Click
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

		Private Sub OPZ_ClearButton_Click(sender As Object, e As EventArgs) Handles OPZ_ClearButton.Click
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

		Private Sub OPZ_ExecutButton_Click(sender As Object, e As EventArgs) Handles OPZ_ExecutButton.Click
			Cursor.Current = Cursors.WaitCursor
			Dim syoriym As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
			If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
				DlgMessageBox.Show("指定年月を指定してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
			Using sqlDataBase As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text As String = Me.makeHeaderSql(syoriym)
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not sqldata.Equals(String.Empty) Then
					Cursor.Current = Cursors.[Default]
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
					Return
				End If
				If sqlDataBase.DbDataTable.Rows.Count = 0 Then
					Cursor.Current = Cursors.[Default]
					DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Return
				End If
				Me.HeaderTable = sqlDataBase.DbDataTable
			End Using
			Using sqlDataBase2 As New SqlDataBase(TopForm.ConfigData.xmlConfData.xDataBase)
				Dim text2 As String = Me.makeBodySql(arrayList, syoriym)
				Dim sqldata2 As String = sqlDataBase2.getSQLData(text2, True)
				If Not sqldata2.Equals(String.Empty) Then
					Cursor.Current = Cursors.[Default]
					DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text2, sqldata2})
					Return
				End If
				If sqlDataBase2.DbDataTable.Rows.Count = 0 Then
					Cursor.Current = Cursors.[Default]
					DlgMessageBox.Show("該当データがありませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Return
				End If
				Me.BodyTable = sqlDataBase2.DbDataTable.Clone()
				Dim array As DataRow() = sqlDataBase2.DbDataTable.[Select]("WORK_SEIKYU_TYPE = '1'")
				If array.Count() > 0 Then
					Dim dataTable As DataTable = Me.makeBodyTable(array, "個数")
					Try
						For Each obj2 As Object In dataTable.Rows
							Dim row As DataRow = CType(obj2, DataRow)
							Me.BodyTable.ImportRow(row)
						Next
					Finally
						Dim enumerator2 As IEnumerator = Nothing
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				End If
				array = sqlDataBase2.DbDataTable.[Select]("WORK_SEIKYU_TYPE = '2'")
				If array.Count() > 0 Then
					Dim dataTable As DataTable = Me.makeBodyTable(array, "％")
					Try
						For Each obj3 As Object In dataTable.Rows
							Dim row2 As DataRow = CType(obj3, DataRow)
							Me.BodyTable.ImportRow(row2)
						Next
					Finally
						Dim enumerator3 As IEnumerator = Nothing
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
				End If
			End Using
			Dim outPutZissekiTableReportForm As New OutPutZissekiTableReportForm(Me.HeaderTable, Me.BodyTable)
			outPutZissekiTableReportForm.Show()
			Dim text3 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
			If Not Directory.Exists(text3) Then
				Directory.CreateDirectory(text3)
			End If
			Dim csvCommon As New CsvCommon()
			Dim flag As Boolean = csvCommon.ConvertDataTableToCsv(Me.makeCsvTable(syoriym), Path.Combine(text3, Me.csvFileName), True)
			Cursor.Current = Cursors.[Default]
			If Not flag Then
				DlgMessageBox.Show(String.Format("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。" & vbCrLf & vbCrLf & "[ファイル名]" & vbCrLf & "{0}", Path.GetFileName(Me.csvFileName)), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		Private Sub OPZ_BackButton_Click(sender As Object, e As EventArgs) Handles OPZ_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
