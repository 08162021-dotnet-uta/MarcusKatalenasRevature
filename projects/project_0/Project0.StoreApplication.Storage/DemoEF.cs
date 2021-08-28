
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage
{
  public class DemoEF
  {
        private readonly DataAdapter _da = new DataAdapter();

        public List<Customer> GetCustomers()
        {
          return _da.Customers.FromSqlRaw("select * from Customer.Customer;").ToList();
        }

        public List<Store> GetStore()
        {
            return _da.Customers.FromSqlRaw("select * from Store.Store;").ToList();
        }
        public List<Order> GetOrder()
        {
            return _da.Customers.FromSqlRaw("select * from Store.Order;").ToList();
        }
        public List<Product> GetProduct(int ID)
        {
            return _da.Customers.FromSqlRaw("select * from Store.Product where ProdcutID = {ID};").ToList();
        }
    }
}