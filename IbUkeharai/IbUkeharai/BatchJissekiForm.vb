Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class BatchJissekiForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.FormClosing, AddressOf Me.BatchJissekiForm_FormClosing
            AddHandler MyBase.Load, AddressOf Me.BatchMonthlyDataForm_Load
            Me._conf = Nothing
            Me._execday = Nothing
            Me.upd = Nothing
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
            Me.FormTitleLabel = New System.Windows.Forms.Label()
            Me.PasswordLabel = New System.Windows.Forms.Label()
            Me.PasswordTextBox = New System.Windows.Forms.TextBox()
            Me.InfoLabel = New System.Windows.Forms.Label()
            Me.BMD_BackButton = New System.Windows.Forms.Button()
            Me.BMD_ExecutButton = New System.Windows.Forms.Button()
            Me.NengetsuLabel = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.CclDateTimePicker = New DitCore.CclDateTimePicker(Me.components)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FormTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FormTitleLabel.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New System.Drawing.Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New System.Drawing.Size(531, 45)
            Me.FormTitleLabel.TabIndex = 6
            Me.FormTitleLabel.Text = "受払実績データ調整"
            Me.FormTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PasswordLabel
            '
            Me.PasswordLabel.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.PasswordLabel.Location = New System.Drawing.Point(23, 88)
            Me.PasswordLabel.Name = "PasswordLabel"
            Me.PasswordLabel.Size = New System.Drawing.Size(79, 20)
            Me.PasswordLabel.TabIndex = 7
            Me.PasswordLabel.Text = "パスワード"
            '
            'PasswordTextBox
            '
            Me.PasswordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.PasswordTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow
            Me.PasswordTextBox.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.PasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.PasswordTextBox.Location = New System.Drawing.Point(122, 85)
            Me.PasswordTextBox.MaxLength = 7
            Me.PasswordTextBox.Name = "PasswordTextBox"
            Me.PasswordTextBox.Size = New System.Drawing.Size(100, 19)
            Me.PasswordTextBox.TabIndex = 1
            Me.PasswordTextBox.UseSystemPasswordChar = True
            '
            'InfoLabel
            '
            Me.InfoLabel.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.InfoLabel.Location = New System.Drawing.Point(2, 190)
            Me.InfoLabel.Name = "InfoLabel"
            Me.InfoLabel.Size = New System.Drawing.Size(366, 47)
            Me.InfoLabel.TabIndex = 41
            Me.InfoLabel.Text = "※　受払実績データを編集しますので十分ご注意ください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "※　指定年月は過去３カ月までにしてください。"
            '
            'BMD_BackButton
            '
            Me.BMD_BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BMD_BackButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.BMD_BackButton.Location = New System.Drawing.Point(458, 182)
            Me.BMD_BackButton.Name = "BMD_BackButton"
            Me.BMD_BackButton.Size = New System.Drawing.Size(80, 30)
            Me.BMD_BackButton.TabIndex = 4
            Me.BMD_BackButton.Text = "戻る"
            Me.BMD_BackButton.UseVisualStyleBackColor = True
            '
            'BMD_ExecutButton
            '
            Me.BMD_ExecutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BMD_ExecutButton.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.BMD_ExecutButton.Location = New System.Drawing.Point(363, 182)
            Me.BMD_ExecutButton.Name = "BMD_ExecutButton"
            Me.BMD_ExecutButton.Size = New System.Drawing.Size(80, 30)
            Me.BMD_ExecutButton.TabIndex = 2
            Me.BMD_ExecutButton.Text = "実行"
            Me.BMD_ExecutButton.UseVisualStyleBackColor = True
            '
            'NengetsuLabel
            '
            Me.NengetsuLabel.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.NengetsuLabel.Location = New System.Drawing.Point(23, 124)
            Me.NengetsuLabel.Name = "NengetsuLabel"
            Me.NengetsuLabel.Size = New System.Drawing.Size(79, 18)
            Me.NengetsuLabel.TabIndex = 48
            Me.NengetsuLabel.Text = "指 定 年 月"
            Me.NengetsuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.IbUkeharai.My.Resources.Resources.PictureBox1
            Me.PictureBox1.InitialImage = Nothing
            Me.PictureBox1.Location = New System.Drawing.Point(441, 57)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(94, 100)
            Me.PictureBox1.TabIndex = 49
            Me.PictureBox1.TabStop = False
            '
            'Timer1
            '
            '
            'PictureBox2
            '
            Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox2.Image = Global.IbUkeharai.My.Resources.Resources.PictureBox2
            Me.PictureBox2.InitialImage = Nothing
            Me.PictureBox2.Location = New System.Drawing.Point(5, 9)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(50, 54)
            Me.PictureBox2.TabIndex = 50
            Me.PictureBox2.TabStop = False
            '
            'CclDateTimePicker
            '
            Me.CclDateTimePicker.BackColor = System.Drawing.Color.LightGoldenrodYellow
            Me.CclDateTimePicker.BkColor = System.Drawing.Color.LightGoldenrodYellow
            Me.CclDateTimePicker.CalendarFont = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.CclDateTimePicker.CustomFormat = "yyyy年MM月"
            Me.CclDateTimePicker.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.CclDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.CclDateTimePicker.Location = New System.Drawing.Point(122, 123)
            Me.CclDateTimePicker.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.CclDateTimePicker.Name = "CclDateTimePicker"
            Me.CclDateTimePicker.NullValue = ""
            Me.CclDateTimePicker.Size = New System.Drawing.Size(106, 19)
            Me.CclDateTimePicker.TabIndex = 47
            Me.CclDateTimePicker.Value = New Date(2022, 11, 15, 9, 30, 22, 0)
            '
            'BatchJissekiForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.ClientSize = New System.Drawing.Size(555, 224)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.NengetsuLabel)
            Me.Controls.Add(Me.CclDateTimePicker)
            Me.Controls.Add(Me.BMD_BackButton)
            Me.Controls.Add(Me.BMD_ExecutButton)
            Me.Controls.Add(Me.InfoLabel)
            Me.Controls.Add(Me.PasswordTextBox)
            Me.Controls.Add(Me.PasswordLabel)
            Me.Controls.Add(Me.FormTitleLabel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "BatchJissekiForm"
            Me.Text = "◆受払実績データ調整画面◆（利用は十分ご注意ください！！）"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private Function IsJissekiTable() As Boolean
            Dim result As Boolean = False
            Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
                Dim sSQL As String = String.Format("select count(*) from Ukeharai.T_UKEHARAIJISSEKI where UKEHARA_YYYYMM='{0}'", Me._execday.ToShortDateString())
                Dim sqldata As String = sqlDataBase.getSQLData(sSQL, True)
                If Operators.CompareString(sqldata, String.Empty, False) = 0 Then
                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(sqlDataBase.DbDataTable.Rows(0)(0))
                    If Conversions.ToInteger(objectValue) <> 0 Then
                        result = True
                    End If
                End If
            End Using
            Return result
        End Function

        Private Sub BatchMonthlyDataForm_Load(sender As Object, e As EventArgs)
            OutputLog.WriteLine("受払実績データ調整画面が起動されました。")
            Me.PictureBox1.Visible = False
            Me._conf = TopForm.ConfigData
            Dim cclDateTimePicker As CclDateTimePicker = Me.CclDateTimePicker
            Dim dateTime As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            cclDateTimePicker.Value = dateTime
        End Sub

        Private Sub SetEnabled(a_flg As Boolean)
            Me.PictureBox1.Visible = a_flg
            Me.PasswordTextBox.Enabled = Not a_flg
            Me.CclDateTimePicker.Enabled = Not a_flg
            Me.BMD_ExecutButton.Enabled = Not a_flg
            Me.BMD_BackButton.Enabled = Not a_flg
        End Sub

        Private Function CheckExecDay() As Boolean
            If String.IsNullOrEmpty(Me.CclDateTimePicker.Text.Trim()) Then
                Return False
            End If
            Dim dateTime As DateTime = Conversions.ToDate(Me.CclDateTimePicker.Value)
            Dim dateTime2 As New DateTime(dateTime.Year, dateTime.Month, 1)
            Dim dateTime3 As New DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, 1)
            Me._execday = DateTime.Parse(Me.CclDateTimePicker.Text.Trim())
            Return Me.IsJissekiTable()
        End Function

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If Me.upd Is Nothing Then
                Me.Timer1.[Stop]()
                DlgMessageBox.Show("処理が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.None)
                Me.PasswordTextBox.Text = String.Empty
                Me.SetEnabled(False)
            ElseIf Not Me.upd.IsRunning Then
                Me.Timer1.[Stop]()
                If Not Me.upd.IsError Then
                    DlgMessageBox.Show(String.Format("処理が完了しました。処理件数：{0}", Me.upd.cnt), "完了", MessageBoxButtons.OK, MessageBoxIcon.None)
                End If
                Me.PasswordTextBox.Text = String.Empty
                Me.SetEnabled(False)
                Me.upd = Nothing
            End If
        End Sub

        Private Sub BatchJissekiForm_FormClosing(sender As Object, e As FormClosingEventArgs)
            If Me.upd IsNot Nothing Then
                Me.upd.ThreadAbort()
                Me.upd = Nothing
            End If
        End Sub


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

        <AccessedThroughProperty("CclDateTimePicker")>
        Private WithEvents CclDateTimePicker As CclDateTimePicker

        <AccessedThroughProperty("NengetsuLabel")>
        Private WithEvents NengetsuLabel As Label

        <AccessedThroughProperty("BackgroundWorker1")>
        Private WithEvents BackgroundWorker1 As BackgroundWorker

        <AccessedThroughProperty("PictureBox1")>
        Private WithEvents PictureBox1 As PictureBox

        <AccessedThroughProperty("Timer1")>
        Private WithEvents Timer1 As Timer

        <AccessedThroughProperty("PictureBox2")>
        Private WithEvents PictureBox2 As PictureBox

        Private _conf As XmlConfigControl

        Private _execday As DateTime

        Private Const PASSWORD_KEY As String = "UH"

        Private upd As ThreadedUpdateJisseki

        Private Sub BMD_ExecutButton_Click(sender As Object, e As EventArgs) Handles BMD_ExecutButton.Click
            Cursor.Current = Cursors.WaitCursor
            If Me.PasswordTextBox.Text.Length < 1 Then
                DlgMessageBox.Show("パスワードを入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not Me.PasswordTextBox.Text.Equals("UH") Then
                DlgMessageBox.Show("パスワードが違います。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not Me.CheckExecDay() Then
                DlgMessageBox.Show("指定年月が未入力または誤りがあります。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim dialogResult As DialogResult = MessageBox.Show("処理を実行します。" & vbCrLf & "本当によろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                Return
            End If
            OutputLog.WriteLine("受払実績データ調整処理が実行されました。")
            Me.upd = New ThreadedUpdateJisseki(Me._execday)
            Me.upd.DoStart()
            Me.SetEnabled(True)
            Me.Timer1.Start()
        End Sub

        Private Sub BMD_BackButton_Click(sender As Object, e As EventArgs) Handles BMD_BackButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
