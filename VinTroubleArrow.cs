// Written by Aicha Maiga
// 02/12/2025


using System;
using System.Collections.Generic;


namespace P153VinFletcherArrows
{
    public class Arrow
    {
        // variables
        private string arrowhead = "n/a";
        private string fletching = "n/a";
        private float length = 0;

        //gets and sets
        public string Arrowhead
        {
            get { return this.arrowhead; }
            set
            {
                if (value == "steel" || value == "wood" || value == "obsidian")
                    this.arrowhead = value;
                else
                {
                    this.arrowhead = "n/a";
                }
            }
        }
        public string Fletching
        {
            get { return this.fletching; }
            set
            {
                if (value == "plastic" || value == "turkey feathers" || value == "goose feathers")
                {
                    this.fletching = value;
                }
                else
                {
                    this.fletching = "n/a";
                }
            }
        }

        public float Length
        {
            get { return this.length; }
            set
            {
                if (value >= 60 && value <= 100)
                {
                    this.length = value;
                }
                else
                {
                    this.length = 0;
                }
            }
        }

        // getter method 
        public string GetArrowhead() => arrowhead;
        public string GetFletching() => fletching;
        public float GetLength() => length;


        // methods  
        public float GetCost()
        {
            float arrowheadcost = 0;

            if (Arrowhead == "steel")
            {
                arrowheadcost = 10;
            }
            else if (Arrowhead == "wood")
            {
                arrowheadcost = 3;
            }
            else if (Arrowhead == "obsidian")
            {
                arrowheadcost = 5;
            }

            float fletchingcost = 0;

            if (Fletching == "plastic")
            {
                fletchingcost = 10;
            }
            else if (Fletching == "turkey feathers")
            {
                fletchingcost = 5;
            }
            else if (Fletching == "goose feathers")
            {
                fletchingcost = 3;
            }

            float lengthcost = 0;
            lengthcost = Length * 0.05f;

            return arrowheadcost + fletchingcost + lengthcost;



        }

    }
}