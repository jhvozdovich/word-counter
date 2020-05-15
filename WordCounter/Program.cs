using System;
using WordCounter.Models;

namespace Program
{
  public class WordCounter
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the word counter!");
      Console.Write("Please enter a word to count: ");
      string userWord = Console.ReadLine();

      while (userWord == "")
      {
        Console.Write("Don't be shy! Please enter your word: ");
        userWord = Console.ReadLine();
      }

      Console.Write("Please enter your sentence to look through: ");
      string userSentence = Console.ReadLine();

      while (userSentence == "")
      {
        Console.Write("I'm sure you can think of a sentence to look through! Try again: ");
        userSentence = Console.ReadLine();
      }

      Entry userEntry = new Entry(userWord, userSentence);
      int count = userEntry.CountRepeats();
      Console.WriteLine("Calculating...");
      Console.WriteLine("There are " + count + " instances of the word " + userWord + " in your sentence.");
      Console.WriteLine("Have a nice day!");
    }
  }
}

