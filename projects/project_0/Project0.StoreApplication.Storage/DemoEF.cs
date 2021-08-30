
using System.Collections.Generic;
using System.Data;
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

        public List<Order> GetCustomerOrders(Customer cust)
        {
            return _da.Orders.FromSqlRaw($"Select * from Store.[Order] where CustomerID = {cust.CustomerID};").ToList();
        }
        public List<Order> GetStoreOrders(Store store)
        {
            return _da.Orders.FromSqlRaw($"Select * from Store.[Order] where StoreID = {store.storeID};").ToList();
        }

        public List<Product> GetProducts(string storeName)
        {
            return _da.Products.FromSqlRaw($"Select ProductID, ProductName, Price, sp.StoreID from Store.Product as sp join Store.Store as s on(sp.StoreID = s.StoreID) where s.storeName = '{storeName}';").ToList();
        }
    }
}