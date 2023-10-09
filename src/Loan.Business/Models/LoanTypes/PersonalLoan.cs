using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.LoanTypes
{
    public class PersonalLoan : MainLoan
    {
        public PersonalLoan(Client client)
        {
            if (client.Income < 3000)
            {
                Type = "PERSONAL";
                Interest_Rate = "4";
            }
            else if (client.Income >= 3000 && client.Income <= 5000 && client.Age < 30 && client.Location.Equals("SP"))
            {
                Type = "PERSONAL";
                Interest_Rate = "4";
            }
        }

        private bool IsPersonalLoan()
        {
            if (Type == "PERSONAL") return true;
            else return false;
        }

        public PersonalLoan? returnPersonalLoanForClient()
        {
            if (IsPersonalLoan()) return this;
            else return null;
        }
    }
}
