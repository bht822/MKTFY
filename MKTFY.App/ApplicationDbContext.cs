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
        
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet <UserAddress> CustomerAddresses { get; set; }
        
    }
}