using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssessment
{
    class Desktop:Computer
    {

        internal Desktop(byte numberOfCores, byte ramSize, ushort busSpeed,bool supportM2) : base(numberOfCores, ramSize, busSpeed,supportM2)
        {
            
        }
        internal override void Show()
        {
            base.Show();
            
        }
    }
}
