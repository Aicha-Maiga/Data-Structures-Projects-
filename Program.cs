// Wrtitten by Aicha Maiga
// 2/2/2025


namespace RepairingTheClockTower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClockRepair aClockRepair = new ClockRepair();

            Console.WriteLine("Enter a number:");
            aClockRepair.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aClockRepair.ClockSound());
        }
    }
}
