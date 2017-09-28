using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SuperFinal1.Models;

namespace SuperFinal1.Context
{
    public class UserDBContextSeeder : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {

            User2 user1 = new User2()
            {
                User2Id = 1,
                EmailAdd = "ella@ticket.com",
                Name = "John Lemon",
                Country = "PH",
                Role = Roles.Admin,
                Tickets = new List<Tickets>(){
                new Tickets(){
                     Subject = "Test",
                    Description = "Test",
                    TicketStatus = Status.New,
                    Category = Cat.Hardware,
                    Comments = new List<Comments>(){
                        new Comments ()
                            {
                                Comment = "Please",
                            }
                    }
                }
            }
            };
            context.Users.Add(user1);
            base.Seed(context);
        }
    }
}