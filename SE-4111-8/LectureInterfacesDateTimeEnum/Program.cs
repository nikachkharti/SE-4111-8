using System.Security;

namespace LectureInterfacesDateTimeEnum
{
    internal class Program
    {
        public interface IFlyer
        {
            public double Height { get; set; }
            public void Fly();
        }

        public interface IHunter
        {
            public double Height { get; set; }
            public void Hunt();
        }

        public abstract class Bird
        {
            public abstract void Eat();
        }

        public class Eagle : Bird, IFlyer, IHunter
        {
            public double Height { get; set; }

            public void Fly()
            {
                Console.WriteLine($"I can fly on {Height} meters");
            }

            public override void Eat()
            {
                Console.WriteLine($"I eat meat");
            }

            public void Hunt()
            {
                Console.WriteLine($"I can hunt very fast");
            }
        }

        public class Hawk : Bird, IFlyer, IHunter
        {
            double IFlyer.Height { get; set; }
            double IHunter.Height { get; set; }

            public override void Eat()
            {
                Console.WriteLine($"I eat meat");
            }

            public void Fly()
            {
                // Accessing explicitly implemented interface member
                Console.WriteLine($"I can fly on {((IFlyer)this).Height} meters");
            }

            public void Hunt()
            {
                Console.WriteLine($"I can hunt fast");
            }

            void IFlyer.Fly()
            {
                throw new NotImplementedException();
            }
        }


        public class Penguin : Bird, IHunter
        {
            public double Height { get; set; }

            public override void Eat()
            {
                Console.WriteLine($"I eat fish");
            }

            public void Hunt()
            {
                Console.WriteLine($"I hunt slow");
            }
        }

        static void Main(string[] args)
        {
            //var currentDateTime = DateTime.Now;
            //var today = DateTime.Today;
            //var currentDateTimeUtc = DateTime.UtcNow;

            //Console.WriteLine(today);
            //Console.WriteLine(currentDateTime);
            //Console.WriteLine(currentDateTimeUtc);

            //DateTime customDate = new DateTime(year: 2025, month: 7, day: 11);
            //DateTime customDateWithTime = new DateTime(year: 2023, month: 12, day: 25, hour: 14, minute: 30, second: 0);

            //Console.WriteLine(customDate);
            //Console.WriteLine(customDateWithTime);

            //Console.WriteLine(customDate.DayOfWeek);
            //Console.WriteLine(customDate.DayOfYear);

            //Console.WriteLine(customDate.AddDays(1)); // უმატებს ერთ დღეს
            //Console.WriteLine(customDate.AddDays(-1)); // აკლებს ერთ დღეს


            //DateTime start = new DateTime(2023, 7, 11);
            //DateTime end = DateTime.Now;

            //TimeSpan diff = end - start;
            //Console.WriteLine(diff);

            //string currentDate = "2025-07-11";
            //DateTime x = DateTime.Parse(currentDate);
            //DateTime.TryParse(currentDate, out var x);

            //DateTime now = DateTime.Now;

            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            //Console.WriteLine(now.ToString("dddd,MMMM,dddd"));


            //დაწერეთ ფუნქცია რომელსაც გადავცემთ, დაბადების თარიღს და ფუნქცია დაგვიბრუნებს თუ რამდენი წლისაა ადამიანი


        }
    }
}
