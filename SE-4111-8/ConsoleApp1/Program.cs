﻿
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ლექცია 1
            //ტექსტური "Nika"
            // "asdasd"  'A' ???


            //რიცხვითი
            // მთელი , ათწილადი


            //ლოგიკური
            //true || false


            //Console.WriteLine("Nika");
            //Console.WriteLine('A');
            //Console.WriteLine(false);
            //Console.WriteLine(100);
            //Console.WriteLine(100.1);


            //string name = "Nika";
            //string name = Console.ReadLine();
            //string lastname = Console.ReadLine();


            //Console.WriteLine($"My name is: {name}");
            //Console.WriteLine("My name is: {0} {1}", name, lastname);
            //Console.WriteLine("My name is:" + name);

            //char firstSymbol = 'N';

            //byte age = 255;
            //sbyte age2 = -128;

            //short x = -1;
            //ushort x2 = 1;

            //int x = 12;
            //uint x2 = 12;

            //long x = 12;
            //long x2 = 12;

            //float x = 1.2f;
            //double y = 1.0;
            //decimal z = 2.2m;

            //bool x = true;





            //1.შექმენით კონსოლური აპლიკაცია

            //2.შექმენით სარეგისტრაციო ფორმა სადაც მომხმარებელს სთხოვთ მისი ინფორმაციის შემოყვანას კონსოლიდან შემდეგი ფორმატით:
            // FirstName: <-------- ინფორმაცია შემოდის კონსოლიდან
            // LastName: <-------- ინფორმაცია შემოდის კონსოლიდან
            // Age: <-------- ინფორმაცია შემოდის კონსოლიდან


            //3. ინფორმაცია დაბეჭდეთ კონსოლში შემდეგი ფორმატით:
            //Hello my name is {FirstName} {LastName} I am {Age} years old


            //Console.Write("FirstName: ");
            //string firstName = Console.ReadLine();

            //Console.Write("LastName: ");
            //string lastName = Console.ReadLine();

            //Console.Write("Age: ");
            //byte age = Convert.ToByte(Console.ReadLine());
            ////byte age = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age} years old"); 
            #endregion



            #region ლექცია 2
            //ტექსუტური: string = ""  char = ''
            //მთელი რიცხვები: (byte,sbyte) (short ushort) (int uint) (long ulong)
            //ათწილადი რიცხვები: float double decimal
            //ლოგიკური : bool


            //string x = "nia"; // ცვლადი
            //x = "nika";

            //const string x2 = "nia"; // კონსტანტა
            //x = "nika";


            //var name = 12; // არის დეველოპერის დამხმარე მინიჭება ხდება ტოლობის მარჯვინვ დწერილი მონაცმიდან გამომდინარე

            //ცხადი cast - explicit cast
            //არაცხადი cast - implicit cast
            //არითმეტიკული გადავსება - Arithmetical overflow

            //int x = 259;
            //long y = x; //implicit cast


            //მინიჭების ოპერატორი     =
            // შედარების ოპერატორები  == > < >= <= != 
            //არითმეტიკული           + - * /    += -= *= /=    ++ --
            //დამხმარე ოპერატორები    && - და     || - ან                               & |


            //Console.WriteLine(1 == 1); //True
            //Console.WriteLine(1 > 1); // False
            //Console.WriteLine(1 >= 1); // True
            //Console.WriteLine(1 <= 1); // True
            //Console.WriteLine(1 != 1); // False
            //
            //Console.WriteLine(1 + 1); // 2
            //Console.WriteLine(1 - 1); // 0
            //Console.WriteLine(1 / 1); // 1
            //Console.WriteLine(1 * 1); // 1

            //int x = 0;
            //x += 1; // x = x + 1
            //x -= 1; // x = x - 1
            //x *= 1; // x = x * 1
            //x /= 1; // x = x / 1
            //int y = x++; // 0
            //int y = ++x; // 1
            //int y = --x; // -1
            //int y = x--; // 0

            //if (10 > 20 || 15 % 2 != 0)
            //{
            //}


            //•	შექმენით სარეგისტრაციო  კონსოლური აპლიკაცია, 
            //    სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოს 
            //    ინფორმაცია საკუთარი თავის 
            //    შესახებ(სახელი, გვარი, პირადი ნომერი, ასაკი, სიმაღლე, წონა, არის თუ არა დაოჯახებული, 
            //        ჰყავს თუ არა ცხოველი) 
            //    კონსოლიდან შემოყვანილი ინფორმაცია დაიმახსოვრეთ შესაბამის ცვლადში 
            //    და საბოლოოდ მოახდინეთ ამ ინფორმაციის სრული რეზლიზება კონსოლში.


            //if (1 == 2)
            //{
            //    Console.WriteLine("1 udris 1");
            //}
            //else if (1 == 3)
            //{
            //    Console.WriteLine("1 udris 3");
            //}
            //else if (1 == 4)
            //{
            //    Console.WriteLine("1 udris 4");
            //}
            //else if (1 == 5)
            //{
            //    Console.WriteLine("1 udris 5");
            //}
            //else
            //{
            //    Console.WriteLine("yvela piroba mcdaria");
            //}

            //Console.Write("First name: ");
            //string firstName = Console.ReadLine();

            //Console.Write("Last name: ");
            //string lastName = Console.ReadLine();

            //Console.Write("Personal number: ");
            //string personalNumber = Console.ReadLine();

            //Console.Write("Age: ");
            //byte age = Convert.ToByte(Console.ReadLine());

            //Console.Write("Is married: [Y/N]");
            //char isMarried = char.Parse(Console.ReadLine());

            //Console.Write("Have pet: [Y/N]");
            //char havePet = char.Parse(Console.ReadLine());


            //if ((havePet == 'y' || havePet == 'Y') && (isMarried == 'y' || isMarried == 'Y'))
            //{
            //    Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age}, my personal number is {personalNumber} have family and have pet");
            //}
            //else if (havePet == 'y' || havePet == 'Y')
            //{
            //    Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age}, my personal number is {personalNumber} have pet");
            //}
            //else if (isMarried == 'y' || isMarried == 'Y')
            //{
            //    Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age}, my personal number is {personalNumber} have family");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello my name is {firstName} {lastName} I am {age}, my personal number is {personalNumber} dont' have family and pet");
            //} 
            #endregion



        }

    }
}
