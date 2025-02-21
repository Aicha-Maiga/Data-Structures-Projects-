// Written by Aicha Maiga 
// 02/19/2025



namespace HW4NumVowels
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Vowels theVowels = new Vowels();
            Console.WriteLine(theVowels.FindNumVowels("sharpening skills", 3)); 
            Console.WriteLine(theVowels.FindNumVowels("major league", 5)); 
            Console.WriteLine(theVowels.FindNumVowels("hostess", 5));
        }
    }
}
