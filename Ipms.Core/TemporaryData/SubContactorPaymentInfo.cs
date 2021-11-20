using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class SubContactorPaymentInfo
    {
        public int ContactorPaymentInfoId { get; set; }
        public int ContactorId { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? PayAmount { get; set; }
        public int? AccountId { get; set; }
        public int? CollectionById { get; set; }
        public int EntryById { get; set; }
        public string VoucharNo { get; set; }
        public double? Discount { get; set; }
        public int PaymentTypeId { get; set; }
        public int BankId { get; set; }
        public string CurrencyType { get; set; }
    }
}
