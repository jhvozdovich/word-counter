using System;

namespace WordCounter.Models
{
  public class Entry
  {
    private string Word { get; set; }
    private string  Sentence { get; set; }
    public Entry (string word, string sentence)
    {
      Word = word.ToLower();
      Sentence = sentence.ToLower();
    }
    public int CountRepeats()
    {
      int count = 0;
      string[] sentenceArray = Sentence.Split(" ");
      foreach(string sentenceWord in sentenceArray)
      {
        string shortenedWord = "";
        if(sentenceWord.EndsWith("!") || sentenceWord.EndsWith(".") || sentenceWord.EndsWith("?") || sentenceWord.EndsWith("-")  || sentenceWord.EndsWith(",") || sentenceWord.EndsWith("/") || sentenceWord.EndsWith("%") || sentenceWord.EndsWith('"') || sentenceWord.EndsWith("'") || sentenceWord.EndsWith(")") || sentenceWord.EndsWith("(") || sentenceWord.EndsWith(":") || sentenceWord.EndsWith(";") )
        {
          shortenedWord = sentenceWord.Remove(sentenceWord.Length - 1);
          Console.WriteLine(shortenedWord);
        }
        if(Word == sentenceWord || Word == shortenedWord)
        {
          count += 1;
        }
      }
      return count;
    }
  }
}