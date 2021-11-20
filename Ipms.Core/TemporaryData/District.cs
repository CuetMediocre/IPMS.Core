using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class District
    {
        public District()
        {
            Upazilas = new HashSet<Upazila>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int DivisionId { get; set; }

        public virtual Division Division { get; set; }
        public virtual ICollection<Upazila> Upazilas { get; set; }
    }
}
