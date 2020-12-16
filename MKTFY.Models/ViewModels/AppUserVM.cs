using System;
using MKTFY.Models.Entities;

namespace MKTFY.Models.ViewModels
{
    public class AppUserVM
    {
        public AppUserVM(AppUser src)
        {
            Id = src.Id;
            Email = src.Email;
            FirstName = src.FirstName;
            LastName = src.LastName;
        

            
        }
        public String Id { get; set; }      
        public string FirstName { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }
        
    }
}