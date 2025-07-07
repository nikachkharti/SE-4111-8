namespace LectureOOP.Exceptions
{
    public class InnsuficentFundsException : Exception
    {
        public InnsuficentFundsException(string message) : base(message) //<-- base გამოხატავას მშობლის კონსტრუქტორს, რომელსაც ვაწვდი მესიჯის ტექსტს
        {
        }

        public InnsuficentFundsException() : base()
        {
        }
    }
}
