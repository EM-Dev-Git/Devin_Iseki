Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports DitCore.Classes
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	<DesignerGenerated()>
	Public Class frmLogo
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
			Me.PictureBox1 = New PictureBox()
			Me.lblMainTitle = New Label()
			Me.lblVersion = New Label()
			Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			'PictureBox1
			'
			Me.PictureBox1.BackColor = Color.Transparent
			Me.PictureBox1.Dock = DockStyle.Fill
			Me.PictureBox1.Image = Global.IbUkeharai.My.Resources.Resources.logo
			Me.PictureBox1.InitialImage = Nothing
			Me.PictureBox1.Location = New Point(0, 0)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Size(502, 302)
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			'
			'lblMainTitle
			'
			Me.lblMainTitle.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
			Or AnchorStyles.Right), AnchorStyles)
			Me.lblMainTitle.BackColor = Color.White
			Me.lblMainTitle.Font = New Font("ＭＳ Ｐゴシック", 15.75!, FontStyle.Bold, GraphicsUnit.Point, CType(128, Byte))
			Me.lblMainTitle.ForeColor = Color.Black
			Me.lblMainTitle.Location = New Point(310, 221)
			Me.lblMainTitle.Name = "lblMainTitle"
			Me.lblMainTitle.Size = New Size(188, 31)
			Me.lblMainTitle.TabIndex = 4
			Me.lblMainTitle.Text = "受払管理システム"
			Me.lblMainTitle.TextAlign = ContentAlignment.MiddleCenter
			'
			'lblVersion
			'
			Me.lblVersion.BackColor = Color.Transparent
			Me.lblVersion.Font = New Font("Cambria", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
			Me.lblVersion.ForeColor = Color.White
			Me.lblVersion.Location = New Point(352, 267)
			Me.lblVersion.Name = "lblVersion"
			Me.lblVersion.Size = New Size(140, 19)
			Me.lblVersion.TabIndex = 5
			Me.lblVersion.Text = "Version 0.0.0.00"
			Me.lblVersion.TextAlign = ContentAlignment.MiddleRight
			'
			'Timer2
			'
			Me.Timer2.Interval = 1000
			'
			'frmLogo
			'
			Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackgroundImageLayout = ImageLayout.Center
			Me.ClientSize = New Size(502, 302)
			Me.Controls.Add(Me.lblVersion)
			Me.Controls.Add(Me.lblMainTitle)
			Me.Controls.Add(Me.PictureBox1)
			Me.Cursor = Cursors.AppStarting
			Me.FormBorderStyle = FormBorderStyle.None
			Me.Name = "frmLogo"
			Me.Text = "frmLogo"
			Me.TopMost = True
			CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
#End Region
		Public Property RunFlag As Boolean
			Get
				Return Me._runFlag
			End Get
			Set(value As Boolean)
				Me._runFlag = value
			End Set
		End Property

		Public Sub StartTask()
			Me.Thread1 = New Thread(AddressOf Me.Tasks.SomeTask)
			Me.Tasks.ConfigData = Me._configData
			Me.Thread1.Start()
		End Sub

		Public Sub New()

			AddHandler MyBase.Load, AddressOf Me.frmLogo_Load
			Me._runFlag = False
			Me.Tasks = New TasksClass()
			Me.InitializeComponent()

		End Sub

		Private Sub frmLogo_Load(sender As Object, e As EventArgs)
			Me.iCnt = 0
			Me.Timer2.Start()
			Me.PictureBox1.Controls.Add(Me.lblVersion)
			Me.lblVersion.Top = Me.lblVersion.Top - Me.PictureBox1.Top
			Me.lblVersion.Left = Me.lblVersion.Left - Me.PictureBox1.Left
			Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
			Dim version As Version = executingAssembly.GetName().Version
			Me.lblVersion.Text = "Version " + version.ToString()
			Me.StartTask()
		End Sub

		Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

			' The following expression was wrapped in a checked-statement
			Me.iCnt += 1
			If Me.Thread1 Is Nothing Then
				Return
			End If
			If Me.Thread1.IsAlive Then
				Return
			End If
			Me.RunFlag = Me.Tasks.RetVal
			If Me.iCnt >= 2 Then
				Me._configData = Me.Tasks.ConfigData
				Me.Close()
			End If
		End Sub

		Private components As IContainer

		<AccessedThroughProperty("PictureBox1")>
		Private WithEvents PictureBox1 As PictureBox

		<AccessedThroughProperty("lblMainTitle")>
		Private WithEvents lblMainTitle As Label

		<AccessedThroughProperty("lblVersion")>
		Private WithEvents lblVersion As Label

		Public _configData As XmlConfigControl

		Private iCnt As Integer

		Private _runFlag As Boolean

		Private Tasks As TasksClass
		Friend WithEvents Timer2 As Windows.Forms.Timer

		Private Thread1 As Thread
	End Class
End Namespace
