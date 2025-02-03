// Written by Aicha Maiga
// 2/2/2025

using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TheDefenseOfConsolas
{
    public class SquadDeployment
    {
        // variables
        private int row = -1;
        private int column = -1;

        // gets and sets
        public int Row 
        { 
            get { return this.row; } 
            set { this.row = value; } 
        }
        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

    }
}
