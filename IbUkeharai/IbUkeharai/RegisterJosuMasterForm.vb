Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Security.Permissions
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs
Imports DitDataAccess.DataBases
Imports IbUkeharai.IbUkeharai.Util
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

    <DesignerGenerated()>
	Public Class RegisterJosuMasterForm
		Inherits RegisterBaseForm

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.RegisterTeisuMasterForm_Load
            Me.BASESQL = "SELECT TOP 1 * FROM Ukeharai.M_JOSU ORDER BY JOSU_CD DESC"
            Me.SQLUPDATE = "UPDATE Ukeharai.M_JOSU SET "
            Me._conf = Nothing
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
            Me.RTIM_CancelButton = New Button()
            Me.SyouhiZeiLabel = New Label()
            Me.PercentLabel = New Label()
            Me.SeikyuViewItemGroupBox = New GroupBox()
            Me.Account2TextBox = New TextBox()
            Me.Account1TextBox = New TextBox()
            Me.GreetDocument2TextBox = New TextBox()
            Me.GreetDocument1TextBox = New TextBox()
            Me.Address3TextBox = New TextBox()
            Me.Address2TextBox = New TextBox()
            Me.Address1TextBox = New TextBox()
            Me.txtSeqnum = New TextBox()
            Me.AccountLabel = New Label()
            Me.AccountInfoTextBox = New TextBox()
            Me.AccountInfoLabel = New Label()
            Me.GreetDocumentLabel = New Label()
            Me.AddressLabel = New Label()
            Me.OfficeNameTextBox = New TextBox()
            Me.OfficeLabel = New Label()
            Me.CompanyNameTextBox = New TextBox()
            Me.CompanyLabel = New Label()
            Me.SeikyuNumberTextBox = New TextBox()
            Me.SeikyuNumberLabel = New Label()
            Me.DistrictLabel = New Label()
            Me.DistrictNameTextBox = New TextBox()
            Me.ZirituNumericUpDown = New NumericUpDown()
            Me.SeikyuViewItemGroupBox.SuspendLayout()
            CType(Me.ZirituNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'FormTitleLabel
            '
            Me.FormTitleLabel.Text = "定数マスター登録"
            '
            'RBM_BackButton
            '
            Me.RBM_BackButton.TabIndex = 5
            '
            'RBM_ExecutButton
            '
            Me.RBM_ExecutButton.Location = New Point(691, 560)
            Me.RBM_ExecutButton.TabIndex = 3
            '
            'RTIM_CancelButton
            '
            Me.RTIM_CancelButton.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.RTIM_CancelButton.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.RTIM_CancelButton.Location = New Point(777, 560)
            Me.RTIM_CancelButton.Name = "RTIM_CancelButton"
            Me.RTIM_CancelButton.Size = New Size(80, 30)
            Me.RTIM_CancelButton.TabIndex = 4
            Me.RTIM_CancelButton.Text = "キャンセル"
            Me.RTIM_CancelButton.UseVisualStyleBackColor = True
            '
            'SyouhiZeiLabel
            '
            Me.SyouhiZeiLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SyouhiZeiLabel.Location = New Point(61, 75)
            Me.SyouhiZeiLabel.Name = "SyouhiZeiLabel"
            Me.SyouhiZeiLabel.Size = New Size(48, 18)
            Me.SyouhiZeiLabel.TabIndex = 32
            Me.SyouhiZeiLabel.Text = "消費税"
            '
            'PercentLabel
            '
            Me.PercentLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.PercentLabel.Location = New Point(204, 75)
            Me.PercentLabel.Name = "PercentLabel"
            Me.PercentLabel.Size = New Size(22, 18)
            Me.PercentLabel.TabIndex = 33
            Me.PercentLabel.Text = "%"
            '
            'SeikyuViewItemGroupBox
            '
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.Account2TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.Account1TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.GreetDocument2TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.GreetDocument1TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.Address3TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.Address2TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.Address1TextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.txtSeqnum)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.AccountLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.AccountInfoTextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.AccountInfoLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.GreetDocumentLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.AddressLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.OfficeNameTextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.OfficeLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.CompanyNameTextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.CompanyLabel)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.SeikyuNumberTextBox)
            Me.SeikyuViewItemGroupBox.Controls.Add(Me.SeikyuNumberLabel)
            Me.SeikyuViewItemGroupBox.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.SeikyuViewItemGroupBox.Location = New Point(18, 103)
            Me.SeikyuViewItemGroupBox.Name = "SeikyuViewItemGroupBox"
            Me.SeikyuViewItemGroupBox.Size = New Size(753, 409)
            Me.SeikyuViewItemGroupBox.TabIndex = 1
            Me.SeikyuViewItemGroupBox.TabStop = False
            Me.SeikyuViewItemGroupBox.Text = "請求書表示項目"
            '
            'Account2TextBox
            '
            Me.Account2TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.Account2TextBox.Location = New Point(97, 350)
            Me.Account2TextBox.MaxLength = 48
            Me.Account2TextBox.Name = "Account2TextBox"
            Me.Account2TextBox.Size = New Size(620, 20)
            Me.Account2TextBox.TabIndex = 12
            Me.Account2TextBox.Tag = "KOZA2"
            Me.Account2TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'Account1TextBox
            '
            Me.Account1TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.Account1TextBox.Location = New Point(97, 319)
            Me.Account1TextBox.MaxLength = 48
            Me.Account1TextBox.Name = "Account1TextBox"
            Me.Account1TextBox.Size = New Size(620, 20)
            Me.Account1TextBox.TabIndex = 11
            Me.Account1TextBox.Tag = "KOZA1"
            Me.Account1TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'GreetDocument2TextBox
            '
            Me.GreetDocument2TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.GreetDocument2TextBox.Location = New Point(97, 247)
            Me.GreetDocument2TextBox.MaxLength = 50
            Me.GreetDocument2TextBox.Name = "GreetDocument2TextBox"
            Me.GreetDocument2TextBox.Size = New Size(620, 20)
            Me.GreetDocument2TextBox.TabIndex = 9
            Me.GreetDocument2TextBox.Tag = "GREETING2"
            Me.GreetDocument2TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'GreetDocument1TextBox
            '
            Me.GreetDocument1TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.GreetDocument1TextBox.Location = New Point(97, 216)
            Me.GreetDocument1TextBox.MaxLength = 50
            Me.GreetDocument1TextBox.Name = "GreetDocument1TextBox"
            Me.GreetDocument1TextBox.Size = New Size(620, 20)
            Me.GreetDocument1TextBox.TabIndex = 8
            Me.GreetDocument1TextBox.Tag = "GREETING1"
            Me.GreetDocument1TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'Address3TextBox
            '
            Me.Address3TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.Address3TextBox.Location = New Point(97, 184)
            Me.Address3TextBox.MaxLength = 48
            Me.Address3TextBox.Name = "Address3TextBox"
            Me.Address3TextBox.Size = New Size(620, 20)
            Me.Address3TextBox.TabIndex = 7
            Me.Address3TextBox.Tag = "JUSYO3"
            Me.Address3TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'Address2TextBox
            '
            Me.Address2TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.Address2TextBox.Location = New Point(97, 153)
            Me.Address2TextBox.MaxLength = 48
            Me.Address2TextBox.Name = "Address2TextBox"
            Me.Address2TextBox.Size = New Size(620, 20)
            Me.Address2TextBox.TabIndex = 6
            Me.Address2TextBox.Tag = "JUSYO2"
            Me.Address2TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'Address1TextBox
            '
            Me.Address1TextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.Address1TextBox.Location = New Point(97, 122)
            Me.Address1TextBox.MaxLength = 48
            Me.Address1TextBox.Name = "Address1TextBox"
            Me.Address1TextBox.Size = New Size(620, 20)
            Me.Address1TextBox.TabIndex = 5
            Me.Address1TextBox.Tag = "JUSYO1"
            Me.Address1TextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'txtSeqnum
            '
            Me.txtSeqnum.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.txtSeqnum.ImeMode = ImeMode.Disable
            Me.txtSeqnum.Location = New Point(183, 29)
            Me.txtSeqnum.MaxLength = 5
            Me.txtSeqnum.Name = "txtSeqnum"
            Me.txtSeqnum.Size = New Size(80, 20)
            Me.txtSeqnum.TabIndex = 2
            Me.txtSeqnum.Tag = "SEQNUM"
            '
            'AccountLabel
            '
            Me.AccountLabel.Location = New Point(15, 322)
            Me.AccountLabel.Name = "AccountLabel"
            Me.AccountLabel.Size = New Size(76, 17)
            Me.AccountLabel.TabIndex = 13
            Me.AccountLabel.Text = "口座"
            '
            'AccountInfoTextBox
            '
            Me.AccountInfoTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.AccountInfoTextBox.Location = New Point(97, 288)
            Me.AccountInfoTextBox.MaxLength = 46
            Me.AccountInfoTextBox.Name = "AccountInfoTextBox"
            Me.AccountInfoTextBox.Size = New Size(620, 20)
            Me.AccountInfoTextBox.TabIndex = 10
            Me.AccountInfoTextBox.Tag = "KOZA_GUIDANCE"
            Me.AccountInfoTextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'AccountInfoLabel
            '
            Me.AccountInfoLabel.Location = New Point(15, 291)
            Me.AccountInfoLabel.Name = "AccountInfoLabel"
            Me.AccountInfoLabel.Size = New Size(76, 17)
            Me.AccountInfoLabel.TabIndex = 10
            Me.AccountInfoLabel.Text = "口座案内"
            '
            'GreetDocumentLabel
            '
            Me.GreetDocumentLabel.Location = New Point(15, 219)
            Me.GreetDocumentLabel.Name = "GreetDocumentLabel"
            Me.GreetDocumentLabel.Size = New Size(76, 17)
            Me.GreetDocumentLabel.TabIndex = 9
            Me.GreetDocumentLabel.Text = "挨拶文"
            '
            'AddressLabel
            '
            Me.AddressLabel.Location = New Point(15, 125)
            Me.AddressLabel.Name = "AddressLabel"
            Me.AddressLabel.Size = New Size(76, 17)
            Me.AddressLabel.TabIndex = 7
            Me.AddressLabel.Text = "住所"
            '
            'OfficeNameTextBox
            '
            Me.OfficeNameTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.OfficeNameTextBox.Location = New Point(97, 91)
            Me.OfficeNameTextBox.MaxLength = 34
            Me.OfficeNameTextBox.Name = "OfficeNameTextBox"
            Me.OfficeNameTextBox.Size = New Size(425, 20)
            Me.OfficeNameTextBox.TabIndex = 4
            Me.OfficeNameTextBox.Tag = "JIGYOSYO"
            Me.OfficeNameTextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'OfficeLabel
            '
            Me.OfficeLabel.Location = New Point(15, 94)
            Me.OfficeLabel.Name = "OfficeLabel"
            Me.OfficeLabel.Size = New Size(76, 17)
            Me.OfficeLabel.TabIndex = 5
            Me.OfficeLabel.Text = "事業所名"
            '
            'CompanyNameTextBox
            '
            Me.CompanyNameTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.CompanyNameTextBox.Location = New Point(97, 60)
            Me.CompanyNameTextBox.MaxLength = 26
            Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
            Me.CompanyNameTextBox.Size = New Size(330, 20)
            Me.CompanyNameTextBox.TabIndex = 3
            Me.CompanyNameTextBox.Tag = "KAISYA"
            Me.CompanyNameTextBox.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
            '
            'CompanyLabel
            '
            Me.CompanyLabel.Location = New Point(15, 63)
            Me.CompanyLabel.Name = "CompanyLabel"
            Me.CompanyLabel.Size = New Size(76, 17)
            Me.CompanyLabel.TabIndex = 2
            Me.CompanyLabel.Text = "会社名"
            '
            'SeikyuNumberTextBox
            '
            Me.SeikyuNumberTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.SeikyuNumberTextBox.ImeMode = ImeMode.Disable
            Me.SeikyuNumberTextBox.Location = New Point(97, 29)
            Me.SeikyuNumberTextBox.MaxLength = 5
            Me.SeikyuNumberTextBox.Name = "SeikyuNumberTextBox"
            Me.SeikyuNumberTextBox.Size = New Size(80, 20)
            Me.SeikyuNumberTextBox.TabIndex = 1
            Me.SeikyuNumberTextBox.Tag = "PREFIX"
            '
            'SeikyuNumberLabel
            '
            Me.SeikyuNumberLabel.Location = New Point(15, 32)
            Me.SeikyuNumberLabel.Name = "SeikyuNumberLabel"
            Me.SeikyuNumberLabel.Size = New Size(76, 17)
            Me.SeikyuNumberLabel.TabIndex = 0
            Me.SeikyuNumberLabel.Text = "請求書No."
            '
            'DistrictLabel
            '
            Me.DistrictLabel.Font = New Font("ＭＳ Ｐゴシック", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(128, Byte))
            Me.DistrictLabel.Location = New Point(61, 531)
            Me.DistrictLabel.Name = "DistrictLabel"
            Me.DistrictLabel.Size = New Size(48, 18)
            Me.DistrictLabel.TabIndex = 36
            Me.DistrictLabel.Text = "地区名"
            '
            'DistrictNameTextBox
            '
            Me.DistrictNameTextBox.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.DistrictNameTextBox.Location = New Point(115, 528)
            Me.DistrictNameTextBox.MaxLength = 6
            Me.DistrictNameTextBox.Name = "DistrictNameTextBox"
            Me.DistrictNameTextBox.Size = New Size(80, 20)
            Me.DistrictNameTextBox.TabIndex = 2
            Me.DistrictNameTextBox.Tag = "CHIKU_NAME"
            Me.DistrictNameTextBox.Text = "XXXXXX"
            '
            'ZirituNumericUpDown
            '
            Me.ZirituNumericUpDown.BorderStyle = BorderStyle.FixedSingle
            Me.ZirituNumericUpDown.DecimalPlaces = 1
            Me.ZirituNumericUpDown.Font = New Font("ＭＳ Ｐゴシック", 9.75!)
            Me.ZirituNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.ZirituNumericUpDown.Location = New Point(115, 73)
            Me.ZirituNumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
            Me.ZirituNumericUpDown.Name = "ZirituNumericUpDown"
            Me.ZirituNumericUpDown.Size = New Size(83, 20)
            Me.ZirituNumericUpDown.TabIndex = 0
            Me.ZirituNumericUpDown.Tag = "ZEIRITU"
            Me.ZirituNumericUpDown.TextAlign = HorizontalAlignment.Right
            '
            'RegisterJosuMasterForm
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = SystemColors.Control
            Me.ClientSize = New Size(955, 602)
            Me.Controls.Add(Me.ZirituNumericUpDown)
            Me.Controls.Add(Me.DistrictLabel)
            Me.Controls.Add(Me.DistrictNameTextBox)
            Me.Controls.Add(Me.SeikyuViewItemGroupBox)
            Me.Controls.Add(Me.PercentLabel)
            Me.Controls.Add(Me.SyouhiZeiLabel)
            Me.Controls.Add(Me.RTIM_CancelButton)
            Me.Name = "RegisterJosuMasterForm"
            Me.Text = "定数マスター登録画面"
            Me.TtileName = "定数マスター登録"
            Me.Controls.SetChildIndex(Me.FormTitleLabel, 0)
            Me.Controls.SetChildIndex(Me.RTIM_CancelButton, 0)
            Me.Controls.SetChildIndex(Me.SyouhiZeiLabel, 0)
            Me.Controls.SetChildIndex(Me.PercentLabel, 0)
            Me.Controls.SetChildIndex(Me.SeikyuViewItemGroupBox, 0)
            Me.Controls.SetChildIndex(Me.DistrictNameTextBox, 0)
            Me.Controls.SetChildIndex(Me.DistrictLabel, 0)
            Me.Controls.SetChildIndex(Me.ZirituNumericUpDown, 0)
            Me.Controls.SetChildIndex(Me.RBM_ExecutButton, 0)
            Me.Controls.SetChildIndex(Me.RBM_BackButton, 0)
            Me.SeikyuViewItemGroupBox.ResumeLayout(False)
            Me.SeikyuViewItemGroupBox.PerformLayout()
            CType(Me.ZirituNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private Function display() As Boolean
            Dim result As Boolean = False
            If Me._conf Is Nothing Then
                Return result
            End If
            Cursor.Current = Cursors.WaitCursor
            Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
                Dim sqldata As String = sqlDataBase.getSQLData(Me.BASESQL, False)
                If String.IsNullOrEmpty(sqldata) Then
                    Me._dataInfo = sqlDataBase.DbData
                    Me.setDisplay()
                    result = True
                Else
                    DlgMessageBox.Show("データベースに接続できない、またはテーブル構成が不正です。" & vbCrLf + sqldata, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            End Using
            Return result
        End Function

        Private Sub setDisplay()
            If Me._dataInfo Is Nothing Then
                Return
            End If
            Dim allControls As Control() = Me.GetAllControls(Me)
            Dim array As Control() = allControls
            Dim i As Integer = 0
            While i < array.Length
                Dim control As Control = array(i)
                If TypeOf control Is TextBox Then
                    GoTo IL_47
                End If
                If TypeOf control Is RichTextBox Then
                    GoTo IL_47
                End If
                If TypeOf control Is Label Then
                    GoTo IL_47
                End If
                If TypeOf control Is NumericUpDown Then
                    GoTo IL_47
                End If
IL_C7:
                i += 1
                Continue While
IL_47:
                If control.Tag Is Nothing Then
                    GoTo IL_C7
                End If
                Dim dictionary As Dictionary(Of String, Object) = Me._dataInfo.DataList(0)
                If Not dictionary.ContainsKey(Conversions.ToString(control.Tag)) Then
                    GoTo IL_C7
                End If
                If Operators.ConditionalCompareObjectEqual(control.Tag, "SEQNUM", False) Then
                    control.Text = String.Format("{0:00000}", RuntimeHelpers.GetObjectValue(dictionary("SEQNUM")))
                    GoTo IL_C7
                End If
                control.Text = dictionary(control.Tag.ToString()).ToString()
                GoTo IL_C7
            End While
        End Sub

        Public Function GetAllControls(top As Control) As Control()
            Dim arrayList As New ArrayList()
            Try
                For Each obj As Object In top.Controls
                    Dim control As Control = CType(obj, Control)
                    arrayList.Add(control)
                    arrayList.AddRange(Me.GetAllControls(control))
                Next
            Finally
                Dim enumerator As IEnumerator = Nothing
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return CType(arrayList.ToArray(GetType(Control)), Control())
        End Function

        Private Function makeSqlUpdate() As String
            Dim dictionary As New Dictionary(Of String, String)()
            Dim allControls As Control() = Me.GetAllControls(Me)
            Dim array As Control() = allControls
            Dim i As Integer = 0
            While i < array.Length
                Dim control As Control = array(i)
                If TypeOf control Is TextBox Then
                    GoTo IL_48
                End If
                If TypeOf control Is RichTextBox Then
                    GoTo IL_48
                End If
                If TypeOf control Is Label Then
                    GoTo IL_48
                End If
                If TypeOf control Is NumericUpDown Then
                    GoTo IL_48
                End If
IL_C5:
                i += 1
                Continue While
IL_48:
                If control.Tag Is Nothing Then
                    GoTo IL_C5
                End If
                Dim dictionary2 As Dictionary(Of String, Object) = Me._dataInfo.DataList(0)
                If Not dictionary2.ContainsKey(Conversions.ToString(control.Tag)) Then
                    GoTo IL_C5
                End If
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dictionary2(Conversions.ToString(control.Tag)))
                If control.Text.Equals(objectValue.ToString()) Then
                    GoTo IL_C5
                End If
                dictionary.Add(Conversions.ToString(control.Tag), control.Text)
                GoTo IL_C5
            End While
            Dim text As String = Me.SQLUPDATE
            If dictionary.Count = 0 Then
                Return String.Empty
            End If
            Try
                For Each keyValuePair As KeyValuePair(Of String, String) In dictionary
                    Dim itemInfo As ItemInfo = Me._dataInfo.ItemDetail(keyValuePair.Key)
                    If itemInfo.type Is GetType(String) OrElse itemInfo.type Is GetType(DateTime) Then
                        text = String.Concat(New String() {text, keyValuePair.Key, "='", keyValuePair.Value, "' ,"})
                    Else
                        text = String.Concat(New String() {text, keyValuePair.Key, "=", keyValuePair.Value, " ,"})
                    End If
                Next
            Finally
                Dim enumerator As Dictionary(Of String, String).Enumerator = Nothing
                CType(enumerator, IDisposable).Dispose()
            End Try
            text = text + "UPDATE_USER='" + Me._conf.xmlConfData.xDataBase.UserId + "',"
            text = text + "UPDATE_DTM='" + Conversions.ToString(DateAndTime.Now) + "',"
            text = text + "UPDATE_FUNCTION='" + Me.[GetType]().Name + "',"
            text = text.TrimEnd(New Char() {","c})
            Return text
        End Function

        <UIPermission(SecurityAction.Demand, Window:=UIPermissionWindow.AllWindows)>
        Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
            If TypeOf Me.ActiveControl Is Button Then
                Return MyBase.ProcessDialogKey(keyData)
            End If
            If (keyData And Keys.KeyCode) = Keys.[Return] AndAlso (keyData And (Keys.Control Or Keys.Alt)) = Keys.None Then
                Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)
                Return True
            End If
            Return MyBase.ProcessDialogKey(keyData)
        End Function

        Private Sub RegisterTeisuMasterForm_Load(sender As Object, e As EventArgs)
            If TopForm.ConfigData Is Nothing Then
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            Me._conf = TopForm.ConfigData
            If Not Me.display() Then
                Me.Close()
            End If
        End Sub

        Private Sub CheckInputLength(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, txtSeqnum.KeyPress, SeikyuNumberTextBox.KeyPress, CompanyNameTextBox.KeyPress, OfficeNameTextBox.KeyPress, GreetDocument2TextBox.KeyPress, GreetDocument1TextBox.KeyPress, DistrictNameTextBox.KeyPress, Address3TextBox.KeyPress, Address2TextBox.KeyPress, Address1TextBox.KeyPress, AccountInfoTextBox.KeyPress, Account2TextBox.KeyPress, Account1TextBox.KeyPress
            If e.KeyChar = vbBack Then
                Return
            End If
            Dim textBox As TextBox = CType(sender, TextBox)
            If Common.LenB(textBox.Text + e.KeyChar.ToString()) > textBox.MaxLength Then
                e.Handled = True
            End If
            If Operators.ConditionalCompareObjectEqual(textBox.Tag, "SEQNUM", False) AndAlso (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) Then
                e.Handled = True
            End If
        End Sub

        Private components As IContainer

        <AccessedThroughProperty("RTIM_CancelButton")>
        Private WithEvents RTIM_CancelButton As Button

        <AccessedThroughProperty("SyouhiZeiLabel")>
        Private WithEvents SyouhiZeiLabel As Label

        <AccessedThroughProperty("PercentLabel")>
        Private WithEvents PercentLabel As Label

        <AccessedThroughProperty("SeikyuViewItemGroupBox")>
        Private WithEvents SeikyuViewItemGroupBox As GroupBox

        <AccessedThroughProperty("AccountLabel")>
        Private WithEvents AccountLabel As Label

        <AccessedThroughProperty("AccountInfoTextBox")>
        Private WithEvents AccountInfoTextBox As TextBox

        <AccessedThroughProperty("AccountInfoLabel")>
        Private WithEvents AccountInfoLabel As Label

        <AccessedThroughProperty("GreetDocumentLabel")>
        Private WithEvents GreetDocumentLabel As Label

        <AccessedThroughProperty("AddressLabel")>
        Private WithEvents AddressLabel As Label

        <AccessedThroughProperty("OfficeNameTextBox")>
        Private WithEvents OfficeNameTextBox As TextBox

        <AccessedThroughProperty("OfficeLabel")>
        Private WithEvents OfficeLabel As Label

        <AccessedThroughProperty("CompanyNameTextBox")>
        Private WithEvents CompanyNameTextBox As TextBox

        <AccessedThroughProperty("CompanyLabel")>
        Private WithEvents CompanyLabel As Label

        <AccessedThroughProperty("SeikyuNumberTextBox")>
        Private WithEvents SeikyuNumberTextBox As TextBox

        <AccessedThroughProperty("SeikyuNumberLabel")>
        Private WithEvents SeikyuNumberLabel As Label

        <AccessedThroughProperty("DistrictLabel")>
        Private WithEvents DistrictLabel As Label

        <AccessedThroughProperty("DistrictNameTextBox")>
        Private WithEvents DistrictNameTextBox As TextBox

        <AccessedThroughProperty("ZirituNumericUpDown")>
        Private WithEvents ZirituNumericUpDown As NumericUpDown

        <AccessedThroughProperty("txtSeqnum")>
        Private WithEvents txtSeqnum As TextBox

        <AccessedThroughProperty("Address3TextBox")>
        Private WithEvents Address3TextBox As TextBox

        <AccessedThroughProperty("Address2TextBox")>
        Private WithEvents Address2TextBox As TextBox

        <AccessedThroughProperty("Address1TextBox")>
        Private WithEvents Address1TextBox As TextBox

        <AccessedThroughProperty("GreetDocument2TextBox")>
        Private WithEvents GreetDocument2TextBox As TextBox

        <AccessedThroughProperty("GreetDocument1TextBox")>
        Private WithEvents GreetDocument1TextBox As TextBox

        <AccessedThroughProperty("Account2TextBox")>
        Private WithEvents Account2TextBox As TextBox

        <AccessedThroughProperty("Account1TextBox")>
        Private WithEvents Account1TextBox As TextBox

        Private BASESQL As String

        Private SQLUPDATE As String

        Private _conf As XmlConfigControl

        Private _dataInfo As SqlDataBase.DataInfomation

        Private Sub RBM_ExecutButton_Click_1(sender As Object, e As EventArgs) Handles RBM_ExecutButton.Click
            Cursor.Current = Cursors.WaitCursor
            Dim text As String = Me.makeSqlUpdate()
            If String.IsNullOrEmpty(text) Then
                DlgMessageBox.Show("変更項目がありませんでした。", "変更なし", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return
            End If
            Using sqlDataBase As New SqlDataBase(Me._conf.xmlConfData.xDataBase)
                Try
                    If sqlDataBase.execSql(text) Then
                        DlgMessageBox.Show("正常に更新されました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                    Me.display()
                Catch ex As Exception
                    DlgMessageBox.Show("SQL実行中にエラーが発生しました。" & vbCrLf & "SQL文:" + text + vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End Try
            End Using
        End Sub

        Private Sub RTIM_CancelButton_Click(sender As Object, e As EventArgs) Handles RTIM_CancelButton.Click
            Me.display()
        End Sub
    End Class
End Namespace
