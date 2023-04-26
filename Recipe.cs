using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gumedeMariamST10232868PartOne
{
    class Recipe
    {
        //creating an instance of an object (the IngredientData class) and declaring arrayLists
        IngredientData ingredient = new IngredientData();
        public static ArrayList ArrIngredients = new ArrayList();
        public static ArrayList arrQuantity = new ArrayList();
        public static ArrayList arrDescription = new ArrayList();
        public static ArrayList arrUnit = new ArrayList();
        public static ArrayList arrScaledFactor = new ArrayList();
        //creating a constructor
        public Recipe()
        {
        }
        //creating a method that adds an ingredient
        public void EnterIngredients()
        {   
            
            //prompting the user to enter the number of ingredients
            Console.Write("Please enter the number of ingredients: ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());
            //declaring and prompting the user to enter the name of the recipe
            Console.WriteLine("Pleasen enter the name of the recipe");
            String recipeName = Console.ReadLine();
            //creating a for loop 
            for (int i = 0; i < numOfIngredients; i++)
            {
                
                //prompting the user to enter the name,quantity,unit of measurement and description of the ingredients
                Console.Write($"Please enter the name of the ingredient {1+i} : ");
                ingredient.IngredientName = Console.ReadLine();
                ArrIngredients.Add(ingredient.IngredientName);
                Console.Write($"Please enter the quantity of the ingredient {1+i}:");
                ingredient.Quantity = Convert.ToInt32(Console.ReadLine());
                arrQuantity.Add(ingredient.Quantity);
                Console.Write($"Please enter the unit of measurement {1+i}: ");
                ingredient.MeasurementUnit = Console.ReadLine();
                arrUnit.Add(ingredient.MeasurementUnit);

                //prompting the user to enter the number of steps 
                Console.Write("\nPlease enter the number of steps the recipe has: ");
                ingredient.NumOfSteps = Convert.ToInt32(Console.ReadLine());
                //prompting the user to enter the description
                Console.Write("Please Enter a Description of each step: \n");
                //creating a for loop to loop
                for (int j = 0; j < ingredient.NumOfSteps; j++)
                {
                    Console.WriteLine("Step : {0}", (j + 1));
                    ingredient.Description = Console.ReadLine();
                    arrDescription.Add(ingredient.Description);
                }

                   
                // Set the Foreground color to cyan
                Console.ForegroundColor = ConsoleColor.Cyan;
                // Display Foreground color cyan
                Console.Write("\n{0}\n  ~~ Ingredient Details have been saved successfully!!\n\n{0}\n ",
                                  "******************************************************\n ", Console.ForegroundColor);
                

            }



            Console.ReadKey();
        }
     

        //creating a function that will display the full recipe
        public void DisplayRecipe()
        {

               // Set the Foreground color
                Console.ForegroundColor = ConsoleColor.Blue;
                // Display Foreground color 
                Console.Write("\n\n{0}\n  ~~~ Here Is The Full Recipe ~~~ \n{0}\n\n "
                        , "###########################################################", Console.ForegroundColor);
            for(int i = 0;i< arrQuantity.Count;i++) 

            {
               
                Console.WriteLine($"This is the recipe for: >>  \n\n ~~~ INGREDIENTS ~~~ \n\n{arrQuantity[i]} {arrUnit[i]} {ArrIngredients[i]}" );
            }
            // Set the Foreground color to blue
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Display Foreground color blue
            Console.Write("\n\nSTEPS: >>", Console.ForegroundColor);
            
            for(int j = 0; j < arrDescription.Count; j++)
            {
                Console.WriteLine($"{j + 1} {arrDescription [j]}");
            }

            
            Console.ReadKey();

        }
        public void ScaleRecipe(double factor)
        {
            
            for (int i =0;i< arrQuantity.Count;i++)
            {

                double quantity = Convert.ToDouble(arrQuantity[i]);
                if (factor == 1)
                {
                    factor= quantity*0.5;
                    arrScaledFactor[i] = factor;
                    
                }
                else if (factor == 2)
                {
                    factor = quantity * 2;
                    arrScaledFactor[i] = factor;

                }
                else if (factor == 3)
                {
                    factor = quantity * 3;
                    arrScaledFactor[i] = factor;

                }
                
            }

            Console.WriteLine($"Recipe scaled by factor of {factor}.\n\n");
            //DisplayRecipe();

            for (int i = 0; i < arrQuantity.Count; i++)

            {

                Console.WriteLine($"This is the recipe for: >>  \n\n ~~~ INGREDIENTS ~~~ \n\n {arrScaledFactor[i]} " +
                    $"{arrUnit[i]} {ArrIngredients[i]}");
            }

            Console.Write("\n\nSTEPS >> ");

            for (int j = 0; j < arrDescription.Count; j++)
            {
                Console.WriteLine($"{j + 1} {arrDescription[j]}");
            }

        }
        public static void ResetFactor()
        {
            for (int i = 0; i < arrQuantity.Count; i++)
            {
                arrScaledFactor.Insert(i, arrQuantity[i]);
            }
            Console.WriteLine("Quantities have been reset to it's original value !! ");
        }
        //creating a method that clears all the data
        public void ClearRecipe()
        {

            ArrIngredients.Clear();
            arrUnit.Clear();
            arrDescription.Clear();
            arrQuantity.Clear();
            Console.WriteLine("ALL DATA HAS BEEN SUCCESSFULLY CLEARED");
            //calling the EnterIngredients method
            EnterIngredients();

        }
    }  
}

