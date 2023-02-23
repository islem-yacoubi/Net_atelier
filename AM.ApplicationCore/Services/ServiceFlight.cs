using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; }   = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //for (int i=0;i<Flights.Count;i++) 
            //{
            //    if (Flights[i].Destination == destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;
        //7
        List<DateTime> dates = new List<DateTime>();
            foreach (Flight flight in Flights) { 
                if (flight.Destination==destination)
                    dates.Add(flight.FlightDate);
            }
            return dates;
        }
    }
}
