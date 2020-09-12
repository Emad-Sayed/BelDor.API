using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Lookups.Branch
{
    public class BranchCreateModel
    {
        public string NameEN { get; set; }
        public string NameAR { get; set; }
        public string AddressEN { get; set; }
        public string AddressAR { get; set; }
        public string Phone { get; set; }
        public List<int> DeptIds { get; set; }
    }
}
