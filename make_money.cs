using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.Write("Input your amount ");
      string amountString = Console.ReadLine();
      double amountUser = Convert.ToDouble(amountString);
      Console.WriteLine( amountUser + " is equal to.. ");
      Console.WriteLine("if you typed a decimal, i'll round it down to the nearest whole cent");
      double goldCoin = Math.Floor(amountUser/10);
      double remainder = amountUser % 10 ;
      double silverCoin = Math.Floor(remainder/5);
      remainder = remainder % 5 ;
      double bronzeCoin = Math.Floor(remainder);
      Console.WriteLine("Gold Coins: " + goldCoin);
      Console.WriteLine("Silver Coins: " + silverCoin );
      Console.WriteLine("Bronze Coins: " + bronzeCoin);
    }
  }
}
