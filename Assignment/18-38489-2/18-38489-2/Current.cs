using System;
using System.Collections.Generic;
using System.Text;

namespace _18_38489_2
{
    class Current:Account
    {
        int accountType;
         internal int AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        internal String Type (int key)
        {
            if (this.accountType== 1)
            {
                return "Personal";
            }
            else if (this.accountType == 2)
            {
                return "Salary";
            }
            else if (this.accountType == 3)
            {
                return "Student";
            }
            else
            {
                return "Invalid Account Type";
            }

        }
       

        internal Current(int accountType, String name, int id, AccountOpeningDate openingDate): base(name,id,openingDate)
        {
            this.AccountType=accountType;
        }
       
        internal override void Show()
        {
            base.Show();
           //Console.WriteLine("Account Type: ",this.accountType);
            Console.WriteLine("Account Type:{0} " ,Type(accountType));

        }
    }
}
