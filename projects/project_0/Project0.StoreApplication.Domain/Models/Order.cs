using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project0.StoreApplication.Domain.Models

{
  public class Order
  {

    public int OrderID { get; set; }
    public Customer customer { get; set; }
    public Store store { get; set; }
   
     [NotMapped]
    public double finalPrice;

  }
}