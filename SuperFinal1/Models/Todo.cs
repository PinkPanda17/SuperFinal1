using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperFinal1.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Completed { get; set; }
        
        //public int UserId { get; set; }
        public virtual User2 User { get; set; }
        
        
    }
}