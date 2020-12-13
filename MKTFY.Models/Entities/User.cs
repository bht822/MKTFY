using System;
using MKTFY.App;

namespace MKTFY.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public String first_name { get; set; }

        public String last_name { get; set; }
        public String email { get; set; }
        public int Phone_Number { get; set; }
        public String City { get; set; }
        public Boolean tos { get; set; }
        public Boolean verified { get; set; }

        public int MyProperty { get; set; }

        public UserAddress PrimaryAddress { get; set; }
        
    }
}