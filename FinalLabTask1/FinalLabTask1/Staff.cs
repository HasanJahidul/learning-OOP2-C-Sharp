using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class Staff:Member
    {
        internal string position;

        internal string Position
        {
            get { return this.position; }
            private set { this.position = value; }
        }
        internal Staff(String name, Address address, String position) : base(name, address)
        {
           
            this.Position = position;
        }

        internal override void GetAllDetails()
        {
            base.GetAllDetails();
            
            Console.WriteLine("Position: {0}", this.Position);
            Console.WriteLine("\n");

        }
    }
}
