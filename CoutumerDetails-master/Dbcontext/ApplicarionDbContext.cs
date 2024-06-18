using CoustomerDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace CoustomerDetails.Dbcontext
{
    public class ApplicarionDbContext : DbContext
    {
        public ApplicarionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
