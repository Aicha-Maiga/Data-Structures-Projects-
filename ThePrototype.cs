// Written by Aicha Maiga
// 02/05/2025

using System;
using System.Collections.Generic;


namespace ThePrototype
{

    public class ThePrototype
    {
        // variables
        private int numberUser1 = -1;

        // gets and sets

        public int NumberUser1
        {
            get { return this.numberUser1; }
            set { this.numberUser1 = value; }
        }

        // methods 
        public string EvaluateGuess(int guess)
        {
            if (guess > NumberUser1)
                return $"{guess} is too high.";
            else if (guess < NumberUser1)
                return $"{guess} is too low.";
            else
                return "You guessed the number!";
        }
    }
}
