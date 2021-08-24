using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class CustomerRepository : IRepo<Customer>
  {
    public List<Customer> Customers { get; set; }

    List<Customer> IRepo<Customer>.Select => throw new NotImplementedException();

    private const string _path = @"/home/marcus/revature/marcus_code/data/customers.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public CustomerRepository()
    {
      if (_fileAdapter.ReadFile<Customer>(_path) == null)
      {
        _fileAdapter.WriteFile<Customer>(_path, new List<Customer>());
      }
    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Customer entry)
    {
      throw new System.NotImplementedException();
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Customer> Select()
    {
      return _fileAdapter.ReadFile<Customer>(_path);
      //throw new System.NotImplementedException();
    }


  }
}