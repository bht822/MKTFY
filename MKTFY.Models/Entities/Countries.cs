using System.ComponentModel.DataAnnotations;

namespace MKTFY.Models.Entities
{
    public class Countries
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
    }
}