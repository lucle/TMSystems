using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public int TicketStatusId { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public Catalog Catalog { get; set; }

    }
}
