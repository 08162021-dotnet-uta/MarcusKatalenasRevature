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

      Log.Logger = new LoggerConfiguration().WriteTo.File(_logfilePath).CreateLogger();


            //Run();

            

           
                //Select Customer
            Customer currentCustomer = SqlCustomerTest();
                
            //Select a Store
              Store store = SqlStoreTest();

            MainMenu(currentCustomer, store);

            //Print products from the selected store
          //  Product product = SqlProductTest(store.storeName);

           // InsertOrder(currentCustomer, store, product);

            //Print past orders from the customer 
           // SqlCustomerOrderTest(currentCustomer);

            //Print past orders from the store
            // SqlStoreOrderTest(store);

           

            //insertCustomer();



          


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

     /// <summary>
     /// This method is used to print customers from the database and give the user the option to select a customer SPLITT THIS 
     /// </summary>
     /// <returns></returns>
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

        /// <summary>
        /// Method used to insert a customer into the database
        /// </summary>
     static void insertCustomer()
        {
            Console.WriteLine("Enter Name");
            String Name = (Console.ReadLine());

            CustomerRepository cr = new CustomerRepository();

            Customer newCustomer = new Customer(Name);

            cr.Insert(newCustomer);
        }

        /// <summary>
        /// This method is used to select a store from the database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method is used to select a product from the selected store
        /// </summary>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        static Product SqlProductTest(string StoreName)
        {
            var def = new DemoEF();
            int ProductID = 1;

            Console.WriteLine("Avaliable Products at " + StoreName);
            foreach (var item in def.GetProducts(StoreName))
            {
                Console.WriteLine(ProductID + " " + item.ProductName + " " + item.Price);
                ProductID += 1;
            }

            Console.WriteLine("What Product do you want to buy?");

            var option = int.Parse(Console.ReadLine());
            var Product = def.GetProducts(StoreName)[option - 1];
            return Product;

        }

        /// <summary>
        /// This method Prints out the orders made by the current customer
        /// </summary>
        /// <param name="cust"></param>
        static void SqlCustomerOrderTest(Customer cust)
        {
            var def = new DemoEF();

            Console.WriteLine("Printing Past " + cust.Name + " Orders");
            foreach (var item in def.GetCustomerOrders(cust))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This method prints the orders made from the selected store
        /// </summary>
        /// <param name="store"></param>
        static void SqlStoreOrderTest(Store store)
        {
            var def = new DemoEF();

            Console.WriteLine("Printing Past Orders from " + store.storeName);
            foreach (var item in def.GetStoreOrders(store))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// The method used to insert Orders into the sql database table
        /// </summary>
        /// <param name="cust"></param>
        /// <param name="store"></param>
        static void InsertOrder(Customer cust, Store store, Product product)
        {
            _ = new DemoEF();

            Order newOrder = new Order(cust.CustomerID, store.storeID);

            OrderRepository or = new OrderRepository();

            or.Insert(newOrder);

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

    private static void MainMenu(Customer cust, Store store)
    {
            Console.WriteLine("\n\nWelcome " + cust.Name + " to the " + store.storeName);

            var option = 0;

            while(option != 999)
            {
                Console.WriteLine("Select an action ");
                Console.WriteLine("1. Look at your past Orders");
                Console.WriteLine("2. Look at your selected store past Orders");
                Console.WriteLine("3. Place an Order");
                Console.WriteLine("999. Exit");

                option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.WriteLine("\n");
                    SqlCustomerOrderTest(cust);
                }
                else if(option == 2)
                {
                    Console.WriteLine("\n");
                    SqlStoreOrderTest(store);
                }
                else if(option == 3)
                {
                    Console.WriteLine("\n");
                    Product product = SqlProductTest(store.storeName);
                    InsertOrder(cust, store, product);
                }
                else if(option == 999)
                {
                    Console.WriteLine("GoodBye");
                }



            }

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
      Order newOrder = new Order(customer.CustomerID, store.storeID);

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
