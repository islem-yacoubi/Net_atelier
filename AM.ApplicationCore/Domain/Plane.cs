using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,Airbus
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }    
        public int PlaneId { get; set; }    
        public PlaneType PlaneType { get; set; }
        public List<Flight> flights { get; set; }
    }
}
