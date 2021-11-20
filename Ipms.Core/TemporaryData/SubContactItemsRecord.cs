using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class SubContactItemsRecord
    {
        public int SubContactItemsRecordId { get; set; }
        public int ProductListId { get; set; }
        public int NetId { get; set; }
        public double? NetQuantity { get; set; }
        public double? UnitPrice { get; set; }
        public int SubContactItemsId { get; set; }
        public double? Amount { get; set; }
    }
}
