// Written by Aicha Maiga
// 2/2/2025

using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RepairingTheClockTower
{
    public class ClockRepair
    {
        //variables
        private int number = -1;

        // gets and sets
        public int Number 
        { 
            get { return this.number; } 
            set { this.number = value; }
        }
        // methods 

        public string ClockSound()
        {
            string aSound = "n/a";

            if (this.Number % 2 == 0)
                aSound = "Tick";
            else
                aSound = "Tock";

            return aSound;
        }
    }
}
