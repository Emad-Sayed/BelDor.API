using Core.Domain.Entity.LocationEntites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Access
{
    public class AppUser : IdentityUser<int>
    {
        public string Phone { get; set; }
    }
}
