Imports System.Drawing
Imports System.Windows.Forms

Namespace DitCore.Dialogs

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class DlgProcess
        Inherits Form


        <Global.System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Windows フォーム デザイナーで必要です。
        Private components As System.ComponentModel.IContainer


        <Global.System.Diagnostics.DebuggerStepThrough()>
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
            Me.Timer1.Interval = 500
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New Font("メイリオ", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.Label1.ForeColor = SystemColors.HotTrack
            Me.Label1.Location = New Point(16, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(48, 20)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "処理中"
            '
            'DlgProcess
            '
            Me.AcceptButton = Me.OK_Button
            Me.AutoScaleDimensions = New SizeF(8.0!, 20.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.Cancel_Button
            Me.ClientSize = New Size(423, 155)
            Me.ControlBox = False
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.messageLabel)
            Me.Controls.Add(Me.ProgressBar1)
            Me.Font = New Font("メイリオ", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.Margin = Me.Margin
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "DlgProcess"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "処理中ダイアログ"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents TableLayoutPanel1 As TableLayoutPanel
        Private WithEvents OK_Button As Button
        Private WithEvents Cancel_Button As Button
        Private WithEvents BackgroundWorker1 As Global.System.ComponentModel.BackgroundWorker
        Private WithEvents ProgressBar1 As ProgressBar
        Private WithEvents messageLabel As Label
        Private WithEvents Timer1 As Timer
        Private WithEvents Label1 As Label
    End Class
End Namespace
