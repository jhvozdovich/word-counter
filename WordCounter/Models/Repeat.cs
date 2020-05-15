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
        if(Word == sentenceWord)
        {
          count += 1;
        }
      }
      return count;
    }
  }
}