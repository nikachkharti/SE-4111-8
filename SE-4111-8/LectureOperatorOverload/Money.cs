namespace LectureOperatorOverload
{
    public class Money : IComparable<Money>
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            var amountSum = first.Amount + second.Amount;
            return new Money(amountSum, first.Currency);
        }
        public static Money operator -(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            var amountSum = first.Amount - second.Amount;
            return new Money(amountSum, first.Currency);
        }
        public static Money operator *(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            var amountSum = first.Amount * second.Amount;
            return new Money(amountSum, first.Currency);
        }
        public static Money operator /(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            var amountSum = first.Amount / second.Amount;
            return new Money(amountSum, first.Currency);
        }
        public static bool operator ==(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount == second.Amount;
        }
        public static bool operator !=(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount != second.Amount;
        }
        public static bool operator >(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount > second.Amount;
        }
        public static bool operator <(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount < second.Amount;
        }
        public static bool operator >=(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount >= second.Amount;
        }
        public static bool operator <=(Money first, Money second)
        {
            ValidateSameCurrency(first, second);
            return first.Amount <= second.Amount;
        }


        public override string ToString() => $"{Amount} {Currency}";


        public int CompareTo(Money other)
        {
            ValidateSameCurrency(other);
            return Amount.CompareTo(other.Amount);
        }


        private void ValidateSameCurrency(Money other)
        {
            if (Currency != other.Currency)
            {
                throw new InvalidOperationException("Can't work with different currencies");
            }
        }
        private static void ValidateSameCurrency(Money money1, Money money2)
        {
            if (money1.Currency != money2.Currency)
            {
                throw new InvalidOperationException("Can't work with different currencies");
            }
        }


    }
}
