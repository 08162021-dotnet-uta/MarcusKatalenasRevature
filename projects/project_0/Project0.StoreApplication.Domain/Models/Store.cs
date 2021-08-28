using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Domain.Abstracts
{

 
  public abstract class Store
  {
    public int storeID;
    public string Name { get; set; }

    public string Location { get; set; }

    public List<Product> listOfProudcts = new List<Product>();


    public override string ToString()
    {
      return Name + " " + Location;
    }

  }// end of class  
}