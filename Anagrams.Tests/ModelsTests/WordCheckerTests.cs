using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;

namespace Anagrams.Tests
{
    [TestClass]
    public class WordCheckerTests
    {
        [TestMethod]
        public void SplitUserInputIntoWords_ReturnsArrayFromMethod_Array()
        {
            string[] userInputArray = {"egg","cheese","bread"};
            string[] resultOfMethodCall = WordChecker.SplitUserInputIntoWords("string");
            Assert.AreEqual(resultOfMethodCall.GetType(), userInputArray.GetType());
        }

        [TestMethod]
        public void SplitUserInputIntoWords_SplitUserInputIntoArrOfWords_Array()
        {
            string userInput = "egg, cheese, bread";
            string[] returnedFromMethod = WordChecker.SplitUserInputIntoWords(userInput);
            string[] expectedResult = {"egg","cheese","bread"};
            CollectionAssert.AreEqual(returnedFromMethod, expectedResult);
        }

        [TestMethod]
        public void SplitsWordsIntoArrayOfChars_SplitsWordsIntoArrayOfChars_Array()
        {
            string userInputSingleWord = "beard";
            char[] stringToChar = WordChecker.SplitsWordsIntoArrayOfChars(userInputSingleWord);
            char[] expectedChars = {'b', 'e', 'a', 'r', 'd'};
            CollectionAssert.AreEqual(stringToChar, expectedChars);
        }
    }
}
