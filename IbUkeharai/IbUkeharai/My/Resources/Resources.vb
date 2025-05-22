Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace IbUkeharai.My.Resources

	<HideModuleName()>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	Public NotInheritable Class Resources

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Me.resourceMan, Nothing) Then
					Me.resourceMan = New ResourceManager("IbUkeharai.Resources", GetType(Resources).Assembly)
				End If
				Return Me.resourceMan
			End Get
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public Property Culture As CultureInfo
			Get
				Return Me.resourceCulture
			End Get
			Set(value As CultureInfo)
				Me.resourceCulture = value
			End Set
		End Property

		Private resourceMan As ResourceManager

		Private resourceCulture As CultureInfo
	End Class
End Namespace
