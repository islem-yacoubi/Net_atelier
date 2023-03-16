using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastrecture.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.PassengerFk, t.FlightFk });
            builder.HasOne(p=>p.Passenger).WithMany(m=>m.Tickets).HasForeignKey(t => t.PassengerFk);
            builder.HasOne(p=>p.Flight).WithMany(m=>m.Tickets).HasForeignKey(t => t.FlightFk);
        }
    }
}
