using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public double Prix { get; set; }
        public string Siege  { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
       // [ForeignKey(nameof(Flight))] 
        public  int FlightFk { get; set; }
       // [ForeignKey(nameof(Passenger))]
        public int  PassengerFk { get; set; }
    }
}
