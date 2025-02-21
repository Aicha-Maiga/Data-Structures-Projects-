// Written by Aicha Maiga 
// 02/19/2025


namespace HW4WordCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WordCount theWordCount = new WordCount();

            Console.WriteLine(theWordCount.FindWordCount("This is a test"));
            Console.WriteLine(theWordCount.FindWordCount("What an easy task, right"));
        }
    }
}
