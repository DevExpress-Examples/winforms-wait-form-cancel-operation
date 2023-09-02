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
Imports System.ComponentModel
Imports System.Drawing

Namespace WaitFormCanceling

    Public Class Locker
        Implements ILocked

        ''' Fields...
        Private _IsCanceled As Boolean

        Public Property IsCanceled As Boolean Implements ILocked.IsCanceled
            Get
                Return _IsCanceled
            End Get

            Set(ByVal value As Boolean)
                _IsCanceled = value
            End Set
        End Property

        Public Sub New()
            _IsCanceled = False
        End Sub
    End Class
End Namespace
