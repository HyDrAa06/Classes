using System;

namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars:");
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Car info:");
                string[] carInfo = Console.ReadLine().Split(" ").ToArray();

                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(car);
            }


            while (true)
            {
                Console.WriteLine("Command:");
                string[] command = Console.ReadLine().Split(" ").ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                double amountOfKm = double.Parse(command[2]);

                for (int i = 0; i < n; i++)
                {
                    if (cars[i].Model == command[1])
                    {
                        cars[i].KmAmount = amountOfKm;
                        cars[i].Drive();
                    }
                }
            }

            Console.WriteLine("Info for cars:");

            for (int i = 0; i < n; i++)
            {
                cars[i].Output();
            }

        }
    }
}