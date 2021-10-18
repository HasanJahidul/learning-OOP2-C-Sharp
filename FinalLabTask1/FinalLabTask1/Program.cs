using System;

namespace FinalLabTask1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Address(houseNO,roadNo,area,district)    

            Address a1 = new Address(2, 5, "Uttara", "Dhaka");

            Address a2 = new Address(3, 15, "Banani", "Dhaka");



            Staff s = new Staff("BRUCE", a1, "Coach");



            Player p1 = new Player("TONY", a2, 10000, "Striker", 87);

            Player p2 = new Player("CLERK", a1, 14000, "Defender", 71);
            //p1.GetAllDetails();


            ClubCommittee cc = new ClubCommittee();

            cc.AddMember(s);

            cc.AddMember(p1);

            cc.AddMember(p2);

            cc.GetAllDetails();

        }
    }
}
