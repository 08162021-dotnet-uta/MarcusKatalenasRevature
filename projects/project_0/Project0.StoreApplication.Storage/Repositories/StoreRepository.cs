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

    private const string _path = @"/home/marcus/revature/marcus_code/Data/project_0.xml";

    private StoreRepository()
    {

      var fileadapt = new FileAdapter();

      fileadapt.WriteFile<Store>(new List<Store>()
        {
          new GroceryStore(),
          new OnlineStore(),
          new AthleticStore()
        }, _path);



      // if (fileadapt.ReadFile<Store>(_path) == null)
      // {
      //   fileadapt.WriteFile<Store>(new List<Store>()
      //   {
      //     new GroceryStore(),
      //     new OnlineStore(),
      //     new AthleticStore()
      //   }, _path);
      // }
      Stores = fileadapt.ReadFile<Store>(_path);
    }

    private static StoreRepository _storeRepo;

    public static StoreRepository Instance
    {
      get
      {
        if (_storeRepo == null)
        {
          _storeRepo = new StoreRepository();
        }
        return _storeRepo;
      }
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
