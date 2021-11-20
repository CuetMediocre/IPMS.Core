using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductList
    {
        public int ProductListId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public int WeightId { get; set; }
        public double? TempPrate { get; set; }
        public bool? IsProductActive { get; set; }
    }
}
