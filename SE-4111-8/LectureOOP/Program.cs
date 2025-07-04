using LectureOOP.BankModels;

namespace LectureOOP
{

    //•	საშინაო: დაწერეთ ანგარიშს კლასი, რომელსაც ექნება
    //•	ანგარიშის ნომერი(22 ნიშნა)
    //•	ვალუტა(სამნიშნა)
    //•	ბალანსი(არ უნდა იყოს უარყოფითი)

    //•	დაწერეთ კლიენტის კლასი, რომელსაც ექნება
    //•	სახელი
    //•	გვარი
    //•	პირადი ნომერი(11 ნიშნა)
    //•	ანგარიში

    //მოახდინეთ თქვენს მიერ შექმნილი კლასების დემონსტრირება კონსოლში.



    //OOP პრინციპები:

    //1. ენკაფსულაცია ნიშნავს გარკვეული ფუნქციონალის დაფარვას უსაფრთხოების მიზნით +
    //2. მემკვიდრეობა
    //3. აბსტრაქცია
    //4. პოლიმორფიზმი


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

             */


            Client mariam = new Client()
            {
                FirstName = "Mariam",
                LastName = "Pankelashvii",
                PersonalNumber = "12345678945",
                Account = new Account()
                {
                    Iban = "1234567894512345678945",
                    Balance = 1100,
                    Currency = "USD"
                }
            };


            Client tornike = new();
            tornike.FirstName = "Tornike";
            tornike.LastName = "Brokishvili";
            tornike.PersonalNumber = "12345678942";
            tornike.Account = new Account()
            {
                Iban = "1234567894212345678942",
                Balance = 50,
                Currency = "USD"
            };






            #endregion







        }
    }
}
