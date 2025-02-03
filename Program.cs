// Written by Aicha Maiga
// 2/2/2025

namespace TheDominionOfKings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ScoreCalculator aScoreCalculator = new ScoreCalculator();

            Console.WriteLine("Enter the number of estate: ");
            aScoreCalculator.Estate =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of duchy: ");
            aScoreCalculator.Duchy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of province: ");
            aScoreCalculator.Province = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Total Score:" + aScoreCalculator.CalcTotalScore());
            Console.WriteLine(aScoreCalculator.ToString());
        }
    }
}
