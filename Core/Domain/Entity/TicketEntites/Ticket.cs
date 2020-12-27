using Core.Domain.Entity.Access;
using Core.Domain.Entity.LocationEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Domain.Entity.TicketEntites
{
    public class Ticket : BaseEntity
    {
        public int TicketNumber { get; set; }
        public int StatusId { get; set; }
        public TicketStatus Status { get; set; }
        public int BranchDepartementId { get; set; }
        public BranchDepartement BranchDepartement { get; set; }
        public int ActiveQueueId { get; set; }
        public ActiveQueue ActiveQueue { get; set; }
    }
}
