// written by Aicha Maiga
//04/09/2025


namespace HW7FindtheDifference
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Difference theDifference = new Difference();

            Console.WriteLine(theDifference.LetterAdded("abcd", "abcde"));
            Console.WriteLine(theDifference.LetterAdded("", "y"));   
        }
    }
}
