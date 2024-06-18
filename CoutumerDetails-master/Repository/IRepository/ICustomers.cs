using CoustomerDetails.Models;

namespace CoustomerDetails.Repository.IRepository
{
    public interface ICustomers
    {
       IEnumerable<CustomerModel> GetCustomers();
        Task<object> RegisterCustomer(CustomerModel customer);
    }
}
