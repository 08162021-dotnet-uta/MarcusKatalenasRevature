using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;
using Project0.StoreApplication.Storage;
using Project0.StoreApplication.Domain.Models;

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
      

      // assert
      Assert.NotNull(sut);
    }

    [Fact]
    public void productModelTest()
        {
            Product sut = new Product();
        }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    

    public void Test_GetProducts(int i)
    {
            var def = new DemoEF();
            var sut = new ProductRepository();

            var sutStore = new StoreRepository();
            var Store = def.GetStores()[i - 1];

            var store = def.GetProducts(Store.storeName)[i - 1];

            Assert.NotNull(store);
    }

        [Fact]
        public void Test_ProductSingleton()
        {
            var sut = ProductSingleton.Instance;

            // act = execute sut for data
            var actual = sut.Products;

            // assert
            Assert.NotNull(actual);
        }
    }
}