// Written by Aicha Maiga 
// 02/19/2025

namespace HW4IsInOrderorNot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LettersInOrder  theLettersInOrder = new LettersInOrder();

            Console.WriteLine(theLettersInOrder.ISinOrder("abc"));
            Console.WriteLine(theLettersInOrder.ISinOrder("edabit"));
            Console.WriteLine(theLettersInOrder.ISinOrder("123"));

        }
    }
}
