using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Weight
    {
        public int WeightId { get; set; }
        public string WeightName { get; set; }
        public bool? WeightIsActive { get; set; }
        public int SizeId { get; set; }

        public virtual Size Size { get; set; }
    }
}
