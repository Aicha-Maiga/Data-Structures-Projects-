// writen by Aicha Maiga
// 02/05/2025


namespace Watchtower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WatchtowerSpotting aWatchTowerSpotting = new WatchtowerSpotting();

            Console.WriteLine(" Enter the X value:");
             aWatchTowerSpotting.ValueX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y value:");
            aWatchTowerSpotting.ValueY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aWatchTowerSpotting.GetEnemySpot());           
       }
    }
}
