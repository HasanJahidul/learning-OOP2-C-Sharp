using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cricket: Player
    {
        ushort run;

        internal ushort Run
        {
            get { return run; }
            set { this.run = value; }
        }
        internal Cricket(String name, ushort id, ushort run) : base(name, id)
        {
            this.run = run;
        }
        internal override void Show()
        {
            base.Show();
            Console.WriteLine("Runs: {0}\n ", this.Run);

        }
    }
}
