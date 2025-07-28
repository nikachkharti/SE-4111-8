using LectureVehiclesPractice;
using System.Collections;
using System.Numerics;

namespace LectureDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\Users\\User\\Desktop\\IT STEP\\SE-4111-8\\SE-4111-8\\LectureVehiclesPractice\\vehicles.csv";
            var carsAsString = File.ReadAllLines(filePath);

            //1.მოძებნეთ მერსედესი
            //2.მოძებნეთ პირველივე ისეთი რომლის ქალაქში გამავლობა მეტია 15 ზე და ნაკლებია 23 ze

            //var allCars = Algorithms.Custom_Select(carsAsString, Vehicle.Parse);
            //var allMercedeses = Algorithms.Custom_Where(allCars, x => x.Make.Contains("Mercedes", StringComparison.OrdinalIgnoreCase));
            //var finalMercedes = Algorithms.Custom_FirstOrDefault(allMercedeses, m => m.City >= 15 && m.City <= 23);


            var finalMercedes = carsAsString
                .Custom_Select(Vehicle.Parse)
                .Custom_Where(x => x.Make.Contains("Mercedes", StringComparison.OrdinalIgnoreCase))
                .Custom_FirstOrDefault(m => m.City >= 15 && m.City <= 23);


            //List<int> intList = new() { 1, 1, 1, 11, 2, -21, 30, 30, 7, -7 };
            //List<string> stringList = new() { "Nika", "Giorgi", "Daviti" };
            //List<double> doubleList = new() { 10.1, 2.2, 3.1 };
            //List<string> listString = new() { "10.1", "2.2", "3.1" };










            #region LIST
            //int[] ar = [98, 11, 44, -10];

            //List<int> intList = new List<int>();
            //intList.Add(10); // ამატებს ერთ ელემენტს
            //intList.Add(300); // ამატებს ერთ ელემენტს
            //intList.Add(788); // ამატებს ერთ ელემენტს
            //intList.Add(9); // ამატებს ერთ ელემენტს
            //intList.Add(19); // ამატებს ერთ ელემენტს
            //intList.AddRange(ar); // ამატებს რამდენიმე ელემენტს
            //intList.Remove(10);
            //intList.RemoveRange(0, 2); // წაშალე პირველი ორი ელემენტი ლისტში
            //intList.Clear(); // ასუფთავებს ლისტს
            //intList.Insert(0, 99); // ლისტის ნებისმიერ ინდექსზე ნებისმიერი მნიშვნელობის ჩამატება
            //intList.InsertRange(0, [7, 7, 7]);
            //bool contains = intList.Contains(7);
            //int idx = intList.IndexOf(-10);
            //intList.TrimExcess(); // გაამადგურებს ტყუილად გამოყოფილ ადგილებს

            //int listCount = intList.Count; // ზომა
            //int listCapacity = intList.Capacity; // მოცულობა
            // 
            #endregion


            #region STACK

            //LIFO - (Last In First Out) ბოლოს ჩამატებული ელემენტი პირველ ადგულს იკავებს კოლექციაში

            Stack<int> stack = new();
            stack.Push(12); // ელემენტის ჩამატება
            stack.Push(47); // ელემენტის ჩამატება
                            //stack.Pop(); // ზედა ელემენტის ამოგდება
                            //var a = stack.Peek(); // აბრუნებს ზედა ელემენტს წაშლის გარეშე
                            //stack.Contains(12);
                            //stack.Clear();
                            //stack.Count;


            #endregion


            #region QUEUE
            //FIFO (First In First Out) პირველი შემავალი ელემენტი რიგს ტოვებს პირველი

            Queue<int> intQueue = new();
            intQueue.Enqueue(12); // ელემენტის დამატება
            intQueue.Enqueue(47); // ელემენტის დამატება
                                  //intQueue.Dequeue(); // ელემენტის ამოგდება
                                  //intQueue.Clear();
                                  //intQueue.Contains(12);
                                  //intQueue.Count;

            #endregion


            #region HASHSET

            HashSet<int> intSet = new();
            intSet.Add(12);
            intSet.Add(121);
            intSet.Add(121);
            intSet.Add(12);

            HashSet<int> intSet2 = new();
            intSet2.Add(12);
            intSet2.Add(121);

            var x = intSet2.IsSubsetOf(intSet); // არის თუ არა IntSet2 intSet ის ქვესიმრავლე
            var xx = intSet2.IsSupersetOf(intSet); // არის თუ არა IntSet2 intSet ის ზესიმრავლე

            #endregion


            #region DICTIONARY

            //Dictionary<int, string> students = new();
            //students.Add(1, "Nika");
            //students.Add(2, "Ana");

            //if (students.TryGetValue(1, out string name))
            //{
            //    Console.WriteLine($"ID 1 : {name}");
            //}

            //students[1] = "Luka";

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"K: {student.Key}  V:{student.Value}");
            //}

            #endregion
        }


        private static void WriteInFile(string info)
        {
            File.WriteAllText(@"../../../test.txt", info);
        }

    }
}