using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Ticket;
using Core.Infrastrcture.Service;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Entity.TicketEntites;

namespace Infrastructure.Service.TicketBusinees
{
    public class TicketService : ITicketService
    {
        public readonly IUOW UOW;
        public readonly IResponse response;
        public TicketService(IUOW uow_, IResponse response_)
        {
            UOW = uow_;
            response = response_;
        }




        public IResponse GetTicket(TicketSearchModel search)
        {
            var (result, totalRows) = UOW.Tickets.TicketFilter(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }

        public IResponse TicketRequest(TicketRequestModel ticketRequest,int VisitorId)
        {
            var selectedBranchDepartement = UOW.BranchDepartement.SingleOrDefault(bd => bd.BranchId == ticketRequest.BranchId
            && bd.DepartementId == ticketRequest.DepartementId);
            var TimeOfNow = DateTime.Now.TimeOfDay;
            var Config = UOW.Configurations.FirstOrDefault(c => true);

            //CHECK IF HAS TICKET BEFORE
            var SelectedTicket = UOW.Tickets.FirstOrDefault(t => t.BranchDepartementId == selectedBranchDepartement.Id
            && t.CreatedById == VisitorId && t.StatusId != 3 && t.CreatedAt.Date == DateTime.Now.Date);
            if (SelectedTicket != null)
            {
                response.status = false;
                response.error_AR = "يوجد حجز مسبق في نفس اليوم";
                response.error_EN = "There is already already ticket Requested";
                response.data = SelectedTicket;
                return response;
            }

            if (Config.StartReservationTime > TimeOfNow || Config.EndReservationTime < TimeOfNow)
            {
                response.status = false;
                response.error_AR = "لا يمكن الحجز في هذا الموعد";
                response.error_EN = "Time not available for Reservation";
                response.data = null;
                return response;
            }

            var CurrentNumber = UOW.Tickets.Find(t => t.BranchDepartementId == selectedBranchDepartement.Id
                                    && t.CreatedAt.Date == DateTime.Now.Date)
                                    .Select(t => t.TicketNumber).DefaultIfEmpty(0).Max();
            var newTicket = new Ticket();
            newTicket.TicketNumber = CurrentNumber + 1;
            newTicket.CreatedById = VisitorId;
            newTicket.BranchDepartementId = selectedBranchDepartement.Id;
            newTicket.StatusId = 1;
            UOW.Tickets.Add(newTicket);
            UOW.Compelete();
            response.data = newTicket;
            return response;
        }
        public IResponse EmployeeDailyTickets(TicketEmployeeSearchModel search)
        {
            var (result, totalRows) = UOW.Tickets.EmployeeDailyTicket(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }
        public IResponse VisitorDailyTickets(TicketVisitorSearchModel search)
        {
            search.specificDay = search.specificDay ?? DateTime.Now;
            var (result, totalRows) = UOW.Tickets.VisitorDailyTicket(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }
    }
}
