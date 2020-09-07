using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.LocationEntites
{
    public class Branch : BaseEntity
    {
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public string AddressAR { get; set; }
        public string AddressEN { get; set; }
        public string Phone { get; set; }
    }
}
