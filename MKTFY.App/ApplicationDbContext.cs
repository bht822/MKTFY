using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MKTFY.Models.Entities;


namespace MKTFY.App
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet <CustomerAddress> CustomerAddresses { get; set; }
        
    }
}