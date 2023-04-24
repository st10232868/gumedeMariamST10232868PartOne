using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gumedeMariamST10232868PartOne
{
    class IngredientData
    {

        //declaring variables 
        private int numOfIngredients, quantity, numOfSteps, option = 0;//field
        private string nameOfIngredient, descrip, name,recipeName;//field
        private String unitOfMeasurement;//field

        //creating a default constructor
        public IngredientData()
        {

        }

        /**creating getters and setters for the option,
       nameOfIngredient,quantity,descrip and unitOfMeasurement **/
        public int NumOfIngredients//property
        {
            get { return numOfIngredients; }
            set { numOfIngredients = value; }
        }
        //creating a getter and setter for the ingredient name
        public String IngredientName//property
        {
            get { return nameOfIngredient; }
            set { nameOfIngredient = value; }

        }
        //creating a getter and setter for Description
        public String Description//property
        {
            get { return descrip; }
            set { descrip = value; }
        }
        //creating a getter and setter for unit of measurement
        public String MeasurementUnit //property
        {
            get { return unitOfMeasurement; }
            set { unitOfMeasurement = value; }
        }
        //creating a getter and setter for quantity
        public int Quantity//property
        {
            get { return quantity; }
            set { quantity = value; }
        }
        //creating an getter and setter for number of steps
        public int NumOfSteps//property
        {
            get { return numOfSteps; }
            set { numOfSteps = value; }
        }
        //creating a parametized constructor
        public IngredientData(string recipeName, string nameOfIngredient, int quantity, string unitOfMeasurement, int numOfSteps, String descrip)
        {   //creating an instance of itself
            this.quantity = quantity;
            this.numOfSteps = numOfSteps;
            this.recipeName = recipeName;
            this.nameOfIngredient = nameOfIngredient;
            this.descrip = descrip;
            this.unitOfMeasurement = unitOfMeasurement;
        }

        //creating a display methods to display user output
        public String ToString()
        {
            string ingredient = string.Format("Recipe For\t\t\t : {0}\nIngredient Name\t\t\t : {1}\nQuantity\t\t\t : " +
                "{2}\nUnit of Measurement\t\t : {3}\nDirections\t\t\t : {4}",
                recipeName, IngredientName, Quantity, MeasurementUnit, Description);

            return (ingredient);
        }


    }
}
