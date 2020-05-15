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

    public string TrimSpecialCharacters()
    {
      // Would refactor with a-z regex, not permitted
      while (Word.EndsWith("!") || Word.EndsWith(".") || Word.EndsWith("?") || Word.EndsWith("-")  || Word.EndsWith(",") || Word.EndsWith("/") || Word.EndsWith("%") || Word.EndsWith('"') || Word.EndsWith("'") || Word.EndsWith(")") || Word.EndsWith("(") || Word.EndsWith(":") || Word.EndsWith(";") || Word.EndsWith("{") || Word.EndsWith("}") || Word.EndsWith("[") || Word.EndsWith("]") || Word.EndsWith("<") || Word.EndsWith(">") || Word.EndsWith("@") || Word.EndsWith("#") || Word.EndsWith("$") || Word.EndsWith("^") || Word.EndsWith("&") || Word.EndsWith("*"))
      {
        Word = Word.Remove(Word.Length - 1);
      }
      while (Word.StartsWith("!") || Word.StartsWith(".") || Word.StartsWith("?") || Word.StartsWith("-")  || Word.StartsWith(",") || Word.StartsWith("/") || Word.StartsWith("%") || Word.StartsWith('"') || Word.StartsWith("'") || Word.StartsWith(")") || Word.StartsWith("(") || Word.StartsWith(":") || Word.StartsWith(";") || Word.StartsWith("{") || Word.StartsWith("}") || Word.StartsWith("[") || Word.StartsWith("]") || Word.StartsWith("<") || Word.StartsWith(">") || Word.StartsWith("@") || Word.StartsWith("#") || Word.StartsWith("$") || Word.StartsWith("^") || Word.StartsWith("&") || Word.StartsWith("*"))
      {
        Word = Word.Substring(1);
      }
      return Word;
    }

    public bool ContainSpecialCharacters()
    {
      char[] letterArray = Word.ToCharArray();
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
  }
}