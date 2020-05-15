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
      if(Word == Sentence)
      {
        count += 1;
      }
      return count;
    }
  }
}