Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Constants

Namespace DitCore.Dialogs

	<DesignerGenerated()>
	Public Class DlgProcessKeppin
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
			Me.components = New System.ComponentModel.Container()
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
			Me.ProgressBar1 = New ProgressBar()
			Me.messageLabel = New Label()
			Me.Timer1 = New Timer(Me.components)
			Me.Label1 = New Label()
			Me.ProgressLabel = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			'
			'TableLayoutPanel1
			'
			Me.TableLayoutPanel1.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Me.TableLayoutPanel1.Location = New Point(165, 98)
			Me.TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0!))
			Me.TableLayoutPanel1.Size = New Size(246, 44)
			Me.TableLayoutPanel1.TabIndex = 0
			'
			'OK_Button
			'
			Me.OK_Button.Anchor = AnchorStyles.None
			Me.OK_Button.Location = New Point(8, 4)
			Me.OK_Button.Margin = New Padding(3, 4, 3, 4)
			Me.OK_Button.Name = "OK_Button"
			Me.OK_Button.Size = New Size(106, 36)
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.OK_Button.Visible = False
			'
			'Cancel_Button
			'
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Me.Cancel_Button.Location = New Point(130, 4)
			Me.Cancel_Button.Margin = New Padding(3, 4, 3, 4)
			Me.Cancel_Button.Name = "Cancel_Button"
			Me.Cancel_Button.Size = New Size(109, 36)
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "キャンセル"
			Me.Cancel_Button.Visible = False
			'
			'BackgroundWorker1
			'
			Me.BackgroundWorker1.WorkerReportsProgress = True
			Me.BackgroundWorker1.WorkerSupportsCancellation = True
			'
			'ProgressBar1
			'
			Me.ProgressBar1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
			Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.ProgressBar1.BackColor = SystemColors.Control
			Me.ProgressBar1.Location = New Point(12, 55)
			Me.ProgressBar1.Margin = New Padding(3, 4, 3, 4)
			Me.ProgressBar1.MarqueeAnimationSpeed = 10
			Me.ProgressBar1.Name = "ProgressBar1"
			Me.ProgressBar1.Size = New Size(395, 26)
			Me.ProgressBar1.Step = 20
			Me.ProgressBar1.Style = ProgressBarStyle.Marquee
			Me.ProgressBar1.TabIndex = 1
			'
			'messageLabel
			'
			Me.messageLabel.Location = New Point(12, 95)
			Me.messageLabel.Name = "messageLabel"
			Me.messageLabel.Size = New Size(403, 54)
			Me.messageLabel.TabIndex = 2
			Me.messageLabel.Text = "経過時間など"
			Me.messageLabel.TextAlign = ContentAlignment.BottomLeft
			'
			'Timer1
			'
			Me.Timer1.Interval = 1000
			'
			'Label1
			'
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.Label1.ForeColor = SystemColors.HotTrack
			Me.Label1.Location = New Point(16, 16)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(46, 13)
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "処理中"
			'
			'ProgressLabel
			'
			Me.ProgressLabel.Location = New Point(139, 134)
			Me.ProgressLabel.Name = "ProgressLabel"
			Me.ProgressLabel.Size = New Size(272, 15)
			Me.ProgressLabel.TabIndex = 4
			Me.ProgressLabel.TextAlign = ContentAlignment.BottomRight
			'
			'DlgProcessKeppin
			'
			Me.AcceptButton = Me.OK_Button
			Me.AutoScaleDimensions = New SizeF(7.0!, 13.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			Me.ClientSize = New Size(423, 155)
			Me.ControlBox = False
			Me.Controls.Add(Me.ProgressLabel)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.messageLabel)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.Margin = New Padding(3, 4, 3, 4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "DlgProcessKeppin"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "処理中ダイアログ"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

#End Region
		Public Sub New(formTitle As String, doWorkEventHandler As DoWorkEventHandler, argument As Object)
			AddHandler MyBase.Shown, AddressOf Me.DlgProcess_Shown
			Me.workerArgument = Nothing
			Me._result = Nothing
			Me.timerCount = 0L
			Me.timer = 0L
			Me._error = Nothing
			Me.InitializeComponent()
			Me.workerArgument = RuntimeHelpers.GetObjectValue(argument)
			AddHandler Me.BackgroundWorker1.DoWork, doWorkEventHandler
			Me.Text = formTitle
		End Sub

		Public ReadOnly Property Result As Object
			Get
				Return Me._result
			End Get
		End Property

		Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
			Me.Cancel_Button.Enabled = False
			Me.BackgroundWorker1.CancelAsync()
		End Sub

		Public ReadOnly Property [Error] As Exception
			Get
				Return Me._error
			End Get
		End Property

		Public ReadOnly Property BackgroundWorker As BackgroundWorker
			Get
				Return Me.BackgroundWorker1
			End Get
		End Property

		Private Sub DlgProcess_Shown(sender As Object, e As EventArgs)
			Me.BackgroundWorker1.RunWorkerAsync(RuntimeHelpers.GetObjectValue(Me.workerArgument))
			Me.Timer1.Start()
		End Sub

		Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
			Me.ProgressLabel.Text = CStr(e.UserState)
		End Sub

		Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
			If e.[Error] IsNot Nothing Then
				DlgMessageBox.Show("エラーが発生しました。" & vbCrLf & vbCrLf + e.[Error].Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me._error = e.[Error]
				Me.DialogResult = DialogResult.Abort
			ElseIf e.Cancelled Then
				Me.DialogResult = DialogResult.Cancel
			Else
				Me._result = RuntimeHelpers.GetObjectValue(e.Result)
				Me.DialogResult = DialogResult.OK
			End If
			Me.Timer1.[Stop]()
			Me.Close()
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private WithEvents TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("Cancel_Button")>
		Private WithEvents Cancel_Button As Button

		<AccessedThroughProperty("BackgroundWorker1")>
		Private WithEvents BackgroundWorker1 As BackgroundWorker

		<AccessedThroughProperty("ProgressBar1")>
		Private WithEvents ProgressBar1 As ProgressBar

		<AccessedThroughProperty("messageLabel")>
		Private WithEvents messageLabel As Label

		<AccessedThroughProperty("Timer1")>
		Private WithEvents Timer1 As Timer

		<AccessedThroughProperty("Label1")>
		Private WithEvents Label1 As Label

		<AccessedThroughProperty("ProgressLabel")>
		Private WithEvents ProgressLabel As Label

		<AccessedThroughProperty("OK_Button")>
		Private WithEvents OK_Button As Button

		Private workerArgument As Object

		Private _result As Object

		Private timerCount As Long

		Private timer As Long

		Private _error As Exception

		Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
			Dim array As String() = New String() {"", ".", "..", "...", "....", "....."}
			Dim str As String = "処理中"
			Me.Label1.Text = str + array(CInt(Me.timerCount))
			Me.timerCount += 1L
			If Me.timerCount >= CLng(array.Length) Then
				Me.timerCount = 0L
			End If
			Me.timer += 1L
			Me.messageLabel.Text = "経過時間 " + Me.timer.ToString() + " 秒"
		End Sub

	End Class
End Namespace
