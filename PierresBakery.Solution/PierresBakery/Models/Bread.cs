namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }

    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
    }
  }
}