using Loan.Business.Interfaces.IServices;
using Loan.Business.Models;
using Loan.Business.Models.LoanTypes;
using Loan.Business.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Services
{
    public class LoanService: ILoanService
    {
        public LoanService() { }

        public ResponseServiceCustumerLoan GetAllLoansForClient(Client client)
        {
            ResponseServiceCustumerLoan loanObject = new ResponseServiceCustumerLoan();

            loanObject.Loans.Add(new PersonalLoan(client).returnPersonalLoanForClient());
            loanObject.Loans.Add(new ConsignmentLoan(client).returnConsignmentLoanForClient());
            loanObject.Loans.Add(new GuaranteedLoan(client).returnGuaranteedLoanForClient());

            loanObject.Loans = loanObject.Loans.Where(x => x != null).ToList();

            return loanObject;
        }
    }
}
