using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.LocationEntites
{
    public class BranchDepartement : BaseEntity
    {
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }
}
