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
      string breadUserInput = Console.ReadLine();
      int breadNumber;
      if (!int.TryParse(breadUserInput, out breadNumber))
      {
        Console.WriteLine("Please input all orders as numbers. Example: 1, 2, 3...");
        Console.WriteLine("Type enter to restart.");
        Console.ReadLine();
        Main();
      }

      Console.WriteLine("How many Pastries would you like? (Buy 2, get a 3rd half off)");
      string pastryUserInput = Console.ReadLine();
      int pastryNumber;
      if (!int.TryParse(pastryUserInput, out pastryNumber))
      {
        Console.WriteLine("Please input all orders as numbers. Example: 1, 2, 3...");
        Console.WriteLine("Type enter to restart.");
        Console.ReadLine();
        Main();
      }

      Bread breadOrder = new Bread(breadNumber);
      Pastry pastryOrder = new Pastry(pastryNumber);
      Console.WriteLine($"You want {breadOrder.NumberOfLoaves} loaves of bread and {pastryOrder.NumberOfPastries} pastries. That will cost: $" + (pastryOrder.PastryCost + breadOrder.BreadCost));
    }
  }
}