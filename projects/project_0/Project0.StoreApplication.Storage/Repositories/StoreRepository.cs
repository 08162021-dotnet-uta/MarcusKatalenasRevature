using System;
using System.Collections.Generic;

using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;


namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository : IRepo<Store>
  {
    public List<Store> Stores { get; set; }

    private const string _path = @"/home/marcus/revature/marcus_code/Data/project_0.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public StoreRepository()
    {
      if (_fileAdapter.ReadFile<Store>(_path) == null)
      {
        _fileAdapter.WriteFile<Store>(_path, new List<Store>()
        {

        });
      }
    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Store entry)
    {
      throw new System.NotImplementedException();
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Store> Select()
    {
      return _fileAdapter.ReadFile<Store>(_path);
      //throw new System.NotImplementedException();
    }
  }
}