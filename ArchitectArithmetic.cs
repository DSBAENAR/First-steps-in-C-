using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
      }

    static double RectArea(double length, double width) {
      double area = length*width;
      return area;
      }
    static double CircArea(double radius) {
      double area = Math.PI*Math.Pow(radius,2);
      return area;
      }
    static double TriangleArea(double bottom, double height) {
      double area = height*bottom*0.5;
      return area;
      }
    static void CalculateTotalCost() {
      string input = InputMessage();
      double totalArea = TriangleArea(500,750)+ RectArea(1500,2500) + CircArea(375/2);
      double totalCost = totalArea * 180;
      OutputMessage(input,Math.Round(totalCost,2));
    }
    static string InputMessage() {
      Console.WriteLine("What monument would you like to work?");
      string inputmessage = Console.ReadLine();
      return inputmessage;
    }

    static void OutputMessage(string monument, double TotalCost) {
      Console.WriteLine($"The plan for {monument} costs {TotalCost} pesos!");
    }
  }
}
