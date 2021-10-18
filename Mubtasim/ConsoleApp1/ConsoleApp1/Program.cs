using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String personName = "mubtasim";
            String personId = "20-41995-1";
            int age = 45;
            String mobileNumber = "01975445561";
            Char gender = 'M';
            Console.WriteLine("Contact Information:\n");
            Contact c = new Contact(personName, personId, age, mobileNumber,gender);
            c.ShowPersonInfo();
            c.DetectMobileOperator();
        }
    }
}
