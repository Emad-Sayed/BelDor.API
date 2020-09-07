using Core.Domain.Entity.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Domain.Entity.TicketEntites
{
    public class TicketClosed : BaseEntity
    {
        public Ticket Ticket { get; set; }
        public int TicketId { get; set; }
    }
}
