Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class RegisterBaseForm
		Inherits Form

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
			Me.RBM_BackButton = New Button()
			Me.RBM_ExecutButton = New Button()
			Me.SuspendLayout()
			'
			'FormTitleLabel
			'
			Me.FormTitleLabel.BackColor = Color.GreenYellow
			Me.FormTitleLabel.Dock = DockStyle.Top
			Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormTitleLabel.ForeColor = Color.Black
			Me.FormTitleLabel.Location = New Point(0, 0)
			Me.FormTitleLabel.Name = "FormTitleLabel"
			Me.FormTitleLabel.Size = New Size(955, 45)
			Me.FormTitleLabel.TabIndex = 3
			Me.FormTitleLabel.Text = "XXXXマスター登録"
			Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
			'
			'RBM_BackButton
			'
			Me.RBM_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.RBM_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RBM_BackButton.Location = New Point(863, 560)
			Me.RBM_BackButton.Name = "RBM_BackButton"
			Me.RBM_BackButton.Size = New Size(80, 30)
			Me.RBM_BackButton.TabIndex = 1
			Me.RBM_BackButton.Text = "戻る"
			Me.RBM_BackButton.UseVisualStyleBackColor = True
			'
			'RBM_ExecutButton
			'
			Me.RBM_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.RBM_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.RBM_ExecutButton.Location = New Point(777, 560)
			Me.RBM_ExecutButton.Name = "RBM_ExecutButton"
			Me.RBM_ExecutButton.Size = New Size(80, 30)
			Me.RBM_ExecutButton.TabIndex = 0
			Me.RBM_ExecutButton.Text = "実行"
			Me.RBM_ExecutButton.UseVisualStyleBackColor = True
			'
			'RegisterBaseForm
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.ClientSize = New Size(955, 602)
			Me.Controls.Add(Me.RBM_BackButton)
			Me.Controls.Add(Me.RBM_ExecutButton)
			Me.Controls.Add(Me.FormTitleLabel)
			Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
			Me.Icon = ico
			Me.Name = "RegisterBaseForm"
			Me.Text = "部品マスター登録画面"
			Me.ResumeLayout(False)

		End Sub
#End Region
		Public Property TtileName As String
			Get
				Return Me._titleName
			End Get
			Set(value As String)
				Me._titleName = value
				Me.FormTitleLabel.Text = Me._titleName
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.RegisterBaseForm_Activated
			AddHandler MyBase.FormClosed, AddressOf Me.RegisterBaseForm_FormClosed
			Me._titleName = String.Empty
			Me.ReViewFlag = False
			Me.InitializeComponent()
			Me._gridViewInfo = Nothing
		End Sub

		Private Sub RegisterBaseForm_Activated(sender As Object, e As EventArgs)
			Me.TopMost = True
			Me.TopMost = False
		End Sub

		Private Sub RegisterBaseForm_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me._gridViewInfo = Nothing
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("FormTitleLabel")>
		Public WithEvents FormTitleLabel As Label

		<AccessedThroughProperty("RBM_BackButton")>
		Public WithEvents RBM_BackButton As Button

		<AccessedThroughProperty("RBM_ExecutButton")>
		Public WithEvents RBM_ExecutButton As Button

		Public Const MSG_E10001 As String = "マスタ登録中にエラーが発生しました。"

		Public Const MSG_E10002 As String = "変更中のデータがあります。更新しないで閉じますか？"

		Public Const MSG_E10003 As String = "更新データありません。"

		Public _gridViewInfo As ControlDataGridView

		Private _titleName As String

		Protected ReViewFlag As Boolean

		Public undertext As String = Nothing

		Protected Overridable Sub RBM_ExecutButton_Click(sender As Object, e As EventArgs) Handles RBM_ExecutButton.Click
			If Me._gridViewInfo Is Nothing Then
				Return
			End If
			Cursor.Current = Cursors.WaitCursor
			Me.RBM_ExecutButton.Enabled = False
			Me.ReViewFlag = False
			Try
				If Me._gridViewInfo.IsChanged() Then
					Me.ReViewFlag = Me._gridViewInfo.UpdateGridView(undertext)
				Else
					DlgMessageBox.Show("更新データありません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
				OutputLog.WriteLine("RegisterBaseForm RBM_ExecutButton.Click Error {0} : {1}", New String() {Me._titleName, ex.Message})
				DlgMessageBox.Show("マスタ登録中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Me.RBM_ExecutButton.Enabled = True

			End Try
		End Sub

		Public Overridable Sub RBM_BackButton_Click(sender As Object, e As EventArgs) Handles RBM_BackButton.Click
			If Me._gridViewInfo Is Nothing Then
				Me.Close()
				Return
			End If
			If Me._gridViewInfo.IsChanged() AndAlso DlgMessageBox.Show("変更中のデータがあります。更新しないで閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) <> DialogResult.OK Then
				Return
			End If
			Me.Close()
		End Sub
	End Class
End Namespace
