namespace LectureOOP
{
    public class Person
    {
        public string name;
        public int age;

        //კონსტრუქტორი
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //კონსტრუქტორი
        public Person()
        {
        }

        //კონსტრუქტორი
        public Person(int age)
        {
            this.age = age;
        }

        public void Walk()
        {
            Console.WriteLine($"{name} WALKING...");
        }

        public void Talk()
        {
            Console.WriteLine($"My Name is {name} I am {age} years old");
        }
    }

}
