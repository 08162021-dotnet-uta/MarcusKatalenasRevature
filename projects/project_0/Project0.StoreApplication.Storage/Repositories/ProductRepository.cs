using System.Collections.Generic;

using Project0.StoreApplication.Domain.Interfaces;

using Project0.StoreApplication.Storage.Adapters;
using StoreWebApi;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository : IRepo<Product>
  {
    public List<Product> Products { get; }

    private const string _path = @"/home/marcus/revature/marcus_code/Data/project_0_Products.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();


    public ProductRepository()
    {
      if (_fileAdapter.ReadFile<Product>(_path) == null)
      {
        _fileAdapter.WriteFile<Product>(_path, new List<Product>()
        {

        });
      }
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Product entry)
    {
      throw new System.NotImplementedException();
    }

    public Product Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Product> Select()
    {
      return _fileAdapter.ReadFile<Product>(_path);
      //throw new System.NotImplementedException();
    }
  }
}