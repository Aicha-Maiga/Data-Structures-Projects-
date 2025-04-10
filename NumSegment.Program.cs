// written by Aicha Maiga
// 04/09/2025



namespace HW7NumOfSegments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumberSegment NumSeg = new NumberSegment();

            Console.WriteLine(NumSeg.CountSegment("Hello, my name is John")); 
            Console.WriteLine(NumSeg.CountSegment("Hello"));
        }
    }
}
