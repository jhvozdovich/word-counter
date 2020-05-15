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
    [TestMethod]
    public void Modify_TrimSpecialCharacters_cat()
    {
      Modify newMod = new Modify("cat!");
      string result = newMod.TrimSpecialCharacters();
      Assert.AreEqual("cat", result);
    }
    public void Modify_ContainSpecialCharacters_true()
    {
      Modify newMod = new Modify("cat!");
      bool result = newMod.ContainSpecialCharacters();
      Assert.AreEqual(true, result);
    }
  }
}