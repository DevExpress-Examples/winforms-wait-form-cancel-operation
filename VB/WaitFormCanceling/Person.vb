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
Namespace WaitFormCanceling

    Friend Class Person

        Private firstNameField As String

        Private secondNameField As String

        Private commentsField As String

        Public Shared counter As Integer = 0

        Public Sub New(ByVal firstName As String, ByVal secondName As String)
            firstNameField = firstName
            secondNameField = secondName
            commentsField = String.Empty
        End Sub

        Public Sub New(ByVal firstName As String, ByVal secondName As String, ByVal comments As String)
            Me.New(firstName, secondName)
            commentsField = comments
        End Sub

        Public Sub New()
            firstNameField = "Name" & counter
            secondNameField = "SecondName" & counter
            commentsField = "Comments" & counter
            counter += 1
        End Sub

        Public Property FirstName As String
            Get
                Return firstNameField
            End Get

            Set(ByVal value As String)
                firstNameField = value
            End Set
        End Property

        Public Property SecondName As String
            Get
                Return secondNameField
            End Get

            Set(ByVal value As String)
                secondNameField = value
            End Set
        End Property

        Public Property Comments As String
            Get
                Return commentsField
            End Get

            Set(ByVal value As String)
                commentsField = value
            End Set
        End Property
    End Class
End Namespace
