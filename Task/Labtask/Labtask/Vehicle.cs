using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labtask
{
    struct Registration
    {
        public byte day;
        public byte month;
        public ushort year;

        public Registration(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("Registration Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }


    class Vehicle
    {
        private ushort engineNumber;
        private Registration registrationDate;


        public Registration GetRegistrationDate()
        {
            return this.registrationDate;
        }
        public void SetRegistrationDate(Registration registrationDate)
        {
            this.registrationDate = registrationDate;
        }
        public ushort GetEngineNumber()
        {
            return this.engineNumber;
        }
        public void SetEngineNumber(ushort engineNumber)

        {
            this.engineNumber = engineNumber;
        }
        public Vehicle()
        {

        }
        public Vehicle(ushort engineNumber, Registration registrationDate)
        {
            this.engineNumber = engineNumber;
            this.registrationDate = registrationDate;
        }
        public void showInfo()
        {
            Console.WriteLine("Engine Number: {0}", this.engineNumber);
            Registration.Show();
            Console.WriteLine("Engine Number: {0}", this.GetRegistrationDate());
        }

    }
}
