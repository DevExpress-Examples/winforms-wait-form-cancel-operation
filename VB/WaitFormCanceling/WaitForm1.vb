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
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraWaitForm

Namespace WaitFormCanceling

    Public Partial Class WaitForm1
        Inherits WaitForm

        Public Sub New()
            InitializeComponent()
            progressPanel1.AutoHeight = True
        End Sub

        Private locker As Object

#Region "Overrides"
        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            progressPanel1.Caption = caption
        End Sub

        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            progressPanel1.Description = description
        End Sub

        Public Overrides Sub ProcessCommand(ByVal cmd As [Enum], ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
            Dim command As WaitFormCommand = CType(cmd, WaitFormCommand)
            If command = WaitFormCommand.SendObject Then
                locker = arg
            End If
        End Sub

#End Region
        Public Enum WaitFormCommand
            SendObject
        End Enum

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If locker IsNot Nothing Then CType(locker, ILocked).IsCanceled = True
        End Sub
    End Class
End Namespace
