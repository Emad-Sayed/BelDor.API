using Core.Domain.Entity.LocationEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Access
{
    public class AppUserManager : BaseEntity
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
