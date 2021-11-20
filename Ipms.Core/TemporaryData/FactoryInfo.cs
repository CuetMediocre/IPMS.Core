using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class FactoryInfo
    {
        public FactoryInfo()
        {
            EmployeeInformations = new HashSet<EmployeeInformation>();
            FactoryUnitInfos = new HashSet<FactoryUnitInfo>();
        }

        public int FactoryId { get; set; }
        public string FactoryName { get; set; }
        public string FactoryAddress { get; set; }
        public string FactoryPhoto1 { get; set; }
        public string FactoryEmail { get; set; }
        public string FactoryMobileNo { get; set; }
        public bool? FactoryIsActive { get; set; }

        public virtual ICollection<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual ICollection<FactoryUnitInfo> FactoryUnitInfos { get; set; }
    }
}
