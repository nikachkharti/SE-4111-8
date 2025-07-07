using LectureOOP.Exceptions;

namespace LectureOOP.BankModels
{
    public class Client
    {
        private string personalNumber;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account Account { get; set; }
        public string PersonalNumber
        {
            get { return personalNumber; }
            set
            {
                if (value.Length == 11)
                {
                    personalNumber = value;
                }
            }
        }


        public void Deposit(decimal amount)
        {
            Account.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Account.Balance >= amount)
            {
                Account.Balance -= amount;
            }
            else
            {
                throw new InnsuficentFundsException("ARASAKMARISI TANXA");
            }
        }

        public void Transfer(decimal amount, Account destination)
        {
            if (amount <= Account.Balance)
            {
                Account.Balance -= amount;
                destination.Balance += amount;
            }
            else
            {
                throw new InnsuficentFundsException("ARASAKMARISI TANXA");
            }
        }


        #region CLASSWORK
        //Property არის განსაკუთრებული ტიპი რომელიც ერთდროულად ფუნქციაცაა და field - იც.

        //private int age; // ენკაფსულაცია

        //AUTO PROPERTY
        //public string FullName { get; set; }


        //FULL PROPERTY
        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            age = value;
        //        }
        //    }
        //}



        //public void SetAge(int value)
        //{
        //    if (value > 0)
        //    {
        //        age = value;
        //    }
        //}
        //public int GetAge()
        //{
        //    return age;
        //} 
        #endregion


    }
}
