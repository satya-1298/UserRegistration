using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserRegistration;

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
            string res = "";
            try
            {
                if (Regex.IsMatch(name, FIRST_NAME))
                    res = "Valid first name";
            }
            catch (Exception ex)
            {
                throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME, "Invalid Firstname");
            }
            return res;

        }
        public string ValidateLastName(string name)
        {
            string res = "";
            try
            {
                if (Regex.IsMatch(name, LAST_NAME))
                    res = "Valid last name";
            }
            catch (Exception ex)
            {
                throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Invalid Lastname");
            }
            return res;
        }
        public string ValidateEmail(string eMail)
        {
            string res = "";
            try
            {
                if (Regex.IsMatch(eMail, E_MAIL))
                    res = "Valid email";
            }
            catch (Exception ex)
            {
                throw new UserException(UserException.ExceptionType.INVALID_EMAIL, "Invalid email");
            }
            return res;
        }
        public string ValidateMobileNumber(string number)
        {
            string res = "";
            try
            {
                if (Regex.IsMatch(number, MOBILE_NUMBER))
                    res = "Valid mobile number";
            }
            catch (Exception ex)
            {
                throw new UserException(UserException.ExceptionType.INVALID_MOBILENUMBER, "Invalid mobile number");
            }
            return res;
        }
        public string ValidatePassWord(string passWord)
        {
            string res = "";
            try
            {
                if (Regex.IsMatch(passWord, PASSWORD))
                    res = "Valid first name";
            }
            catch (Exception ex)
            {
                throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
            return res;
        }
    }
}
