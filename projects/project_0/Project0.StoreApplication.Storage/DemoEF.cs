
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

        public List<Store> GetStores()
        {
            return _da.Stores.FromSqlRaw("select * from Store.Store;").ToList();
        }

        public List<Order> GetOrders()
        {
            return _da.Orders.FromSqlRaw("Select * from Store.[Order];").ToList();
        }

        public List<Product> GetProducts()
        {
            return _da.Products.FromSqlRaw("Select ProductID, ProductName, Price, StoreID from Store.Product;").ToList();
        }


    }
}