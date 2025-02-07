// Written by Aicha Maiga 
// 02/05/2025


using System.Reflection.PortableExecutable;

namespace BuyingInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuyingInventory aBuyingInventory = new BuyingInventory();

            Console.WriteLine(aBuyingInventory.ToString());

            Console.WriteLine(" What number do you want to see the price of?");
            aBuyingInventory.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aBuyingInventory.ItemPrice());

        }
    }
}
