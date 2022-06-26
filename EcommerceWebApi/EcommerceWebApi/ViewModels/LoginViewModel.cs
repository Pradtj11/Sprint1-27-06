using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApi.ViewModels
{
    public class LoginViewModel
    {
        public string EmailId { get; set; }
        public string Password { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Gender { get; set; }
    }
}
