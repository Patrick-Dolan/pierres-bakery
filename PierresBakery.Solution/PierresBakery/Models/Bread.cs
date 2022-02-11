using System;
namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }

    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
    }
    public int CalculateCost()
    {
      if (NumberOfLoaves >= 3)
      {
      int discountedLoaves = 0;
      discountedLoaves = (NumberOfLoaves - (NumberOfLoaves / 3));
      return discountedLoaves * 5;
      }
      else
      {
        return NumberOfLoaves * 5;
      }
    }
  }
}