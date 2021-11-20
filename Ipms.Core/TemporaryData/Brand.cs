using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Brand
    {
        public Brand()
        {
            Sizes = new HashSet<Size>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public bool? BrandIsActive { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
    }
}
