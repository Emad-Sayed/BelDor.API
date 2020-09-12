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
            (search.statusIds == null || search.statusIds.Contains(t.StatusId)))
            .Select(t => new TicketViewModel
            {
                Id = t.Id,
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
            });
            var count = query.Count();
            var data = query.OrderBy(c => c.TicketNumber).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public (IEnumerable<TicketViewModel>, int) VisitorDailyTicket(TicketVisitorSearchModel search)
        {
            var query = Context.Tickets.Where(t => t.CreatedAt.Date == search.specificDay.Value.Date &&
            t.CreatedById == search.visitorId &&
            (search.statusIds == null || search.statusIds.Contains(t.StatusId))&&
            (search.branchIds == null || search.branchIds.Contains(t.BranchDepartement.BranchId))&&
            (search.departementIds == null || search.departementIds.Contains(t.BranchDepartement.DepartementId)))
            .Select(t => new TicketViewModel
            {
                Id = t.Id,
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
            });
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }

        public (IEnumerable<TicketViewModel>, int) TicketFilter(TicketSearchModel search)
        {
            var query = Context.Tickets.Where(t => search.ticketIds == null || search.ticketIds.Contains(t.Id))
                .Select(t => new TicketViewModel
                {
                    Id = t.Id,
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
                });
            var count = query.Count();
            var data = query.OrderBy(c => c.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
    }
}
