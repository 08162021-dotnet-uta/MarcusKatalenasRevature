using System;
using System.Collections.Generic;

#nullable disable

namespace StoreAppProject1
{
    public partial class OrderProduct
    {
        public Guid OrderProductId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public byte AmountOrdered { get; set; }
        public bool? Active { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
