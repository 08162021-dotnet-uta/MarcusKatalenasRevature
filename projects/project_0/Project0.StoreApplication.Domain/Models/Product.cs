using System;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Domain.Abstracts
{


    public class Product
  {
    public int productID { get; set; }
    public string ProductName { get; set; }

    public int StoreID { get; set; }

    public double Price { get; set; }

  

    public override string ToString()
    {
      return ProductName + " " + "$" + Price;
    }
  }
}