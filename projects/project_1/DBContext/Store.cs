using System;
using System.Collections.Generic;

#nullable disable

namespace DBContext
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public Guid StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
