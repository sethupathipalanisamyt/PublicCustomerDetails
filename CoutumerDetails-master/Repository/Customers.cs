using CoustomerDetails.Dbcontext;
using CoustomerDetails.Models;
using CoustomerDetails.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CoustomerDetails.Repository
{
    public class Customers : ICustomers
    {
        private readonly ApplicarionDbContext _context;

        public Customers(ApplicarionDbContext applicarionDbContext)
        {
            _context= applicarionDbContext;
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            try
            {
                IEnumerable<CustomerModel> Customers =_context.Customers.ToList();
                return Customers;

            }catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);    
            }
        }


        public async Task<object> RegisterCustomer(CustomerModel customer)
        {
            try
            {
                var response = await _context.Customers.AddAsync(customer);
                _context.SaveChanges();
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
