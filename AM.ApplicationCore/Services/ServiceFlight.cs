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
        public ServiceFlight() {
            FlightDetailsDel = (Plane plane)=>
        {
                var query = Flights
                .Where(f => f.Plane.PlaneId == plane.PlaneId) // jamais trajaa true (si ki nzidhom .PlaneId)
                    .Select(f => new { f.Destination, f.FlightDate });
                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            };
            DurationAverageDel = (string destination)=>
        {
                var query = Flights
                    .Where(f => f.Destination.Equals(destination))
                    .Average(f => f.EstimatedDuration);
                return query;
            };
                }  

        public List<Flight> Flights { get; set; }   = new List<Flight>();
        public Action <Plane> FlightDetailsDel { get; set; }
        public Func<string ,double> DurationAverageDel { get; set; }
        public List<DateTime> GetFlightDates(string destination)
        {
            var query = Flights
            .Where(f => f.Destination == destination)
            .Select(f => f.FlightDate).ToList();
            return query;
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
        public double DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimatedDuration);
            return query;
        }
        public void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.Plane.PlaneId == plane.PlaneId) // jamais trajaa true (si ki nzidhom .PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

    }
}
