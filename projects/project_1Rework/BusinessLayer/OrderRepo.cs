using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.ViewModels;
using StoreAppApiDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class OrderRepo : IModelMapper<Order, ViewModelOrder>
    {
        private readonly Project_1StoreAppDBContext _context;

        public OrderRepo(Project_1StoreAppDBContext context)
        {
            _context = context;
        }
        public ViewModelOrder EFToView(Order ef)
        {
            ViewModelOrder o1 = new ViewModelOrder(ef.OrderId, ef.StoreId, ef.CustomerId, ef.OrderDate, ef.FinalPrice);
            return o1;
        }

        public Order ViewToEF(ViewModelOrder view)
        {
            Order o1 = (Order)_context.Orders.FromSqlRaw<Order>("Select * from Store.Orders where OrderID = {0}", view.OrderId).FirstOrDefault();
            return o1;
        }
    }
}
