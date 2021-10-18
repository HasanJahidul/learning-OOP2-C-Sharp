using System;

namespace MidAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop D = new Desktop(8,16,3200,false);
            D.Show();
            Laptop L = new Laptop(6,32,2400,3000,true);
            L.Show();
        }
    }
}
