using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.ViewModels;
using StoreAppApiDbContext.Models;
using System;

namespace BusinessLayer
{


    public class CustomerRepo : IModelMapper<Customer, ViewModelCustomer>
    {
        private readonly Project_1StoreAppDBContext _context;
        public ViewModelCustomer EFToView(Customer ef)
        {

            ViewModelCustomer c1 = new ViewModelCustomer(ef.Fname, ef.Lname);
            return c1;
        }

        public Customer ViewToEF(ViewModelCustomer view)
        {

            Customer c1 = (Customer)_context.Customers.FromSqlRaw<Customer>("Select * From Customer where FName = {0} AND LName = {1}");
            return c1;
        }
    }


}
