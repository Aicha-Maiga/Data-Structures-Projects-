// written by Aicha Maiga
// 04/09/2025


namespace HW7MaxNumBalloons
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MaxNumBalloons Solution = new MaxNumBalloons();
            Console.WriteLine(Solution.MaxNumofInstances("nlaebolko")); 
            Console.WriteLine(Solution.MaxNumofInstances("loonbalxballpoon")); 
            Console.WriteLine(Solution.MaxNumofInstances("leetcode")); // 0
        }
    }
}
