using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11_ArraysAndListsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {

    }//EoM

    /// <summary>
    /// This method takes an array of integers and returns a double, the average 
    /// value of all the integers in the array
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static double AverageOfValues(int[] array)
    {
      return Math.Round((double)((double)array.Sum() / array.Length));
    }

    /// <summary>
    /// This method increases each array element by 2 and 
    /// returns an array with the altered values.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int[] SunIsShining(int[] x)
    {
      for (int i = 0; i < x.Length; i++)
      {
        x[i] += 2;
      }
      return x;
    }

    /// <summary>
    /// This method takes an ArrayList containing types of double, int, and string 
    /// and returns the average of the ints and doubles only, as a decimal.
    /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
    /// </summary>
    /// <param name="myArrayList"></param>
    /// <returns></returns>
    public static decimal ArrayListAvg(ArrayList myArrayList)
    {
      double sum = 0;
      int numCount = 0;
      foreach (var item in myArrayList)
      {
        if (item.GetType() == typeof(String))
        {

        }
        else
        {
          numCount++;
          if (item.GetType() == typeof(int))
            sum += (int)item;
          else
          {
            sum = ((double)item + sum);
          }
        }
      }
      decimal avg = (decimal)(sum / numCount);
      avg = Decimal.Round(avg, 3);
      return avg;
    }

    /// <summary>
    /// This method returns the rank (starting with 1st place) of a new 
    /// score entered into a list of randomly ordered scores.
    /// </summary>
    /// <param name="myArray1"></param>
    public static int ListAscendingOrder(List<int> scores, int yourScore)
    {
      scores.Sort();
      int place = 1;
      int currentPos = 0;
      int currentScore = scores[currentPos];

      while (yourScore > currentScore)
      {
        currentPos++;
        place++;
        currentScore = scores[currentPos];
      }
      return place;

    }

    /// <summary>
    /// This method has with two parameters takes a List<string> and a string.
    /// The method returns true if the string parameter is found in the List, otherwise false.
    /// </summary>
    /// <param name="myArray2"></param>
    /// <param name="word"></param>
    /// <returns></returns>
    public static bool FindStringInList(List<string> myArray2, string word)
    {
      return myArray2.Contains(word);
    }
  }//EoP
}// EoN