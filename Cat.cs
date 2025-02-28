// written by Aicha Maiga 
// 02/27/2025


using System;
using System.Collections.Generic;


namespace HW5AnimalsandSounds
{
    public class Cat: Animal
    {
        //constructor
        public Cat(string name) : base(name) { }

        // method
        public override string MakeSound()
        {
            return "Meow";
        }
    }

}

