using Microsoft.EntityFrameworkCore;
using MKTFY.Models.Entities;


namespace MKTFY.App
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
        
    }
}