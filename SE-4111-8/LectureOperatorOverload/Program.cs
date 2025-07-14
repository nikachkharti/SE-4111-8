namespace LectureOperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money firstMoney = new(101, "USD");
            Money secondMoney = new(102, "EUR");

            //var a = firstMoney.CompareTo(secondMoney); //0  1  -1


            //+ - * /

            Console.WriteLine(firstMoney + secondMoney);

            //Console.WriteLine(1 + 1) => 2;
            //Console.WriteLine("1" + "1") => "11";

        }
    }
}
