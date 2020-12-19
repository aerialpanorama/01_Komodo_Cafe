using _01_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MenuTests
{
    [TestClass]
    public class MenuContentClassTests

    {
        private Menu _repo;
        private MenuRepositoryClass _content;

        [TestInitialize]
        public void Arrange()


        {

            _repo = new Menu();
            _content = new MenuRepositoryClass("1", "Jumbolaya", "A popular dish of West African, French, and Spanish influence", "consisting mainly of meat and vegetables mixed with rice.", 10.99, MealType.Dinner);

            _repo.AddContentToList(_content);

            



        }
        // Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //Arrange ---> setting up the playing field
            MenuRepositoryClass content = new MenuRepositoryClass();
            content.MealNumber = "1";
            Menu repository = new Menu();


            //Act
            repository.AddContentToList(content);
            MenuRepositoryClass contentFromDirectory = repository.GetContentByMealNumber("1");

           // Assert
            Assert.IsNotNull(contentFromDirectory);

        }

        //update
        [TestMethod]

        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            //TestInitialize

            MenuRepositoryClass = newContent = new MenuRepositoryClass("2", "Huevos Rancheros", "Eggs served in the style of the traditional large mid-morning fare on rural Mexican farms", "Black beans, feta cheese, corn tortillas, hot sauce, olive oil", 6.99, MealType.Breakfast);
            
            //Act

            bool updateResult = _repo.UpdateExistingContent(3)

        }
    }
}
