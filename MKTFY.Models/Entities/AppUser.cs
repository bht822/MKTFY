using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MKTFY.Models.Entities
{
    // AppUser to inherit from Identity User and custom data such as avatar etc to be extended here
    public class AppUser: IdentityUser
    {       
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // [Required]

        // public bool ToS { get; set; }

        // [Required]
        // public Cities city { get; set; }

        public DateTime lastLogin { get; set; }


        public ProfilePhoto profilePhoto { get; set; }     // if more are desired , change it to ICollection

        public ICollection<Listings> myListings { get; set; }


    }
}