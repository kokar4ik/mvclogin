using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace mvclogin.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } // Имя
        public string LastName { get; set; }  // Фамилия
        public string MiddleName { get; set; }
    }
}
