using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gumedeMariamST10232868PartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of an object (the IngredientData class)
            IngredientData ingredient = new IngredientData();
            Recipe recipes = new Recipe();
            // creating an empty array list for the object Recipe Ingredients


            // Set the Foreground color to DarkMagenta
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Display Foreground color DarkMagenta
            Console.Write("{0}\n  **  WELCOME TO THE RECIPE COMMAND LINE APPLICATION!! ** \n{0}\n "
                    , "=======================================================================", Console.ForegroundColor);
            do
            {
                recipes.EnterIngredients();
                DisplayMenu();
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    recipes.DisplayRecipe();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Are you sure you'd like to Change the scale factor? \nEnter 'Y' or 'N'");
                    String option1 = Console.ReadLine().ToUpper();
                    if (option1.Equals("Y"))
                    {
                        Console.WriteLine("\nChange Scale Factor by selecting an option by entering a number next to the option: \n");
                    Console.WriteLine("(1) {0}\n(2) {1}\n(3) {2}", "Half", "Double", "Triple");
                    double factor = Convert.ToDouble(Console.ReadLine());

                    recipes.ScaleRecipe(factor); 
                    }
                    else 
                    {
                        Console.WriteLine("You entered 'N' and will be directed to the main menu\n");
                        DisplayMenu();
                    }
                   
                }
                else if (option == 3)
                {
                    
                }
                else if (option == 4)
                {
                    Console.WriteLine("Are you sure you'd like to clear all the data \nEnter 'Y' or 'N'");
                    String clear = Console.ReadLine().ToUpper();
                    if (clear.Equals("Y"))
                    {
                        recipes.ClearRecipe();
                        recipes.EnterIngredients();
                    }
                    else
                    {
                        Console.WriteLine("You entered 'N' and will be directed to the main menu\n");
                        DisplayMenu();
                    }
                }
                else if (option == 5)
                {
                    Environment.Exit(option);
                }
                else
                {
                    Console.WriteLine("INVALID SELECTION!!");
                }
                Console.ReadKey();
            } while (true);


        }
        static void DisplayMenu()
        {
            String menu1 = String.Format("\nPlease select an option by entering a number next to the option:" +
                " \n\n (1) {0}\n (2) {1}\n (3) {2}\n (4) {3}\n (5) {4}\n\n",
                 "Display Recipe","Change Scale Recipe", "Reset Ingredient Quantity",
                "Clear Recipe", "Exit");

            Console.WriteLine(menu1);

        }


    }
}
