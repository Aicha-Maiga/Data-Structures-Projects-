// written by Aicha Maiga
// 04/09/2025


namespace HW7MergeStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MergingStrings Solution = new MergingStrings();

            Console.WriteLine(Solution.MergedString("abc", "pqr"));   
            Console.WriteLine(Solution.MergedString("ab", "pqrs"));   
            Console.WriteLine(Solution.MergedString("abcd", "pq"));
        }
    }
}
