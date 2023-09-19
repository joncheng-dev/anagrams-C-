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
            string[] UserInputArray = {"egg", "cheese", "bread"};
            string[] resultOfMethodCall = WordChecker.SplitUserInputIntoWords();
            Assert.AreEqual(resultOfMethodCall.GetType(), UserInputArray.GetType());
        }
    }
}