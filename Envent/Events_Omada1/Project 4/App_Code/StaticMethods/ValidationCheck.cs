using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_4.App_Code.StaticMethods
{
    public static class ValidationCheck
    {

        public static bool EmailIsValid(string emailaddress)
        {
                var valid = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
                if (valid.IsMatch(emailaddress))    
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public static bool PasswordIsValid(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]");
            var hasMinimum8Chars = new Regex(@".{8,}");

            if(hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password)&& hasLowerChar.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ConfirmPasswordIsValid(string password1,string password2)
        {
            if (password1 == password2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckUserName(String userName)
        {
            enventDataSetTableAdapters.userTableAdapter checkUserName = new enventDataSetTableAdapters.userTableAdapter();
            return Convert.ToBoolean(checkUserName.tryLogInAsUser(userName));
        }

        public static bool CheckEmail(String email)
        {
            enventDataSetTableAdapters.userTableAdapter check = new enventDataSetTableAdapters.userTableAdapter();
            return Convert.ToBoolean(check.checkEmail(email));
        }
    }
}
