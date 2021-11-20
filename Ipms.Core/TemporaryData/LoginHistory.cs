using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class LoginHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginDate { get; set; }
        public TimeSpan? LoginTime { get; set; }
        public TimeSpan? LogoutTime { get; set; }
    }
}
