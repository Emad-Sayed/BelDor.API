using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketVisitorSearchModel : BaseSearch
    {
        public int visitorId { get; set; }
        public DateTime? specificDay { get; set; }
        public List<int> ticketIds { get; set; } = new List<int>();
        public List<int> statusIds { get; set; } = new List<int>();
        public List<int> branchIds { get; set; } = new List<int>();
        public List<int> departementIds { get; set; } = new List<int>();
    }
}
