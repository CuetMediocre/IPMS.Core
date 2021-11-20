using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class CustomerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TradeName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public int CustomerTypeId { get; set; }
        public double? DueAmount { get; set; }
        public double? InitialDue { get; set; }
        public string Photos { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public int DistrictId { get; set; }
        public int UpozillaId { get; set; }
        public int EntryById { get; set; }
        public string FatherName { get; set; }
        public string Nid { get; set; }
    }
}
