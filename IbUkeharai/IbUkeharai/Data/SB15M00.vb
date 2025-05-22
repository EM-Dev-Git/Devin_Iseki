Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Data

	Public Class SB15M00
		Public Sub New(val As String)
			Me.SetParameters(val)
		End Sub

		Private Sub SetParameters(val As String)
			Me.tori_cd = val.Substring(0, 8).Trim()
			Me.buhin_cd = val.Substring(8, 12).Trim()
			Me.datalist = New List(Of SB15M00.MonthData)()
			Dim monthData As SB15M00.MonthData = New SB15M00.MonthData()
			monthData.dateYMD = DateTime.Parse(String.Format("{0}/{1}/01", val.Substring(20, 4), val.Substring(24, 2)))
			monthData.kosu = Conversions.ToInteger(val.Substring(26, 7))
			Me.datalist.Add(monthData)
			Dim monthData2 As SB15M00.MonthData = New SB15M00.MonthData()
			monthData2.dateYMD = DateTime.Parse(String.Format("{0}/{1}/01", val.Substring(33, 4), val.Substring(37, 2)))
			monthData2.kosu = Conversions.ToInteger(val.Substring(39, 7))
			Me.datalist.Add(monthData2)
			Dim monthData3 As SB15M00.MonthData = New SB15M00.MonthData()
			monthData3.dateYMD = DateTime.Parse(String.Format("{0}/{1}/01", val.Substring(46, 4), val.Substring(50, 2)))
			monthData3.kosu = Conversions.ToInteger(val.Substring(52, 7))
			Me.datalist.Add(monthData3)
			Dim monthData4 As SB15M00.MonthData = New SB15M00.MonthData()
			monthData4.dateYMD = DateTime.Parse(String.Format("{0}/{1}/01", val.Substring(59, 4), val.Substring(63, 2)))
			monthData4.kosu = Conversions.ToInteger(val.Substring(65, 7))
			Me.datalist.Add(monthData4)
			Me.createday = DateTime.Parse(String.Format("{0}/{1}/{2}", val.Substring(72, 4), val.Substring(76, 2), val.Substring(78, 2)))
		End Sub

		Public tori_cd As String

		Public buhin_cd As String

		Public datalist As List(Of SB15M00.MonthData)

		Public createday As DateTime

		Public Class MonthData

			Public dateYMD As DateTime

			Public kosu As Integer
		End Class
	End Class
End Namespace
