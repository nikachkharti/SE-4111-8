
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





        }

    }
}
