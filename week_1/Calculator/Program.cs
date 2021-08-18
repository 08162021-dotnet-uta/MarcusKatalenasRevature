using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      //input stuff in C#
      var inputs = Input();

      var result1 = Add(inputs[0], inputs[1]);
      var result2 = Subtract(inputs[0], inputs[1]);
      var result3 = mult(inputs[0], inputs[1]);
      var result4 = divide(inputs[0], inputs[1]);

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
    static int[] Input()
    {
      //input stuff

      try
      {
        var input1 = int.Parse(Console.ReadLine()); //type inference
        var input2 = int.Parse(Console.ReadLine());
        return new int[] { input1, input2 };
      }
      catch (Exception e)
      {
        throw e; //points to the origin cause of the error
        //throw new Exception("hue"); // generates an entire new error
      }
      finally
      {

      }

    }
  }
}
