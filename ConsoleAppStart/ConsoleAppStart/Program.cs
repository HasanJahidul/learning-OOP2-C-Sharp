using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStart
{
    struct Point
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1,p2;
            p1.x = 20;//Convert.ToInt32(Console.ReadLine());
            p1.y = 30;
            Console.WriteLine("({0},{1})",p1.x,p1.y);

            p2 = p1;
            p1.x++;

            //Console.WriteLine("Welcome to c#");
            //Console.Write("Welcome to Summer\n");
            //int ax = 10, bx = 30, cx = 50;
            //float q = 5.34f;
            //double w = 5.34742;
            //decimal r = 34.12m;
            //bool t = false;
            //string u = "hello";

            //Console.WriteLine("ax: {0}, bx: {1}, cx: {2}", ax, bx, u); //printf("ax: %d, bx: %d",ax,bx);
            //Console.WriteLine("ax: " + ax + ", bx: " + bx + ", cx: " + cx);
            //Console.WriteLine("{0},{1}", ax, bx);
            //SchoolStudent
            //ourStartVariable
            //studentAge place Holder
            //string ourText;
            //ourText = Console.ReadLine();
            //Console.WriteLine("{0}", ourText);

            //int p,pp;
            //double g,gg;

            //p = Convert.ToInt32(Console.ReadLine());
            //pp = Int32.Parse(Console.ReadLine());
            //g = Convert.ToDouble(Console.ReadLine());
            //gg = Double.Parse(Console.ReadLine());

            //type_name var_name [= init];

            int n1, n2=11;
            double n3 = 5, n4;
            short n5 = 10, n6;

            n1 = n5;
            n4 = n2;
            n1 = (int)n3;
            n6 = (short)n2;
        }
    }
}





























///Console.WriteLine(w);
//schoolStudent
//string ourString;
//ourString = Console.ReadLine();
//Console.WriteLine(ourString);

//int z,h;
//double p;

//z = Convert.ToInt32(Console.ReadLine());
//h = Int32.Parse(Console.ReadLine());
//p = Convert.ToDouble(Console.ReadLine());

//int n1, n2=12;
//double n3, n4=3;
//short n5 = 10, n6;

//n1 = n5;
//n6 = (short)n2;
//n1 = (int)n4;

//Console.WriteLine("ax: {0}, bx: {1}, cx: {2}", ax, bx, cx);//printf("ax: %d, bx: %d",ax,bx);
            ////Console.WriteLine("{0}", bx);
            //////Console.WriteLine("ax: " + ax + ", bx: " + bx + ", cx: " + cx);
            ////Console.WriteLine(q);
            //Console.WriteLine("{0}",q);

            //////bx = ax;
            //////ax++;
            ////School Student
            ////mySchoolStudent

            //string ourText;
            //ourText = Console.ReadLine();
            //Console.WriteLine("{0}", ourText);
            
            //int p,v;
            //double u;

            //p = Convert.ToInt32(Console.ReadLine());
            //v = Int32.Parse(Console.ReadLine());
            //u = Convert.ToDouble(Console.ReadLine());

            //int n1, n2;
            //double n3 = 6, n4;
            //short n5 = 11, n6;

            //n1 = n5;
            //n2 = (int) n3;
            //n6 = (short) n2;

            //int ax = 10, bx;
            //bx = ax;
            //ax++;
            //bx++;
            //bx = ax;