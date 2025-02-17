// Written by Aicha Maiga 
// 02/12/2025

namespace HW3Questions
{
    public class MinMaxProgram
    {
        public static void Main(string[] args)

        {
            MinMax aMinMax = new MinMax();
            int[] result1 = aMinMax.FindMinMax(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"[{result1[0]}, {result1[1]}]");
        }
    }
}
