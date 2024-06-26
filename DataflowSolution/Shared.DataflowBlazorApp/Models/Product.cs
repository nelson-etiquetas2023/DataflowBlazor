﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataflowBlazorApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double Price { get; set; }
        public string Category { get; set; } = null!;
        public string Presentation { get; set; } = null!;
        public string Imagen { get; set; } = null!;
        public Boolean IsActive { get; set; }
        public Boolean IsService { get; set; }
        public string CodigoBarra { get; set; } = null!;
    }
}
