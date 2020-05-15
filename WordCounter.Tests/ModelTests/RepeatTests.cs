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
    [TestMethod]
    public void CountRepeats_SingleWordNonMatch_0()
    {
      Entry newEntry = new Entry("cat", "bat");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(0, count);
    }
    [TestMethod]
    public void CountRepeats_TwoWordMatch_2()
    {
      Entry newEntry = new Entry("cat", "cat cat");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(2, count);
    }
    [TestMethod]
    public void CountRepeats_TwoWordExcludeNonMatch_1()
    {
      Entry newEntry = new Entry("cat", "cat bat");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(1, count);
    }
    [TestMethod]
    public void CountRepeats_SentenceExcludeNonMatch_2()
    {
      Entry newEntry = new Entry("cat", "This cat named Zora is my favorite cat in the world!");
      int count = newEntry.CountRepeats();
      Assert.AreEqual(0, count);

    }
  }
}