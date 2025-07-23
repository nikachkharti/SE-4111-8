using LectureVehiclesPractice;

namespace LectureDataStructures
{
    //Predicate --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და აბრუნებს bool - ს
    //Func --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და დასაბრუნებელი ტიპს ვუთითებთ ჩვენ
    //Action --> შეუძლია მიინიჭოს ისეთი მეთოდი რომლის დასაბრუნებელი ტიპი არის void


    //public delegate bool Predicate(int value);
    //public delegate int Func(string value);
    //public delegate void Action(string value);

    public static class Algorithms
    {
        public static int Custom_FirstOrDefault(List<int> intList, Func<int, bool> predicate)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    return intList[i];
                }
            }

            return default;
        }
        public static int Custom_LastOrDefault(List<int> intList, Predicate<int> predicate)
        {
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                if (predicate(intList[i]))
                {
                    return intList[i];
                }
            }

            return default;

        }
        public static Vehicle[] Custom_Select(string[] vehiclesString, Func<string, Vehicle> converter)
        {
            Vehicle[] cars = new Vehicle[vehiclesString.Length];

            for (int i = 0; i < vehiclesString.Length; i++)
            {
                cars[i] = converter(vehiclesString[i]);
            }

            return cars;
        }
        public static List<int> Custom_Select(List<string> stringList, Func<string, int> converter)
        {
            List<int> result = new();

            for (int i = 0; i < stringList.Count; i++)
            {
                result.Add(converter(stringList[i]));
            }

            return result;
        }
        public static List<long> Custom_Select(List<string> stringList, Func<string, long> converter)
        {
            List<long> result = new();

            for (int i = 0; i < stringList.Count; i++)
            {
                result.Add(converter(stringList[i]));
            }

            return result;
        }

        //1. დაწერეთ მეთოდი Custom_Where --> მეთოდმა უნდა მიიღოს int ლისტი და დააბრუნოს ყველა შესაძლო შედეგი, გადაცემული პირობის მიხედვით.
        //2. დაწერეთ მეთოდი Custom_FirstIndex --> მეთოდმა უნდა მიიღოს int ლისტი და დააბრუნოს პირობის მიხედვით გადაცემული შესაბამისი პირველივე ელემენტის ინდექსი.
        //3. დაწერეთ მეთოდი Custom_LastIndex --> მეთოდმა უნდა მიიღოს int ლისტი და დააბრუნოს პირობის მიხედვით გადაცემული შესაბამისი ბოლო ელემენტის ინდექსი.
    }
}
