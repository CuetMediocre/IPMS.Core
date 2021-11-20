using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class UserRoll
    {
        public UserRoll()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesciption { get; set; }
        public bool? RoleIsActive { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
