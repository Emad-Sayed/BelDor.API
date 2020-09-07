using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class Configuration : BaseEntity
    {
        public TimeSpan StartReservationTime { get; set; }
        public TimeSpan EndReservationTime { get; set; }
    }
}
