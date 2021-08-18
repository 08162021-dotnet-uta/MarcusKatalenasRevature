using System;

namespace helloworld
{
  class Program
  {
    static public void add(int x, int y)
    {
      print(x + y);
    }
    static public void subtract(int x, int y)
    {
      print(x - y);
    }
    static public void mulitply(int x, int y)
    {
      print(x * y);
    }
    static public void divide(int x, int y)
    {
      print(x / y);
    }
    static public void print(int result)
    {
      Console.WriteLine("The answer is " + result);
    }
    //build a simple calculator using 6 methods add, mulit, sub, divide, print , 
    static void Main(string[] args)
    {
      int x, y;
      String operation;
      Console.WriteLine("Hello World!");
      Console.WriteLine("Welcome to Calculator program");

      Console.WriteLine("Enter the first number ");

      //Looked this up 
      x = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the second number ");

      y = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("The first number is " + x + " The Second number is " + y);

      Console.WriteLine("Enter Desire operation (Add, Sub, Mult, Divide)");

      operation = Console.ReadLine();

      if (operation == "Add")
      {
        Program.add(x, y);
      }
      else if (operation == "Sub")
      {
        Program.subtract(x, y);
      }
      else if (operation == "Mult")
      {
        Program.mulitply(x, y);
      }
      else if (operation == "Divide")
      {
        Program.divide(x, y);
      }
      else
      {
        Console.WriteLine("You messed up goodbye");
      }

      Environment.Exit(0);

    }
  }

}
