using MiniEcommerce.Domain.Constants.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
