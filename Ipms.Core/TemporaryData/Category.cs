using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Category
    {
        public Category()
        {
            Brands = new HashSet<Brand>();
        }

        public int CategoryId { get; set; }
        public bool? CategoryIsActive { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}
