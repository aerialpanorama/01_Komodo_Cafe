using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary
{


    public enum MealType
    {
        Breakfast = 1,
        Lunch,
        Dinner,

    }

  //POCO simple class that is an object / single resposibility object that holds DATA. 
  public class MenuRepositoryClass
    {

        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealListOfIngridients { get; set; }
        public double MealPrice { get; set; }
        public MealType TypeOfMeal { get; set; }

        public MenuRepositoryClass() { }

        public MenuRepositoryClass(string mealNumber, string mealName, string mealDescription, string mealListOfIngridients, double mealPrice, MealType typeOfMeal)
       
        //contructor
        {
            //property       //parameter
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealListOfIngridients = mealListOfIngridients;
            MealPrice = mealPrice;
            TypeOfMeal = typeOfMeal;


        }

         


        //create method

        // read All method

        //update method

        //delete method

    }
}
//Komodo cafe is getting a new menu. The manager wants to be able to create new menu items, update menu items, delete menu items, 
//and receive a list of all items on the cafe's menu. She needs a console app.

/*
    A meal number, so customers can say "I'll have the #5"
    A meal name
    A description
    A list of ingredients,
    A price
*/

