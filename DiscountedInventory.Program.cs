// Written by Aicha Maiga

using System.ComponentModel.Design;

namespace P83DiscountedInventory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DiscountedInventory aDiscountedInventory = new DiscountedInventory();

            Console.WriteLine(aDiscountedInventory.ToString());

            Console.WriteLine(" What number do you want to see the price of?");
            aDiscountedInventory.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name:");
            aDiscountedInventory.Name = Console.ReadLine() ?? string.Empty;

            int actualprice = aDiscountedInventory.ItemPrice();
            double discount = aDiscountedInventory.DiscountedPrice();

            if (actualprice != discount) 
            {
                Console.WriteLine(aDiscountedInventory.DiscountedPrice());
            }
            else
            {
                Console.WriteLine(aDiscountedInventory.ItemPrice());
            }
                    

            //Console.WriteLine(aDiscountedInventory.ItemPrice());
        }
    }
}
