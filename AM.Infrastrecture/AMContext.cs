using AM.ApplicationCore.Domain;
using AM.Infrastrecture.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastrecture
{
    public class AMContext:DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Section> Sections { get; set; }    
        public DbSet<Reservation> Reservations { get; set; }    
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MsSqlLocalDb; initial catalog=KharroubiHazem; integrated Security = true");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.Entity<Passenger>().ToTable("Passengers");
            modelBuilder.Entity<Traveller>().ToTable("Travellers");
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
           
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(120);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date") ;
            configurationBuilder.Properties<Double>().HavePrecision(2, 3); 
            
        }
    }
}
