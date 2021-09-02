using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Storage;
using Project0.StoreApplication.Client.SingleTons;

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

      // assert
      Assert.NotNull(sut);
    }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Test_GetOrders(int i)
        {
            
            var def = new DemoEF();
            var sut = new OrderRepository();

            var order = def.GetOrders()[i - 1];

            Assert.NotNull(order);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Test_CustGetOrders(int i)
        {

            var def = new DemoEF();
            var sut = new OrderRepository();
            var sutCust = new CustomerRepository();

            var Customer = def.GetCustomers()[i - 1];

            var custOrder = def.GetCustomerOrders(Customer)[i - 1];

            Assert.NotNull(custOrder);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Test_StoreGetOrders(int i)
        {
            
            var def = new DemoEF();
            var sut = new OrderRepository();
            var sutStore = new StoreRepository();
            var Store = def.GetStores()[i - 1];

            var storeOrder = def.GetStoreOrders(Store)[i - 1];

            Assert.NotNull(storeOrder);
        }

        [Fact]
        public void Test_StoreSingleton()
        {
            var sut = OrderSingleton.Instance;

            // act = execute sut for data
            var actual = sut.Orders;

            // assert
            Assert.NotNull(actual);
        }
    }
}