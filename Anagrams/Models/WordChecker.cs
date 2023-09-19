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

    
  }
}