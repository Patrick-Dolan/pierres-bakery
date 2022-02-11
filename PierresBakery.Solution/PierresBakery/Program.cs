using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("===========================");
      Console.WriteLine("How many loaves of bread would you like? (Buy 2, get 1 free)");
      Bread breadOrder = new Bread(Convert.ToInt32(Console.ReadLine()));
      Console.WriteLine("How many Pastries would you like? (Buy 2, get a 3rd half off)");
      Pastry pastryOrder = new Pastry(Convert.ToInt32(Console.ReadLine()));
      Console.WriteLine("So you want " + breadOrder.NumberOfLoaves + " loaves of bread and " + pastryOrder.NumberOfPastries + " pastries. That will cost you: $" + (pastryOrder.PastryCost + breadOrder.BreadCost));
    }
  }
}