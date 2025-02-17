// Written by Aicha Maiga
// 02/12/2025

using P153VinFletcherArrows;

namespace P153VinArrow
{
    public class VinArrowProgram
    {
        public static void Main(string[] args)
        {
            Arrow anArrow = new Arrow(); 
                
            Console.WriteLine("Choose an arrowhead type (steel, wood, obsidian):");
            string inputArrowhead = Console.ReadLine()?.Trim().ToLower() ?? "";
            if (inputArrowhead == "steel" || inputArrowhead == "wood" || inputArrowhead == "obsidian")
            {
                anArrow.Arrowhead = inputArrowhead;
            }

            Console.WriteLine("Choose a fletching type (plastic, turkey feathers, goose feathers):");
            string inputFletching = Console.ReadLine()?.Trim().ToLower() ?? "";
            if (inputFletching == "plastic" || inputFletching == "turkey feathers" || inputFletching == "goose feathers")
            {
                anArrow.Fletching = inputFletching;
            }
               
               
            Console.WriteLine("Enter the length of the arrow (between 60 and 100 cm):");
            float inputLength;
            if (float.TryParse(Console.ReadLine(), out inputLength) && inputLength >= 60 && inputLength <= 100)
            {
                anArrow.Length = inputLength;
            }
               
             Console.WriteLine($"Total Cost: ${anArrow.GetCost():0.00}");
        }
    }
}
    

