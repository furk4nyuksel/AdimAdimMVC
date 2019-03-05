using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOrnek11CustomModelKonusu.Models
{
    public class AppUserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}