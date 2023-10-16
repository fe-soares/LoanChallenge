using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.Exceptions
{
    public class PasswordNoSpecialCharException: Exception
    {
        public PasswordNoSpecialCharException() { }

        public PasswordNoSpecialCharException(string message) : base(message) { }

        public PasswordNoSpecialCharException(string message, Exception inner) : base(message, inner) { }
    }
}
