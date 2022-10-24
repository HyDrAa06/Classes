using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    internal class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double travelledDistance;
        private double kmAmount;



        public Car(string model, double fuelAmount, double fuelConsumption)
        {            
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TravelledDistance = 0;
            KmAmount = 0;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public double KmAmount
        {
            get { return kmAmount; }
            set { kmAmount = value; }
        }

        public void Drive()
        {
            if(fuelAmount >= fuelConsumption * kmAmount)
            {
                fuelAmount = fuelAmount - fuelConsumption*kmAmount;
                travelledDistance += kmAmount;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public void Output()
        {
            Console.WriteLine($"{model} {fuelAmount} {travelledDistance}");
        }

    }
}
