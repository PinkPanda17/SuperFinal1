using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class User2
    {
        public int User2Id { get; set; }
        public string EmailAdd { get; set; }
        public string Name { get; set; }
        public string Country { get; set;}
        public string Passwword { get; set; }
        public Roles Role { get; set; }

        public int? AdminId { get; set; }
        public virtual List<Tickets> Tickets { get; set; }
    }

    public enum Roles
    {

        Admin = 1,
        Technician = 2,
        Staff = 3

    }
}