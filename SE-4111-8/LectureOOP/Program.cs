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


    internal class Program
    {
        static void Main(string[] args)
        {

            Person nikasObj = new Person() /*<--კონსტრუქტორი*/;
            nikasObj.name = "Nika";
            nikasObj.age = 16;

            nikasObj.Walk();
            nikasObj.Talk();


            Person giorgisObj = new Person() /*<--კონსტრუქტორი*/
            {
                name = "Giorgi",
                age = 20
            };
            giorgisObj.Walk();
            giorgisObj.Talk();



            Person elenesObj = new Person("Elene", 25); /*<--კონსტრუქტორი*/
            elenesObj.Walk();
            elenesObj.Talk();


            Person davitisObj = new Person(33); /*<--კონსტრუქტორი*/
            davitisObj.name = "Daviti";

            davitisObj.Walk();
            davitisObj.Talk();




            //Console.WriteLine($"{nikasObj.name} {nikasObj.age}");
            //Console.WriteLine($"{giorgisObj.name} {giorgisObj.age}");





            /*
             
            let obj1 = {name:"Nika",age:12},

            [
                {name:"Nika",age:12},
                {name:"Giorgi",age:13},
                {name:"Elene",age:45}
            ] 

             */

        }
    }
}
