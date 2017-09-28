using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SuperFinal1.Models;

namespace SuperFinal1.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User2> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Comments> Comments { get; set; }

      //  public DbSet<Tickets> Tickets { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("MapTest");

            modelBuilder.Entity<User2>().ToTable("AllUsers");
            modelBuilder.Entity<Todo>().ToTable("Todos");
        }
    }
    

}