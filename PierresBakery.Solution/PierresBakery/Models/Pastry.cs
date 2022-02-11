namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumberOfPastries { get; set; }
    public int PastryCost { get; set; }

    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
      PastryCost = this.CalculateCost();
    }
    public int CalculateCost()
    {
      if (NumberOfPastries >= 3)
      {
        int discountedPastries = NumberOfPastries / 3;
        int remainingPastries = NumberOfPastries - discountedPastries;
        return discountedPastries * 1 + remainingPastries * 2;
      }
      else 
      {
      return NumberOfPastries * 2;
      }
    }
  }
}