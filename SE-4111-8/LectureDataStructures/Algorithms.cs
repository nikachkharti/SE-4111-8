using LectureVehiclesPractice;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
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
        public static T Custom_FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;
        }
        public static T Custom_LastOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            T result = default;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }

            return result;
        }
        public static IEnumerable<TDestination> Custom_Select<TSource, TDestination>(this IEnumerable<TSource> source, Func<TSource, TDestination> selector)
        {
            List<TDestination> result = new();

            foreach (var item in source)
            {
                result.Add(selector(item));
            }

            return result;
        }
        public static void Custom_Foreach<T>(this IEnumerable<T> source)
        {
            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static IEnumerable<T> Custom_Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public static int Custom_FirstIndex<T>(this IEnumerable<T> source, Func<T, bool> predicate)
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
        public static int Custom_LastIndex<T>(this IEnumerable<T> source, Predicate<T> predicate)
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
        public static IList<T> Custom_OrderBy<T>(this IList<T> intList, Func<T, T, bool> compareFunction)
        {
            for (int i = 0; i < intList.Count - 1; i++)
            {
                for (int j = i + 1; j < intList.Count; j++)
                {
                    if (compareFunction(intList[j], intList[i]))
                    {
                        T temp = intList[j];
                        intList[j] = intList[i];
                        intList[i] = temp;
                    }
                }
            }

            return intList;
        }
        public static int Custom_Sum(this IEnumerable<int> source)
        {
            int sum = 0;

            foreach (int item in source)
            {
                sum += item;
            }

            return sum;
        }
        public static int Custom_Sum(this IEnumerable<int> source, Predicate<int> predicate)
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
        public static int Custom_Count<T>(this IEnumerable<T> source)
        {
            int count = 0;

            foreach (var item in source)
            {
                count++;
            }

            return count;
        }
        public static int Custom_Count<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            int count = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            return count;
        }
        public static IEnumerable<T> Custom_Distinct<T>(this IEnumerable<T> source)
        {
            HashSet<T> set = new();

            foreach (var item in source)
            {
                set.Add(item);
            }

            return set;
        }
        public static IEnumerable<T> Custom_Reverse<T>(this IEnumerable<T> source)
        {
            Stack<T> stack = new();

            foreach (var item in source)
            {
                stack.Push(item);
            }

            return stack;
        }
        public static IEnumerable<T> Custom_Reverse<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Stack<T> stack = new();

            foreach (var item in source)
            {
                if (predicate(item))
                    stack.Push(item);
            }

            return stack;
        }
        public static bool Custom_Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
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
        public static bool Custom_All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
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

        public static T Custom_Max<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
                throw new ArgumentException("Source can't be empty", nameof(source));

            var max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(max) > 0)
                {
                    max = enumerator.Current;
                }
            }

            return max;
        }


        public static T Custom_Min<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
                throw new ArgumentException("Source can't be empty", nameof(source));

            var min = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(min) < 0)
                {
                    min = enumerator.Current;
                }
            }

            return min;
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
