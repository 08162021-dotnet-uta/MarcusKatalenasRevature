using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class CustomerRepository : IRepo<Customer>
  {
    public List<Customer> Customers { get; set; }

        private readonly DataAdapter _da = new DataAdapter();

       private const string _path = @"/home/marcus/revature/marcus_code/Data/customers.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    /// <summary>
    /// 
    /// </summary>
    public CustomerRepository()
    {
            /*
      if (_fileAdapter.ReadFile<Customer>(_path) == null)
      {
        _fileAdapter.WriteFile<Customer>(_path, new List<Customer>(){

          new Customer("Marcus"),
          new Customer("Luke"),
          new Customer("John")
        });
      }
            */
    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Customer entry)
        {
            try
            {
                // String sqlStatment = $"Execute dbo.SP_AddCustomer @name = '{entry.Name}'";
                // Console.WriteLine(sqlStatment);
                _da.Customers.FromSqlInterpolated($"Execute dbo.SP_AddCustomer @name = '{entry.Name};'");
                return true;
            }
            catch(SqlException E)
            {
                Console.WriteLine("Error Generated. Details: " + E.ToString());
            }
            finally
            {
                
            }
            return false;
           
        }

     public Customer Update()
    {
      throw new System.NotImplementedException();
    }
    public List<Customer> Select()
    {
      return _fileAdapter.ReadFile<Customer>(_path);
    }


  }
}