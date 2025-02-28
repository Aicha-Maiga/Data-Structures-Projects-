// written by Aicha Maiga 
// 02/26/2025


using System;
using System.Collections.Generic;


namespace HW5ShapesandAreas
{
    public class Circle: Shape
    {
        // variables
        private double radius= 00;

        // gets and sets 
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        // constructor
        public Circle(string aColor, double aRadius): base(aColor)
        {
            this.Radius = aRadius;
        }

        //methods

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override string ToString()
        {
            return $"{Color} Circle, Radius: {Radius}, Area: {GetArea():F2}";
        }
    }
}

