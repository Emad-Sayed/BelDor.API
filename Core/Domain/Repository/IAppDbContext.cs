using Core.Domain.Entity;
using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.Entity.TicketEntites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Repository
{
    public interface IAppDbContext
    {
        public DbSet<AppUserEmployee> Employees { get; set; }
        public DbSet<AppUserManager> Managers { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<BranchDepartement> BranchDepartement { get; set; }



        public DbSet<TicketStatus> TicketStatus { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketClosed> TicketClosed { get; set; }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<BranchConfiguration> BranchConfigurations { get; set; }
    }
}
