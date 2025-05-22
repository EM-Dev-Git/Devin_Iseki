Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Data

	Public Class SISAN

		Public Sub New(val As String, nohinsaki As String)
			Me.SetParameters(val, nohinsaki)
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
			Me.kbn = val.Substring(0, 1)
			Me.tori_cd = val.Substring(1, 8).Trim()
			Me.buhin_cd = val.Substring(9, 12).Trim()
			Me.process = val.Substring(21, 3)
			Me.buhin_name = val.Substring(24, 20).Trim()
			Me.tani = val.Substring(44, 2)
			Me.tori_short = val.Substring(46, 7)
			Me.yyyymm = val.Substring(53, 6)
			Me.jan_yyyymm = val.Substring(59, 6)
			Me.jan_number = Conversions.ToInteger(val.Substring(65, 7))
			Me.feb_yyyymm = val.Substring(72, 6)
			Me.feb_number = Conversions.ToInteger(val.Substring(78, 7))
			Me.mar_yyyymm = val.Substring(85, 6)
			Me.mar_number = Conversions.ToInteger(val.Substring(91, 7))
			Me.apr_yyyymm = val.Substring(98, 6)
			Me.apr_number = Conversions.ToInteger(val.Substring(104, 7))
			Me.may_yyyymm = val.Substring(111, 6)
			Me.may_number = Conversions.ToInteger(val.Substring(117, 7))
			Me.jun_yyyymm = val.Substring(124, 6)
			Me.jun_number = Conversions.ToInteger(val.Substring(130, 7))
			Me.jul_yyyymm = val.Substring(137, 6)
			Me.jul_number = Conversions.ToInteger(val.Substring(143, 7))
			Me.aug_yyyymm = val.Substring(150, 6)
			Me.aug_number = Conversions.ToInteger(val.Substring(156, 7))
			Me.sep_yyyymm = val.Substring(163, 6)
			Me.sep_number = Conversions.ToInteger(val.Substring(169, 7))
			Me.oct_yyyymm = val.Substring(176, 6)
			Me.oct_number = Conversions.ToInteger(val.Substring(182, 7))
			Me.nov_yyyymm = val.Substring(189, 6)
			Me.nov_number = Conversions.ToInteger(val.Substring(195, 7))
			Me.dec_yyyymm = val.Substring(202, 6)
			Me.dec_number = Conversions.ToInteger(val.Substring(208, 7))
			Me.factory = Conversions.ToInteger(val.Substring(215, 8))
			Me._0000D = Conversions.ToInteger(val.Substring(223, 7))
			Me.kariuke = Conversions.ToInteger(val.Substring(230, 7))
			Me.zengetu = Conversions.ToInteger(val.Substring(237, 7))
			Me.total = Conversions.ToInteger(val.Substring(244, 7))
			Me.cyuzan = Conversions.ToInteger(val.Substring(251, 7))
			Me.naiji = Conversions.ToInteger(val.Substring(258, 7))
			Me.process_day = val.Substring(265, 8)
		End Sub

		Public nohinsaki_cd As String

		Public kbn As String

		Public tori_cd As String

		Public buhin_cd As String

		Public process As String

		Public buhin_name As String

		Public tani As String

		Public tori_short As String

		Public yyyymm As String

		Public jan_yyyymm As String

		Public jan_number As Integer

		Public feb_yyyymm As String

		Public feb_number As Integer

		Public mar_yyyymm As String

		Public mar_number As Integer

		Public apr_yyyymm As String

		Public apr_number As Integer

		Public may_yyyymm As String

		Public may_number As Integer

		Public jun_yyyymm As String

		Public jun_number As Integer

		Public jul_yyyymm As String

		Public jul_number As Integer

		Public aug_yyyymm As String

		Public aug_number As Integer

		Public sep_yyyymm As String

		Public sep_number As Integer

		Public oct_yyyymm As String

		Public oct_number As Integer

		Public nov_yyyymm As String

		Public nov_number As Integer

		Public dec_yyyymm As String

		Public dec_number As Integer

		Public factory As Integer

		Public _0000D As Integer

		Public kariuke As Integer

		Public zengetu As Integer

		Public total As Integer

		Public cyuzan As Integer

		Public naiji As Integer

		Public process_day As String
	End Class
End Namespace
