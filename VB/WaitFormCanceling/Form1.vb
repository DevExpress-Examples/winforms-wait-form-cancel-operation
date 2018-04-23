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


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen


Namespace WaitFormCanceling
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			backgroundWorker1.WorkerSupportsCancellation = True
			AddHandler backgroundWorker1.DoWork, AddressOf backgroundWorker1_DoWork
			AddHandler backgroundWorker1.RunWorkerCompleted, AddressOf backgroundWorker1_RunWorkerCompleted
		End Sub
		Private locker1 As New Locker()

		Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			splashScreenManager1.CloseWaitForm()
			locker1.IsCanceled = False
			If e.Error IsNot Nothing Then
				MessageBox.Show(e.Error.Message)
				Return
			Else
				gridControl.DataSource = CType(e.Result, BindingList(Of Person))
				label1.Text = (CType(e.Result, BindingList(Of Person))).Count.ToString() & " records from 3 000 005 are loaded"
			End If
		End Sub

		Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

			Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
			If worker IsNot Nothing Then
				Dim gridDataList As New BindingList(Of Person)()
				splashScreenManager1.ShowWaitForm()
				splashScreenManager1.SendCommand(WaitForm1.WaitFormCommand.SendObject, locker1)
				gridDataList.Add(New Person("John", "Smith"))
				gridDataList.Add(New Person("Gabriel", "Smith"))
				gridDataList.Add(New Person("Ashley", "Smith", "some comment"))
				gridDataList.Add(New Person("Adrian", "Smith", "some comment"))
				gridDataList.Add(New Person("Gabriella", "Smith", "some comment"))
				For i As Integer = 0 To 2999999
					gridDataList.Add(New Person())
					If (CType(e.Argument, ILocked)).IsCanceled Then
						Exit For
					End If
				Next i
				e.Result = gridDataList
			End If
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Person.counter = 0
			backgroundWorker1.RunWorkerAsync(locker1)
		End Sub

	End Class
End Namespace