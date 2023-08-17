using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TripulacionGoingMerry.Models;

namespace TripulacionGoingMerry.DAL
{
    public class TripContext : DbContext
    {
        public TripContext() : base("TripContext")
        {
        }
        public DbSet<Tripulant> Tripulants { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}