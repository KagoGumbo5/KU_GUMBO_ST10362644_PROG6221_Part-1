using System;

namespace RecipeApp
{
    
    class Recipe
    {
        //Array to store ingredients and steps 
        public Ingredient[] Ingredients { get; set; }
        public Step[] Steps { get; set; }

        //This method is to display the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            // Reset all quantities to original values
        }

        public void ClearRecipe()
        {
            // Clear all data
        }
    }
}