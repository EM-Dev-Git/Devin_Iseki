Imports System
Imports System.Net.Mime.MediaTypeNames
Imports System.Threading
Imports System.Windows.Forms
Imports DitCore.Classes
Imports DitCore.Dialogs

Namespace IbUkeharai
	Public Class Program

		<STAThread()>
		Public Shared Sub Main()
			System.Windows.Forms.Application.EnableVisualStyles()
			Dim mutex As New Mutex(False, "井関物流　受払管理システム")
			If Not mutex.WaitOne(0, False) Then
				DlgMessageBox.Show("既に受払管理システムが起動してます。" & vbCrLf & "起動中のシステムを閉じて再度実施してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
			End If
			AddHandler System.Windows.Forms.Application.ThreadException, AddressOf Program.Application_ThreadException
			AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf Program.CurrentDomain_UnhandledException
			System.Windows.Forms.Application.Run(New TopForm())
			mutex.ReleaseMutex()
		End Sub

		Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
			Try
				DlgMessageBox.Show(CType(e.ExceptionObject, Exception).Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				OutputLog.WriteLine("Unhandled Exception!! : " + CType(e.ExceptionObject, Exception).Message)
			Finally
			End Try
		End Sub

		Private Shared Sub Application_ThreadException(sender As Object, e As ThreadExceptionEventArgs)
			Try
				DlgMessageBox.Show(e.Exception.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				OutputLog.WriteLine("Thread Exception!! : " + e.Exception.Message)
			Finally
			End Try
		End Sub
	End Class
End Namespace
