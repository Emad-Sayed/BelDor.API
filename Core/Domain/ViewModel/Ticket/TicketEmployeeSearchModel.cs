using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Ticket
{
    public class TicketEmployeeSearchModel : BaseSearch
    {
        public int branchDepartementId { get; set; }
        public List<int> statusIds { get; set; } = new List<int>();
    }
}
