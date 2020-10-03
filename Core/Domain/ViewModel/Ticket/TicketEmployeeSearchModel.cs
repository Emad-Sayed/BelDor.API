using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketEmployeeSearchModel : BaseSearch
    {
        public int branchDepartementId { get; set; }
        public List<int> statusIds { get; set; } = new List<int>();
        public List<int> ticketIds { get; set; } = new List<int>();
        public List<int> ticketNumbers { get; set; } = new List<int>();
    }
}
