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
    public void CalculateCost_ReturnCostOfTwoBread_Int()
    {
      int numberOfLoaves = 2;
      int cost = 10;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfFourBread_Int()
    {
      int numberOfLoaves = 4;
      int cost = 15;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfSixBread_Int()
    {
      int numberOfLoaves = 6;
      int cost = 20;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnCostOfSevenBread_Int()
    {
      int numberOfLoaves = 7;
      int cost = 25;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.CalculateCost();
      Assert.AreEqual(cost, result);
    }
    [TestMethod]
    public void GetBreadCost_ReturnBreadCost_Int()
    {
      int numberOfLoaves = 2;
      int breadCost = 10;
      Bread newBread = new Bread(numberOfLoaves);
      int result = newBread.BreadCost;
      Assert.AreEqual(breadCost, result);
    }
  }
}