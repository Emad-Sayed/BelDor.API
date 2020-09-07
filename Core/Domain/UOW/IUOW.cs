﻿using Core.Domain.Entity;
using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using Core.Domain.Entity.TicketEntites;
using Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.UOW
{

    public interface IUOW
    {
        IRepository<AppUserEmployee> Employees { get;  }

        IRepository<Branch> Branches { get; }
        IRepository<Departement> Departements { get; }
        IRepository<BranchDepartement> BranchDepartement { get; }

        IRepository<TicketStatus> TicketStatus { get; }
        IRepository<Ticket> Tickets { get; }
        IRepository<TicketClosed> TicketClosed { get; }

        IRepository<Configuration> Configurations { get; }

        int Compelete();
    }
}
