using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_DeclareBreadObjectWithNumberOfLoafs_Bread()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetNumberOfLoaves_ReturnNumberOfLoaves_Int()
    {
      int numberOfLoaves = 2;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.NumberOfLoaves;
      Assert.AreEqual(numberOfLoaves, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfTwoBread_Bread()
    {
      int numberOfLoaves = 2;
      int cost = 10;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.CalculateCost();
      Assert.AreEqual(cost, result);
    }
  }
}
// Example Test Method Structure
//_________________________
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }