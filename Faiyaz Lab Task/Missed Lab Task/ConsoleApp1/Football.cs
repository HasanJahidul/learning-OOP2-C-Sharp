﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Football:Player
    {
        byte goal;

        internal byte Goal
        {
            get { return goal; }
            set { this.goal = value; }
        }
        internal Football(String name,ushort id ,byte goal) : base(name, id)
        {
            this.goal = goal;
        }
        internal override void Show() 
        {
            base.Show();
            Console.WriteLine("Goal: {0}\n ", this.Goal);

        }
    }
}
