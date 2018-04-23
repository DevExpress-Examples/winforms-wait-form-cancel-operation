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

Namespace WaitFormCanceling
    Friend Class Person

        Private firstName_Renamed As String

        Private secondName_Renamed As String

        Private comments_Renamed As String
        Public Shared counter As Integer = 0
        Public Sub New(ByVal firstName As String, ByVal secondName As String)
            Me.firstName_Renamed = firstName
            Me.secondName_Renamed = secondName
            comments_Renamed = String.Empty
        End Sub
        Public Sub New(ByVal firstName As String, ByVal secondName As String, ByVal comments As String)
            Me.New(firstName, secondName)
            Me.comments_Renamed = comments
        End Sub
        Public Sub New()
            firstName_Renamed = "Name" & counter
            secondName_Renamed = "SecondName" & counter
            comments_Renamed = "Comments" & counter
            counter += 1
        End Sub

        Public Property FirstName() As String
            Get
                Return firstName_Renamed
            End Get
            Set(ByVal value As String)
                firstName_Renamed = value
            End Set
        End Property
        Public Property SecondName() As String
            Get
                Return secondName_Renamed
            End Get
            Set(ByVal value As String)
                secondName_Renamed = value
            End Set
        End Property
        Public Property Comments() As String
            Get
                Return comments_Renamed
            End Get
            Set(ByVal value As String)
                comments_Renamed = value
            End Set
        End Property
    End Class
End Namespace