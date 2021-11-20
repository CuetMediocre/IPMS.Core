using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Division
    {
        public Division()
        {
            Districts = new HashSet<District>();
        }

        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
