using System;
using System.Xml.Serialization;
using Project0.Storeapplicaton.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(AthleticStore))]
  [XmlInclude(typeof(GroceryStore))]
  [XmlInclude(typeof(OnlineStore))]
  public abstract class Store
  {
    public string Name { get; set; }

    public string Location { get; set; }


    public override string ToString()
    {
      return Name + " " + Location;
    }

  }// end of class  
}