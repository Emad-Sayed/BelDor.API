using Core.Domain.Entity.TicketEntites;
using Core.Domain.Repository;
using Core.Domain.ViewModel.Ticket;
using Domain.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Core.Helpers;

namespace Domain.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<TicketViewModel>, int) EmployeeDailyTicket(TicketEmployeeSearchModel search)
        {
            var DateOfNow = DateTime.Now.AddServerTimeHours().Date;
            var query = Context.Tickets.Where(t => t.CreatedAt.Date == DateOfNow &&
            t.BranchDepartementId == search.branchDepartementId &&
            (search.statusIds.Count == 0 || search.statusIds.Contains(t.StatusId)) &&
            (search.ticketIds.Count == 0 || search.ticketIds.Contains(t.Id)) &&
            (search.ticketNumbers.Count == 0 || search.ticketNumbers.Contains(t.TicketNumber)))
            .Select(t => new TicketViewModel
            {
                Id = t.Id,
                CreateTime = t.CreatedAt,
                TicketNumber = t.TicketNumber,
                VisitorId = t.CreatedById.Value,
                VisitorName = t.CreatedBy.UserName,
                BranchId = t.BranchDepartement.BranchId,
                BranchNameAR = t.BranchDepartement.Branch.NameAR,
                BranchNameEN = t.BranchDepartement.Branch.NameEN,
                DepartementId = t.BranchDepartement.DepartementId,
                DepartementNameAR = t.BranchDepartement.Departement.NameAR,
                DepartementNameEN = t.BranchDepartement.Departement.NameEN,
                StatusId = t.StatusId,
                StatusNameAR = t.Status.NameAR,
                StatusNameEN = t.Status.NameEN,
                BranchDepartementId = t.BranchDepartementId

            });
            var count = query.Count();
            var data = query.OrderBy(c => c.TicketNumber).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public (IEnumerable<TicketViewModel>, int) VisitorDailyTicket(TicketVisitorSearchModel search)
        {
            var query = Context.Tickets.Where(t => t.CreatedAt.Date == search.specificDay.Value.Date &&
            t.CreatedById == search.visitorId &&
            (search.ticketIds.Count == 0 || search.ticketIds.Contains(t.Id)) &&
            (search.statusIds.Count == 0 || search.statusIds.Contains(t.StatusId)) &&
            (search.branchIds.Count == 0 || search.branchIds.Contains(t.BranchDepartement.BranchId)) &&
            (search.departementIds.Count == 0 || search.departementIds.Contains(t.BranchDepartement.DepartementId)))
            .Select(t => new TicketViewModel
            {
                Id = t.Id,
                CreateTime = t.CreatedAt,
                TicketNumber = t.TicketNumber,
                VisitorId = t.CreatedById.Value,
                VisitorName = t.CreatedBy.UserName,
                BranchId = t.BranchDepartement.BranchId,
                BranchNameAR = t.BranchDepartement.Branch.NameAR,
                BranchNameEN = t.BranchDepartement.Branch.NameEN,
                DepartementId = t.BranchDepartement.DepartementId,
                DepartementNameAR = t.BranchDepartement.Departement.NameAR,
                DepartementNameEN = t.BranchDepartement.Departement.NameEN,
                StatusId = t.StatusId,
                StatusNameAR = t.Status.NameAR,
                StatusNameEN = t.Status.NameEN,
                BranchDepartementId = t.BranchDepartementId
            });
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }

        public (IEnumerable<TicketViewModel>, int) TicketFilter(TicketSearchModel search)
        {
            var query = Context.Tickets.Where(t => 
            (search.ticketIds.Count == 0 || search.ticketIds.Contains(t.Id)) &&
            (search.employeesIds.Count == 0 || search.employeesIds.Contains(t.UpdatedById.Value)) &&
            (search.statusIds.Count == 0 || search.statusIds.Contains(t.StatusId)) &&
            (search.SpecificDate == null || search.SpecificDate.Value.Date == t.CreatedAt.Date))
                .Select(t => new TicketViewModel
                {
                    Id = t.Id,
                    CreateTime = t.CreatedAt,
                    TicketNumber = t.TicketNumber,
                    VisitorId = t.CreatedById.Value,
                    VisitorName = t.CreatedBy.UserName,
                    BranchId = t.BranchDepartement.BranchId,
                    BranchNameAR = t.BranchDepartement.Branch.NameAR,
                    BranchNameEN = t.BranchDepartement.Branch.NameEN,
                    DepartementId = t.BranchDepartement.DepartementId,
                    DepartementNameAR = t.BranchDepartement.Departement.NameAR,
                    DepartementNameEN = t.BranchDepartement.Departement.NameEN,
                    StatusId = t.StatusId,
                    StatusNameAR = t.Status.NameAR,
                    StatusNameEN = t.Status.NameEN,
                    BranchDepartementId = t.BranchDepartementId
                });
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public TicketClosedViewModel ClosedTicketInfo(int ticketId)
        {
            var query = Context.TicketClosed.Where(t => t.TicketId == ticketId)
                .Select(t => new TicketClosedViewModel
                {
                    Id = t.Id,
                    CreateTime = t.Ticket.CreatedAt,
                    TicketNumber = t.Ticket.TicketNumber,
                    VisitorId = t.Ticket.CreatedById.Value,
                    VisitorName = t.Ticket.CreatedBy.UserName,
                    EmployeeName = t.CreatedBy.UserName,
                    EmployeeId = t.CreatedById.Value,
                    Information = t.Information,
                    BranchId = t.Ticket.BranchDepartement.BranchId,
                    BranchNameAR = t.Ticket.BranchDepartement.Branch.NameAR,
                    BranchNameEN = t.Ticket.BranchDepartement.Branch.NameEN,
                    DepartementId = t.Ticket.BranchDepartement.DepartementId,
                    DepartementNameAR = t.Ticket.BranchDepartement.Departement.NameAR,
                    DepartementNameEN = t.Ticket.BranchDepartement.Departement.NameEN,
                    StatusId = t.Ticket.StatusId,
                    StatusNameAR = t.Ticket.Status.NameAR,
                    StatusNameEN = t.Ticket.Status.NameEN,
                    BranchDepartementId = t.Ticket.BranchDepartementId
                });

            return query.SingleOrDefault();
        }
    }
}
