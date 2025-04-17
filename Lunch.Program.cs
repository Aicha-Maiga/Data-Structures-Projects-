// written by Aicha Maiga
// 04/16/2025


namespace HW8StudentsLunch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Lunch theLunch = new Lunch();

            Console.WriteLine(theLunch.CountStudents(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 })); 
            Console.WriteLine(theLunch.CountStudents(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 })); 

        }

    }
}
