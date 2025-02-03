// Written by Aicha Maiga
// 2/1/2025

namespace TheTriangleFarmer
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            AreaCalculator anAreaCalculator = new AreaCalculator();

            //anAreaCalculator.BaseLength = 20.0;
            //anAreaCalculator.Height = 10.0;

            Console.WriteLine("Enter Height:");
            anAreaCalculator.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Base:");
            anAreaCalculator.BaseLength = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Height: " + anAreaCalculator.Height);
            //Console.WriteLine("Base: " + anAreaCalculator.BaseLength);
            Console.WriteLine("Area: " + anAreaCalculator.CalcArea());

        }
    }
}
 