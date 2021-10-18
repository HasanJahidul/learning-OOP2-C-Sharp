using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game obj1 = new Game(12345, new StartingTime(01, 02, 36));
            obj1.showInfo();
            Game obj2 = new Game();
            obj2.showInfo();
            
        }
    }
}
