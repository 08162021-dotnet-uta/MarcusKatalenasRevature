using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.SingleTons
{

  /// <summary>
  /// 
  /// </summary>
  public class OrderSingleton
  {

    private static OrderSingleton _orderSingle;
    private static readonly OrderRepository _orderRepo = new OrderRepository();


    public List<Order> Orders { get; private set; }

    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingle == null)
        {
          _orderSingle = new OrderSingleton();

        }
        else
        {
          return _orderSingle;
        }
        return _orderSingle;
      }
    }

    private OrderSingleton()
    {
      Orders = _orderRepo.Select();
    }

    public void Add(Order order)
    {
      _orderRepo.Insert(order);
      Orders = _orderRepo.Select();
    }
  }
}