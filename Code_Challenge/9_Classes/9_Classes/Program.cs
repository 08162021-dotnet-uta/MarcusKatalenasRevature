using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Human firstHuman = new Human();

          Human secondHuman = new Human("Dick", "Butkus");

          Console.WriteLine(firstHuman.AboutMe());
          Console.WriteLine(secondHuman.AboutMe());

          Human2 firstHuman2 = new Human2("FName", "Lname", "Blue");
          Human2 secondHuman2 = new Human2("Pat", "Mcgee", 22);
          Human2 thirdHuman2 = new Human2("Marcus", "Katalenas", "Brown", 27);
          thirdHuman2.Weight = 30;

          Console.WriteLine(firstHuman2.AboutMe2());
          Console.WriteLine(secondHuman2.AboutMe2());
          Console.WriteLine(thirdHuman2.AboutMe2());
        }
    }
}
