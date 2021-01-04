using System;

namespace MKTFY.Models.Entities
{
    public class FAQ
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime createdOn  { get; set; }    

        public DateTime updatedOn { get; set; }
        
    }
}