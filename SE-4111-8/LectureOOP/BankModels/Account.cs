namespace LectureOOP.BankModels
{
    public class Account
    {
        private string iban;
        private string currency;
        private decimal balance;

        public string Iban
        {
            get { return iban; }
            set
            {
                if (value.Length == 22)
                {
                    iban = value;
                }
            }
        }

        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Length == 3)
                {
                    currency = value.ToUpper();
                }
            }
        }

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

    }
}
