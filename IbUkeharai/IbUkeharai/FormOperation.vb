Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DitCore.Dialogs
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	Public Class FormOperation

		Public Shared Function IsInputNumber(e As KeyPressEventArgs) As Boolean
			Dim result As Boolean = False
			If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso e.KeyChar <> vbBack Then
				result = True
			End If
			Return result
		End Function

		Public Shared Function CreateBuhinCode(ByRef sCode As String) As String
			sCode = sCode.Replace("-", "")
			Dim length As Integer = sCode.Length
			Dim result As String
			If length > 10 Then
				result = String.Format("{0}-{1}-{2}-{3}", New Object() {sCode.Substring(0, 4), sCode.Substring(4, 3), sCode.Substring(7, 3), sCode.Substring(10)})
			ElseIf length > 7 Then
				result = String.Format("{0}-{1}-{2}", sCode.Substring(0, 4), sCode.Substring(4, 3), sCode.Substring(7))
			ElseIf length > 4 Then
				result = String.Format("{0}-{1}", sCode.Substring(0, 4), sCode.Substring(4))
			Else
				result = sCode
			End If
			Return result
		End Function

		Public Shared Sub OpenCreateFile(filePath As Object)
			Try
				Dim instance As Object = Nothing
				Dim typeFromHandle As Type = GetType(Process)
				Dim memberName As String = "Start"
				Dim array As Object() = New Object() {RuntimeHelpers.GetObjectValue(filePath)}
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() {True}
				NewLateBinding.LateCall(instance, typeFromHandle, memberName, arguments, argumentNames, typeArguments, array2, True)
				If array2(0) Then
					filePath = RuntimeHelpers.GetObjectValue(array(0))
				End If
			Catch ex As Exception
				DlgMessageBox.Show("表示中にエラーが発生しました。" & vbCrLf + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub
	End Class
End Namespace
