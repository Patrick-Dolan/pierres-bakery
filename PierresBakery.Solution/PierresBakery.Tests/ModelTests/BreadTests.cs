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