using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class Designation
    {
        public Designation()
        {
            EmployeeInformations = new HashSet<EmployeeInformation>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string DesignationDesciption { get; set; }
        public bool? DesignationIsActive { get; set; }

        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
