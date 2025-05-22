Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace IbUkeharai.Util

	Public Class dgvTextBoxCell
		Inherits DataGridViewTextBoxCell

		Protected Overrides Function GetErrorIconBounds(graphics As Graphics, cellStyle As DataGridViewCellStyle, rowIndex As Integer) As Rectangle
			Dim errorIconBounds As Rectangle = MyBase.GetErrorIconBounds(graphics, cellStyle, rowIndex)
			errorIconBounds.X = errorIconBounds.Right - Me.Size.Width + errorIconBounds.Size.Width
			Return errorIconBounds
		End Function
	End Class
End Namespace