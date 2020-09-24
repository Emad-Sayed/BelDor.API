using Core.Domain.Entity;
using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.Entity.TicketEntites;
using Core.Domain.Repository;
using Core.Domain.UOW;
using Domain.Context;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UOW : IUOW
    {
        AppDbContext context;
        public UOW(AppDbContext _context)
        {
            context = _context;

            Employees = new Repository<AppUserEmployee>(_context);

            Branches = new BranchRepository(_context);
            Departements = new DepartementRepository(_context);
            BranchDepartement = new Repository<BranchDepartement>(_context);

            TicketStatus = new Repository<TicketStatus>(_context);
            Tickets = new TicketRepository(_context);
            TicketClosed = new Repository<TicketClosed>(_context);

            Configurations = new Repository<Configuration>(_context);

        }
        public IRepository<AppUserEmployee> Employees { get; }

        public IBranchRepository Branches { get; }
        public IDepartementRepository Departements { get; }
        public IRepository<BranchDepartement> BranchDepartement { get; }

        public IRepository<TicketStatus> TicketStatus { get; }
        public ITicketRepository Tickets { get; }
        public IRepository<TicketClosed> TicketClosed { get; }

        public IRepository<Configuration> Configurations { get; }


        public int Compelete()
        {
            return context.SaveChanges();
        }

    }
}
