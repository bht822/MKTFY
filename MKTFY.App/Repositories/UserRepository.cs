using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MKTFY.Models.ViewModels;
using MKTFY.App.Interface;

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
            var result = await _context.Users.FirstAsync(item => item.Email == email);
            var model = new AppUserVM(result);
            return model;
            
        }
    }
}