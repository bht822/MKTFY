using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MKTFY.Models.Entities
{
    public class Provinces
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProvinceName { get; set; }
        [Required]
        [MaxLength(2)] // Only two for North america 
        public string Abbreviation { get; set; }

        public Countries country { get; set; }

    }
}