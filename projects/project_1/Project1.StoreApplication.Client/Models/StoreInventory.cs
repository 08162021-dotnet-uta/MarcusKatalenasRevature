using System;
using System.Collections.Generic;

#nullable disable

namespace project1app.Models
{
    public partial class StoreInventory
    {
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public byte ProductRemaining { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
