<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619130/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4524)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Wait Form - How to cancel a time-consuming operation

This example shows how to close the Wait Form to cancel a time-consuming operation:

* Add a `GridControl` onto the Form.
* Place a `BackgroundWorker` component onto the Form and handle its `RunWorkerCompleted` and `DoWork` events.
* Place a `SplashScreenManager` component onto the Form.
* Invoke the SplashScreen Manager's smart tag menu and add a Wait Form.
* Add a **Load Data** button onto the Form and handle its `Click` event to load data and display a wait form.
  
  ```csharp
  private void simpleButton1_Click(object sender, EventArgs e) {
      Person.counter = 0;
      backgroundWorker1.RunWorkerAsync(locker1);
  
      splashScreenManager1.ShowWaitForm();
      splashScreenManager1.SendCommand(WaitForm1.WaitFormCommand.SendObject, locker1);
  }
  ```
* Open the WaitForm designer and add a Cancel button.
* Handle the Cancel button's `Click` event to cancel the operation:
  ```csharp
  private void simpleButton1_Click(object sender, EventArgs e) {
      if (locker != null)
          ((ILocked)locker).IsCanceled = true;
  }
  ```


## Files to Review

* [WaitForm1.cs](./CS/WaitFormCanceling/WaitForm1.cs) (VB: [WaitForm1.vb](./VB/WaitFormCanceling/WaitForm1.vb))
* [Form1.cs](./CS/WaitFormCanceling/Form1.cs) (VB: [Form1.vb](./VB/WaitFormCanceling/Form1.vb))
* [ILocked.cs](./CS/WaitFormCanceling/ILocked.cs) (VB: [ILocked.vb](./VB/WaitFormCanceling/ILocked.vb))
* [Locker.cs](./CS/WaitFormCanceling/Locker.cs) (VB: [Locker.vb](./VB/WaitFormCanceling/Locker.vb))


## Documentation

* [WinForms Splash Screen Manager](https://docs.devexpress.com/WindowsForms/10826/controls-and-libraries/forms-and-user-controls/splash-screen-manager)
* [Wait Form](https://docs.devexpress.com/WindowsForms/10824/controls-and-libraries/forms-and-user-controls/splash-screen-manager/wait-form)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-wait-form-cancel-operation&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-wait-form-cancel-operation&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
