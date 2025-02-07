// Written by Aicha Maiga
// 02/05/2025

namespace p89TheMagicCannon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TheMagicCannon aMagicCannon = new TheMagicCannon();

            for (int number = 1; number <= 100; number++)
            {
                string blast = aMagicCannon.CannonBlast(number);

                if (blast == "Electric and Fire")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (blast == "Electric")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (blast == "Fire")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine($"{number}: {blast}");
                Console.ResetColor();

            }

        }
        
    }
}
