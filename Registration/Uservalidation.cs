using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class UserValidation
    {
        public static string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string E_MAIL = "^[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][]A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILE_NUMBER = "[+]{1}[1-9]{2}[' '][6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";
        public string ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, FIRST_NAME))
                return "Valid first name";
            return "Inalid first name";
        }
        public string ValidateLastName(string name)
        {
            if (Regex.IsMatch(name, LAST_NAME))
                return "Valid Last name";
            return "Inalid Last name";
        }
        public string ValidateEmail(string eMail)
        {
            foreach (var m in eMail)
            {
                if (Regex.IsMatch(eMail, E_MAIL))
                    return "Valid email";
                return "Inalid email";
            }
            return "";
        }
        public string ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER))
                return "Valid mobile number";
            return "Inalid mobile number";
        }
        public string ValidatePassWord(string passWord)
        {
            if (Regex.IsMatch(passWord, PASSWORD))
                return "Valid password";
            return "Inalid password";
        }

    }
}