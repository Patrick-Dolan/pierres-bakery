using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_DeclarePastryObjectWithNumberOfPastries_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetNumberOfPastries_ReturnNumberOfPastries_Int()
    {
      int numberOfPastries = 2;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.NumberOfPastries;
      Assert.AreEqual(numberOfPastries, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfOnePastry_int()
    {
      int numberOfPastries = 1;
      int cost = 2;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.CalculateCost();
      Assert.AreEqual(cost, result);
    }
  }
}