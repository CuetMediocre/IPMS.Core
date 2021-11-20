using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductSellRecordDelete
    {
        public int Id { get; set; }
        public int ProductSellId { get; set; }
        public int ProductListId { get; set; }
        public double? Quantity { get; set; }
        public double? Amount { get; set; }
        public double? LabourCost { get; set; }
    }
}
