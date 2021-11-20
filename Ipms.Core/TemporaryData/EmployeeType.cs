using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            EmployeeInformations = new HashSet<EmployeeInformation>();
        }

        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeName { get; set; }

        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
