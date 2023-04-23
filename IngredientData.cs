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
        private string nameOfIngredient, descrip, name;//field
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



    }
}
