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

             CreateCustomerMenu();
            
             //Select Customer
            Customer currentCustomer = GetCustomerFromUserPrompt();
                
            //Select a Store
             Store store = SqlStoreTest();

            MainMenu(currentCustomer, store);

        }

    /// <summary>
    /// The run fucntion to start the code not yet perfectly implemented
    /// </summary>
   
        /*
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
        */

     /// <summary>
     /// This method is used to print customers from the database and give the user the option to select a customer SPLITT THIS 
     /// </summary>
     /// <returns></returns>
    static Customer GetCustomerFromUserPrompt()
    {
            Log.Information("method run()");

            var def = new DemoEF();
            bool flag = false;
            int result = 0;
      int customerid = 1;
      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(customerid + " " + item.Name);
        customerid += 1;
      }
            while(flag != true)
            {
                Console.WriteLine("Who are you?");
                 flag = int.TryParse(Console.ReadLine(), out result);
                if(flag == true)
                {
                    if (result > 0 && result <= def.GetCustomers().Count)
                    {
                        Console.WriteLine("Input Valid");
                    }
                    else
                    {
                        Console.WriteLine("NUMBER NOT IN VALID RANGE");
                        Log.Information("SOMEONE DIDNT ENTER THE RIGHT NUMBER RANGE");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                    Log.Information("SOMEONE DIDNT ENTER A Valid data type");
                }
            }
           
            var customer = def.GetCustomers()[result - 1];
            return customer;
        }

        /// <summary>
        /// This method is the start of the menu where the user is prompted with making a user or skip and log in
        /// </summary>
    static void CreateCustomerMenu()
        {

            Log.Information("method run()");
            Console.WriteLine("Hello to the StoreApplication app ");

            int result = 0;
            bool flag = false;

            while (flag != true)
            {
                Console.WriteLine("1. Exisiting user? ");
                Console.WriteLine("2. New User");

                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag == true)
                {
                    if (result == 1 || result == 2)
                    {
                        Console.WriteLine("Input Valid");
                    }
                    else
                    {
                        Console.WriteLine("NUMBER NOT IN VALID RANGE");
                        Log.Information("SOMEONE DIDNT ENTER THE RIGHT NUMBER RANGE");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                    Log.Information("SOMEONE DIDNT ENTER A Valid data type");
                }
            }

            if (result == 2)
            {
                insertCustomer();
            }


        }

        /// <summary>
        /// Method used to insert a customer into the database
        /// </summary>
     static void insertCustomer()
        {

            Log.Information("method run()");

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
            Log.Information("method run()");


            var def = new DemoEF();


            int result = 0;
            bool flag = false;

            while(flag != true)
            {
                int storeID = 1;
                foreach (var item in def.GetStores())
                {
                    Console.WriteLine(storeID + " " + item.storeName);
                    storeID += 1;
                }
                Console.WriteLine("What store do you want to shop at?");

                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag == true)
                {
                    if (result > 0 && result <= def.GetStores().Count)
                    {
                        Console.WriteLine("Input Valid");
                    }
                    else
                    {
                        Console.WriteLine("NUMBER NOT IN VALID RANGE");
                        Log.Information("SOMEONE DIDNT ENTER THE RIGHT NUMBER RANGE");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                    Log.Information("SOMEONE DIDNT ENTER A Valid data type");
                }
            }

            var store = def.GetStores()[result - 1];
            return store;

        }

        /// <summary>
        /// This method is used to select a product from the selected store
        /// </summary>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        static Product SqlProductTest(string StoreName)
        {
            Log.Information("method run()");


            var def = new DemoEF();
           

          

            int result = 0;
            bool flag = false;

            while(flag != true)
            {
                int ProductID = 1;
                Console.WriteLine("Avaliable Products at " + StoreName);
                foreach (var item in def.GetProducts(StoreName))
                {
                    Console.WriteLine(ProductID + " " + item.ProductName + " " + item.Price);
                    ProductID += 1;
                }

                Console.WriteLine("What Product do you want to buy?");

                flag = int.TryParse(Console.ReadLine(), out result);

                if (flag == true)
                {
                    if (result > 0 && result <= def.GetProducts(StoreName).Count)
                    {
                        Console.WriteLine("Input Valid");
                    }
                    else
                    {
                        Console.WriteLine("NUMBER NOT IN VALID RANGE");
                        Log.Information("SOMEONE DIDNT ENTER THE RIGHT NUMBER RANGE");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                    Log.Information("SOMEONE DIDNT ENTER A Valid data type");
                }
            }

            var Product = def.GetProducts(StoreName)[result - 1];
            return Product;

        }

        /// <summary>
        /// This method Prints out the orders made by the current customer
        /// </summary>
        /// <param name="cust"></param>
        static void SqlCustomerOrderTest(Customer cust)
        {

            Log.Information("method run()");

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
            Log.Information("method run()");


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

        /*
        private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"Method Output<{typeof(T)}>"); //string Inerpolation

      foreach (var type in data)
      {
        Console.WriteLine(type);
      }
    }
        */

 
    private static void MainMenu(Customer cust, Store store)
    {
            Console.WriteLine("\n\nWelcome " + cust.Name + " to the " + store.storeName);


            var option = 0;
            bool flag = false;
            

         
          
            while (option != 999)
            {
                Console.WriteLine("Select an action ");
                Console.WriteLine("1. Look at your past Orders");
                Console.WriteLine("2. Look at your selected store past Orders");
                Console.WriteLine("3. Place an Order");
                Console.WriteLine("999. Exit");

                flag = int.TryParse(Console.ReadLine(), out option);
                
                if(flag == true)
                {
                    if (option == 1)
                    {
                        Console.WriteLine("\n");
                        SqlCustomerOrderTest(cust);
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("\n");
                        SqlStoreOrderTest(store);
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("\n");
                        Product product = SqlProductTest(store.storeName);
                        InsertOrder(cust, store, product);
                    }
                    else if (option == 999)
                    {
                        Console.WriteLine("GoodBye");
                    }
                }
                else
                {
                    Console.WriteLine("INVALID DATE");
                }

            
            }
    }
  }
}
