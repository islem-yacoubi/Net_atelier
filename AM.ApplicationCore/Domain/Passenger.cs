using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        [Key,MaxLength(7)]
        public int PasseportNumber { get; set; }
       [ DataType(DataType.EmailAddress)]//[EmailAddress]
        public string EmailAddress { get; set; }

        //[MinLength(3, ErrorMessage = "longueur minimale 3 caractères"), MaxLength(25, ErrorMessage = "de longueur maximale 25 caractères")]

        //public string FirstName { get; set; }

        //public string LastName { get; set; }
        public FullName FullName { get; set; }
        [MinLength(8),MaxLength(8)]//(public string) [RegualarExpression("[0-9]{8}")]
        public int TelNumber { get; set; }
        

        //public List<Flight> Flights { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public Passenger()
        {

        }

        public Passenger(DateTime birthDate, int passeportNumber, string emailAddress, string firstName, string lastName, int telNumber)
        {
            BirthDate = birthDate;
            PasseportNumber = passeportNumber;
            EmailAddress = emailAddress;
            //FirstName = firstName;
            //LastName = lastName;
            TelNumber = telNumber;
        }

        //public bool CheckProfile(string nom, string prenom)
        //{
        //    return FirstName == nom && LastName == prenom;
        //}



        //public bool CheckProfile(string nom, string prenom, string mail)
        //{
        //    return FirstName == nom && LastName == prenom && EmailAddress == mail;
        //}


       


        /*11. Polymorphysme par héritage*/

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
}