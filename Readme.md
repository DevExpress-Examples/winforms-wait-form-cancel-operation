<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WaitFormCanceling/Form1.cs) (VB: [Form1.vb](./VB/WaitFormCanceling/Form1.vb))
* [ILocked.cs](./CS/WaitFormCanceling/ILocked.cs) (VB: [ILocked.vb](./VB/WaitFormCanceling/ILocked.vb))
* [Locker.cs](./CS/WaitFormCanceling/Locker.cs) (VB: [Locker.vb](./VB/WaitFormCanceling/Locker.vb))
* [Person.cs](./CS/WaitFormCanceling/Person.cs) (VB: [Person.vb](./VB/WaitFormCanceling/Person.vb))
* [Program.cs](./CS/WaitFormCanceling/Program.cs) (VB: [Program.vb](./VB/WaitFormCanceling/Program.vb))
* [WaitForm1.cs](./CS/WaitFormCanceling/WaitForm1.cs) (VB: [WaitForm1.vb](./VB/WaitFormCanceling/WaitForm1.vb))
<!-- default file list end -->
# How to cancel time-consuming operation from the WaitForm


<p>This example illustrates how to cancel a time-consuming operation on a WaitForm. To accomplish this task, place a BackgroundWorker and SplashScreenManager onto a Form, and add the Cancel button in the WaitForm's designer.  </p><p>The main idea is to perform data loading in a background thread, pass the ILocked object both to the WaitForm and to this thread, and check its condition while data is loading.</p>

<br/>


