using MiniEcommerce.Domain.Constants.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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