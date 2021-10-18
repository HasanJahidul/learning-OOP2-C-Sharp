using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStruct
{
    struct OurAddress
    {
        public byte houseNo = 90;
        public byte roadNo;
        public ushort postalCode;
        public string district;

        public OurAddress(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address Info: ");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //OurAddress addressOne;
            //addressOne.houseNo = 2;
            //addressOne.roadNo = 67;
            //addressOne.postalCode = 1290;
            //addressOne.district = "Dhaka";
            //addressOne.PrintAddress();


            OurAddress addressTwo = new OurAddress(21, 76, 9890, "Sylhet");
            //addressTwo.houseNo = 12;
            //addressTwo.roadNo = 76;
            //addressTwo.postalCode = 9890;
            //addressTwo.district = "Sylhet";
            addressTwo.PrintAddress();
        }
    }
}
