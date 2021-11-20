using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductPurchaseRecordList
    {
        public int Id { get; set; }
        public int ProductListId { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public int ProductPurchaseId { get; set; }
        public double? Amount { get; set; }
    }
}
