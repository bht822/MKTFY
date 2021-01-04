using MKTFY.Models.Entities;
using MKTFY.Models.ViewModels;

namespace MKTFY.Api.Controllers
{
    public class RegisterResponseVM
    {
        public RegisterResponseVM(AppUserVM user)
        {
            User = user;
            
        }
        public AppUserVM User { get; set; }

    }
}