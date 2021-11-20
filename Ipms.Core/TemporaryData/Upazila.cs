using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Upazila
    {
        public int UpazilaId { get; set; }
        public string UpazilaName { get; set; }
        public int DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}
