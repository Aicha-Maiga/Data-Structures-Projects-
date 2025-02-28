// written by Aicha Maiga 
// 02/26/2025


using System;
using System.Collections.Generic;

namespace HW5ShapesandAreas
{
    public class Rectangle: Shape
    {
        // variables 
        private double width = 00;
        private double height = 00;

        // gets and sets 

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Constructor 
        public Rectangle(string aColor, double theWidth, double theHeight): base(aColor) 
        {
            this.Width = width;
            this.Height = height;
        }

        // methods
        public override double GetArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"{Color} Rectangle,  Width: {Width}, Height: {Height}, Area: {GetArea():F2}";
        }
    }
}
