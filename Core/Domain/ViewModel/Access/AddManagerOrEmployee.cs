using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Access
{
    public class AddManagerOrEmployee
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string RoleName { get; set; }
        public int ManagerBranchId { get; set; }
        public int EmployeeBranchDepartementId { get; set; }
    }
}
