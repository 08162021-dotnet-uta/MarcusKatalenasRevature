using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; set; }

    public StoreRepository()
    {

      Stores = new List<Store>()
      {
        new Store(){ Name = "Store1", Location = "Char"},
        new Store(){ Name = "Store2",  Location = "NY"},
        new Store(){ Name = "Store3",  Location = "BOS"}
      };
    }
  }
}
