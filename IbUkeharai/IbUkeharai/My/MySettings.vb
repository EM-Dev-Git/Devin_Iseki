Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.My

	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Class MySettings
		Inherits ApplicationSettingsBase

		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Return MySettings.defaultInstance
			End Get
		End Property

		<DefaultSettingValue("Data Source=BUGYO-THINK\OBCINSTANCE2X;Initial Catalog=UkeharaiDB;Persist Security Info=True;User ID=dit;Password=dit")>
		<ApplicationScopedSetting()>
		<SpecialSetting(SpecialSetting.ConnectionString)>
		<DebuggerNonUserCode()>
		Public ReadOnly Property UkeharaiDBConnectionString As String
			Get
				Return Conversions.ToString(Me("UkeharaiDBConnectionString"))
			End Get
		End Property

		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)
	End Class
End Namespace
