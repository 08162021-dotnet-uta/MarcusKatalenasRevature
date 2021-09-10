using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human2
    {
      //Fields
      private string lastName = "Smyth";
      private string firstName = "Pat";
      private string eyeColor;
      private int age;
      private int weight;
    

      public int Weight { 
        get{
          return weight;
          } 
        set{
            if(value < 0 || value > 400){
            weight = 0;
            }
            else{
              weight = value;
            }
          } 
        } 
          

      public Human2(string fName, string lName, string eColor, int a){
        lastName = lName;
        firstName = fName;
        eyeColor = eColor;
        age = a;

      }
      public Human2(string fName, string lname, int a){
        lastName = lname;
        firstName = fName;
        age = a;
      }
      public Human2(string fname, string lname, string eColor){
        lastName = lname;
        firstName = fname;
        eyeColor = eColor;
      }
      public Human2(){

      }
      public string AboutMe(){
         return $"My name is {this.firstName} {this.lastName}.";
      }
      public string AboutMe2(){
        if(eyeColor == null && age == 0){
          return $"My name is {this.firstName} {this.lastName}.";
        }
        else if(eyeColor == null){
          return $"My name is {this.firstName} {this.lastName}. My age is {this.age}.";
        }
        else if(age == 0){
          return $"My name is {this.firstName} {this.lastName}. My eye color is {this.eyeColor}.";
        }
        else{
           return $"My name is {this.firstName} {this.lastName}. My age is {this.age}. My eye color is {this.eyeColor}.";
        }
       
      }
    }
}