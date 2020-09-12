using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; }
        public int VisitorId { get; set; }
        public string VisitorName { get; set; }
        public int StatusId { get; set; }
        public string StatusNameAR { get; set; }
        public string StatusNameEN { get; set; }
        public int BranchId { get; set; }
        public string BranchNameAR { get; set; }
        public string BranchNameEN { get; set; }
        public int DepartementId { get; set; }
        public string DepartementNameAR { get; set; }
        public string DepartementNameEN { get; set; }
    }
}
