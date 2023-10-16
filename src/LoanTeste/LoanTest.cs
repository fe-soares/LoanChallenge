using Loan.Business.Interfaces.IServices;
using Loan.Business.Models;
using Loan.Business.Models.LoanTypes;
using Loan.Business.ResponseModel;
using Loan.Business.Services;

namespace TestProject
{
    public class LoanTest
    {
        private readonly ILoanService _loanService;
        public LoanTest()
        {
            _loanService = new LoanService();
        }

        [Fact]
        public void Post_testPersonalConditionOne()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 3000.00,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("PERSONAL"));
            if(loan != null)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void Post_testPersonalConditionTwo()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 3000.50,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("PERSONAL"));
            if (loan != null)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void Post_testCONSIGNMENTConditionOne()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 5005,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("CONSIGNMENT"));
            if (loan != null)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void Post_testGUARANTEEDConditionOne()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 1000,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("GUARANTEED"));
            if (loan != null)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void Post_testGUARANTEEDConditionTwo()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 4000,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("GUARANTEED"));
            if (loan != null)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void Post_testCONSIGNMENTConditionTwo()
        {
            Client client = new Client()
            {
                Age = 26,
                Cpf = "275.484.389-23",
                Name = "Vuxaywua Zukiagou",
                Income = 10000,
                Location = "SP"
            };

            ResponseServiceCustumerLoan response = _loanService.GetAllLoansForClient(client);
            MainLoan? loan = response.Loans.Find(x => x.Type.Equals("CONSIGNMENT"));
            if (loan != null)
            {
                Assert.True(true && response.Loans.Count() == 1);
            }
            else
            {
                Assert.True(false);
            }
        }
    }
}