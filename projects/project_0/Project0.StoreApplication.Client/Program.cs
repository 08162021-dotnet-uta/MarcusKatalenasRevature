using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;


namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var p = new Program();

      Console.WriteLine("Hello");
      p.PrintAllStoreLocations();

      var store = p.selectStore();
      
      p.printProducts();
      p.purchaseProducts(store);
    }
    void PrintAllStoreLocations()
    {
      var storeRepository = new StoreRepository();
      int storeid = 1;
      

      foreach (var store in storeRepository.Stores)
      {
        Console.WriteLine(storeid + " " + store);
        storeid += 1;
      }
    }

    Store selectStore()
    {
      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a Store ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;
    }

    void printProducts(){
       var productRepo = new ProductRepository();
       int productID = 1;
       foreach (var product in productRepo.Products)
       {
            Console.WriteLine(productID + " " + product);
            productID += 1;

       }
    }
    void purchaseProducts(Store store){
      
      var pr = new ProductRepository().Products;

      Console.WriteLine("Select a product you want to buy");
      var option = int.Parse(Console.ReadLine());
      var product = pr[option - 1];

      Console.WriteLine("You have bought " + product + " from " + store);

    }
  }
}
