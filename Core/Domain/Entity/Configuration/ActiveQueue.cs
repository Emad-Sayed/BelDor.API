using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class ActiveQueue : BaseEntity
    {
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        public bool isActive { get; set; } = true;
    }
}
