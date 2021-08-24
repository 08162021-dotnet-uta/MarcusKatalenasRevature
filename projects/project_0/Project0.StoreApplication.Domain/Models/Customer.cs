namespace Project0.StoreApplication.Domain.Models
{

  /// <summary>
  /// 
  /// </summary>
  public class Customer
  {
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