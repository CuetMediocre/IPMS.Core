using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductStock
    {
        public int Id { get; set; }
        public int ProductListId { get; set; }
        public double? StockAmount { get; set; }
    }
}
