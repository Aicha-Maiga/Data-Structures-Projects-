// Written by Aicha Maiga 
// 02/19/2025


namespace HW4ChangingLetters
{
    public class ChangingLettersProgram
    {
        public static void Main(string[] args)
        {
            ChangingLetters GetchangingLetters = new ChangingLetters();

            Console.WriteLine(GetchangingLetters.ChangetoNext("hello"));
            Console.WriteLine(GetchangingLetters.ChangetoNext("bye"));
            Console.WriteLine(GetchangingLetters.ChangetoNext("welcome"));

        }
    }
}
