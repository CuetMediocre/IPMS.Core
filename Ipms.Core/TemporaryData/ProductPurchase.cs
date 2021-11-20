using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class ProductPurchase
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int VendorId { get; set; }
        public int EntryById { get; set; }
        public double? LabourCost { get; set; }
        public int PaymentTypeId { get; set; }
        public int BankId { get; set; }
        public int Discount { get; set; }
        public int CarringBill { get; set; }
        public int ToDirectSaleId { get; set; }
        public string DoNo { get; set; }
        public string TruckNo { get; set; }
    }
}
