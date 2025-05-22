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
	Public Class BatchMonthlyDataForm
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.BatchMonthlyDataForm_Load
			Me._conf = Nothing
			Me._execday = Nothing
			Me._monthTb = Nothing
			Me._viewinfo = Nothing
			Me._isCancel = False
			Me._isErrer = False
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
			Me.PasswordLabel = New Label()
			Me.PasswordTextBox = New TextBox()
			Me.InfoLabel = New Label()
			Me.BMD_BackButton = New Button()
			Me.BMD_ExecutButton = New Button()
			Me.Count_Label = New Label()
			Me.BuhinCD_Label = New Label()
			Me.ToriCD_Label = New Label()
			Me.ResultGroupBox = New GroupBox()
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
			Me.FormTitleLabel.TabIndex = 6
			Me.FormTitleLabel.Text = "月次データ処理"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'PasswordLabel
			'
			Me.PasswordLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.PasswordLabel.Location = New Point(211, 80)
			Me.PasswordLabel.Name = "PasswordLabel"
			Me.PasswordLabel.Size = New Size(191, 20)
			Me.PasswordLabel.TabIndex = 7
			Me.PasswordLabel.Text = "パスワードを入力してください。"
			'
			'PasswordTextBox
			'
			Me.PasswordTextBox.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left), AnchorStyles)
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
			'InfoLabel
			'
			Me.InfoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.InfoLabel.ForeColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.InfoLabel.Location = New Point(211, 116)
			Me.InfoLabel.Name = "InfoLabel"
			Me.InfoLabel.Size = New Size(325, 25)
			Me.InfoLabel.TabIndex = 41
			Me.InfoLabel.Text = "※　日次処理（受入・払出）は終わりましたか？"
			'
			'BMD_BackButton
			'
			Me.BMD_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BMD_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BMD_BackButton.Location = New Point(687, 520)
			Me.BMD_BackButton.Name = "BMD_BackButton"
			Me.BMD_BackButton.Size = New Size(80, 30)
			Me.BMD_BackButton.TabIndex = 4
			Me.BMD_BackButton.Text = "戻る"
			Me.BMD_BackButton.UseVisualStyleBackColor = True
			'
			'BMD_ExecutButton
			'
			Me.BMD_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.BMD_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.BMD_ExecutButton.Location = New Point(592, 520)
			Me.BMD_ExecutButton.Name = "BMD_ExecutButton"
			Me.BMD_ExecutButton.Size = New Size(80, 30)
			Me.BMD_ExecutButton.TabIndex = 2
			Me.BMD_ExecutButton.Text = "実行"
			Me.BMD_ExecutButton.UseVisualStyleBackColor = True
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
			'ResultGroupBox
			'
			Me.ResultGroupBox.Controls.Add(Me.Count_Label)
			Me.ResultGroupBox.Controls.Add(Me.BuhinCD_Label)
			Me.ResultGroupBox.Controls.Add(Me.ToriCD_Label)
			Me.ResultGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.ResultGroupBox.Location = New Point(214, 186)
			Me.ResultGroupBox.Name = "ResultGroupBox"
			Me.ResultGroupBox.Size = New Size(309, 54)
			Me.ResultGroupBox.TabIndex = 45
			Me.ResultGroupBox.TabStop = False
			Me.ResultGroupBox.Text = "処理結果"
			Me.ResultGroupBox.Visible = False
			'
			'BatchMonthlyDataForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(784, 562)
			Me.Controls.Add(Me.ResultGroupBox)
			Me.Controls.Add(Me.BMD_BackButton)
			Me.Controls.Add(Me.BMD_ExecutButton)
			Me.Controls.Add(Me.InfoLabel)
			Me.Controls.Add(Me.PasswordTextBox)
			Me.Controls.Add(Me.PasswordLabel)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "BatchMonthlyDataForm"
			Me.Text = "月次データ処理画面"
			Me.ResultGroupBox.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
#End Region

		Private Sub BatchMonthlyDataForm_Load(sender As Object, e As EventArgs)
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
			If DateAndTime.Now.Month <> execday.AddMonths(1).Month Then
				Return False
			End If
			Me._execday = execday
			Return True
		End Function

		Private Function MonthProcess() As Boolean
			Dim monthDataTable As DataTable = Me.GetMonthDataTable()
			If IsNothing(monthDataTable) Then
				DlgMessageBox.Show("月次更新情報を取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me._monthTb = monthDataTable
			If Not Me.StartExec() Then
				DlgMessageBox.Show("受払実績情報の更新に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			If Me._isCancel Then
				Return False
			End If
			If Not Me.UpdateNengatuValue() Then
				DlgMessageBox.Show("日付テーブルの年月更新に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End If
			Me.SetViewInfo(Me._viewinfo)
			Return True
		End Function

		Private Function GetMonthDataTable() As DataTable
			Dim result As DataTable = Nothing
			Dim paramlist As List(Of SqlDataBase.SqlParamInfo) = Me.CreateSelectStoredParam(Me._execday)
			Dim dataTable As DataTable = Me.ExecStoredDbParam(paramlist)
			If dataTable.Rows.Count > 0 Then
				result = dataTable
			End If
			Return result
		End Function

		Private Function StartExec() As Boolean
			Dim result As Boolean = False
			Me._isCancel = False
			Me._isErrer = False
			Dim dialogResult As DialogResult = DialogResult.None
			Using dlgProcess As New DlgProcess("月次処理", AddressOf Me.UpdateMonthData, 100)
				dialogResult = dlgProcess.ShowDialog(Me)
			End Using
			If Not Me._isErrer Then
				result = True
			End If
			If dialogResult = DialogResult.Cancel Then
				Me._isCancel = True
			End If
			Return result
		End Function

		Private Function CreateSelectStoredParam(execDate As DateTime) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = execDate.ToString("yyyy/MM/dd")}}
		End Function

		Private Function CreateUpdateStoredParam(toricd As String, execDate As DateTime) As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@S_ToriCd", .type = SqlDbType.NVarChar, .val = toricd}, New SqlDataBase.SqlParamInfo() With {.name = "@D_ExecYYYYMMDD", .type = SqlDbType.[Date], .val = execDate.ToString("yyyy/MM/dd")}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_User", .type = SqlDbType.NVarChar, .val = Me._conf.xmlConfData.xDataBase.UserId}, New SqlDataBase.SqlParamInfo() With {.name = "@D_UpdateTime", .type = SqlDbType.DateTime, .val = Conversions.ToString(DateAndTime.Now)}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Func", .type = SqlDbType.NVarChar, .val = "BatchMonthlyData"}}
		End Function

		Private Function CreateUpdateNengatuStoredParam() As List(Of SqlDataBase.SqlParamInfo)
			Return New List(Of SqlDataBase.SqlParamInfo)() From {New SqlDataBase.SqlParamInfo() With {.name = "@D_NengetuYMD", .type = SqlDbType.[Date], .val = Conversions.ToString(Me._execday)}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_User", .type = SqlDbType.NVarChar, .val = Me._conf.xmlConfData.xDataBase.UserId}, New SqlDataBase.SqlParamInfo() With {.name = "@D_UpdateTime", .type = SqlDbType.DateTime, .val = Conversions.ToString(DateAndTime.Now)}, New SqlDataBase.SqlParamInfo() With {.name = "@ID_Func", .type = SqlDbType.NVarChar, .val = "BatchMonthlyData"}}
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

		Private Function GetAllToriSql() As String
			Dim stringBuilder As New StringBuilder()
			stringBuilder.Append(String.Format("SELECT * ", New Object(-1) {}))
			stringBuilder.Append(String.Format("FROM Ukeharai.M_TORI [M_Tori] ", New Object(-1) {}))
			stringBuilder.Append(String.Format("WHERE M_Tori.TORI_CD <> '' ", New Object(-1) {}))
			Return stringBuilder.ToString()
		End Function

		Private Function ExecStoredDbParam(paramlist As List(Of SqlDataBase.SqlParamInfo)) As DataTable
			Dim result As New DataTable()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Select_Month_Data", paramlist, True)
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = sqlDataBase.DbDataTable
				End If
			End Using
			Return result
		End Function

		Private Sub UpdateMonthData(sender As Object, e As DoWorkEventArgs)
			Me._viewinfo = New viewInfo()
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim backgroundWorker As BackgroundWorker = CType(sender, BackgroundWorker)
				Dim count As Integer = Me._monthTb.Rows.Count
				Dim num As Integer = 0
				If sqlDataBase.BeginTransaction() Then
					Try
						Dim flag As Boolean = False
						Dim allToriSql As String = Me.GetAllToriSql()
						Dim dbParam As DataTable = Me.GetDbParam(allToriSql)
						If dbParam.Rows.Count < 1 Then
							flag = True
						Else
							count = Me._monthTb.Rows.Count
							backgroundWorker.ReportProgress(num, "月次更新：" + (CDbl(num) / CDbl(count)).ToString("P0"))
							Try
								For Each obj As Object In dbParam.Rows
									Dim dataRow As DataRow = CType(obj, DataRow)
									Dim filterExpression As String = String.Format("取引先コード = '{0}'", RuntimeHelpers.GetObjectValue(dataRow("TORI_CD")))
									Dim array As DataRow() = Me._monthTb.[Select](filterExpression)
									If array.Length >= 1 Then
										If backgroundWorker.CancellationPending Then
											flag = True
										End If
										Dim text As String = Conversions.ToString(dataRow("TORI_CD"))
										Dim buhin_cd As String = Conversions.ToString(array(array.Length - 1)("部品コード"))
										Dim listParams As List(Of SqlDataBase.SqlParamInfo) = Me.CreateUpdateStoredParam(text, Me._execday)
										Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Update_Month_Data", listParams, False)
										If Operators.CompareString(storedProcedureData, String.Empty, False) <> 0 Then
											flag = True
											OutputLog.WriteLine(String.Format("UPDATE ERRER [{0}] : ExecYMD[{1}]", storedProcedureData, Me._execday))
										End If
										num += array.Length
										backgroundWorker.ReportProgress(num, "月次更新：" + (CDbl(num) / CDbl(count)).ToString("P0"))
										Me._viewinfo.tori_cd = text
										Me._viewinfo.buhin_cd = buhin_cd
										Me._viewinfo.count = num
									End If
								Next
							Finally
								Dim enumerator As IEnumerator = Nothing
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							If Not flag Then
								sqlDataBase.CommitTransact()
							Else
								Me._isErrer = True
								sqlDataBase.RollbackTransact()
							End If
						End If
					Catch ex As Exception
						Me._isErrer = True
						sqlDataBase.RollbackTransact()
						OutputLog.WriteLine(String.Format("月次処理中に異常発生 {0}", ex.ToString()))
						DlgMessageBox.Show("受払実績情報の更新中に異常が発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End Try
				End If
			End Using
		End Sub
		Private Function UpdateNengatuValue() As Boolean
			Dim result As Boolean = False
			Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
				Dim listParams As List(Of SqlDataBase.SqlParamInfo) = Me.CreateUpdateNengatuStoredParam()
				Dim storedProcedureData As String = sqlDataBase.getStoredProcedureData("Ukeharai.Update_Nengetu_Value", listParams, False)
				If Operators.CompareString(storedProcedureData, String.Empty, False) = 0 Then
					result = True
				Else
					OutputLog.WriteLine(String.Format("UPDATE ERRER [{0}] : NengetuYMD[{1}] ", storedProcedureData, Me._execday.ToString("yyyy/MM/dd")))
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

		<AccessedThroughProperty("PasswordLabel")>
		Private WithEvents PasswordLabel As Label

		<AccessedThroughProperty("PasswordTextBox")>
		Private WithEvents PasswordTextBox As TextBox

		<AccessedThroughProperty("InfoLabel")>
		Private WithEvents InfoLabel As Label

		<AccessedThroughProperty("BMD_BackButton")>
		Private WithEvents BMD_BackButton As Button

		<AccessedThroughProperty("BMD_ExecutButton")>
		Private WithEvents BMD_ExecutButton As Button

		<AccessedThroughProperty("Count_Label")>
		Private WithEvents Count_Label As Label

		<AccessedThroughProperty("BuhinCD_Label")>
		Private WithEvents BuhinCD_Label As Label

		<AccessedThroughProperty("ToriCD_Label")>
		Private WithEvents ToriCD_Label As Label

		<AccessedThroughProperty("ResultGroupBox")>
		Private WithEvents ResultGroupBox As GroupBox

		Private _conf As XmlConfigControl

		Private _execday As DateTime

		Private _monthTb As DataTable

		Private _viewinfo As BatchMonthlyDataForm.viewInfo

		Private _isCancel As Boolean

		Private _isErrer As Boolean

		Private Const PASSWORD_KEY As String = "UH"

		Private Const EXEC_FUNC_NAME As String = "BatchMonthlyData"

		Private Const SELECT_STORED_NAME As String = "Ukeharai.Select_Month_Data"

		Private Const UPDATE_STORED_NAME As String = "Ukeharai.Update_Month_Data"

		Private Const UPDATE_NENGATU_STORED_NAME As String = "Ukeharai.Update_Nengetu_Value"


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


		Private Sub BMD_ExecutButton_Click(sender As Object, e As EventArgs) Handles BMD_ExecutButton.Click
			If Me.PasswordTextBox.Text.Length < 1 Then
				DlgMessageBox.Show("パスワードを入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If Not Me.PasswordTextBox.Text.Equals("UH") Then
				DlgMessageBox.Show("パスワードが違います。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If Not Me.CheckExecDay() Then
				DlgMessageBox.Show("月次処理の可能な月ではありません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim dialogResult As DialogResult = MessageBox.Show("月次処理を実行します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			If dialogResult = DialogResult.No Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			If Me.MonthProcess() Then
				DlgMessageBox.Show("月次処理が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.None)
				Return
			End If
			If Me._isCancel Then
				DlgMessageBox.Show("月次処理をキャンセルしました。", "キャンセル", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			DlgMessageBox.Show("月次処理を中断しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		Private Sub BMD_BackButton_Click(sender As Object, e As EventArgs) Handles BMD_BackButton.Click
			Me.Close()
		End Sub
	End Class
End Namespace
