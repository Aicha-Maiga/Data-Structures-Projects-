// Written by Aicha Maiga 
// 02/05/2025


namespace P94TheReplicatorofDTO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int [] array2 = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = number;
            }
            for ( int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"array1[{i}] = {array1[i]}, array2[{i}] = {array2[i]}");
            }
        }
    }
}
