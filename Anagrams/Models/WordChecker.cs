using System;

namespace Anagrams.Models
{
  public class WordChecker
  {
    // properties, constructors, methods, etc. go here
    public static string[] SplitUserInputIntoWords(string userInput)
    {
      string[] returnedFromMethod = userInput.Split(", ");
      // returnedFromMethod = userInput.Trim(" ");
      return returnedFromMethod; 
    }

    public static char[] SplitsWordsIntoArrayOfChars(string userInput)
    {
      char[] expectedChars = userInput.ToCharArray();
      return expectedChars;
    }
    
    public static char[] CharArrayAlphabetizer (char[] charArray)
    {
      Array.Sort<char>(charArray);
      return charArray;
    }
  }
}