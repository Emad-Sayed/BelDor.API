using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Ticket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastrcture.Service
{
    public interface ITicketService
    {
        IResponse TicketRequest(TicketRequestModel ticketRequest, int VisitorId);
        IResponse GetTicket(TicketSearchModel search);
        IResponse EmployeeDailyTickets(TicketEmployeeSearchModel search);
        IResponse VisitorDailyTickets(TicketVisitorSearchModel search);
    }
}
