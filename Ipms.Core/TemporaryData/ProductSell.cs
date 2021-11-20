using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductSell
    {
        public int ProductSellId { get; set; }
        public int TransactionId { get; set; }
        public double? Commission { get; set; }
        public double? TotalAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? DueAmount { get; set; }
        public double? PaidAmount { get; set; }
        public int CustomerId { get; set; }
        public double? LabourCost { get; set; }
        public DateTime? SellingDate { get; set; }
        public int EntryById { get; set; }
        public string VoucherNo { get; set; }
        public double CarryingCost { get; set; }
    }
}
