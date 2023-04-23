﻿using System;
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



            // Set the Foreground color to DarkMagenta
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Display Foreground color DarkMagenta
            Console.Write("{0}\n  **  WELCOME TO THE RECIPE COMMAND LINE APPLICATION!! ** \n{0} "
                    , "=======================================================================",Console.ForegroundColor);

            //prompting the user to enter the number of ingredients
            Console.Write("Please enter the number of ingredients: ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());

            //creating a for loop 
            for (int  i = 0;  i < numOfIngredients;  i++)
            {
                //prompting the user to enter the name of the ingredients
                Console.Write("Please enter the name of the ingredient: ");
                ingredient.IngredientName = Console.ReadLine();//calling the setter and setting the ingredient name to user input
                //prompting the user to enter the quantity of the ingredients    
                Console.Write("Please enter the quantity of the ingredient: ");
                ingredient.Quantity = Convert.ToInt32(Console.ReadLine());
                //prompting the user to enter the unit of measurement
                Console.Write("Please enter the unit of measurment: ");
                ingredient.MeasurementUnit = Console.ReadLine();





            }
            Console.ReadKey();
        }
    }
}
