using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class DrVoucher
    {
        public int DrVoucherid { get; set; }
        public int TransacationId { get; set; }
        public int DrTypeId { get; set; }
        public DateTime IncomeDate { get; set; }
        public double Amount { get; set; }
        public int DebitToId { get; set; }
        public int CreditFromId { get; set; }
    }
}
