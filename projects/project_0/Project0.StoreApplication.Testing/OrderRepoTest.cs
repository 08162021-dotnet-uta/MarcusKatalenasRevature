using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class OrderRepoTest
  {
    [Fact] //TDD 
    public void Test_OrderCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = new OrderRepository();

      // act = execute sut for data
      var actual = sut.Orders;

      // assert
      Assert.NotNull(actual);
    }
  }
}