namespace LectureOperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money firstMoney = new(50, "USD");
            Money secondMoney = new(25, "USD");

            //var a = firstMoney.CompareTo(secondMoney); //0  1  -1


            //+ - * /

            Console.WriteLine(firstMoney * secondMoney);

            //Console.WriteLine(1 + 1) => 2;
            //Console.WriteLine("1" + "1") => "11";

        }
    }
}
