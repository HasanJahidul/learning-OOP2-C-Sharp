using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask2
{
    struct StartingTime
    {
        byte hour;
        byte minute;
        byte second;
        
        public StartingTime (byte hour, byte minute, byte second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void Show()
        {
            Console.WriteLine("Starting Time: {0}/{1}/{2}", this.hour, this.minute, this.second);
        }
    }
    class Game
    {
        private ushort gameNumber, numberValue;
        private StartingTime startingTime;

        private ushort GameNumber
        {
            set
            {
               this.gameNumber =numberValue;
            }
            get
            {
                return this.gameNumber;
            }
        }
        private StartingTime StartingTime
        {
            set
            {
                this.startingTime = value;
            }
            get
            {
                return this.startingTime;
            }
        }
        public Game ()
        {
            gameNumber = 123;
            StartingTime = new StartingTime(4, 5, 40);
        }
        public Game(ushort gameNumber, StartingTime startingTime)
        {
            this.gameNumber = gameNumber;
            this.startingTime = startingTime;
        }
        public void showInfo()
        {
            Console.WriteLine("Game Number: {0}", this.gameNumber);
            StartingTime.Show();

        }
    }
}
