// Written by Aicha Maiga 
// 02/14/2025

namespace P143SimulasSoup
{
    public class SimulaSoupProgram
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Choose a food type (soup, stew, gumbo):");
            string inputFood = Console.ReadLine()?.Trim().ToLower() ?? "";

            SimulaSoup.FoodType selectedFoodType;
            if (inputFood == "soup")
            {
                selectedFoodType = SimulaSoup.FoodType.soup;
            }
            else if (inputFood == "stew")
            {
                selectedFoodType = SimulaSoup.FoodType.stew;
            }
            else if (inputFood == "gumbo")
            {
                selectedFoodType = SimulaSoup.FoodType.gumbo;
            }
            else
            {
                selectedFoodType = SimulaSoup.FoodType.soup;
            }
           
            Console.WriteLine("Choose a main ingredient (mushrooms, chicken, carrots, potatoes):");
            string inputIngredient = Console.ReadLine()?.Trim().ToLower() ?? "";

            SimulaSoup.MainIngredient selectedIngredient;
            if (inputIngredient == "mushrooms")
            {
                selectedIngredient = SimulaSoup.MainIngredient.mushrooms;
            }
            else if (inputIngredient == "chicken")
            {
                selectedIngredient = SimulaSoup.MainIngredient.chicken;
            }
            else if (inputIngredient == "carrots")
            {
                selectedIngredient = SimulaSoup.MainIngredient.carrots;
            }
            else if (inputIngredient == "potatoes")
            {
                selectedIngredient = SimulaSoup.MainIngredient.potatoes;
            }
            else
            {
                selectedIngredient = SimulaSoup.MainIngredient.chicken;
            }
            
            Console.WriteLine("Choose a seasoning (spicy, salty, sweet):");
            string inputSeasoning = Console.ReadLine()?.Trim().ToLower() ?? "";

            SimulaSoup.Seasoning selectedSeasoning;
            if (inputSeasoning == "spicy")
            {
                selectedSeasoning = SimulaSoup.Seasoning.spicy;
            }
            else if (inputSeasoning == "salty")
            {
                selectedSeasoning = SimulaSoup.Seasoning.salty;
            }
            else if (inputSeasoning == "sweet")
            {
                selectedSeasoning = SimulaSoup.Seasoning.sweet;
            } 
            else
            {
                selectedSeasoning = SimulaSoup.Seasoning.salty;
            }
            
            SimulaSoup aSimulaSoup = new SimulaSoup(selectedFoodType, selectedIngredient, selectedSeasoning);

            Console.WriteLine($"\nYour soup: {aSimulaSoup.GetSeasoning()} {aSimulaSoup.GetMainIngredient()} {aSimulaSoup.GetFoodType()}.");
        }

    }
}
