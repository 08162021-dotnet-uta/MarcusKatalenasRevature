using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.SingleTons
{

  /// <summary>
  /// 
  /// </summary>
  public class CustomerSingleton
  {

    private static CustomerSingleton _customerSingle;
    private static readonly CustomerRepository _customerRepo = new CustomerRepository();


    public List<Customer> Customers { get; private set; }

    public static CustomerSingleton Instance
    {
      get
      {
        if (_customerSingle == null)
        {
          _customerSingle = new CustomerSingleton();

        }
        else
        {
          return _customerSingle;
        }
        return _customerSingle;
      }
    }

    private CustomerSingleton()
    {
      Customers = _customerRepo.Select();
    }

    public void Add(Customer cust)
    {
      _customerRepo.Insert(cust);
    }
  }
}