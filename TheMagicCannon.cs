// Written by Aicha Maiga
// 02/05/2025


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;


namespace p89TheMagicCannon
{
    public class TheMagicCannon
    {
        // variables
        private int number = -1;
        
        //gets and sets 
        public int Number 
        { 
            get { return this.number; } 
            set { this.number = value; } 
        }

        // methods
        public string CannonBlast(int number )
        {
            
            //for (int number = 1; number <= 100; number++)
            {


                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "Electric and Fire";
                }
                else if (number % 5 == 0)
                {
                    return "Electric";
                }
                else if (number % 3 == 0)
                {
                    return "Fire";
                }
                else
                {
                    return "Normal";

                }
            }
 
        }

        }
    }

