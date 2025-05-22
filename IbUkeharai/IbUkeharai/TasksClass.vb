Imports System
Imports System.IO
Imports DitCore.Classes
Imports DitDataAccess.DataBases
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai

	Friend Class TasksClass

		Public Sub New()
			Me.ConfigData = Nothing
		End Sub

		Public Sub SomeTask()
			Me.RetVal = False
			Me.ConfigData = New XmlConfigControl()
			If Me.ConfigData Is Nothing Then
				Return
			End If
			If Operators.CompareString(Me.ConfigData.xmlConfData.Kyoten, "Matsuyama", False) <> 0 Then
				If Operators.CompareString(Me.ConfigData.xmlConfData.Kyoten, "Kumamoto", False) <> 0 Then
					If Operators.CompareString(Me.ConfigData.xmlConfData.Kyoten, "Buhin", False) <> 0 Then
						Return
					End If
				End If
			End If
			Dim sLogFilePath As String = Path.Combine(FileSystem.CurDir() + Conversions.ToString(Path.DirectorySeparatorChar) + "log", Me.ConfigData.xmlConfData.xPath.LogFileName)
			OutputLog.Initialize(False, sLogFilePath)
			Using sqlDataBase As New SqlDataBase(Me.ConfigData.xmlConfData.xDataBase)
				Dim text As String = "SELECT SAKI_CD AS TORI_NAME FROM Ukeharai.M_SAKI WHERE 0=1 "
				Dim sqldata As String = sqlDataBase.getSQLData(text, True)
				If Not sqldata.Equals(String.Empty) Then
					OutputLog.WriteLine(Me.[GetType]().Name + " Database Error.", New String() {text, sqldata})
				End If
			End Using
			Me.RetVal = True

		End Sub

		Friend ConfigData As XmlConfigControl

		Public RetVal As Boolean

		Private Const LOG_FOLDER As String = "log"
	End Class
End Namespace
