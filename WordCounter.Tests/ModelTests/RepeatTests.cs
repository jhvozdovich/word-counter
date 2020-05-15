using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void CountRepeats_SingleCharacterMatch_1()
    {
      Entry newEntry = new Entry("a", "a");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(1, count);
    }
  }
}