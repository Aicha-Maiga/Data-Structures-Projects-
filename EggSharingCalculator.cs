// Written By Aich Maiga
// 2/2/2025

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TheFourSisters_TheDuckbear
{
    public class EggSharingCalculator
    {
        // variables 
        private int numberofEggs = -1;
        
        // gets and sets
        public int NumberofEggs
        {
            get { return this.numberofEggs; }
            set
            {
                if (value < 0)
                {
                    this.numberofEggs = -1;
                }
                else
                {
                    this.numberofEggs = value;
                }
            }
        }
        // methods 
        public int CalcSisterShare()
        {
            int aSisterShare = 0;
            aSisterShare = NumberofEggs / 4;

            return aSisterShare;
        }
        public int CalcDuckShare()
        {
            int aDuckShare= 0;
            aDuckShare = NumberofEggs % 4;

            return aDuckShare;
        }
            
    }
}
