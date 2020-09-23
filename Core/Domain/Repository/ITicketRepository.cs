using Core.Domain.Entity.TicketEntites;
using Core.Domain.ViewModel.Ticket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        (IEnumerable<TicketViewModel>, int) TicketFilter(TicketSearchModel search);
        (IEnumerable<TicketViewModel>, int) EmployeeDailyTicket(TicketEmployeeSearchModel search);
        (IEnumerable<TicketViewModel>, int) VisitorDailyTicket(TicketVisitorSearchModel search);
        TicketClosedViewModel ClosedTicketInfo(int ticketId);
    }
}
