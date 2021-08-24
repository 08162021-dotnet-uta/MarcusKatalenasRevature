using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.SingleTons
{

  /// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {

    private static StoreSingleton _storeSingle;
    private static readonly StoreRepository _storeRepo = new StoreRepository();


    public List<Store> Stores { get; private set; }

    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingle == null)
        {
          _storeSingle = new StoreSingleton();

        }
        else
        {
          return _storeSingle;
        }
        return _storeSingle;
      }
    }

    private StoreSingleton()
    {
      Stores = _storeRepo.Select();
    }

    public void Add(Store store)
    {
      _storeRepo.Insert(store);
      Stores = _storeRepo.Select();
    }
  }
}