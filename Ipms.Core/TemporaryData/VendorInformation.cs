using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class VendorInformation
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string ContactNumber { get; set; }
        public string FatherName { get; set; }
        public string VendorPhoto { get; set; }
        public double Balance { get; set; }
        public int InitialBalance { get; set; }
        public DateTime OpeningDate { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public int DistrictId { get; set; }
        public int VendorAccoutId { get; set; }
        public int EntryById { get; set; }
    }
}
