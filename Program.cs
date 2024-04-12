using System;
{
    
}
namespace RecipeApp
{
    
    class Program
    {
        static void Main()
        {
            Recipe recipe = new Recipe();//creates a new recipe
            bool exit = false;
            //This loop will display and collect input
            while (!exit)
            {
                //This is the menu options that are going to be displayed
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Exit");
                //Gets user input
                string choice = Console.ReadLine();

                //This processes the user's choice
                switch (choice)
                {
                    case "1":
                        recipe = EnterNewRecipe();
                        break;
                    case "2":
                        recipe.DisplayRecipe();
                        break;
                    case "3":
                        Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
                        if (double.TryParse(Console.ReadLine(), out double factor))
                        {
                            recipe.ScaleRecipe(factor);
                        }
                        else
                        {
                            Console.WriteLine("Invalid scaling factor.");
                        }
                        break;
                    case "4":
                        recipe.ResetQuantities();
                        break;
                    case "5":
                        recipe.ClearRecipe();
                        break;
                    case "6":
                        exit = true; //exit loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}