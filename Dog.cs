// Written by Aicha Maiga
// 02/27/2025

using System;
using System.Collections.Generic;


namespace HW5AnimalsandSounds
{
    public class Dog: Animal
    {
        // constructor
        public Dog(string aName) : base(aName) 
        {
            
        }

        // method
        public override string MakeSound()
        {
            return "Bark";
        }
    }
}

