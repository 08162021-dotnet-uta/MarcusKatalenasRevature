using System;

namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {
    public string Name { get; set; }

    public string Location {get; , set;}

    public override string ToString()
    {
      return Name;
    }

  }// end of class
}