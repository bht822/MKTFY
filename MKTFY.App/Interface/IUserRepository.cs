using System.Threading.Tasks;
using MKTFY.Models.ViewModels;

namespace MKTFY.App.Interface
{
    public interface IUserRepository
    {
       Task<AppUserVM> GetUserByEmail(string email); 
        
    }
}