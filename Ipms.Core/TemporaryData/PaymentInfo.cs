using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class PaymentInfo
    {
        public int PaymentInfoId { get; set; }
        public int CustomerId { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? PayAmount { get; set; }
        public int? AccountId { get; set; }
        public int? CollectionById { get; set; }
        public int EntryById { get; set; }
        public string VoucharNo { get; set; }
        public double? Discount { get; set; }
    }
}
