using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketVisitorSearchModel : BaseSearch
    {
        public int visitorId { get; set; }
        public DateTime? specificDay { get; set; }
        public List<int> ticketIds { get; set; }
        public List<int> statusIds { get; set; }
        public List<int> branchIds { get; set; }
        public List<int> departementIds { get; set; }
    }
}
