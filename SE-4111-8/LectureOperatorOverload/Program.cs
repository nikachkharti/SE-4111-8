namespace LectureOperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money firstMoney = new(100, "USD");
            Money secondMoney = new(25, "USD");

            var result1 = (firstMoney + secondMoney).ToString();
            var result2 = (firstMoney - secondMoney).ToString();
            var result3 = (firstMoney * secondMoney).ToString();
            var result4 = (firstMoney / secondMoney).ToString();

            string[] resultArray = [result1, result2, result3, result4];


            //File.WriteAllText("C:\\Users\\User\\Desktop\\IT STEP\\SE-4111-8\\SE-4111-8\\LectureOperatorOverload\\Files\\moneyResult.txt", result);
            //File.WriteAllText(@"../../../Files/moneyResult.txt", result);
            //File.WriteAllBytes(@"../../../Files/moneyResult.txt", resultArray);
            //File.AppendAllText(@"../../../Files/moneyResult.txt", $"{result}{Environment.NewLine}");
            //File.AppendAllText(@"../../../Files/moneyResult.txt", $"\n{result}");
            //File.AppendAllLines(@"../../../Files/moneyResult.txt", resultArray);
            //File.AppendAllBytes(@"../../../Files/moneyResult.txt", resultArray);


            //string result = File.ReadAllText(@"../../../Files/moneyResult.txt");
            //string[] result = File.ReadAllLines(@"../../../Files/moneyResult.txt");
            //byte[] result = File.ReadAllBytes(@"../../../Files/moneyResult.txt");


        }
    }
}
