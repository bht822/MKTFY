using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MKTFY.Models.Entities
{
    public class Listings
    {
        
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string title { get; set; }

        [Required]
        [MaxLength(300)]
        public string description { get; set; }

        [Required]
        public double price { get; set; }
    
        [Required]

        public int city { get; set; }
         [Required]

        public ListingStatus listingStatus { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }

        public ICollection<ListingPhoto> ListingPhoto { get; set; }

        public bool IsArchived { get; set; }



    }
}