using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Country
    {
        public Country()
        {
            Divisions = new HashSet<Division>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Division> Divisions { get; set; }
    }
}
