//writtem by Aicha Maiga 
// 04/16/2025


namespace HW8PivotIndex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindPivotIndex Pivot = new FindPivotIndex();

            int[] nums1 = { 1, 7, 3, 6, 5, 6 };
            int[] nums2 = { 1, 2, 3 };
            int[] nums3 = { 2, 1, -1 };

            Console.WriteLine(Pivot.PivotIndex(nums1)); 
            Console.WriteLine(Pivot.PivotIndex(nums2));        
            Console.WriteLine(Pivot.PivotIndex(nums3));
        }
    }
}
