using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.Storeapplicaton.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository
  {
    public List<Product> Products { get; }

    private const string _path = @"/home/marcus/revature/marcus_code/Data/project_0_Products.xml";


    public ProductRepository()
    {

      var fileadapt = new FileAdapter();




    }
  }
}