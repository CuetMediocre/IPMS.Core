using System;
using System.Collections.Generic;

namespace Ipms.Core.Data
{
    public partial class CompanyInformation
    {
        public int Id { get; set; }
        public string ComNameBengla { get; set; }
        public string ComNameEnglish { get; set; }
        public string CompanyAddress { get; set; }
        public string OwnerName { get; set; }
        public string OwnerName2 { get; set; }
        public string MobileNo1 { get; set; }
        public string MobileNo2 { get; set; }
        public string Description { get; set; }
        public string Fax { get; set; }
        public string CompanyLogo { get; set; }
        public string OwnerPhoto1 { get; set; }
        public string OwnerPhoto2 { get; set; }
        public string WebAddress { get; set; }
        public string Email { get; set; }
        public string TradeLicense { get; set; }
    }
}
