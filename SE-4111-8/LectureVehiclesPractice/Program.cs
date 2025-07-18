using System.Numerics;

namespace LectureVehiclesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehiclesString = File.ReadAllLines(@"../../../vehicles.csv");

            //1. ამ ფაილში არსებული თითოეული მასივის ელემენტი, გარდაქმენით მანქანის ობიექტად და დაბეჭდეთ კონსოლში +
            Vehicle[] cars = TransformToCars(vehiclesString);

            //2. მოძებნეთ ყველა მერსედეს ბენცი. +
            Vehicle[] mercedeses = FindAllMercedeses(cars);

            //3. მოძებნეთ 10 ყველაზე ეკონომიური მანქანა. +
            Vehicle[] economicCars = CombinedSort(cars);
            Vehicle[] topTenEconomicCars = Take(economicCars, 10);

        }


        private static Vehicle[] Take(Vehicle[] cars, int quantity)
        {
            Vehicle[] result = new Vehicle[quantity];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = cars[i];
            }

            return result;
        }
        private static Vehicle[] CombinedSort(Vehicle[] cars)
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[j].Combined > cars[i].Combined)
                    {
                        Vehicle tempCar = cars[j];
                        cars[j] = cars[i];
                        cars[i] = tempCar;
                    }
                }
            }

            return cars;
        }
        private static Vehicle[] FindAllMercedeses(Vehicle[] cars)
        {
            List<Vehicle> result = new();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Make.Contains("Mercedes", StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(cars[i]);
                }
            }

            return result.ToArray();
        }
        private static Vehicle[] TransformToCars(string[] vehiclesString)
        {
            Vehicle[] cars = new Vehicle[vehiclesString.Length];

            for (int i = 0; i < vehiclesString.Length; i++)
            {
                cars[i] = Vehicle.Parse(vehiclesString[i]);
            }

            return cars;
        }
    }
}
