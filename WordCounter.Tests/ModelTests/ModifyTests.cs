using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class ModifyInputTests
  {
    [TestMethod]
    public void Modify_RemoveAllNonAlphaCharacters_cat()
    {
      Modify newMod = new Modify("ca0t");
      string result = newMod.RemoveAllNonAlphaCharacters();
      Assert.AreEqual("cat", result);
    }
  }
}