using System;
using System.Collections.Generic;

#nullable disable

namespace DBContext
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescrip { get; set; }
        public Guid StoreId { get; set; }
        public decimal Price { get; set; }
        public bool? Active { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
