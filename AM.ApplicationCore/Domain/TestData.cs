using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>()
        {
            new Plane()
            {
                PlaneType = PlaneType.Boing,
                Capacity = 150,
                ManualFactureDate = new DateTime(2015, 02, 03)
            },
            new Plane()
            {
                PlaneType = PlaneType.Airbus,
                Capacity = 250,
                ManualFactureDate = new DateTime(2020, 11, 11)
            }




        };
        public static List<Staff> Staff { get; set; } = new List<Staff>()

        {
            new Staff()
            {
                FirstName="Captain",
            LastName="Captain",
            EmailAddress="Captain.Captain@gmail.com",
            BirthDate=new DateTime(1965,01,01),
            EmployementDate=new DateTime(1995,01,01),
            Salary=99999}
        };
        public static List<Traveller> Traveller { get; set; } = new List<Traveller>()
        { new Traveller()
        {
            FirstName="Traveller1",
            LastName="Traveller1",
            EmailAddress="traveller1.traveller1@gmail.com",
            BirthDate=new DateTime(1980,01,01),
            HealthInformation="no troble",
            Nationality="American"
        }
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        { new Flight()
        {
            FlightDate=new DateTime(2022,01,01,15,10,10),
            Destination="Paris",
            EffectiveArrival=new DateTime(2022,01,01,17,10,10),
            plane=Planes[2],
            EstimatedDuration=110,



        }
        };

    }
}
