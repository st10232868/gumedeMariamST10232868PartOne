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
            // Set the Foreground color to DarkMagenta
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Display Foreground color DarkMagenta
            Console.Write("{0}\n  **  WELCOME TO THE RECIPE COMMAND LINE APPLICATION!! ** \n{0} "
                    , "=======================================================================",Console.ForegroundColor);

            //prompting the user to enter the number of ingredients
            Console.Write("Please enter the number of ingredients: ");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
