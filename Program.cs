//Written by Aicha Maiga 
//01/27/2025

namespace QuizCalculatorSpring2025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuizCalculator aQuizCalculator = new QuizCalculator();

            aQuizCalculator.Quiz1 = 80.0;
            aQuizCalculator.Quiz2 = 85.0;
            aQuizCalculator.Quiz3 = 90.0;
            aQuizCalculator.Quiz4 = 85.0;



            Console.WriteLine("Total: " + aQuizCalculator.CalcTotal());
            Console.WriteLine("Average: " + aQuizCalculator.CalcAverage());
            Console.WriteLine("Letter Grade: " + aQuizCalculator.CalcLetterGrade());
        }
    }
}
