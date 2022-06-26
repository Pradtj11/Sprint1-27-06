using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceWebApi.Models
{
    public partial class TblLogin
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public int? IsAdmin { get; set; }
    }
}
