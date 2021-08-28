namespace Project0.StoreApplication.Domain.Models
{

  /// <summary>
  /// The customer class to hold the general information about what a customer should have
  /// along with supporting methods
  /// </summary>
  public class Customer
  {

    public int customerId;
    public string userName { get; set; }


    public Customer()
    {

    }
    public Customer(string name)
    {
      userName = name;
    }

  }
}