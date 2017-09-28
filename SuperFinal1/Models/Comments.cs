using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class Comments
    {
        public int CommentsId { get; set; }
        public string Comment { get; set; }
       // [ForeignKey("Tickets")]
        public virtual Tickets TicketsId { get; set; }
      //  [ForeignKey("User2")]
        public virtual User2 User2Id { get; set; }

    }
}