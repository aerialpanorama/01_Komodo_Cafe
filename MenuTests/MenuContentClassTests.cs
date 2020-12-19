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
            //TestInitialize - Already have

            MenuRepositoryClass newContent = new MenuRepositoryClass("2", "Huevos Rancheros", "Eggs served in the style of the traditional large mid-morning fare on rural Mexican farms", "Black beans, feta cheese, corn tortillas, spicy sauce, olive oil", 7.99, MealType.Breakfast);

            //Act

            bool updateResult = _repo.UpdateExistingContent("2", newContent);

            // Assert
            Assert.IsTrue(updateResult);


        }

        [TestMethod]
        [DataRow("2", true)]
        [DataRow("1", false)]

        public void UpdateExistingContent_ShouldMatchGivenbool(string originalMealNumber, bool shouldUpdate)
        {

            //Arrange
            //TestInitialize - Already have

            MenuRepositoryClass newContent = new MenuRepositoryClass("2", "Huevos Rancheros", "Eggs served in the style of the traditional large mid-morning fare on rural Mexican farms", "Black beans, feta cheese, corn tortillas, spicy sauce, olive oil", 7.99, MealType.Breakfast);

            //Act

            bool updateResult = _repo.UpdateExistingContent("2", newContent);

            // Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]

        public void DeleteContent_ShouldReturnTrue()
        { 

            //arrange

        //act

        bool deleteResult = _repo.RemoveContentFromList(_content.MealNumber);

        //assert
        Assert.IsTrue(deleteResult);
            }
    }
}
