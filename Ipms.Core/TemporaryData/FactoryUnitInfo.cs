using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class FactoryUnitInfo
    {
        public FactoryUnitInfo()
        {
            EmployeeInformations = new HashSet<EmployeeInformation>();
        }

        public int FactoryUnitId { get; set; }
        public string FactoryUnitName { get; set; }
        public bool? FactoryUnitIsActive { get; set; }
        public int FactoryId { get; set; }

        public virtual FactoryInfo Factory { get; set; }
        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
