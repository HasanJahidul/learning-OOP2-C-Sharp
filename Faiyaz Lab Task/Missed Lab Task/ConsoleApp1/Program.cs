using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Football F = new Football("Faiyaz",12345,8);
            F.Show();

            Player C = new Cricket(" Shahrear", 12345, 244);
            C.Show();
        }
    }
}
