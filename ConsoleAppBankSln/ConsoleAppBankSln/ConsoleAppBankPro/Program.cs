using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankPro
{
    internal abstract class Parent
    {
        internal virtual void M1()
        {
            Console.WriteLine("PM1");
        }

        internal virtual void M2()
        {
            Console.WriteLine("PM2");
        }

        internal abstract void M4();
    }

    internal class Child : Parent
    {
        internal override void M1()
        {
            Console.WriteLine("CM1");
        }

        internal new void M2()
        {
            Console.WriteLine("PM2");
        }

        internal void M3()
        {
            Console.WriteLine("PM3");
        }

        internal override void M4()
        {
            Console.WriteLine("PM4");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            //Child c = new Child();
            //p.M1();
            //c.M1();
            //int y = 90;
            //double e = y;
            //int ppppppp = e;
            
            //Parent p = new Child();
            //p.M1();
            //p.M2();
            ////p.M3();
            //Child cc = (Child)p;
            //p.M4();
            ////int[] w = new int[5];
            //Parent[] pr = new Parent[2];
            //pr[0] = new Parent();
            //pr[1] = new Child();
            
            Account[] accounts = new Account[2];
            accounts[0] = new Savings(100, "Bruce", new OurDate(12, 3, 2020), new OurAddress(4, 3, 2224, "Dhaka"), 5000, 6);
            accounts[1] = new Current(101, "Clerk", new OurDate(22, 11, 2019), new OurAddress(44, 33, 2424, "Khulna"), 3500, "Personal");

            accounts[1].Transfer(accounts[0], 3500);
            //foreach (Account acc in accounts)
            //{
            //    acc.ShowInfo();
            //}
            //int c = 0;
            //while (c < accounts.Length)
            //{
            //    accounts[c].ShowInfo();
            //    c++;
            //}
            //a1.Deposit(300);
            //a2.Deposit(4000);
            //a1.Withdraw(5000);
            //a2.Withdraw(3000);
            //a1.ShowInfo();
            //a2.ShowInfo();
        }
    }
}
