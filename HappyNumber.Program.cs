// written by Aicha Maiga
// 04/23/2025


namespace HW9HappyNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HappyNumber checker = new HappyNumber();

            Console.WriteLine($"Is 19 a happy number? {checker.IsHappy(19)}");  
            Console.WriteLine($"Is 2 a happy number? {checker.IsHappy(2)}");   


        }
    }
}
