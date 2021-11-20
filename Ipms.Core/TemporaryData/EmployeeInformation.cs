using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class EmployeeInformation
    {
        public EmployeeInformation()
        {
            Users = new HashSet<User>();
        }

        public int EmployeId { get; set; }
        public string EmployeeName { get; set; }
        public string ContactNumber { get; set; }
        public string FatherName { get; set; }
        public string EmpMobileNo { get; set; }
        public string Nid { get; set; }
        public string Photo { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public int DistrictId { get; set; }
        public int UpazilaId { get; set; }
        public int FactoryId { get; set; }
        public int FactoryUnitId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int? SalaryGradeId { get; set; }
        public int? PresentSalary { get; set; }
        public int? StartingSalary { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual FactoryInfo Factory { get; set; }
        public virtual FactoryUnitInfo FactoryUnit { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
