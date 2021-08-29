using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Domain.Models
{

 
  public class Store
  {
    public byte storeID { get; set; }
    public string storeName { get; set; }
    public override string ToString()
    {
            return storeName;
    }

  }// end of class  
}