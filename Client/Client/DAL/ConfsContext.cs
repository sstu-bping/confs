using Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Client.DAL
{
    public class ConfsContext : DbContext
    {
        public ConfsContext() : base("ConfsContext") { 
        }

        public DbSet<News> News { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<RegistrationModel> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}