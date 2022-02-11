namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public int BreadCost { get; set; }

    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
      BreadCost = this.CalculateCost();
    }
    public int CalculateCost()
    {
      if (NumberOfLoaves >= 3)
      {
      int discountedLoaves = (NumberOfLoaves - (NumberOfLoaves / 3));
      return discountedLoaves * 5;
      }
      else
      {
        return NumberOfLoaves * 5;
      }
    }
  }
}