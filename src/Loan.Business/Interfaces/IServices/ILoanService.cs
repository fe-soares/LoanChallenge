using Loan.Business.Models;
using Loan.Business.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Interfaces.IServices
{
    public interface ILoanService
    {
        ResponseServiceCustumerLoan GetAllLoansForClient(Client client);
    }
}
