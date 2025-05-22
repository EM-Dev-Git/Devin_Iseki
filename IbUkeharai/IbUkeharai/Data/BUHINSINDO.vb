Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Data

	Public Class BUHINSINDO

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
			Me.tori_cd = val.Substring(0, 8).Trim()
			Me.buhin_cd = val.Substring(8, 12).Trim()
			Me.process = val.Substring(20, 3)
			Me.buhin_name = val.Substring(23, 20).Trim()
			Me.sign = val.Substring(43, 1)
			Me.pre_key = Conversions.ToString(Conversions.ToInteger(val.Substring(44, 4)))
			Me.first_sign = val.Substring(48, 1)
			Me.first_number = Conversions.ToInteger(val.Substring(49, 4))
			Me.second_sign = val.Substring(53, 1)
			Me.second_number = Conversions.ToInteger(val.Substring(54, 4))
			Me.third_sign = val.Substring(58, 1)
			Me.third_number = Conversions.ToInteger(val.Substring(59, 4))
			Me.fourth_sign = val.Substring(63, 1)
			Me.fourth_number = Conversions.ToInteger(val.Substring(64, 4))
			Me.fifth_sign = val.Substring(68, 1)
			Me.fifth_number = Conversions.ToInteger(val.Substring(69, 4))
			Me.sixth_sign = val.Substring(73, 1)
			Me.sixth_number = Conversions.ToInteger(val.Substring(74, 4))
			Me.seventh_sign = val.Substring(78, 1)
			Me.seventh_number = Conversions.ToInteger(val.Substring(79, 4))
			Me.eighth_sign = val.Substring(83, 1)
			Me.eighth_number = Conversions.ToInteger(val.Substring(84, 4))
			Me.ninth_sign = val.Substring(88, 1)
			Me.ninth_number = Conversions.ToInteger(val.Substring(89, 4))
			Me.tenth_sign = val.Substring(93, 1)
			Me.tenth_number = Conversions.ToInteger(val.Substring(94, 4))
			Me.eleventh_sign = val.Substring(98, 1)
			Me.eleventh_number = Conversions.ToInteger(val.Substring(99, 4))
			Me.twelfth_sign = val.Substring(103, 1)
			Me.twelfth_number = Conversions.ToInteger(val.Substring(104, 4))
			Me.thirteenth_sign = val.Substring(108, 1)
			Me.thirteenth_number = Conversions.ToInteger(val.Substring(109, 4))
			Me.fourteenth_sign = val.Substring(113, 1)
			Me.fourteenth_number = Conversions.ToInteger(val.Substring(114, 4))
			Me.fifteenth_sign = val.Substring(118, 1)
			Me.fifteenth_number = Conversions.ToInteger(val.Substring(119, 4))
			Me.sixteenth_sign = val.Substring(123, 1)
			Me.sixteenth_number = Conversions.ToInteger(val.Substring(124, 4))
			Me.seventeenth_sign = val.Substring(128, 1)
			Me.seventeenth_number = Conversions.ToInteger(val.Substring(129, 4))
			Me.eighteenth_sign = val.Substring(133, 1)
			Me.eighteenth_number = Conversions.ToInteger(val.Substring(134, 4))
			Me.nineteenth_sign = val.Substring(138, 1)
			Me.nineteenth_number = Conversions.ToInteger(val.Substring(139, 4))
			Me.twentieth_sign = val.Substring(143, 1)
			Me.twentieth_number = Conversions.ToInteger(val.Substring(144, 4))
			Me.twenty_first_sign = val.Substring(148, 1)
			Me.twenty_first_number = Conversions.ToInteger(val.Substring(149, 4))
			Me.twenty_second_sign = val.Substring(153, 1)
			Me.twenty_second_number = Conversions.ToInteger(val.Substring(154, 4))
			Me.twenty_third_sign = val.Substring(158, 1)
			Me.twenty_third_number = Conversions.ToInteger(val.Substring(159, 4))
			Me.twenty_fourth_sign = val.Substring(163, 1)
			Me.twenty_fourth_number = Conversions.ToInteger(val.Substring(164, 4))
			Me.twenty_fifth_sign = val.Substring(168, 1)
			Me.twenty_fifth_number = Conversions.ToInteger(val.Substring(169, 4))
			Me.twenty_sixth_sign = val.Substring(173, 1)
			Me.twenty_sixth_number = Conversions.ToInteger(val.Substring(174, 4))
			Me.twenty_seventh_sign = val.Substring(178, 1)
			Me.twenty_seventh_number = Conversions.ToInteger(val.Substring(179, 4))
			Me.twenty_eighth_sign = val.Substring(183, 1)
			Me.twenty_eighth_number = Conversions.ToInteger(val.Substring(184, 4))
			Me.twenty_ninth_sign = val.Substring(188, 1)
			Me.twenty_ninth_number = Conversions.ToInteger(val.Substring(189, 4))
			Me.thirtieth_sign = val.Substring(193, 1)
			Me.thirtieth_number = Conversions.ToInteger(val.Substring(194, 4))
			Me.thirtieth_first_sign = val.Substring(198, 1)
			Me.thirtieth_first_number = Conversions.ToInteger(val.Substring(199, 4))
			Me.yyyymm = val.Substring(203, 6)
		End Sub

		Private Sub SetSignValue()
			If Operators.CompareString(Me.sign, "-", False) = 0 Then
				Me.pre_key = Conversions.ToString(Conversions.ToDouble(Me.pre_key) * -1.0)
			End If
			If Operators.CompareString(Me.first_sign, "-", False) = 0 Then
				Me.first_number *= -1
			End If
			If Operators.CompareString(Me.second_sign, "-", False) = 0 Then
				Me.second_number *= -1
			End If
			If Operators.CompareString(Me.third_sign, "-", False) = 0 Then
				Me.third_number *= -1
			End If
			If Operators.CompareString(Me.fourth_sign, "-", False) = 0 Then
				Me.fourth_number *= -1
			End If
			If Operators.CompareString(Me.fifth_sign, "-", False) = 0 Then
				Me.fifth_number *= -1
			End If
			If Operators.CompareString(Me.sixth_sign, "-", False) = 0 Then
				Me.sixth_number *= -1
			End If
			If Operators.CompareString(Me.seventh_sign, "-", False) = 0 Then
				Me.seventh_number *= -1
			End If
			If Operators.CompareString(Me.eighth_sign, "-", False) = 0 Then
				Me.eighth_number *= -1
			End If
			If Operators.CompareString(Me.ninth_sign, "-", False) = 0 Then
				Me.ninth_number *= -1
			End If
			If Operators.CompareString(Me.tenth_sign, "-", False) = 0 Then
				Me.tenth_number *= -1
			End If
			If Operators.CompareString(Me.eleventh_sign, "-", False) = 0 Then
				Me.eleventh_number *= -1
			End If
			If Operators.CompareString(Me.twelfth_sign, "-", False) = 0 Then
				Me.twelfth_number *= -1
			End If
			If Operators.CompareString(Me.thirteenth_sign, "-", False) = 0 Then
				Me.thirteenth_number *= -1
			End If
			If Operators.CompareString(Me.fourteenth_sign, "-", False) = 0 Then
				Me.fourteenth_number *= -1
			End If
			If Operators.CompareString(Me.fifteenth_sign, "-", False) = 0 Then
				Me.fifteenth_number *= -1
			End If
			If Operators.CompareString(Me.sixteenth_sign, "-", False) = 0 Then
				Me.sixteenth_number *= -1
			End If
			If Operators.CompareString(Me.seventeenth_sign, "-", False) = 0 Then
				Me.seventeenth_number *= -1
			End If
			If Operators.CompareString(Me.eighteenth_sign, "-", False) = 0 Then
				Me.eighteenth_number *= -1
			End If
			If Operators.CompareString(Me.nineteenth_sign, "-", False) = 0 Then
				Me.nineteenth_number *= -1
			End If
			If Operators.CompareString(Me.twentieth_sign, "-", False) = 0 Then
				Me.twentieth_number *= -1
			End If
			If Operators.CompareString(Me.twenty_first_sign, "-", False) = 0 Then
				Me.twenty_first_number *= -1
			End If
			If Operators.CompareString(Me.twenty_second_sign, "-", False) = 0 Then
				Me.twenty_second_number *= -1
			End If
			If Operators.CompareString(Me.twenty_third_sign, "-", False) = 0 Then
				Me.twenty_third_number *= -1
			End If
			If Operators.CompareString(Me.twenty_fourth_sign, "-", False) = 0 Then
				Me.twenty_fourth_number *= -1
			End If
			If Operators.CompareString(Me.twenty_fifth_sign, "-", False) = 0 Then
				Me.twenty_fifth_number *= -1
			End If
			If Operators.CompareString(Me.twenty_sixth_sign, "-", False) = 0 Then
				Me.twenty_sixth_number *= -1
			End If
			If Operators.CompareString(Me.twenty_seventh_sign, "-", False) = 0 Then
				Me.twenty_seventh_number *= -1
			End If
			If Operators.CompareString(Me.twenty_eighth_sign, "-", False) = 0 Then
				Me.twenty_eighth_number *= -1
			End If
			If Operators.CompareString(Me.twenty_ninth_sign, "-", False) = 0 Then
				Me.twenty_ninth_number *= -1
			End If
			If Operators.CompareString(Me.thirtieth_sign, "-", False) = 0 Then
				Me.thirtieth_number *= -1
			End If
			If Operators.CompareString(Me.thirtieth_first_sign, "-", False) = 0 Then
				Me.thirtieth_first_number *= -1
			End If
		End Sub

		Public nohinsaki_cd As String

		Public tori_cd As String

		Public buhin_cd As String

		Public process As String

		Public buhin_name As String

		Public sign As String

		Public pre_key As String

		Public first_sign As String

		Public first_number As Integer

		Public second_sign As String

		Public second_number As Integer

		Public third_sign As String

		Public third_number As Integer

		Public fourth_sign As String

		Public fourth_number As Integer

		Public fifth_sign As String

		Public fifth_number As Integer

		Public sixth_sign As String

		Public sixth_number As Integer

		Public seventh_sign As String

		Public seventh_number As Integer

		Public eighth_sign As String

		Public eighth_number As Integer

		Public ninth_sign As String

		Public ninth_number As Integer

		Public tenth_sign As String

		Public tenth_number As Integer

		Public eleventh_sign As String

		Public eleventh_number As Integer

		Public twelfth_sign As String

		Public twelfth_number As Integer

		Public thirteenth_sign As String

		Public thirteenth_number As Integer

		Public fourteenth_sign As String

		Public fourteenth_number As Integer

		Public fifteenth_sign As String

		Public fifteenth_number As Integer

		Public sixteenth_sign As String

		Public sixteenth_number As Integer

		Public seventeenth_sign As String

		Public seventeenth_number As Integer

		Public eighteenth_sign As String

		Public eighteenth_number As Integer

		Public nineteenth_sign As String

		Public nineteenth_number As Integer

		Public twentieth_sign As String

		Public twentieth_number As Integer

		Public twenty_first_sign As String

		Public twenty_first_number As Integer

		Public twenty_second_sign As String

		Public twenty_second_number As Integer

		Public twenty_third_sign As String

		Public twenty_third_number As Integer

		Public twenty_fourth_sign As String

		Public twenty_fourth_number As Integer

		Public twenty_fifth_sign As String

		Public twenty_fifth_number As Integer

		Public twenty_sixth_sign As String

		Public twenty_sixth_number As Integer

		Public twenty_seventh_sign As String

		Public twenty_seventh_number As Integer

		Public twenty_eighth_sign As String

		Public twenty_eighth_number As Integer

		Public twenty_ninth_sign As String

		Public twenty_ninth_number As Integer

		Public thirtieth_sign As String

		Public thirtieth_number As Integer

		Public thirtieth_first_sign As String

		Public thirtieth_first_number As Integer

		Public yyyymm As String
	End Class
End Namespace
