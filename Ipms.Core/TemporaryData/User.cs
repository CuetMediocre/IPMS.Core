using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int EmployeId { get; set; }
        public int RoleId { get; set; }

        public virtual EmployeeInformation Employe { get; set; }
        public virtual UserRoll Role { get; set; }
    }
}
