using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models.LoanTypes
{
    internal class ConsignmentLoan: MainLoan
    {
        public ConsignmentLoan(Client client)
        {
            if (client.Income >= 5000)
            {
                Type = "CONSIGNMENT";
                Interest_Rate = "2";
            }
        }

        private bool IsConsignmentLoan()
        {
            if (Type == "CONSIGNMENT") return true;
            else return false;
        }

        public ConsignmentLoan? returnConsignmentLoanForClient()
        {
            if (IsConsignmentLoan()) return this;
            else return null;
        }
    }
}
