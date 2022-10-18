using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingArea
    {
        private int capacity;
        private List<Car> cars;

        public ParkingArea(int capacity)
        {
            if(capacity <= 0)
            {
                Console.WriteLine("Capacity should be a positive number.");
                return;
            }

            this.capacity = capacity;

            cars = new List<Car>();
        }

        public int Count
        {
            get { return cars.Count(); }
        }

        public string AddCar(Car car)
        {
            string[] registrationNumbers = cars.Select(x => x.RegNumber).ToArray();
            if (registrationNumbers.Contains(car.RegNumber))
            {
                return("Already exsists.");
            }

            if (registrationNumbers.Count() == capacity)
            {
                return("Parking is full.");
            }

            cars.Add(car);
            return($"Successfuly added {car.Make} {car.RegNumber}.");
        }

        public string RemoveCar(string registrationNumber)
        {
            string[] registrationNumbers = cars.Select(x => x.RegNumber).ToArray();
            if (!registrationNumbers.Contains(registrationNumber))
            {
                return("Doesn't exsist.");
                
            }

            Car carsForRemove = cars.Where(x => x.RegNumber == registrationNumber).First();
            cars.Remove(carsForRemove);

            return($"Successfuly removed {registrationNumber}.");
        }

        public Car GetCar(string registrationNumber)
        {
            Car car = cars.Where(x => x.RegNumber == registrationNumber).First();
            return car;

        }

        public void RemoveSetoOfRegNums(List<string> RegistrationNumbers)
        {
            foreach(string regNumber in RegistrationNumbers)
            {
                RemoveCar(regNumber);
            }
        }
    }
}
