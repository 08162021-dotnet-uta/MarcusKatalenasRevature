
using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;

namespace Project0.StoreApplication.Testing
{


  public class StoreRepositoryTests
  {
    [Fact] //TDD 
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = StoreSingleton.Instance;

      // act = execute sut for data
      var actual = sut.Stores;

      // assert
      Assert.NotNull(actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]

    public void Test_GetStore(int i)
    {
      var sut = StoreSingleton.Instance;

      var store = sut.Stores[i];

      Assert.NotNull(store);
    }

  }
}