using System;
using MKTFY.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;


namespace MKTFY.Models.Entities
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public String UserName { get; set; }
        
    }
}