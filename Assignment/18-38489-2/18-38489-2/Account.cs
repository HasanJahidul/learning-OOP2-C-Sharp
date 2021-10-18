using System;
using System.Collections.Generic;
using System.Text;

namespace _18_38489_2
{
     struct AccountOpeningDate
    {
         public byte day;
         public byte month;
         public ushort year;

         public AccountOpeningDate(byte day, byte month, ushort year)
         {
                this.day = day;
                this.month = month;
                this.year = year;
         }
         public void ShowDate()
         {
              Console.WriteLine("Registration Date: {0}/{1}/{2}", this.day, this.month, this.year);
         }
           
    }
    class Account
    {
        String name;
        int id;
        int balance=10000, amount;
        AccountOpeningDate openingDate;

        internal String Name
        {
            get {return this.name;}
            set {this.name=value;}
        }
        internal int Id
        {
            get {return this.id;}
            set 
            {
                this.id = value;
            }
        }
        internal int Balance 
        {
            get {return this.balance;}
            //set {this.balance=value;}
        }
        internal int Amount
        {
            get { return amount; }
            set
            {
                   this. amount=value;
            }
        }
        internal int Withdraw(int amount)
        {

            if (balance-amount < 500 && balance < amount)
            {
                Console.WriteLine("Insufficient Balance.......");
                Console.WriteLine("Account should have 500 Taka after withdrawal\n\n");
            }

            else
             {
                 balance -= amount;
                
             }
            return balance;

        }
        internal int Deposit(int amount)
        {

            if (amount < 500)
            {
                Console.WriteLine("Deposite failed...........");
                Console.WriteLine("Minimum deposite amount 500 taka\n\n");
            }

            else
            {
                balance += amount;

            }
            return balance;

        }


        internal AccountOpeningDate AccountOpeningDate
        {
            get {return this.openingDate;}
            set {this.openingDate=value;}
        }

        internal Account (String name,int id,AccountOpeningDate openingDate)
        {
            this.Name=name;
            this.Id=id;
            this.Amount = amount;
            this.openingDate=openingDate; 
        }
        internal Account()
        {
            
        }

        internal virtual void Show()
        {
            Console.WriteLine("Account Holder Name: {0}" ,this.Name);
            Console.WriteLine("Account ID: {0}" ,this.Id);
            Console.WriteLine("Balance: {0} ",this.Balance);
            AccountOpeningDate.ShowDate();
        }
    }
}
