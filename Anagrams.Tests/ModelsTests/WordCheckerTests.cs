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

        [TestMethod]
        public void CharArrayAlphabetizer_PutsCharArrayElementsInAlphaOrder_Array()
        {
            char[] unalphabetizedCharArray = {'b', 'e', 'a', 'r', 'd'};
            char[] alphabetizedCharArray = {'a', 'b', 'd', 'e', 'r'};
            char[] result = WordChecker.CharArrayAlphabetizer(unalphabetizedCharArray);
            CollectionAssert.AreEqual(alphabetizedCharArray, result);   
        }

        [TestMethod]
        public void CompareTargetWord_CompareTargetWordWithArrayElements_Bool()
        {
            char[] userCharArray = {'a', 'b', 'd', 'e', 'r'};
            char[] suspectedWord = {'c', 'e', 'e', 'e', 'h', 's'};
            bool comparison = WordChecker.CompareTargetWord(userCharArray, suspectedWord);
            Assert.AreEqual(comparison, false);
        }
        
        [TestMethod]
        public void CompareTargetWord_CompareTargetWordWithArrayElements_Bool()
        {
            char[] userCharArray = {'a', 'b', 'd', 'e', 'r'};
            char[] suspectedWord = {'a', 'b', 'd', 'e', 'r'};
            bool comparison = WordChecker.CompareTargetWord(userCharArray, suspectedWord);
            Assert.AreEqual(comparison, true);
        }

        [TestMethod]
        public void CheckForAnagram_CompareInitialWordWithUserArrayOfWords_Array()
        {
            string startingWord = "beard";
            string[] userListOfWords = "egg, bread, cheese";

            // Take user's starting word.. Ex: startingWord = "beard";

            // Take user's list of words to check for anagram. Ex: userList = "egg, bread, cheese"
            // Split this list into an array of strings. Ex: {"egg", "bread", "cheese"};
            string[] userList = SplitUserInputIntoWords(userListOfWords);
            // Split each word into characters.   -ib question-
            // Alphabetize characters or sort into alphabetical order.
            // Compare user's starting word -- also separated into characters, and alphabetized -- with EACH of the user's list words.
            // Return all words that are 'true' for anagram checker 
        }
        
    }
}
