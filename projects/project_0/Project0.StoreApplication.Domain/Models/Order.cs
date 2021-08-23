using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models

{
  public class Order
  {
    public Customer customer { get; set; }
    public Store s { get; set; }

    public double price;

    //public List<Product> o { get; set; }

  }
}