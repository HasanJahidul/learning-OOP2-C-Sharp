using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssessment
{
    class Laptop:Computer
    {
        ushort batteryAmount;

        internal ushort BatteryAmount
        {
            get { return batteryAmount; }
            set { this.batteryAmount = value; }
        }

        internal Laptop(byte numberOfCores, byte ramSize, ushort busSpeed, ushort batteryAmount,bool supportM2) :base (numberOfCores,ramSize,busSpeed,supportM2)
        {
            this.BatteryAmount = batteryAmount;
        }

        internal override void Show()
        {
            base.Show();
            Console.WriteLine("Battery Amount: {0} ", this.BatteryAmount,"mAh\n");
        }
    }
}
