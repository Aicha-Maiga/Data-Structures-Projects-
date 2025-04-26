//written by Aicha Maiga
//04/23/2025




namespace HW9MajorityElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MajorityElement Majority = new MajorityElement();

            int[] nums1 = { 3, 2, 3 };
            Console.WriteLine($"Majority element: {Majority.FindMajority(nums1)}");

            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine($"Majority element: {Majority.FindMajority(nums2)}");
        }
    }
}
