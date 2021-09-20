using System;
using System.Collections.Generic;

#nullable disable

namespace DBContext
{
    public partial class ProductList
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public byte ProductRemaining { get; set; }
    }
}
