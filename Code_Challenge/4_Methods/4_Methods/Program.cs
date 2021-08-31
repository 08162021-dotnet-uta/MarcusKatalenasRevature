using System;

namespace _4_MethodsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //1
      string name = GetName();
      GreetFriend(name);

      //2
      double result1 = GetNumber();
      double result2 = GetNumber();
      int action1 = GetAction();
      double result3 = DoAction(result1, result2, action1);

      System.Console.WriteLine($"The result of your mathematical operation is {result3}.");
    }

    public static string GetName()
    {
      String returnName = Console.ReadLine();
      return returnName;
    }

    public static string GreetFriend(string name)
    {
      return "Hello, " + name + ". You are my friend.";
    }

    public static double GetNumber()
    {
      String returnDouble = Console.ReadLine();

      double actualReturnDouble = Double.Parse(returnDouble);
      return actualReturnDouble;

    }

    public static int GetAction()
    {
      int action = Int32.Parse(Console.ReadLine());
      return action;

    }

    public static double DoAction(double x, double y, int action)
    {
      if (action == 1)
      {
        return x + y;
      }
      else if (action == 2)
      {
        return y - x;
      }
      else if (action == 3)
      {
        return x * y;
      }
      else if (action == 4)
      {
        return x / y;
      }
      else
      {
        throw new FormatException();
      }
    }
  }
}
