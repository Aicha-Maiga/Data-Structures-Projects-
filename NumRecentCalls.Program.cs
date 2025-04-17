// written by Aicha Maiga 
// 04/14/2025


namespace HW8NumRecentCalls
{
    public class Program
    {
        public static void Main(string[] args)
        {

            RecentCounter theRecentCounter = new RecentCounter();
            Console.WriteLine(theRecentCounter.Ping(1));     
            Console.WriteLine(theRecentCounter.Ping(100));   
            Console.WriteLine(theRecentCounter.Ping(3001));  
            Console.WriteLine(theRecentCounter.Ping(3002));

        }
    }
}
