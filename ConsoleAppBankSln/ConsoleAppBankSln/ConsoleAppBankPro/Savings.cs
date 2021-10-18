using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankPro
{
    internal class Savings : Account
    {
        private byte duration;

        internal byte Duration
        {
            get { return this.duration; }
            set
            {
                if (value >= 2 && value <= 40)
                    this.duration = value;
                else
                    this.duration = 0;
            }
        }

        internal Savings(int id, string name, OurDate openingDate, OurAddress address, double balance, byte duration) : base(id, name, openingDate, address, balance)
        {
            this.Duration = duration;
        }

        internal override bool Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Console.WriteLine("Withdraw of {0} taka complete", amount);
                return true;
            }
            else
                Console.WriteLine("{0} is not enough. Insufficient Balance", amount);
            return false;
            //this.ShowInfo();
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Savings Account Duration: {0}\n", this.Duration);
        }
    }
}
