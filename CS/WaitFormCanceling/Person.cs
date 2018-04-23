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

namespace WaitFormCanceling {
    class Person {
        string firstName;
        string secondName;
        string comments;
        public static int counter = 0;
        public Person(string firstName, string secondName) {
            this.firstName = firstName;
            this.secondName = secondName;
            comments = String.Empty;
        }
        public Person(string firstName, string secondName, string comments)
            : this(firstName, secondName) {
            this.comments = comments;
        }
        public Person()
        {
            firstName = "Name" + counter;
            secondName = "SecondName" + counter;
            comments = "Comments" + counter;
            counter++;
        }
         
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName {
            get { return secondName; }
            set { secondName = value; }
        }
        public string Comments {
            get { return comments; }
            set { comments = value; }
        }
    }
}