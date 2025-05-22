Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.CateDataExec

	Public Class DataGridViewCheckBoxCellEx
		Inherits DataGridViewCheckBoxCell

		Protected Overrides Sub OnClick(e As DataGridViewCellEventArgs)
			MyBase.OnClick(e)
			Dim flag As Boolean = Conversions.ToBoolean(Operators.XorObject(Me.Value, True))
			Me.Value = flag
		End Sub
	End Class
End Namespace