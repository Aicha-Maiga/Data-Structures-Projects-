//written by Aicha Maiga
//04/23/2025


namespace HW9ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ReverseString Reverser = new ReverseString();

            char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
            Reverser.ReverseWord(s1);
            Console.WriteLine(new string(s1)); 

            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            Reverser.ReverseWord(s2);
            Console.WriteLine(new string(s2)); 
        }
    }
}
