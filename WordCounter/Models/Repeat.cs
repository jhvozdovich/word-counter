namespace WordCounter.Models
{
  public class Entry
  {
    private string Word { get; set; }
    private string  Sentence { get; set; }
    public Entry (string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }
    public int CountRepeats()
    {
      return 0;
    }
  }
}