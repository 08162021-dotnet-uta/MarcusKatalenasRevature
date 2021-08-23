using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.Storeapplicaton.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository
  {
    public List<Product> Products { get; set; }

    public ProductRepository()
    {

      Products = new List<Product>()
      {
        new GroceryStoreProduct(){ Name = "Apple", Price = 1.00},
        new AthleticStoreProducts(){ Name = "Glove",  Price = 8.00},
        new OnlineStoreProduct(){ Name = "USB Adapter",  Price = 10.00}
      };
    }
  }
}