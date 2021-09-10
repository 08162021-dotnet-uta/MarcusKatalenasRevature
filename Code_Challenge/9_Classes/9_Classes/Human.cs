using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
      private string lastName = "Smyth";
      private string firstName = "Pat";

      public Human(string fName, string lName){
        lastName = lName;
        firstName = fName;
      }
      public Human(){

      }
      public string AboutMe(){
        return $"My name is {this.firstName} {this.lastName}.";
      }
    }//end of class
}//end of namespace