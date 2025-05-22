Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Data

	Public Class CYUZAN

		Public Sub New(val As String, nohinsaki As String)
			Me.SetParameters(val, nohinsaki)
			Me.SetSignValue()
		End Sub

		Public Sub SetParameters(val As String, nohinsaki As String)
			If Operators.CompareString(nohinsaki, "Matsuyama", False) = 0 Then
				Me.nohinsaki_cd = "M"
			ElseIf Operators.CompareString(nohinsaki, "Kumamoto", False) = 0 Then
				Me.nohinsaki_cd = "K"
			Else
				If Operators.CompareString(nohinsaki, "Shigenobu", False) <> 0 Then
					Return
				End If
				Me.nohinsaki_cd = "S"
			End If
			Me.buhin_cd = val.Substring(0, 12).Trim()
			Me.saisinhensen = val.Substring(12, 1)
			Me.process = val.Substring(13, 3)
			Me.buhin_name = val.Substring(16, 20).Trim()
			If Operators.CompareString(val.Substring(36, 8).Trim(), "00000000", False) = 0 Then
				Me.hacyu_yyyymmdd = Nothing
			Else
				Me.hacyu_yyyymmdd = DateTime.Parse(String.Format("{0}/{1}/{2}", val.Substring(36, 4), val.Substring(40, 2), val.Substring(42, 2)))
			End If
			If Operators.CompareString(val.Substring(44, 8).Trim(), "", False) = 0 Then
				Me.noki_yyyymmdd = Nothing
			Else
				Me.noki_yyyymmdd = DateTime.Parse(String.Format("{0}/{1}/{2}", val.Substring(44, 4), val.Substring(48, 2), val.Substring(50, 2)))
			End If
			Me.hacyu_no = Conversions.ToString(Conversions.ToInteger(val.Substring(52, 6)))
			Me.hacyu_fugo = val.Substring(58, 1)
			Me.hacyu_su = Conversions.ToString(Conversions.ToInteger(val.Substring(59, 7)))
			Me.nonyu_fugo = val.Substring(66, 1)
			Me.nonyu_su = Conversions.ToString(Conversions.ToInteger(val.Substring(67, 7)))
			Me.cyuzan_fugo = val.Substring(74, 1)
			Me.cyuzan_su = Conversions.ToString(Conversions.ToInteger(val.Substring(75, 7)))
			Me.tori_cd = val.Substring(82, 8).Trim()
			Me.order_cd = val.Substring(90, 12).Trim()
		End Sub

		Private Sub SetSignValue()
			If Operators.CompareString(Me.hacyu_fugo, "-", False) = 0 Then
				Me.hacyu_su = Conversions.ToString(Conversions.ToDouble(Me.hacyu_su) * -1.0)
			End If
			If Operators.CompareString(Me.nonyu_fugo, "-", False) = 0 Then
				Me.nonyu_su = Conversions.ToString(Conversions.ToDouble(Me.nonyu_su) * -1.0)
			End If
			If Operators.CompareString(Me.cyuzan_fugo, "-", False) = 0 Then
				Me.cyuzan_su = Conversions.ToString(Conversions.ToDouble(Me.cyuzan_su) * -1.0)
			End If
		End Sub

		Public nohinsaki_cd As String

		Public buhin_cd As String

		Public saisinhensen As String

		Public process As String

		Public buhin_name As String

		Public hacyu_yyyymmdd As DateTime

		Public noki_yyyymmdd As DateTime

		Public hacyu_no As String

		Public hacyu_fugo As String

		Public hacyu_su As String

		Public nonyu_fugo As String

		Public nonyu_su As String

		Public cyuzan_fugo As String

		Public cyuzan_su As String

		Public tori_cd As String

		Public order_cd As String
	End Class
End Namespace
