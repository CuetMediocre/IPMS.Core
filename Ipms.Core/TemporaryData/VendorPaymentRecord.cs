using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class VendorPaymentRecord
    {
        public int VendorPaymentRecord1 { get; set; }
        public int TransactionId { get; set; }
        public int VendorId { get; set; }
        public DateTime PayDate { get; set; }
        public double Amount { get; set; }
        public int EntryById { get; set; }
        public int DebitToId { get; set; }
        public int CreditToId { get; set; }
        public string CheckNo { get; set; }
        public int? BankId { get; set; }
        public int? PaymentTypeId { get; set; }
    }
}
