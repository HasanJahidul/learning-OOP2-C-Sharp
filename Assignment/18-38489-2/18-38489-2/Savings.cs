using System;
using System.Collections.Generic;
using System.Text;

namespace _18_38489_2
{
    class Savings:Account
    {
        int duration;
        internal int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        internal Savings(String name, int id, AccountOpeningDate openingDate, int duration) : base(name, id, openingDate)
        {
            this.Duration = duration;
        }
        internal override void Show()
        {
            base.Show();
            Console.WriteLine("Account Duration: " + this.Duration);

        }
    }
}
