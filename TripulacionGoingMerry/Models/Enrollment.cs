using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripulacionGoingMerry.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int TripulantID { get; set; }
        public virtual Tripulant Tripulant { get; set; }

    }

}