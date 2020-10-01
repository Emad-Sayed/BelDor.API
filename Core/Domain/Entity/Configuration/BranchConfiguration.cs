using Core.Domain.Entity.LocationEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class BranchConfiguration : BaseEntity
    {
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
