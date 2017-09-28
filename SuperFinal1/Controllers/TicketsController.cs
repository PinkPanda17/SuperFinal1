using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SuperFinal1.Context;
using SuperFinal1.Models;
//using System.Windows.Forms;
//using System.Web.Script.Serialization;


namespace SuperFinal1.Controllers
{
    [RoutePrefix("api/tickets")]
    public class TicketController : ApiController
    {
        private UserContext db = new UserContext();

         //POST: api/Users
        [ResponseType(typeof(Tickets))]
        [HttpPost]
        [Route("AddTicket")]
        public IHttpActionResult AddTicket([FromBody] TicketsDto ticket)
        {

            var user = db.Users.FirstOrDefault(t => t.User2Id == ticket.User2Id);

    
            var newTicket = new Tickets();

            newTicket.Category = ticket.Category;
            newTicket.Description = ticket.Description;
            newTicket.EndDate = ticket.EndDate;
            newTicket.StartDate = ticket.StartDate;
            newTicket.Subject = ticket.Subject;
            newTicket.TicketStatus = ticket.TicketStatus;
            newTicket.User2Id = user;

            var ticketAdded = db.Tickets.Add(newTicket);
            db.SaveChanges();
            return Created("", ticketAdded);
        }


    }
}