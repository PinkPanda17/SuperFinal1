using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public virtual List<Todo> Todos { get; set; }
    }
}