using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace Program
{
  public class WordCounter
  {
    public static void TypeLine(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(40);
      }
      Console.WriteLine();
    }
    public static void TypeLineSlow(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(100);
      }
      Console.WriteLine();
    }
    static void Main()
    {
      TypeLine("Welcome to the word counter!");
      StartWordCounter();
      TypeLine("Would you like to count another word? Y/N");
      tryagain:
      string continueQuestion = Console.ReadLine().ToLower();
      while (continueQuestion == "y" || continueQuestion == "yes")
      {
        StartWordCounter();
        TypeLine("Would you like to count another word? Y/N");
        continueQuestion = Console.ReadLine().ToLower();
      }
      while (continueQuestion != "n" && continueQuestion != "no")
      {
          TypeLine("Sorry, I didn't catch that! Would you like to count another word? Y/N");
          goto tryagain;
      }
      TypeLine("Have a nice day!");
    }

    static void StartWordCounter()
    {
      TypeLine("Please enter a word to count: ");
      string userWord = Console.ReadLine();

      userWord = ValidateWord(userWord);

      TypeLine("Now enter your sentence to look through: ");
      string userSentence = Console.ReadLine();

      while (userSentence == "")
      {
        TypeLine("I'm sure you can think of a sentence to look through! Try again: ");
        userSentence = Console.ReadLine();
      }

      Entry userEntry = new Entry(userWord, userSentence);
      int count = userEntry.CountRepeats();
      TypeLineSlow("Calculating...");
      TypeLine("There are " + count + " instances of the word " + userWord + " in your sentence.");
    }

    static string ValidateWord(string word)
    {
      tryagain:

      while (word == "")
      {
        TypeLine("Don't be shy! Please enter your word: ");
        word = Console.ReadLine();
        goto tryagain;
      }

      while(word.Contains(" "))
      {
        TypeLine("Please enter a valid word with no spaces: ");
        word = Console.ReadLine();
        goto tryagain;
      }

      word = RemoveAllNonAlphaCharacters(word);

      if(ContainSpecialCharacters(word))
      {
        TypeLine("Your word contains special characters. Are you sure you would like to proceed? Y/N");
        tryCharacterAgain:
        string continueCharacterQuestion = Console.ReadLine().ToLower();
        if (continueCharacterQuestion == "y" || continueCharacterQuestion == "yes")
        {
          TypeLine("Would you like to remove punctuation?");
          tryTrimAgain:
          string continueTrimQuestion = Console.ReadLine().ToLower();
          if (continueTrimQuestion == "y" || continueTrimQuestion == "yes")
          {
            word = TrimSpecialCharacters(word);
          }
          else if (continueTrimQuestion != "n" && continueTrimQuestion != "no")
          {
            TypeLine("Sorry I didn't catch that. Would you like to remove the punctuation at the beginning and end of your word? Y/N");
            goto tryTrimAgain;
          }
        }
        else if (continueCharacterQuestion == "n" || continueCharacterQuestion == "no")
        {
          TypeLine("Please enter a new word: ");
          word = Console.ReadLine();
          goto tryagain;
        }
        else
        {
          TypeLine("Sorry, I didn't catch that! Are you sure you would like to proceed with special characters? Y/N");
          goto tryCharacterAgain;
        }
      }
      return word;
    }

    public static bool ContainSpecialCharacters(string word)
    {
      char[] letterArray = word.ToCharArray();
      bool specialCharacterStatus = false;
      for (int i = 0; i < letterArray.Length; i++)
      {
        if(Char.IsLetter(letterArray[i]))
        {
          specialCharacterStatus = true;
        }
      }
      return specialCharacterStatus;
    }
    public static string TrimSpecialCharacters(string word)
    {
      // Would refactor with a-z regex, not permitted
      while (word.EndsWith("!") || word.EndsWith(".") || word.EndsWith("?") || word.EndsWith("-")  || word.EndsWith(",") || word.EndsWith("/") || word.EndsWith("%") || word.EndsWith('"') || word.EndsWith("'") || word.EndsWith(")") || word.EndsWith("(") || word.EndsWith(":") || word.EndsWith(";") || word.EndsWith("{") || word.EndsWith("}") || word.EndsWith("[") || word.EndsWith("]") || word.EndsWith("<") || word.EndsWith(">") || word.EndsWith("@") || word.EndsWith("#") || word.EndsWith("$") || word.EndsWith("^") || word.EndsWith("&") || word.EndsWith("*"))
      {
        word = word.Remove(word.Length - 1);
      }
      while (word.StartsWith("!") || word.StartsWith(".") || word.StartsWith("?") || word.StartsWith("-")  || word.StartsWith(",") || word.StartsWith("/") || word.StartsWith("%") || word.StartsWith('"') || word.StartsWith("'") || word.StartsWith(")") || word.StartsWith("(") || word.StartsWith(":") || word.StartsWith(";") || word.StartsWith("{") || word.StartsWith("}") || word.StartsWith("[") || word.StartsWith("]") || word.StartsWith("<") || word.StartsWith(">") || word.StartsWith("@") || word.StartsWith("#") || word.StartsWith("$") || word.StartsWith("^") || word.StartsWith("&") || word.StartsWith("*"))
      {
        word = word.Substring(1);
      }
      return word;
    }

    public static string RemoveAllNonAlphaCharacters(string word)
    {
      List<char> removed = new List<char> {};
      for (int i = 0; i < word.Length; i++)
      {
        if(word[i] >= 'A' && word[i] <= 'z')
        {
          removed.Add(word[i]);
        }
      }
      string removedString = string.Join("", removed.ToArray());
      return removedString;
    }
  }
}

