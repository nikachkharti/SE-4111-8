using LectureOOP.BankModels;
using System;
using System.Net.WebSockets;
using System.Text;

namespace LectureOOP
{
    //OOP პრინციპები:

    //1. მემკვიდრეობა +
    //2. ენკაფსულაცია ნიშნავს გარკვეული ფუნქციონალის დაფარვას უსაფრთხოების მიზნით +
    //3. პოლიმორფიზმი +
    //4. აბსტრაქცია +



    //sealed კლასი არის უშვილო კლასი
    //public /*sealed*/ class Person
    //{
    //    public string Name { get; set; }

    //    public void Talk()
    //    {
    //        Console.WriteLine("ZDAROVA");
    //    }
    //}

    //public class Teacher : Person
    //{
    //    //public string Name { get; set; } // გადაფარვა
    //    public new string Name { get; set; } // გადაფარვა
    //    public string Subject { get; set; }
    //}


    //class CsharpTeacher : Teacher
    //{
    //    //Subject ---> Teacher
    //    //Name ---> Person
    //    public void Sing()
    //    {
    //    }
    //}

    //class FrontTeacher : Teacher
    //{
    //    //Subject ---> Teacher
    //    //Name ---> Person
    //    public void Dance()
    //    {
    //    }
    //}



    //public class Student : Person
    //{
    //}




    public abstract class Person
    {
        public string FullName { get; set; }

        //როცა ფუნქცია არის ვირტუალური, მის მემკვიდრეებს აქვთ საშუალება რომ თავის ჭკუაზე გადააკეთონ ეს ფუნქცია
        public virtual string Talk() => $"Hello I am a person {FullName}";
        public abstract string Walk();
    }

    public abstract class Employee : Person
    {
        public decimal Salary { get; set; }
    }



    class Student : Person
    {
        public double Score { get; set; }
        public Subject Subject { get; set; }

        //override ნიშანავს მშობლის მოწოდებული ფუნქციის გადატვირთვას
        public override string Talk() => $"Hello I am a student {FullName} I sstudy a subject {Subject.Name} and have score {Score}";
        public override string Walk() => $"I am walking I am an student {FullName}";

    }

    class Teacher : Employee
    {
        public Subject Subject { get; set; }


        //override ნიშანავს მშობლის მოწოდებული ფუნქციის გადატვირთვას
        public override string Talk() => $"Hello I am a employee {FullName} I have a salary {Salary} GEL and teach a subject {Subject.Name}";

        public override string Walk() => $"I am walking I am an a teacher {FullName}";

    }



    public class Subject
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {

            #region CLASSWORK

            /*
                საკლასო: 
                შექმენით კლასი რიმლითაც აღწერთ საკუთარ თავს. კლასს უნდა ჰქოონდეს შემდეგი 
                ინფორმაცია თქვენი სახელი,გვარი,ასაკი,პირადი ნომერი,ტელეფონის 
                ნომერი,ელ-ფოსტა.კლასი ინფორმაციას უნდა იღებდეს კონსტრუქტორიდან.
                მოახდინეთ თქვენი კლასის დემონსტრირება კონსოლში.             
             */


            //Human nika = new Human("Nika", "Chkhartishvili", 30, "01024087458", "557889966", "nika@gmail.com");
            //Console.WriteLine(nika.Talk());



            //Person nikasObj = new Person() /*<--კონსტრუქტორი*/;
            //nikasObj.name = "Nika";
            //nikasObj.age = 16;

            //nikasObj.Walk();
            //nikasObj.Talk();


            //Person giorgisObj = new Person() /*<--კონსტრუქტორი*/
            //{
            //    name = "Giorgi",
            //    age = 20
            //};
            //giorgisObj.Walk();
            //giorgisObj.Talk();



            //Person elenesObj = new Person("Elene", 25); /*<--კონსტრუქტორი*/
            //elenesObj.Walk();
            //elenesObj.Talk();


            //Person davitisObj = new Person(33); /*<--კონსტრუქტორი*/
            //davitisObj.name = "Daviti";

            //davitisObj.Walk();
            //davitisObj.Talk();




            //Console.WriteLine($"{nikasObj.name} {nikasObj.age}");
            //Console.WriteLine($"{giorgisObj.name} {giorgisObj.age}");





            /*
             
            let obj1 = {name:"Nika",age:12},

            [
                {name:"Nika",age:12},
                {name:"Giorgi",age:13},
                {name:"Elene",age:45}
            ] 


                        //try
            //{

            //    Client mariam = new Client()
            //    {
            //        FirstName = "Mariam",
            //        LastName = "Pankelashvii",
            //        PersonalNumber = "12345678945",
            //        Account = new Account()
            //        {
            //            Iban = "1234567894512345678945",
            //            Balance = 1100,
            //            Currency = "USD"
            //        }
            //    };

            //    mariam.Withdraw(50000);


            //    Client tornike = new();
            //    tornike.FirstName = "Tornike";
            //    tornike.LastName = "Brokishvili";
            //    tornike.PersonalNumber = "12345678942";
            //    tornike.Account = new Account()
            //    {
            //        Iban = "1234567894212345678942",
            //        Balance = 50,
            //        Currency = "USD"
            //    };

            //    //mariam.Transfer(50000, tornike.Account);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

             */


            //Animal animal1 = new Animal("Jeka");
            //Dog dog1 = new Dog("Simba");

            //Person person = new Person() { Name = "Nika" };
            //person.Talk();

            //Person student = new Student() { Name = "Giorgi" };
            //student.Talk();

            ////Person teacher = new Teacher() { Name = "Daviti" };

            //CsharpTeacher csTeacherObject = new();
            //csTeacherObject.Name = "";


            //SayHi(student);



            //!!!! არ გამოიყენოთ !!!!
            //object[] x = { 1, 2, 3, "asdasd", true, student };

            ////BOXING UNBOXING
            //object first = 1;
            //int xx = (int)first;


            #endregion



            Subject typeScript = new() { Name = "Typescript" };
            Subject angular = new() { Name = "Angular" };
            Subject react = new() { Name = "React" };


            Console.WriteLine(typeScript);
            Console.WriteLine(angular);
            Console.WriteLine(react);










            var teacherObj = new Teacher
            {
                FullName = "John Doe",
                Salary = 75000.00m,
                Subject = new Subject { Name = "Mathematics" }
            };


            var studentObj = new Student
            {
                FullName = "Jack Doe",
                Score = 100,
                Subject = new Subject { Name = "Mathematics" }
            };


            //პოლიმორფიზმი
            Console.WriteLine(teacherObj.Talk());
            Console.WriteLine(studentObj.Talk());



        }


        public static void SayHi(Person person) => Console.WriteLine($"Hello {person.FullName}");


    }
}
