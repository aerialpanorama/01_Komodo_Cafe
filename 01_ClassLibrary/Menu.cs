using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassLibrary //_06_RepositoryPattern_Repository
{
    public class Menu //stremingContentRepository
    {
        private List<MenuRepositoryClass> _listOfContent = new List<MenuRepositoryClass>();
        public List<MenuRepositoryClass> ListOfContent { get; set; }

        public void AddContentToList(MenuRepositoryClass content)
        //create method
        //_listOfContent is a field - properties and fields are both white
        // fields are underscored and camel case
        //properties are pascal case
        {
            _listOfContent.Add(content);
        }


        // read All method
        public List<MenuRepositoryClass> GetContentList()
        {
            return _listOfContent;
        }

    
 
        //update method

        public bool UpdateExistingContent(string originalMealNumber, MenuRepositoryClass newContent)
        {
            //Find the content
            MenuRepositoryClass oldContent = GetContentByMealNumber(originalMealNumber);

            //update the content
            if (oldContent != null)
            {
                oldContent.MealNumber = newContent.MealNumber;//A
                oldContent.MealName = newContent.MealName;//B
                oldContent.MealDescription = newContent.MealDescription;//C
                oldContent.MealListOfIngridients = newContent.MealListOfIngridients;//D
                oldContent.MealPrice = newContent.MealPrice;//E
                oldContent.TypeOfMeal = newContent.TypeOfMeal;//F

                return true;



            }
            else
            {
                return false;
            }
        }



        //delete method
        public bool RemoveContentFromList(string mealNumber)
        {
            MenuRepositoryClass content = GetContentByMealNumber(mealNumber);

            if( content == null)
            {
                return false;
            }
            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else 
            
            {
                return false;
            }
        }

        //Helper Method
        public MenuRepositoryClass GetContentByMealNumber(string mealNumber)
        {
            foreach(MenuRepositoryClass content in _listOfContent)
            {
                if (content.MealNumber == mealNumber)
                {
                    return content;
                }
            }
            return null;
        }   



}
}