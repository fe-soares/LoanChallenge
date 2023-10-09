using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.LoanTypes
{
    public class GuaranteedLoan : MainLoan
    {
        public GuaranteedLoan(Client client)
        {
            if (client.Income <= 3000)
            {
                Type = "GUARANTEED";
                Interest_Rate = "3";
            }
            else if (client.Income >= 3000 && client.Income <= 5000 && client.Age < 30 && client.Location.Equals("SP"))
            {
                Type = "GUARANTEED";
                Interest_Rate = "3";
            }
        }

        private bool IsGuaranteedLoan()
        {
            if (Type == "GUARANTEED") return true;
            else return false;
        }

        public GuaranteedLoan? returnGuaranteedLoanForClient()
        {
            if (IsGuaranteedLoan()) return this;
            else return null;
        }
    }
}
