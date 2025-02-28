// Written by Aicha Maiga
// 02/26/2025

using System;
using System.Collections.Generic;

namespace HW5Vehicle
{
    public class Motorcycle: Vehicle
    {
        // variables
        private bool hasSidecar = false;

        //gets and sets 
        public bool HasSidecar
        {
            get { return hasSidecar; }
            set { hasSidecar = value; }
        }


        // constructors

        public Motorcycle(string aMake, string aModel, int aYear, bool _HasSidecar) : base(aMake, aModel, aYear)
        {
            this.HasSidecar = _HasSidecar;
        }
        public override string ToString()
        {
            return $"{Year},{Make},{Model} ( Has Sidecar: {HasSidecar})";
        }




    }
}
