namespace LectureEvents
{
    public class Player // PUBLISHER
    {
        #region LESS IDIOMATIC
        //public int TotalPoints { get; private set; }
        //public event Action<int> AchivementUnlocked;

        //public void AddPoints(int points)
        //{
        //    TotalPoints += points;
        //    Console.WriteLine($"Player earned {points} points. Total points: {TotalPoints}");
        //    Thread.Sleep(1000);

        //    if (TotalPoints >= 100)
        //        AchivementUnlocked?.Invoke(TotalPoints);
        //}
        #endregion


        #region MORE IDIOMATIC

        public int TotalPoints { get; private set; }
        public event EventHandler<int> AchivementUnlocked;

        public void AddPoints(int points)
        {
            TotalPoints += points;
            Console.WriteLine($"Player earned {points} points. Total points: {TotalPoints}");
            Thread.Sleep(1000);

            if (TotalPoints >= 100)
                AchivementUnlocked?.Invoke(this, TotalPoints);
        }

        #endregion
    }


    public class ConsoleSubscriber // SUBSCRIBER || CONSUMER
    {
        #region LESS IDIOMATIC
        //public void OnAchivementUnlocked(int points)
        //{
        //    Console.WriteLine($"Congratulations, you win, your final score is {points}");
        //}
        #endregion


        #region MORE IDIOMATIC
        public void OnAchivementUnlocked(object sender, int points)
        {
            Console.WriteLine($"Congratulations, you win, your final score is {points}");
        }
        #endregion
    }


    public class FileSubscriber // SUBSCRIBER || CONSUMER
    {
        #region LESS IDIOMATIC
        //public void OnAchivementUnlocked(int points)
        //{
        //    const string filePath = @"../../../Game.txt";
        //    File.AppendAllText(filePath, $"Congratulations youn win, your final score is {points}");
        //}
        #endregion


        #region MORE IDIOMATIC
        public void OnAchivementUnlocked(object sender, int points)
        {
            const string filePath = @"../../../Game.txt";
            File.AppendAllText(filePath, $"Congratulations youn win, your final score is {points}");
        }
        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleSubscriber cs = new ConsoleSubscriber();
            FileSubscriber fs = new FileSubscriber();

            Player player1 = new();
            player1.AchivementUnlocked += cs.OnAchivementUnlocked;
            player1.AchivementUnlocked += fs.OnAchivementUnlocked;

            player1.AddPoints(30);
            player1.AddPoints(40);
            player1.AddPoints(35);


            player1.AchivementUnlocked -= cs.OnAchivementUnlocked;
            player1.AchivementUnlocked -= fs.OnAchivementUnlocked;
        }
    }
}
