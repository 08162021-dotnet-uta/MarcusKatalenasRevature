
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
      var sut = new StoreRepository();

      // act = execute sut for data
      var actual = sut.Stores;

      // assert
      Assert.NotNull(actual);
    }
  }
}