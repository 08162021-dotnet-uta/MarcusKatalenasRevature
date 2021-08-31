using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project0.StoreApplication.Domain.Models

{
  public class Order
  {

    public byte OrderID { get; set; }
    public byte CustomerID { get; set; }
    public byte StoreID { get; set; }

    public DateTime OrderDate { get; set; }
   
    [NotMapped]
    public double finalPrice;
    
     public Order()
        {

        }
    public Order(byte Cid, byte sID)
        {
            CustomerID = Cid;
            StoreID = sID;
        }

        public override string ToString()
        {
            return OrderID +  " " + CustomerID + " " + StoreID + " " + OrderDate;
        }

    }
}