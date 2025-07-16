namespace LectureVehiclesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehiclesString = File.ReadAllLines(@"../../../vehicles.csv");
            Vehicle[] cars = TransformToCars(vehiclesString);

            //1. ამ ფაილში არსებული თითოეული მასივის ელემენტი, გარდაქმენით მანქანის ობიექტად და დაბეჭდეთ კონსოლში +
            //2. მოძებნეთ ყველა მერსედეს ბენცი.
            //3. მოძებნეთ 10 ყველაზე ეკონომიური მანქანა.
        }

        private static Vehicle[] TransformToCars(string[] vehiclesString)
        {
            Vehicle[] cars = new Vehicle[vehiclesString.Length];

            for (int i = 1; i < vehiclesString.Length; i++)
            {
                cars[i] = Vehicle.Parse(vehiclesString[i]);
            }

            return cars;
        }
    }
}
