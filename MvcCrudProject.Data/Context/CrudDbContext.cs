using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MvcCrudProject.Data.Entities;

namespace MvcCrudProje.Models.Context
{
    public class CrudDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 

        public CrudDbContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-CT3TMFE\\ALISQL;database=CrudProject;Trusted_Connection=true";
        }

        public DbSet<Departman> Departman{ get; set; }
        public DbSet<Calisan> Calisan{ get; set; }
        public DbSet<Login> Login { get; set; }

    }
}