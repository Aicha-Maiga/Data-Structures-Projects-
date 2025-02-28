// Written by Aicha Maiga
// 02/26/2025

using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace HW5Vehicle
{
    public class Car : Vehicle
    {
        // variables
        private int numberofDoors = -1;

        //gets and sets
        public int NumberofDoors
        {
            get { return this.numberofDoors; }
            set { this.numberofDoors = value; }
        }

        // constructors

        public Car(string aMake, string aModel, int aYear, int aNumberofDoors):base( aMake, aModel,  aYear)
        {

        }
        public override string ToString()
        {
            return $"{Year},{Make},{Model} with {NumberofDoors} doors";
        }
    }
}
