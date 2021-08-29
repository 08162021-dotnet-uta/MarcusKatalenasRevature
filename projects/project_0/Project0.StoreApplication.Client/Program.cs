using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.SingleTons;

using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;


/// <summary>
/// Defines the Program Class
/// </summary>
namespace Project0.StoreApplication.Client
{
  class Program
  {

    //Singular instance at runtime 
    private static readonly StoreSingleton _storeRepo = StoreSingleton.Instance;
    private static readonly CustomerSingleton _customerRepo = CustomerSingleton.Instance;
    private static readonly ProductSingleton _productRepo = ProductSingleton.Instance;

    private const string _logfilePath = @"/home/marcus/revature/marcus_code/Data/logs.txt";

    /// <summary>
    /// Defines the main method
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();


            //Run();
            
            SqlCustomerTest();
            SqlStoreTest();
            SqlProductTest();
            SqlOrderTest();


        }

    /// <summary>
    /// 
    /// </summary>
    static void Run()
    {
      Log.Information("method run()");

      //Customers
      Output<Customer>(_customerRepo.Customers);
      //Store
      Output<Store>(_storeRepo.Stores);
      //Products
      Output<Product>(_productRepo.Products);

      //Place an order

      CaptureOutput();
    }

    static void SqlCustomerTest()
    {
      var def = new DemoEF();
      

      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(item);
      }
    }

        static void SqlStoreTest()
        {
            var def = new DemoEF();


            foreach (var item in def.GetStores())
            {
                Console.WriteLine(item);
            }
        }

        static void SqlProductTest()
        {
            var def = new DemoEF();


            foreach (var item in def.GetProducts())
            {
                Console.WriteLine(item);
            }
        }
        static void SqlOrderTest()
        {
            var def = new DemoEF();


            foreach (var item in def.GetOrders())
            {
                Console.WriteLine(item);
            }
        }

        private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"Method Output<{typeof(T)}>"); //string Inerpolation

      foreach (var type in data)
      {
        Console.WriteLine(type);
      }
    }

    private static void CaptureOutput()
    {
      Output<Store>(_storeRepo.Stores);
      Output<Customer>(_customerRepo.Customers);
    }

    private static void MainMenu()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    static void printAllCustomers()
    {
      var customerRep = new CustomerRepository();
      int customerid = 1;

      foreach (var customer in customerRep.Customers)
      {
        Console.WriteLine(customerid + " " + customer);
        customerid += 1;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Customer SelectCustomer()
    {
      var cr = new CustomerRepository().Customers;

      Console.WriteLine("Who are you?");

      var option = int.Parse(Console.ReadLine());
      var customer = cr[option - 1];

      return customer;
    }


    /// <summary>
    /// 
    /// </summary>
    static void PrintAllStoreLocations()
    {

      Log.Information("Store Output Method");
      int storeid = 1;


      foreach (var store in _storeRepo.Stores)
      {
        Console.WriteLine(storeid + " " + store);
        storeid += 1;
      }
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Store selectStore()
    {
      Log.Information("In SelctStore Output Method");
      var sr = _storeRepo.Stores;

      Console.WriteLine("Select a Store ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;
    }


    /// <summary>
    /// 
    /// </summary>
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

      Console.WriteLine("You have bought " + product.ProductName + " from " + store.storeName);

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
