Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic

Namespace DitCore.Dialogs
    Partial Public Class DlgProcess
        Inherits Form

#Region "変数・定数"

        Private workerArgument As Object

        Private _result As Object

        Private timerCount As Long

        Private _error As Exception

#End Region

#Region "画面初期化"

        Public Sub New(formTitle As String, doWorkEventHandler As DoWorkEventHandler, argument As Object)
            AddHandler MyBase.Shown, AddressOf Me.DlgProcess_Shown
            Me.workerArgument = Nothing
            Me._result = Nothing
            Me.timerCount = 0L
            Me._error = Nothing
            Me.InitializeComponent()
            Me.workerArgument = RuntimeHelpers.GetObjectValue(argument)
            AddHandler Me.BackgroundWorker1.DoWork, doWorkEventHandler
            Me.Text = formTitle
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        '''  DoWorkイベントハンドラで設定された結果
        '''  </summary>
        Public ReadOnly Property Result As Object
            Get
                Return Me._result
            End Get
        End Property

        ''' <summary>
        ''' エラー
        ''' </summary>
        Public ReadOnly Property [Error] As Exception
            Get
                Return Me._error
            End Get
        End Property

        ''' <summary>
        '''  処理中ダイアログで使用しているBackgroundWorkerクラス
        '''  </summary>
        Public ReadOnly Property BackgroundWorker As BackgroundWorker
            Get
                Return Me.BackgroundWorker1
            End Get
        End Property

#End Region

#Region " イベント "

        ''' <summary>
        ''' OKボタン押下
        ''' </summary>
        Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        ''' <summary>
        ''' 中止ボタン押下
        ''' </summary>
        Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
            Me.Cancel_Button.Enabled = False
            Me.BackgroundWorker1.CancelAsync()
        End Sub

        'コーディングでハンドリング済
        ''' <summary>
        ''' フォーム表示
        ''' </summary>
        Private Sub DlgProcess_Shown(sender As Object, e As EventArgs)
            Me.BackgroundWorker1.RunWorkerAsync(RuntimeHelpers.GetObjectValue(Me.workerArgument))
            Me.Timer1.Start()
        End Sub

        ''' <summary>
        '''  バックグラウンド 更新処理
        '''  </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
            Dim progressPercentage As Integer = e.ProgressPercentage
            If progressPercentage < Me.ProgressBar1.Minimum Then
                Me.ProgressBar1.Value = Me.ProgressBar1.Minimum
            ElseIf Me.ProgressBar1.Maximum < progressPercentage Then
                Me.ProgressBar1.Value = Me.ProgressBar1.Maximum
            Else
                Me.ProgressBar1.Value = progressPercentage
            End If
            Me.messageLabel.Text = CStr(e.UserState)
        End Sub

        ''' <summary>
        '''  バックグラウンド操作の完了時、キャンセル時、またはバックグラウンド操作によって例外発生処理
        '''  </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
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

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  タイマー Tick イベント処理
        '''  </summary>
        ''' 	<param name="sender">オブジェクト</param>
        ''' 	<param name="e">イベント情報</param>
        ''' ------------------------------------------------------------------------
        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Dim array As String() = New String() {"", ".", "..", "...", "....", "....."}
            Dim str As String = "処理中"
            Me.Label1.Text = str + array(CInt(Me.timerCount))
            Me.timerCount += 1L
            If Me.timerCount >= CLng(array.Length) Then
                Me.timerCount = 0L
            End If
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

#End Region

    End Class
End Namespace
