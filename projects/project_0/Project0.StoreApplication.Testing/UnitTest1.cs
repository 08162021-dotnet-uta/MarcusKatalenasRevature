using Microsoft.EntityFrameworkCore;
using StoreWebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Project0.StoreApplication.Testing
{
    public class UnitTest1
    {
        public DbContextOptions<Project_1StoreAppDBContext> options { get; set; } = new DbContextOptionsBuilder<Project_1StoreAppDBContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        [Fact]
        public void Test1()
        {
            //Create the in mem db
            //Dont forget to configure the actual db in the Context class

           

            using (Project_1StoreAppDBContext _context = new Project_1StoreAppDBContext(options))
            {
                //Arrgange
                //create the foundation of the test

                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();

                Customer c = new Customer();
                c.Fname = "FNAME";
                c.Lname = "LNAME";
                _context.Customers.Add(c);
                _context.SaveChanges();

                //Act
                // act on that foundations 
                Customer c1 = _context.Customers.Where(cust => cust.Fname == "FNAME" && cust.Lname == "LNAME").FirstOrDefault();

                //Assert
                Assert.Equal(c1.Fname, c.Fname);
            }
        }
    }
}
