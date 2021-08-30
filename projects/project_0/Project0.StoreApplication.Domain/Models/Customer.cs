using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{

  /// <summary>
  /// The customer class to hold the general information about what a customer should have
  /// along with supporting methods
  /// </summary>
  public class Customer
  {

    public byte CustomerID { get; set; }
    public string Name { get; set; }

    public List<Order> Orders { get; set; }



    public Customer()
    {
            Orders = new List<Order>();
    }
    public Customer(string nameGiven)
    {
      Name = nameGiven;
    }

        public override string ToString()
        {
            return $"{CustomerID} {Name} with {Orders.Count} Orders so far";
        }

    }
}