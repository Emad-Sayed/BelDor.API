using Core.Domain.Entity.TicketEntites;
using Core.Domain.Repository;
using Core.Domain.ViewModel.Ticket;
using Domain.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext _Context) : base(_Context)
        {
        }
        public (IEnumerable<TicketViewModel>, int) TicketFilter(TicketSearchModel search)
        {
            var query = Context.Tickets.Where(t => search.ticketIds == null || search.ticketIds.Contains(t.Id))
                .Select(t => new TicketViewModel
                {
                    Id = t.Id,
                    TicketNumber = t.TicketNumber,
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
