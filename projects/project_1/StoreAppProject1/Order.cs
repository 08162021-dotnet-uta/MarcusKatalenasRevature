using System;
using System.Collections.Generic;

#nullable disable

namespace StoreAppProject1
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid StoreId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal FinalPrice { get; set; }
        public bool? Active { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
