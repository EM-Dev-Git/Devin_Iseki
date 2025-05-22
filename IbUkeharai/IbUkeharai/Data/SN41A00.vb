Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Data

	Public Class SN41A00

		Public Sub New(val As String)
			Me.CHECK_KUBUN = "81"
			Me.CHECK_ORDER_VALUE = "99999"
			Me.SetParameters(val)
			Me.SetSignValue()
			Me.CheckOderValue()
		End Sub

		Public Sub SetParameters(val As String)
			Me.tori_cd = val.Substring(0, 8).Trim()
			Me.buhin_cd = val.Substring(8, 12).Trim()
			Me.acceptMMDD = val.Substring(20, 4)
			Me.dispatchMMDD = val.Substring(24, 4)
			Me.order_NO = val.Substring(28, 6)
			Me.set_NO = val.Substring(34, 5)
			Me.sign_kosu = val.Substring(39, 1)
			Me.kosu = Conversions.ToInteger(val.Substring(40, 7))
			Me.order_cd = val.Substring(47, 12)
			Me.kubun = val.Substring(59, 2)
			Me.sign_money = val.Substring(61, 1)
			Me.money = Conversions.ToInteger(val.Substring(62, 11))
			Me.saki_cd = val.Substring(73, 2)
		End Sub

		Private Sub SetSignValue()
			' The following expression was wrapped in a checked-statement
			If Operators.CompareString(Me.sign_kosu, "-", False) = 0 Then
				Me.kosu *= -1
			End If
			If Operators.CompareString(Me.sign_money, "-", False) = 0 Then
				Me.money *= -1
			End If
		End Sub

		Private Sub CheckOderValue()
			If Operators.CompareString(Me.kubun, Me.CHECK_KUBUN, False) <> 0 Or Operators.CompareString(Me.order_cd.Substring(0, 5), Me.CHECK_ORDER_VALUE, False) = 0 Then
				Me.order_cd = "            "
			End If
		End Sub

		Public tori_cd As String

		Public buhin_cd As String

		Public acceptMMDD As String

		Public dispatchMMDD As String

		Public order_NO As String

		Public set_NO As String

		Public sign_kosu As String

		Public kosu As Integer

		Public order_cd As String

		Public kubun As String

		Public sign_money As String

		Public money As Integer

		Public saki_cd As String

		Private CHECK_KUBUN As String

		Private CHECK_ORDER_VALUE As String
	End Class
End Namespace
