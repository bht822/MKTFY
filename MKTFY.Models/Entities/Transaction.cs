using System;

namespace MKTFY.Models.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public Listings Asscociated_listing { get; set; }

        public AppUser buyer { get; set; }

        public AppUser seller { get; set; }

        public DateTime createdOn { get; set; }
        public DateTime complete { get; set; }
    }
}