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
      p.selectStore();
    }
    void PrintAllStoreLocations()
    {
      var storeRepository = new StoreRepository();
      

      foreach (var store in storeRepository.Stores)
      {
        Console.WriteLine(store);
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
  }
}
