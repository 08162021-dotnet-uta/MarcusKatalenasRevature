﻿using System;
using System.Collections.Generic;

#nullable disable

namespace project1app.Models
{
    public partial class ProductList
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public byte ProductRemaining { get; set; }
    }
}