<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619130/12.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4524)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


