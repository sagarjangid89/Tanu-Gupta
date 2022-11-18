using System;
using System.Collections.Generic;

namespace TanuTest.Models.DB
{
    public partial class ProductInfo
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
