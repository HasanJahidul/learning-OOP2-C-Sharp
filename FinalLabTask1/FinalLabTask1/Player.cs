using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FinalLabTask1
{
    class Player: Member
    {
        internal string playingPosition;
        internal byte currentRank;
        


        internal string PlayingPosition
        {
            get { return this.playingPosition; }
             set { this.playingPosition = value; }
        }
        internal byte CurrentRank
        {
            get { return this.currentRank; }
            set {this.currentRank = value; }
        }
        internal override string Id
        {
            get { return base.Id; }
            set { base.Id = "PC-"+value; }
        }
        internal bool PlayingStatus(byte currentRank)
        {
            if (this.currentRank >= 75 && this.currentRank<=100)
            {
                return true;
            }
            else
            {
               
                return false;
            }

        }
            internal Player(String name, Address address, double salary, String playingPosition, byte currentRank):base(name,address,salary)
        {
            this.CurrentRank = currentRank;
            this.PlayingPosition = playingPosition;
        }
        internal override void GetAllDetails()
        {
            base.GetAllDetails();
            Console.WriteLine("Player Position: {0}", this.PlayingPosition);
            Console.WriteLine("Player rank: {0}", this.CurrentRank);
            Console.WriteLine("Playing Status: {0}", this.PlayingStatus(CurrentRank));
            Console.WriteLine("\n");
        }

    }
}
