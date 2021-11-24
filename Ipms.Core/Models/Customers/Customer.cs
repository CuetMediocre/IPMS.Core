namespace Ipms.Core.Models.Customers
{
    public class Customer : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime LastModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
