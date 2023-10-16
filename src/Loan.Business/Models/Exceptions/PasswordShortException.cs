using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.Exceptions
{
    public class PasswordShortException: Exception
    {
        public PasswordShortException() { }

        public PasswordShortException(string message):base(message) { }

        public PasswordShortException(string message, Exception inner) : base(message, inner) { }
    }
}
