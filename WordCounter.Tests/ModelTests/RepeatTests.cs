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
    [TestMethod]
    public void CountRepeats_SingleCharacterCapitalization_1()
    {
      Entry newEntry = new Entry("a", "A");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(1, count);
    }
    [TestMethod]
    public void CountRepeats_SingleCharacterNonMatch_0()
    {
      Entry newEntry = new Entry("a", "b");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(0, count);
    }
    [TestMethod]
    public void CountRepeats_SingleWordMatch_1()
    {
      Entry newEntry = new Entry("cat", "cat");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(1, count);
    }
    [TestMethod]
    public void CountRepeats_SingleWordCapitalization_1()
    {
      Entry newEntry = new Entry("cat", "Cat");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(1, count);
    }
  }
}