// Written by Aicha Maiga
// 02/05/2025

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace P83DiscountedInventory
{
    public class DiscountedInventory
    {
        // variables 
        private int number;
        private string name ="n/a";

        // gets and sets 
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        // methods

        public int ItemPrice()
        {
            int ItemPrice = 0;

            switch (Number)
            {
                case 1:
                    ItemPrice = 10;
                    break;
                case 2:
                    ItemPrice = 16;
                    break;
                case 3:
                    ItemPrice = 24;
                    break;
                case 4:
                    ItemPrice = 2;
                    break;
                case 5:
                    ItemPrice = 20;
                    break;
                case 6:
                    ItemPrice = 200;
                    break;
                case 7:
                    ItemPrice = 2;
                    break;
            }
            return ItemPrice;
        }

        public double DiscountedPrice()
        {
            double Price = ItemPrice();

            if ( Name == "Aicha")
            {
                Price *= 0.5;
            }
            return Price;
        }

        public override string ToString()
        {
            string message = "";
            message = message + " The following items are available:" + "\n";
            message = message + " 1- Rope" + "\n";
            message = message + " 2- Torches" + "\n";
            message = message + " 3-Climbing Equipment" + "\n";
            message = message + " 4- Clean Water" + "\n";
            message = message + " 5- Machete" + "\n";
            message = message + " 6- Canoe" + "\n";
            message = message + " 7- Food Supplies" + "\n";

            return message;
        }


    }
}
    

