// Written by Aicha Maiga
// 02/14/2025


using System;
using System.Collections.Generic;


namespace P143SimulasSoup
{
    public class SimulaSoup
    {
        // variables 
        public enum FoodType { soup, stew, gumbo };
        public enum MainIngredient { mushrooms, chicken, carrots, potatoes };
        public enum Seasoning { spicy, salty, sweet};

        private (FoodType type, MainIngredient ingredient, Seasoning seasoning) food;
        
        // constructor 
        public SimulaSoup( FoodType type, MainIngredient ingredient, Seasoning seasoning)
        {
            food= (type, ingredient, seasoning);
        }

        // methods
        public string GetFoodType()
        {
            return food.type.ToString();
        }
        public string GetMainIngredient()
        {
            return food.ingredient.ToString();
        }
        public string GetSeasoning()
        {
            return food.seasoning.ToString();
        }

    } 
}
