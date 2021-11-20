using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class TargetPayment
    {
        public int TargetPaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ProductSellId { get; set; }
    }
}
