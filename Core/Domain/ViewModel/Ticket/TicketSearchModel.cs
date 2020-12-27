using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketSearchModel : BaseSearch
    {
        public List<int> ticketIds { get; set; } = new List<int>();
        public List<int> employeesIds { get; set; } = new List<int>();
        public List<int> statusIds { get; set; } = new List<int>();
        public List<int> activeQueueIds { get; set; } = new List<int>();
        public DateTime? SpecificDate { get; set; }
    }
}
