using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Player
    {
        String name;
        ushort id;

        internal String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        internal ushort Id
        {
            get { return id; }
            set { this.id = value; }
        }
        internal Player(String name, ushort id)
        {
            this.name = name;
            this.id = id;
        }

        internal virtual void Show()
        {
            Console.WriteLine("Player Name: {0} ", this.Name);
            Console.WriteLine("Player Id: {0}", this.Id);

        }

    }
}
