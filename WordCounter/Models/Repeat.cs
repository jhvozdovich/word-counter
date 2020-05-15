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
      for(int i = 0; i < sentenceArray.Length; i++)
      {
        if(ContainSpecialCharacters(Word) == false)
        {
        sentenceArray[i] = TrimSpecialCharacters(sentenceArray[i]);
        }
        if (Word == sentenceArray[i] || Word == sentenceArray[i])
        {
          count += 1;
        }
      }
      return count;
    }

    public bool ContainSpecialCharacters(string word)
    {
      if(word.Contains("!") || word.Contains(".") || word.Contains("?") || word.Contains("-")  || word.Contains(",") || word.Contains("/") || word.Contains("%") || word.Contains('"') || word.Contains("'") || word.Contains(")") || word.Contains("(") || word.Contains(":") || word.Contains(";") || word.Contains("{") || word.Contains("}") || word.Contains("[") || word.Contains("]") || word.Contains("<") || word.Contains(">"))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string TrimSpecialCharacters(string word)
    {
      // Would refactor with a-z regex, not permitted
      while (word.EndsWith("!") || word.EndsWith(".") || word.EndsWith("?") || word.EndsWith("-")  || word.EndsWith(",") || word.EndsWith("/") || word.EndsWith("%") || word.EndsWith('"') || word.EndsWith("'") || word.EndsWith(")") || word.EndsWith("(") || word.EndsWith(":") || word.EndsWith(";") || word.EndsWith("{") || word.EndsWith("}") || word.EndsWith("[") || word.EndsWith("]") || word.EndsWith("<") || word.EndsWith(">"))
      {
        word = word.Remove(word.Length - 1);
      }
      while (word.StartsWith("!") || word.StartsWith(".") || word.StartsWith("?") || word.StartsWith("-")  || word.StartsWith(",") || word.StartsWith("/") || word.StartsWith("%") || word.StartsWith('"') || word.StartsWith("'") || word.StartsWith(")") || word.StartsWith("(") || word.StartsWith(":") || word.StartsWith(";") || word.StartsWith("{") || word.StartsWith("}") || word.StartsWith("[") || word.StartsWith("]") || word.StartsWith("<") || word.StartsWith(">"))
      {
        word = word.Substring(1);
      }
      return word;
    }
  }
}