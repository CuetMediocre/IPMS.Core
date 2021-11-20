using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class SubContactor
    {
        public int ContactorId { get; set; }
        public string ContactorName { get; set; }
        public string ContactNumber { get; set; }
        public string FatherName { get; set; }
        public string ContactorNid { get; set; }
        public string ContactorPhoto { get; set; }
        public DateTime JoinDate { get; set; }
        public int InitialBalance { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public int DistrictId { get; set; }
        public int UpozillaId { get; set; }
        public int SubContactorAccoutId { get; set; }
        public int EntryById { get; set; }
    }
}
