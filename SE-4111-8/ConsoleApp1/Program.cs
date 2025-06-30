
using System;
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


            #region ლექცია 3


            ////შეამოაყვანინეთ ერთი რიცხვი კონსოლიდან
            //Console.Write("First Number: ");
            //int firstNumber = int.Parse(Console.ReadLine());

            ////შეამოაყვანინეთ მეორე რიცხვი კონსოლიდან
            //Console.Write("Second Number: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            ////შეამოაყვანინეთ ოპერაცია კონსოლიდან
            //Console.Write("[+ - * /]");
            //char operation = char.Parse(Console.ReadLine());


            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //        break;
            //    default:
            //        break;
            //}




            //შეამოწმეთ გადმოცემული პირობები და დაბეჭდეთ შესაბამისი შედეგი კონსოლში
            //გამოიყენეთ switch case









            //int number = int.Parse(Console.ReadLine());

            //ტერნარი
            //int result =
            //    number % 2 == 0
            //    ? number
            //    : -1;


            //int x = default;

            //if (number % 2 == 0)
            //{
            //    x = number;
            //}
            //else
            //{
            //    x = -1;
            //}


            //Console.Write("[1-7]");
            //byte day = byte.Parse(Console.ReadLine());


            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Satuarday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Satuarday");
            //        break;
            //    default:
            //        Console.WriteLine("Incorrect day");
            //        break;
            //}




            //აეიოუ
            //char character = char.Parse(Console.ReadLine());

            //switch (character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}


            //switch (character)
            //{
            //    case 'a':
            //        Console.WriteLine("Vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("Vowel");
            //        break;
            //    case 'i':
            //        Console.WriteLine("Vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine("Vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}




            //if (character == 'a')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if(character == 'e')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if(character == 'i')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if(character == 'o')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if(character == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}



            //if
            //(
            //    character == 'a' ||
            //    character == 'e' ||
            //    character == 'i' ||
            //    character == 'o' ||
            //    character == 'u' ||
            //    character == 'A' ||
            //    character == 'E' ||
            //    character == 'I' ||
            //    character == 'O' ||
            //    character == 'U'
            //)
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}





            //2.ლოგინის ვალიდაცია: ააწყეთ ლოგინის ფორმა სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოთ email და პაროლი.
            //    თქვენი დავალებაა რომ შემოყვანილი email და პროლი იყოს ვალიდური, მაგალითად email 
            //    შეიცავდეს შესაბამის სიმბოლოებს, 
            //    და პაროლი შეიცავდეს დიდ/ 
            //    პატარა ასოებს რიცხვებს და სპეციალურ სიმბოლოებს, აპლიკაციის რეალიზება უნდა მოხდეს კონსოლში.



            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());
            //char operation = char.Parse(Console.ReadLine());

            //if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
            //{
            //    Console.WriteLine("GOOD");
            //}






            //Console.Write("Email: ");
            //string email = Console.ReadLine();

            //Console.Write("Password: ");
            //string password = Console.ReadLine();


            //if (email.Contains('@') && email.Contains('.') && password.Any(x=>x))
            //{
            //    Console.WriteLine($"Email: {email}, Password: {password}");
            //}


            #endregion


            #region ლექცია 4

            //while(3) | do while(4) | for(2) | foreach (1)


            //int i = 0;

            //while (i < 3)
            //{
            //    Console.WriteLine("NIKA");
            //    i++;
            //}


            //int i = 0;

            //do
            //{
            //    Console.WriteLine("NIKA");
            //    i++;
            //}
            //while (i <= 3);


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("NIKA");
            //}


            //int[] ar = [1, 2, 3];
            //foreach (var item in ar)
            //{
            //    Console.Write(item);
            //}






            //1.Print numbers from 1 to 10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //2.Print even numbers from 1 to 20

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 0; i <= 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}



            //3.Sum of numbers from 1 to 100

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);



            //TODO 4.Factorial of number



            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //    {
            //        //break;
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}");
            //    }
            //}




            //დავალება 1: ლუწი რიცხვების ჩვენება სწორ დიაპაზონში

            //Console.Write("First Number: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Second Number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //if (number2 < number1)
            //{
            //    int temp = number2;
            //    number2 = number1;
            //    number1 = temp;
            //}


            //for (int i = number1; i <= number2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Console.WriteLine(); // ახალ ხაზზე გადასვლა





            //დავალება 2: ნახევარ პირამიდა *-ებით

            //int rows = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //დავალება 3: ციფრებით შექმნილი პირამიდა
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }

            //    Console.WriteLine();
            //}




            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 10;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            #endregion


            #region ლექცია 5

            //Exception - გამონაკლისი



            //1.ექსეფშენის დამუშავება try catch ის გამოყენებით
            //try
            //{
            //    // წერ კოდს სადაც პოტენციურად ელოდები exception  - ს

            //    int firstNumber = 10;
            //    int secondNumber = 0;

            //    int result = firstNumber / secondNumber;
            //}
            //catch(DivideByZeroException divideByzeroException)
            //{
            //    // წერ ლოგიკას რა მოხდეს იმ შემთხვევაში თუ exception მოხდა
            //    Console.WriteLine(divideByzeroException.Message);
            //}




            //2.ექსეფშენის გასროლის ლოგიკა throw new - ს გამოყენებით
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 1 && number <= 7)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    throw new ArgumentOutOfRangeException("Argument must be between 1 to 7");
            //}



            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number >= 1 && number <= 7)
            //    {
            //        if (number == 5)
            //        {
            //            throw new ArgumentException("Number can't be 5");
            //        }

            //        Console.WriteLine("OK");
            //    }
            //    else
            //    {
            //        throw new ArgumentOutOfRangeException("Argument must be between 1 to 7");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Sorry but {ex.Message}");
            //}
            //catch (ArgumentException argumentException)
            //{
            //    Console.WriteLine($"Sorry but {argumentException.Message}");
            //}
            //catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            //{
            //    Console.WriteLine($"Sorry but {argumentOutOfRangeException.Message}");
            //}





            //1.წინა გაკვეთილზე დაწყებული დავალება, კონსოლური კალკულატორი გადააკეთეთ იმგვარად რომ აპლიკაციის მუშაობა არ იყოს ერთჯერადი (იყოს სულ გაშვებული)
            //2.აპლიკაციას X ღილაკის შემოყვანის შემთხვევაში უნდა ჰქონდეს გათიშვის ფუნქცია
            //3.არასწორი Input - ების ვალიდაცია არის სავალდებულო Exception - ების გამოყენებით.


            //while (true)
            //{
            //    Console.Write("First number: ");
            //    if (!int.TryParse(Console.ReadLine(), out var firstNumber))
            //        continue;

            //    Console.Write("Second number: ");
            //    if (!int.TryParse(Console.ReadLine(), out var secondNumber))
            //        continue;

            //    Console.Write("[+ - * /]: ");
            //    if (!char.TryParse(Console.ReadLine(), out var operation))
            //        continue;


            //    switch (operation)
            //    {
            //        case '+':
            //            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //            break;
            //        case '/':
            //            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //            break;
            //    }

            //    Console.Write("Exit: [X] ");
            //    char.TryParse(Console.ReadLine(), out var exit);

            //    if (exit == 'X')
            //        break;
            //}





            #endregion


            #region ლექცია 6


            //int[] ar = new int[3] { 11, 22, 33, };

            //int[] ar = new int[3];
            //ar[0] = 11;
            //ar[1] = 22;
            //ar[2] = 33;



            //int[] ar = { 11, 12, 33 };


            //int[] ar = [11, 12, 33, 44];


            //string firstPersonName = "Nika";
            //string[] names = [firstPersonName, "asd"];


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(ar[i]);
            //}


            //Console.WriteLine(ar[0]);
            //Console.WriteLine(ar[1]);
            //Console.WriteLine(ar[2]);



            //int[] array = [10, 5, 3, 4, 18];

            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[j] < array[i])
            //        {
            //            int t = array[j];
            //            array[j] = array[i];
            //            array[i] = t;
            //        }
            //    }
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //int min = array[0];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}



            #endregion


        }




    }
}
