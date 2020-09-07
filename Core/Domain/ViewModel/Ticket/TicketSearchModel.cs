using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketSearchModel : BaseSearch
    {
        public List<int> ticketIds { get; set; }
    }
}
