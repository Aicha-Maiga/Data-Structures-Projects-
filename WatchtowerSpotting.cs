// Written by Aicha Maiga
// 02/05/2025


using System;
using System.Collections.Generic;


namespace Watchtower
{
    public class WatchtowerSpotting
    {
        // variables 
        private int valueX = -1;
        private int valueY = -1;

        // gets and sets 

        public int ValueX 
        { 
            get { return this.valueX; } 
            set { this.valueX = value; }
        }
        public int ValueY
        {
            get { return this.valueY; }
            set { this.valueY = value; }
        }

        public string GetEnemySpot()
        {
            string EnemySpot = "";

            if (ValueX < 0 && ValueY > 0)
            {
                EnemySpot = "The enemy spot is to the northwest!";
            }
            else if (ValueX < 0 && valueY == 0)
            {

                EnemySpot = "The enemy spot is to the west!";
            }
            else if (ValueX < 0 && ValueY < 0)
            {

                EnemySpot = "The enemy spot is to the southwest!";
            }
            else if (ValueX == 0 && valueY > 0)
            {

                EnemySpot = "The enemy spot is to the north!";
            }
            else if (ValueX == 0 && ValueY == 0)
            {

                EnemySpot = "The enemy spot is here!";
            }
            else if (ValueX == 0 && ValueY < 0)
            {

                EnemySpot = "The enemy spot is to the south!";
            }
            else if (ValueX > 0 && ValueY > 0)
            {

                EnemySpot = "The enemy spot is to the northeast!";
            }
            else if (ValueX > 0 && ValueY == 0)
            {

                EnemySpot = "The enemy spot is to the east!";
            }
            else if (ValueX > 0 && ValueY < 0)
            {

                EnemySpot = "The enemy spot is to the southeast!";
            }
            return EnemySpot;
            }
        }
    }


