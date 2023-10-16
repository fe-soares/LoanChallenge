using Loan.Business.Interfaces.IServices;
using Loan.Business.Models.LoanTypes;
using Loan.Business.Models;
using Loan.Business.ResponseModel;
using Loan.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loan.Business.Models.Exceptions;

namespace LoanTeste
{
    public class PasswordTest
    {
        public readonly IValidatePasswordService validatePasswordService;
        public PasswordTest() 
        {
            validatePasswordService = new ValidatePasswordService();
        }

        [Fact]
        public void Post_testPasswordValid()
        {
            string password = "Ter2o12#@";

            bool response = validatePasswordService.ValidatePassword(password);
            Assert.True(response);
        }

        [Fact]
        public void Post_NonNumericPasswordValid()
        {
            string password = "SouLindo#@";

            Exception exception = Assert.Throws<PasswordNoNumericException>(() => validatePasswordService.ValidatePassword(password));
            Assert.IsType<PasswordNoNumericException>(exception);
        }

        [Fact]
        public void Post_NonUpperCasePasswordValid()
        {
            string password = "soulindo#@";

            Exception exception = Assert.Throws<PasswordNoUpperCaseException>(() => validatePasswordService.ValidatePassword(password));
            Assert.IsType<PasswordNoUpperCaseException>(exception);
        }

        [Fact]
        public void Post_NonLowCasePasswordValid()
        {
            string password = " SOULINDO#@";

            Exception exception = Assert.Throws<PasswordNoLowerCaseException>(() => validatePasswordService.ValidatePassword(password));
            Assert.IsType<PasswordNoLowerCaseException>(exception);
        }

        [Fact]
        public void Post_NonPasswordTooShortValid()
        {
            string password = "kap";

            Exception  exception = Assert.Throws<PasswordShortException>(() => validatePasswordService.ValidatePassword(password));
            Assert.IsType<PasswordShortException>(exception);
        }

        [Fact]
        public void Post_NonSpecialCaracterPasswordValid()
        {
            string password = "Soulindo34";

            Exception exception = Assert.Throws<PasswordNoSpecialCharException>(() => validatePasswordService.ValidatePassword(password));
            Assert.IsType<PasswordNoSpecialCharException>(exception);
        }
    }
}
