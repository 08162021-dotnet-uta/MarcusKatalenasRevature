using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreWebApi;

namespace Project0.StoreApplication.Storage.Adapters
{

    public class DataAdapter : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Store> Stores { get; set; }

    public DbSet<Product> Products { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=StoreApplicationDB; Trusted_Connection = True;");
    }
  }


}