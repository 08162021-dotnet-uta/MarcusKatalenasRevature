
using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    [Fact] //TDD 
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = StoreRepository.Instance;

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
      var sut = StoreRepository.Instance;

      var store = sut.GetStore(i);

      Assert.NotNull(store);
    }


    [Theory]
    [InlineData(-1)]
    public void Test_GetStoreNull(int i)
    {
      var sut = StoreRepository.Instance;

      var store = sut.GetStore(i);

      Assert.Null(store);
    }
  }
}