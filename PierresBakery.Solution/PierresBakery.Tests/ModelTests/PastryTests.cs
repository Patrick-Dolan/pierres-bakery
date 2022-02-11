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
    [TestMethod]
    public void CalculateCost_ReturnCostOfThreePastries_int()
    {
      int numberOfPastries = 3;
      int cost = 5;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfFourPastries_int()
    {
      int numberOfPastries = 4;
      int cost = 7;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfFivePastries_int()
    {
      int numberOfPastries = 5;
      int cost = 9;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfSixPastries_int()
    {
      int numberOfPastries = 6;
      int cost = 10;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void GetPastryCost_ReturnPastryCost_Int()
    {
      int numberOfPastries = 2;
      int pastryCost = 4;
      Pastry newPastry = new Pastry(numberOfPastries);
      int result = newPastry.PastryCost;
      Assert.AreEqual(pastryCost, result);
    }
  }
}