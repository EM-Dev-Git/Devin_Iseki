Imports System
Imports System.Text
Imports DitCore.Classes
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.Util

	Public Class ZaikosuCommon

		Public Sub New()
			Me._zaikosu = 0
		End Sub

		Public ReadOnly Property Zaikosu As Integer
			Get
				Return Me._zaikosu
			End Get
		End Property

		Public Function GetZaikosu(toricd As String, buhincd As String, syoriymd As DateTime, Optional isToday As Boolean = True) As String
			Dim configData As XmlConfigControl = TopForm.ConfigData
			Dim text As String = ""
			Using sqlDataBase As New SqlDataBase(configData.xmlConfData.xDataBase)
				Dim text2 As String = "SELECT Ukeharai.Get_Zaikosu('{0}', '{1}', '{2}', '{3}') AS ZAIKOSU"
				If isToday Then
					text2 = String.Format(text2, New Object() {toricd, buhincd, syoriymd.ToString("yyyy/MM/dd"), "True"})
				Else
					text2 = String.Format(text2, New Object() {toricd, buhincd, syoriymd.ToString("yyyy/MM/dd"), "False"})
				End If
				text = sqlDataBase.getSQLData(text2, True)
				If String.IsNullOrEmpty(text) Then
					Me._zaikosu = Conversions.ToInteger(sqlDataBase.DbDataTable.Rows(0)(0))
				End If
			End Using
			Return text
		End Function

		Public Shared Function GetZaikoSubquery(syoriymd As DateTime, tableAlias As String, Optional isToday As Boolean = True) As String
			Dim stringBuilder As New StringBuilder()
			Dim dateTime As DateTime = syoriymd.AddMonths(-1)
			stringBuilder.Append("( ")
			stringBuilder.Append("    SELECT ")
			stringBuilder.Append("        ISNULL(SUM(COMMON_ALIAS.ZAIKOSU), 0) ")
			stringBuilder.Append("    FROM ")
			stringBuilder.Append("        ( ")
			stringBuilder.Append("            SELECT ")
			stringBuilder.Append("                (MAX(ZAIKOSU) + SUM(UKESU) - SUM(HARASU)) AS ZAIKOSU ")
			stringBuilder.Append("            FROM ")
			stringBuilder.Append("                Ukeharai.T_UKEHARAIJISSEKI ")
			stringBuilder.Append("            WHERE ")
			stringBuilder.Append("                TORI_CD = {0}.TORI_CD  ")
			stringBuilder.Append("                AND BUHIN_CD = {0}.BUHIN_CD  ")
			stringBuilder.Append("                AND UKEHARA_YYYYMM >= '{1}' ")
			stringBuilder.Append("                AND UKEHARA_YYYYMM <= '{2}' ")
			stringBuilder.Append("            GROUP BY ")
			stringBuilder.Append("                TORI_CD, ")
			stringBuilder.Append("                BUHIN_CD ")
			stringBuilder.Append("            UNION ALL ")
			stringBuilder.Append("            SELECT ")
			stringBuilder.Append("                SUM( CASE WHEN UKEHARAI_KBN = '1' THEN KOSU WHEN UKEHARAI_KBN = '2' THEN -KOSU  ELSE 0 END ) AS ZAIKOSU ")
			stringBuilder.Append("            FROM ")
			stringBuilder.Append("                Ukeharai.T_UKEHARAIMEISAI ")
			stringBuilder.Append("            WHERE ")
			stringBuilder.Append("                TORI_CD = {0}.TORI_CD  ")
			stringBuilder.Append("                AND BUHIN_CD = {0}.BUHIN_CD  ")
			stringBuilder.Append("                AND UKEHARA_YYYYMMDD >= '{3}' ")
			If isToday Then
				stringBuilder.Append("            AND UKEHARA_YYYYMMDD <= '{4}' ")
			Else
				stringBuilder.Append("            AND UKEHARA_YYYYMMDD <  '{4}' ")
			End If
			stringBuilder.Append("            GROUP BY ")
			stringBuilder.Append("                TORI_CD, ")
			stringBuilder.Append("                BUHIN_CD ")
			stringBuilder.Append("        ) AS COMMON_ALIAS ")
			stringBuilder.Append(") ")
			Return String.Format(stringBuilder.ToString(), New Object() {tableAlias, dateTime.ToString("yyyy/01/01"), dateTime.ToString("yyyy/MM/01"), syoriymd.ToString("yyyy/MM/01"), syoriymd.ToString("yyyy/MM/dd")})
		End Function

		Private _zaikosu As Integer
	End Class
End Namespace
