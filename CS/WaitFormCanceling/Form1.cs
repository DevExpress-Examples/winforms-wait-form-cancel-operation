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
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;


namespace WaitFormCanceling
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {       
            InitializeComponent();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }
        Locker locker1 = new Locker();
        
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splashScreenManager1.CloseWaitForm();
            locker1.IsCanceled = false;
            if (e.Error!=null)
            {
                MessageBox.Show(e.Error.Message); return;
            }
            else
            {
                gridControl.DataSource = (BindingList<Person>)e.Result;
                label1.Text = ((BindingList<Person>)e.Result).Count.ToString() + " records from 3 000 005 are loaded";
            }
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                 
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker != null)
            {
                BindingList<Person> gridDataList = new BindingList<Person>();  
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SendCommand(WaitForm1.WaitFormCommand.SendObject, locker1);
                gridDataList.Add(new Person("John", "Smith"));
                gridDataList.Add(new Person("Gabriel", "Smith"));
                gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
                gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
                gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
                for (int i = 0; i < 3000000; i++)
                {
                    gridDataList.Add(new Person());
                    if (((ILocked)e.Argument).IsCanceled)
                    {
                        break;
                    }
                }
                e.Result = gridDataList;              
            }
        }        
      
        private void simpleButton1_Click(object sender, EventArgs e)         
        {
            Person.counter = 0;            
            backgroundWorker1.RunWorkerAsync(locker1);
        }
    
    }
}