using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class LabourCostInfo
    {
        public int LabourCostId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public string CostType { get; set; }
        public double? Amount { get; set; }
    }
}
