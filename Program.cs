// Written by Aicha Maiga 
// 04/02/2025



namespace HW6_TwoSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TwoSum theTwoSum = new TwoSum();

            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            int[] result = theTwoSum.FindTwoSum(nums, target);

            Console.WriteLine("[" + result[0] + ", " + result[1] + "]");

        }
    }
}
