using System;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Domain.Abstracts
{


  public abstract class Product
  {
    public int productID;
    public string Name { get; set; }

    public double Price { get; set; }

    public string storeTypeName { get; set; }

    public override string ToString()
    {
      return Name + " " + "$" + Price;
    }
  }
}