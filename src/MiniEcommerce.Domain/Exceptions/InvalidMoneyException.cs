using MiniEcommerce.Domain.Constants.Errors;

namespace MiniEcommerce.Domain.Exceptions
{
    public class InvalidMoneyException : BaseException
    {
        public InvalidMoneyException(MoneyErrorCodes errorCode) : base(errorCode) { }

        public class NegativeAmountException : InvalidMoneyException
        {
            public NegativeAmountException()
                : base(MoneyErrorCodes.NegativeAmount) { }
        }
    }
}
