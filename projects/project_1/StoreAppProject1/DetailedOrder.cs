using System;
using System.Collections.Generic;

#nullable disable

namespace StoreAppProject1
{
    public partial class DetailedOrder
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string StoreName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
