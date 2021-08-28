using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models

{
  public class Order
  {

    public int OrderID { get; set; }
    public Customer customer { get; set; }
    public Store store { get; set; }

    public List<Product> listofProducts { get; set; }

    public double finalPrice;

  }
}