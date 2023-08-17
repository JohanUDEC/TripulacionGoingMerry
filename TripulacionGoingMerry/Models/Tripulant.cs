using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripulacionGoingMerry.Models
{
    public class Tripulant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //virtual 
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}