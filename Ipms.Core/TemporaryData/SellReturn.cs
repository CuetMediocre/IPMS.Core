using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class SellReturn
    {
        public int SellReturn1 { get; set; }
        public int TransactionId { get; set; }
        public double? Commision { get; set; }
        public double? TotalAmount { get; set; }
        public double? NetAmount { get; set; }
        public double? DueAmount { get; set; }
        public double? PaidAmount { get; set; }
        public double? CustomerId { get; set; }
        public double? LabourCost { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int EntryById { get; set; }
        public int? SellId { get; set; }
        public string PaymentType { get; set; }
    }
}
