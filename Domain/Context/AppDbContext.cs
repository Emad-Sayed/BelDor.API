using Core.Domain.Entity;
using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.Entity.TicketEntites;
using Core.Domain.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //foreach (var relationship in builder.Model.GetEntityTypes().Where(e => !e.IsOwned()).SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            builder.Seed();
        }
    }
}
