// written by Aicha Maiga 
// 04/16/2025




namespace HW8BaseballGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BaseballGame theBaseballGame = new BaseballGame();
            List<string> Ops1 = new List<string>{ "5", "2", "C", "D", "+" };
            Console.WriteLine(theBaseballGame.Score(Ops1)); 

            List<string> ops2 =new List<string> { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Console.WriteLine(theBaseballGame.Score(ops2)); 

            List<string> ops3 = new List<string>{ "1", "C" };
            Console.WriteLine(theBaseballGame.Score(ops3)); 
            
        }

    }
}

