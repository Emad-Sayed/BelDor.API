using Core.Domain.Entity.LocationEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Access
{
    public class AppUserEmployee :BaseEntity
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int BranchDepartementId { get; set; }
        public BranchDepartement BranchDepartement { get; set; }
    }
}
