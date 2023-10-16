using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.Exceptions
{
    public class PasswordNoNumericException: Exception
    {
        public PasswordNoNumericException() { }

        public PasswordNoNumericException(string message) : base(message) { }

        public PasswordNoNumericException(string message, Exception inner) : base(message, inner) { }
    }
}
