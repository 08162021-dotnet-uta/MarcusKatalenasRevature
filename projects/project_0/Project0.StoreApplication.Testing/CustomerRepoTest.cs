using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;

namespace Project0.StoreApplication.Testing
{
  public class CustomerRepoTest
  {
    [Fact] //TDD 
    public void Test_CustomerCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = CustomerSingleton.Instance;
      // act = execute sut for data
      var actual = sut.Customers;

      // assert
      Assert.NotNull(actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]

    public void Test_GetCustomers(int i)
    {
      var sut = CustomerSingleton.Instance;

      var customer = sut.Customers[i];

      Assert.NotNull(customer);
    }



  }
}