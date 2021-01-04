using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MKTFY.Models.Entities;

namespace MKTFY.App
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Listings> Listings { get; set; }
        public DbSet <Transaction> Transactions{ get; set; }
        

    }
}