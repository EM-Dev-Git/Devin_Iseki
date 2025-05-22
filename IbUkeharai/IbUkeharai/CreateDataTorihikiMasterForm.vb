Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class CreateDataTorihikiMasterForm
		Inherits Form

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.CreatDataTorihikitMasterForm_Load
            Me.csvDirectory = Path.Combine("csv", "56.取引先マスタ")
            Me.csvFileName = "56.取引先マスタ.csv"
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
            Me.CTM_BackButton = New Button()
            Me.CTM_ExecutButton = New Button()
            Me.ResultLabel = New Label()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.FormTitleLabel.BackColor = Color.SlateBlue
            Me.FormTitleLabel.Font = New Font("ＭＳ Ｐゴシック", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.FormTitleLabel.ForeColor = SystemColors.ButtonHighlight
            Me.FormTitleLabel.Location = New Point(12, 9)
            Me.FormTitleLabel.Name = "FormTitleLabel"
            Me.FormTitleLabel.Size = New Size(760, 45)
            Me.FormTitleLabel.TabIndex = 8
            Me.FormTitleLabel.Text = "取引先マスターデータ作成"
            Me.FormTitleLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'InfoLabel
            '
            Me.InfoLabel.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.InfoLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.InfoLabel.ForeColor = Color.Black
            Me.InfoLabel.Location = New Point(240, 130)
            Me.InfoLabel.Name = "InfoLabel"
            Me.InfoLabel.Size = New Size(320, 40)
            Me.InfoLabel.TabIndex = 32
            Me.InfoLabel.Text = "取引先マスターのデータをCSVファイルに出力します。"
            Me.InfoLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'CTM_BackButton
            '
            Me.CTM_BackButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.CTM_BackButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CTM_BackButton.Location = New Point(687, 520)
            Me.CTM_BackButton.Name = "CTM_BackButton"
            Me.CTM_BackButton.Size = New Size(80, 30)
            Me.CTM_BackButton.TabIndex = 5
            Me.CTM_BackButton.Text = "戻る"
            Me.CTM_BackButton.UseVisualStyleBackColor = True
            '
            'CTM_ExecutButton
            '
            Me.CTM_ExecutButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.CTM_ExecutButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.CTM_ExecutButton.Location = New Point(601, 520)
            Me.CTM_ExecutButton.Name = "CTM_ExecutButton"
            Me.CTM_ExecutButton.Size = New Size(80, 30)
            Me.CTM_ExecutButton.TabIndex = 3
            Me.CTM_ExecutButton.Text = "実行"
            Me.CTM_ExecutButton.UseVisualStyleBackColor = True
            '
            'ResultLabel
            '
            Me.ResultLabel.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
            Me.ResultLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.ResultLabel.ForeColor = Color.Black
            Me.ResultLabel.Location = New Point(240, 190)
            Me.ResultLabel.Name = "ResultLabel"
            Me.ResultLabel.Size = New Size(320, 40)
            Me.ResultLabel.TabIndex = 33
            Me.ResultLabel.Text = "ここに結果を表示します。"
            Me.ResultLabel.TextAlign = ContentAlignment.MiddleCenter
            '
            'CreateDataTorihikiMasterForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(784, 562)
            Me.Controls.Add(Me.ResultLabel)
            Me.Controls.Add(Me.CTM_BackButton)
            Me.Controls.Add(Me.CTM_ExecutButton)
            Me.Controls.Add(Me.InfoLabel)
            Me.Controls.Add(Me.FormTitleLabel)
            Dim ico As Icon = Global.IbUkeharai.My.Resources.Resources.this64
            Me.Icon = ico
            Me.Name = "CreateDataTorihikiMasterForm"
            Me.Text = "取引先マスターデータ作成画面"
            Me.ResumeLayout(False)

        End Sub
#End Region
        Private Sub CreatDataTorihikitMasterForm_Load(sender As Object, e As EventArgs)
            Me.ResultLabel.Text = String.Empty
        End Sub


        Private components As IContainer

        <AccessedThroughProperty("FormTitleLabel")>
        Private WithEvents FormTitleLabel As Label

        <AccessedThroughProperty("InfoLabel")>
        Private WithEvents InfoLabel As Label

        <AccessedThroughProperty("CTM_BackButton")>
        Private WithEvents CTM_BackButton As Button

        <AccessedThroughProperty("CTM_ExecutButton")>
        Private WithEvents CTM_ExecutButton As Button

        <AccessedThroughProperty("ResultLabel")>
        Private WithEvents ResultLabel As Label

        Private csvDirectory As String

        Private csvFileName As String

        Private Sub CTM_ExecutButton_Click(sender As Object, e As EventArgs) Handles CTM_ExecutButton.Click
            Me.ResultLabel.Text = Nothing
            Dim dialogResult As DialogResult = MessageBox.Show("CSVファイルを出力します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                Return
            End If
            Dim configData As XmlConfigControl = TopForm.ConfigData
            Dim dbDataTable As DataTable
            Using sqlDataBase As New SqlDataBase(configData.xmlConfData.xDataBase)
                Dim text As String = "SELECT TORI_CD AS 取引先コード, TORI_NAME AS 取引先名 FROM Ukeharai.M_TORI"
                Dim sqldata As String = sqlDataBase.getSQLData(text, True)
                If Not String.IsNullOrEmpty(sqldata) Then
                    DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
                    Return
                End If
                dbDataTable = sqlDataBase.DbDataTable
            End Using
            Dim text2 As String = Path.Combine(FileSystem.CurDir(), Me.csvDirectory)
            If Not Directory.Exists(text2) Then
                Directory.CreateDirectory(text2)
            End If
            Dim count As Integer = dbDataTable.Rows.Count
            Dim csvPath As String = Path.Combine(text2, Me.csvFileName)
            Dim csvCommon As New CsvCommon()
            If Not csvCommon.ConvertDataTableToCsv(dbDataTable, csvPath, True) Then
                DlgMessageBox.Show("別のプログラムによってファイルが開かれています。" & vbCrLf & "ファイルを閉じてから再実行してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If
            DlgMessageBox.Show("CSV出力が完了しました。", "完了", MessageBoxButtons.OK)
            Me.ResultLabel.Text = count.ToString() + " 件のデータを出力しました。"
        End Sub

        Private Sub CTM_BackButton_Click(sender As Object, e As EventArgs) Handles CTM_BackButton.Click
            Me.Close()
        End Sub
    End Class
End Namespace
