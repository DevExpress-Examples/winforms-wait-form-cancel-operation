' Developer Express Code Central Example:
' How to cancel time-consuming operation from the WaitForm
' 
' This example illustrates how to cancel a time-consuming operation on a WaitForm.
' To accomplish this task, place a BackgroundWorker and SplashScreenManager onto a
' Form, and add the Cancel button in the WaitForm's designer. The main idea is to
' perform data loading in a background thread, pass the ILocked object both to the
' WaitForm and to this thread, and check its condition while data is loading.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4524
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly:AssemblyTitle("WaitFormCanceling")>
<Assembly:AssemblyDescription("")>
<Assembly:AssemblyConfiguration("")>
<Assembly:AssemblyCompany("")>
<Assembly:AssemblyProduct("WaitFormCanceling")>
<Assembly:AssemblyCopyright("Copyright ©  2013")>
<Assembly:AssemblyTrademark("")>
<Assembly:AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly:ComVisible(False)>
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly:Guid("61edac9e-c745-4e88-8667-e4e8116ddd50")>
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly:AssemblyVersion("1.0.0.0")>
<Assembly:AssemblyFileVersion("1.0.0.0")>
