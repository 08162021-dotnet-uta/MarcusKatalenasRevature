using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository
  {
    public List<Product> Products { get; set; }

    public ProductRepository()
    {

      Products = new List<Product>()
      {
        new Product(){ Name = "Apple", Price = 1.00},
        new Product(){ Name = "Pizza",  Price = 8.00},
        new Product(){ Name = "Bacon",  Price = 10.00}
      };
    }
  }
}