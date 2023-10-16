using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.Exceptions
{
    public class PasswordNoLowerCaseException: Exception
    {
        public PasswordNoLowerCaseException() { }

        public PasswordNoLowerCaseException(string message) : base(message) { }

        public PasswordNoLowerCaseException(string message, Exception inner) : base(message, inner) { }
    }
}
