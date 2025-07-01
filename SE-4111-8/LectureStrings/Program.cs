using System.Globalization;
using System.Text;

namespace LectureStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region STRING

            //string name = "Nikoloz Chkhartishvili";
            //string lastName = "CHKHARTISHVILI";
            //double x = 12.2;

            //string nameToUpper = name.ToUpper(); // ტექსტის მაღალ რეგისტრში გადააყვანა
            //string nameToLower = name.ToLower(); // ტექსტის დაბალ რეგისტრში გადააყვანა
            //int nameLength = name.Length; // ტექსტის ზომის გაგება

            //string fullName = name + " " + lastName; // ტექსტის გაერთიანება
            //string fullName = $"{name} {lastName}"; // ტექსტის გაერთიანება


            //ტექსტის გაერთიანება მოსახერხებელია მხოლოდ დიდი მოცულობის ტექსტებთან სამუშაოდ !!!
            //StringBuilder sb = new StringBuilder();
            //sb.Append(name);
            //sb.Append(" ");
            //sb.Append(lastName);

            //Console.WriteLine(sb);


            //Console.WriteLine(name == lastName); // ტექსტის შედარება
            //Console.WriteLine(name.Equals(lastName, StringComparison.OrdinalIgnoreCase)); // ტექსტის შედარება + case დაიგნორება
            //Console.WriteLine(name.Equals(lastName, StringComparison.InvariantCultureIgnoreCase)); // ტექსტის შედარება + კულტურის დაიგნორება

            //string subName = name.Substring(0, 4); // ქვეტექსტის ამოღება


            //string convertedX = x.ToString(); // ნებისმიერი მნიშვნელობის ტექსტად გარდაქმნა


            //string trimmedName = name.Trim(); // თავსა და ბოლოში დაწერილ სფეისებს დააიგნორებს
            //string trimmedName = name.TrimStart(); // თავში დაწერილ სფეისებს დააიგნორებს
            //string trimmedName = name.TrimEnd(); // ბოლოშ დაწერილ სფეისებს დააიგნორებს

            //string[] separatedInfo = name.Split(' '); // რაიმე პატერნით ტექსტის დახლეჩა


            //bool chkhExists = name.Contains("Chkh"); // ქვეტექსტის ძებნა ტექსტში


            //string replacedName = name.Replace('N', 'z'); // ტექსტის ჩანაცვლება
            //string replacedName = name.Replace("n", "z", StringComparison.OrdinalIgnoreCase); // ტექსტის ჩანაცვლება

            //var a = name.IndexOfAny(new char[] { 'N', 'o' }, 0); // ინდექსის ძებნა სტრინგში
            //var a = name.LastIndexOfAny(new char[] { 'N', 'o' }, 0); // ინდექსის ძებნა სტრინგში 
            #endregion


            #region CHAR
            //string name = "Nika";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char symbolOfText = name[i];
            //}

            //char symbol = 'Z'; // ---> Z 
            //int symbolIntValue = 'Z'; // ---> 90
            //var sum = '1' + '1'; // --> 98


            //Console.WriteLine(Char.IsDigit(symbol)); // ამოწმებს სიმბოლო არის თუ არა რიცხვითი
            //Console.WriteLine(Char.IsLetter(symbol)); // ამოწმებს სიმბოლო არის თუ არა ასო
            //Console.WriteLine(Char.IsUpper(symbol)); // ამოწმებს სიმბოლო არის თუ არა მაღალ რეგისტრში
            //Console.WriteLine(Char.IsLower(symbol)); // ამოწმებს სიმბოლო არის თუ არა დაბალ რეგისტრში

            //Console.WriteLine(Char.ToLower(symbol)); // z
            //Console.WriteLine(Char.ToUpper(symbol)); // z


            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.WriteLine($"Character: {c}, Unicode: {Convert.ToInt32(c)}");
            //}


            #endregion


            //var spaces = ContainsSymbol("Nika Chkartishivli", 'I');
        }


        //static int CountSymbols(string argument, char symbol)
        //{
        //    int spaces = 0;

        //    for (int i = 0; i < argument.Length; i++)
        //    {
        //        if (char.ToLower(argument[i]) == Char.ToLower(symbol))
        //            spaces++;
        //    }

        //    return spaces;
        //}

        //static bool ContainsSymbol(string argument, char symbol)
        //{
        //    return argument.Contains(symbol);

        //    //if (result)
        //    //    return true;
        //    //return false;


        //    //return result ? true : false; // ტერნარი
        //}

    }
}
