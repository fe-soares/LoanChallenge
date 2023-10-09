using Loan.Business.Models.LoanTypes;
using System.Collections;

namespace Loan.Business.ResponseModel
{
    public class ResponseServiceCustumerLoan
    {
        public string Customer { get; set; }
        public List<MainLoan?> Loans { get;set;} = new List<MainLoan?>();
    }


}
