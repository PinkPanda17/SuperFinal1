using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class SupportServ
    {
        public int SupportServId { get; set; }
         //[ForeignKey("User2")]
        public User2 User2Id { get; set; }
    //    [ForeignKey("Tickets")]
        public Tickets TicketsId { get; set; }
    }
}