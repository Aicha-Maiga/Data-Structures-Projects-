// written by Aicha Maiga
// 04/09/2025


namespace HW7FirstUniqChar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FirstUniqChar Solution = new FirstUniqChar();

            Console.WriteLine(Solution.FirstCharacter("leetcode"));    
            Console.WriteLine(Solution.FirstCharacter("loveleetcode"));  
            Console.WriteLine(Solution.FirstCharacter("aabb"));         

        }
    }
}
