using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Contact
    {
        String personName;
        String personId;
        int age;
        String mobileNumber;
        Char gender;

        private String PersonName
        {
            get { return this.personName; }
            set { this.personName = value; }
        }
        private String PersonId
        {
            get { return this.personId; }
            set { this.personId = value; }
        }
        private int Age
        {
            get { return this.age; }
            set {this.age=value;}
        }
        private String MobileNumber
        {
            get { return this.mobileNumber; }
            set { this.mobileNumber = value; }
        }
        private Char Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public Contact()
        {

        }
        public Contact(String personName, String personId, int age, String mobileNumber,  Char gender)
        {
            this.PersonName = personName;
            this.PersonId = personId;
            this.Age = age;
            this.MobileNumber = mobileNumber;
            this.Gender = gender;

        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Name: {0}", this.PersonName);
            Console.WriteLine("ID: {0}", this.PersonId);
            Console.WriteLine("Age: {0} ", this.Age);
            Console.WriteLine("Mobile Number: {0} ", this.MobileNumber);
            Console.WriteLine("Gender: {0} ", this.Gender);
        }
        public void DetectMobileOperator()
        {
            String MobileOperator = "";
            String check = this.MobileNumber.Substring(2,1);
            int tempOperator = Convert.ToInt32(check);

            switch (tempOperator)
            {
                case 6:
                    {
                        MobileOperator = "Airtel";
                        break;
                    }
                case 9:
                    {
                        MobileOperator = "Banglalink";
                        break;
                    }
                case 8:
                    {
                        MobileOperator = "Robi";
                        break;
                    }
                case 7:
                    {
                        MobileOperator = "GP";
                        break;
                    }
                default:
                    {
                        MobileOperator = "Invalid Mobile Number";
                        break;

                    }
            }

            Console.WriteLine("Mobile Operator: {0} ", MobileOperator);
        }

    }
}
