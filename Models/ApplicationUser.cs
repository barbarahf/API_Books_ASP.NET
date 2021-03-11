using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibros.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    }
}
