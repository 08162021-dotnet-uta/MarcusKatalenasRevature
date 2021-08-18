using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      //input stuff in C#
      var input1 = int.Parse(Console.ReadLine()); //type inference
      var input2 = int.Parse(Console.ReadLine());

      var result1 = Add(input1, input2);
      var result2 = Subtract(input1, input2);
      var result3 = mult(input1, input2);
      var result4 = divide(input1, input2);

      Print(result1, result2, result3, result4);
    }
    static int Add(int input1, int input2)
    {
      var compute = (int)input1 + (int)input2;
      return compute;
    }
    static int Subtract(int input1, int input2)
    {
      var compute = (int)input1 - (int)input2;
      return compute;
    }
    static int mult(int input1, int input2)
    {
      var compute = (int)input1 * (int)input2;
      return compute;
    }
    static int divide(int input1, int input2)
    {
      var compute = (int)input1 / (int)input2;
      return compute;
    }
    static void Print(params int[] results)
    {
      foreach (var item in results)
      {
        Console.WriteLine(item);
      }
    }
  }
}
