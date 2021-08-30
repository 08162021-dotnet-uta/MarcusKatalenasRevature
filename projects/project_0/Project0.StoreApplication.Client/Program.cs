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

            

           
                //Select Customer
             // Customer currentCustomer = SqlCustomerTest();
                
            //Select a Store
              //Store store = SqlStoreTest();

            //Print products from the selected store
            // SqlProductTest(store.storeName);

            //Print past orders from the customer 
            // SqlCustomerOrderTest(currentCustomer);

            //Print past orders from the store
            //  SqlStoreOrderTest(store);

            insertCustomer();



          


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

    static Customer SqlCustomerTest()
    {
      var def = new DemoEF();
      int customerid = 1;
      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(customerid + " " + item.Name);
                customerid += 1;
      }
            Console.WriteLine("Who are you?");

            var option = int.Parse(Console.ReadLine());
            var customer = def.GetCustomers()[option - 1];
            return customer;
        }

     static void insertCustomer()
        {
            Console.WriteLine("Enter Name");
            String Name = (Console.ReadLine());

            CustomerRepository cr = new CustomerRepository();

            Customer newCustomer = new Customer(Name);

            cr.Insert(newCustomer);
        }

        static Store SqlStoreTest()
        {
            var def = new DemoEF();
            int storeID = 1;

            foreach (var item in def.GetStores())
            {
                Console.WriteLine(storeID + " " + item.storeName);
                storeID += 1;
            }

            Console.WriteLine("What store do you want to shop at?");

            var option = int.Parse(Console.ReadLine());
            var store = def.GetStores()[option - 1];
            return store;

        }

        static void SqlProductTest(string StoreName)
        {
            var def = new DemoEF();

            Console.WriteLine("Avaliable Products at " + StoreName);
            foreach (var item in def.GetProducts(StoreName))
            {
                Console.WriteLine(item);
            }
        }
        static void SqlCustomerOrderTest(Customer cust)
        {
            var def = new DemoEF();

            Console.WriteLine("Printing Past " + cust.Name + " Orders");
            foreach (var item in def.GetCustomerOrders(cust))
            {
                Console.WriteLine(item);
            }
        }

        static void SqlStoreOrderTest(Store store)
        {
            var def = new DemoEF();

            Console.WriteLine("Printing Past Orders from " + store.storeName);
            foreach (var item in def.GetStoreOrders(store))
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
