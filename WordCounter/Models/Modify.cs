using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Modify
  {
    private string Word { get; set; }
    public Modify (string word)
    {
      Word = word.ToLower();
    }

    public string RemoveAllNonAlphaCharacters()
    {
      List<char> removed = new List<char> {};
      for (int i = 0; i < Word.Length; i++)
      {
        if(Word[i] >= 'A' && Word[i] <= 'z')
        {
          removed.Add(Word[i]);
        }
      }
      string removedString = string.Join("", removed.ToArray());
      return removedString;
    }
  }
}