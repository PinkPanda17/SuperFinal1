using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class Tickets
    {
        public int TicketsId { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }
        public Status TicketStatus { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Cat Category { get; set; }

        public virtual User2 User2Id { get; set; }
        public virtual List<Comments> Comments { get; set; }
    }

    public class TicketsDto
    {
        public int TicketsId { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }
        public Status TicketStatus { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Cat Category { get; set; }

        public int User2Id { get; set; }

    }
    public enum Status
    {
        New = 1,
        WorkinProg = 2,
        Pending = 3,
        Closed = 4

    }

    public enum Cat
    {
        Hardware = 1,
        Software = 2,
        Network = 3

    }
}