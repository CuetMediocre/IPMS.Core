using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class SubContactItem
    {
        public int SubContactItemsId { get; set; }
        public int TransactionId { get; set; }
        public DateTime ContactDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SubContactorId { get; set; }
        public int EntryById { get; set; }
        public double? LabourCost { get; set; }
        public int PaymentTypeId { get; set; }
        public int BankId { get; set; }
        public string CurrencyType { get; set; }
        public int Discount { get; set; }
        public int ShipingBill { get; set; }
        public double TotalBill { get; set; }
        public double AdvanceAmount { get; set; }
        public string Status { get; set; }
    }
}
