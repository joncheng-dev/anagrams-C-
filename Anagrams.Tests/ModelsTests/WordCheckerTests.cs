using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;

namespace Anagrams.Tests
{
    [TestClass]
    public class WordCheckerTests
    {
        [TestMethod]
        public void SplitUserInputIntoWords_SplitUserInputIntoWords_Array()
        {
            string UserInput = "egg, cheese, bread";
            string[] UserInputArray = ["egg", "cheese", "bread"];
            
            Triangle newTriangle = new Triangle(length);
            
            string result =newTriangle.CheckType();
            // result = "equilateral triangle";

            WordChecker newUserInputtedString = new WordChecker();
            string result2 = newUserInputtedString.SplitUserInputIntoWords(UserInput);

            
        }
    }
}