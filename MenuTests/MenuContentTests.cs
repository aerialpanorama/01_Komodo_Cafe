using _01_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MenuTests
{
    [TestClass]
    public class MenuContentTests
    {
        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectString()
        {
            MenuRepositoryClass content = new MenuRepositoryClass();

            content.MealNumber = "1";

            string expected = "1";
            String actual = content.MealNumber;

            Assert.AreEqual(expected, actual);
        }
    }
}
