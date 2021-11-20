using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class BankName
    {
        public int Id { get; set; }
        public string BankName1 { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string BankContactNo { get; set; }
    }
}
