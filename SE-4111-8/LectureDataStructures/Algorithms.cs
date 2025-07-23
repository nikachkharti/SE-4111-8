using LectureVehiclesPractice;
using System.Runtime.Intrinsics.Arm;

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
        public static List<int> Custom_Where(List<int> intList, Func<int, bool> predicate)
        {
            List<int> result = new();

            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    result.Add(intList[i]);
                }
            }

            return result;
        }
        public static int Custom_FirstIndex(List<int> intList, Func<int, bool> predicate)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int Custom_LastIndex(List<int> intList, Predicate<int> predicate)
        {
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                if (predicate(intList[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static List<int> Custom_OrderBy(List<int> intList, Func<int, int, bool> compareFunction)
        {
            for (int i = 0; i < intList.Count - 1; i++)
            {
                for (int j = i + 1; j < intList.Count; j++)
                {
                    if (compareFunction(intList[j], intList[i]))
                    {
                        int temp = intList[j];
                        intList[j] = intList[i];
                        intList[i] = temp;
                    }
                }
            }

            return intList;
        }
        public static int Custom_Sum(List<int> intList)
        {
            int sum = 0;

            for (int i = 0; i < intList.Count; i++)
            {
                sum += intList[i];
            }

            return sum;
        }
        public static int Custom_Sum(List<int> intList, Predicate<int> predicate)
        {
            int sum = 0;

            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    sum += intList[i];
                }
            }

            return sum;
        }
        public static int Custom_Count(List<int> intList)
        {
            int count = 0;

            for (int i = 0; i < intList.Count; i++)
            {
                count++;
            }

            return count;
        }
        public static int Custom_Count(List<int> intList, Predicate<int> predicate)
        {
            int count = 0;

            for (int i = 0; i < intList.Count; i++)
            {
                if (predicate(intList[i]))
                {
                    count++;
                }
            }

            return count;
        }


    }
}
