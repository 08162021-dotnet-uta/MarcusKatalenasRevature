using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
  public class Program
  {
    enum Vehicle { Car, Bus, Truck, Motobike };
    public static void Main(string[] args)
    {
      Console.WriteLine("The enumeration...");
      foreach (string v in Enum.GetNames(typeof(Vehicle)))
      {
        Console.WriteLine("{0} = {1:D}", v, Enum.Parse(typeof(Vehicle), v));
      }
      Console.WriteLine();
    }

    /// <summary>
    /// This method returns a randomly chosen number between 0 and 100, inclusive.
    /// </summary>
    /// <returns></returns>
    public static int GetRandomNumber()
    {
      var rand = new Random();
      return rand.Next(101);
    }

    /// <summary>
    /// This method gets input from the user, 
    /// verifies that the input is valid and 
    /// returns an int.
    /// </summary>
    /// <returns></returns>
    public static int GetUsersGuess()
    {
      int outPut;

      Console.WriteLine("Please enter number from 0 -100");

      String userInput = Console.ReadLine();

      int.TryParse(userInput, out outPut);

      return outPut;

    }

    /// <summary>
    /// This method will has two int parameters.
    /// It will:
    /// 1) compare the first number to the second number
    /// 2) return -1 if the first number is less than the second number
    /// 3) return 0 if the numbers are equal
    /// 4) return 1 if the first number is greater than the second number
    /// </summary>
    /// <param name="randomNum"></param>
    /// <param name="guess"></param>
    /// <returns></returns>
    public static int CompareNums(int randomNum, int guess)
    {
      if (guess == randomNum)
      {
        return 0;
      }
      else if (randomNum < guess)
      {
        return -1;

      }
      else
      {
        return 1;
      }
    }

    public static bool PlayGameAgain()
    {
      throw new NotImplementedException();
    }
  }
}
