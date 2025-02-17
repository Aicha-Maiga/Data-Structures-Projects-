// Written by Aicha Maiga 
// 02/14/2025


using System;
using System.Collections.Generic;


namespace P135Simula_sTest
{
    public class SimulaTest
    {
        private StateOfChest currentState;
        public enum StateOfChest { Open, Closed, Locked }

       
        public string Closing()

        {
            //string message = "";

            if (currentState == StateOfChest.Open)
            {
                currentState = StateOfChest.Closed;
            }
            return "The chest is closed " ;
        }
        public string Locking()

        {

            if (currentState == StateOfChest.Closed)
            {
                currentState = StateOfChest.Locked;
                
            }
            return "The chest is locked"; 
        }
        public string Unlocking()

        {

            if (currentState == StateOfChest.Locked)
            {
                currentState = StateOfChest.Closed;
            }
            return "The chest is unlocked " ;
        }
        public string Opening()

        {

            if (currentState == StateOfChest.Closed)
            {
                currentState = StateOfChest.Open;
            }
            return "The chest is open" ;
        }
        
    }
}

