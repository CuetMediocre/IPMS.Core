using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Size
    {
        public Size()
        {
            Weights = new HashSet<Weight>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public bool? SizeIsActive { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Weight> Weights { get; set; }
    }
}
