// Written by Aicha Maiga
// 02/26/2025


using System;
using System.Collections.Generic;


namespace HW5Vehicle
{
    public abstract class Vehicle
    {
        // variables 
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        // gets and sets
        public string Make
        { 
            get { return this.make; } 
            set { this.make = value; } 
        }

        public string Model
        { 
            get { return this.model; } 
            set { this.model = value; } 
        }
        public int Year
        { 
            get { return this.year; } 
            set { this.year = value; } 
        }

        // Constructor 
        public Vehicle( string aMake, string aModel, int aYear)
        {
            this.make = aMake;
            this.model = aModel;
            this.year = aYear;
        }

        public override string ToString()
        {
            return $"{Year} {Model} {Make}";
        }
    }
}
