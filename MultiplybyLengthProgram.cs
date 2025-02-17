// Written by Aicha Maiga 
// 02/12/2025

namespace Multiplyby
{
    public class MultiplybyLengthProgram
    {
        public static void Main(string[] args)
        {
            MultiplybyLength aMultiplybyLength = new MultiplybyLength();

            int[] multiplyby = aMultiplybyLength.MultiplyByLength(new int[] { 4, 1, 1 });
            Console.WriteLine($"[{string.Join(", ", multiplyby)}]");

        }
    }
}
