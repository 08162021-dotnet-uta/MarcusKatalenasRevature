
using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Testing
{


  public class StoreRepositoryTests
  {
    [Fact] //TDD 
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = new StoreRepository();

      // act = execute sut for data
      // assert
      Assert.NotNull(sut);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]

    public void Test_GetStore(int i)
    {
            var def = new DemoEF();
            var sut = new StoreRepository();

        var store = def.GetCustomers()[i - 1];

            Assert.NotNull(store);
    }
        [Fact]
     public void Test_StoreSingleton()
        {
            var sut = CustomerSingleton.Instance;

            // act = execute sut for data
            var actual = sut.Customers;

            // assert
            Assert.NotNull(actual);
        }

  }
}