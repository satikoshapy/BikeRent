﻿using System;
using System.Collections.Generic;

namespace BikeRent
{
    public enum Gender
    {
        Male,
        Female
    }

    public abstract class BikeBase
    {
        private List<Rental> _rentals;

        public BikeBase()
        {
            _rentals = new List<Rental>();
            LastMaintenanceDate = DateTime.MinValue;
        }
        
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public double TotalDistance { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public Gender Gender { get; set; }
        public double PricePerDay { get; set; }

        public abstract int KmPerMaintenanceCycle { get; }

        public bool NeedsMaintenance()
        {
            //ToDo : a bike needs maintenance if its TotalDistance is greater than or equal to 
            //       its KmPerMaintenanceCycle
            if (TotalDistance >= KmPerMaintenanceCycle)
            {
                return true;
            }
            return false;
        }

        public List<Rental> Rentals
        {
            get
            {
                return _rentals;
            }
        }

        public bool IsOccupied
        {
            get
            {
                // When a bike rental is ended, its Distance will be entered
                var rental = FindCurrentRental();
                return ((rental != null) && (rental.Distance == 0));
            }
        }

        public Rental FindCurrentRental()
        {
            Rental currentRental = null;

            if ((_rentals != null) && (_rentals.Count > 0))
            {
                currentRental = _rentals[0];
            }

            return currentRental;
        }

        public void Rent(DateTime startDate, int days, string customer)
        {
            //ToDo: create a new Rental object and insert it
            //      into the correct location in the list
            //      This Rental object will be the new current Rental

            Rental rental = new Rental(startDate, days, BusinessRules.CalculatePrice(days, PricePerDay), customer);
            _rentals.Add(rental);
        }

        public void Return(double distance)
        {
            //ToDo: find the current rental and fill out its distance.
            //      Don't forget to update the total distance!

            Rental currentRental = FindCurrentRental();
            if (currentRental != null) 
            {
                currentRental.Distance = distance;
                TotalDistance += distance;
            }
        }
    }
}
