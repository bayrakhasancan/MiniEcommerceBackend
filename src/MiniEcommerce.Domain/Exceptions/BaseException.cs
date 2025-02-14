using MiniEcommerce.Domain.Constants.Errors;

namespace MiniEcommerce.Domain.Exceptions
{
    public abstract class BaseException : Exception
    {
        protected BaseException(MoneyErrorCodes errorCode)
            : base(errorCode.ToString())
        {
        }
    }
}