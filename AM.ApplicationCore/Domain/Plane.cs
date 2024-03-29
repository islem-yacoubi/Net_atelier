﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing, Airbus
    }
    public class Plane
    {
        [Range(0, double.MaxValue)]
        public double Capacity { get; set; }
        public DateTime ManualFactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public virtual List<Flight> Flights { get; set; }
        public virtual List<Passenger> Passes { get; set; }
        public virtual List <Seat> Seats { get; set; }

        /*/*Créer un objet non initialisé de type Plane en utilisant le constructeur non paramétré de la
           classe, puis initialiser ses attributs à travers leurs propriétés.*/
        public Plane()
        {

        }
        public override string ToString()
        {
            return "Capacity : " + Capacity + " Facture Date : " + ManualFactureDate + " Type Plane : " + PlaneType;
        }

        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    this.Capacity = capacity;
        //    this.ManualFactureDate = date;
        //    this.PlaneType = pt;
        //}

        public Plane(double capacity, DateTime manualFactureDate, int planeId, PlaneType planeType)
        {
            this.Capacity = capacity;
            this.ManualFactureDate = manualFactureDate;
            this.PlaneId = planeId;
            this.PlaneType = planeType;
        }
    }
}