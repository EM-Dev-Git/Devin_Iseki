Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace DitCore.Dialogs
    Partial Public Class DlgMessageBox
        Inherits Form

#Region "変数・定数"

        Private Const TEXT_ABORT As String = "中止(&A)"

        ''' <summary>再試行ボタンのボタンテキスト</summary>
        Private Const TEXT_RETRY As String = "再試行(&R)"

        Private Const TEXT_IGNORE As String = "無視(&I)"

        ''' <summary>OKボタンのボタンテキスト</summary>
        Private Const TEXT_OK As String = "OK"

        Private Const TEXT_CANCEL As String = "キャンセル"

        ''' <summary>はいボタンのボタンテキスト</summary>
        Private Const TEXT_YES As String = "はい(&Y)"

        Private Const TEXT_NO As String = "いいえ(&N)"

        ''' <summary>メッセージ表示領域の上側のオフセット値</summary>
        Private Const OFFSET_TOP As Integer = 10

        Private Const OFFSET_BOTTOM As Integer = 10

        ''' <summary>メッセージ表示領域の左側のオフセット値</summary>
        Private Const OFFSET_LEFT As Integer = 10

        Private Const OFFSET_RIGHT As Integer = 10

        ''' <summary>ボタンの間隔</summary>
        Private Const BUTTON_SPACE As Integer = 10

        Private Const BUTTON_LEFT As Integer = 20

        ''' <summary>メッセージ表示領域の右側のオフセット値</summary>
        Private Const BUTTON_RIGHT As Integer = 20

        Private Const NewLine As String = "<\n>"

        ''' <summary>自身の最小の高さ</summary>
        Private _iMinHeight As Integer

        Private _iMinWidth As Integer

        ''' <summary>チェックコントロール状態</summary>
        Private Shared _blnChecked As Boolean = False

#End Region

#Region "画面初期化"
        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  クラスコンストラクタ
        '''  </summary>
        ''' ------------------------------------------------------------------------
        Private Sub New(IsUseErroInfoBurron As Boolean)
            AddHandler MyBase.Load, AddressOf Me.frmMessageBox_Load
            AddHandler MyBase.Shown, AddressOf Me.frmMessageBox_Shown
            Me.InitializeComponent()
            Me._iMinHeight = Me.pnlIcon.Height + Me.pnlButtonBase.Height
            Me._iMinWidth = Me.pnlButtonBase.Width
            Me.DialogResult = DialogResult.Cancel
            Me.TopMost = True
        End Sub
#End Region

#Region " イベント "

        'コーディングでハンドリング済
        ''' <summary>
        ''' フォーム初期表示
        ''' </summary>
        Private Sub frmMessageBox_Load(sender As Object, e As EventArgs)
            Me.SuspendLayout()
        End Sub

        'コーディングでハンドリング済
        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  フォーム表示直後イベント
        '''  </summary>
        ''' ------------------------------------------------------------------------
        Private Sub frmMessageBox_Shown(sender As Object, e As EventArgs)
            Me.ResumeLayout()
            Me.TopMost = False
            Me.Activate()
        End Sub

        Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles btn01.Click, btn02.Click, btn03.Click
            Dim button As Button = TryCast(sender, Button)
            If button Is Nothing Then
                Return
            End If
            Dim text As String = button.Text
            Dim dialogResult As DialogResult
            If Operators.CompareString(text, "中止(&A)", False) = 0 Then
                dialogResult = DialogResult.Abort
            ElseIf Operators.CompareString(text, "キャンセル", False) = 0 Then
                dialogResult = DialogResult.Cancel
            ElseIf Operators.CompareString(text, "無視(&I)", False) = 0 Then
                dialogResult = DialogResult.Ignore
            ElseIf Operators.CompareString(text, "いいえ(&N)", False) = 0 Then
                dialogResult = DialogResult.No
            ElseIf Operators.CompareString(text, "OK", False) = 0 Then
                dialogResult = DialogResult.OK
            ElseIf Operators.CompareString(text, "再試行(&R)", False) = 0 Then
                dialogResult = DialogResult.Retry
            ElseIf Operators.CompareString(text, "はい(&Y)", False) = 0 Then
                dialogResult = DialogResult.Yes
            Else
                dialogResult = DialogResult.None
            End If
            Me.DialogResult = dialogResult
            Me.Close()
        End Sub

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  チェックボタン押下
        '''  </summary>
        ''' ------------------------------------------------------------------------
        Private Sub chkButton_CheckedChanged(sender As Object, e As EventArgs) Handles chkButton.CheckedChanged
            DlgMessageBox._blnChecked = Me.chkButton.Checked
        End Sub

#End Region

#Region "関数"

        Public Overloads Shared Function Show(sMessage As String) As DialogResult
            Return DlgMessageBox.Show(sMessage, " ", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.None)
        End Function

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  ダイアログ表示
        '''  </summary>
        ''' 	<param name="sMessage">表示メッセージ</param>
        ''' 	<param name="sCaption">ダイアログキャプション</param>
        ''' 	<returns>結果</returns>
        ''' 	<remarks>アイコンは表示せずボタンは「OK」のみ。</remarks>
        ''' ------------------------------------------------------------------------
        Public Overloads Shared Function Show(sMessage As String, sCaption As String) As DialogResult
            Return DlgMessageBox.Show(sMessage, sCaption, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.None)
        End Function

        Public Overloads Shared Function Show(sMessage As String, sCaption As String, enmButtons As MessageBoxButtons) As DialogResult
            Return DlgMessageBox.Show(sMessage, sCaption, String.Empty, enmButtons, MessageBoxIcon.None)
        End Function

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  ダイアログを表示
        '''  </summary>
        ''' 	<param name="sMessage">表示メッセージ</param>
        ''' 	<param name="sCaption">ダイアログキャプション</param>
        ''' 	<param name="enmButtons">表示ボタンセット</param>
        ''' 	<param name="enmIcon">表示アイコン</param>
        ''' 	<returns>結果</returns>
        ''' ------------------------------------------------------------------------
        Public Overloads Shared Function Show(sMessage As String, sCaption As String, enmButtons As MessageBoxButtons, enmIcon As MessageBoxIcon) As DialogResult
            Return DlgMessageBox.Show(sMessage, sCaption, String.Empty, enmButtons, enmIcon)
        End Function

        Public Overloads Shared Function Show(sMessage As String, sCaption As String, sChkButton As String, enmButtons As MessageBoxButtons, enmIcon As MessageBoxIcon) As DialogResult
            Dim dlgMessageBox As New DlgMessageBox(False)
            dlgMessageBox.Text = sCaption
            dlgMessageBox.SetIcon(enmIcon)
            dlgMessageBox.SetBackColor(enmIcon)
            dlgMessageBox.SetMessage(sMessage)
            dlgMessageBox.SetButtons(enmButtons)
            dlgMessageBox.SetCheckButton(sChkButton)
            Dim num As Integer = dlgMessageBox.pnlIcon.Width + dlgMessageBox.pnlMessageBase.Width
            If num < dlgMessageBox._iMinWidth Then
                num = dlgMessageBox._iMinWidth
            End If
            If num < dlgMessageBox.pnlButtonBase.Width Then
                num = dlgMessageBox.pnlButtonBase.Width
            End If
            Dim num2 As Integer = dlgMessageBox.pnlMessageBase.Height + dlgMessageBox.pnlButtonBase.Height
            If num2 < dlgMessageBox._iMinHeight Then
                num2 = dlgMessageBox._iMinHeight
            End If
            dlgMessageBox.SetClientSizeCore(num, num2)
            DlgMessageBox._blnChecked = dlgMessageBox.chkButton.Checked
            Return dlgMessageBox.ShowDialog()
        End Function

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  アイコンセット
        '''  </summary>
        ''' 	<param name="enmIcon">アイコンの指定</param>
        ''' ------------------------------------------------------------------------
        Private Sub SetIcon(enmIcon As MessageBoxIcon)
            Dim icon As Icon
            Select Case enmIcon
                Case MessageBoxIcon.Hand
                    icon = SystemIcons.[Error]
                    GoTo IL_FC
                Case MessageBoxIcon.Question
                    icon = SystemIcons.Question
                    GoTo IL_FC
                Case MessageBoxIcon.Exclamation
                    icon = SystemIcons.Warning
                    GoTo IL_FC
                Case MessageBoxIcon.Asterisk
                    icon = SystemIcons.Information
                    GoTo IL_FC
            End Select
            Me.pnlIcon.Width = 0
            Return
IL_FC:
            Me.picIcon.Image = icon.ToBitmap()
        End Sub

        Private Sub SetBackColor(enmIcon As MessageBoxIcon)
            Dim backColor As Color = Color.FromArgb(255, 255, 255)
            Me.BackColor = backColor
            backColor = SystemColors.Control
            Me.pnlButtonBase.BackColor = backColor
        End Sub

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  メッセージセット
        '''  </summary>
        ''' 	<param name="sMessage">セットするメッセージ</param>
        ''' 	<remarks>メッセージは規定の文字列を改行コードに置換</remarks>
        ''' ------------------------------------------------------------------------
        Private Sub SetMessage(sMessage As String)
            sMessage = sMessage.Replace("<\n>", Environment.NewLine)
            Dim separator As String() = New String() {Environment.NewLine}
            Dim array As String() = sMessage.Split(separator, StringSplitOptions.None)
            Dim num As Integer = 10
            Dim num2 As Integer = 0
            Dim label As New Label()
            label.AutoSize = True
            Dim control As Control = label
            Dim location As New Point(0, 0)
            control.Location = location
            Me.pnlMessageBase.Controls.Add(label)
            Dim num3 As Integer = array.Count() * label.Height
            If num3 < Me.pnlMessageBase.Height Then
                num = CInt(Math.Round(CDbl((Me.pnlMessageBase.Height - num3)) / 2.0))
            End If
            For Each text As String In array
                Dim label2 As New Label()
                label2.AutoSize = True
                label2.UseMnemonic = False
                label2.Text = text
                Dim control2 As Control = label2
                location = New Point(10, num)
                control2.Location = location
                Me.pnlMessageBase.Controls.Add(label2)
                If label2.Width + 10 > num2 Then
                    num2 = label2.Width + 10
                End If
                num += label2.Height
            Next
            Me.pnlMessageBase.Height = num + 10
            Me.pnlMessageBase.Width = num2 + 10 + 10
            Me.pnlMessageBase.Left = Me.pnlIcon.Width
        End Sub

        Private Sub SetButtons(enmButtons As MessageBoxButtons)
            Select Case enmButtons
                Case MessageBoxButtons.OK
                    Me.SetButton(1, "OK")
                    Me.SetButton(2, String.Empty)
                    Me.SetButton(3, String.Empty)
                    Me.AcceptButton = Me.btn02
                Case MessageBoxButtons.OKCancel
                    Me.SetButton(1, "OK")
                    Me.SetButton(2, "キャンセル")
                    Me.SetButton(3, String.Empty)
                    Me.AcceptButton = Me.btn01
                Case MessageBoxButtons.AbortRetryIgnore
                    Me.SetButton(1, "中止(&A)")
                    Me.SetButton(2, "再試行(&R)")
                    Me.SetButton(3, "無視(&I)")
                    Me.AcceptButton = Me.btn01
                Case MessageBoxButtons.YesNoCancel
                    Me.SetButton(1, "はい(&Y)")
                    Me.SetButton(2, "いいえ(&N)")
                    Me.SetButton(3, "キャンセル")
                    Me.AcceptButton = Me.btn01
                Case MessageBoxButtons.YesNo
                    Me.SetButton(1, "はい(&Y)")
                    Me.SetButton(2, "いいえ(&N)")
                    Me.SetButton(3, String.Empty)
                    Me.AcceptButton = Me.btn01
                Case MessageBoxButtons.RetryCancel
                    Me.SetButton(1, "再試行(&R)")
                    Me.SetButton(2, "キャンセル")
                    Me.SetButton(3, String.Empty)
                    Me.AcceptButton = Me.btn01
                Case Else
                    Me.SetButton(1, "OK")
                    Me.SetButton(2, String.Empty)
                    Me.SetButton(3, String.Empty)
                    Me.AcceptButton = Me.btn02
            End Select
            Me.SetButtonLocation()
        End Sub

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  ボタンを設定
        '''  </summary>
        ''' 	<param name="iNo">設定するボタン番号</param>
        ''' 	<param name="sText">設定するテキスト(Emptyの場合は表示を隠す)</param>
        ''' ------------------------------------------------------------------------
        Private Sub SetButton(iNo As Integer, sText As String)
            Dim button As Button
            Select Case iNo
                Case 1
                    button = Me.btn01
                Case 2
                    button = Me.btn02
                Case 3
                    button = Me.btn03
                Case Else
                    Return
            End Select
            button.Text = sText
            If String.IsNullOrEmpty(sText) Then
                button.Visible = False
            End If
        End Sub

        Private Sub SetButtonLocation()
            Dim num As Integer = 0
            If Not String.IsNullOrEmpty(Me.btn01.Text) Then
                num += 1
            End If
            If Not String.IsNullOrEmpty(Me.btn02.Text) Then
                num += 1
            End If
            If Not String.IsNullOrEmpty(Me.btn03.Text) Then
                num += 1
            End If
            Dim width As Integer = Me.btn01.Width
            Dim num2 As Integer
            If Me.pnlButtonBase.Width > Me.pnlIcon.Width + Me.pnlMessageBase.Width Then
                num2 = Me.pnlButtonBase.Width
            Else
                num2 = Me.pnlIcon.Width + Me.pnlMessageBase.Width
            End If
            Dim num3 As Integer = width
            Dim num4 As Integer = 1
            Dim num5 As Integer = num - 1
            For i As Integer = num4 To num5
                num3 += width + 10
            Next
            Dim num6 As Integer
            If num2 > num3 + 20 + 20 Then
                num6 = CInt(Math.Round(CDbl((num2 - num3)) / 2.0))
            Else
                Me.pnlButtonBase.Width = num3 + 20 + 20
                num6 = 20
            End If
            If Not String.IsNullOrEmpty(Me.btn01.Text) Then
                Me.btn01.Left = num6
                num6 += Me.btn01.Width + 10
            End If
            If Not String.IsNullOrEmpty(Me.btn02.Text) Then
                Me.btn02.Left = num6
                num6 += Me.btn02.Width + 10
            End If
            If Not String.IsNullOrEmpty(Me.btn03.Text) Then
                Me.btn03.Left = num6
                num6 += Me.btn03.Width + 10
            End If
        End Sub

        ''' ------------------------------------------------------------------------
        '''  <summary>
        '''  チェックボタン表示
        '''  </summary>
        ''' 	<param name="sChackMessage">表示メッセージ</param>
        ''' ------------------------------------------------------------------------
        Private Sub SetCheckButton(sChackMessage As String)
            Me.chkButton.Visible = False
            Me.chkButton.Checked = False
            DlgMessageBox._blnChecked = False
            If Not String.IsNullOrEmpty(sChackMessage) Then
                Me.chkButton.Visible = True
                Me.chkButton.Text = sChackMessage
                Me.chkButton.Top = Me.pnlMessageBase.Height - Me.chkButton.Height + 10
                If Me.chkButton.Left + Me.chkButton.Width > Me.pnlMessageBase.Width Then
                    Me.pnlMessageBase.Width = Me.chkButton.Left + Me.chkButton.Width
                End If
                Me.pnlMessageBase.Height = Me.pnlMessageBase.Height + 10 + Me.chkButton.Height
            End If
        End Sub
#End Region

    End Class
End Namespace
