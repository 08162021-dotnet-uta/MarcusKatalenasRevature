using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Domain.Models
{


    public class Product
  {
    public byte ProductID { get; set; }
    public string ProductName { get; set; }

    public byte StoreID { get; set; }
   
    public double Price { get; set; }

    public override string ToString()
    {
      return ProductName + " " + "$" + Price;
    }
  }
}