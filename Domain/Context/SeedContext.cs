using Core.Domain.Entity;
using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.Entity.TicketEntites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public static class SeedContext
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region Access
            builder.Entity<IdentityRole<int>>().HasData(
            new IdentityRole<int>
            {
                Id = 1,Name = "ADMIN",NormalizedName = "ADMIN",
            },
            new IdentityRole<int>
            {
                Id = 2,Name = "EMPLOYEE",NormalizedName = "EMPLOYEE",
            },
             new IdentityRole<int>
             {
                 Id = 3,Name = "VISITOR",NormalizedName = "VISITOR",
             },
             new IdentityRole<int>
             {
                 Id = 4,Name = "MANAGER",NormalizedName = "MANAGER",
             });
            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = 1,
                UserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admindemo"),
                SecurityStamp = string.Empty
            },
            new AppUser
            {
                Id = 2,
                UserName = "EMPLOYEE",
                Email = "employee@employee.com",
                NormalizedEmail = "employee@employee.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "employeedemo"),
                SecurityStamp = string.Empty
            },
            new AppUser
            {
                Id = 3,
                UserName = "VISITOR",
                Email = "visitor@visitor.com",
                NormalizedEmail = "visitor@visitor.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "visitordemo"),
                SecurityStamp = string.Empty
            },
            new AppUser
            {
                Id = 4,
                UserName = "MANAGER",
                Email = "manager@manager.com",
                NormalizedEmail = "manager@manager.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "managerdemo"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int>
            {
                RoleId = 1,UserId = 1
            },
            new IdentityUserRole<int>
            {
                RoleId = 2,UserId = 2
            },
            new IdentityUserRole<int>
            {
                RoleId = 3,UserId = 3
            },
            new IdentityUserRole<int>
            {
                RoleId = 4,UserId = 4
            });
            #endregion
            #region Location
            builder.Entity<Branch>().HasData(
            new Branch
            {
                Id = 1,NameEN = "Cairo",NameAR = "القاهرة",AddressAR = "القاهرة",AddressEN = "Cairo",Phone = "010",
            },
            new Branch
            {Id = 2, NameEN = "Alexandria",NameAR = "الاسكندرية", AddressAR = "الاسكندرية",AddressEN = "Alexandria",Phone = "011",});
            builder.Entity<Departement>().HasData(
            new Departement
            {
                Id = 1,NameEN = "IT",NameAR = "نظم المعلومات",
            },
            new Departement
            {
                Id = 2,NameEN = "Customer Service",NameAR = "الدعم الفني",
            },
            new Departement
            {
                Id = 3,NameEN = "Complains",NameAR = "الشكاوي",
            });
            builder.Entity<BranchDepartement>().HasData(
            new BranchDepartement
            {
            Id = 1,BranchId=1,DepartementId=1
            },
            new BranchDepartement
            {
                Id = 2,BranchId = 1,DepartementId = 2
            },
            new BranchDepartement
            {
                Id = 3,BranchId = 1,DepartementId = 3
            },
            new BranchDepartement
            {
                Id = 4,BranchId = 2,DepartementId = 2
            },
            new BranchDepartement
            {
                Id = 5, BranchId = 2,DepartementId = 3
            });
            builder.Entity<AppUserEmployee>().HasData(
            new AppUserEmployee
            {
                Id = 1,
                BranchDepartementId = 1,
                UserId = 2
            });

            builder.Entity<AppUserManager>().HasData(
            new AppUserManager        
            {
                Id = 2,
                BranchId = 3,
                UserId = 4
            });
            #endregion
            #region Ticket
            builder.Entity<TicketStatus>().HasData(
            new TicketStatus { Id = 1, NameEN = "Waiting" ,NameAR="انتظار" },
            new TicketStatus { Id = 2, NameEN = "Serving" ,NameAR="تخدم"},
            new TicketStatus { Id = 3, NameEN = "Closed", NameAR = "مغلقة" },
            new TicketStatus { Id = 4, NameEN = "Missed", NameAR = "تخلفت" });
            #endregion
            #region Configuration
            builder.Entity<Configuration>().HasData(
                new Configuration { Id = 1, StartReservationTime = TimeSpan.Parse("7:30"), EndReservationTime = TimeSpan.Parse("18:30") });
            #endregion
        }
    }
}
