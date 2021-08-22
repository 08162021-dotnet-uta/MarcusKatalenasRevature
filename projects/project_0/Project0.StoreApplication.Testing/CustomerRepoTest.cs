using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class CustomerRepoTest
  {
    [Fact] //TDD 
    public void Test_CustomerCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = new CustomerRepository();

      // act = execute sut for data
      var actual = sut.Customers;

      // assert
      Assert.NotNull(actual);
    }
  }
}