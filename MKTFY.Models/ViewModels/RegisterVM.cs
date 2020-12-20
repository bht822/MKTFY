using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MKTFY.Api.Controllers
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        // [Required]
        // public IdentityRole role { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


    }
}