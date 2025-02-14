namespace MiniEcommerce.Domain.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; init; }
        public Currencies Currency { get; init; }

        private Money() { } // EF Core'un kullanabileceği parametresiz constructor

        public Money(decimal amount, Currencies currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money From(decimal amount, Currencies currency)
        {
            var money = new Money(amount, currency);

            if (money.Amount < 0)
                throw new InvalidMoneyException.NegativeAmountException();

            return money;
        }

        public static Money USD(decimal amount) => From(amount, Currencies.USD);
        public static Money EUR(decimal amount) => From(amount, Currencies.EUR);
        public static Money GBP(decimal amount) => From(amount, Currencies.GBP);
        public static Money JPY(decimal amount) => From(amount, Currencies.JPY);
        public static Money TRY(decimal amount) => From(amount, Currencies.TRY);

        public static implicit operator string(Money money) => money.ToString();

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}