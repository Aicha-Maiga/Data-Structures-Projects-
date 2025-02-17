// Written by Aicha Maiga
//02/14/2025

using System.Threading.Channels;

namespace P135Simula_sTest
{
    internal class SimulaTestProgram
    {
        public static void Main(string[] args)
        {
            
            SimulaTest aSimulaTest = new SimulaTest();
            Console.WriteLine("The current state is locked");

            while (true)
            {
                
                Console.WriteLine("What do you want to do?");
                //string input = Console.ReadLine();
                string input = Console.ReadLine()?.Trim().ToLower() ?? "";


                if (input == "open")
                {
                    Console.WriteLine(aSimulaTest.Opening());
                }
                else if (input == "close")
                {
                    Console.WriteLine(aSimulaTest.Closing());
                }
                else if (input == "lock")
                {
                    Console.WriteLine(aSimulaTest.Locking());
                }
                else if (input == "unlock")
                {
                    Console.WriteLine(aSimulaTest.Unlocking());
                }

               
            }
        }
    }
}
