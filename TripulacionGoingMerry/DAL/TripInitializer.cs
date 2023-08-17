using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripulacionGoingMerry.Models;

namespace TripulacionGoingMerry.DAL
{
    public class TripInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TripContext>
    {
        protected override void Seed(TripContext context)
        {
            var tripulants = new List<Tripulant>
            {
            new Tripulant{Name="Luffy",EnrollmentDate=DateTime.Parse("2023-01-01")}
            };

            tripulants.ForEach(s => context.Tripulants.Add(s));
            context.SaveChanges();


            var enrollments = new List<Enrollment>
            {
             new Enrollment{TripulantID=1}
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();


        }

    }
}