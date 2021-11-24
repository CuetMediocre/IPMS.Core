using Ipms.Core.Models.Customers;
using Microsoft.EntityFrameworkCore;

namespace Ipms.Core.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Customer> Customers { get; set; }

        public IQueryable<Customer> SelectAllCustomers() => this.Customers;
    }
}
