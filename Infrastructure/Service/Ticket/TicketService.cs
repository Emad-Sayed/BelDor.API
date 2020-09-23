using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Ticket;
using Core.Infrastrcture.Service;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Entity.TicketEntites;
using Core.Helpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using Core.Infrastrcture.Notification.SignalR;

namespace Infrastructure.Service.TicketBusinees
{
    public class TicketService : ITicketService
    {
        public readonly IUOW UOW;
        public readonly IResponse response;
        public INotificationService notification;
        public TicketService(IUOW uow_, IResponse response_, INotificationService notification_)
        {
            UOW = uow_;
            response = response_;
            notification = notification_;
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
        public IResponse TicketRequest(TicketRequestModel ticketRequest, int VisitorId)
        {

            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var TimeOfNow = ServerDateTime.TimeOfDay;
            var DateOfNow = ServerDateTime.Date;

            var selectedBranchDepartement = UOW.BranchDepartement.SingleOrDefault(bd => bd.BranchId == ticketRequest.BranchId
            && bd.DepartementId == ticketRequest.DepartementId);

            var Config = UOW.Configurations.FirstOrDefault(c => true);


            if (Config.StartReservationTime > TimeOfNow || Config.EndReservationTime < TimeOfNow)
            {
                response.status = false;
                response.error_AR = "لا يمكن الحجز في هذا الموعد";
                response.error_EN = "Time not available for Reservation";
                response.data = null;
                return response;
            }


            //CHECK IF HAS TICKET BEFORE
            var SelectedTicket = UOW.Tickets.FirstOrDefault(t => t.BranchDepartementId == selectedBranchDepartement.Id
            && t.CreatedById == VisitorId && t.StatusId != 3 && t.CreatedAt.Date == DateOfNow);
            if (SelectedTicket != null)
            {
                response.status = false;
                response.error_AR = "يوجد حجز مسبق في نفس اليوم";
                response.error_EN = "There is already ticket Requested";
                response.data = VisitorDailyTickets(new TicketVisitorSearchModel()
                { ticketIds = { SelectedTicket.Id }, visitorId = SelectedTicket.CreatedById.Value }).data;
                return response;
            }

            var CurrentNumber = UOW.Tickets.Find(t => t.BranchDepartementId == selectedBranchDepartement.Id
                                    && t.CreatedAt.Date == DateOfNow)
                                    .Select(t => t.TicketNumber).DefaultIfEmpty(0).Max();
            var newTicket = new Ticket();
            newTicket.TicketNumber = CurrentNumber + 1;
            newTicket.CreatedById = VisitorId;
            newTicket.BranchDepartementId = selectedBranchDepartement.Id;
            newTicket.StatusId = 1;
            UOW.Tickets.Add(newTicket);
            UOW.Compelete();
            #region notification
            notification.NotifyNewEvent("E_" + newTicket.BranchDepartementId,
                new { newTicket.Id, newTicket.TicketNumber, newTicket.CreatedById.Value });
            #endregion
            //Notification Employees
            response.data = VisitorDailyTickets(new TicketVisitorSearchModel()
            { ticketIds = { newTicket.Id }, visitorId = newTicket.CreatedById.Value }).data;
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
            search.specificDay = search.specificDay ?? DateTime.Now.AddServerTimeHours().Date;
            var (result, totalRows) = UOW.Tickets.VisitorDailyTicket(search);
            var dataListed = result.ToList();
            foreach (var ticket in dataListed)
            {
                ticket.CurrentNumber = UOW.Tickets.Find(t => t.BranchDepartementId == ticket.BranchDepartementId
                                     && t.CreatedAt.Date == search.specificDay && t.StatusId == 2)
                                    .Select(t => t.TicketNumber).DefaultIfEmpty(0).Max();
            }
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = dataListed;
            return response;
        }
        public IResponse ServeTicket(TicketServingModel model)
        {
            //as3'r ticket waiting
            //arbot el ticket deh bel visitor
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var TimeOfNow = ServerDateTime.TimeOfDay;
            var DateOfNow = ServerDateTime.Date;
            var Config = UOW.Configurations.FirstOrDefault(c => true);
            if (Config.StartReservationTime > TimeOfNow || Config.EndReservationTime < TimeOfNow)
            {
                response.status = false;
                response.error_AR = "لا يمكن الخدمة في هذا الموعد";
                response.error_EN = "Time not available for Reservation";
                response.data = null;
                return response;
            }
            var servingTicket = UOW.Tickets.SingleOrDefault(t => t.BranchDepartementId == model.BranchDepartementId
            && t.CreatedAt.Date == DateOfNow && t.StatusId == 2 && t.UpdatedById == model.EmployeeId);
            if (servingTicket != null)
            {
                response.data = servingTicket;
                return response;
            }
            var currentTicket = UOW.Tickets.Find(t => t.BranchDepartementId == model.BranchDepartementId
                        && t.CreatedAt.Date == DateOfNow && t.StatusId == 1)
                        .OrderBy(t => t.TicketNumber).FirstOrDefault();
            if (currentTicket == null)
            {
                response.status = false;
                response.error_AR = "لا يوجد تكتات منتطرة";
                response.error_EN = "There are no waiting tickets";
                response.data = null;
                return response;
            }
            currentTicket.StatusId = 2;
            currentTicket.UpdatedById = model.EmployeeId;
            UOW.Compelete();
            #region notification
            notification.NotifyNewEvent("V_" + currentTicket.BranchDepartementId,
                new { currentTicket.Id, currentTicket.BranchDepartementId, currentTicket.TicketNumber, currentTicket.CreatedById.Value });
            #endregion
            response.data = currentTicket;
            return response;
        }
        #region Closed
        public IResponse CloseServedTicket(TicketClosedModel model)
        {
            //smallest ticket m3molha serve mn el employee dh
            var ServerDateTime = DateTime.Now.AddServerTimeHours().Date;
            var servingTicket = UOW.Tickets.SingleOrDefault(t => t.BranchDepartementId == model.BranchDepartementId
                                && t.CreatedAt.Date == ServerDateTime && t.StatusId == 2 && t.UpdatedById == model.EmployeeId);
            if (servingTicket == null)
            {
                response.status = false;
                response.error_AR = "لا يوجد تكت تخدم منك";
                response.error_EN = "There is no serving ticket by you";
                response.data = null;
                return response;
            }
            servingTicket.StatusId = 3;
            UOW.TicketClosed.Add(new TicketClosed { TicketId = servingTicket.Id, CreatedById = model.EmployeeId, Information = model.Information });
            UOW.Compelete();
            response.data = servingTicket;
            return response;
        }

        public IResponse ClosedTicketInfo(int id)
        {
            var data = UOW.Tickets.ClosedTicketInfo(id);
            if (data == null)
                response.status = false;
            else
                response.data = data;
            return response;
        }
        #endregion
        #region Missed
        public IResponse SetTicketAsMissed(TicketClosedModel model)
        {
            //smallest ticket m3molha serve mn el employee dh
            var ServerDateTime = DateTime.Now.AddServerTimeHours().Date;
            var servingTicket = UOW.Tickets.SingleOrDefault(t => t.BranchDepartementId == model.BranchDepartementId
                                && t.CreatedAt.Date == ServerDateTime && t.StatusId == 2 && t.UpdatedById == model.EmployeeId);
            if (servingTicket == null)
            {
                response.status = false;
                response.error_AR = "لا يوجد تكت تخدم منك";
                response.error_EN = "There is no serving ticket by you";
                response.data = null;
                return response;
            }
            servingTicket.StatusId = 4; // set it as Missed
            UOW.Compelete();
            response.data = servingTicket;
            return response;
        }
        public IResponse ServeMissedTicket(TicketServeMissedModel model)
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            var TimeOfNow = ServerDateTime.TimeOfDay;
            var DateOfNow = ServerDateTime.Date;
            var Config = UOW.Configurations.FirstOrDefault(c => true);
            if (Config.StartReservationTime > TimeOfNow || Config.EndReservationTime < TimeOfNow)
            {
                response.status = false;
                response.error_AR = "لا يمكن الخدمة في هذا الموعد";
                response.error_EN = "Time not available for Reservation";
                response.data = null;
                return response;
            }
            var servingTicket = UOW.Tickets.SingleOrDefault(t => t.BranchDepartementId == model.BranchDepartementId
            && t.CreatedAt.Date == DateOfNow && t.StatusId == 2 && t.UpdatedById == model.EmployeeId);
            if (servingTicket != null)
            {
                response.data = servingTicket;
                return response;
            }
            var misseddTicket = UOW.Tickets.SingleOrDefault(t => t.Id == model.TicketId && t.BranchDepartementId == model.BranchDepartementId
            && t.CreatedAt.Date == DateOfNow && t.StatusId == 4);
            if (misseddTicket == null)
            {
                response.status = false;
                response.error_AR = "التكت لم تتخلف";
                response.error_EN = "Ticket Not Missed";
                response.data = null;
                return response;
            }
            misseddTicket.StatusId = 2;
            misseddTicket.UpdatedById = model.EmployeeId;
            UOW.Compelete();
            return response;
        }
        #endregion

    }
}
