using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class EmployeeAttendance
    {
        public int EmployeeAttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public string DeviceEmpId { get; set; }
        public string EntryTime { get; set; }
        public string OutTime { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
