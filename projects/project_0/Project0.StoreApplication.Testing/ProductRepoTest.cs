using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;

namespace Project0.StoreApplication.Testing
{
  public class ProductRepoTest
  {
    [Fact] //TDD 
    public void Test_ProductCollection()
    {
      // arrange = instance of the entity of the entity to test //sut Subject under test
      var sut = ProductSingleton.Instance;

      // act = execute sut for data
      var actual = sut.Products;

      // assert
      Assert.NotNull(actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]

    public void Test_GetProducts(int i)
    {
      var sut = ProductSingleton.Instance;

      var product = sut.Products[i];

      Assert.NotNull(product);
    }
  }
}