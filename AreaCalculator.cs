// Written by Aicha Maiga 
// 2/1/2025

using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    public class AreaCalculator
    {
        // variables
        private double height = -9999.99;
        private double baseLength = -9999.99;
        
        // gets and sets
        public double Height
        { 
            get { return this.height;} 
            set { this.height = value; }
        }
        public double BaseLength
        {
            get { return this.baseLength; }
            set { this.baseLength = value; }
        }
        public double CalcArea()
        {
            double anArea = 0.0;

            anArea = BaseLength * Height / 2;

            return anArea;

        }
    }
}
