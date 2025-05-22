Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace DitCore.My

	<CompilerGenerated()>
	<HideModuleName()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Class MySettingsProperty

		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Class
End Namespace