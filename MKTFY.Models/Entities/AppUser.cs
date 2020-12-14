using System;
using Microsoft.AspNetCore.Identity;
using MKTFY.App;
using System.ComponentModel.DataAnnotations;

namespace MKTFY.Models.Entities
{
    // AppUser to inherit from Identity User and custom data such as avatar etc to be extended here
    public class AppUser: IdentityUser
    {       
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}