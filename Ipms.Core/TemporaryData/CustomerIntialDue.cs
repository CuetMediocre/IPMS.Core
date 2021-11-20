using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class CustomerIntialDue
    {
        public int Id { get; set; }
        public double InitialDueAmount { get; set; }
        public int Year { get; set; }
        public DateTime EntryDate { get; set; }
        public int CustomerId { get; set; }
    }
}
