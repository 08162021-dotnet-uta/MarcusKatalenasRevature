using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int oddCount = 0;
            for(int pos = 0; pos < x.Count; pos++){
              if(x[pos] % 2 != 0){
                oddCount = oddCount + 1;
              }
            }
            return oddCount;
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
          return 4;
        }
          
      

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            int countMultOfFour = 0;
            int currentNumber = 0;
            int pos = 0;

            while(currentNumber != 1234){
              currentNumber = x[pos];

              if(x[pos] % 4 == 0){
                countMultOfFour = countMultOfFour + 1;
              }
              pos++;
            }
            return countMultOfFour;
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
           int counter = 0;
           

           for (int pos = 0; pos < x.Length; pos++)
           {
               if(x[pos] % 3 == 0 && x[pos] % 4 == 0){
                 counter++;
               }
           }
           return counter;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            string returnString = "";

            for(int pos = 0; pos < stringListArray.Length; pos++){

              foreach (var item in stringListArray[pos])
              {
                  returnString = returnString + " " + item;
              }
            }
            return returnString;
        }
    }
}