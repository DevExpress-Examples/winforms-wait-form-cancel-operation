// Developer Express Code Central Example:
// How to cancel time-consuming operation from the WaitForm
// 
// This example illustrates how to cancel a time-consuming operation on a WaitForm.
// To accomplish this task, place a BackgroundWorker and SplashScreenManager onto a
// Form, and add the Cancel button in the WaitForm's designer. The main idea is to
// perform data loading in a background thread, pass the ILocked object both to the
// WaitForm and to this thread, and check its condition while data is loading.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4524

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using System.Threading;

namespace WaitFormCanceling
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();         
            this.progressPanel1.AutoHeight = true;           
        }
        object locker;
        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            WaitFormCommand command = (WaitFormCommand)cmd;           
                if (command == WaitFormCommand.SendObject)
                {
                    locker = arg;
                }
        }

        #endregion
        public enum WaitFormCommand
        {
            SendObject
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(locker!=null)
                ((ILocked)locker).IsCanceled = true;           
        }
    }
}