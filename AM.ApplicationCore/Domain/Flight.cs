﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        //public List<Passenger> Passes { get; set; }
        public virtual List<Ticket> Tickets { get; set; }    
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public DateTime EstimatedDuration { get; set; }
        //[ForeignKey(nameof(PlaneFK))]
       public virtual Plane ? plane { get; set; }
       [ForeignKey(nameof(plane))]
        public int ? PlaneFK { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}