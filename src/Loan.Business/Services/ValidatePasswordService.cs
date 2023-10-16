using Loan.Business.Interfaces.IServices;
using Loan.Business.ServicesFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Services
{
    public class ValidatePasswordService: IValidatePasswordService
    {
        public ValidatePasswordService() { }

        public bool ValidatePassword(string password)
        {
            bool isPasswordValid = ValidatePasswordFunctions.HasPasswordMinCaractersLength(password) && 
                ValidatePasswordFunctions.HasAtleastOneUpperCaseLetter(password) &&
                ValidatePasswordFunctions.HasAtleastOneLowerCaseLetter(password) && 
                ValidatePasswordFunctions.HasNumeric(password) && 
                ValidatePasswordFunctions.HasSpecialCaracters(password);

            return isPasswordValid;
        }
    }
}
