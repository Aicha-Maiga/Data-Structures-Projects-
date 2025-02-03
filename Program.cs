// Written by Aicha Maiga
// 2/2/2025

namespace TheDefenseOfConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Title = "Defense of Consolas";


            SquadDeployment aSquadDeployment = new SquadDeployment();


            Console.WriteLine(" Target Row?");
            aSquadDeployment.Row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Target Column?");
            aSquadDeployment.Column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({aSquadDeployment.Row}, {aSquadDeployment.Column - 1})");
            Console.WriteLine($"({aSquadDeployment.Row -1}, {aSquadDeployment.Column})");
            Console.WriteLine($"({aSquadDeployment.Row}, {aSquadDeployment.Column + 1})");
            Console.WriteLine($"({aSquadDeployment.Row +1}, {aSquadDeployment.Column})");
          
            Console.Beep();
        }
    }
}
