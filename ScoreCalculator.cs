// Written by Aicha Maiga 
// 2/2/2025


using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TheDominionOfKings
{
    public class ScoreCalculator
    {
        // variables
        private int estate = -1;
        private int duchy = -1;
        private int province = -1;

        // gets and sets
        public int Estate
        {
            get { return this.estate; }
            set { this.estate = value; }
        }
        public int Duchy
        {
            get { return this.duchy; }
            set { this.duchy = value; }
        }
        public int Province
        {
            get { return this.province; }
            set { this.province = value; }
        }

        // methods
        public int CalcTotalScore()
        {
            int aTotalScore = 0;
            aTotalScore = (Estate * 1) + (Duchy * 3) + (Province * 6);

            return aTotalScore;
        }

        public override string ToString()
        {
            string message = "";
            message = "Estate: " + this.Estate + "\n";
            message = "Duchy: " + this.Duchy + "\n";
            message = "Province: " + this.Province + "\n";
            message = "Total Score: " + this.CalcTotalScore() + "\n";

            return message;
        }    
    }
}
