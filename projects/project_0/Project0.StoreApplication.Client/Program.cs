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
      Console.WriteLine(p.selectStore());
      p.printProducts();
    }
    void PrintAllStoreLocations()
    {
      var storeRepository = new StoreRepository();
      int storeid = 0;
      

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
      var store = sr[option];

      return store;
    }

    void printProducts(){
       var productRepo = new ProductRepository();
       foreach (var product in productRepo.Products)
       {
            Console.WriteLine(product);
       }
    }
  }
}
