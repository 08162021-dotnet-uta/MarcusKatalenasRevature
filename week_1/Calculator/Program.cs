using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      //input stuff in C#
      var input1 = Console.ReadLine(); //type inference
      var input2 = Console.ReadLine();

      //compute
      var compute = input1 + input2;

      //output
      Console.WriteLine(compute);
    }
  }
}
