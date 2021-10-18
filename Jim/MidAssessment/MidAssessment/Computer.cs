using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssessment
{
    class Computer
    {
        byte numberOfCores;
        ushort busSpeed;
        byte ramSize;
        bool supportM2;

        internal byte NumberOfCores
        {
            get { return numberOfCores; }
            set { this.numberOfCores = value; }
        }
        internal ushort BusSpeed
        {
            get { return busSpeed; }
            set { this.busSpeed = value; }
        }
        internal byte RamSize
        {
            get { return ramSize; }
            set { this.ramSize = value; }
        }
        internal bool SupportM2
        {
            get { return supportM2; }
            set
            {
                if (!supportM2)
                {
                    this.supportM2 = value;
                    Console.WriteLine("M.2 Suported ");
                }
                else if (supportM2)
                {
                    this.supportM2 = value;
                    Console.WriteLine("M.2 Not Suported ");
                }

           }
        }
        internal Computer(byte numberOfCores, byte ramSize, ushort busSpeed,bool supporM2)
        {
            this.NumberOfCores = numberOfCores;
            this.RamSize = ramSize;
            this.BusSpeed = busSpeed;
            this.SupportM2 = supportM2;
        }
        
        internal static void BetterMemory()
        {
           
        }

        internal virtual void Show()
        {
            Console.WriteLine("Number Of Cores: {0} ", this.NumberOfCores);
            Console.WriteLine("Ram Size: {0}", this.RamSize);
            Console.WriteLine("Bus Speed:  {0}", this.BusSpeed);
            Console.WriteLine(this.SupportM2);
            
        }
    }
}
