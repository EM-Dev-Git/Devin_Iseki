Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class TopForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Activated, AddressOf Me.TopForm_Activated
            AddHandler MyBase.Load, AddressOf Me.TopForm_Load
            AddHandler MyBase.Resize, AddressOf Me.frmMain_Resize
            Me._topForm = Nothing
            Me._childForm = Nothing
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
            Me.TitlePanel = New Panel()
            Me.VersionLabel = New LinkLabel()
            Me.FormTitleLabel = New Label()
            Me.MenuPanel = New Panel()
            Me.CloseButton = New Button()
            Me.SeikyuMenuButton = New Button()
            Me.CreatDataMenuButton = New Button()
            Me.BatchMenuButton = New Button()
            Me.InquiryMenuButton = New Button()
            Me.RegisterButton = New Button()
            Me.MainPanel = New Panel()
            Me.Panel1 = New Panel()
            Me.StatusStrip1 = New StatusStrip()
            Me.LocationLabel = New ToolStripStatusLabel()
            Me.TitlePanel.SuspendLayout()
            Me.MenuPanel.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.StatusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TitlePanel
            '
            Me.TitlePanel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.TitlePanel.Controls.Add(Me.VersionLabel)
            Me.TitlePanel.Location = New Point(0, -1)
            Me.TitlePanel.Name = "TitlePanel"
            Me.TitlePanel.Size = New Size(784, 89)
            Me.TitlePanel.TabIndex = 0
            '
            'VersionLabel
            '
            Me.VersionLabel.AutoSize = True
            Me.VersionLabel.BackColor = Color.Transparent
            Me.VersionLabel.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.VersionLabel.Location = New Point(698, 10)
            Me.VersionLabel.Name = "VersionLabel"
            Me.VersionLabel.Size = New Size(63, 13)
            Me.VersionLabel.TabIndex = 2
            Me.VersionLabel.TabStop = True
            Me.VersionLabel.Text = "バージョン"
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.FormTitleLabel.BackColor = Color.CornflowerBlue
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 24.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Image = Global.IbUkeharai.My.Resources.Resources.FormTitleLabel
            Me.FormTitleLabel.Location = New Point(0, 29)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(784, 89)
            Me.FormTitleLabel.TabIndex = 1
            Me.FormTitleLabel.Text = "受払システム　メニュー"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'MenuPanel
            '
            Me.MenuPanel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left), AnchorStyles)
            Me.MenuPanel.BorderStyle = BorderStyle.Fixed3D
            Me.MenuPanel.Controls.Add(Me.CloseButton)
            Me.MenuPanel.Controls.Add(Me.SeikyuMenuButton)
            Me.MenuPanel.Controls.Add(Me.CreatDataMenuButton)
            Me.MenuPanel.Controls.Add(Me.BatchMenuButton)
            Me.MenuPanel.Controls.Add(Me.InquiryMenuButton)
            Me.MenuPanel.Controls.Add(Me.RegisterButton)
            Me.MenuPanel.Location = New Point(0, 121)
            Me.MenuPanel.Name = "MenuPanel"
            Me.MenuPanel.Size = New Size(199, 476)
            Me.MenuPanel.TabIndex = 1
            '
            'CloseButton
            '
            Me.CloseButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CloseButton.Location = New Point(16, 403)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New Size(163, 36)
            Me.CloseButton.TabIndex = 5
            Me.CloseButton.Text = "終了"
            Me.CloseButton.UseVisualStyleBackColor = True
            '
            'SeikyuMenuButton
            '
            Me.SeikyuMenuButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SeikyuMenuButton.Location = New Point(16, 262)
            Me.SeikyuMenuButton.Name = "SeikyuMenuButton"
            Me.SeikyuMenuButton.Size = New Size(163, 36)
            Me.SeikyuMenuButton.TabIndex = 4
            Me.SeikyuMenuButton.Text = "請求メニュー"
            Me.SeikyuMenuButton.UseVisualStyleBackColor = True
            '
            'CreatDataMenuButton
            '
            Me.CreatDataMenuButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CreatDataMenuButton.Location = New Point(16, 200)
            Me.CreatDataMenuButton.Name = "CreatDataMenuButton"
            Me.CreatDataMenuButton.Size = New Size(163, 36)
            Me.CreatDataMenuButton.TabIndex = 3
            Me.CreatDataMenuButton.Text = "データ作成メニュー"
            Me.CreatDataMenuButton.UseVisualStyleBackColor = True
            '
            'BatchMenuButton
            '
            Me.BatchMenuButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.BatchMenuButton.Location = New Point(16, 141)
            Me.BatchMenuButton.Name = "BatchMenuButton"
            Me.BatchMenuButton.Size = New Size(163, 36)
            Me.BatchMenuButton.TabIndex = 2
            Me.BatchMenuButton.Text = "バッチ処理メニュー"
            Me.BatchMenuButton.UseVisualStyleBackColor = True
            '
            'InquiryMenuButton
            '
            Me.InquiryMenuButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.InquiryMenuButton.Location = New Point(16, 81)
            Me.InquiryMenuButton.Name = "InquiryMenuButton"
            Me.InquiryMenuButton.Size = New Size(163, 36)
            Me.InquiryMenuButton.TabIndex = 1
            Me.InquiryMenuButton.Text = "問合せメニュー"
            Me.InquiryMenuButton.UseVisualStyleBackColor = True
            '
            'RegisterButton
            '
            Me.RegisterButton.Font = New Font("ＭＳ Ｐゴシック", 11.25!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RegisterButton.Location = New Point(16, 24)
            Me.RegisterButton.Name = "RegisterButton"
            Me.RegisterButton.Size = New Size(163, 36)
            Me.RegisterButton.TabIndex = 0
            Me.RegisterButton.Text = "登録メニュー"
            Me.RegisterButton.UseVisualStyleBackColor = True
            '
            'MainPanel
            '
            Me.MainPanel.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.MainPanel.BorderStyle = BorderStyle.Fixed3D
            Me.MainPanel.Location = New Point(198, 121)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Size = New Size(586, 476)
            Me.MainPanel.TabIndex = 2
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.StatusStrip1)
            Me.Panel1.Location = New Point(0, 568)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New Size(784, 28)
            Me.Panel1.TabIndex = 3
            '
            'StatusStrip1
            '
            Me.StatusStrip1.Items.AddRange(New ToolStripItem() {Me.LocationLabel})
            Me.StatusStrip1.Location = New Point(0, 2)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.RightToLeft = RightToLeft.Yes
            Me.StatusStrip1.Size = New Size(780, 22)
            Me.StatusStrip1.SizingGrip = False
            Me.StatusStrip1.TabIndex = 0
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'LocationLabel
            '
            Me.LocationLabel.Font = New Font("ＭＳ Ｐゴシック", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.LocationLabel.ImageAlign = ContentAlignment.MiddleRight
            Me.LocationLabel.Name = "LocationLabel"
            Me.LocationLabel.Size = New Size(85, 17)
            Me.LocationLabel.Text = "LocationLabel"
            Me.LocationLabel.TextAlign = ContentAlignment.MiddleLeft
            '
            'TopForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(784, 598)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.MainPanel)
            Me.Controls.Add(Me.FormTitleLabel)
            Me.Controls.Add(Me.MenuPanel)
            Me.Controls.Add(Me.TitlePanel)
            Me.FormBorderStyle = FormBorderStyle.Fixed3D
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "TopForm"
            Me.Text = "受払システム"
            Me.TitlePanel.ResumeLayout(False)
            Me.TitlePanel.PerformLayout()
            Me.MenuPanel.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub TopForm_Load(sender As Object, e As EventArgs)
            Using frmLogo As New frmLogo()
                frmLogo.StartPosition = FormStartPosition.CenterScreen
                frmLogo.ShowDialog()
                TopForm.ConfigData = frmLogo._configData
                If Not frmLogo.RunFlag Then
                    DlgMessageBox.Show("設定値に誤りがあります。" & vbCrLf & "修正後再起動してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return
                End If
                If Operators.CompareString(TopForm.ConfigData.xmlConfData.Kyoten, "Matsuyama", False) = 0 Then
                    Me.LocationLabel.Text = "松山"
                ElseIf Operators.CompareString(TopForm.ConfigData.xmlConfData.Kyoten, "Kumamoto", False) = 0 Then
                    Me.LocationLabel.Text = "熊本"
                ElseIf Operators.CompareString(TopForm.ConfigData.xmlConfData.Kyoten, "Buhin", False) = 0 Then
                    Me.LocationLabel.Text = "部品松山"
                End If
            End Using
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
        End Sub

        Private Sub frmMain_Resize(sender As Object, e As EventArgs)
            If Me._childForm Is Nothing Then
                Return
            End If
            Dim childForm As Form = Me._childForm
            Dim size As New Size(Me.MainPanel.Size.Width, Me.MainPanel.Size.Height)
            childForm.Size = size
        End Sub

        Private Function ShowChildForm(childForm As Form) As Object
            If childForm Is Nothing Then
                Return False
            End If
            If Not Me.CloseFormAll() Then
                Return False
            End If
            childForm.Owner = Me
            childForm.TopLevel = False
            Me.MainPanel.Controls.Add(childForm)
            childForm.Show()
            childForm.BringToFront()
            Me._childForm = childForm
            Me.ActiveControl = childForm
            Dim childForm2 As Form = Me._childForm
            Dim size As New Size(Me.MainPanel.Size.Width, Me.MainPanel.Size.Height)
            childForm2.Size = size
            Return True
        End Function

        Private Function CloseFormAll() As Boolean
            Try
                For Each obj As Object In Me.MainPanel.Controls
                    Dim control As Control = CType(obj, Control)
                    If TypeOf control Is Form Then
                        CType(control, Form).Close()
                        Me.MainPanel.Controls.Remove(control)
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return True
        End Function

        Private Sub TopForm_Activated(sender As Object, e As EventArgs)
            Me.TopMost = True
            Me.TopMost = False
        End Sub

        Private Sub VersionLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VersionLabel.LinkClicked
            Me.VersionLabel.LinkVisited = True
            Dim versionForm As New VersionForm()
            versionForm.ShowDialog()
            versionForm.Dispose()
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("TitlePanel")>
        Private WithEvents TitlePanel As Panel

        <AccessedThroughProperty("MenuPanel")>
        Private WithEvents MenuPanel As Panel

        <AccessedThroughProperty("RegisterButton")>
        Private WithEvents RegisterButton As Button

        <AccessedThroughProperty("MainPanel")>
        Private WithEvents MainPanel As Panel

        <AccessedThroughProperty("InquiryMenuButton")>
        Private WithEvents InquiryMenuButton As Button

        <AccessedThroughProperty("BatchMenuButton")>
        Private WithEvents BatchMenuButton As Button

        <AccessedThroughProperty("CreatDataMenuButton")>
        Private WithEvents CreatDataMenuButton As Button

        <AccessedThroughProperty("SeikyuMenuButton")>
        Private WithEvents SeikyuMenuButton As Button

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("CloseButton")>
        Private WithEvents CloseButton As Button

        <AccessedThroughProperty("VersionLabel")>
        Private WithEvents VersionLabel As LinkLabel

        <AccessedThroughProperty("Panel1")>
        Private WithEvents Panel1 As Panel

        <AccessedThroughProperty("StatusStrip1")>
        Private WithEvents StatusStrip1 As StatusStrip

        <AccessedThroughProperty("LocationLabel")>
        Private WithEvents LocationLabel As ToolStripStatusLabel

        Public _topForm As Form

        Public _childForm As Form

        Private Const LOG_FOLDER As String = "log"

        Public Shared ConfigData As XmlConfigControl

        Private Sub RegisterButton_Click_1(sender As Object, e As EventArgs) Handles RegisterButton.Click
            Dim childForm As Form = New RegisterMenuForm()
            Me.ShowChildForm(childForm)
        End Sub

        Private Sub InquiryMenuButton_Click(sender As Object, e As EventArgs) Handles InquiryMenuButton.Click
            Dim childForm As Form = New InquiryMenuForm()
            Me.ShowChildForm(childForm)
        End Sub

        Private Sub BatchMenuButton_Click(sender As Object, e As EventArgs) Handles BatchMenuButton.Click
            Dim childForm As Form = New BatchMenuForm()
            Me.ShowChildForm(childForm)
        End Sub

        Private Sub CreatDataMenuButton_Click(sender As Object, e As EventArgs) Handles CreatDataMenuButton.Click
            Dim childForm As Form = New CreatDataMenuForm()
            Me.ShowChildForm(childForm)
        End Sub

        Private Sub SeikyuMenuButton_Click(sender As Object, e As EventArgs) Handles SeikyuMenuButton.Click
            Dim childForm As Form = New SeikyuMenuForm()
            Me.ShowChildForm(childForm)
        End Sub

        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
