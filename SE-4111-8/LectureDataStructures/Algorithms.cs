using LectureVehiclesPractice;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LectureDataStructures
{
    //Predicate --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და აბრუნებს bool - ს
    //Func --> შეუძლია მიინიჭოს ისეთი მეთოდი რომელიც პარამეტრად იღებს რაიმე ტიპს და დასაბრუნებელი ტიპს ვუთითებთ ჩვენ
    //Action --> შეუძლია მიინიჭოს ისეთი მეთოდი რომლის დასაბრუნებელი ტიპი არის void


    //public delegate bool Predicate(int value);
    //public delegate int Func(string value);
    //public delegate void Action(string value);


    //IEnumerable გვაძლევს  Current, MoveNext, Reset , GetEnumerator

    public static class Algorithms
    {
        public static int Custom_FirstOrDefault(IEnumerable<int> source, Func<int, bool> predicate)
        {
            foreach (int item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;
        }

        //გააკეთეთ უჩემოდ !!!
        public static int Custom_LastOrDefault(IEnumerable<int> source, Predicate<int> predicate)
        {
            for (int i = source.Count() - 1; i >= 0; i--)
            {
                if (predicate(source[i]))
                {
                    return source[i];
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
        public static List<int> Custom_Select(IEnumerable<string> source, Func<string, int> converter)
        {
            List<int> result = new();

            foreach (string item in source)
            {
                result.Add(converter(item));
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
        public static List<int> Custom_Distinct(List<int> intList)
        {
            List<int> result = new();

            for (int i = 0; i < intList.Count; i++)
            {
                if (!result.Contains(intList[i]))
                    result.Add(intList[i]);
            }

            return result;
        }
        public static List<int> Custom_Reverse(List<int> intList)
        {
            List<int> result = new();

            for (int i = intList.Count - 1; i >= 0; i--)
            {
                result.Add(intList[i]);
            }

            return result;
        }
        public static List<int> Custom_Reverse(List<int> intList, Func<int, bool> predicate)
        {
            List<int> result = new();

            for (int i = intList.Count - 1; i >= 0; i--)
            {
                if (predicate(intList[i]))
                {
                    result.Add(intList[i]);
                }
            }

            return result;
        }
        public static bool Custom_Any(List<int> intList, Func<int, bool> predicate)
        {
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                if (predicate(intList[i]))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Custom_All(List<int> intList, Func<int, bool> predicate)
        {
            for (int i = intList.Count - 1; i >= 0; i--)
            {
                if (!predicate(intList[i]))
                {
                    return false;
                }
            }

            return true;
        }
        public static int Custom_Max(List<int> intList)
        {
            int max = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] > max)
                {
                    max = intList[i];
                }
            }

            return max;
        }
        public static int Custom_Min(List<int> intList)
        {
            int max = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] < max)
                {
                    max = intList[i];
                }
            }

            return max;
        }
        public static List<int> Custom_Take(List<int> intList, int count)
        {
            List<int> result = new();

            for (int i = 0; i < count && i < intList.Count; i++)
            {
                result.Add(intList[i]);
            }

            return result;
        }
        public static List<int> Custom_Skip(List<int> intList, int count)
        {
            List<int> result = new();

            for (int i = count; i < intList.Count; i++)
            {
                result.Add(intList[i]);
            }

            return result;
        }

    }
}
