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
        // Would refactor with a-z regex, not permitted
        while (sentenceArray[i].EndsWith("!") || sentenceArray[i].EndsWith(".") || sentenceArray[i].EndsWith("?") || sentenceArray[i].EndsWith("-")  || sentenceArray[i].EndsWith(",") || sentenceArray[i].EndsWith("/") || sentenceArray[i].EndsWith("%") || sentenceArray[i].EndsWith('"') || sentenceArray[i].EndsWith("'") || sentenceArray[i].EndsWith(")") || sentenceArray[i].EndsWith("(") || sentenceArray[i].EndsWith(":") || sentenceArray[i].EndsWith(";") || sentenceArray[i].EndsWith("{") || sentenceArray[i].EndsWith("}") || sentenceArray[i].EndsWith("[") || sentenceArray[i].EndsWith("]") || sentenceArray[i].EndsWith("<") || sentenceArray[i].EndsWith(">"))
        {
          sentenceArray[i] = sentenceArray[i].Remove(sentenceArray[i].Length - 1);
        }
        while (sentenceArray[i].StartsWith("!") || sentenceArray[i].StartsWith(".") || sentenceArray[i].StartsWith("?") || sentenceArray[i].StartsWith("-")  || sentenceArray[i].StartsWith(",") || sentenceArray[i].StartsWith("/") || sentenceArray[i].StartsWith("%") || sentenceArray[i].StartsWith('"') || sentenceArray[i].StartsWith("'") || sentenceArray[i].StartsWith(")") || sentenceArray[i].StartsWith("(") || sentenceArray[i].StartsWith(":") || sentenceArray[i].StartsWith(";") || sentenceArray[i].StartsWith("{") || sentenceArray[i].StartsWith("}") || sentenceArray[i].StartsWith("[") || sentenceArray[i].StartsWith("]") || sentenceArray[i].StartsWith("<") || sentenceArray[i].StartsWith(">"))
        {
          sentenceArray[i] = sentenceArray[i].Substring(1);
        }
        if (Word == sentenceArray[i] || Word == sentenceArray[i])
        {
          count += 1;
        }
      }
      return count;
    }
  }
}