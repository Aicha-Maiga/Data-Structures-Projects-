// Written by Aicha Maiga
// 02/27/2025


using System;
using System.Collections.Generic;


namespace HW5AnimalsandSounds
{
    public class Animal
    {
        // variables
        private string name= "n/a";

        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public Animal(string aName)
        {
            this.Name = aName;
        }

        //methods
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }
}
