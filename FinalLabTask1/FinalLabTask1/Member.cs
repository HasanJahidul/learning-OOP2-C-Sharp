using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    internal struct Address
    {
        private byte houseNo;
        private byte roadNo;
        private String area;
        private string district;

        public Address(byte houseNo, byte roadNo, String area, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address Info: ");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.area);
            Console.WriteLine("District: {0}", this.district);
        }
    }
    class Member
    {

        private string id;
        private string name;
        private double salary;
        private Address address;
        internal String temp="0000";

        internal virtual string Id
        {
            get { return this.id; }
            set {
                
                this.id = value;
            }
        }

        internal string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        internal Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }
        internal Member(string name, Address address,double salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.Address = address;
           
        }
        internal Member(string name, Address address)
        {

            this.Name = name;
           
            this.Address = address;

        }
        internal virtual void GetAllDetails()
        {
            Console.WriteLine("Member Information");
            Console.WriteLine("Member ID: {0}", this.Id);
            Console.WriteLine("Member Name: {0}", this.Name);
            this.Address.PrintAddress();
            Console.WriteLine("Account salary: {0}", this.Salary);
        }

    }
}
