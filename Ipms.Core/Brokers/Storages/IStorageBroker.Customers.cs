using Ipms.Core.Models.Customers;

namespace Ipms.Core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        IQueryable<Customer> SelectAllCustomers();
    }
}
