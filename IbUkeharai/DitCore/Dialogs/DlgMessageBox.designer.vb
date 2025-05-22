Imports System.Drawing
Imports System.Windows.Forms

Namespace DitCore.Dialogs

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class DlgMessageBox
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
            Me.components = New Global.System.ComponentModel.Container()
            Dim resource As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgMessageBox))
            Me.pnlIcon = New Panel()
            Me.picIcon = New PictureBox()
            Me.pnlMessageBase = New Panel()
            Me.chkButton = New CheckBox()
            Me.pnlButtonBase = New Panel()
            Me.btn03 = New Button()
            Me.btn02 = New Button()
            Me.btn01 = New Button()
            Me.pnlIcon.SuspendLayout()
            CType(Me.picIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMessageBase.SuspendLayout()
            Me.pnlButtonBase.SuspendLayout()
            Me.SuspendLayout()
            Me.pnlIcon.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left)
            Me.pnlIcon.BackColor = Color.Transparent
            Me.pnlIcon.Controls.Add(Me.picIcon)
            Me.pnlIcon.Name = "pnlIcon"
            Me.pnlIcon.Location = New Point(0, 0)
            Me.pnlIcon.Margin = New Padding(10)
            Me.pnlIcon.Size = New Size(52, 70)

            Me.pnlIcon.TabIndex = 0
            Me.picIcon.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
            Me.picIcon.Name = "picIcon"
            Me.picIcon.Location = New Point(15, 17)
            Me.picIcon.Size = New Size(32, 40)

            Me.picIcon.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picIcon.TabIndex = 0
            Me.picIcon.TabStop = False
            Me.pnlMessageBase.BackColor = Color.Transparent
            Me.pnlMessageBase.Controls.Add(Me.chkButton)
            Me.pnlMessageBase.Name = "pnlMessageBase"
            Me.pnlMessageBase.Location = New Point(53, 0)
            Me.pnlMessageBase.Size = New Size(243, 70)

            Me.pnlMessageBase.TabIndex = 1
            Me.chkButton.Anchor = AnchorStyles.Left
            Me.chkButton.AutoSize = True
            Me.chkButton.Name = "chkButton"
            Me.chkButton.Location = New Point(10, 50)
            Me.chkButton.Size = New Size(15, 14)

            Me.chkButton.TabIndex = 0
            Me.chkButton.UseVisualStyleBackColor = True
            Me.pnlButtonBase.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
            Me.pnlButtonBase.Controls.Add(Me.btn03)
            Me.pnlButtonBase.Controls.Add(Me.btn02)
            Me.pnlButtonBase.Controls.Add(Me.btn01)
            Me.pnlButtonBase.Name = "pnlButtonBase"
            Me.pnlButtonBase.Location = New Point(0, 70)
            Me.pnlButtonBase.Size = New Size(296, 44)

            Me.pnlButtonBase.TabIndex = 2
            Me.btn03.Name = "btn03"
            Me.btn03.Location = New Point(74, 7)
            Me.btn03.Size = New Size(86, 30)

            Me.btn03.TabIndex = 2
            Me.btn03.Text = "ボタン３"
            Me.btn03.UseVisualStyleBackColor = True
            Me.btn02.Name = "btn02"
            Me.btn02.Location = New Point(43, 7)
            Me.btn02.Size = New Size(86, 30)

            Me.btn02.TabIndex = 1
            Me.btn02.Text = "ボタン２"
            Me.btn02.UseVisualStyleBackColor = True
            Me.btn01.Name = "btn01"
            Me.btn01.Location = New Point(12, 7)
            Me.btn01.Size = New Size(86, 30)

            Me.btn01.TabIndex = 0
            Me.btn01.Text = "ボタン１"
            Me.btn01.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As SizeF = New SizeF(7.0F, 18.0F)
            Me.AutoScaleDimensions = autoScaleDimensions
            Me.AutoScaleMode = AutoScaleMode.Font

            Me.ClientSize = New Size(296, 114)
            Me.ControlBox = False
            Me.Controls.Add(Me.pnlButtonBase)
            Me.Controls.Add(Me.pnlMessageBase)
            Me.Controls.Add(Me.pnlIcon)
            Me.Font = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 128)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Padding = New Padding(3, 4, 3, 4)
            Me.Margin = Padding
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "DlgMessageBox"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "System"
            Me.pnlIcon.ResumeLayout(False)
            CType(Me.picIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMessageBase.ResumeLayout(False)
            Me.pnlMessageBase.PerformLayout()
            Me.pnlButtonBase.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub
        Private WithEvents pnlIcon As Panel
        Private WithEvents picIcon As PictureBox
        Private WithEvents pnlMessageBase As Panel
        Private WithEvents chkButton As CheckBox
        Private WithEvents pnlButtonBase As Panel
        Private WithEvents btn01 As Button
        Private WithEvents btn02 As Button
        Private WithEvents btn03 As Button
    End Class
End Namespace
