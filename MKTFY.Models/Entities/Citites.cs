using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MKTFY.Models.Entities
{
    public class Cities
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Provinces Province { get; set; }
        

    }
}