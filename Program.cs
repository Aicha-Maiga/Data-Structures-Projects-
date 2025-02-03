// Written by Aicha Maiga
// 2/2/2025

namespace TheFourSisters_TheDuckbear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EggSharingCalculator anEggSharingCalculator = new EggSharingCalculator();

            Console.WriteLine("Enter the number of chocolate egg gathered today: ");
            anEggSharingCalculator.NumberofEggs = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Sisters share:" +anEggSharingCalculator.CalcSisterShare());
            Console.WriteLine("Duck share:" + anEggSharingCalculator.CalcDuckShare());

        }
    }
}
