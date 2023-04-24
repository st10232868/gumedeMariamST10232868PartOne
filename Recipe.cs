using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gumedeMariamST10232868PartOne
{
    class Recipe
    {   //creating arraylist
        private List<IngredientData> arrIngredients;
        private List<string> arrDescriptions;
        //creating an instance of an object (the IngredientData class)
        IngredientData ingredient = new IngredientData();


        //creating a constructor
        public Recipe()
        {
            arrIngredients = new List<IngredientData>();
            arrDescriptions = new List<string>();
        }
        //creating a method that adds an ingredient
        public void AddIngredients()
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
                //prompting the user to enter the name of the ingredients
                Console.Write("Please enter the name of the ingredient: ");
                //calling the setter and setting the ingredient name to user input
                ingredient.IngredientName = Console.ReadLine();
                //prompting the user to enter the quantity of the ingredients    
                Console.Write("Please enter the quantity of the ingredient: ");
                ingredient.Quantity = Convert.ToInt32(Console.ReadLine());
                //prompting the user to enter the unit of measurement
                Console.Write("Please enter the unit of measurment: ");
                ingredient.MeasurementUnit = Console.ReadLine();

                //prompting the user to enter the number of steps 
                Console.Write("\nPlease enter the number of steps the recipe has: ");
                ingredient.NumOfSteps = Convert.ToInt32(Console.ReadLine());
                
               
            }

        
        }
            //creating a parametized method that adds descriptions based on the number of steps
            public void AddStep(String description)
            {
            arrDescriptions.Add(description);
            }
        
    }
}

