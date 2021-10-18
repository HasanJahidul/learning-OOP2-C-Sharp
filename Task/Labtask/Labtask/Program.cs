using Labtask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask

{
    class Program
    {
        static void Main(string[] args)
        {
           // Registration registrationDate1 = new Registration(02 / 03 / 1);
            //Registration registrationDate2 = new Registration(10 / 03 / 12);
            //Vehicle engineNo1 = new Vehicle(12356, registrationDate1);
            Vehicle engineNo2 = new Vehicle(45679, new Registration(1,11,1010));
            //engineNo1.showInfo();
            engineNo2.showInfo();
        }
    }
}
