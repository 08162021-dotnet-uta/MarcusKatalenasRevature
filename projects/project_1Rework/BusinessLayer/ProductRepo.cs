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
    class ProductRepo : IModelMapper<Product, ViewModelProduct>
    {
        private readonly Project_1StoreAppDBContext _context;
        public ViewModelProduct EFToView(Product ef)
        {
            ViewModelProduct p1 = new ViewModelProduct(ef.ProductId, ef.ProductDescrip, ef.ProductName, ef.Price);
            return p1;
        }

        public Product ViewToEF(ViewModelProduct view)
        {
            Product p1 = (Product)_context.Products.FromSqlRaw<Product>("Select * from Store.Product where productName = {0}", view.ProductName).FirstOrDefault();
            return p1;
        }
    }
}
