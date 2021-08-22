using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class ProductRepoTest
  {
    [Fact] //TDD 
    public void Test_ProductCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = new ProductRepository();

      // act = execute sut for data
      var actual = sut.Products;

      // assert
      Assert.NotNull(actual);
    }
  }
}