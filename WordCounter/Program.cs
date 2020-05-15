using System;
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

      while (userWord == "")
      {
        TypeLine("Don't be shy! Please enter your word: ");
        userWord = Console.ReadLine();
      }

      TypeLine("Please enter your sentence to look through: ");
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
  }
}

