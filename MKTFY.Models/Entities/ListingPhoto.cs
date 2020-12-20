using System.ComponentModel.DataAnnotations.Schema;

namespace MKTFY.Models.Entities
{[
    Table("ListingPhotos")]
    public class ListingPhoto
    {
        public int  Id { get; set; }

        public string Url { get; set; }

        public string PublicId { get; set; }
        public bool isMain { get; set; }

    }
}