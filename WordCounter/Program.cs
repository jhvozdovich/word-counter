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
     public static void TypeLineFast(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(10);
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
      EndCat();
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

      if (count == 1)
      {
      TypeLine("There is " + count + " instance of the word " + userWord + " in your sentence.");
      }
      else
      {
      TypeLine("There are " + count + " instances of the word " + userWord + " in your sentence.");
      }
    }
    static string ValidateWord(string word)
    {
      Modify modifyWord = new Modify(word);
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

      if(modifyWord.ContainSpecialCharacters())
      {
        TypeLine("Your word contains special characters. Are you sure you would like to proceed? Y/N");
        tryCharacterAgain:
        string continueCharacterQuestion = Console.ReadLine().ToLower();
        if (continueCharacterQuestion == "y" || continueCharacterQuestion == "yes")
        {
          TypeLine("Would you like to remove all non alphabetical characters?");
          tryRemoveAgain:
          string continueRemoveQuestion = Console.ReadLine().ToLower();
          if (continueRemoveQuestion == "y" || continueRemoveQuestion == "yes")
          {
            word = modifyWord.RemoveAllNonAlphaCharacters();
          }
          else if(continueRemoveQuestion != "n" && continueRemoveQuestion != "no")
          {
            TypeLine("Sorry I didn't catch that. Would you like to remove all non alphabetical characters from your word? Y/N");
            goto tryRemoveAgain;
          }
          else
          {
            TypeLine("Would you like to trim punctuation from the start and end of your word?");
            tryTrimAgain:
            string continueTrimQuestion = Console.ReadLine().ToLower();
            if (continueTrimQuestion == "y" || continueTrimQuestion == "yes")
            {
              word = modifyWord.TrimSpecialCharacters();
            }
            else if (continueTrimQuestion != "n" && continueTrimQuestion != "no")
            {
              TypeLine("Sorry I didn't catch that. Would you like to remove the punctuation at the beginning and end of your word? Y/N");
              goto tryTrimAgain;
            }
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
    static void EndCat()
    {
      TypeLineFast(@"
          /\_____/\
         /  o   o  \
        ( ==  w  == )
         )         (
        (           )
       ( (  )   (  ) )
      (__(__)___(__)__)");
    }
  }
}

