using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// The orderRepository class to hold ways to store and retrive Order objects from files and a data storage
  /// </summary>
  public class OrderRepository : IRepo<Order>
  {
    public List<Order> Orders { get; }

    private const string _path = @"/home/marcus/revature/marcus_code/Data/project_0_Orders.xml";
  


    public static readonly FileAdapter _fileAdapter = new FileAdapter();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFile<Order>(_path) == null)
      {
        _fileAdapter.WriteFile<Order>(_path, new List<Order>()
        {
          // Will handle later or learn how to properly store this within the Data storage
        });
      }
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Order entry)
    {
      throw new System.NotImplementedException();
    }

    public List<Order> Select()
    {
      throw new System.NotImplementedException();
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}