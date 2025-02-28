// written by Aicha Maiga 
// 02/26/2025


using System;
using System.Collections.Generic;

namespace HW5ShapesandAreas
{
    public abstract class Shape
    {
        // variables
        private string color = "n/a";

        // gets and sets

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // Constructor 
        public Shape(string aColor)
        {
            this.Color = aColor;
        }

        // methods

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";
        }
    }
}
