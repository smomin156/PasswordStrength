using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrength
{
    public enum PassWordStrength
    {
        Blank,//blank password
        Weak,//only lowercase 
        Medium,//atleast one uppercase
        Strong,//atleast onedigit
        VeryStrong,// atleast one special char
    }
    static class PasswordCheck
    {
        public static PassWordStrength GetPasswordStrength(string password)
        {
            int strength = 0;
            //two main check
            if (String.IsNullOrEmpty(password))
            {
                throw new PasswordIsEmptyException("Password cannot be blank");
            }
            if (!(HasMinLength(password)))
            {
                throw new MinimumLengthException("Minimum Length Must be 6 characters");
            }
            strength++;
            strength += Convert.ToInt32(HasUpperCaseLetter(password));
            strength += Convert.ToInt32(HasDigit(password));
            strength += Convert.ToInt32(HasSpecialChar(password));

            return (PassWordStrength)strength;
        }


        #region CheckCodes
        public static bool HasMinLength(string password)
        {
            return password.Length >= 6;
        }
        public static bool HasUpperCaseLetter(string password)
        {
            return password.Any(char.IsUpper);
        }

        public static bool HasDigit(string password)
        {
            return password.Any(char.IsDigit);
        }
        public static bool HasSpecialChar(string password)
        {
            return password.IndexOfAny("!@#$%^&*?_~-£().,".ToCharArray()) != -1;
        }
        //public static bool HasLowerCaseLetter(string password)
        //{
        //    return password.Any(char.IsLower);
        //}
        #endregion
    }
}
