﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

        List<Flight> Flights { get; set; }

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
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
        }

        public bool CheckProfile(string nom, string prenom)
        {
            return FirstName == nom && LastName == prenom;
        }



        public bool CheckProfile(string nom, string prenom, string mail)
        {
            return FirstName == nom && LastName == prenom && EmailAddress == mail;
        }

       


        /*11. Polymorphysme par héritage*/

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
}