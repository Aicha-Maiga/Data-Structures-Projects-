//written by Aicha Maiga
//04/23/2025



namespace HW9LenghofLastWord
{
    public class Program
    {
        public static void Main(string[] args)
        {

            LastWord theLastWord = new LastWord();

            string test1 = "Hello World";
            string test2 = "   fly me   to   the moon  ";
            string test3 = "luffy is still joyboy";

            Console.WriteLine($"Length of last word in: \"{test1}\" is {theLastWord.FindLength(test1)}");
            Console.WriteLine($"Length of last word in: \"{test2}\" is {theLastWord.FindLength(test2)}");
            Console.WriteLine($"Length of last word in: \"{test3}\" is {theLastWord.FindLength(test3)}");

        }
    }
}
