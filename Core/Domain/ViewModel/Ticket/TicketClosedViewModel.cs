using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketClosedViewModel : TicketViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Information { get; set; }
    }
}
