//written by Aicha Maiga
//04/23/2025


namespace MovingZeroes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            int[] nums = { 0, 1, 0, 3, 12 };

            aSolution.MoveZeroes(nums);

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            
        }
    }
}
