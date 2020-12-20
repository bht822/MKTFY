using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MKTFY.Models.ViewModels;
using MKTFY.App.Interface;
using System.Collections.Generic;

namespace MKTFY.App.Repositories
{
    public class UserRepository: IUserRepository 
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            
        }

        public async Task<AppUserVM> GetUserByEmail(string email)
        {
            List<string> a = new List<string>();
            var result = await _context.Users.FirstAsync(item => item.Email == email);
            var model = new AppUserVM(result);
            return model;
            
        }
    }
}