using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{

  public class DataAdapter : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Store> Stores { get; set; }

    private readonly DataAdapter _da = new DataAdapter();
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=StoreApplicationDB;Trusted_Connection:True;");
    }

    public List<Customer> GetCustomers()
    {
      return _da.Customers.FromSqlRaw("Select Name from Customer.Customer").ToList();
    }
    public void setCustomer(Customer customer)
    {
      _da.Customers.FromSqlRaw("insert into Customer.Customer(Name) values ({0}),", customer.userName);
    }
  }


}