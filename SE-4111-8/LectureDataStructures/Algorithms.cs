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

        public static int Custom_LastOrDefault(IEnumerable<int> source, Predicate<int> predicate)
        {
            int result = default;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }

            return result;
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
        public static List<int> Custom_Where(IEnumerable<int> source, Func<int, bool> predicate)
        {
            List<int> result = new();

            foreach (int item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public static int Custom_FirstIndex(IEnumerable<int> source, Func<int, bool> predicate)
        {
            int i = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return i;
                }

                i++;
            }

            return -1;
        }
        public static int Custom_LastIndex(IEnumerable<int> source, Predicate<int> predicate)
        {
            int i = 0;
            int result = -1;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result = i;
                }

                i++;
            }

            return result;
        }
        public static IList<int> Custom_OrderBy(IList<int> intList, Func<int, int, bool> compareFunction)
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
        public static int Custom_Sum(IEnumerable<int> source)
        {
            int sum = 0;

            foreach (int item in source)
            {
                sum += item;
            }

            return sum;
        }
        public static int Custom_Sum(IEnumerable<int> source, Predicate<int> predicate)
        {
            int sum = 0;

            foreach (int item in source)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }

            return sum;
        }
        public static int Custom_Count(IEnumerable<int> source)
        {
            int count = 0;

            foreach (int item in source)
            {
                count++;
            }

            return count;
        }
        public static int Custom_Count(IEnumerable<int> source, Predicate<int> predicate)
        {
            int count = 0;

            foreach (int item in source)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            return count;
        }
        public static IEnumerable<int> Custom_Distinct(IEnumerable<int> source)
        {
            HashSet<int> set = new();

            foreach (int item in source)
            {
                set.Add(item);
            }

            return set;
        }
        public static IEnumerable<int> Custom_Reverse(IEnumerable<int> source)
        {
            Stack<int> stack = new();

            foreach (var item in source)
            {
                stack.Push(item);
            }

            return stack;
        }
        public static IEnumerable<int> Custom_Reverse(IEnumerable<int> source, Func<int, bool> predicate)
        {
            Stack<int> stack = new();

            foreach (var item in source)
            {
                if (predicate(item))
                    stack.Push(item);
            }

            return stack;
        }
        public static bool Custom_Any(IEnumerable<int> source, Func<int, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Custom_All(IEnumerable<int> source, Func<int, bool> predicate)
        {
            foreach (var item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }




        //გადასაკეთებელი !!!!
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
