using Xunit;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.SingleTons;
using Project0.StoreApplication.Storage;

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
      

      // assert
      Assert.NotNull(sut);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]

    public void Test_GetCustomers(int i)
    {
            var def = new DemoEF();
            var sut = new StoreRepository();

            var customer = def.GetCustomers()[i - 1];

      Assert.NotNull(customer);
    }


    public void Test_CustomerSingleton()
        {
            var sut = CustomerSingleton.Instance;

            // act = execute sut for data
            var actual = sut.Customers;

            // assert
            Assert.NotNull(actual);
        }



  }
}