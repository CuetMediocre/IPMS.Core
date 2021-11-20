using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class CrVoucher
    {
        public int CrVoucher1 { get; set; }
        public int TransactionId { get; set; }
        public int CrTypeId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public double Amount { get; set; }
        public int DebitedToId { get; set; }
        public int CreditedFromId { get; set; }
        public string VoucherNo { get; set; }
    }
}
