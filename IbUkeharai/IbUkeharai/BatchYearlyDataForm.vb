Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class BatchYearlyDataForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.BatchYearlyDataForm_Load
			Me._conf = Nothing
			Me._execday = Nothing
			Me._viewinfo = Nothing
			Me._isCancel = False
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
			Me.FormTitleLabel = New Label()
			Me.InfoLabel = New Label()
			Me.PasswordTextBox = New TextBox()
			Me.PasswordLabel = New Label()
			Me.BYD_BackButton = New Button()
			Me.BYD_ExecutButton = New Button()
			Me.ResultGroupBox = New GroupBox()
			Me.Count_Label = New Label()
			Me.BuhinCD_Label = New Label()
			Me.ToriCD_Label = New Label()
			Me.ResultGroupBox.SuspendLayout()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.FormTitleLabel.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
			Me.FormTitleLabel.Location = New Point(12, 9)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(760, 45)
			Me.FormTitleLabel.TabIndex = 7
			Me.FormTitleLabel.Text = "年次データ処理"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'InfoLabel
			'
			Me.InfoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.InfoLabel.ForeColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.InfoLabel.Location = New Point(211, 116)
			Me.InfoLabel.Name = "InfoLabel"
			Me.InfoLabel.Size = New Size(325, 25)
			Me.InfoLabel.TabIndex = 44
			Me.InfoLabel.Text = "※　月次処理は終わりましたか？"
			'
			'PasswordTextBox
			'
			Me.PasswordTextBox.BackColor = Color.LightGoldenrodYellow
			Me.PasswordTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.PasswordTextBox.ImeMode = ImeMode.Disable
			Me.PasswordTextBox.Location = New Point(436, 77)
			Me.PasswordTextBox.MaxLength = 7
			Me.PasswordTextBox.Name = "PasswordTextBox"
			Me.PasswordTextBox.Size = New Size(100, 19)
			Me.PasswordTextBox.TabIndex = 1
			Me.PasswordTextBox.UseSystemPasswordChar = True
			'
			'PasswordLabel
			'
			Me.PasswordLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.PasswordLabel.Location = New Point(211, 80)
			Me.PasswordLabel.Name = "PasswordLabel"
			Me.PasswordLabel.Size = New Size(191, 20)
			Me.PasswordLabel.TabIndex = 42
			Me.PasswordLabel.Text = "パスワードを入力してください。"
			'
			'BYD_BackButton
			'
			Me.BYD_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BYD_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BYD_BackButton.Location = New Point(687, 520)
			Me.BYD_BackButton.Name = "BYD_BackButton"
			Me.BYD_BackButton.Size = New Size(80, 30)
			Me.BYD_BackButton.TabIndex = 4
			Me.BYD_BackButton.Text = "戻る"
			Me.BYD_BackButton.UseVisualStyleBackColor = True
			'
			'BYD_ExecutButton
			'
			Me.BYD_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BYD_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BYD_ExecutButton.Location = New Point(594, 520)
			Me.BYD_ExecutButton.Name = "BYD_ExecutButton"
			Me.BYD_ExecutButton.Size = New Size(80, 30)
			Me.BYD_ExecutButton.TabIndex = 2
			Me.BYD_ExecutButton.Text = "実行"
			Me.BYD_ExecutButton.UseVisualStyleBackColor = True
			'
			'ResultGroupBox
			'
			Me.ResultGroupBox.Controls.Add(Me.Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.ToriCD_Label)
			Me.ResultGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ResultGroupBox.Location = New Point(214, 186)
			Me.ResultGroupBox.Name = "ResultGroupBox"
			Me.ResultGroupBox.Size = New Size(309, 54)
			Me.ResultGroupBox.TabIndex = 46
			Me.ResultGroupBox.TabStop = False
			Me.ResultGroupBox.Text = "処理結果"
			Me.ResultGroupBox.Visible = False
			'
			'Count_Label
			'
			Me.Count_Label.Location = New Point(243, 23)
			Me.Count_Label.Name = "Count_Label"
			Me.Count_Label.Size = New Size(59, 20)
			Me.Count_Label.TabIndex = 44
			Me.Count_Label.Text = "ZZ,ZZ9"
			'
			'BuhinCD_Label
			'
			Me.BuhinCD_Label.Location = New Point(92, 23)
			Me.BuhinCD_Label.Name = "BuhinCD_Label"
			Me.BuhinCD_Label.Size = New Size(145, 20)
			Me.BuhinCD_Label.TabIndex = 43
			Me.BuhinCD_Label.Text = "XXXX-XXX-XXX-XX"
			'
			'ToriCD_Label
			'
			Me.ToriCD_Label.Location = New Point(6, 23)
			Me.ToriCD_Label.Name = "ToriCD_Label"
			Me.ToriCD_Label.Size = New Size(80, 20)
			Me.ToriCD_Label.TabIndex = 42
			Me.ToriCD_Label.Text = "XXXXXXXX"
			'
			'BatchYearlyDataForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.ResultGroupBox)
			Me.Controls.Add(Me.BYD_BackButton)
			Me.Controls.Add(Me.BYD_ExecutButton)
			Me.Controls.Add(Me.InfoLabel)
			Me.Controls.Add(Me.PasswordTextBox)
			Me.Controls.Add(Me.PasswordLabel)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "BatchYearlyDataForm"
			Me.Text = "年次データ処理画面"
			Me.ResultGroupBox.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region
		Private Sub BatchYearlyDataForm_Load(sender As Object, e As EventArgs)
			Me._conf = TopForm.ConfigData
		End Sub


		Private Function CheckExecDay() As Boolean
			Dim hizukeSql As String = Me.GetHizukeSql()
			Dim dbParam As DataTable = Me.GetDbParam(hizukeSql)
			If dbParam.Rows.Count < 1 Then
				Return False
			End If
			Dim s As String = Conversions.ToString(dbParam.Rows(0)("NENGETSU"))
			Dim execday As DateTime = DateTime.Parse(s)
			If execday.Month <> 1 Then
				Return False
			End If
			Me._execday = execday
			Return True
		End Function

		Private Function StartExec() As Boolean
			Dim result As Boolean = False
			Me._isCancel = False
			Dim dialogResult As DialogResult = DialogResult.None
			Using dlgProcess As New DlgProcess("年次処理", Sub(a0 As Object, a1 As DoWorkEventArgs)
														   Me.YearProcess(RuntimeHelpers.GetObjectValue(a0), a1)
													   End Sub, 100)
				dialogResult = dlgProcess.ShowDialog(Me)
			End Using
			If dialogResult = DialogResult.OK Then
				result = True
			ElseIf dialogResult = DialogResult.Cancel Then
				Me._isCancel = True
			End If
			Return result
		End Function

		Private Function YearProcess(sender As Object, e As DoWorkEventArgs) As Boolean
			Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
			Dim yearDataTable As DataTable = Me.GetYearDataTable()
			If IsNothing(yearDataTable) Then
				DlgMessageBox.Show("年次更新情報を取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me._viewinfo = New viewInfo()
			Dim count As Integer = yearDataTable.Rows.Count
			Dim num As Integer = 0
			Try
				Try
					For Each obj As Object In yearDataTable.Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						num += 1
						backgroundWorker.ReportProgress(num, "年次更新：" + (CDbl(num) / CDbl(count)).ToString("P0"))
						If backgroundWorker.CancellationPending Then
							Return False
						End If
						Dim num2 As Integer = Me.InsertYearData(dataRow)
						If num2 <= 0 Then
							If num2 <> 0 Then
								Throw New Exception("")
							End If
							Me._viewinfo.tori_cd = Conversions.ToString(dataRow("取引先コード"))
							Me._viewinfo.buhin_cd = Conversions.ToString(dataRow("部品コード"))
							Dim viewinfo As viewInfo = Me._viewinfo
							viewinfo.count += 1
						End If
					Next
				Finally
					Dim enumerator As IEnumerator = Nothing
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
				DlgMessageBox.Show("受払実績情報の更新中に異常が発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		Private Function GetYearDataTable() As DataTable
			Dim result As DataTable = Nothing
			Dim paramlist As List(Of SqlDataBase.SqlParamInfo) = Me.CreateSelectStoredParam(Me._execday)
			Dim dataTable As DataTable = Me.SelectYearStockData(paramlist)
			If dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function CreateSelectStoredParam(execDate As DateTime) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = execDate.ToString("yyyy/MM/dd")}}
		End Function

		Private Function CreateDeleteStoredParam(row As DataRow) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@ID_Tori", .type = SqlDbType.NVarChar, .val = Conversions.ToString(row("取引先コード"))}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Buhin", .type = SqlDbType.NVarChar, .val = Conversions.ToString(row("部品コード"))}, New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = Conversions.ToString(row("処理日付"))}}
		End Function

		Private Function CreateInsertStoredParam(row As DataRow) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@ID_Tori", .type = SqlDbType.NVarChar, .val = Conversions.ToString(row("取引先コード"))}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Buhin", .type = SqlDbType.NVarChar, .val = Conversions.ToString(row("部品コード"))}, New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = Conversions.ToString(row("処理日付"))}, New SqlDataBase.SqlParamInfo() With {.name = "@I_LastYearKosu", .type = SqlDbType.[Decimal], .val = Conversions.ToString(row("前年末在庫"))}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_User", .type = SqlDbType.NVarChar, .val = Me._conf.xmlConfData.xDataBase.UserId}, New SqlDataBase.SqlParamInfo() With {.name = "@D_UpdateTime", .type = SqlDbType.DateTime, .val = Conversions.ToString(DateAndTime.Now)}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Func", .type = SqlDbType.NVarChar, .val = "BatchYearlyData"}}
		End Function

		Private Function GetDbParam(sql As String) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim sqldata As String = sqlDataBase.getSQLData(sql, True)
				If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function SelectYearStockData(paramlist As List(Of SqlDataBase.SqlParamInfo)) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Select_Year_Stock", paramlist, True)
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Function InsertYearData(row As DataRow) As Integer
			Dim result As Integer = 0
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				If sqlDataBase.BeginTransaction() Then
					Try
						Dim flag As Boolean = False
						Dim listParams As List(Of SqlDataBase.SqlParamInfo) = Me.CreateDeleteStoredParam(row)
						Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Delete_Year_InitializeData", listParams, False)
						If Operators.CompareString(storedProcedureData, String.Empty, False) <> 0 Then
							flag = True
							OutputLog.WriteLine(String.Format("DELETE ERRER [{0}] : ToriCd[{1}] BuhinCd[{2}] ExecYMD[{3}]", New Object() {storedProcedureData, RuntimeHelpers.GetObjectValue(row("取引先コード")), RuntimeHelpers.GetObjectValue(row("部品コード")), RuntimeHelpers.GetObjectValue(row("処理日付"))}))
						End If
						Dim listParams2 As List(Of SqlDataBase.SqlParamInfo) = Me.CreateInsertStoredParam(row)
						storedProcedureData = sqlDataBase.getStoredProcedureData("Ukeharai.Insert_Year_InitializeData", listParams2, False)
						If Operators.CompareString(storedProcedureData, String.Empty, False) <> 0 Then
							flag = True
							OutputLog.WriteLine(String.Format("INSERT ERRER [{0}] : ToriCd[{1}] BuhinCd[{2}] ExecYMD[{3}]", New Object() {storedProcedureData, RuntimeHelpers.GetObjectValue(row("取引先コード")), RuntimeHelpers.GetObjectValue(row("部品コード")), RuntimeHelpers.GetObjectValue(row("処理日付"))}))
						End If
						If Not flag Then
							sqlDataBase.CommitTransact()
						Else
							sqlDataBase.RollbackTransact()
							result = 1
						End If
					Catch ex As Exception
						sqlDataBase.RollbackTransact()
						result = -1
					End Try
				End If
			End Using
			Return result
		End Function

		Private Function GetHizukeSql() As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.T_HIZUKE ", New Object(-1) {}))
			Return stringBuilder.ToString()
		End Function

		Private Sub SetViewInfo(info As viewInfo)
			Me.ToriCD_Label.Text = info.tori_cd
			Me.BuhinCD_Label.Text = Me.ConvertBuhinCd(info.buhin_cd)
			Me.Count_Label.Text = Me.ConvertViewNumber(info.count)
			Me.ResultGroupBox.Visible = True
		End Sub

		Private Function ConvertViewNumber(num As Integer) As String
			Return String.Format("{0:#,0}", num)
		End Function

		Private Function ConvertBuhinCd(buhin_cd As String) As String
			Dim length As Integer = buhin_cd.Length
			Dim result As String
			If length > 10 Then
				result = String.Format("{0}-{1}-{2}-{3}", New Object() {buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7, 3), buhin_cd.Substring(10)})
			ElseIf length > 7 Then
				result = String.Format("{0}-{1}-{2}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4, 3), buhin_cd.Substring(7))
			ElseIf length > 4 Then
				result = String.Format("{0}-{1}", buhin_cd.Substring(0, 4), buhin_cd.Substring(4))
			Else
				result = buhin_cd
			End If
			Return result
		End Function

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Private WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("InfoLabel")>
		Private WithEvents InfoLabel As Label

		<AccessedThroughProperty("PasswordTextBox")>
		Private WithEvents PasswordTextBox As TextBox

		<AccessedThroughProperty("PasswordLabel")>
		Private WithEvents PasswordLabel As Label

		<AccessedThroughProperty("BYD_BackButton")>
		Private WithEvents BYD_BackButton As Button

		<AccessedThroughProperty("BYD_ExecutButton")>
		Private WithEvents BYD_ExecutButton As Button

		<AccessedThroughProperty("ResultGroupBox")>
		Private WithEvents ResultGroupBox As GroupBox

		<AccessedThroughProperty("Count_Label")>
		Private WithEvents Count_Label As Label

		<AccessedThroughProperty("BuhinCD_Label")>
		Private WithEvents BuhinCD_Label As Label

		<AccessedThroughProperty("ToriCD_Label")>
		Private WithEvents ToriCD_Label As Label

		Private _conf As XmlConfigControl

		Private _execday As DateTime

		Private _viewinfo As BatchYearlyDataForm.viewInfo

		Private _isCancel As Boolean

		Private Const PASSWORD_KEY As String = "UH"

		Private Const EXEC_FUNC_NAME As String = "BatchYearlyData"

		Private Const SELECT_STORED_NAME As String = "Ukeharai.Select_Year_Stock"

		Private Const DELETE_STORED_NAME As String = "Ukeharai.Delete_Year_InitializeData"

		Private Const INSERT_STORED_NAME As String = "Ukeharai.Insert_Year_InitializeData"

		Public Class viewInfo
			Public Sub New()
				Me.tori_cd = ""
				Me.buhin_cd = ""
				Me.count = 0
			End Sub

			Public tori_cd As String

			Public buhin_cd As String

			Public count As Integer
		End Class

		Private Sub BYD_ExecutButton_Click_1(sender As Object, e As EventArgs) Handles BYD_ExecutButton.Click
			If Me.PasswordTextBox.Text.Length < 1 Then
				DlgMessageBox.Show("パスワードを入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If Not Me.PasswordTextBox.Text.Equals("UH") Then
				DlgMessageBox.Show("パスワードが違います。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If Not Me.CheckExecDay() Then
				DlgMessageBox.Show("年次処理の可能な月ではありません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("年次処理を実行します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			If Me.StartExec() Then
				Me.SetViewInfo(Me._viewinfo)
				DlgMessageBox.Show("年次処理が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.None)
				Return
			End If
			If Me._isCancel Then
				DlgMessageBox.Show("年次処理をキャンセルしました。", "キャンセル", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			DlgMessageBox.Show("年次処理を中断しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BYD_BackButton_Click(sender As Object, e As EventArgs) Handles BYD_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
