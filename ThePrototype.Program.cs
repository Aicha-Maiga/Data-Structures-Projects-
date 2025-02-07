// Written by Aicha Maiga
//02/05/2025

namespace ThePrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ThePrototype _ThePrototype = new ThePrototype();
            int number;

            Console.WriteLine("User 1, please enter a number between 0 and 100:");
            number = Convert.ToInt32(Console.ReadLine());
           
            while (number < 0 || number > 100);

            _ThePrototype.NumberUser1 = number;  

            Console.Clear();
            Console.WriteLine("User 2, guess the number.");

            while (true)
            {
                Console.Write("What is your next guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());

                string result = _ThePrototype.EvaluateGuess(guess); 
                Console.WriteLine(result);

                if (result == "You guessed the number!")
                    break;
            }
        }
    }

}

