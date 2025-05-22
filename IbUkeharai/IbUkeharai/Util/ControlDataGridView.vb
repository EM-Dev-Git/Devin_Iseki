Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class ControlDataGridView

		Public ReadOnly Property gridInfo As List(Of gridInfomation)
			Get
				Return Me._gridInfo
			End Get
		End Property

		Public ReadOnly Property dataInfo As SqlDataBase.DataInfomation
			Get
				Return Me._dataInfo
			End Get
		End Property

		Public Sub New(ByRef view As CustomDataGridView, configData As XmlConfigControl)
			Me.colConst = New Dictionary(Of String, columninfo)() From {{"TORI_CD", New columninfo("取引先ｺｰﾄﾞ", 100, 16, "")}, {"TORI_NAME", New columninfo("取引先名", 200, 16, "")}, {"SEIKYU_TYPE", New columninfo("請求形態", 100, 32, "")}, {"RITU", New columninfo("手数料率", 100, 64, "N2")}, {"BUHIN_CD", New columninfo("部品ｺｰﾄﾞ", 130, 32, "aaaa-aaa-aaa-aa")}, {"BUHIN_NAME", New columninfo("部品名称", 200, 16, "")}, {"TANA_NO1", New columninfo("棚番1", 80, 16, "")}, {"TANA_NO2", New columninfo("棚番2", 80, 16, "")}, {"TANA_NO3", New columninfo("棚番3", 80, 16, "")}, {"KIKAKU", New columninfo("規格", 150, 16, "")}, {"TORIHIN_NO", New columninfo("取引先品番", 150, 16, "")}, {"IKISAKI_CD", New columninfo("行先ｺｰﾄﾞ", 100, 16, "")}, {"SAKI_CD", New columninfo("納入先ｺｰﾄﾞ", 80, 32, "")}, {"YUKO_FM", New columninfo("有効日（始）", 130, 32, "yyyy/MM/dd")}, {"YUKO_TO", New columninfo("有効日（終）", 130, 32, "yyyy/MM/dd")}, {"SAGYO", New columninfo("作業料単価", 80, 64, "N2")}, {"SAKI_NAME", New columninfo("納入先名称", 260, 16, "")}, {"SAKI_ABBREVIATION", New columninfo("納入先略称", 120, 16, "")}, {"UKEHARA_YYYYMM", New columninfo("年月", 100, 16, "yyyy年MM月")}, {"ZAIKOSU", New columninfo("在庫数", 100, 64, "")}, {"UKESU", New columninfo("受入個数", 100, 64, "")}, {"HARASU", New columninfo("払出個数", 100, 64, "")}, {"UKEHARA_YYYYMMDD", New columninfo("年月日", 100, 32, "yyyy/MM/dd")}, {"UKEIRE_YYYYMMDD", New columninfo("受入年月日", 100, 32, "yyyy/MM/dd")}, {"HARAI_YYYYMMDD", New columninfo("払出年月日", 100, 32, "yyyy/MM/dd")}, {"DEN_NO", New columninfo("伝票No", 110, 16, "")}, {"UKEHARAI_KBN", New columninfo("受払区分", 100, 16, "")}, {"KOSU", New columninfo("個数", 100, 64, "N0")}, {"REMARKS1", New columninfo("備考1", 100, 16, "")}, {"REMARKS2", New columninfo("備考2", 100, 16, "")}, {"REMARKS3", New columninfo("備考3", 100, 16, "")}, {"KINGAKU", New columninfo("金額", 130, 64, "N0")}, {"SEIKYU_YYYYMM", New columninfo("請求年月", 100, 32, "yyyy年MM月")}, {"SEIKYU_NO", New columninfo("請求書No", 100, 16, "")}, {"SEIKYU_SQNO", New columninfo("No", 40, 64, "N0")}, {"SAKU_KBN", New columninfo("作成区分", 100, 32, "")}, {"UCHIWAKE", New columninfo("請求内訳", 280, 16, "")}, {"TEKIYO", New columninfo("摘要", 220, 16, "")}, {"SURYO", New columninfo("数量", 120, 64, "N0")}, {"TANI", New columninfo("単位", 50, 32, "")}, {"TANKA", New columninfo("単価", 100, 64, "")}, {"KAZEI_KBN", New columninfo("課税区分", 90, 32, "")}, {"MEISAI_UMU", New columninfo("明細有無", 90, 32, "")}, {"KUBUN", New columninfo("区分", 60, 32, "")}, {"ZAIKO", New columninfo("　　　　" & vbCrLf & "在庫数量" & vbCrLf & "(現時点)" & vbCrLf & "　　　　", 65, 64, "N0")}, {"TESU", New columninfo("手数料単価", 80, 64, "N2")}, {"HASU_KBN", New columninfo("端数区分", 70, 32, "")}, {"TEBAN", New columninfo("手番", 40, 64, "N0")}, {"KAKUNIN", New columninfo("確認", 40, 32, "")}, {"LINE", New columninfo("ﾗｲﾝ欠品日", 98, 32, "")}, {"NONYU", New columninfo("納入欠品日", 98, 32, "")}, {"FUSOKU_TOGETU", New columninfo("　　　　" & vbCrLf & "不足数量" & vbCrLf & "　当月　" & vbCrLf & "　　　　", 65, 64, "N0")}, {"FUSOKU_JIGETU", New columninfo("　　　　" & vbCrLf & "不足数量" & vbCrLf & "　次月　" & vbCrLf & "　　　　", 65, 64, "N0")}, {"CYUZAN", New columninfo("　　　　" & vbCrLf & "注残" & vbCrLf & "(当月)" & vbCrLf & "　　　　", 65, 64, "N0")}, {"NOKI", New columninfo("納期", 98, 32, "yyyy/MM/dd")}, {"NYUKABI", New columninfo("物流入荷日", 98, 32, "yyyy/MM/dd")}, {"NOHINSAKI", New columninfo("納品先", 25, 32, "")}, {"END", New columninfo("終了", 100, 16, "")}}
			Me._TableName = String.Empty
			Me._itemComb = New List(Of String)() From {"", "追加", "変更", "削除"}
			Me._dbSql = String.Empty
			Me.listOfHidden = New List(Of String)()
			Me.listOfKey = New List(Of String)()
			Me._dataGridView = view
			Me._configData = configData
			Me._dataGridView.Init()
			Me.initialize()
		End Sub

		Private Sub initialize()
			Me._gridInfo = New List(Of gridInfomation)()
		End Sub

		Public Sub RowAdd(Optional key As Dictionary(Of String, Object) = Nothing, Optional flg As Boolean = False)
			If Me._dataGridView Is Nothing Then
				Return
			End If
			Dim num As Integer
			If flg Then
				num = Me._dataGridView.RowCount
			ElseIf Me._dataGridView.CurrentRow Is Nothing Then
				num = Me._dataGridView.RowCount
			Else
				' The following expression was wrapped in a checked-expression
				num = Me._dataGridView.CurrentCell.RowIndex + 1
			End If
			Try
				Me._dataGridView.Rows.Insert(num, New Object(-1) {})
				Me._dataGridView.IsChanged = True
				Me._dataGridView.Rows(num).Height = 25
				Me.setCellData(num, key)
				Me._dataGridView.CurrentCell = Me._dataGridView.Rows(num).Cells(0)
			Catch ex As Exception
				OutputLog.WriteLine("RowAdd Error!! : " + ex.Message)
			End Try
		End Sub

		Private Sub setCellData(rowIndex As Integer, key As Dictionary(Of String, Object))
			Try
				For Each obj As Object In Me._dataGridView.Columns
					Dim dataGridViewColumn As DataGridViewColumn = CType(obj, DataGridViewColumn)
					If "KUBUN".Equals(dataGridViewColumn.Name) Then
						Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me._dataGridView.Rows(rowIndex).Cells("KUBUN"), DataGridViewComboBoxCell)
						dataGridViewComboBoxCell.Items.Clear()
						dataGridViewComboBoxCell.Items.Add("追加")
						dataGridViewComboBoxCell.Value = "追加"
					ElseIf key IsNot Nothing Then
						If key.ContainsKey(dataGridViewColumn.Name) Then
							Me._dataGridView.Rows(rowIndex).Cells(dataGridViewColumn.Name).Value = RuntimeHelpers.GetObjectValue(key(dataGridViewColumn.Name))
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

		Public Sub ResetRowNumber(numName As String)
			If String.IsNullOrEmpty(numName) Then
				Return
			End If
			Dim num As Integer = 0
			Try
				For Each obj As Object In CType(Me._dataGridView.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					num += 1
					dataGridViewRow.Cells(numName).Value = New Decimal(num)
				Next
			Finally
				Dim enumerator As IEnumerator = Nothing
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Public Function DisplayGridView(sql As String, Optional iHeight As Integer = 0) As Boolean
			Me._dbSql = sql
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				sqlDataBase.ListOfHidden = Me.listOfHidden
				Dim sqldata As String = sqlDataBase.getSQLData(Me._dbSql, False)
				If String.IsNullOrEmpty(sqldata) Then
					Me.getTableName(Me._dbSql)
					Me._dataInfo = sqlDataBase.DbData
					Try
						Me.display(iHeight)
						Me._dataGridView.Init()
						Me._dataGridView.UpdateRows()
						Return True
					Catch ex As Exception
						DlgMessageBox.Show("グリッド表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End If
				DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。" & vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Using
			Return True
		End Function

		Private Function ExecData(sql As String) As Boolean
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Try
					sqlDataBase.BeginTransaction()
					If Not sqlDataBase.execSql(sql) Then
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + sql, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End If
					sqlDataBase.CommitTransact()
				Catch ex As Exception
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End Try
			End Using
			Return True
		End Function

		Private Function getJissekiTable(uWhere As List(Of sqlWork)) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim text As String = String.Empty
			If uWhere.Count > 0 Then
				text = " WHERE "
				Try
					For Each sqlWork As sqlWork In uWhere
						If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
							text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Dim text2 As String = "SELECT ZAIKOSU, UKESU, HARASU FROM Ukeharai.T_UKEHARAIJISSEKI"
			text2 += text
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text2, False)
				If String.IsNullOrEmpty(sqldata) Then
					If sqlDataBase.DbData.DataList.Count = 1 Then
						result = sqlDataBase.DbData.DataList(0)
					End If
				Else
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text2 + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
			End Using
			Return result
		End Function

		Private Function getMeisaiTable(uWhere As List(Of sqlWork)) As Dictionary(Of String, Object)
			Dim result As New Dictionary(Of String, Object)()
			Dim text As String = String.Empty
			If uWhere.Count > 0 Then
				text = " WHERE "
				Try
					For Each sqlWork As sqlWork In uWhere
						If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
							text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Dim text2 As String = "SELECT KOSU FROM Ukeharai.T_UKEHARAIMEISAI"
			text2 += text
			Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(text2, False)
				If String.IsNullOrEmpty(sqldata) Then
					If sqlDataBase.DbData.DataList.Count = 1 Then
						result = sqlDataBase.DbData.DataList(0)
					End If
				Else
					DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text2 + vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
			End Using
			Return result
		End Function

		Private Function objToLong(obj As Object) As Long
			Dim result As Long = 0L
			Long.TryParse(Conversions.ToString(obj), result)
			Return result
		End Function

		Private Function ExecDataJisseki(uSet As List(Of sqlWork), uWhere As List(Of sqlWork), kbn As String) As Boolean
			Dim result As Boolean = False
			Dim text As String = String.Empty
			Dim dictionary As New Dictionary(Of String, Object)()
			If "INS".Equals(kbn) Then
				text = Me.MakeSqlInsert(uSet)
				Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase.BeginTransaction()
						If Not sqlDataBase.execSql(text) Then
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return result
						End If
						Dim list As New List(Of sqlWork)()
						Dim list2 As New List(Of sqlWork)()
						Dim v As String = String.Empty
						Dim v2 As String = String.Empty
						Dim text2 As String = String.Empty
						Dim value As String = String.Empty
						Dim num As Long = 0L
						Dim num2 As Long = 0L
						Try
							For Each sqlWork As sqlWork In uSet
								If "UKEHARAI_KBN".Equals(sqlWork.name) Then
									value = sqlWork.value
									Exit For
								End If
							Next
						Finally
							Dim enumerator As List(Of sqlWork).Enumerator = Nothing
							CType(enumerator, IDisposable).Dispose()
						End Try
						Try
							For Each sqlWork2 As sqlWork In uSet
								If "TORI_CD".Equals(sqlWork2.name) Then
									v = sqlWork2.value
								ElseIf "BUHIN_CD".Equals(sqlWork2.name) Then
									v2 = sqlWork2.value
								ElseIf "UKEHARA_YYYYMMDD".Equals(sqlWork2.name) Then
									text2 = Conversions.ToDate(sqlWork2.value).ToString("yyyy/MM/01")
								ElseIf "KOSU".Equals(sqlWork2.name) Then
									If "1".Equals(value) Then
										num = Me.objToLong(sqlWork2.value)
										Exit For
									End If
									If "2".Equals(value) Then
										num2 = Me.objToLong(sqlWork2.value)
										Exit For
									End If
									Exit For
								End If
							Next
						Finally
							Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
							CType(enumerator2, IDisposable).Dispose()
						End Try
						list2.Add(New sqlWork("TORI_CD", v, GetType(String), Nothing))
						list2.Add(New sqlWork("BUHIN_CD", v2, GetType(String), Nothing))
						list2.Add(New sqlWork("UKEHARA_YYYYMM", text2, GetType(DateTime), Nothing))
						dictionary = Me.getJissekiTable(list2)
						If dictionary Is Nothing Then
							Return False
						End If
						If dictionary.Count <= 0 Then
							DlgMessageBox.Show("該当の受払実績テーブルが存在なしのため更新できませんでした。" + text2, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return False
						End If
						Dim num3 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("UKESU")))
						Dim num4 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("HARASU")))
						num3 += num
						num4 += num2
						list.Add(New sqlWork("UKESU", Conversions.ToString(num3), GetType(Long), Nothing))
						list.Add(New sqlWork("HARASU", Conversions.ToString(num4), GetType(Long), Nothing))
						text = Me.MakeSqlUpdateJisseki(list, list2)
						If sqlDataBase.execSql(text) Then
							sqlDataBase.CommitTransact()
							Return True
						End If
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return result
					Catch ex As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			If "UPD".Equals(kbn) Then
				Dim text3 As String = String.Empty
				Dim text4 As String = String.Empty
				Dim text5 As String = String.Empty
				Dim text6 As String = String.Empty
				Dim text7 As String = String.Empty
				Dim text8 As String = String.Empty
				Dim num5 As Long = 0L
				Dim num6 As Long = 0L
				Dim num7 As Long = 0L
				Dim num8 As Long = 0L
				Dim value2 As String = String.Empty
				Try
					For Each sqlWork3 As sqlWork In uWhere
						If "TORI_CD".Equals(sqlWork3.name) Then
							text3 = sqlWork3.value
							text6 = Conversions.ToString(sqlWork3.cmpValue)
						ElseIf "BUHIN_CD".Equals(sqlWork3.name) Then
							text4 = sqlWork3.value
							text7 = Conversions.ToString(sqlWork3.cmpValue)
						ElseIf "UKEHARA_YYYYMMDD".Equals(sqlWork3.name) Then
							text5 = Conversions.ToDate(sqlWork3.value).ToString("yyyy/MM/01")
							text8 = Conversions.ToDate(sqlWork3.cmpValue).ToString("yyyy/MM/01")
						ElseIf "UKEHARAI_KBN".Equals(sqlWork3.name) Then
							value2 = sqlWork3.value
							Exit For
						End If
					Next
				Finally
					Dim enumerator3 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator3, IDisposable).Dispose()
				End Try
				dictionary = Me.getMeisaiTable(uWhere)
				If dictionary Is Nothing Then
					Return False
				End If
				If dictionary.Count <= 0 Then
					DlgMessageBox.Show("該当の受払明細テーブルが存在しないため更新できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				If "1".Equals(value2) Then
					num5 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("KOSU")))
				ElseIf "2".Equals(value2) Then
					num7 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("KOSU")))
				End If
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Try
					For Each sqlWork4 As sqlWork In uSet
						If "TORI_CD".Equals(sqlWork4.name) Then
							text6 = sqlWork4.value
							flag = True
						ElseIf "BUHIN_CD".Equals(sqlWork4.name) Then
							text7 = sqlWork4.value
							flag = True
						ElseIf "UKEHARA_YYYYMMDD".Equals(sqlWork4.name) Then
							text8 = Conversions.ToDate(sqlWork4.value).ToString("yyyy/MM/01")
							flag = True
						ElseIf "KOSU".Equals(sqlWork4.name) Then
							If "1".Equals(value2) Then
								num6 = Me.objToLong(sqlWork4.value)
							ElseIf "2".Equals(value2) Then
								num8 = Me.objToLong(sqlWork4.value)
							End If
							flag2 = True
						End If
					Next
				Finally
					Dim enumerator4 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator4, IDisposable).Dispose()
				End Try
				If text6.Equals(text3) AndAlso text7.Equals(text4) AndAlso text8.Equals(text5) Then
					flag = False
				End If
				text = Me.MakeSqlUpdate(uSet, uWhere)
				Using sqlDataBase2 As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase2.BeginTransaction()
						If sqlDataBase2.execSql(text) Then
							Dim list3 As New List(Of sqlWork)()
							Dim list4 As New List(Of sqlWork)()
							If flag Then
								list4.Add(New sqlWork("TORI_CD", text3, GetType(String), Nothing))
								list4.Add(New sqlWork("BUHIN_CD", text4, GetType(String), Nothing))
								list4.Add(New sqlWork("UKEHARA_YYYYMM", text5, GetType(DateTime), Nothing))
								dictionary = Me.getJissekiTable(list4)
								If dictionary Is Nothing Then
									Return False
								End If
								If dictionary.Count <= 0 Then
									DlgMessageBox.Show("該当の受払実績テーブルが存在しないため更新できませんでした。" + text5, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Return False
								End If
								Dim num9 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("UKESU")))
								Dim num10 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("HARASU")))
								num9 -= num5
								num10 -= num7
								list3.Clear()
								list3.Add(New sqlWork("UKESU", Conversions.ToString(num9), GetType(Long), Nothing))
								list3.Add(New sqlWork("HARASU", Conversions.ToString(num10), GetType(Long), Nothing))
								text = Me.MakeSqlUpdateJisseki(list3, list4)
								If Not sqlDataBase2.execSql(text) Then
									DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Return result
								End If
								list4.Clear()
								list4.Add(New sqlWork("TORI_CD", Conversions.ToString(Interaction.IIf(String.IsNullOrEmpty(text6), text3, text6)), GetType(String), Nothing))
								list4.Add(New sqlWork("BUHIN_CD", Conversions.ToString(Interaction.IIf(String.IsNullOrEmpty(text7), text4, text7)), GetType(String), Nothing))
								list4.Add(New sqlWork("UKEHARA_YYYYMM", Conversions.ToString(Interaction.IIf(String.IsNullOrEmpty(text8), text5, text8)), GetType(DateTime), Nothing))
								dictionary = Me.getJissekiTable(list4)
								If dictionary Is Nothing Then
									Return False
								End If
								If dictionary.Count <= 0 Then
									DlgMessageBox.Show("該当の受払実績テーブルが存在しないため更新できませんでした。" + text5, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Return False
								End If
								num9 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("UKESU")))
								num10 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("HARASU")))
								num9 += num5
								num10 += num7
								list3.Clear()
								list3.Add(New sqlWork("UKESU", Conversions.ToString(num9), GetType(Long), Nothing))
								list3.Add(New sqlWork("HARASU", Conversions.ToString(num10), GetType(Long), Nothing))
								text = Me.MakeSqlUpdateJisseki(list3, list4)
								If Not sqlDataBase2.execSql(text) Then
									DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Return result
								End If
								sqlDataBase2.CommitTransact()
							Else
								If flag2 Then
									list4.Add(New sqlWork("TORI_CD", text3, GetType(String), Nothing))
									list4.Add(New sqlWork("BUHIN_CD", text4, GetType(String), Nothing))
									list4.Add(New sqlWork("UKEHARA_YYYYMM", text5, GetType(DateTime), Nothing))
									dictionary = Me.getJissekiTable(list4)
									If dictionary Is Nothing Then
										Return False
									End If
									If dictionary.Count <= 0 Then
										DlgMessageBox.Show("該当の受払実績テーブルが存在しないため更新できませんでした。" + text5, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Return False
									End If
									Dim num9 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("UKESU")))
									Dim num10 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("HARASU")))
									num9 += num6 - num5
									num10 += num8 - num7
									list3.Add(New sqlWork("UKESU", Conversions.ToString(num9), GetType(Long), Nothing))
									list3.Add(New sqlWork("HARASU", Conversions.ToString(num10), GetType(Long), Nothing))
									text = Me.MakeSqlUpdateJisseki(list3, list4)
									If Not sqlDataBase2.execSql(text) Then
										DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Return result
									End If
								End If
								sqlDataBase2.CommitTransact()
							End If
							Return True
						End If
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return result
					Catch ex2 As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex2.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			If "DEL".Equals(kbn) Then
				Dim v3 As String = String.Empty
				Dim v4 As String = String.Empty
				Dim text9 As String = String.Empty
				Dim num11 As Long = 0L
				Dim num12 As Long = 0L
				Dim value3 As String = String.Empty
				Try
					For Each sqlWork5 As sqlWork In uWhere
						If "TORI_CD".Equals(sqlWork5.name) Then
							v3 = sqlWork5.value
						ElseIf "BUHIN_CD".Equals(sqlWork5.name) Then
							v4 = sqlWork5.value
						ElseIf "UKEHARA_YYYYMMDD".Equals(sqlWork5.name) Then
							text9 = Conversions.ToDate(sqlWork5.value).ToString("yyyy/MM/01")
						ElseIf "UKEHARAI_KBN".Equals(sqlWork5.name) Then
							value3 = sqlWork5.value
							Exit For
						End If
					Next
				Finally
					Dim enumerator5 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator5, IDisposable).Dispose()
				End Try
				dictionary = Me.getMeisaiTable(uWhere)
				If dictionary Is Nothing Then
					Return False
				End If
				If dictionary.Count <= 0 Then
					DlgMessageBox.Show("該当の受払明細テーブルが存在なしのため削除できませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
				If "1".Equals(value3) Then
					num11 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("KOSU")))
				ElseIf "2".Equals(value3) Then
					num12 = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("KOSU")))
				End If
				text = Me.MakeSqlDelete(uWhere)
				Using sqlDataBase3 As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase3.BeginTransaction()
						If sqlDataBase3.execSql(text) Then
							Dim list5 As New List(Of sqlWork)()
							Dim list6 As New List(Of sqlWork)()
							list6.Add(New sqlWork("TORI_CD", v3, GetType(String), Nothing))
							list6.Add(New sqlWork("BUHIN_CD", v4, GetType(String), Nothing))
							list6.Add(New sqlWork("UKEHARA_YYYYMM", text9, GetType(DateTime), Nothing))
							dictionary = Me.getJissekiTable(list6)
							If dictionary Is Nothing Then
								Return False
							End If
							If dictionary.Count <= 0 Then
								DlgMessageBox.Show("該当の受払実績テーブルが存在なしのため更新できませんでした。" + text9, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Return False
							End If
							Dim num13 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("UKESU")))
							Dim num14 As Long = Me.objToLong(RuntimeHelpers.GetObjectValue(dictionary("HARASU")))
							num13 -= num11
							num14 -= num12
							list5.Add(New sqlWork("UKESU", Conversions.ToString(num13), GetType(Long), Nothing))
							list5.Add(New sqlWork("HARASU", Conversions.ToString(num14), GetType(Long), Nothing))
							text = Me.MakeSqlUpdateJisseki(list5, list6)
							If sqlDataBase3.execSql(text) Then
								sqlDataBase3.CommitTransact()
								result = True
							Else
								DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							End If
						Else
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End If
					Catch ex3 As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex3.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			Return result
		End Function

		Private Function ExecDataBuhin(uSet As List(Of sqlWork), uWhere As List(Of sqlWork), kbn As String) As Boolean
			Dim result As Boolean = False
			Dim text As String = String.Empty
			Dim dictionary As New Dictionary(Of String, Object)()
			If "INS".Equals(kbn) Then
				text = Me.MakeSqlInsert(uSet)
				Using sqlDataBase As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase.BeginTransaction()
						If Not sqlDataBase.execSql(text) Then
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return result
						End If
						Dim list As New List(Of sqlWork)()
						Dim v As String = String.Empty
						Dim v2 As String = String.Empty
						Dim str As String = String.Empty
						Try
							For Each sqlWork As sqlWork In uSet
								If "TORI_CD".Equals(sqlWork.name) Then
									v = sqlWork.value
								ElseIf "BUHIN_CD".Equals(sqlWork.name) Then
									v2 = sqlWork.value
									Exit For
								End If
							Next
						Finally
							Dim enumerator As List(Of sqlWork).Enumerator = Nothing
							CType(enumerator, IDisposable).Dispose()
						End Try
						' 2023/06/26 部品登録時、実績データが存在するためエラー対応 ↓ START
						' 実績データを確認
						Dim count As Integer = 0
						list.Clear()
						list.Add(New sqlWork("TORI_CD", v, GetType(String), Nothing))
						list.Add(New sqlWork("BUHIN_CD", v2, GetType(String), Nothing))
						text = Me.MakeSqlCountJisseki(list)
						If Not String.IsNullOrEmpty(sqlDataBase.getSQLData(text, False)) Then
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return result
						End If
						count = Conversions.ToInteger(sqlDataBase.DbData.DataList(0)("COUNT"))
						If count > 0 Then
							' 実績データを削除
							text = Me.MakeSqlDeleteJisseki(list)
							If Not sqlDataBase.execSql(text) Then
								DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Return result
							End If
						End If
						' 明細データを確認
						count = 0
						list.Clear()
						list.Add(New sqlWork("TORI_CD", v, GetType(String), Nothing))
						list.Add(New sqlWork("BUHIN_CD", v2, GetType(String), Nothing))
						text = Me.MakeSqlCountMeisai(list)
						If Not String.IsNullOrEmpty(sqlDataBase.getSQLData(text, False)) Then
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return result
						End If
						count = Conversions.ToInteger(sqlDataBase.DbData.DataList(0)("COUNT"))
						If count > 0 Then
							' 明細データを削除
							text = Me.MakeSqlDeleteMeisai(list)
							If Not sqlDataBase.execSql(text) Then
								DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Return result
							End If
						End If
						' 2023/06/26 部品登録時、実績データが存在するためエラー対応 ↑ END

						text = "SELECT NENGETSU FROM Ukeharai.T_HIZUKE"
						If Not String.IsNullOrEmpty(sqlDataBase.getSQLData(text, False)) Then
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return False
						End If
						str = Conversions.ToDate(sqlDataBase.DbData.DataList(0)("NENGETSU")).ToString("yyyy")
						Dim num As Integer = 1
						While True
							Dim v3 As String = str + "/" + num.ToString("00") + "/01"
							list.Clear()
							list.Add(New sqlWork("TORI_CD", v, GetType(String), Nothing))
							list.Add(New sqlWork("BUHIN_CD", v2, GetType(String), Nothing))
							list.Add(New sqlWork("UKEHARA_YYYYMM", v3, GetType(DateTime), Nothing))
							list.Add(New sqlWork("ZAIKOSU", Conversions.ToString(0), GetType(Decimal), Nothing))
							list.Add(New sqlWork("UKESU", Conversions.ToString(0), GetType(Decimal), Nothing))
							list.Add(New sqlWork("HARASU", Conversions.ToString(0), GetType(Decimal), Nothing))
							text = Me.MakeSqlInsertJisseki(list)
							If Not sqlDataBase.execSql(text) Then
								Exit While
							End If
							num += 1
							If num > 12 Then
								GoTo Block_13
							End If
						End While
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return result
Block_13:
						sqlDataBase.CommitTransact()
						Return True
					Catch ex As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			If "UPD".Equals(kbn) Then
				text = Me.MakeSqlUpdate(uSet, uWhere)
				Using sqlDataBase2 As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase2.BeginTransaction()
						If sqlDataBase2.execSql(text) Then
							sqlDataBase2.CommitTransact()
							Return True
						End If
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return result
					Catch ex2 As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex2.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			If "DEL".Equals(kbn) Then
				text = Me.MakeSqlDelete(uWhere)
				Using sqlDataBase3 As New SqlDataBase(Me._configData.xmlConfData.xDataBase)
					Try
						sqlDataBase3.BeginTransaction()
						If sqlDataBase3.execSql(text) Then
							Dim list2 As New List(Of sqlWork)()
							Dim v4 As String = String.Empty
							Dim v5 As String = String.Empty
							Dim empty As String = String.Empty
							Try
								For Each sqlWork2 As sqlWork In uWhere
									If "TORI_CD".Equals(sqlWork2.name) Then
										v4 = sqlWork2.value
									ElseIf "BUHIN_CD".Equals(sqlWork2.name) Then
										v5 = sqlWork2.value
										Exit For
									End If
								Next
							Finally
								Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
								CType(enumerator2, IDisposable).Dispose()
							End Try
							list2.Clear()
							list2.Add(New sqlWork("TORI_CD", v4, GetType(String), Nothing))
							list2.Add(New sqlWork("BUHIN_CD", v5, GetType(String), Nothing))
							text = Me.MakeSqlDeleteJisseki(list2)
							If sqlDataBase3.execSql(text) Then
								list2.Clear()
								list2.Add(New sqlWork("TORI_CD", v4, GetType(String), Nothing))
								list2.Add(New sqlWork("BUHIN_CD", v5, GetType(String), Nothing))
								text = Me.MakeSqlDeleteMeisai(list2)
								If sqlDataBase3.execSql(text) Then
									sqlDataBase3.CommitTransact()
									result = True
								Else
									DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								End If
							Else
								DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							End If
						Else
							DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End If
					Catch ex3 As Exception
						DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf + ex3.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return False
					End Try
				End Using
			End If
			Return result
		End Function

		Private Sub display(Optional ByRef iHeight As Integer = 0)
			If Me._dataGridView Is Nothing Then
				Return
			End If
			Me._dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			If iHeight > 0 Or Me._dataGridView.ColumnHeadersHeight > 28 Then
				Me._dataGridView.ColumnHeadersHeight = 63
			Else
				Me._dataGridView.ColumnHeadersHeight = 28
			End If
			If Not Me.makeGridInfo() Then
				Return
			End If
			Me._dataGridView.DataSource = Nothing
			Me._dataGridView.Rows.Clear()
			Me._dataGridView.Columns.Clear()
			Me._dataGridView.AllowUserToAddRows = False
			Dim list As New List(Of DataGridViewColumn)()
			Dim font As New Font("ＭＳ Ｐゴシック", 9.5F)
			Dim lightGoldenrodYellow As Color = Color.LightGoldenrodYellow
			Dim gradientInactiveCaption As Color = SystemColors.GradientInactiveCaption
			Dim font2 As New Font("ＭＳ Ｐゴシック", 9.5F)
			Try
				For Each gridInfomation As gridInfomation In Me._gridInfo
					If "KUBUN".Equals(gridInfomation.colKeyName) Then
						Dim dataGridViewComboBoxColumn As New DataGridViewComboBoxColumn()
						dataGridViewComboBoxColumn.DataPropertyName = gridInfomation.colKeyName
						dataGridViewComboBoxColumn.Name = gridInfomation.colKeyName
						dataGridViewComboBoxColumn.HeaderText = gridInfomation.colLogicName
						dataGridViewComboBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
						dataGridViewComboBoxColumn.HeaderCell.Style.Font = font
						dataGridViewComboBoxColumn.ValueMember = "value"
						dataGridViewComboBoxColumn.DisplayMember = "name"
						dataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
						dataGridViewComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic
						Try
							For Each text As String In Me._itemComb
								If Not "追加".Equals(text) Then
									dataGridViewComboBoxColumn.Items.Add(text.ToString())
								End If
							Next
						Finally
							Dim enumerator2 As List(Of String).Enumerator = Nothing
							CType(enumerator2, IDisposable).Dispose()
						End Try
						dataGridViewComboBoxColumn.Width = gridInfomation.colWidth
						dataGridViewComboBoxColumn.DefaultCellStyle.Alignment = gridInfomation.colAlignment
						dataGridViewComboBoxColumn.DefaultCellStyle.Font = font2
						list.Add(dataGridViewComboBoxColumn)
					ElseIf gridInfomation.colType Is GetType(DateTime) Then
						Dim calendarColumn As New CalendarColumn(gridInfomation.colFormat)
						calendarColumn.DataPropertyName = gridInfomation.colKeyName
						calendarColumn.Name = gridInfomation.colKeyName
						calendarColumn.HeaderText = gridInfomation.colLogicName
						calendarColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
						calendarColumn.SortMode = DataGridViewColumnSortMode.Automatic
						calendarColumn.HeaderCell.Style.Font = font
						If gridInfomation.colIsKey Or gridInfomation.colIsHissu Then
							calendarColumn.HeaderCell.Style.BackColor = lightGoldenrodYellow
						End If
						calendarColumn.Width = gridInfomation.colWidth
						calendarColumn.DefaultCellStyle.Format = gridInfomation.colFormat
						calendarColumn.StyleFormat = gridInfomation.colFormat
						calendarColumn.DefaultCellStyle.Alignment = gridInfomation.colAlignment
						calendarColumn.DefaultCellStyle.Font = font2
						If Operators.CompareString(calendarColumn.Name, "NYUKABI", False) = 0 Then
							calendarColumn.[ReadOnly] = False
							gridInfomation.colIsReadOnly = False
						ElseIf Operators.CompareString(calendarColumn.Name, "LINE", False) = 0 Then
							calendarColumn.DefaultCellStyle.ForeColor = Color.Red
							calendarColumn.[ReadOnly] = gridInfomation.colIsReadOnly
						Else
							calendarColumn.[ReadOnly] = gridInfomation.colIsReadOnly
						End If
						If gridInfomation.colIsReadOnly Then
							calendarColumn.DefaultCellStyle.BackColor = gradientInactiveCaption
						End If
						calendarColumn.Visible = Not gridInfomation.colIsHidden
						list.Add(calendarColumn)
					ElseIf gridInfomation.colType Is GetType(String) Then
						If String.IsNullOrEmpty(gridInfomation.colFormat) Then
							If Operators.CompareString(gridInfomation.colKeyName, "KAKUNIN", False) = 0 Then
								Dim dataGridViewCheckBoxColumn As New DataGridViewCheckBoxColumn()
								dataGridViewCheckBoxColumn.DataPropertyName = gridInfomation.colKeyName
								dataGridViewCheckBoxColumn.Name = gridInfomation.colKeyName
								dataGridViewCheckBoxColumn.HeaderText = gridInfomation.colLogicName
								dataGridViewCheckBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
								dataGridViewCheckBoxColumn.HeaderCell.Style.Font = font
								If gridInfomation.colIsKey Or gridInfomation.colIsHissu Then
									dataGridViewCheckBoxColumn.HeaderCell.Style.BackColor = lightGoldenrodYellow
								End If
								dataGridViewCheckBoxColumn.Width = gridInfomation.colWidth
								dataGridViewCheckBoxColumn.DefaultCellStyle.Format = gridInfomation.colFormat
								dataGridViewCheckBoxColumn.DefaultCellStyle.Alignment = gridInfomation.colAlignment
								dataGridViewCheckBoxColumn.DefaultCellStyle.Font = font2
								dataGridViewCheckBoxColumn.[ReadOnly] = True

								dataGridViewCheckBoxColumn.Visible = Not gridInfomation.colIsHidden
								list.Add(dataGridViewCheckBoxColumn)
							Else
								Dim dataGridViewTextBoxColumn As New DataGridViewTextBoxColumn()
								dataGridViewTextBoxColumn.DataPropertyName = gridInfomation.colKeyName
								dataGridViewTextBoxColumn.Name = gridInfomation.colKeyName
								dataGridViewTextBoxColumn.HeaderText = gridInfomation.colLogicName
								dataGridViewTextBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
								dataGridViewTextBoxColumn.HeaderCell.Style.Font = font
								If gridInfomation.colIsKey Or gridInfomation.colIsHissu Then
									dataGridViewTextBoxColumn.HeaderCell.Style.BackColor = lightGoldenrodYellow
								End If
								dataGridViewTextBoxColumn.MaxInputLength = gridInfomation.colLength
								dataGridViewTextBoxColumn.Width = gridInfomation.colWidth
								dataGridViewTextBoxColumn.DefaultCellStyle.Format = gridInfomation.colFormat
								dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = gridInfomation.colAlignment
								dataGridViewTextBoxColumn.DefaultCellStyle.Font = font2
								dataGridViewTextBoxColumn.[ReadOnly] = gridInfomation.colIsReadOnly
								If gridInfomation.colIsReadOnly Then
									dataGridViewTextBoxColumn.DefaultCellStyle.BackColor = gradientInactiveCaption
								End If
								dataGridViewTextBoxColumn.Visible = Not gridInfomation.colIsHidden
								list.Add(dataGridViewTextBoxColumn)
							End If
						Else
							Dim dataGridViewMaskedTextBoxColumn As New DataGridViewMaskedTextBoxColumn()
							dataGridViewMaskedTextBoxColumn.DataPropertyName = gridInfomation.colKeyName
							dataGridViewMaskedTextBoxColumn.Name = gridInfomation.colKeyName
							dataGridViewMaskedTextBoxColumn.HeaderText = gridInfomation.colLogicName
							dataGridViewMaskedTextBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
							dataGridViewMaskedTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic
							dataGridViewMaskedTextBoxColumn.HeaderCell.Style.Font = font
							If gridInfomation.colIsKey Or gridInfomation.colIsHissu Then
								dataGridViewMaskedTextBoxColumn.HeaderCell.Style.BackColor = lightGoldenrodYellow
							End If
							dataGridViewMaskedTextBoxColumn.Mask = gridInfomation.colFormat
							dataGridViewMaskedTextBoxColumn.Width = gridInfomation.colWidth
							dataGridViewMaskedTextBoxColumn.DefaultCellStyle.Format = gridInfomation.colFormat
							dataGridViewMaskedTextBoxColumn.DefaultCellStyle.Alignment = gridInfomation.colAlignment
							dataGridViewMaskedTextBoxColumn.DefaultCellStyle.Font = font2
							dataGridViewMaskedTextBoxColumn.[ReadOnly] = gridInfomation.colIsReadOnly
							If gridInfomation.colIsReadOnly Then
								dataGridViewMaskedTextBoxColumn.DefaultCellStyle.BackColor = gradientInactiveCaption
							End If
							dataGridViewMaskedTextBoxColumn.Visible = Not gridInfomation.colIsHidden
							list.Add(dataGridViewMaskedTextBoxColumn)
						End If
					Else
						Dim dataGridViewTextBoxColumn2 As New DataGridViewTextBoxColumn()
						dataGridViewTextBoxColumn2.CellTemplate = New dgvTextBoxCell()
						dataGridViewTextBoxColumn2.DataPropertyName = gridInfomation.colKeyName
						dataGridViewTextBoxColumn2.Name = gridInfomation.colKeyName
						dataGridViewTextBoxColumn2.HeaderText = gridInfomation.colLogicName
						dataGridViewTextBoxColumn2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
						dataGridViewTextBoxColumn2.HeaderCell.Style.Font = font
						If gridInfomation.colIsKey Or gridInfomation.colIsHissu Then
							dataGridViewTextBoxColumn2.HeaderCell.Style.BackColor = lightGoldenrodYellow
						End If
						dataGridViewTextBoxColumn2.MaxInputLength = gridInfomation.colLength
						dataGridViewTextBoxColumn2.Width = gridInfomation.colWidth
						dataGridViewTextBoxColumn2.DefaultCellStyle.Format = gridInfomation.colFormat
						dataGridViewTextBoxColumn2.DefaultCellStyle.Alignment = gridInfomation.colAlignment
						dataGridViewTextBoxColumn2.DefaultCellStyle.Font = font2
						dataGridViewTextBoxColumn2.[ReadOnly] = gridInfomation.colIsReadOnly
						If gridInfomation.colIsReadOnly Then
							dataGridViewTextBoxColumn2.DefaultCellStyle.BackColor = gradientInactiveCaption
						End If
						dataGridViewTextBoxColumn2.Visible = Not gridInfomation.colIsHidden
						list.Add(dataGridViewTextBoxColumn2)
					End If
				Next
			Finally
				Dim enumerator As List(Of gridInfomation).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			list.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ROW", .Name = "ROW", .HeaderText = "行番号", .Visible = False, .[ReadOnly] = True})
			Me._dataGridView.Columns.AddRange(list.ToArray())
			Dim num As Integer = 0
			Dim list2 As New List(Of DataGridViewRow)()
			Try
				For Each dictionary As Dictionary(Of String, Object) In Me._dataInfo.DataList
					Dim dataGridViewRow As New DataGridViewRow()
					dataGridViewRow.Height = 25
					dataGridViewRow.CreateCells(Me._dataGridView)
					Dim num2 As Integer = 0
					Try
						For Each keyValuePair As KeyValuePair(Of String, Object) In dictionary
							Try
								If TypeOf keyValuePair.Value Is String Then
									If "BUHIN_CD".Equals(keyValuePair.Key) Then
										Dim dataGridViewCell As DataGridViewCell = dataGridViewRow.Cells(num2)
										Dim text2 As String = keyValuePair.Value.ToString()
										dataGridViewCell.Value = FormOperation.CreateBuhinCode(text2)
									ElseIf "KAKUNIN".Equals(keyValuePair.Key) Then
										If Operators.ConditionalCompareObjectEqual(keyValuePair.Value, "0", False) Then
											dataGridViewRow.Cells(num2).Value = False
										Else
											dataGridViewRow.Cells(num2).Value = True
										End If
									Else
										dataGridViewRow.Cells(num2).Value = RuntimeHelpers.GetObjectValue(keyValuePair.Value)
									End If
								ElseIf TypeOf keyValuePair.Value Is Decimal Then
									dataGridViewRow.Cells(num2).Value = Conversions.ToDecimal(keyValuePair.Value)
								ElseIf TypeOf keyValuePair.Value Is DateTime Then
									dataGridViewRow.Cells(num2).Value = Conversions.ToDate(keyValuePair.Value)
								ElseIf TypeOf keyValuePair.Value Is Long Then
									dataGridViewRow.Cells(num2).Value = Conversions.ToLong(keyValuePair.Value)
								ElseIf TypeOf keyValuePair.Value Is Integer Then
									dataGridViewRow.Cells(num2).Value = Conversions.ToInteger(keyValuePair.Value)
								End If
							Catch ex As Exception
								OutputLog.WriteLine("Columns Set Error! :" + ex.Message)
							Finally
								num2 += 1
							End Try
						Next
					Finally
						Dim enumerator4 As Dictionary(Of String, Object).Enumerator = Nothing
						CType(enumerator4, IDisposable).Dispose()
					End Try
					dataGridViewRow.Cells(num2).Value = num.ToString()
					list2.Add(dataGridViewRow)
					num += 1
				Next
			Finally
				Dim enumerator3 As List(Of Dictionary(Of String, Object)).Enumerator = Nothing
				CType(enumerator3, IDisposable).Dispose()
			End Try
			Me._dataGridView.Rows.AddRange(list2.ToArray())
			Me._dataGridView.AllowUserToAddRows = False
			Me._dataGridView.CurrentCell = Nothing
			Me._dataGridView.Refresh()
			Me._dataGridView.gridInfo = Me.gridInfo
		End Sub

		Public Function UpdateGridView(ByRef undertext As String) As Boolean

			If String.IsNullOrEmpty(Me._TableName) Then
				Return False
			End If
			If Me._gridInfo Is Nothing Then
				Return False
			End If
			Dim gridInfomation As New gridInfomation()
			gridInfomation.colKeyName = "KUBUN"
			Dim flag As Boolean = False
			If Me._gridInfo.Contains(gridInfomation) Then
				flag = True
			End If
			Try
				For Each gridInfomation2 As gridInfomation In Me._gridInfo
					If "KUBUN".Equals(gridInfomation2.colKeyName) Then
						flag = True
						Exit For
					End If
				Next
			Finally
				Dim enumerator As List(Of gridInfomation).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Not flag Then
				Return False
			End If
			Dim dictionary As New Dictionary(Of String, Integer)() From {{"追加", 0}, {"変更", 0}, {"削除", 0}}
			Dim list As New List(Of sqlWork)()
			Dim list2 As New List(Of sqlWork)()
			Dim num As Integer = 0
			Dim flag2 As Boolean = False
			Dim list3 As New List(Of Integer)()
			Try
				For Each obj As Object In CType(Me._dataGridView.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KUBUN").Value)
					list.Clear()
					list2.Clear()
					If Not (IsNothing(RuntimeHelpers.GetObjectValue(objectValue)) Or "".Equals(RuntimeHelpers.GetObjectValue(objectValue))) Then
						Dim flag3 As Boolean
						If "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
							flag2 = False
							Dim dictionary2 As New Dictionary(Of String, Object)()
							dictionary2.Clear()
							Try
								For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me._dataInfo.ItemDetail
									If Not String.IsNullOrEmpty(dataGridViewRow.Cells(keyValuePair.Key).ErrorText) Then
										If num = 0 Then
											Me._dataGridView.CurrentCell = dataGridViewRow.Cells(keyValuePair.Key)
										End If
										list.Clear()
										num += 1
										Exit For
									End If
									If "KUBUN".Equals(keyValuePair.Key) Then
										dictionary2.Add(keyValuePair.Key, "")
									ElseIf keyValuePair.Value.tablename.Equals(Me._TableName) Then
										If keyValuePair.Value.iskey Or Me.listOfKey.Contains(keyValuePair.Key) Then
											Dim value As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
											If String.IsNullOrEmpty(value) Then
												dataGridViewRow.Cells(keyValuePair.Key).ErrorText = "必須項目です。"
												If num = 0 Then
													Me._dataGridView.CurrentCell = dataGridViewRow.Cells(keyValuePair.Key)
												End If
												num += 1
												flag2 = True
											End If
										End If
										Dim obj2 As Object = Nothing
										If keyValuePair.Value.type Is GetType(String) Then
											If "BUHIN_CD".Equals(keyValuePair.Key) Then
												obj2 = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue).Replace("-", "")
											Else
												obj2 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
											End If
										ElseIf keyValuePair.Value.type Is GetType(Decimal) Then
											If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).Value)) Then
												obj2 = "NULL"
											Else
												Dim s As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).Value)
												Dim num2 As Decimal = Conversions.ToDecimal(obj2)
												Decimal.TryParse(s, num2)
												obj2 = num2
											End If
										ElseIf keyValuePair.Value.type Is GetType(DateTime) Then
											If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair.Key).Value)) Then
												obj2 = "NULL"
											Else
												Dim s2 As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
												Dim dateTime As DateTime = Conversions.ToDate(obj2)
												DateTime.TryParse(s2, dateTime)
												obj2 = dateTime
											End If
										End If
										list.Add(New sqlWork(keyValuePair.Key, Conversions.ToString(obj2), keyValuePair.Value.type, Nothing))
										dictionary2.Add(keyValuePair.Key, RuntimeHelpers.GetObjectValue(obj2))
									Else
										dictionary2.Add(keyValuePair.Key, "")
									End If
								Next
							Finally
								Dim enumerator3 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
								CType(enumerator3, IDisposable).Dispose()
							End Try
							dictionary2.Add("ROW", Me._dataInfo.DataList.Count)
							If list.Count = 0 Then
								Continue For
							End If
							If flag2 Then
								Continue For
							End If
							Dim sql As String = String.Empty
							If "Ukeharai.T_UKEHARAIMEISAI".Equals(Me._TableName) Then
								flag3 = Me.ExecDataJisseki(list, Nothing, "INS")
							ElseIf "Ukeharai.M_BUHIN".Equals(Me._TableName) Then
								flag3 = Me.ExecDataBuhin(list, Nothing, "INS")
							Else
								sql = Me.MakeSqlInsert(list)
								flag3 = Me.ExecData(sql)
							End If
							If flag3 Then
								Me._dataInfo.DataList.Add(dictionary2)
								dataGridViewRow.Cells("ROW").Value = RuntimeHelpers.GetObjectValue(dictionary2("ROW"))
							End If
						ElseIf "変更".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
							flag2 = False
							Dim dictionary3 As Dictionary(Of String, Object) = Me._dataInfo.DataList(Me.StrToInt(dataGridViewRow.Cells("ROW").Value.ToString()))
							Try
								For Each keyValuePair2 As KeyValuePair(Of String, ItemInfo) In Me._dataInfo.ItemDetail
									If Not String.IsNullOrEmpty(dataGridViewRow.Cells(keyValuePair2.Key).ErrorText) Then
										If num = 0 Then
											Me._dataGridView.CurrentCell = dataGridViewRow.Cells(keyValuePair2.Key)
										End If
										list.Clear()
										num += 1
										Exit For
									End If
									If Not "KUBUN".Equals(keyValuePair2.Key) Then
										If keyValuePair2.Value.tablename.Equals(Me._TableName) Then
											If keyValuePair2.Value.iskey Or Me.listOfKey.Contains(keyValuePair2.Key) Then
												Dim value2 As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair2.Key).FormattedValue)
												If String.IsNullOrEmpty(value2) Then
													dataGridViewRow.Cells(keyValuePair2.Key).ErrorText = "必須項目です。"
													If num = 0 Then
														Me._dataGridView.CurrentCell = dataGridViewRow.Cells(keyValuePair2.Key)
													End If
													num += 1
													flag2 = True
												End If
											End If
											Dim obj3 As Object = Nothing
											Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(dictionary3(keyValuePair2.Key))
											If keyValuePair2.Value.type Is GetType(String) Then
												If "BUHIN_CD".Equals(keyValuePair2.Key) Then
													obj3 = Conversions.ToString(dataGridViewRow.Cells(keyValuePair2.Key).FormattedValue).Replace("-", "")
												Else
													obj3 = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair2.Key).FormattedValue)
												End If
											ElseIf keyValuePair2.Value.type Is GetType(Decimal) Then
												If String.IsNullOrEmpty(Conversions.ToString(dataGridViewRow.Cells(keyValuePair2.Key).Value)) Then
													obj3 = "NULL"
												Else
													Dim s3 As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair2.Key).Value)
													Dim num2 As Decimal = Conversions.ToDecimal(obj3)
													Decimal.TryParse(s3, num2)
													obj3 = num2
												End If
											ElseIf keyValuePair2.Value.type Is GetType(DateTime) Then
												If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair2.Key).Value)) Then
													obj3 = "NULL"
												Else
													Dim s4 As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair2.Key).FormattedValue)
													Dim dateTime As DateTime = Conversions.ToDate(obj3)
													DateTime.TryParse(s4, dateTime)
													obj3 = dateTime
												End If
											End If
											If obj3 IsNot Nothing Then
												If Not obj3.Equals(RuntimeHelpers.GetObjectValue(objectValue2)) Then
													list.Add(New sqlWork(keyValuePair2.Key, Conversions.ToString(obj3), keyValuePair2.Value.type, RuntimeHelpers.GetObjectValue(objectValue2)))
												End If
												If keyValuePair2.Value.iskey Then
													list2.Add(New sqlWork(keyValuePair2.Key, objectValue2.ToString(), keyValuePair2.Value.type, obj3.ToString()))
												End If
											End If
										End If
									End If
								Next
							Finally
								Dim enumerator4 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
								CType(enumerator4, IDisposable).Dispose()
							End Try
							If list.Count = 0 Then
								Continue For
							End If
							If flag2 Then
								Continue For
							End If
							Dim sql2 As String = String.Empty
							If "Ukeharai.T_UKEHARAIMEISAI".Equals(Me._TableName) Then
								flag3 = Me.ExecDataJisseki(list, list2, "UPD")
							ElseIf "Ukeharai.M_BUHIN".Equals(Me._TableName) Then
								flag3 = Me.ExecDataBuhin(list, list2, "UPD")
							Else
								sql2 = Me.MakeSqlUpdate(list, list2)
								flag3 = Me.ExecData(sql2)
							End If
						Else
							If Not "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
								Continue For
							End If
							Dim dictionary4 As Dictionary(Of String, Object) = Me._dataInfo.DataList(Me.StrToInt(dataGridViewRow.Cells("ROW").Value.ToString()))
							Try
								For Each keyValuePair3 As KeyValuePair(Of String, ItemInfo) In Me._dataInfo.ItemDetail
									If Not "KUBUN".Equals(keyValuePair3.Key) Then
										Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(dictionary4(keyValuePair3.Key))
										If keyValuePair3.Value.tablename.Equals(Me._TableName) AndAlso keyValuePair3.Value.iskey Then
											list2.Add(New sqlWork(keyValuePair3.Key, Conversions.ToString(objectValue3), keyValuePair3.Value.type, Nothing))
										End If
									End If
								Next
							Finally
								Dim enumerator5 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
								CType(enumerator5, IDisposable).Dispose()
							End Try
							If list2.Count = 0 Then
								Continue For
							End If
							Dim sql3 As String = String.Empty
							If "Ukeharai.T_UKEHARAIMEISAI".Equals(Me._TableName) Then
								flag3 = Me.ExecDataJisseki(Nothing, list2, "DEL")
							ElseIf "Ukeharai.M_BUHIN".Equals(Me._TableName) Then
								flag3 = Me.ExecDataBuhin(Nothing, list2, "DEL")
							Else
								sql3 = Me.MakeSqlDelete(list2)
								flag3 = Me.ExecData(sql3)
							End If
						End If
						If flag3 Then
							dataGridViewRow.Cells("KUBUN").Value = Nothing
							If "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
								list3.Add(dataGridViewRow.Index)
							Else
								Try
									For Each obj4 As Object In dataGridViewRow.Cells
										Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(obj4)
										If TypeOf objectValue4 Is DataGridViewTextBoxCell Then
											Dim dataGridViewTextBoxCell As DataGridViewTextBoxCell = CType(objectValue4, DataGridViewTextBoxCell)
											If dataGridViewTextBoxCell.[ReadOnly] Then
												dataGridViewTextBoxCell.Style.BackColor = SystemColors.GradientInactiveCaption
											Else
												dataGridViewTextBoxCell.Style.BackColor = Color.White
											End If
										End If
									Next
								Finally
									Dim enumerator6 As IEnumerator = Nothing
									If TypeOf enumerator6 Is IDisposable Then
										TryCast(enumerator6, IDisposable).Dispose()
									End If
								End Try
								If "追加".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
									Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(dataGridViewRow.Cells("KUBUN"), DataGridViewComboBoxCell)
									dataGridViewComboBoxCell.Items.Clear()
									dataGridViewComboBoxCell.Items.Add("")
									dataGridViewComboBoxCell.Items.Add("変更")
									dataGridViewComboBoxCell.Items.Add("削除")
									dataGridViewComboBoxCell.Value = ""
								End If
							End If
							Dim dictionary5 As Dictionary(Of String, Integer) = dictionary
							Dim dictionary6 As Dictionary(Of String, Integer) = dictionary5
							Dim value3 As Object = objectValue
							dictionary6(Conversions.ToString(value3)) = dictionary5(Conversions.ToString(value3)) + 1
						Else
							If num = 0 AndAlso num = 0 Then
								Me._dataGridView.CurrentCell = dataGridViewRow.Cells(0)
							End If
							num += 1
						End If
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator = Nothing
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			For i As Integer = list3.Count - 1 To 0 Step -1
				Me._dataGridView.Rows.RemoveAt(list3(i))
			Next
			Dim sMessage As String = "更新処理が正常に終了しました。"
			Dim text As String = String.Empty
			Try
				For Each keyValuePair4 As KeyValuePair(Of String, Integer) In dictionary
					text = String.Concat(New String() {text, keyValuePair4.Key, "[", Conversions.ToString(keyValuePair4.Value), "]  "})
				Next
			Finally
				Dim enumerator7 As Dictionary(Of String, Integer).Enumerator = Nothing
				CType(enumerator7, IDisposable).Dispose()
			End Try
			If num = 0 Then
				Me.DisplayGridView(Me._dbSql, 0)
				Me._dataGridView.Init()
				DlgMessageBox.Show(sMessage, "結果", MessageBoxButtons.OK)
				undertext = Me._dataGridView.UpdateRows(text)
				Return True
			End If
			DlgMessageBox.Show("入力エラーのため一部行を更新できませんでした。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Return False
		End Function

		Public Function UpdateGridKeppinView(ByRef keppinUtext As String) As Boolean
			If String.IsNullOrEmpty(Me._TableName) Then
				Return False
			End If
			If Me._gridInfo Is Nothing Then
				Return False
			End If
			Dim item As New gridInfomation()
			Dim flag As Boolean = False
			If Me._gridInfo.Contains(item) Then
				flag = True
			End If
			Try
				For Each gridInfomation As gridInfomation In Me._gridInfo
					If "NYUKABI".Equals(gridInfomation.colKeyName) Then
						flag = True
						Exit For
					End If
				Next
			Finally
				Dim enumerator As List(Of gridInfomation).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Not flag Then
				Return False
			End If
			Dim num As Integer = 0
			Dim list As New List(Of sqlWork)()
			Dim list2 As New List(Of sqlWork)()
			Dim num2 As Integer = 0
			Dim list3 As New List(Of Integer)()
			Try
				For Each obj As Object In CType(Me._dataGridView.Rows, IEnumerable)
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("NYUKABI").Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells("KAKUNIN").Value)
					list.Clear()
					list2.Clear()
					Dim dictionary As Dictionary(Of String, Object) = Me._dataInfo.DataList(Me.StrToInt(dataGridViewRow.Cells("ROW").Value.ToString()))
					Try
						For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me._dataInfo.ItemDetail
							If Not ("KAKUNIN".Equals(keyValuePair.Key) Or "NYUKABI".Equals(keyValuePair.Key)) Then
								If Not keyValuePair.Value.iskey Then
									Continue For
								End If
							End If
							If Not String.IsNullOrEmpty(dataGridViewRow.Cells(keyValuePair.Key).ErrorText) Then
								If num2 = 0 Then
									Me._dataGridView.CurrentCell = dataGridViewRow.Cells(keyValuePair.Key)
								End If
								list.Clear()
								num2 += 1
								Exit For
							End If
							Dim obj2 As Object = Nothing
							Dim obj3 As Object = RuntimeHelpers.GetObjectValue(dictionary(keyValuePair.Key))
							If "KAKUNIN".Equals(keyValuePair.Key) Then
								If Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue, False, False) Then
									obj2 = "0"
								Else
									obj2 = "1"
								End If
							ElseIf "NYUKABI".Equals(keyValuePair.Key) Then
								If obj3 Is Nothing Then
									obj3 = "NULL"
								End If
								If IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(keyValuePair.Key).Value)) Then
									obj2 = "NULL"
								Else
									Dim s As String = Conversions.ToString(dataGridViewRow.Cells(keyValuePair.Key).FormattedValue)
									Dim dateTime As DateTime = Conversions.ToDate(obj2)
									DateTime.TryParse(s, dateTime)
									obj2 = dateTime
								End If
							Else
								obj2 = RuntimeHelpers.GetObjectValue(obj3)
							End If
							If Not ((obj2 Is Nothing Or "NULL".Equals(RuntimeHelpers.GetObjectValue(obj2))) And obj3 Is Nothing) Then
								If Not obj2.Equals(RuntimeHelpers.GetObjectValue(obj3)) Then
									list.Add(New sqlWork(keyValuePair.Key, Conversions.ToString(obj2), keyValuePair.Value.type, RuntimeHelpers.GetObjectValue(obj3)))
								End If
								If keyValuePair.Value.iskey Then
									list2.Add(New sqlWork(keyValuePair.Key, obj3.ToString(), keyValuePair.Value.type, obj2.ToString()))
								End If
							End If
						Next
					Finally
						Dim enumerator3 As Dictionary(Of String, ItemInfo).Enumerator = Nothing
						CType(enumerator3, IDisposable).Dispose()
					End Try
					If list.Count <> 0 Then
						Dim sql As String = String.Empty
						Dim flag2 As Boolean
						If "Ukeharai.T_UKEHARAIMEISAI".Equals(Me._TableName) Then
							flag2 = Me.ExecDataJisseki(list, list2, "UPD")
						ElseIf "Ukeharai.M_BUHIN".Equals(Me._TableName) Then
							flag2 = Me.ExecDataBuhin(list, list2, "UPD")
						Else
							sql = Me.MakeSqlUpdateKeppin(list, list2)
							flag2 = Me.ExecData(sql)
						End If
						If flag2 Then
							dataGridViewRow.Cells("NYUKABI").Value = Nothing
							num += 1
							If "削除".Equals(RuntimeHelpers.GetObjectValue(objectValue)) Then
								list3.Add(dataGridViewRow.Index)
							Else
								Try
									For Each obj4 As Object In dataGridViewRow.Cells
										Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(obj4)
										If TypeOf objectValue3 Is DataGridViewTextBoxCell Then
											Dim dataGridViewTextBoxCell As DataGridViewTextBoxCell = CType(objectValue3, DataGridViewTextBoxCell)
											If dataGridViewTextBoxCell.[ReadOnly] Then
												dataGridViewTextBoxCell.Style.BackColor = SystemColors.GradientInactiveCaption
											Else
												dataGridViewTextBoxCell.Style.BackColor = Color.White
											End If
										End If
									Next
								Finally
									Dim enumerator4 As IEnumerator = Nothing
									If TypeOf enumerator4 Is IDisposable Then
										TryCast(enumerator4, IDisposable).Dispose()
									End If
								End Try
							End If
						Else
							If num2 = 0 AndAlso num2 = 0 Then
								Me._dataGridView.CurrentCell = dataGridViewRow.Cells(0)
							End If
							num2 += 1
						End If
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator = Nothing
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Dim sMessage As String = "更新処理が正常に終了しました。"
			Dim text As String = String.Empty
			text = text + "変更[" + num.ToString() + "]  "
			If num2 = 0 Then
				Me.DisplayGridView(Me._dbSql, 0)
				Me._dataGridView.Init()
				DlgMessageBox.Show(sMessage, "結果", MessageBoxButtons.OK)
				keppinUtext = Me._dataGridView.UpdateRows(text)
				Return True
			End If
			DlgMessageBox.Show("入力エラーのため一部行を更新できませんでした。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Return False
		End Function

		Private Function MakeSqlUpdate(uSet As List(Of sqlWork), uWhere As List(Of sqlWork)) As String
			uSet.Add(New sqlWork("UPDATE_USER", Me._configData.xmlConfData.xDataBase.UserId, GetType(String), Nothing))
			uSet.Add(New sqlWork("UPDATE_DTM", Conversions.ToString(DateAndTime.Now), GetType(DateTime), Nothing))
			uSet.Add(New sqlWork("UPDATE_FUNCTION", "ControlDataGridView", GetType(String), Nothing))
			Dim text As String = "UPDATE " + Me._TableName + " SET "
			Try
				For Each sqlWork As sqlWork In uSet
					If "NULL".Equals(sqlWork.value) Then
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					ElseIf sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, sqlWork.name, "='", sqlWork.value, "' ,"})
					Else
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			If uWhere.Count > 0 Then
				text += " WHERE "
				Try
					For Each sqlWork2 As sqlWork In uWhere
						If sqlWork2.type Is GetType(String) Or sqlWork2.type Is GetType(DateTime) Then
							text = String.Concat(New String() {text, " ", sqlWork2.name, "='", sqlWork2.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork2.name, "=", sqlWork2.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator2, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Console.WriteLine(text)
			Return text
		End Function

		Private Function MakeSqlUpdateKeppin(uSet As List(Of sqlWork), uWhere As List(Of sqlWork)) As String
			uSet.Add(New sqlWork("UPDATE_USER", Me._configData.xmlConfData.xDataBase.UserId, GetType(String), Nothing))
			uSet.Add(New sqlWork("UPDATE_DTM", Conversions.ToString(DateAndTime.Now), GetType(DateTime), Nothing))
			uSet.Add(New sqlWork("UPDATE_FUNCTION", "ControlDataGridView", GetType(String), Nothing))
			Dim text As String = "UPDATE " + Me._TableName + " SET "
			Try
				For Each sqlWork As sqlWork In uSet
					If "NULL".Equals(sqlWork.value) Then
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					ElseIf Operators.CompareString(sqlWork.name, "NYUKABI", False) = 0 And Operators.CompareString(sqlWork.value, Nothing, False) = 0 Then
						text = text + sqlWork.name + "= NULL  ,"
					ElseIf sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, sqlWork.name, "='", sqlWork.value, "' ,"})
					Else
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			If uWhere.Count > 0 Then
				text += " WHERE "
				Try
					For Each sqlWork2 As sqlWork In uWhere
						If sqlWork2.type Is GetType(String) Or sqlWork2.type Is GetType(DateTime) Then
							text = String.Concat(New String() {text, " ", sqlWork2.name, "='", sqlWork2.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork2.name, "=", sqlWork2.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator2, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Console.WriteLine(text)
			Return text
		End Function

		Private Function MakeSqlInsert(uSet As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Dim text2 As String = String.Empty
			uSet.Add(New sqlWork("INSERT_USER", Me._configData.xmlConfData.xDataBase.UserId, GetType(String), Nothing))
			uSet.Add(New sqlWork("INSERT_DTM", Conversions.ToString(DateAndTime.Now), GetType(DateTime), Nothing))
			uSet.Add(New sqlWork("INSERT_FUNCTION", "ControlDataGridView", GetType(String), Nothing))
			Try
				For Each sqlWork As sqlWork In uSet
					text = text + sqlWork.name + " ,"
					If "NULL".Equals(sqlWork.value) Then
						text2 = text2 + sqlWork.value + " ,"
					ElseIf sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text2 = text2 + "'" + sqlWork.value + "' ,"
					Else
						text2 = text2 + sqlWork.value + " ,"
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			text2 = text2.TrimEnd(New Char() {","c})
			Return String.Concat(New String() {"INSERT INTO ", Me._TableName, " (", text, " ) VALUES (", text2, " )"})
		End Function

		Private Function MakeSqlDelete(uWhere As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "DELETE FROM " + Me._TableName + " WHERE " + text
		End Function

		Private Function MakeSqlUpdateJisseki(uSet As List(Of sqlWork), uWhere As List(Of sqlWork)) As String
			uSet.Add(New sqlWork("UPDATE_USER", Me._configData.xmlConfData.xDataBase.UserId, GetType(String), Nothing))
			uSet.Add(New sqlWork("UPDATE_DTM", Conversions.ToString(DateAndTime.Now), GetType(DateTime), Nothing))
			uSet.Add(New sqlWork("UPDATE_FUNCTION", "ControlDataGridView", GetType(String), Nothing))
			Dim text As String = "UPDATE Ukeharai.T_UKEHARAIJISSEKI SET "
			Try
				For Each sqlWork As sqlWork In uSet
					If "NULL".Equals(sqlWork.value) Then
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					ElseIf sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, sqlWork.name, "='", sqlWork.value, "' ,"})
					Else
						text = String.Concat(New String() {text, sqlWork.name, "=", sqlWork.value, " ,"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			If uWhere.Count > 0 Then
				text += " WHERE "
				Try
					For Each sqlWork2 As sqlWork In uWhere
						If sqlWork2.type Is GetType(String) Or sqlWork2.type Is GetType(DateTime) Then
							text = String.Concat(New String() {text, " ", sqlWork2.name, "='", sqlWork2.value, "' AND"})
						Else
							text = String.Concat(New String() {text, " ", sqlWork2.name, "=", sqlWork2.value, " AND"})
						End If
					Next
				Finally
					Dim enumerator2 As List(Of sqlWork).Enumerator = Nothing
					CType(enumerator2, IDisposable).Dispose()
				End Try
				text = text.Substring(0, text.Length - 4)
			End If
			Return text
		End Function

		Private Function MakeSqlInsertJisseki(uSet As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Dim text2 As String = String.Empty
			uSet.Add(New sqlWork("INSERT_USER", Me._configData.xmlConfData.xDataBase.UserId, GetType(String), Nothing))
			uSet.Add(New sqlWork("INSERT_DTM", Conversions.ToString(DateAndTime.Now), GetType(DateTime), Nothing))
			uSet.Add(New sqlWork("INSERT_FUNCTION", "ControlDataGridView", GetType(String), Nothing))
			Try
				For Each sqlWork As sqlWork In uSet
					text = text + sqlWork.name + " ,"
					If "NULL".Equals(sqlWork.value) Then
						text2 = text2 + sqlWork.value + " ,"
					ElseIf sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text2 = text2 + "'" + sqlWork.value + "' ,"
					Else
						text2 = text2 + sqlWork.value + " ,"
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.TrimEnd(New Char() {","c})
			text2 = text2.TrimEnd(New Char() {","c})
			Return String.Concat(New String() {"INSERT INTO Ukeharai.T_UKEHARAIJISSEKI (", text, " ) VALUES (", text2, " )"})
		End Function

		Private Function MakeSqlDeleteJisseki(uWhere As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "DELETE FROM Ukeharai.T_UKEHARAIJISSEKI WHERE " + text
		End Function

		Private Function MakeSqlCountJisseki(uWhere As List(Of sqlWork)) As String
			' 2023/06/26 ADD 実績データ確認
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "SELECT COUNT(*) AS COUNT FROM Ukeharai.T_UKEHARAIJISSEKI WHERE " + text
		End Function

		Private Function MakeSqlDeleteMeisai(uWhere As List(Of sqlWork)) As String
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "DELETE FROM Ukeharai.T_UKEHARAIMEISAI WHERE " + text
		End Function

		Private Function MakeSqlCountMeisai(uWhere As List(Of sqlWork)) As String
			' 2023/06/26 ADD 明細データ確認
			Dim text As String = String.Empty
			Try
				For Each sqlWork As sqlWork In uWhere
					If sqlWork.type Is GetType(String) Or sqlWork.type Is GetType(DateTime) Then
						text = String.Concat(New String() {text, " ", sqlWork.name, "='", sqlWork.value, "' AND"})
					Else
						text = String.Concat(New String() {text, " ", sqlWork.name, "=", sqlWork.value, " AND"})
					End If
				Next
			Finally
				Dim enumerator As List(Of sqlWork).Enumerator = Nothing
				CType(enumerator, IDisposable).Dispose()
			End Try
			text = text.Substring(1, text.Length - 4)
			Return "SELECT COUNT(*) AS COUNT FROM Ukeharai.T_UKEHARAIMEISAI WHERE " + text
		End Function

		Private Function makeGridInfo() As Boolean
			If Me._dataInfo Is Nothing Then
				Return False
			End If
			If Me._dataInfo.ItemDetail.Count = 0 Then
				Return False
			End If
			Me._gridInfo.Clear()
			Try
				Try
					For Each keyValuePair As KeyValuePair(Of String, ItemInfo) In Me._dataInfo.ItemDetail
						Dim gridInfomation As New gridInfomation()
						gridInfomation.colKeyName = keyValuePair.Key
						gridInfomation.colLength = keyValuePair.Value.length
						gridInfomation.colType = keyValuePair.Value.type
						If keyValuePair.Value.tablename.Equals("Ukeharai.T_KEPPIN") Then
							gridInfomation.colIsReadOnly = True
						ElseIf keyValuePair.Value.tablename.Equals(Me._TableName) Then
							gridInfomation.colIsReadOnly = False
						Else
							gridInfomation.colIsReadOnly = True
						End If
						If Me.colConst.ContainsKey(keyValuePair.Key) Then
							gridInfomation.colLogicName = Me.colConst(keyValuePair.Key).name
							gridInfomation.colWidth = Me.colConst(keyValuePair.Key).width
							gridInfomation.colAlignment = Me.colConst(keyValuePair.Key).alignment
							gridInfomation.colFormat = Me.colConst(keyValuePair.Key).format
							gridInfomation.colIsHidden = keyValuePair.Value.ishidden
							If Me.listOfKey.Contains(keyValuePair.Key) Then
								gridInfomation.colIsHissu = True
							End If
							If keyValuePair.Value.tablename.Equals(Me._TableName) Then
								gridInfomation.colIsKey = keyValuePair.Value.iskey
							Else
								gridInfomation.colIsKey = False
							End If
						Else
							gridInfomation.colLogicName = keyValuePair.Key
						End If
						Me._gridInfo.Add(gridInfomation)
					Next
				Finally
					Dim enumerator As Dictionary(Of String, ItemInfo).Enumerator = Nothing
					CType(enumerator, IDisposable).Dispose()
				End Try
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		Private Function StrToInt(str As String) As Integer
			Dim result As Integer = 0
			If String.IsNullOrEmpty(str) Then
				Return result
			End If
			Try
				result = Integer.Parse(str)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub getTableName(sql As String)
			If String.IsNullOrEmpty(sql) Then
				Return
			End If
			Dim array As String() = sql.Split(New Char() {" "c})
			Dim flag As Boolean = False
			Me._TableName = String.Empty
			For Each text As String In array
				If flag Then
					Me._TableName = text
					Exit For
				End If
				If "FROM".Equals(text.ToUpper()) Then
					flag = True
				End If
			Next
		End Sub

		Public Function IsChanged() As Boolean
			Return Me._dataGridView.IsChanged
		End Function

		Private _configData As XmlConfigControl

		Protected colConst As Dictionary(Of String, columninfo)

		Private _TableName As String

		Public Const COMBOBOXCOLUMN As String = "KUBUN"

		Private Const BUHINCOLUMN As String = "BUHIN_CD"

		Private Const NYUKABICOLUMN As String = "NYUKABI"

		Private Const KAKUNINCOLUMN As String = "KAKUNIN"

		Public Const KUBUN_NON As String = ""

		Public Const KUBUN_TUIKA As String = "追加"

		Public Const KUBUN_HENKO As String = "変更"

		Public Const KUBUN_SAKUJO As String = "削除"

		Private _itemComb As List(Of String)

		Private _gridInfo As List(Of gridInfomation)

		Private _dataInfo As SqlDataBase.DataInfomation

		Private _dataGridView As CustomDataGridView

		Private _dataBaseInfo As SchemaInfo

		Private _dbSql As String

		Private Const ROWHEIGHT As Integer = 25

		Public listOfHidden As List(Of String)

		Public listOfKey As List(Of String)

		Protected Class sqlWork

			Public Property name As String
				Get
					Return Me._name
				End Get
				Set(value As String)
					Me._name = value
				End Set
			End Property

			Public Property value As String
				Get
					Return Me._value
				End Get
				Set(value As String)
					Me._value = value
				End Set
			End Property

			Public Property type As Type
				Get
					Return Me._type
				End Get
				Set(value As Type)
					Me._type = value
				End Set
			End Property

			Public Property cmpValue As Object
				Get
					Return Me._cmpValue
				End Get
				Set(value As Object)
					Me._cmpValue = RuntimeHelpers.GetObjectValue(value)
				End Set
			End Property

			Public Sub New(n As String, v As String, t As Type, Optional b As Object = Nothing)
				Me.name = n
				Me.value = v
				Me.type = t
				Me.cmpValue = RuntimeHelpers.GetObjectValue(b)
			End Sub

			Private _name As String
			Private _value As String
			Private _type As Type
			Private _cmpValue As Object

		End Class

		Protected Class columninfo

			Public Sub New(n As String, Optional w As Integer = 100, Optional a As Integer = 16, Optional f As String = "")
				Me.name = n
				Me.width = w
				Me.alignment = CType(a, DataGridViewContentAlignment)
				Me.format = f
			End Sub

			Public name As String

			Public width As Integer

			Public alignment As DataGridViewContentAlignment

			Public format As String

		End Class

		Public Class gridInfomation

			Public Sub New()
				Dim empty As String = String.Empty
				Me.colKeyName = empty
				empty = String.Empty
				Me.colLogicName = empty
				Dim colType As Type = Nothing
				Me.colType = colType
				Dim num As Integer = 0
				Me.colLength = num
				num = 100
				Me.colWidth = num
				Dim colAlignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft
				Me.colAlignment = colAlignment
				empty = String.Empty
				Me.colFormat = empty
				Dim flag As Boolean = False
				Me.colIsReadOnly = flag
				flag = False
				Me.colIsHidden = flag
				flag = False
				Me.colIsKey = flag
				flag = False
				Me.colIsHissu = flag
			End Sub

			Public Property colKeyName As String
				Get
					Return Me._colKeyName
				End Get
				Set(value As String)
					Me._colKeyName = value
				End Set
			End Property

			Public Property colLogicName As String
				Get
					Return Me._colLogicName
				End Get
				Set(value As String)
					Me._colLogicName = value
				End Set
			End Property

			Public Property colType As Type
				Get
					Return Me._colType
				End Get
				Set(value As Type)
					Me._colType = value
				End Set
			End Property

			Public Property colLength As Integer
				Get
					Return Me._colLength
				End Get
				Set(value As Integer)
					Me._colLength = value
				End Set
			End Property

			Public Property colWidth As Integer
				Get
					Return Me._colWidth
				End Get
				Set(value As Integer)
					Me._colWidth = value
				End Set
			End Property

			Public Property colAlignment As DataGridViewContentAlignment
				Get
					Return Me._colAlignment
				End Get
				Set(value As DataGridViewContentAlignment)
					Me._colAlignment = value
				End Set
			End Property

			Public Property colFormat As String
				Get
					Return Me._colFormat
				End Get
				Set(value As String)
					Me._colFormat = value
				End Set
			End Property

			Public Property colIsReadOnly As Boolean
				Get
					Return Me._colIsReadOnly
				End Get
				Set(value As Boolean)
					Me._colIsReadOnly = value
				End Set
			End Property

			Public Property colIsHidden As Boolean
				Get
					Return Me._colIsHidden
				End Get
				Set(value As Boolean)
					Me._colIsHidden = value
				End Set
			End Property

			Public Property colIsKey As Boolean
				Get
					Return Me._colIsKey
				End Get
				Set(value As Boolean)
					Me._colIsKey = value
				End Set
			End Property

			Public Property colIsHissu As Boolean
				Get
					Return Me._colIsHissu
				End Get
				Set(value As Boolean)
					Me._colIsHissu = value
				End Set
			End Property

			Private _colKeyName As String
			Private _colLogicName As String
			Private _colType As Type
			Private _colLength As Integer
			Private _colWidth As Integer
			Private _colAlignment As DataGridViewContentAlignment
			Private _colFormat As String
			Private _colIsReadOnly As Boolean
			Private _colIsHidden As Boolean
			Private _colIsKey As Boolean
			Private _colIsHissu As Boolean

		End Class
	End Class
End Namespace
