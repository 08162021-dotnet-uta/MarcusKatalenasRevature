using System.Collections.Generic;

using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.SingleTons
{

  /// <summary>
  /// 
  /// </summary>
  public class ProductSingleton
  {

    private static ProductSingleton _productSingle;
    private static readonly ProductRepository _productRepo = new ProductRepository();


    public List<Product> Products { get; private set; }

    public static ProductSingleton Instance
    {
      get
      {
        if (_productSingle == null)
        {
          _productSingle = new ProductSingleton();

        }
        else
        {
          return _productSingle;
        }
        return _productSingle;
      }
    }

    private ProductSingleton()
    {
      Products = _productRepo.Select();
    }

    public void Add(Product product)
    {
      _productRepo.Insert(product);
      Products = _productRepo.Select();
    }
  }
}