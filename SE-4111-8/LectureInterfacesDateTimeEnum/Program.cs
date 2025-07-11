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
        }
    }
}
