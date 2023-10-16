using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.Exceptions
{
    public class PasswordNoUpperCaseException : Exception
    {
        public PasswordNoUpperCaseException() { }

        public PasswordNoUpperCaseException(string message) : base(message) { }

        public PasswordNoUpperCaseException(string message, Exception inner) : base(message, inner) { }
    }
}
