using System;
using System.Xml.Serialization;
using Project0.Storeapplicaton.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{

  [XmlInclude(typeof(AthleticStoreProduct))]
  [XmlInclude(typeof(GroceryStoreProduct))]
  [XmlInclude(typeof(OnlineStoreProduct))]

  public abstract class Product
  {
    public string Name { get; set; }

    public double Price { get; set; }

    public string storeTypeName { get; set; }

    public override string ToString()
    {
      return Name + " " + "$" + Price;
    }
  }
}