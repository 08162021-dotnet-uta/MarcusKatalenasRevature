using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
  class Program
  {

    //Singular instance at runtime 
    private readonly StoreRepository _storeRepo = StoreRepository.Instance;
    static void Main(string[] args)
    {

      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();


      var p = new Program();

      Console.WriteLine("Hello");


      //Customer 
      p.printAllCustomers();
      var customer = p.SelectCustomer();

      //Stores
      p.PrintAllStoreLocations();
      var store = p.selectStore();

      p.printProducts();
      p.purchaseProducts(customer, store);
    }

    void printAllCustomers()
    {
      var customerRep = new CustomerRepository();
      int customerid = 1;

      foreach (var customer in customerRep.Customers)
      {
        Console.WriteLine(customerid + " " + customer);
        customerid += 1;
      }
    }
    Customer SelectCustomer()
    {
      var cr = new CustomerRepository().Customers;

      Console.WriteLine("Who are you?");

      var option = int.Parse(Console.ReadLine());
      var customer = cr[option - 1];

      return customer;
    }

    void PrintAllStoreLocations()
    {

      Log.Information("Store Output Method");
      int storeid = 1;


      foreach (var store in _storeRepo.Stores)
      {
        Console.WriteLine(storeid + " " + store);
        storeid += 1;
      }
    }

    Store selectStore()
    {
      Log.Information("In SelctStore Output Method");
      var sr = _storeRepo.Stores;

      Console.WriteLine("Select a Store ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;
    }

    void printProducts()
    {
      var productRepo = new ProductRepository();
      int productID = 1;
      foreach (var product in productRepo.Products)
      {
        Console.WriteLine(productID + " " + product);
        productID += 1;

      }
    }
    void purchaseProducts(Customer customer, Store store)
    {

      //List products 
      var pr = new ProductRepository().Products;

      //Start a new order
      Order newOrder = new Order();

      Console.WriteLine("Select a product you want to buy");
      var option = int.Parse(Console.ReadLine());
      var product = pr[option - 1];

      Console.WriteLine("You have bought " + product.Name + " from " + store.Name);

    }

    void previewProductsPurchased(Order o)
    {

    }
    void viewStoreOrders()
    {

    }
    void viewCustomerOrders()
    {

    }
  }
}
