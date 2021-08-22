using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class CustomerRepository
  {
    public List<Customer> Customers { get; set; }

    public CustomerRepository()
    {

      Customers = new List<Customer>()
      {
        new Customer{userName = "Marcus"},
        new Customer{userName = "Luke"},
        new Customer{userName = "John"}
      };
    }
  }
}