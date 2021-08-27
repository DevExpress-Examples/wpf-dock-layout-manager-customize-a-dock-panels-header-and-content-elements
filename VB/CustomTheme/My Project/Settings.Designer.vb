﻿' Developer Express Code Central Example:
' How to customize header and content elements of the DockPanel in the DockManager (creating a custom theme)
' 
' It's necessary to respecify templates corresponding to the defined resource
' keys. The DockPanel Header and Content are placed in the
' DockPaneElementsThemeKey. The resource keys for the Header and the Content and
' Header and Content keys respectively. These are the keys you should
' respecify:
' 
' <DataTemplate x:Key="{dxt:DockPaneElementsThemeKey
' ResourceKey=Header}">
' <DataTemplate x:Key="{dxt:DockPaneElementsThemeKey
' ResourceKey=ContentHostTemplate}">
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1918

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace