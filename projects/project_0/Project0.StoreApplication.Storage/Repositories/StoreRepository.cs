using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.Storeapplicaton.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; }

    public StoreRepository()
    {

      var fileadapt = new FileAdapter();

      if (fileadapt.ReadFile() == null)
      {
        fileadapt.WriteFile(new List<Store>()
        {
          new GroceryStore(),
          new OnlineStore(),
          new AthleticStore()
        });
      }

      Stores = fileadapt.ReadFile();
    }
    public Store GetStore(int index)
    {
      try
      {
        return Stores[index];
      }
      catch
      {
        return null;
      }
    }
  }
}
