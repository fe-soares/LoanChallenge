using Loan.Business.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Loan.Business.ServicesFunctions
{
    public static class ValidatePasswordFunctions
    {
        public static bool IsStringValid(string password)
        {
            return !string.IsNullOrEmpty(password);
        }
        public static bool HasPasswordMinCaractersLength(string password)
        {
            if(password.Length >= 8) return true;
            throw new PasswordShortException("Senha muito curta");
        }

        public static bool HasAtleastOneUpperCaseLetter(string password)
        {
            if(password.Any(char.IsUpper))
                return true;
            throw new PasswordNoUpperCaseException("Sem carater maiusculo");
        }

        public static bool HasAtleastOneLowerCaseLetter(string password)
        {
            if (password.Any(char.IsLower))
                return true;
            throw new PasswordNoLowerCaseException("Sem caracter minusculo");
        }

        public static bool HasNumeric(string password)
        {
            if (password.Any(char.IsDigit))
                return true;
            throw new PasswordNoNumericException("Sem caracter numerico");
        }

        public static bool HasSpecialCaracters(string password)
        {
            bool hasSpecialCaracter = password.Any(c => !char.IsLetterOrDigit(c));

            if (hasSpecialCaracter)
            {
                return true;
            }
            throw new PasswordNoSpecialCharException("Sem caracter Especial");
        }
    }
}
